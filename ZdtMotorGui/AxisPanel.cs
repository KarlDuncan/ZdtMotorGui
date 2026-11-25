using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZdtMotorGui
{
    /// <summary>
    /// 单轴操作面板（标准 WinForms 自定义控件）。
    ///
    /// 控件全部在 AxisPanel.Designer.cs 里，VS 设计器能看到完整布局；
    /// 本文件只放“这根轴怎么动”的代码，不再单独拆一个控制器类。
    ///
    /// 换算公式：脉冲 = 目标值 / 每圈行程 × 脉冲每圈。
    /// 例：推动轴每圈 5 mm、3200 脉冲/圈，走 1 mm = 640 脉冲。
    /// </summary>
    public sealed partial class AxisPanel : UserControl
    {
        private ZdtLink _link;               // 两台轴共用同一条 485 总线
        private AxisSettings _settings;      // 当前轴参数
        private int _softPosPulses;          // 软件累计的指令脉冲
        private readonly object _sync = new object(); // 保护位置和参数，轮询/点动线程都会用

        private string _name;                // 轴名称
        private bool _isLinear;              // 是否推动轴
        private string _unit;                // 显示单位：° 或 mm
        private string _fmt;                 // 位置显示的小数位格式

        private bool _connected;             // 串口是否已打开
        private bool _syncing;               // 正在批量设置控件，忽略值变化事件
        private volatile bool _jogging;      // 点动线程是否继续跑
        private int _jogDir;                 // 点动方向：+1 / -1
        private Thread _jogThread;           // 点动后台线程

        public event Action<string> Log;

        /// <summary>设计器里显示/修改的标题，运行时会换成实际轴名。</summary>
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public string AxisTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        /// <summary>设计器里切换“角度/毫米”显示，方便预览两种轴。</summary>
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public bool LinearAxis
        {
            get { return _isLinear; }
            set
            {
                _isLinear = value;
                _unit = value ? "mm" : "°";
                _fmt = value ? "F3" : "F2";
                if (lblUnitsCaption == null) return;
                lblUnitsCaption.Text = value ? "每圈行程" : "每圈角度";
                lblUnitUnits.Text = _unit;
                lblUnitTarget.Text = _unit;
                lblUnitStep.Text = _unit;
                lblUnitLimit.Text = _unit;
                lblPosBig.Text = (value ? "0.000 " : "0.00 ") + _unit;
                int d = value ? 3 : 2;
                numTarget.DecimalPlaces = d;
                numStep.DecimalPlaces = d;
                numMin.DecimalPlaces = d;
                numMax.DecimalPlaces = d;
            }
        }

        /// <summary>创建面板：只建控件和事件，不碰串口；设计器也用这个构造。</summary>
        public AxisPanel()
        {
            InitializeComponent();

            _name = "轴";
            _isLinear = false;
            _unit = "°";
            _fmt = "F2";
            _settings = new AxisSettings();

            SetConnected(false);
        }

        /// <summary>运行时由 MainForm 调用：接上共享的 485 总线并套用这根轴的参数。</summary>
        public void Attach(ZdtLink link, AxisSettings settings)
        {
            _link = link;
            _settings = settings;
            _softPosPulses = 0;

            ApplyIdentity(settings);
            LoadSettings(settings);
            SetConnected(false);
        }

        private void ApplyIdentity(AxisSettings settings)
        {
            _name = settings.Name;
            _isLinear = settings.IsLinear;
            _unit = settings.Unit;
            _fmt = _isLinear ? "F3" : "F2";

            lblTitle.Text = _name + "（地址 " + settings.Address + "）";
            lblUnitsCaption.Text = _isLinear ? "每圈行程" : "每圈角度";
            lblUnitUnits.Text = _unit;
            lblUnitTarget.Text = _unit;
            lblUnitStep.Text = _unit;
            lblUnitLimit.Text = _unit;
            lblPosBig.Text = (settings.IsLinear ? "0.000 " : "0.00 ") + _unit;

            numTarget.DecimalPlaces = _isLinear ? 3 : 2;
            numStep.DecimalPlaces = _isLinear ? 3 : 2;
            numMin.DecimalPlaces = _isLinear ? 3 : 2;
            numMax.DecimalPlaces = _isLinear ? 3 : 2;
            numTarget.Increment = _isLinear ? 0.1m : 1m;
            numStep.Increment = _isLinear ? 0.1m : 1m;
            numStep.Value = _isLinear ? 0.1m : 1m;
        }

        public AxisSettings CollectSettings()
        {
            AxisSettings s = new AxisSettings();
            s.Name = _name;
            s.IsLinear = _isLinear;
            s.Address = (byte)numAddress.Value;
            s.PulsesPerRev = (int)numPpr.Value;
            s.UnitsPerRev = (double)numUnits.Value;
            s.Invert = chkInvert.Checked;
            s.UseLimits = chkUseLimits.Checked;
            s.Min = (double)numMin.Value;
            s.Max = (double)numMax.Value;
            s.SpeedRpm = (int)numSpeed.Value;
            s.Acc = (byte)numAcc.Value;
            s.HomingMode = (byte)Math.Max(0, cmbHomeMode.SelectedIndex);
            return s;
        }

        public void LoadSettings(AxisSettings settings)
        {
            _syncing = true;
            try
            {
                numAddress.Value = Clamp((decimal)settings.Address, numAddress.Minimum, numAddress.Maximum);
                numPpr.Value = Clamp((decimal)settings.PulsesPerRev, numPpr.Minimum, numPpr.Maximum);
                numUnits.Value = Clamp((decimal)settings.UnitsPerRev, numUnits.Minimum, numUnits.Maximum);
                numSpeed.Value = Clamp((decimal)settings.SpeedRpm, numSpeed.Minimum, numSpeed.Maximum);
                numAcc.Value = Clamp((decimal)settings.Acc, numAcc.Minimum, numAcc.Maximum);
                numMin.Value = Clamp((decimal)settings.Min, numMin.Minimum, numMin.Maximum);
                numMax.Value = Clamp((decimal)settings.Max, numMax.Minimum, numMax.Maximum);
                chkInvert.Checked = settings.Invert;
                chkUseLimits.Checked = settings.UseLimits;

                int idx = settings.HomingMode;
                if (idx < 0 || idx >= cmbHomeMode.Items.Count) idx = 0;
                cmbHomeMode.SelectedIndex = idx;

                lblTitle.Text = _name + "（地址 " + (int)numAddress.Value + "）";
            }
            finally
            {
                _syncing = false;
            }
            _settings = CollectSettings();
        }

        public void SetConnected(bool connected)
        {
            _connected = connected;
            chkEnable.Enabled = connected;
            btnMove.Enabled = connected;
            btnStop.Enabled = connected;
            btnJogNeg.Enabled = connected;
            btnJogPos.Enabled = connected;
            btnStepNeg.Enabled = connected;
            btnStepPos.Enabled = connected;
            btnHome.Enabled = connected;
            btnHomeAbort.Enabled = connected;
            btnSetZero.Enabled = connected;
            btnClearPos.Enabled = connected;
            btnResetStall.Enabled = connected;

            if (!connected)
            {
                _syncing = true;
                chkEnable.Checked = false;
                _syncing = false;
                lblStatus.Text = "未连接";
                lblStatus.ForeColor = Color.Gray;
                lblFeedback.Text = "反馈：--";
            }
        }

        /// <summary>
        /// 轮询结果刷新到界面。状态位：bit0 使能 / bit1 到位 / bit3 堵转 / bit7 掉电。
        /// 大数字是软件累计的指令位置，下面一行是驱动器单圈编码器反馈。
        /// </summary>
        public void ShowFeedback(AxisFeedback fb, bool portOpen)
        {
            lblPosBig.Text = fb.SoftPosition.ToString(_fmt) + " " + _unit;

            if (!portOpen)
            {
                lblStatus.Text = "未连接";
                lblStatus.ForeColor = Color.Gray;
                lblFeedback.Text = "反馈：--";
                return;
            }
            if (!fb.Online)
            {
                lblStatus.Text = "离线（无应答）";
                lblStatus.ForeColor = Color.Firebrick;
                lblFeedback.Text = "反馈：--";
                return;
            }

            bool enabled = (fb.Status & 0x01) != 0;
            bool inPlace = (fb.Status & 0x02) != 0;
            bool stall = (fb.Status & 0x08) != 0;
            bool powerLoss = (fb.Status & 0x80) != 0;

            string text = "在线";
            text += enabled ? " · 已使能" : " · 未使能";
            text += inPlace ? " · 到位" : " · 运动中";
            if (stall) text += " · 堵转!";
            if (powerLoss) text += " · 掉电!";

            lblStatus.Text = text;
            lblStatus.ForeColor = (stall || powerLoss) ? Color.Firebrick : (enabled ? Color.ForestGreen : Color.DarkOrange);

            if (fb.PositionValid)
            {
                double deg = fb.Encoder * 360.0 / 65536.0;
                if (_isLinear)
                {
                    double singleTurnMm = fb.Encoder / 65536.0 * _settings.UnitsPerRev;
                    lblFeedback.Text = "反馈单圈：" + singleTurnMm.ToString("F2") + " mm（" + deg.ToString("F1") + "°）";
                }
                else
                {
                    lblFeedback.Text = "反馈角度：" + deg.ToString("F1") + "°";
                }
            }
            else
            {
                lblFeedback.Text = "反馈：--";
            }

            if (!_syncing && chkEnable.Checked != enabled)
            {
                _syncing = true;
                chkEnable.Checked = enabled;
                _syncing = false;
            }
        }

        // ==================== 轴动作 ====================

        /// <summary>使能/失能电机：F3 AB 状态 同步 校验。</summary>
        private void Enable(bool enable)
        {
            _link.Enable(_settings.Address, enable);
            Raise(enable ? "电机已使能" : "电机已失能");
        }

        /// <summary>定位。absolute=true 走绝对位置，false 在当前软件位置上走增量。</summary>
        private void MoveTo(double target, bool absolute)
        {
            // 先把点动停掉、清掉驱动器里没走完的目标，避免新旧指令叠加
            StopMotion();

            lock (_sync)
            {
                AxisSettings s = _settings;
                int targetPulses = UnitsToPulses(target);
                // 绝对定位：目标脉冲 - 当前软件位置 = 本次要走的增量
                // 相对定位：目标值本身就是增量
                int delta = absolute ? targetPulses - _softPosPulses : targetPulses;
                if (delta == 0)
                {
                    Raise("目标位置未变化");
                    return;
                }
                int newPos = _softPosPulses + delta;
                CheckLimits(s, newPos); // 超软限位直接抛异常
                _link.MoveRelative(s.Address, Invert(delta), s.SpeedRpm, s.Acc);
                _softPosPulses = newPos;
            }
            Raise(string.Format("{0}定位 {1} {2}", absolute ? "绝对" : "相对",
                target.ToString(_isLinear ? "F3" : "F2"), _unit));
        }

        /// <summary>
        /// 按住点动：每 60ms 发一小段相对位移，驱动器按目标累加连续走。
        /// 松手后最后一小段自己走完（平滑停），到软限位自动停。
        /// </summary>
        private void StartJog(int direction)
        {
            if (direction == 0 || _jogging) return;
            _jogDir = direction;
            _jogging = true;

            Thread t = new Thread(JogLoop);
            t.IsBackground = true;
            t.Name = "JogLoop";
            _jogThread = t;
            t.Start();
        }

        /// <summary>停止点动线程，但不清驱动器里已经排队的最后一段小位移（松手平滑停）。</summary>
        private void StopJog()
        {
            _jogging = false;
            Thread t = _jogThread;
            if (t != null && t.IsAlive) t.Join(300);
        }

        /// <summary>立即停止：先停点动线程，再发 FE 98 清掉驱动器里未走完的目标。</summary>
        private void StopNow()
        {
            _jogging = false;
            Thread t = _jogThread;
            if (t != null && t.IsAlive) t.Join(300);
            _link.Stop(_settings.Address);
            Raise("已停止");
        }

        /// <summary>
        /// 点动循环：每 60ms 发一小段相对位移，驱动器按目标累加连续走。
        /// 步长按“当前速度×60ms”算，速度单位是 RPM，推动轴还要乘每圈行程。
        /// </summary>
        private void JogLoop()
        {
            AxisSettings s = _settings;
            // 每秒走多少工程量：RPM / 60 × 每圈行程
            double unitsPerSecond = s.SpeedRpm / 60.0 * s.UnitsPerRev;
            if (unitsPerSecond <= 0) unitsPerSecond = s.UnitsPerRev;
            // 60ms 一小段，这样松手时驱动器很快走完最后一点，形成平滑停
            double stepUnits = unitsPerSecond * 0.06;
            double minStep = s.IsLinear ? 0.02 : 0.1; // 太小的一步凑不够一个脉冲
            if (stepUnits < minStep) stepUnits = minStep;

            while (_jogging)
            {
                lock (_sync)
                {
                    if (!_jogging) break;
                    AxisSettings cur = _settings;
                    double next = PulsesToUnits(_softPosPulses) + _jogDir * stepUnits;
                    double lo = Math.Min(cur.Min, cur.Max);
                    double hi = Math.Max(cur.Min, cur.Max);
                    if (cur.UseLimits && (next < lo - 1e-9 || next > hi + 1e-9))
                    {
                        _jogging = false;
                        Raise("已到软限位，点动停止");
                        break;
                    }

                    int stepPulses = UnitsToPulses(stepUnits);
                    if (stepPulses < 1) stepPulses = 1;
                    try
                    {
                        _link.MoveRelative(cur.Address, Invert(_jogDir * stepPulses), cur.SpeedRpm, cur.Acc);
                    }
                    catch (Exception ex)
                    {
                        _jogging = false;
                        Raise("点动失败：" + ex.Message);
                        break;
                    }
                    _softPosPulses += _jogDir * stepPulses;
                }
                Thread.Sleep(60);
            }
        }

        /// <summary>回零并等待完成。返回中文结果，界面直接弹窗。</summary>
        private string Home(int timeoutMs = 60000)
        {
            byte mode;
            lock (_sync)
            {
                // 先停点动、发停止，再读回零模式
                _jogging = false;
                Thread t = _jogThread;
                if (t != null && t.IsAlive) t.Join(300);
                _link.Stop(_settings.Address);
                mode = _settings.HomingMode;
            }
            Thread.Sleep(50);

            _link.StartHome(_settings.Address, mode); // 9A 触发回零

            Stopwatch sw = Stopwatch.StartNew();
            bool sawRunning = false;
            while (sw.ElapsedMilliseconds < timeoutMs)
            {
                byte status;
                if (_link.ReadHomeStatus(_settings.Address, out status, 80))
                {
                    // bit2=1 正在回零，bit3=1 回零失败
                    if ((status & 0x08) != 0) return "回零失败（驱动器 bit3=1）";
                    if ((status & 0x04) != 0) sawRunning = true;
                    // 两位都为 0 且之前看到过“正在回零”，才算真正完成，避免刚触发时误判
                    if ((status & 0x0C) == 0 && (sawRunning || sw.ElapsedMilliseconds > 1500))
                    {
                        _link.ClearPosition(_settings.Address); // 回零完成后当前位置清零
                        lock (_sync) _softPosPulses = 0;
                        return "回零完成";
                    }
                }
                Thread.Sleep(200); // 200ms 查一次回零状态
            }
            return "回零超时（" + (timeoutMs / 1000) + " 秒）";
        }

        /// <summary>当前位置设为单圈零点，并写入驱动器保存。</summary>
        private void SetZero()
        {
            lock (_sync)
            {
                _jogging = false;
                Thread t = _jogThread;
                if (t != null && t.IsAlive) t.Join(300);
                _link.Stop(_settings.Address);
                Thread.Sleep(30);
                _link.ClearPosition(_settings.Address);
                _link.SaveZero(_settings.Address);
                _softPosPulses = 0;
            }
            Raise("已把当前位置设为单圈零点（掉电保存）");
        }

        /// <summary>当前位置清零，不改驱动器保存的零点。</summary>
        private void ClearPosition()
        {
            lock (_sync)
            {
                _jogging = false;
                Thread t = _jogThread;
                if (t != null && t.IsAlive) t.Join(300);
                _link.Stop(_settings.Address);
                Thread.Sleep(20);
                _link.ClearPosition(_settings.Address);
                _softPosPulses = 0;
            }
            Raise("当前位置已清零");
        }

        /// <summary>
        /// 轮询一帧状态：读 0x36（单圈编码器）和 0x3A（使能/到位/堵转）。
        /// 两个读命令都用短超时，电机不在线时轮询不会卡太久。
        /// </summary>
        private AxisFeedback ReadFeedback()
        {
            int encoder;
            byte status;
            // 0x36 读编码器，0x3A 读状态；两个都失败就按离线处理
            bool okPos = _link.ReadEncoder(_settings.Address, out encoder, 80);
            bool okStatus = _link.ReadStatus(_settings.Address, out status, 60);

            AxisFeedback fb = new AxisFeedback();
            fb.Online = okPos || okStatus;
            fb.PositionValid = okPos;
            fb.Encoder = encoder;
            fb.Status = okStatus ? status : (byte)0;
            lock (_sync) fb.SoftPosition = PulsesToUnits(_softPosPulses);
            return fb;
        }

        /// <summary>停止点动并清掉驱动器里还没走完的目标。</summary>
        /// <summary>定位前调用：停点动、发停止、等 30ms，确保上一次运动队列被清空。</summary>
        private void StopMotion()
        {
            _jogging = false;
            Thread t = _jogThread;
            if (t != null && t.IsAlive) t.Join(300);
            _link.Stop(_settings.Address);
            Thread.Sleep(30);
        }

        // ==================== 换算与限位 ====================

        /// <summary>工程量换算成脉冲：脉冲 = 目标值 / 每圈行程 × 脉冲每圈。</summary>
        private int UnitsToPulses(double units)
        {
            return (int)Math.Round(units * _settings.PulsesPerRev / _settings.UnitsPerRev);
        }

        /// <summary>脉冲换算回工程量，用于显示软件位置。</summary>
        private double PulsesToUnits(int pulses)
        {
            return pulses * _settings.UnitsPerRev / _settings.PulsesPerRev;
        }

        /// <summary>方向反转：只改发出去的脉冲符号，软件位置仍按实际方向累计。</summary>
        private int Invert(int pulses)
        {
            return _settings.Invert ? -pulses : pulses;
        }

        /// <summary>软件限位检查：超范围直接抛异常，界面会弹窗提示。</summary>
        private void CheckLimits(AxisSettings s, int targetPulses)
        {
            if (!s.UseLimits) return;
            double value = targetPulses * (s.UnitsPerRev / s.PulsesPerRev);
            double lo = Math.Min(s.Min, s.Max);
            double hi = Math.Max(s.Min, s.Max);
            if (value < lo - 1e-9 || value > hi + 1e-9)
            {
                throw new InvalidOperationException(string.Format(
                    "目标 {0:F3} {1} 超出软限位 [{2:F3}, {3:F3}]", value, s.Unit, lo, hi));
            }
        }

        // ==================== 界面事件 ====================

        private void SettingsChanged(object sender, EventArgs e)
        {
            if (_syncing) return;
            try
            {
                AxisSettings s = CollectSettings();
                if (s.PulsesPerRev != _settings.PulsesPerRev
                    || Math.Abs(s.UnitsPerRev - _settings.UnitsPerRev) > 1e-9)
                {
                    _softPosPulses = 0;
                    Raise("换算参数已修改，软件位置归零（请重新设零或回零）");
                }
                _settings = s;
                lblTitle.Text = _name + "（地址 " + s.Address + "）";
            }
            catch (Exception ex)
            {
                Raise("参数错误：" + ex.Message);
            }
        }

        /// <summary>勾选/取消“使能”：串口没开就还原勾选框。</summary>
        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (_syncing) return;
            bool want = chkEnable.Checked;
            if (!_connected)
            {
                _syncing = true;
                chkEnable.Checked = !want;
                _syncing = false;
                Raise("请先打开串口");
                return;
            }
            RunCommand(delegate { Enable(want); }, want ? "使能" : "失能");
        }

        /// <summary>“运行”按钮：按绝对/相对模式定位。</summary>
        private void btnMove_Click(object sender, EventArgs e)
        {
            double target = (double)numTarget.Value;
            bool absolute = rdoAbs.Checked;
            RunCommand(delegate { MoveTo(target, absolute); }, "定位");
        }

        /// <summary>“停止”按钮：立即停止本轴。</summary>
        private void btnStop_Click(object sender, EventArgs e)
        {
            RunCommand(StopNow, "停止");
        }

        /// <summary>按住左点动：MouseDown 开始，MouseUp/MouseLeave 停止。</summary>
        private void btnJogNeg_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_connected)
            {
                Raise("请先打开串口");
                return;
            }
            StartJog(-1);
        }

        /// <summary>松开左点动。</summary>
        private void btnJogNeg_MouseUp(object sender, MouseEventArgs e)
        {
            StopJog();
        }

        /// <summary>鼠标移出按钮也当作松开，防止一直点动。</summary>
        private void btnJogNeg_MouseLeave(object sender, EventArgs e)
        {
            StopJog();
        }

        /// <summary>按住右点动。</summary>
        private void btnJogPos_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_connected)
            {
                Raise("请先打开串口");
                return;
            }
            StartJog(1);
        }

        /// <summary>松开右点动。</summary>
        private void btnJogPos_MouseUp(object sender, MouseEventArgs e)
        {
            StopJog();
        }

        /// <summary>鼠标移出右点动按钮。</summary>
        private void btnJogPos_MouseLeave(object sender, EventArgs e)
        {
            StopJog();
        }

        /// <summary>负方向步进：走一个“步长”的距离。</summary>
        private void btnStepNeg_Click(object sender, EventArgs e)
        {
            double step = (double)numStep.Value;
            RunCommand(delegate { MoveTo(-step, false); }, "步进");
        }

        /// <summary>正方向步进：走一个“步长”的距离。</summary>
        private void btnStepPos_Click(object sender, EventArgs e)
        {
            double step = (double)numStep.Value;
            RunCommand(delegate { MoveTo(step, false); }, "步进");
        }

        /// <summary>
        /// “回零”按钮：先弹确认框，再后台执行 Home()，避免回零几十秒把界面卡死。
        /// 回零完成后驱动器位置清零，软件位置也归零。
        /// </summary>
        private async void btnHome_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                Raise("请先打开串口");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                FindForm(),
                "将按“" + cmbHomeMode.Text + "”执行回零，轴会自行运动。\r\n确认现场安全后继续？",
                "回零确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirm != DialogResult.OK) return;

            btnHome.Enabled = false;
            try
            {
                string result = await Task.Run(delegate { return Home(); });
                Raise("回零结果：" + result);
                bool ok = result.Contains("完成") || result.Contains("零点");
                MessageBox.Show(FindForm(), result, "回零", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Raise("回零失败：" + ex.Message);
                MessageBox.Show(FindForm(), ex.Message, "回零失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnHome.Enabled = _connected;
            }
        }

        /// <summary>中止回零：发 9C 48，让驱动器退出回零流程。</summary>
        private void btnHomeAbort_Click(object sender, EventArgs e)
        {
            RunCommand(delegate { _link.AbortHome(_settings.Address); Raise("已发送中止回零"); }, "中止回零");
        }

        /// <summary>设零：把当前位置写成单圈零点并掉电保存，软件位置归零。</summary>
        private void btnSetZero_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                Raise("请先打开串口");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                FindForm(),
                "把当前位置设为单圈零点，并写入驱动器掉电保存？",
                "设零确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm != DialogResult.OK) return;
            RunCommand(SetZero, "设零");
        }

        /// <summary>位置清零：只清当前位置，不改驱动器保存的零点。</summary>
        private void btnClearPos_Click(object sender, EventArgs e)
        {
            if (!_connected)
            {
                Raise("请先打开串口");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                FindForm(),
                "把当前位置清零？此操作不改变驱动器保存的单圈零点。",
                "位置清零", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm != DialogResult.OK) return;
            RunCommand(ClearPosition, "位置清零");
        }

        /// <summary>解除堵转/过流保护（0E 52）。</summary>
        private void btnResetStall_Click(object sender, EventArgs e)
        {
            RunCommand(delegate { _link.ResetStall(_settings.Address); Raise("已发送解除堵转"); }, "解除堵转");
        }

        /// <summary>统一的后台执行 + 出错弹窗，避免串口操作卡住界面。</summary>
        private async void RunCommand(Action action, string title)
        {
            if (!_connected)
            {
                Raise("请先打开串口");
                return;
            }
            try
            {
                await Task.Run(action);
            }
            catch (Exception ex)
            {
                Raise(title + "失败：" + ex.Message);
                MessageBox.Show(FindForm(), ex.Message, title + "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==================== 供 MainForm 调用 ====================

        /// <summary>主窗口轮询时调用：读一帧状态。</summary>
        public AxisFeedback Poll()
        {
            return ReadFeedback();
        }

        /// <summary>全部停止时调用：停点动并立即停止本轴。</summary>
        public void Stop()
        {
            StopNow();
        }

        /// <summary>全部回零时调用：执行本轴回零并返回结果文字。</summary>
        public string HomeNow()
        {
            return Home();
        }

        /// <summary>全部停止时先中止回零流程。</summary>
        public void AbortHome()
        {
            if (_link == null || !_connected) return;
            _link.AbortHome(_settings.Address);
            Raise("已发送中止回零");
        }

        /// <summary>统一的消息出口，主窗口订阅后写到日志窗口。</summary>
        private void Raise(string text)
        {
            Action<string> handler = Log;
            if (handler != null) handler(text);
        }

        /// <summary>把数值夹在控件允许范围内，防止读配置时越界。</summary>
        private static decimal Clamp(decimal value, decimal min, decimal max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
