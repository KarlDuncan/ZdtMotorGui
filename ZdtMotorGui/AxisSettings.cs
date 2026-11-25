using System;

namespace ZdtMotorGui
{
    /// <summary>一根轴的参数。旋转轴单位是度，推动轴单位是毫米。</summary>
    public sealed class AxisSettings
    {
        public string Name = "轴";            // 显示名称：旋转轴 / 推动轴
        public bool IsLinear;                 // true=推动轴(mm)，false=旋转轴(°)
        public byte Address = 1;              // 驱动器地址
        public int PulsesPerRev = 3200;       // 电机转一圈需要的脉冲数 = 200 × 细分
        public double UnitsPerRev = 360.0;    // 电机转一圈对应多少工程量（旋转 360°，推动轴填丝杆导程 mm）
        public bool Invert;                   // 方向反了就勾上
        public bool UseLimits = true;         // 是否启用软件限位
        public double Min = -3600.0;          // 软件限位下限
        public double Max = 3600.0;           // 软件限位上限
        public int SpeedRpm = 60;             // 默认速度（电机轴 RPM）
        public byte Acc = 150;                // 加速度档位 0~255
        public byte HomingMode = 0;           // 回零模式 0~4

        public string Unit
        {
            get { return IsLinear ? "mm" : "°"; }
        }
    }

    /// <summary>轮询回来的一帧轴状态。</summary>
    public struct AxisFeedback
    {
        public bool Online;          // 本次轮询有没有收到应答
        public bool PositionValid;   // 编码器值是否有效
        public int Encoder;          // 单圈编码器值 0~65535
        public byte Status;          // bit0 使能 / bit1 到位 / bit3 堵转 / bit7 掉电
        public double SoftPosition;  // 软件累计的指令位置
    }
}
