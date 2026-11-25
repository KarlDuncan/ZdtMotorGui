using System;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;

namespace ZdtMotorGui
{
    /// <summary>
    /// ZDT 调试窗口：对应官方上位机里的参数/回零/状态/运动/PID 页面。
    ///
    /// 帧格式统一为：地址 + 功能码 + 数据 + 校验字节（默认 0x6B）。
    /// 本窗口和主窗口共用同一个 ZdtLink，所以同一个 COM 口不会被打开两次。
    ///
    /// 按钮事件在 ZdtToolForm.Designer.cs 里统一挂接；
    /// 真正的协议代码从下面“串口”一节开始。
    /// </summary>
    public sealed partial class ZdtToolForm : Form
    {
        /// <summary>主窗口传进来的串口对象，两个窗口共用。</summary>
        private readonly ZdtLink _link;

        /// <summary>系统状态实时刷新定时器（500ms）。</summary>
        private readonly System.Windows.Forms.Timer _liveTimer = new System.Windows.Forms.Timer();

        private int _liveFailures;

        /// <summary>最近一次读到的 32 字节驱动参数；修改时以它为底稿，未显示的字节原样保留。</summary>
        private byte[] _driveParams;

        /// <summary>驱动参数个数，用来判断固件格式是否与已知的 24 项一致。</summary>
        private int _driveParamCount;

        /// <summary>串口开关状态变化，通知主窗口刷新连接显示。</summary>
        public event Action ConnectionChanged;

        /// <summary>VS 设计器用。</summary>
        public ZdtToolForm()
            : this(new ZdtLink(), "", 115200)
        {
        }

        /// <summary>创建窗口：初始化控件、串口列表、校验字节和状态栏。</summary>
        public ZdtToolForm(ZdtLink link, string portName, int baud)
        {
            InitializeComponent();
            ApplyDefaultSelections();
            _link = link;

            FillPorts(portName);
            SelectBaud(baud);
            txtChecksum.Text = "0x" + link.Checksum.ToString("X2");

            UpdateOpenState();
            SetStatus("就绪");

            // 系统状态实时刷新：默认开启，打开串口后自动更新
            _liveTimer.Interval = 500;
            _liveTimer.Tick += LiveTimer_Tick;
            _liveTimer.Enabled = chkLiveStatus.Checked;
            FormClosing += delegate { _liveTimer.Stop(); _liveTimer.Dispose(); };
        }

        /// <summary>VS 设计器重排时可能丢掉 SelectedIndex，这里统一兜底。</summary>
        private void ApplyDefaultSelections()
        {
            SelectDefault(cmbHomeModeP, 0);
            SelectDefault(cmbHomeDirP, 0);
            SelectDefault(cmbAutoHomeP, 0);
            SelectDefault(cmbSaveHomeP, 0);
            SelectDefault(cmbHomeModeC, 0);
            SelectDefault(cmbHomeSyncC, 0);
            SelectDefault(cmbSaveZero, 0);
            SelectDefault(cmbSyncEn, 0);
            SelectDefault(cmbSpeedDir, 0);
            SelectDefault(cmbSyncSpeed, 0);
            SelectDefault(cmbPosDir, 0);
            SelectDefault(cmbRaF, 0);
            SelectDefault(cmbSyncPos, 0);
            SelectDefault(cmbSyncStop, 0);
            SelectDefault(cmbClogPro, 1);
            SelectDefault(cmbSaveDrive, 0);
            SelectDefault(cmbSavePid, 0);
        }

        private static void SelectDefault(ComboBox combo, int index)
        {
            if (combo == null || combo.SelectedIndex >= 0 || combo.Items.Count == 0) return;
            if (index < 0 || index >= combo.Items.Count) index = 0;
            combo.SelectedIndex = index;
        }

