using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Text;
using System.Threading;

namespace ZdtMotorGui
{
    /// <summary>
    /// ZDT 电机的 485 通信（原来拆成 ZdtBus + ZdtMotor 两个类，现在合成一个文件）。
    ///
    /// 帧格式：地址 + 功能码 + 数据 + 0x6B。
    /// 两台电机共用一条总线，所以所有收发都加锁排队。
    /// 有些 USB 转 485 适配器会回显自己发出的字节，读应答时在数据里找
    /// 最后一帧完整的“地址 + 功能码 + … + 0x6B”，可以自动跳过回显。
    /// </summary>
    public sealed class ZdtLink : IDisposable
    {
        private readonly object _io = new object(); // 串口读写锁，两台电机共用一条总线
        private SerialPort _port;                   // 实际打开的串口对象

        /// <summary>帧尾校验字节，默认 0x6B，调试窗口里可以改。</summary>
        public byte Checksum = 0x6B;

        /// <summary>收发帧跟踪，界面勾选“显示通信帧”时会输出到日志。</summary>
        public event Action<string> Trace;

        /// <summary>串口是否已经打开。</summary>
        public bool IsOpen
        {
            get
            {
                SerialPort p = _port;
                return p != null && p.IsOpen;
            }
        }

        /// <summary>当前串口名，例如 COM3；未打开时返回空字符串。</summary>
        public string PortName
        {
            get
            {
                SerialPort p = _port;
                return p == null ? "" : p.PortName;
            }
        }

        /// <summary>打开串口：8 数据位、无校验、1 停止位，并清空收发缓冲。</summary>
        public void Open(string portName, int baudRate)
        {
            lock (_io)
            {
                CloseInternal();
                SerialPort p = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
                p.Handshake = Handshake.None;
                p.ReadTimeout = 100;
                p.WriteTimeout = 300;
                p.Open();
                p.DiscardInBuffer();
                p.DiscardOutBuffer();
                _port = p;
            }
        }

        /// <summary>关闭串口，任何异常都吞掉，避免退出程序时崩。</summary>
        public void Close()
        {
            lock (_io)
            {
                CloseInternal();
            }
        }

        /// <summary>内部关闭：先 Close 再 Dispose，最后把引用置空。</summary>
        private void CloseInternal()
        {
            if (_port == null) return;
            try
            {
                if (_port.IsOpen) _port.Close();
            }
            catch { }
            try { _port.Dispose(); } catch { }
            _port = null;
        }

        // ==================== 运动命令 ====================

        // 使能：地址 F3 AB 01/00 00 6B
        public void Enable(byte address, bool enable)
        {
            SendRaw(address, new byte[] { 0xF3, 0xAB, (byte)(enable ? 1 : 0), 0x00 });
        }

        // 相对定位：地址 FD 方向 速度(2B) 加速度 脉冲(4B) 00 00 6B
        // 所有定位和点动都发“相对上一次目标”的增量，软件自己累计位置。
        public void MoveRelative(byte address, int pulses, int rpm, byte acc)
        {
            byte dir = (byte)(pulses < 0 ? 1 : 0);
            uint p = (uint)Math.Abs((long)pulses);
            if (rpm < 1) rpm = 1;
            if (rpm > 3000) rpm = 3000;
            SendRaw(address, new byte[]
            {
                0xFD, dir,
                (byte)(rpm >> 8), (byte)rpm, acc,
                (byte)(p >> 24), (byte)(p >> 16), (byte)(p >> 8), (byte)p,
                0x00, 0x00
            });
        }

        // 立即停止：地址 FE 98 00 6B
        public void Stop(byte address)
        {
            SendRaw(address, new byte[] { 0xFE, 0x98, 0x00 });
        }

        // 当前位置清零（不保存）：地址 0A 6D 6B
        public void ClearPosition(byte address)
        {
            SendRaw(address, new byte[] { 0x0A, 0x6D });
        }

        // 把当前位置设为单圈零点并掉电保存：地址 93 88 01 6B
        public void SaveZero(byte address)
        {
            SendRaw(address, new byte[] { 0x93, 0x88, 0x01 });
        }

        // 触发回零：地址 9A 模式 00 6B（模式 0~4）
        public void StartHome(byte address, byte mode)
        {
            SendRaw(address, new byte[] { 0x9A, mode, 0x00 });
        }

        // 中止回零：地址 9C 48 6B
        public void AbortHome(byte address)
        {
            SendRaw(address, new byte[] { 0x9C, 0x48 });
        }

        // 解除堵转保护：地址 0E 52 6B
        public void ResetStall(byte address)
        {
            SendRaw(address, new byte[] { 0x0E, 0x52 });
        }

        // ==================== 读取命令 ====================

        // 读状态：地址 3A 6B -> 地址 3A 状态 6B
        // bit0 使能 / bit1 到位 / bit3 堵转 / bit7 掉电
        public bool ReadStatus(byte address, out byte status, int timeoutMs = 60)
        {
            status = 0;
            byte[] rx = new byte[4];
            if (!Query(address, 0x3A, 4, rx, timeoutMs)) return false;
            status = rx[2];
            return true;
        }

        // 读单圈编码器：地址 36 6B -> 地址 36 符号 位置(4B) 6B
        // 一圈 65536 个计数，返回 0~65535；符号字节 1 表示负数。
        public bool ReadEncoder(byte address, out int encoder, int timeoutMs = 80)
        {
            encoder = 0;
            byte[] rx = new byte[8];
            if (!Query(address, 0x36, 8, rx, timeoutMs)) return false;
            uint value = ((uint)rx[3] << 24) | ((uint)rx[4] << 16) | ((uint)rx[5] << 8) | rx[6];
            encoder = rx[2] == 0x01 ? -(int)value : (int)value;
            return true;
        }

