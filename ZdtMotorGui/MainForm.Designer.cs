namespace ZdtMotorGui
{
    /// <summary>
    /// 主窗口的设计器文件：所有控件都在这里创建。
    /// 打开 MainForm 的设计器即可看到完整窗口（两轴面板也会显示）。
    /// </summary>
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            // 主窗口布局：顶部串口/通信/调试工具按钮，中间左右两个轴面板，底部日志。
            // 事件在控件属性之后统一挂接，功能代码在 MainForm.cs。
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topBar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPort = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblConn = new System.Windows.Forms.Label();
            this.btnTestComm = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnTool = new System.Windows.Forms.Button();
            this.btnHomeAll = new System.Windows.Forms.Button();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.axesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.axisPanelRotary = new ZdtMotorGui.AxisPanel();
            this.axisPanelLinear = new ZdtMotorGui.AxisPanel();
            this.logGroup = new System.Windows.Forms.GroupBox();
            this.logLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logTools = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.rootLayout.SuspendLayout();
            this.topBar.SuspendLayout();
            this.axesLayout.SuspendLayout();
            this.logGroup.SuspendLayout();
            this.logLayout.SuspendLayout();
            this.logTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Controls.Add(this.topBar, 0, 0);
            this.rootLayout.Controls.Add(this.axesLayout, 0, 1);
            this.rootLayout.Controls.Add(this.logGroup, 0, 2);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.RowCount = 3;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.rootLayout.Size = new System.Drawing.Size(1180, 930);
            this.rootLayout.TabIndex = 0;
            // 
            // topBar
            // 
            this.topBar.AutoSize = true;
            this.topBar.Controls.Add(this.lblPort);
            this.topBar.Controls.Add(this.cboPort);
            this.topBar.Controls.Add(this.btnRefreshPorts);
            this.topBar.Controls.Add(this.lblBaud);
            this.topBar.Controls.Add(this.cboBaud);
            this.topBar.Controls.Add(this.btnOpen);
            this.topBar.Controls.Add(this.lblConn);
            this.topBar.Controls.Add(this.btnTestComm);
            this.topBar.Controls.Add(this.btnScan);
            this.topBar.Controls.Add(this.btnTool);
            this.topBar.Controls.Add(this.btnHomeAll);
            this.topBar.Controls.Add(this.btnStopAll);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBar.Location = new System.Drawing.Point(3, 3);
            this.topBar.Name = "topBar";
            this.topBar.Padding = new System.Windows.Forms.Padding(6, 6, 6, 2);
            this.topBar.Size = new System.Drawing.Size(1174, 44);
            this.topBar.TabIndex = 0;
            this.topBar.WrapContents = false;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(8, 16);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 10, 2, 4);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 17);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "串口";
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.Location = new System.Drawing.Point(44, 10);
            this.cboPort.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(110, 25);
            this.cboPort.TabIndex = 1;
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(164, 9);
            this.btnRefreshPorts.Margin = new System.Windows.Forms.Padding(2, 3, 10, 4);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(60, 28);
            this.btnRefreshPorts.TabIndex = 2;
            this.btnRefreshPorts.Text = "刷新";
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(236, 16);
            this.lblBaud.Margin = new System.Windows.Forms.Padding(2, 10, 2, 4);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(44, 17);
            this.lblBaud.TabIndex = 3;
            this.lblBaud.Text = "波特率";
            // 
            // cboBaud
            // 
            this.cboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cboBaud.Location = new System.Drawing.Point(284, 10);
            this.cboBaud.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(90, 25);
            this.cboBaud.TabIndex = 4;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(384, 9);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 3, 10, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 28);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "打开串口";
            // 
            // lblConn
            // 
            this.lblConn.AutoSize = true;
            this.lblConn.ForeColor = System.Drawing.Color.Gray;
            this.lblConn.Location = new System.Drawing.Point(496, 16);
            this.lblConn.Margin = new System.Windows.Forms.Padding(2, 10, 16, 4);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(44, 17);
            this.lblConn.TabIndex = 6;
            this.lblConn.Text = "未连接";
            // 
            // btnTestComm
            // 
            this.btnTestComm.Location = new System.Drawing.Point(558, 9);
            this.btnTestComm.Margin = new System.Windows.Forms.Padding(2, 3, 4, 4);
            this.btnTestComm.Name = "btnTestComm";
            this.btnTestComm.Size = new System.Drawing.Size(90, 28);
            this.btnTestComm.TabIndex = 7;
            this.btnTestComm.Text = "通信测试";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(654, 9);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2, 3, 16, 4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 28);
            this.btnScan.TabIndex = 8;
            this.btnScan.Text = "扫描地址";
            // 
            // btnTool
            // 
            this.btnTool.Margin = new System.Windows.Forms.Padding(2, 3, 16, 4);
            this.btnTool.Name = "btnTool";
            this.btnTool.Size = new System.Drawing.Size(90, 28);
            this.btnTool.Text = "调试工具";
            // 
            // btnHomeAll
            // 
            this.btnHomeAll.Location = new System.Drawing.Point(762, 8);
            this.btnHomeAll.Margin = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btnHomeAll.Name = "btnHomeAll";
            this.btnHomeAll.Size = new System.Drawing.Size(90, 30);
            this.btnHomeAll.TabIndex = 9;
            this.btnHomeAll.Text = "全部回零";
            // 
            // btnStopAll
            // 
            this.btnStopAll.BackColor = System.Drawing.Color.IndianRed;
            this.btnStopAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStopAll.ForeColor = System.Drawing.Color.White;
            this.btnStopAll.Location = new System.Drawing.Point(858, 8);
            this.btnStopAll.Margin = new System.Windows.Forms.Padding(2, 2, 4, 4);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(110, 30);
            this.btnStopAll.TabIndex = 10;
            this.btnStopAll.Text = "全部停止";
            this.btnStopAll.UseVisualStyleBackColor = false;
            // 
            // axesLayout
            // 
            this.axesLayout.ColumnCount = 2;
            this.axesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.axesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.axesLayout.Controls.Add(this.axisPanelRotary, 0, 0);
            this.axesLayout.Controls.Add(this.axisPanelLinear, 1, 0);
            this.axesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axesLayout.Location = new System.Drawing.Point(3, 53);
            this.axesLayout.Name = "axesLayout";
            this.axesLayout.RowCount = 1;
            this.axesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.axesLayout.Size = new System.Drawing.Size(1174, 704);
            this.axesLayout.TabIndex = 1;
            // 
            // axisPanelRotary
            // 
            this.axisPanelRotary.AxisTitle = "旋转轴";
            this.axisPanelRotary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisPanelRotary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.axisPanelRotary.LinearAxis = false;
            this.axisPanelRotary.Location = new System.Drawing.Point(2, 2);
            this.axisPanelRotary.Margin = new System.Windows.Forms.Padding(2);
            this.axisPanelRotary.Name = "axisPanelRotary";
            this.axisPanelRotary.Size = new System.Drawing.Size(583, 700);
            this.axisPanelRotary.TabIndex = 0;
            // 
            // axisPanelLinear
            // 
            this.axisPanelLinear.AxisTitle = "推动轴";
            this.axisPanelLinear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisPanelLinear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.axisPanelLinear.LinearAxis = true;
            this.axisPanelLinear.Location = new System.Drawing.Point(589, 2);
            this.axisPanelLinear.Margin = new System.Windows.Forms.Padding(2);
            this.axisPanelLinear.Name = "axisPanelLinear";
            this.axisPanelLinear.Size = new System.Drawing.Size(583, 700);
            this.axisPanelLinear.TabIndex = 1;
            // 
            // logGroup
            // 
            this.logGroup.Controls.Add(this.logLayout);
            this.logGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logGroup.Location = new System.Drawing.Point(6, 762);
            this.logGroup.Margin = new System.Windows.Forms.Padding(6, 2, 6, 6);
            this.logGroup.Name = "logGroup";
            this.logGroup.Padding = new System.Windows.Forms.Padding(6);
            this.logGroup.Size = new System.Drawing.Size(1168, 162);
            this.logGroup.TabIndex = 2;
            this.logGroup.TabStop = false;
            this.logGroup.Text = "日志";
            // 
            // logLayout
            // 
            this.logLayout.ColumnCount = 1;
            this.logLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logLayout.Controls.Add(this.logTools, 0, 0);
            this.logLayout.Controls.Add(this.rtbLog, 0, 1);
            this.logLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logLayout.Location = new System.Drawing.Point(6, 22);
            this.logLayout.Name = "logLayout";
            this.logLayout.RowCount = 2;
            this.logLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.logLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logLayout.Size = new System.Drawing.Size(1156, 134);
            this.logLayout.TabIndex = 0;
            // 
            // logTools
            // 
            this.logTools.AutoSize = true;
            this.logTools.Controls.Add(this.btnClearLog);
            this.logTools.Controls.Add(this.chkTrace);
            this.logTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTools.Location = new System.Drawing.Point(0, 0);
            this.logTools.Margin = new System.Windows.Forms.Padding(0);
            this.logTools.Name = "logTools";
            this.logTools.Size = new System.Drawing.Size(1156, 30);
            this.logTools.TabIndex = 0;
            this.logTools.WrapContents = false;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(2, 2);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(80, 26);
            this.btnClearLog.TabIndex = 0;
            this.btnClearLog.Text = "清空日志";
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(94, 6);
            this.chkTrace.Margin = new System.Windows.Forms.Padding(2, 6, 12, 2);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(87, 21);
            this.chkTrace.TabIndex = 1;
            this.chkTrace.Text = "显示通信帧";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.DetectUrls = false;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbLog.Location = new System.Drawing.Point(0, 32);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(1156, 102);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            this.rtbLog.WordWrap = false;
            // 
            // 按钮事件（放在设计器里，VS 里双击按钮就能跳到对应代码）
            // 
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            this.btnTestComm.Click += new System.EventHandler(this.TestComm_Click);
            this.btnScan.Click += new System.EventHandler(this.Scan_Click);
            this.btnTool.Click += new System.EventHandler(this.btnTool_Click);
            this.btnStopAll.Click += new System.EventHandler(this.StopAll_Click);
            this.btnHomeAll.Click += new System.EventHandler(this.HomeAll_Click);
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            this.chkTrace.CheckedChanged += new System.EventHandler(this.chkTrace_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 930);
            this.Controls.Add(this.rootLayout);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1040, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZDT 双轴测试台 — USB 转 485";
            this.rootLayout.ResumeLayout(false);
            this.rootLayout.PerformLayout();
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.axesLayout.ResumeLayout(false);
            this.logGroup.ResumeLayout(false);
            this.logLayout.ResumeLayout(false);
            this.logLayout.PerformLayout();
            this.logTools.ResumeLayout(false);
            this.logTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.FlowLayoutPanel topBar;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.Button btnTestComm;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnTool;
        private System.Windows.Forms.Button btnHomeAll;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.TableLayoutPanel axesLayout;
        private ZdtMotorGui.AxisPanel axisPanelRotary;
        private ZdtMotorGui.AxisPanel axisPanelLinear;
        private System.Windows.Forms.GroupBox logGroup;
        private System.Windows.Forms.TableLayoutPanel logLayout;
        private System.Windows.Forms.FlowLayoutPanel logTools;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}