        // 设计器里双击按钮会跳到这些方法
        private void btnToolOpen_Click(object sender, EventArgs e) { TogglePort(); }
        private void btnReadHomeP_Click(object sender, EventArgs e) { ReadHomeParams(); }
        private void btnWriteHomeP_Click(object sender, EventArgs e) { WriteHomeParams(); }
        private void btnTriggerHome_Click(object sender, EventArgs e) { TriggerHome(); }
        private void btnSetHomeZero_Click(object sender, EventArgs e) { SetHomeZero(); }
        private void btnAbortHome_Click(object sender, EventArgs e) { AbortHome(); }
        private void btnReadStatus_Click(object sender, EventArgs e) { ReadSystemStatus(); }
        private void btnReadDrive_Click(object sender, EventArgs e) { ReadDriveParams(); }
        private void btnWriteDrive_Click(object sender, EventArgs e) { WriteDriveParams(); }
        private void btnWriteId_Click(object sender, EventArgs e) { WriteId(); }
        private void btnEnable_Click(object sender, EventArgs e) { EnableMotor(true); }
        private void btnDisable_Click(object sender, EventArgs e) { EnableMotor(false); }
        private void btnSendSpeed_Click(object sender, EventArgs e) { SendSpeed(); }
        private void btnSendPos_Click(object sender, EventArgs e) { SendPosition(); }
        private void btnClearPos_Click(object sender, EventArgs e) { ClearPosition(); }
        private void btnStopNow_Click(object sender, EventArgs e) { StopNow(); }
        private void btnSyncMove_Click(object sender, EventArgs e) { SyncMove(); }
        private void btnResetStall_Click(object sender, EventArgs e) { ResetStall(); }
        private void btnReadPid_Click(object sender, EventArgs e) { ReadPid(); }
        private void btnWritePid_Click(object sender, EventArgs e) { WritePid(); }

        // ==================== 串口 ====================

        /// <summary>枚举电脑上的串口，并尽量选中主窗口正在用的那个。</summary>
        private void FillPorts(string preferred)
        {
            cboToolPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            for (int i = 0; i < ports.Length; i++) cboToolPort.Items.Add(ports[i]);

            string target = preferred;
            if ((target == null || target.Length == 0) && _link.IsOpen) target = _link.PortName;
            if (target != null && target.Length > 0 && !cboToolPort.Items.Contains(target)) cboToolPort.Items.Add(target);

            if (target != null && target.Length > 0 && cboToolPort.Items.Contains(target))
                cboToolPort.SelectedItem = target;
            else if (cboToolPort.Items.Count > 0)
                cboToolPort.SelectedIndex = 0;
        }

        /// <summary>让波特率下拉框选中指定值（不存在就先加进去）。</summary>
        private void SelectBaud(int baud)
        {
            string text = baud.ToString();
            if (!cboToolBaud.Items.Contains(text)) cboToolBaud.Items.Add(text);
            cboToolBaud.SelectedItem = text;
        }