        // 读回零状态：地址 3B 6B -> 地址 3B 状态 6B
        // bit2 正在回零 / bit3 回零失败 / 两位都为 0 表示完成
        public bool ReadHomeStatus(byte address, out byte status, int timeoutMs = 60)
        {
            status = 0;
            byte[] rx = new byte[4];
            if (!Query(address, 0x3B, 4, rx, timeoutMs)) return false;
            status = rx[2];
            return true;
        }

        // ==================== 底层收发 ====================

        // 发一条“地址 + 功能码 + 数据 + 校验字节”，不等应答
        public void SendRaw(byte address, byte[] body)
        {
            lock (_io)
            {
                SerialPort p = _port;
                if (p == null || !p.IsOpen) throw new InvalidOperationException("串口未打开");

                byte[] frame = new byte[body.Length + 2];
                frame[0] = address;
                Array.Copy(body, 0, frame, 1, body.Length);
                frame[frame.Length - 1] = Checksum;

                p.Write(frame, 0, frame.Length);
                RaiseTrace("TX " + ToHex(frame));
            }
        }

        // 发“地址 + 功能码 + 校验字节”，并等一帧完整应答
        private bool Query(byte address, byte code, int totalLength, byte[] result, int timeoutMs)
        {
            byte[] tx = new byte[] { address, code, Checksum };
            return QueryRaw(tx, address, code, totalLength, result, timeoutMs);
        }

        /// <summary>发送任意帧并等待固定长度的应答（用于 0x42 0x6C 这类带辅助码的命令）。</summary>
        public bool QueryRaw(byte[] tx, byte address, byte code, int totalLength, byte[] result, int timeoutMs)
        {
            lock (_io)
            {
                SerialPort p = _port;
                if (p == null || !p.IsOpen) return false;
                try
                {
                    p.DiscardInBuffer();
                    p.Write(tx, 0, tx.Length);
                    RaiseTrace("TX " + ToHex(tx));

                    List<byte> rx = new List<byte>(totalLength * 2 + 4);
                    Stopwatch sw = Stopwatch.StartNew();
                    while (sw.ElapsedMilliseconds < timeoutMs)
                    {
                        if (p.BytesToRead > 0)
                        {
                            rx.Add((byte)p.ReadByte());
                            if (TakeFrame(rx, address, code, totalLength, result))
                            {
                                RaiseTrace("RX " + ToHex(result));
                                return true;
                            }
                        }
                        else
                        {
                            Thread.Sleep(1);
                        }
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 读长度不固定的应答（0x42 驱动参数、0x43 系统状态、0x21 PID 等）：
        /// 收到数据后等 30ms 没有新字节就认为一帧结束，再按“地址+功能码”对齐。
        /// </summary>
        public bool ReadVariable(byte[] tx, byte address, byte code, out byte[] frame, int timeoutMs = 250)
        {
            frame = null;
            lock (_io)
            {
                SerialPort p = _port;
                if (p == null || !p.IsOpen) return false;
                try
                {
                    p.DiscardInBuffer();
                    p.Write(tx, 0, tx.Length);
                    RaiseTrace("TX " + ToHex(tx));

                    List<byte> rx = new List<byte>(128);
                    Stopwatch sw = Stopwatch.StartNew();
                    int quiet = 0;
                    while (sw.ElapsedMilliseconds < timeoutMs)
                    {
                        if (p.BytesToRead > 0)
                        {
                            rx.Add((byte)p.ReadByte());
                            quiet = 0;      // 刚收到数据，重新计静默时间
                        }
                        else
                        {
                            if (rx.Count > 0)
                            {
                                quiet++;
                                if (quiet > 30) break; // 30ms 没有新字节，认为一帧结束
                            }
                            Thread.Sleep(1);
                        }
                    }

                    int end = -1;
                    for (int i = rx.Count - 1; i >= 2; i--)
                    {
                        if (rx[i] == Checksum) { end = i; break; }
                    }
                    if (end < 2) return false;

                    int start = -1;
                    for (int i = end - 2; i >= 1; i--)
                    {
                        if (rx[i] == code && rx[i - 1] == address) { start = i - 1; break; }
                    }
                    if (start < 0) return false;

                    frame = new byte[end - start + 1];
                    for (int i = 0; i < frame.Length; i++) frame[i] = rx[start + i];
                    RaiseTrace("RX " + ToHex(frame));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        // 在收到的数据里从后往前找一帧完整应答，过滤适配器回显和总线噪声
        private bool TakeFrame(List<byte> rx, byte address, byte code, int totalLength, byte[] result)
        {
            for (int start = rx.Count - totalLength; start >= 0; start--)
            {
                if (rx[start] != address || rx[start + 1] != code) continue;
                if (rx[start + totalLength - 1] != Checksum) continue;
                for (int i = 0; i < totalLength; i++) result[i] = rx[start + i];
                return true;
            }
            return false;
        }

        private void RaiseTrace(string text)
        {
            Action<string> handler = Trace;
            if (handler != null) handler(text);
        }

        /// <summary>把字节数组转成 "01 3A 6B" 这种十六进制文本，用于日志和界面显示。</summary>
        public static string ToHex(byte[] data)
        {
            if (data == null) return "";
            StringBuilder sb = new StringBuilder(data.Length * 3);
            for (int i = 0; i < data.Length; i++)
            {
                if (i > 0) sb.Append(' ');
                sb.Append(data[i].ToString("X2"));
            }
            return sb.ToString();
        }

        /// <summary>释放串口，等同 Close。</summary>
        public void Dispose()
        {
            Close();
        }
    }
}
