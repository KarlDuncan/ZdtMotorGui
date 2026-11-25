using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZdtMotorGui
{
    /// <summary>
    /// 主窗口：只负责串口开关、状态轮询、日志和两个轴面板的调度。
    /// 轴的动作细节在 AxisPanel.cs，485 帧的拼装在 Zdt.cs。
    /// 这是一个普通 WinForms 桌面程序，不是网页/后端。
    /// </summary>
    public sealed partial class MainForm : Form
    {
        private readonly ZdtLink _link = new ZdtLink(); // 两台电机共用这一条 485 总线
        private AxisPanel _rotaryPanel;                // 旋转轴面板
        private AxisPanel _linearPanel;                // 推动轴面板
        private CancellationTokenSource _cts;          // 关闭窗口时停止轮询
        private volatile bool _traceEnabled;           // 是否在日志里显示收发帧

        /// <summary>
        /// 创建主窗口：绑定两个轴面板、恢复 config.ini、启动状态轮询。
        /// 设计器里只画界面，不启动串口和轮询。
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // 设计器里已经放了两个轴面板，这里直接拿来用
            _rotaryPanel = axisPanelRotary;
            _linearPanel = axisPanelLinear;

            // 设计器只画界面，不启动轮询、不碰串口
            if (IsDesignTime) return;

            _rotaryPanel.Attach(_link, CreateRotarySettings());
            _linearPanel.Attach(_link, CreateLinearSettings());

            _rotaryPanel.Log += AppendLog;
            _linearPanel.Log += AppendLog;
            _link.Trace += OnTrace;

            RefreshPortList();
            LoadConfig();
            SetConnectedUi(false);
            AppendLog("提示：打开串口后先点“通信测试”，两个地址都有应答再试使能和点动。");

            _cts = new CancellationTokenSource();
            _ = PollLoopAsync(_cts.Token);
            FormClosing += MainForm_FormClosing;
        }

        /// <summary>VS 设计器实例化窗口时用它区分“设计时”和“运行时”。</summary>
        private static bool IsDesignTime
        {
            get { return LicenseManager.UsageMode == LicenseUsageMode.Designtime; }
        }

        /// <summary>旋转轴默认参数：地址 1，单位度，回零模式 0。</summary>
        private static AxisSettings CreateRotarySettings()
        {
            AxisSettings s = new AxisSettings();
            s.Name = "旋转轴";
            s.IsLinear = false;
            s.Address = 1;
            s.UnitsPerRev = 360.0;   // 一圈 360°
            s.Min = -3600;           // 软限位先放宽，按实际行程改
            s.Max = 3600;
            s.HomingMode = 0;
            return s;
        }

        /// <summary>推动轴默认参数：地址 2，单位毫米，默认每圈 5mm。</summary>
        private static AxisSettings CreateLinearSettings()
        {
            AxisSettings s = new AxisSettings();
            s.Name = "推动轴";
            s.IsLinear = true;
            s.Address = 2;
            s.UnitsPerRev = 5.0;     // 一圈 5 mm，按丝杆导程改
            s.Min = -500;
            s.Max = 500;
            s.HomingMode = 0;
            return s;
        }

        // ==================== 串口开关 ====================

        /// <summary>枚举电脑上的串口，尽量保留当前选择。</summary>
        private void RefreshPortList()
        {
            string old = cboPort.Text;
            cboPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            for (int i = 0; i < ports.Length; i++) cboPort.Items.Add(ports[i]);

            if (old.Length > 0 && cboPort.Items.Contains(old))
                cboPort.SelectedItem = old;
            else if (cboPort.Items.Count > 0)
                cboPort.SelectedIndex = 0;
        }

        /// <summary>打开/关闭串口。已打开时点按钮就是关闭。</summary>
        private void TogglePort()
        {
            if (_link.IsOpen)
            {
                ClosePort();
                return;
            }
            if (cboPort.Text.Length == 0)
            {
                MessageBox.Show(this, "没有可用串口。请插上 USB 转 485 后点“刷新”。", "串口", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int baud;
            if (!int.TryParse(cboBaud.Text, out baud)) baud = 115200;

            try
            {
                _link.Open(cboPort.Text, baud);
                SetConnectedUi(true);
                AppendLog("串口已打开：" + cboPort.Text + " @ " + baud);
            }
            catch (Exception ex)
            {
                AppendLog("打开串口失败：" + ex.Message);
                MessageBox.Show(this, "打开串口失败：\r\n" + ex.Message, "串口", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>关闭串口前先停两轴，避免电机保持最后一次运动指令。</summary>
        private void ClosePort()
        {
            try
            {
                if (_link.IsOpen)
                {
                    _rotaryPanel.Stop();
                    _linearPanel.Stop();
                }
            }
            catch { }
            _link.Close();
            SetConnectedUi(false);
            AppendLog("串口已关闭");
        }

        /// <summary>串口状态变化时，统一刷新按钮可用性和“已连接/未连接”。</summary>
        private void SetConnectedUi(bool open)
        {
            btnOpen.Text = open ? "关闭串口" : "打开串口";
            cboPort.Enabled = !open;
            cboBaud.Enabled = !open;
            btnRefreshPorts.Enabled = !open;
            _rotaryPanel.SetConnected(open);
            _linearPanel.SetConnected(open);
            btnTestComm.Enabled = open;
            btnScan.Enabled = open;
            btnStopAll.Enabled = open;
            btnHomeAll.Enabled = open;
            lblConn.Text = open ? ("已连接 " + _link.PortName + " @ " + cboBaud.Text) : "未连接";
            lblConn.ForeColor = open ? Color.ForestGreen : Color.Gray;
        }

        // ==================== 通信测试 / 扫描地址 ====================

        /// <summary>通信测试：各读一次状态和编码器，确认地址、接线和波特率。</summary>
        private async void TestComm_Click(object sender, EventArgs e)
        {
            btnTestComm.Enabled = false;
            try
            {
                string report = await Task.Run(delegate
                {
                    AxisFeedback r = _rotaryPanel.Poll();
                    AxisFeedback l = _linearPanel.Poll();
                    return "旋转轴（地址 " + _rotaryPanel.CollectSettings().Address + "）：" + Describe(r)
                         + "\r\n推动轴（地址 " + _linearPanel.CollectSettings().Address + "）：" + Describe(l);
                });
                AppendLog("通信测试 → " + report.Replace("\r\n", "；"));
                MessageBox.Show(this, report, "通信测试", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                btnTestComm.Enabled = _link.IsOpen;
            }
        }

        /// <summary>把一帧状态翻译成日志里的一句话。</summary>
        private static string Describe(AxisFeedback fb)
        {
            if (!fb.Online) return "无应答（检查地址、A/B 线、供电、波特率）";
            string text = "应答正常，状态 0x" + fb.Status.ToString("X2");
            if (fb.PositionValid) text += "，编码器 " + fb.Encoder;
            return text;
        }

        /// <summary>扫描 1~16 号地址：逐个读 0x3A，谁应答就显示谁。</summary>
        private async void Scan_Click(object sender, EventArgs e)
        {
            btnScan.Enabled = false;
            try
            {
                List<string> found = await Task.Run(delegate
                {
                    List<string> list = new List<string>();
                    for (byte addr = 1; addr <= 16; addr++)
                    {
                        byte status;
                        if (_link.ReadStatus(addr, out status, 60))
                            list.Add(addr + "（状态 0x" + status.ToString("X2") + "）");
                    }
                    return list;
                });

                if (found.Count == 0)
                {
                    AppendLog("地址扫描 1~16：无应答");
                    MessageBox.Show(this, "1~16 地址都没有应答。\r\n请检查 A/B 线、终端电阻、供电和波特率。", "扫描地址", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string text = "有应答的地址：\r\n" + string.Join("\r\n", found.ToArray());
                    AppendLog("地址扫描 → " + string.Join("，", found.ToArray()));
                    MessageBox.Show(this, text, "扫描地址", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            finally
            {
                btnScan.Enabled = _link.IsOpen;
            }
        }

        // ==================== 全局按钮 ====================

        /// <summary>全部停止：先中止回零，再让两轴立即停止，任何一步出错都不影响另一轴。</summary>
        private async void StopAll_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(delegate
                {
                    try { _rotaryPanel.AbortHome(); } catch { }
                    try { _linearPanel.AbortHome(); } catch { }
                    try { _rotaryPanel.Stop(); } catch { }
                    try { _linearPanel.Stop(); } catch { }
                });
                AppendLog("全部停止");
            }
            catch (Exception ex)
            {
                AppendLog("全部停止失败：" + ex.Message);
            }
        }

        /// <summary>全部回零：两轴依次回零，先旋转轴再推动轴。</summary>
        private async void HomeAll_Click(object sender, EventArgs e)
        {
            if (!_link.IsOpen)
            {
                AppendLog("串口未打开");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                this,
                "两轴将依次按各自设定的模式回零，确认现场安全？",
                "全部回零", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirm != DialogResult.OK) return;

            btnHomeAll.Enabled = false;
            try
            {
                string r1 = await Task.Run(delegate { return _rotaryPanel.HomeNow(); });
                AppendLog("旋转轴回零：" + r1);
                string r2 = await Task.Run(delegate { return _linearPanel.HomeNow(); });
                AppendLog("推动轴回零：" + r2);
                MessageBox.Show(this, "旋转轴：" + r1 + "\r\n推动轴：" + r2, "全部回零", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                AppendLog("全部回零失败：" + ex.Message);
                MessageBox.Show(this, ex.Message, "全部回零", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnHomeAll.Enabled = _link.IsOpen;
            }
        }

        // ==================== 轮询与日志 ====================

        /// <summary>串口收发帧回调：只有勾选“显示通信帧”时才写日志。</summary>
        private void OnTrace(string line)
        {
            if (!_traceEnabled) return;
            AppendLog("通信 " + line);
        }

        /// <summary>
        /// 后台轮询：每 350ms 读一次两轴状态和编码器。
        /// 串口读取放在 Task.Run 里，界面不会卡；关窗口时用 CancellationToken 退出。
        /// </summary>
        private async Task PollLoopAsync(CancellationToken token)
        {
            AxisPanel[] panels = new AxisPanel[] { _rotaryPanel, _linearPanel };
            while (!token.IsCancellationRequested)
            {
                bool open = _link.IsOpen;
                // 两轴依次读，避免同时占用同一条 485 总线
                for (int i = 0; i < panels.Length; i++)
                {
                    if (token.IsCancellationRequested) return;
                    AxisPanel panel = panels[i];
                    AxisFeedback fb;
                    if (open)
                    {
                        try
                        {
                            fb = await Task.Run(delegate { return panel.Poll(); });
                        }
                        catch
                        {
                            fb = new AxisFeedback();
                        }
                    }
                    else
                    {
                        fb = new AxisFeedback();
                    }
                    if (token.IsCancellationRequested) return;
                    try { panel.ShowFeedback(fb, open); } catch { }
                }
                try
                {
                    await Task.Delay(350, token);
                }
                catch (OperationCanceledException)
                {
                    return;
                }
            }
        }

        /// <summary>线程安全的日志输出：后台线程调用时会自动切回界面线程。</summary>
        private void AppendLog(string text)
        {
            // 窗口已经销毁就不再写
            if (IsDisposed) return;
            if (InvokeRequired)
            {
                try
                {
                    if (IsHandleCreated) BeginInvoke(new Action<string>(AppendLog), text);
                }
                catch { }
                return;
            }
            try
            {
                if (rtbLog.TextLength > 200000) rtbLog.Clear(); // 日志太多时清一次，防止越跑越慢
                rtbLog.AppendText(DateTime.Now.ToString("HH:mm:ss.fff") + "  " + text + Environment.NewLine);
                rtbLog.SelectionStart = rtbLog.TextLength;
                rtbLog.ScrollToCaret(); // 自动滚到最新一行
            }
            catch { }
        }

        // ==================== 调试窗口 ====================

        // 设计器里双击按钮会跳到这些方法
        private void btnRefreshPorts_Click(object sender, EventArgs e) { RefreshPortList(); }
        private void btnOpen_Click(object sender, EventArgs e) { TogglePort(); }
        private void btnTool_Click(object sender, EventArgs e) { OpenToolForm(); }
        private void btnClearLog_Click(object sender, EventArgs e) { rtbLog.Clear(); }
        private void chkTrace_CheckedChanged(object sender, EventArgs e) { _traceEnabled = chkTrace.Checked; }

        /// <summary>打开第二个窗口：参数、回零、状态、运动、PID。和主窗口共用串口。</summary>
        private void OpenToolForm()
        {
            int baud;
            if (!int.TryParse(cboBaud.Text, out baud)) baud = 115200;
            string port = _link.IsOpen ? _link.PortName : cboPort.Text;

            ZdtToolForm form = new ZdtToolForm(_link, port, baud);
            form.ConnectionChanged += delegate { SetConnectedUi(_link.IsOpen); };
            form.FormClosed += delegate { SetConnectedUi(_link.IsOpen); };
            form.Show(this);
        }

        // ==================== 参数保存（config.ini） ====================

        /// <summary>配置文件位置：和 exe 放在同一目录。</summary>
        private string ConfigPath
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini"); }
        }

        /// <summary>
        /// 启动时读 config.ini：恢复串口、波特率和两轴参数。
        /// 文件不存在就直接用默认值，不报错。
        /// </summary>
        private void LoadConfig()
        {
            try
            {
                if (!File.Exists(ConfigPath)) return;

                Dictionary<string, string> dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                string[] lines = File.ReadAllLines(ConfigPath);
                for (int i = 0; i < lines.Length; i++)
                {
                    // 每行格式：key=value，忽略空行和没有等号的行
                    int idx = lines[i].IndexOf('=');
                    if (idx <= 0) continue;
                    dict[lines[i].Substring(0, idx).Trim()] = lines[i].Substring(idx + 1).Trim();
                }

                string value;
                if (dict.TryGetValue("port", out value) && value.Length > 0)
                {
                    if (!cboPort.Items.Contains(value)) cboPort.Items.Add(value);
                    cboPort.SelectedItem = value;
                }
                if (dict.TryGetValue("baud", out value))
                {
                    if (!cboBaud.Items.Contains(value)) cboBaud.Items.Add(value);
                    cboBaud.SelectedItem = value;
                }

                _rotaryPanel.LoadSettings(ReadAxisConfig(dict, "rotary", _rotaryPanel.CollectSettings()));
                _linearPanel.LoadSettings(ReadAxisConfig(dict, "linear", _linearPanel.CollectSettings()));
            }
            catch (Exception ex)
            {
                AppendLog("读取配置失败：" + ex.Message);
            }
        }

        /// <summary>把 ini 里的 rotary.* / linear.* 转成一根轴的参数，并做范围夹取。</summary>
        private static AxisSettings ReadAxisConfig(Dictionary<string, string> dict, string prefix, AxisSettings def)
        {
            AxisSettings s = new AxisSettings();
            s.Name = def.Name;
            s.IsLinear = def.IsLinear;
            s.Address = (byte)ClampInt(GetInt(dict, prefix + ".address", def.Address), 1, 247);
            s.PulsesPerRev = ClampInt(GetInt(dict, prefix + ".ppr", def.PulsesPerRev), 200, 200000);
            s.UnitsPerRev = ClampDouble(GetDouble(dict, prefix + ".units", def.UnitsPerRev), 0.001, 100000.0);
            s.Invert = GetInt(dict, prefix + ".invert", def.Invert ? 1 : 0) != 0;
            s.UseLimits = GetInt(dict, prefix + ".limits", def.UseLimits ? 1 : 0) != 0;
            s.Min = GetDouble(dict, prefix + ".min", def.Min);
            s.Max = GetDouble(dict, prefix + ".max", def.Max);
            s.SpeedRpm = ClampInt(GetInt(dict, prefix + ".speed", def.SpeedRpm), 1, 3000);
            s.Acc = (byte)ClampInt(GetInt(dict, prefix + ".acc", def.Acc), 0, 255);
            s.HomingMode = (byte)ClampInt(GetInt(dict, prefix + ".home", def.HomingMode), 0, 4);
            return s;
        }

        /// <summary>读整数配置，格式不对就用默认值。</summary>
        private static int GetInt(Dictionary<string, string> dict, string key, int def)
        {
            string value;
            int result;
            if (dict.TryGetValue(key, out value) && int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            return def;
        }

        /// <summary>读小数配置，先按不变文化解析，失败再按系统区域解析。</summary>
        private static double GetDouble(Dictionary<string, string> dict, string key, double def)
        {
            string value;
            double result;
            if (dict.TryGetValue(key, out value)
                && (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out result)
                    || double.TryParse(value, out result)))
                return result;
            return def;
        }

        /// <summary>把整数限制在最小/最大值之间。</summary>
        private static int ClampInt(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        /// <summary>把小数限制在最小/最大值之间。</summary>
        private static double ClampDouble(double value, double min, double max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        /// <summary>关窗口时把当前串口和两轴参数写回 config.ini。</summary>
        private void SaveConfig()
        {
            List<string> lines = new List<string>();
            lines.Add("port=" + cboPort.Text);
            lines.Add("baud=" + cboBaud.Text);
            AppendAxisConfig(lines, "rotary", _rotaryPanel.CollectSettings());
            AppendAxisConfig(lines, "linear", _linearPanel.CollectSettings());
            File.WriteAllLines(ConfigPath, lines.ToArray());
        }

        /// <summary>按 rotary.* / linear.* 的键名写一根轴的参数。</summary>
        private static void AppendAxisConfig(List<string> lines, string prefix, AxisSettings s)
        {
            lines.Add(prefix + ".address=" + s.Address);
            lines.Add(prefix + ".ppr=" + s.PulsesPerRev);
            lines.Add(prefix + ".units=" + s.UnitsPerRev.ToString("R", CultureInfo.InvariantCulture));
            lines.Add(prefix + ".invert=" + (s.Invert ? 1 : 0));
            lines.Add(prefix + ".limits=" + (s.UseLimits ? 1 : 0));
            lines.Add(prefix + ".min=" + s.Min.ToString("R", CultureInfo.InvariantCulture));
            lines.Add(prefix + ".max=" + s.Max.ToString("R", CultureInfo.InvariantCulture));
            lines.Add(prefix + ".speed=" + s.SpeedRpm);
            lines.Add(prefix + ".acc=" + s.Acc);
            lines.Add(prefix + ".home=" + s.HomingMode);
        }

        /// <summary>关闭窗口：停轮询、停两轴、保存 config.ini、关闭串口。</summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { if (_cts != null) _cts.Cancel(); } catch { }
            try
            {
                if (_link.IsOpen)
                {
                    _rotaryPanel.Stop();
                    _linearPanel.Stop();
                }
            }
            catch { }
            try
            {
                SaveConfig();
            }
            catch (Exception ex)
            {
                AppendLog("保存配置失败：" + ex.Message);
            }
            try { _link.Dispose(); } catch { }
        }
    }
}