        /// <summary>打开/关闭串口。串口是主窗口共用的，这里关闭主窗口也会断开。</summary>
        private void TogglePort()
        {
            if (_link.IsOpen)
            {
                _link.Close();
                UpdateOpenState();
                RaiseConnectionChanged();
                SetStatus("串口已关闭");
                return;
            }
            if (cboToolPort.Text.Length == 0)
            {
                MessageBox.Show(this, "没有可用串口，请插上 USB 转 485 后重新打开本窗口。", "串口", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int baud;
            if (!int.TryParse(cboToolBaud.Text, out baud)) baud = 115200;
            try
            {
                _link.Checksum = ParseChecksum();
                _link.Open(cboToolPort.Text, baud);
                UpdateOpenState();
                RaiseConnectionChanged();
                SetStatus("串口已打开：" + cboToolPort.Text + " @ " + baud);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "打开串口失败：\r\n" + ex.Message, "串口", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>串口打开后禁止再改端口/波特率，并显示实际端口。</summary>
        private void UpdateOpenState()
        {
            bool open = _link.IsOpen;
            btnToolOpen.Text = open ? "关闭串口" : "打开串口";
            cboToolPort.Enabled = !open;
            cboToolBaud.Enabled = !open;
            if (open && _link.PortName.Length > 0)
            {
                if (!cboToolPort.Items.Contains(_link.PortName)) cboToolPort.Items.Add(_link.PortName);
                cboToolPort.SelectedItem = _link.PortName;
            }
        }

        /// <summary>通知主窗口：串口状态变了，请刷新“已连接/未连接”。</summary>
        private void RaiseConnectionChanged()
        {
            Action handler = ConnectionChanged;
            if (handler != null) handler();
        }

        /// <summary>本窗口所有命令使用的电机地址。</summary>
        private byte Addr
        {
            get { return (byte)numToolAddr.Value; }
        }

        /// <summary>读取“校验字节”文本框，支持 0x6B、6B 两种写法，填错就用默认 0x6B。</summary>
        private byte ParseChecksum()
        {
            string text = txtChecksum.Text.Trim().Replace("0x", "").Replace("0X", "");
            byte value;
            if (!byte.TryParse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value)) value = 0x6B;
            return value;
        }

        /// <summary>所有操作前的统一检查：串口没开就弹提示，并同步一次校验字节。</summary>
        private bool EnsureOpen()
        {
            if (!_link.IsOpen)
            {
                MessageBox.Show(this, "请先打开串口。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            _link.Checksum = ParseChecksum();
            return true;
        }

        /// <summary>向本窗口当前地址发一帧（自动补地址和校验字节）。</summary>
        private bool SendBody(params byte[] body)
        {
            try
            {
                _link.SendRaw(Addr, body);
                return true;
            }
            catch (Exception ex)
            {
                SetStatus("发送失败：" + ex.Message);
                return false;
            }
        }

        /// <summary>向指定地址发一帧，例如同步运动的广播地址 0x00。</summary>
        private bool SendBodyTo(byte address, params byte[] body)
        {
            try
            {
                _link.SendRaw(address, body);
                return true;
            }
            catch (Exception ex)
            {
                SetStatus("发送失败：" + ex.Message);
                return false;
            }
        }

        /// <summary>窗口底部状态栏文字。</summary>
        private void SetStatus(string text)
        {
            lblToolStatus.Text = text;
        }

        // ==================== 回零参数 ====================

        /// <summary>
        /// 读取回零参数：地址 + 0x22 + 校验。
        /// 返回 15 个参数字节：模式、方向、速度、超时、无限位检测转速/电流/时间、上电自动回零。
        /// </summary>
        private void ReadHomeParams()
        {
            if (!EnsureOpen()) return;

            byte[] tx = new byte[] { Addr, 0x22, _link.Checksum };
            byte[] rx = new byte[18];
            if (!_link.QueryRaw(tx, Addr, 0x22, 18, rx, 200))
            {
                SetStatus("读取回零参数超时（检查地址/校验字节）");
                return;
            }

            try
            {
                int o = 2;                                        // 前 2 字节是地址和功能码
                cmbHomeModeP.SelectedIndex = Math.Min(rx[o++], cmbHomeModeP.Items.Count - 1); // 回零模式
                cmbHomeDirP.SelectedIndex = rx[o++] == 0 ? 0 : 1; // 回零方向
                SetNum(numHomeSpeedP, U16(rx, o)); o += 2;        // 回零速度 RPM
                SetNum(numHomeTimeoutP, U32(rx, o)); o += 4;      // 回零超时 ms
                SetNum(numSlVel, U16(rx, o)); o += 2;             // 无限位检测转速
                SetNum(numSlMa, U16(rx, o)); o += 2;              // 无限位检测电流
                SetNum(numSlMs, U16(rx, o)); o += 2;              // 无限位检测时间
                cmbAutoHomeP.SelectedIndex = rx[o] != 0 ? 1 : 0;  // 上电自动回零
                SetStatus("回零参数读取成功");
            }
            catch
            {
                SetStatus("回零参数解析失败");
            }
        }

        /// <summary>
        /// 修改回零参数：地址 + 0x4C + 0xAE + 是否存储 + 15 个参数 + 校验。
        /// 注意“是否存储”选“是”才会写进驱动器，否则只本次运行有效。
        /// </summary>
        private void WriteHomeParams()
        {
            if (!EnsureOpen()) return;

            byte[] body = new byte[18];
            body[0] = 0x4C;                                      // 功能码
            body[1] = 0xAE;                                      // 辅助码
            body[2] = (byte)cmbSaveHomeP.SelectedIndex;          // 是否存储
            body[3] = (byte)cmbHomeModeP.SelectedIndex;          // 回零模式
            body[4] = (byte)cmbHomeDirP.SelectedIndex;           // 回零方向
            PutU16(body, 5, (int)numHomeSpeedP.Value);           // 回零速度
            PutU32(body, 7, (uint)numHomeTimeoutP.Value);        // 回零超时
            PutU16(body, 11, (int)numSlVel.Value);               // 无限位检测转速
            PutU16(body, 13, (int)numSlMa.Value);                // 无限位检测电流
            PutU16(body, 15, (int)numSlMs.Value);                // 无限位检测时间
            body[17] = (byte)cmbAutoHomeP.SelectedIndex;         // 上电自动回零

            if (SendBody(body)) SetStatus("已发送修改回零参数");
        }

        /// <summary>命令触发回零：地址 + 0x9A + 回零模式 + 同步标志 + 校验。</summary>
        private void TriggerHome()
        {
            if (!EnsureOpen()) return;
            byte mode = (byte)cmbHomeModeC.SelectedIndex;
            byte sync = (byte)(cmbHomeSyncC.SelectedIndex == 1 ? 1 : 0);
            if (SendBody(new byte[] { 0x9A, mode, sync })) SetStatus("已触发回零");
        }

        /// <summary>把当前位置设为单圈零点：地址 + 0x93 + 0x88 + 是否存储 + 校验。</summary>
        private void SetHomeZero()
        {
            if (!EnsureOpen()) return;
            byte save = (byte)(cmbSaveZero.SelectedIndex == 1 ? 1 : 0);
            if (SendBody(new byte[] { 0x93, 0x88, save })) SetStatus("已设置单圈零点");
        }

        /// <summary>强制中断回零：地址 + 0x9C + 0x48 + 校验。</summary>
        private void AbortHome()
        {
            if (!EnsureOpen()) return;
            if (SendBody(new byte[] { 0x9C, 0x48 })) SetStatus("已发送强制中断回零");
        }

        // ==================== 系统状态 ====================

        private void chkLiveStatus_CheckedChanged(object sender, EventArgs e)
        {
            _liveTimer.Enabled = chkLiveStatus.Checked;
            if (chkLiveStatus.Checked)
            {
                _liveFailures = 0;
                LiveTimer_Tick(sender, e);
            }
        }

        /// <summary>每 500ms 读一次系统状态；串口没开就跳过。</summary>
        private void LiveTimer_Tick(object sender, EventArgs e)
        {
            if (!chkLiveStatus.Checked) return;
            if (_link == null || !_link.IsOpen)
            {
                lblToolStatus.Text = "实时刷新：请先打开串口";
                return;
            }

            ReadSystemStatus();
            if (lblToolStatus.Text.StartsWith("系统状态读取完成"))
            {
                _liveFailures = 0;
                lblToolStatus.Text = "实时刷新 " + DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                _liveFailures++;
                if (_liveFailures >= 3)
                {
                    chkLiveStatus.Checked = false;
                    lblToolStatus.Text = "实时刷新已暂停：无应答，请检查地址/串口";
                }
            }
        }

        /// <summary>
        /// 读取系统状态：地址 + 0x43 + 0x7A + 校验。
        /// 两种固件的 0x43 长度不同：
        ///   X 固件 37 字节（12 项，含母线电流、编码器原始值、温度、标志）；
        ///   Emm 固件 31 字节（9 项，没有母线电流/编码器原始值/温度）。
        /// 标志位另外用 0x3A/0x3B 补读。
        /// </summary>
        private void ReadSystemStatus()
        {
            if (!EnsureOpen()) return;

            byte[] tx = new byte[] { Addr, 0x43, 0x7A, _link.Checksum };
            byte[] f;
            if (!_link.ReadVariable(tx, Addr, 0x43, out f, 300) || f.Length < 31)
            {
                SetStatus("读取系统状态超时或长度不足");
                return;
            }

            try
            {
                int o = 4;                          // 地址、功能码、字节数、参数个数
                bool xLayout = f.Length >= 36;      // 37 字节为 X 布局，31 字节为 Emm 布局

                ushort busVolt = U16(f, o); o += 2; // 总线电压 mV
                if (xLayout) o += 2;                // X：母线电流
                ushort phaseCur = U16(f, o); o += 2;
                if (xLayout) o += 2;                // X：编码器原始值
                ushort encCal = U16(f, o); o += 2;
                int tSign = f[o++]; uint target = U32(f, o); o += 4;
                int sSign = f[o++]; ushort speed = U16(f, o); o += 2;
                int pSign = f[o++]; uint pos = U32(f, o); o += 4;
                int eSign = f[o++]; uint err = U32(f, o); o += 4;

                txtBusVolt.Text = (busVolt / 1000.0).ToString("F2"); // mV 转 V
                txtPhaseCur.Text = phaseCur.ToString();
                txtEncoder.Text = encCal.ToString();
                if (xLayout)
                {
                    // X 固件：位置 0.1°，误差 0.01°，速度 0.1RPM
                    txtTargetPos.Text = SignedScale(tSign, target, 0.1).ToString("F2");
                    txtSpeed.Text = SignedScale(sSign, speed, 0.1).ToString("F1");
                    txtRealPos.Text = SignedScale(pSign, pos, 0.1).ToString("F2");
                    txtPosErr.Text = SignedScale(eSign, err, 0.01).ToString("F3");
                }
                else
                {
                    // Emm 固件：角度原始值 0~65535 对应一圈，速度为 RPM
                    txtTargetPos.Text = SignedDeg(tSign, target).ToString("F2");
                    txtSpeed.Text = (sSign == 0 ? speed : -speed).ToString();
                    txtRealPos.Text = SignedDeg(pSign, pos).ToString("F2");
                    txtPosErr.Text = SignedDeg(eSign, err).ToString("F3");
                }

                byte status;
                byte homeStatus;
                bool okSt = _link.ReadStatus(Addr, out status, 100);
                bool okHome = _link.ReadHomeStatus(Addr, out homeStatus, 100);

                txtHoming.Text = okHome && (homeStatus & 0x04) != 0 ? "是" : "否";
                txtHomeFail.Text = okHome && (homeStatus & 0x08) != 0 ? "是" : "否";
                txtEnabled.Text = okSt && (status & 0x01) != 0 ? "是" : "否";
                txtInPlace.Text = okSt && (status & 0x02) != 0 ? "是" : "否";
                txtStall.Text = okSt && (status & 0x08) != 0 ? "是" : "否";
                txtStallProt.Text = txtStall.Text;

                SetStatus("系统状态读取完成（" + (xLayout ? "X 布局" : "Emm 布局") + "）");
            }
            catch
            {
                SetStatus("系统状态解析失败");
            }
        }

        // ==================== 驱动参数 ====================

        /// <summary>
        /// 读取驱动参数：地址 + 0x42 + 0x6C + 校验。
        /// 返回帧里第 3 字节是整帧长度，第 4 字节是参数个数；
        /// 已知 24 项格式一共 32 个参数字节，读出来后才允许修改。
        /// </summary>
        private void ReadDriveParams()
        {
            if (!EnsureOpen()) return;

            byte[] tx = new byte[] { Addr, 0x42, 0x6C, _link.Checksum };
            byte[] f;
            if (!_link.ReadVariable(tx, Addr, 0x42, out f, 300) || f.Length < 6)
            {
                SetStatus("读取驱动参数超时或长度不足");
                return;
            }

            txtDriveRaw.Text = ZdtLink.ToHex(f);
            int paramCount = f[3];
            int paramBytes = f.Length - 5;

            if (paramCount == 24 && paramBytes >= 32)
            {
                _driveParams = new byte[32];
                Array.Copy(f, 4, _driveParams, 0, 32);
                _driveParamCount = 24;
                FillDriveFields(_driveParams);
                btnWriteDrive.Enabled = true;
                SetStatus("驱动参数读取成功（24 项）");
            }
            else
            {
                _driveParams = null;
                _driveParamCount = paramCount;
                btnWriteDrive.Enabled = false;
                SetStatus("驱动参数为 " + paramCount + " 项，与已知 24 项格式不同，只读显示");
            }
        }

        /// <summary>
        /// 把 32 字节驱动参数按 X 系列 V2 的顺序填到界面。
        /// 偏移：细分=6，开环电流=10，闭环最大电流=12，闭环最大转速=14，
        /// 波特率档位=18，CAN 档位=19，校验档位=20，堵转保护=23，
        /// 堵转转速=24，堵转电流=26，堵转时间=28，位置窗口=30。
        /// </summary>
        private void FillDriveFields(byte[] p)
        {
            SetNum(numMStep, p[6]);
            SetNum(numMa, U16(p, 10));
            SetNum(numMaLimit, U16(p, 12));
            SetNum(numVmLimit, U16(p, 14));
            SetNum(numUartBaud, p[18]);
            SetNum(numCanBaud, p[19]);
            SetNum(numChecksumType, p[20]);
            cmbClogPro.SelectedIndex = p[23] != 0 ? 1 : 0;
            SetNum(numClogRpm, U16(p, 24));
            SetNum(numClogMa, U16(p, 26));
            SetNum(numClogMs, U16(p, 28));
            SetNum(numPosWindow, U16(p, 30));
        }

        /// <summary>
        /// 修改驱动参数：地址 + 0x48 + 0xD1 + 是否存储 + 32 字节参数 + 校验。
        /// 以最近一次读到的原始参数为底稿，只改界面上的 12 项，其它字节原样写回。
        /// </summary>
        private void WriteDriveParams()
        {
            if (!EnsureOpen()) return;
            if (_driveParams == null || _driveParams.Length < 32)
            {
                MessageBox.Show(this, "请先成功读取一次驱动参数，再修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool save = cmbSaveDrive.SelectedIndex == 1;
            DialogResult confirm = MessageBox.Show(
                this,
                "将写入驱动参数" + (save ? "并掉电保存" : "（只本次生效）") + "，确认？",
                "修改驱动参数", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirm != DialogResult.OK) return;

            byte[] p = (byte[])_driveParams.Clone();
            p[6] = (byte)numMStep.Value;
            PutU16(p, 10, (int)numMa.Value);
            PutU16(p, 12, (int)numMaLimit.Value);
            PutU16(p, 14, (int)numVmLimit.Value);
            p[18] = (byte)numUartBaud.Value;
            p[19] = (byte)numCanBaud.Value;
            p[20] = (byte)numChecksumType.Value;
            p[23] = (byte)cmbClogPro.SelectedIndex;
            PutU16(p, 24, (int)numClogRpm.Value);
            PutU16(p, 26, (int)numClogMa.Value);
            PutU16(p, 28, (int)numClogMs.Value);
            PutU16(p, 30, (int)numPosWindow.Value);

            byte[] body = new byte[35];
            body[0] = 0x48;
            body[1] = 0xD1;
            body[2] = (byte)(save ? 1 : 0);
            Array.Copy(p, 0, body, 3, 32);

            if (SendBody(body)) SetStatus("已发送修改驱动参数");
        }

        /// <summary>修改电机 ID：地址 + 0xAE + 0x4B + 是否存储(1) + 新地址 + 校验。</summary>
        private void WriteId()
        {
            if (!EnsureOpen()) return;
            byte newId = (byte)numId.Value;
            if (SendBody(new byte[] { 0xAE, 0x4B, 0x01, newId }))
            {
                numToolAddr.Value = newId;
                SetStatus("已写入并保存 ID：" + newId + "（请重新打开串口）");
            }
        }

        // ==================== 运动控制 ====================

        /// <summary>使能/关闭驱动板：地址 + 0xF3 + 0xAB + 状态 + 同步标志 + 校验。</summary>
        private void EnableMotor(bool enable)
        {
            if (!EnsureOpen()) return;
            byte sync = (byte)(cmbSyncEn.SelectedIndex == 1 ? 1 : 0);
            if (SendBody(new byte[] { 0xF3, 0xAB, (byte)(enable ? 1 : 0), sync }))
                SetStatus(enable ? "已发送使能" : "已发送关闭驱动板");
        }

        /// <summary>速度模式：地址 + 0xF6 + 方向 + 速度(2B) + 加速度 + 同步标志 + 校验。</summary>
        private void SendSpeed()
        {
            if (!EnsureOpen()) return;
            int rpm = (int)numSpeedVal.Value;
            byte dir = (byte)cmbSpeedDir.SelectedIndex;
            byte acc = (byte)numAccVal.Value;
            byte sync = (byte)(cmbSyncSpeed.SelectedIndex == 1 ? 1 : 0);

            if (SendBody(new byte[] { 0xF6, dir, (byte)(rpm >> 8), (byte)rpm, acc, sync }))
                SetStatus("已发送速度指令");
        }

        /// <summary>
        /// 位置模式：地址 + 0xFD + 方向 + 速度(2B) + 加速度 + 脉冲数(4B)
        /// + 相对/绝对标志 + 同步标志 + 校验。
        /// </summary>
        private void SendPosition()
        {
            if (!EnsureOpen()) return;
            int rpm = (int)numPosSpeed.Value;
            byte dir = (byte)cmbPosDir.SelectedIndex;
            byte acc = (byte)numPosAcc.Value;
            uint pulses = (uint)numPulses.Value;
            byte raF = (byte)cmbRaF.SelectedIndex;
            byte sync = (byte)(cmbSyncPos.SelectedIndex == 1 ? 1 : 0);

            byte[] body = new byte[11];
            body[0] = 0xFD;                  // 位置模式
            body[1] = dir;                   // 方向
            body[2] = (byte)(rpm >> 8);      // 速度高字节
            body[3] = (byte)rpm;             // 速度低字节
            body[4] = acc;                   // 加速度
            body[5] = (byte)(pulses >> 24);  // 脉冲数 bit31~24
            body[6] = (byte)(pulses >> 16);  // 脉冲数 bit23~16
            body[7] = (byte)(pulses >> 8);   // 脉冲数 bit15~8
            body[8] = (byte)pulses;          // 脉冲数 bit7~0
            body[9] = raF;                   // 相对/绝对标志
            body[10] = sync;                 // 多机同步标志

            if (SendBody(body)) SetStatus("已发送位置指令");
        }

        /// <summary>当前位置清零：地址 + 0x0A + 0x6D + 校验（不保存到驱动器）。</summary>
        private void ClearPosition()
        {
            if (!EnsureOpen()) return;
            if (SendBody(new byte[] { 0x0A, 0x6D })) SetStatus("已发送当前位置清零");
        }

        /// <summary>立即停止：地址 + 0xFE + 0x98 + 同步标志 + 校验。</summary>
        private void StopNow()
        {
            if (!EnsureOpen()) return;
            byte sync = (byte)(cmbSyncStop.SelectedIndex == 1 ? 1 : 0);
            if (SendBody(new byte[] { 0xFE, 0x98, sync })) SetStatus("已发送立即停止");
        }

        /// <summary>广播启动所有缓存了同步命令的电机：00 + 0xFF + 0x66 + 校验。</summary>
        private void SyncMove()
        {
            if (!EnsureOpen()) return;
            if (SendBodyTo(0x00, new byte[] { 0xFF, 0x66 })) SetStatus("已发送多机同步启动");
        }

        /// <summary>解除堵转/过流保护：地址 + 0x0E + 0x52 + 校验。</summary>
        private void ResetStall()
        {
            if (!EnsureOpen()) return;
            if (SendBody(new byte[] { 0x0E, 0x52 })) SetStatus("已发送解除堵转保护");
        }

        // ==================== PID ====================

        /// <summary>
        /// 读取 PID：地址 + 0x21 + 校验。
        /// 官方 X 系列 V2 返回 4 个 32 位参数：位置环Kp1、位置环Kp2、速度环Kp、速度环Ki。
        /// 按实际返回长度解析，少几项也不会越界。
        /// </summary>
        private void ReadPid()
        {
            if (!EnsureOpen()) return;

            byte[] tx = new byte[] { Addr, 0x21, _link.Checksum };
            byte[] f;
            if (!_link.ReadVariable(tx, Addr, 0x21, out f, 250) || f.Length < 7)
            {
                SetStatus("读取 PID 超时或长度不足");
                return;
            }

            int count = (f.Length - 3) / 4;
            if (count > 4) count = 4;
            try
            {
                if (count > 0) SetNum(numKp1, U32(f, 2));
                if (count > 1) SetNum(numKp2, U32(f, 6));
                if (count > 2) SetNum(numKp3, U32(f, 10));
                if (count > 3) SetNum(numKi, U32(f, 14));
                SetStatus("PID 读取成功，共 " + count + " 项");
            }
            catch
            {
                SetStatus("PID 解析失败");
            }
        }

        /// <summary>
        /// 修改 PID：地址 + 0x4A + 0xC3 + 是否存储 + 4 个 32 位参数 + 校验。
        /// 参数顺序与读取返回一致：位置环Kp1、位置环Kp2、速度环Kp、速度环Ki。
        /// </summary>
        private void WritePid()
        {
            if (!EnsureOpen()) return;
            bool save = cmbSavePid.SelectedIndex == 1;
            DialogResult confirm = MessageBox.Show(
                this,
                "将写入 PID 参数" + (save ? "并掉电保存" : "（只本次生效）") + "，确认？",
                "修改PID", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirm != DialogResult.OK) return;

            byte[] body = new byte[19];
            body[0] = 0x4A;
            body[1] = 0xC3;
            body[2] = (byte)(save ? 1 : 0);
            PutU32(body, 3, (uint)numKp1.Value);
            PutU32(body, 7, (uint)numKp2.Value);
            PutU32(body, 11, (uint)numKp3.Value);
            PutU32(body, 15, (uint)numKi.Value);

            if (SendBody(body)) SetStatus("已发送修改 PID");
        }

        // ==================== 工具方法 ====================

        /// <summary>按大端顺序取 16 位无符号数。</summary>
        private static ushort U16(byte[] data, int offset)
        {
            return (ushort)((data[offset] << 8) | data[offset + 1]);
        }

        /// <summary>按大端顺序取 32 位无符号数。</summary>
        private static uint U32(byte[] data, int offset)
        {
            return ((uint)data[offset] << 24) | ((uint)data[offset + 1] << 16)
                 | ((uint)data[offset + 2] << 8) | data[offset + 3];
        }

        /// <summary>按大端顺序写 16 位无符号数。</summary>
        private static void PutU16(byte[] data, int offset, int value)
        {
            data[offset] = (byte)(value >> 8);
            data[offset + 1] = (byte)value;
        }

        /// <summary>按大端顺序写 32 位无符号数。</summary>
        private static void PutU32(byte[] data, int offset, uint value)
        {
            data[offset] = (byte)(value >> 24);
            data[offset + 1] = (byte)(value >> 16);
            data[offset + 2] = (byte)(value >> 8);
            data[offset + 3] = (byte)value;
        }

        /// <summary>
        /// 编码器值换算成角度：一圈 65536 个计数，对应 360°。
        /// 符号字节为 1 表示负数。
        /// </summary>
        private static double SignedDeg(int sign, uint value)
        {
            double v = value * 360.0 / 65536.0;
            return sign == 1 ? -v : v;
        }

        /// <summary>按给定单位换算带符号的值（X 固件位置 0.1°、误差 0.01°、速度 0.1RPM）。</summary>
        private static double SignedScale(int sign, uint value, double scale)
        {
            double v = value * scale;
            return sign == 1 ? -v : v;
        }

        /// <summary>给 NumericUpDown 赋值并夹在最小/最大值之间，防止读回异常数据时抛异常。</summary>
        private static void SetNum(NumericUpDown control, decimal value)
        {
            if (value < control.Minimum) value = control.Minimum;
            if (value > control.Maximum) value = control.Maximum;
            control.Value = value;
        }
    }
}
