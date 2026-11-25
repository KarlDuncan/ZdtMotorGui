namespace ZdtMotorGui
{
    /// <summary>
    /// ZDT 调试窗口的设计器文件：串口、回零、状态、驱动参数、运动控制、PID 控件都在这里。
    /// </summary>
    partial class ZdtToolForm
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
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.groupSerial = new System.Windows.Forms.GroupBox();
            this.lblToolPort = new System.Windows.Forms.Label();
            this.cboToolPort = new System.Windows.Forms.ComboBox();
            this.lblToolBaud = new System.Windows.Forms.Label();
            this.cboToolBaud = new System.Windows.Forms.ComboBox();
            this.lblToolAddr = new System.Windows.Forms.Label();
            this.numToolAddr = new System.Windows.Forms.NumericUpDown();
            this.lblChecksum = new System.Windows.Forms.Label();
            this.txtChecksum = new System.Windows.Forms.TextBox();
            this.btnToolOpen = new System.Windows.Forms.Button();
            this.lblShare = new System.Windows.Forms.Label();
            this.groupHomeParams = new System.Windows.Forms.GroupBox();
            this.lblHomeModeP = new System.Windows.Forms.Label();
            this.cmbHomeModeP = new System.Windows.Forms.ComboBox();
            this.lblHomeDirP = new System.Windows.Forms.Label();
            this.cmbHomeDirP = new System.Windows.Forms.ComboBox();
            this.lblHomeSpeedP = new System.Windows.Forms.Label();
            this.numHomeSpeedP = new System.Windows.Forms.NumericUpDown();
            this.lblHomeTimeoutP = new System.Windows.Forms.Label();
            this.numHomeTimeoutP = new System.Windows.Forms.NumericUpDown();
            this.lblSlVel = new System.Windows.Forms.Label();
            this.numSlVel = new System.Windows.Forms.NumericUpDown();
            this.lblSlMa = new System.Windows.Forms.Label();
            this.numSlMa = new System.Windows.Forms.NumericUpDown();
            this.lblSlMs = new System.Windows.Forms.Label();
            this.numSlMs = new System.Windows.Forms.NumericUpDown();
            this.lblAutoHomeP = new System.Windows.Forms.Label();
            this.cmbAutoHomeP = new System.Windows.Forms.ComboBox();
            this.lblSaveHomeP = new System.Windows.Forms.Label();
            this.cmbSaveHomeP = new System.Windows.Forms.ComboBox();
            this.btnReadHomeP = new System.Windows.Forms.Button();
            this.btnWriteHomeP = new System.Windows.Forms.Button();
            this.lblHomeNote = new System.Windows.Forms.Label();
            this.groupHomeCmd = new System.Windows.Forms.GroupBox();
            this.lblHomeModeC = new System.Windows.Forms.Label();
            this.cmbHomeModeC = new System.Windows.Forms.ComboBox();
            this.lblHomeSyncC = new System.Windows.Forms.Label();
            this.cmbHomeSyncC = new System.Windows.Forms.ComboBox();
            this.btnTriggerHome = new System.Windows.Forms.Button();
            this.btnSetHomeZero = new System.Windows.Forms.Button();
            this.cmbSaveZero = new System.Windows.Forms.ComboBox();
            this.btnAbortHome = new System.Windows.Forms.Button();
            this.lblHomeCmdNote = new System.Windows.Forms.Label();
            this.groupStatus = new System.Windows.Forms.GroupBox();
            this.btnReadStatus = new System.Windows.Forms.Button();
            this.chkLiveStatus = new System.Windows.Forms.CheckBox();
            this.lblBusVolt = new System.Windows.Forms.Label();
            this.txtBusVolt = new System.Windows.Forms.TextBox();
            this.lblPhaseCur = new System.Windows.Forms.Label();
            this.txtPhaseCur = new System.Windows.Forms.TextBox();
            this.lblEncoder = new System.Windows.Forms.Label();
            this.txtEncoder = new System.Windows.Forms.TextBox();
            this.lblTargetPos = new System.Windows.Forms.Label();
            this.txtTargetPos = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblRealPos = new System.Windows.Forms.Label();
            this.txtRealPos = new System.Windows.Forms.TextBox();
            this.lblPosErr = new System.Windows.Forms.Label();
            this.txtPosErr = new System.Windows.Forms.TextBox();
            this.lblHoming = new System.Windows.Forms.Label();
            this.txtHoming = new System.Windows.Forms.TextBox();
            this.lblHomeFail = new System.Windows.Forms.Label();
            this.txtHomeFail = new System.Windows.Forms.TextBox();
            this.lblEnabled = new System.Windows.Forms.Label();
            this.txtEnabled = new System.Windows.Forms.TextBox();
            this.lblInPlace = new System.Windows.Forms.Label();
            this.txtInPlace = new System.Windows.Forms.TextBox();
            this.lblStall = new System.Windows.Forms.Label();
            this.txtStall = new System.Windows.Forms.TextBox();
            this.lblStallProt = new System.Windows.Forms.Label();
            this.txtStallProt = new System.Windows.Forms.TextBox();
            this.groupDrive = new System.Windows.Forms.GroupBox();
            this.lblMStep = new System.Windows.Forms.Label();
            this.numMStep = new System.Windows.Forms.NumericUpDown();
            this.lblMa = new System.Windows.Forms.Label();
            this.numMa = new System.Windows.Forms.NumericUpDown();
            this.lblMaLimit = new System.Windows.Forms.Label();
            this.numMaLimit = new System.Windows.Forms.NumericUpDown();
            this.lblVmLimit = new System.Windows.Forms.Label();
            this.numVmLimit = new System.Windows.Forms.NumericUpDown();
            this.lblUartBaud = new System.Windows.Forms.Label();
            this.numUartBaud = new System.Windows.Forms.NumericUpDown();
            this.lblCanBaud = new System.Windows.Forms.Label();
            this.numCanBaud = new System.Windows.Forms.NumericUpDown();
            this.lblChecksumType = new System.Windows.Forms.Label();
            this.numChecksumType = new System.Windows.Forms.NumericUpDown();
            this.lblClogRpm = new System.Windows.Forms.Label();
            this.numClogRpm = new System.Windows.Forms.NumericUpDown();
            this.lblClogMa = new System.Windows.Forms.Label();
            this.numClogMa = new System.Windows.Forms.NumericUpDown();
            this.lblClogMs = new System.Windows.Forms.Label();
            this.numClogMs = new System.Windows.Forms.NumericUpDown();
            this.lblPosWindow = new System.Windows.Forms.Label();
            this.numPosWindow = new System.Windows.Forms.NumericUpDown();
            this.lblClogPro = new System.Windows.Forms.Label();
            this.cmbClogPro = new System.Windows.Forms.ComboBox();
            this.txtDriveRaw = new System.Windows.Forms.TextBox();
            this.btnReadDrive = new System.Windows.Forms.Button();
            this.btnWriteDrive = new System.Windows.Forms.Button();
            this.lblSaveDrive = new System.Windows.Forms.Label();
            this.cmbSaveDrive = new System.Windows.Forms.ComboBox();
            this.lblDriveNote = new System.Windows.Forms.Label();
            this.lblIdAddr = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.btnWriteId = new System.Windows.Forms.Button();
            this.lblIdNote = new System.Windows.Forms.Label();
            this.groupMotion = new System.Windows.Forms.GroupBox();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lblSyncEn = new System.Windows.Forms.Label();
            this.cmbSyncEn = new System.Windows.Forms.ComboBox();
            this.lblSpeedDir = new System.Windows.Forms.Label();
            this.cmbSpeedDir = new System.Windows.Forms.ComboBox();
            this.lblSpeedVal = new System.Windows.Forms.Label();
            this.numSpeedVal = new System.Windows.Forms.NumericUpDown();
            this.lblAccVal = new System.Windows.Forms.Label();
            this.numAccVal = new System.Windows.Forms.NumericUpDown();
            this.lblSyncSpeed = new System.Windows.Forms.Label();
            this.cmbSyncSpeed = new System.Windows.Forms.ComboBox();
            this.btnSendSpeed = new System.Windows.Forms.Button();
            this.lblPosDir = new System.Windows.Forms.Label();
            this.cmbPosDir = new System.Windows.Forms.ComboBox();
            this.lblPosSpeed = new System.Windows.Forms.Label();
            this.numPosSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblPosAcc = new System.Windows.Forms.Label();
            this.numPosAcc = new System.Windows.Forms.NumericUpDown();
            this.lblPulses = new System.Windows.Forms.Label();
            this.numPulses = new System.Windows.Forms.NumericUpDown();
            this.lblRaF = new System.Windows.Forms.Label();
            this.cmbRaF = new System.Windows.Forms.ComboBox();
            this.lblSyncPos = new System.Windows.Forms.Label();
            this.cmbSyncPos = new System.Windows.Forms.ComboBox();
            this.btnSendPos = new System.Windows.Forms.Button();
            this.groupQuick = new System.Windows.Forms.GroupBox();
            this.btnClearPos = new System.Windows.Forms.Button();
            this.btnStopNow = new System.Windows.Forms.Button();
            this.lblSyncStop = new System.Windows.Forms.Label();
            this.cmbSyncStop = new System.Windows.Forms.ComboBox();
            this.btnSyncMove = new System.Windows.Forms.Button();
            this.btnResetStall = new System.Windows.Forms.Button();
            this.lblQuickNote = new System.Windows.Forms.Label();
            this.groupPid = new System.Windows.Forms.GroupBox();
            this.lblKp1 = new System.Windows.Forms.Label();
            this.numKp1 = new System.Windows.Forms.NumericUpDown();
            this.lblKp2 = new System.Windows.Forms.Label();
            this.numKp2 = new System.Windows.Forms.NumericUpDown();
            this.lblKp3 = new System.Windows.Forms.Label();
            this.numKp3 = new System.Windows.Forms.NumericUpDown();
            this.lblKi = new System.Windows.Forms.Label();
            this.numKi = new System.Windows.Forms.NumericUpDown();
            this.btnReadPid = new System.Windows.Forms.Button();
            this.btnWritePid = new System.Windows.Forms.Button();
            this.lblSavePid = new System.Windows.Forms.Label();
            this.cmbSavePid = new System.Windows.Forms.ComboBox();
            this.lblToolStatus = new System.Windows.Forms.Label();
            this.scrollPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.groupSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToolAddr)).BeginInit();
            this.groupHomeParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeSpeedP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeTimeoutP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlMs)).BeginInit();
            this.groupHomeCmd.SuspendLayout();
            this.groupStatus.SuspendLayout();
            this.groupDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVmLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUartBaud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanBaud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChecksumType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClogRpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClogMa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClogMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.groupMotion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPulses)).BeginInit();
            this.groupQuick.SuspendLayout();
            this.groupPid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKi)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.contentPanel);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(1480, 940);
            this.scrollPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.groupSerial);
            this.contentPanel.Controls.Add(this.groupHomeParams);
            this.contentPanel.Controls.Add(this.groupHomeCmd);
            this.contentPanel.Controls.Add(this.groupStatus);
            this.contentPanel.Controls.Add(this.groupDrive);
            this.contentPanel.Controls.Add(this.groupMotion);
            this.contentPanel.Controls.Add(this.groupQuick);
            this.contentPanel.Controls.Add(this.groupPid);
            this.contentPanel.Controls.Add(this.lblToolStatus);
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1460, 1060);
            this.contentPanel.TabIndex = 0;
            // 
            // groupSerial
            // 
            this.groupSerial.Controls.Add(this.lblToolPort);
            this.groupSerial.Controls.Add(this.cboToolPort);
            this.groupSerial.Controls.Add(this.lblToolBaud);
            this.groupSerial.Controls.Add(this.cboToolBaud);
            this.groupSerial.Controls.Add(this.lblToolAddr);
            this.groupSerial.Controls.Add(this.numToolAddr);
            this.groupSerial.Controls.Add(this.lblChecksum);
            this.groupSerial.Controls.Add(this.txtChecksum);
            this.groupSerial.Controls.Add(this.btnToolOpen);
            this.groupSerial.Controls.Add(this.lblShare);
            this.groupSerial.Location = new System.Drawing.Point(10, 10);
            this.groupSerial.Name = "groupSerial";
            this.groupSerial.Size = new System.Drawing.Size(250, 220);
            this.groupSerial.TabIndex = 0;
            this.groupSerial.TabStop = false;
            this.groupSerial.Text = "串口设置";
            // 
            // lblToolPort
            // 
            this.lblToolPort.AutoSize = true;
            this.lblToolPort.Location = new System.Drawing.Point(10, 33);
            this.lblToolPort.Name = "lblToolPort";
            this.lblToolPort.Size = new System.Drawing.Size(32, 17);
            this.lblToolPort.TabIndex = 0;
            this.lblToolPort.Text = "端口";
            // 
            // cboToolPort
            // 
            this.cboToolPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToolPort.Location = new System.Drawing.Point(70, 29);
            this.cboToolPort.Name = "cboToolPort";
            this.cboToolPort.Size = new System.Drawing.Size(160, 25);
            this.cboToolPort.TabIndex = 1;
            // 
            // lblToolBaud
            // 
            this.lblToolBaud.AutoSize = true;
            this.lblToolBaud.Location = new System.Drawing.Point(10, 68);
            this.lblToolBaud.Name = "lblToolBaud";
            this.lblToolBaud.Size = new System.Drawing.Size(44, 17);
            this.lblToolBaud.TabIndex = 2;
            this.lblToolBaud.Text = "波特率";
            // 
            // cboToolBaud
            // 
            this.cboToolBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToolBaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cboToolBaud.Location = new System.Drawing.Point(70, 64);
            this.cboToolBaud.Name = "cboToolBaud";
            this.cboToolBaud.Size = new System.Drawing.Size(160, 25);
            this.cboToolBaud.TabIndex = 3;
            // 
            // lblToolAddr
            // 
            this.lblToolAddr.AutoSize = true;
            this.lblToolAddr.Location = new System.Drawing.Point(10, 103);
            this.lblToolAddr.Name = "lblToolAddr";
            this.lblToolAddr.Size = new System.Drawing.Size(56, 17);
            this.lblToolAddr.TabIndex = 4;
            this.lblToolAddr.Text = "电机地址";
            // 
            // numToolAddr
            // 
            this.numToolAddr.Location = new System.Drawing.Point(85, 99);
            this.numToolAddr.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numToolAddr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numToolAddr.Name = "numToolAddr";
            this.numToolAddr.Size = new System.Drawing.Size(70, 23);
            this.numToolAddr.TabIndex = 5;
            this.numToolAddr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChecksum
            // 
            this.lblChecksum.AutoSize = true;
            this.lblChecksum.Location = new System.Drawing.Point(10, 138);
            this.lblChecksum.Name = "lblChecksum";
            this.lblChecksum.Size = new System.Drawing.Size(56, 17);
            this.lblChecksum.TabIndex = 6;
            this.lblChecksum.Text = "校验字节";
            // 
            // txtChecksum
            // 
            this.txtChecksum.Location = new System.Drawing.Point(85, 134);
            this.txtChecksum.Name = "txtChecksum";
            this.txtChecksum.Size = new System.Drawing.Size(70, 23);
            this.txtChecksum.TabIndex = 7;
            this.txtChecksum.Text = "0x6B";
            // 
            // btnToolOpen
            // 
            this.btnToolOpen.Location = new System.Drawing.Point(10, 170);
            this.btnToolOpen.Name = "btnToolOpen";
            this.btnToolOpen.Size = new System.Drawing.Size(120, 30);
            this.btnToolOpen.TabIndex = 8;
            this.btnToolOpen.Text = "打开串口";
            this.btnToolOpen.Click += new System.EventHandler(this.btnToolOpen_Click);
            // 
            // lblShare
            // 
            this.lblShare.AutoSize = true;
            this.lblShare.ForeColor = System.Drawing.Color.Gray;
            this.lblShare.Location = new System.Drawing.Point(140, 176);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(104, 17);
            this.lblShare.TabIndex = 9;
            this.lblShare.Text = "与主窗口共用串口";
            // 
            // groupHomeParams
            // 
            this.groupHomeParams.Controls.Add(this.lblHomeModeP);
            this.groupHomeParams.Controls.Add(this.cmbHomeModeP);
            this.groupHomeParams.Controls.Add(this.lblHomeDirP);
            this.groupHomeParams.Controls.Add(this.cmbHomeDirP);
            this.groupHomeParams.Controls.Add(this.lblHomeSpeedP);
            this.groupHomeParams.Controls.Add(this.numHomeSpeedP);
            this.groupHomeParams.Controls.Add(this.lblHomeTimeoutP);
            this.groupHomeParams.Controls.Add(this.numHomeTimeoutP);
            this.groupHomeParams.Controls.Add(this.lblSlVel);
            this.groupHomeParams.Controls.Add(this.numSlVel);
            this.groupHomeParams.Controls.Add(this.lblSlMa);
            this.groupHomeParams.Controls.Add(this.numSlMa);
            this.groupHomeParams.Controls.Add(this.lblSlMs);
            this.groupHomeParams.Controls.Add(this.numSlMs);
            this.groupHomeParams.Controls.Add(this.lblAutoHomeP);
            this.groupHomeParams.Controls.Add(this.cmbAutoHomeP);
            this.groupHomeParams.Controls.Add(this.lblSaveHomeP);
            this.groupHomeParams.Controls.Add(this.cmbSaveHomeP);
            this.groupHomeParams.Controls.Add(this.btnReadHomeP);
            this.groupHomeParams.Controls.Add(this.btnWriteHomeP);
            this.groupHomeParams.Controls.Add(this.lblHomeNote);
            this.groupHomeParams.Location = new System.Drawing.Point(270, 10);
            this.groupHomeParams.Name = "groupHomeParams";
            this.groupHomeParams.Size = new System.Drawing.Size(650, 300);
            this.groupHomeParams.TabIndex = 1;
            this.groupHomeParams.TabStop = false;
            this.groupHomeParams.Text = "原点回零参数";
            // 
            // lblHomeModeP
            // 
            this.lblHomeModeP.AutoSize = true;
            this.lblHomeModeP.Location = new System.Drawing.Point(10, 33);
            this.lblHomeModeP.Name = "lblHomeModeP";
            this.lblHomeModeP.Size = new System.Drawing.Size(56, 17);
            this.lblHomeModeP.TabIndex = 0;
            this.lblHomeModeP.Text = "回零模式";
            // 
            // cmbHomeModeP
            // 
            this.cmbHomeModeP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeModeP.Items.AddRange(new object[] {
            "Nearest（就近）",
            "Dir（方向）",
            "Collision（碰撞）",
            "EndStop（限位）"});
            this.cmbHomeModeP.Location = new System.Drawing.Point(90, 29);
            this.cmbHomeModeP.Name = "cmbHomeModeP";
            this.cmbHomeModeP.Size = new System.Drawing.Size(130, 25);
            this.cmbHomeModeP.TabIndex = 1;
            // 
            // lblHomeDirP
            // 
            this.lblHomeDirP.AutoSize = true;
            this.lblHomeDirP.Location = new System.Drawing.Point(250, 33);
            this.lblHomeDirP.Name = "lblHomeDirP";
            this.lblHomeDirP.Size = new System.Drawing.Size(56, 17);
            this.lblHomeDirP.TabIndex = 2;
            this.lblHomeDirP.Text = "回零方向";
            // 
            // cmbHomeDirP
            // 
            this.cmbHomeDirP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeDirP.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.cmbHomeDirP.Location = new System.Drawing.Point(320, 29);
            this.cmbHomeDirP.Name = "cmbHomeDirP";
            this.cmbHomeDirP.Size = new System.Drawing.Size(100, 25);
            this.cmbHomeDirP.TabIndex = 3;
            // 
            // lblHomeSpeedP
            // 
            this.lblHomeSpeedP.AutoSize = true;
            this.lblHomeSpeedP.Location = new System.Drawing.Point(440, 33);
            this.lblHomeSpeedP.Name = "lblHomeSpeedP";
            this.lblHomeSpeedP.Size = new System.Drawing.Size(91, 17);
            this.lblHomeSpeedP.TabIndex = 4;
            this.lblHomeSpeedP.Text = "回零速度(RPM)";
            // 
            // numHomeSpeedP
            // 
            this.numHomeSpeedP.Location = new System.Drawing.Point(560, 29);
            this.numHomeSpeedP.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numHomeSpeedP.Name = "numHomeSpeedP";
            this.numHomeSpeedP.Size = new System.Drawing.Size(70, 23);
            this.numHomeSpeedP.TabIndex = 5;
            this.numHomeSpeedP.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblHomeTimeoutP
            // 
            this.lblHomeTimeoutP.AutoSize = true;
            this.lblHomeTimeoutP.Location = new System.Drawing.Point(10, 68);
            this.lblHomeTimeoutP.Name = "lblHomeTimeoutP";
            this.lblHomeTimeoutP.Size = new System.Drawing.Size(81, 17);
            this.lblHomeTimeoutP.TabIndex = 6;
            this.lblHomeTimeoutP.Text = "回零超时(ms)";
            // 
            // numHomeTimeoutP
            // 
            this.numHomeTimeoutP.Location = new System.Drawing.Point(120, 64);
            this.numHomeTimeoutP.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numHomeTimeoutP.Name = "numHomeTimeoutP";
            this.numHomeTimeoutP.Size = new System.Drawing.Size(90, 23);
            this.numHomeTimeoutP.TabIndex = 7;
            this.numHomeTimeoutP.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblSlVel
            // 
            this.lblSlVel.AutoSize = true;
            this.lblSlVel.Location = new System.Drawing.Point(250, 68);
            this.lblSlVel.Name = "lblSlVel";
            this.lblSlVel.Size = new System.Drawing.Size(92, 17);
            this.lblSlVel.TabIndex = 8;
            this.lblSlVel.Text = "无限位检测转速";
            // 
            // numSlVel
            // 
            this.numSlVel.Location = new System.Drawing.Point(380, 64);
            this.numSlVel.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numSlVel.Name = "numSlVel";
            this.numSlVel.Size = new System.Drawing.Size(70, 23);
            this.numSlVel.TabIndex = 9;
            this.numSlVel.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // lblSlMa
            // 
            this.lblSlMa.AutoSize = true;
            this.lblSlMa.Location = new System.Drawing.Point(470, 68);
            this.lblSlMa.Name = "lblSlMa";
            this.lblSlMa.Size = new System.Drawing.Size(83, 17);
            this.lblSlMa.TabIndex = 10;
            this.lblSlMa.Text = "检测电流(mA)";
            // 
            // numSlMa
            // 
            this.numSlMa.Location = new System.Drawing.Point(580, 64);
            this.numSlMa.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numSlMa.Name = "numSlMa";
            this.numSlMa.Size = new System.Drawing.Size(60, 23);
            this.numSlMa.TabIndex = 11;
            this.numSlMa.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // lblSlMs
            // 
            this.lblSlMs.AutoSize = true;
            this.lblSlMs.Location = new System.Drawing.Point(10, 103);
            this.lblSlMs.Name = "lblSlMs";
            this.lblSlMs.Size = new System.Drawing.Size(81, 17);
            this.lblSlMs.TabIndex = 12;
            this.lblSlMs.Text = "检测时间(ms)";
            // 
            // numSlMs
            // 
            this.numSlMs.Location = new System.Drawing.Point(120, 99);
            this.numSlMs.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSlMs.Name = "numSlMs";
            this.numSlMs.Size = new System.Drawing.Size(70, 23);
            this.numSlMs.TabIndex = 13;
            this.numSlMs.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblAutoHomeP
            // 
            this.lblAutoHomeP.AutoSize = true;
            this.lblAutoHomeP.Location = new System.Drawing.Point(220, 103);
            this.lblAutoHomeP.Name = "lblAutoHomeP";
            this.lblAutoHomeP.Size = new System.Drawing.Size(80, 17);
            this.lblAutoHomeP.TabIndex = 14;
            this.lblAutoHomeP.Text = "上电自动回零";
            // 
            // cmbAutoHomeP
            // 
            this.cmbAutoHomeP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutoHomeP.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cmbAutoHomeP.Location = new System.Drawing.Point(330, 99);
            this.cmbAutoHomeP.Name = "cmbAutoHomeP";
            this.cmbAutoHomeP.Size = new System.Drawing.Size(100, 25);
            this.cmbAutoHomeP.TabIndex = 15;
            // 
            // lblSaveHomeP
            // 
            this.lblSaveHomeP.AutoSize = true;
            this.lblSaveHomeP.Location = new System.Drawing.Point(10, 138);
            this.lblSaveHomeP.Name = "lblSaveHomeP";
            this.lblSaveHomeP.Size = new System.Drawing.Size(56, 17);
            this.lblSaveHomeP.TabIndex = 16;
            this.lblSaveHomeP.Text = "是否存储";
            // 
            // cmbSaveHomeP
            // 
            this.cmbSaveHomeP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaveHomeP.Items.AddRange(new object[] {
            "否",
            "是"});
            this.cmbSaveHomeP.Location = new System.Drawing.Point(90, 134);
            this.cmbSaveHomeP.Name = "cmbSaveHomeP";
            this.cmbSaveHomeP.Size = new System.Drawing.Size(80, 25);
            this.cmbSaveHomeP.TabIndex = 17;
            // 
            // btnReadHomeP
            // 
            this.btnReadHomeP.Location = new System.Drawing.Point(10, 170);
            this.btnReadHomeP.Name = "btnReadHomeP";
            this.btnReadHomeP.Size = new System.Drawing.Size(120, 32);
            this.btnReadHomeP.TabIndex = 18;
            this.btnReadHomeP.Text = "读取回零参数";
            this.btnReadHomeP.Click += new System.EventHandler(this.btnReadHomeP_Click);
            // 
            // btnWriteHomeP
            // 
            this.btnWriteHomeP.Location = new System.Drawing.Point(140, 170);
            this.btnWriteHomeP.Name = "btnWriteHomeP";
            this.btnWriteHomeP.Size = new System.Drawing.Size(120, 32);
            this.btnWriteHomeP.TabIndex = 19;
            this.btnWriteHomeP.Text = "修改回零参数";
            this.btnWriteHomeP.Click += new System.EventHandler(this.btnWriteHomeP_Click);
            // 
            // lblHomeNote
            // 
            this.lblHomeNote.AutoSize = true;
            this.lblHomeNote.ForeColor = System.Drawing.Color.Gray;
            this.lblHomeNote.Location = new System.Drawing.Point(280, 170);
            this.lblHomeNote.Name = "lblHomeNote";
            this.lblHomeNote.Size = new System.Drawing.Size(184, 34);
            this.lblHomeNote.TabIndex = 20;
            this.lblHomeNote.Text = "先读取确认参数，再修改；\n“是否存储”选“是”才会掉电保存。";
            // 
            // groupHomeCmd
            // 
            this.groupHomeCmd.Controls.Add(this.lblHomeModeC);
            this.groupHomeCmd.Controls.Add(this.cmbHomeModeC);
            this.groupHomeCmd.Controls.Add(this.lblHomeSyncC);
            this.groupHomeCmd.Controls.Add(this.cmbHomeSyncC);
            this.groupHomeCmd.Controls.Add(this.btnTriggerHome);
            this.groupHomeCmd.Controls.Add(this.btnSetHomeZero);
            this.groupHomeCmd.Controls.Add(this.cmbSaveZero);
            this.groupHomeCmd.Controls.Add(this.btnAbortHome);
            this.groupHomeCmd.Controls.Add(this.lblHomeCmdNote);
            this.groupHomeCmd.Location = new System.Drawing.Point(930, 10);
            this.groupHomeCmd.Name = "groupHomeCmd";
            this.groupHomeCmd.Size = new System.Drawing.Size(520, 220);
            this.groupHomeCmd.TabIndex = 2;
            this.groupHomeCmd.TabStop = false;
            this.groupHomeCmd.Text = "命令触发回零";
            // 
            // lblHomeModeC
            // 
            this.lblHomeModeC.AutoSize = true;
            this.lblHomeModeC.Location = new System.Drawing.Point(10, 33);
            this.lblHomeModeC.Name = "lblHomeModeC";
            this.lblHomeModeC.Size = new System.Drawing.Size(56, 17);
            this.lblHomeModeC.TabIndex = 0;
            this.lblHomeModeC.Text = "回零模式";
            // 
            // cmbHomeModeC
            // 
            this.cmbHomeModeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeModeC.Items.AddRange(new object[] {
            "Nearest（就近）",
            "Dir（方向）",
            "Collision（碰撞）",
            "EndStop（限位）"});
            this.cmbHomeModeC.Location = new System.Drawing.Point(90, 29);
            this.cmbHomeModeC.Name = "cmbHomeModeC";
            this.cmbHomeModeC.Size = new System.Drawing.Size(140, 25);
            this.cmbHomeModeC.TabIndex = 1;
            // 
            // lblHomeSyncC
            // 
            this.lblHomeSyncC.AutoSize = true;
            this.lblHomeSyncC.Location = new System.Drawing.Point(250, 33);
            this.lblHomeSyncC.Name = "lblHomeSyncC";
            this.lblHomeSyncC.Size = new System.Drawing.Size(56, 17);
            this.lblHomeSyncC.TabIndex = 2;
            this.lblHomeSyncC.Text = "多机同步";
            // 
            // cmbHomeSyncC
            // 
            this.cmbHomeSyncC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeSyncC.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbHomeSyncC.Location = new System.Drawing.Point(340, 29);
            this.cmbHomeSyncC.Name = "cmbHomeSyncC";
            this.cmbHomeSyncC.Size = new System.Drawing.Size(90, 25);
            this.cmbHomeSyncC.TabIndex = 3;
            // 
            // btnTriggerHome
            // 
            this.btnTriggerHome.Location = new System.Drawing.Point(10, 65);
            this.btnTriggerHome.Name = "btnTriggerHome";
            this.btnTriggerHome.Size = new System.Drawing.Size(160, 36);
            this.btnTriggerHome.TabIndex = 4;
            this.btnTriggerHome.Text = "触发回零";
            this.btnTriggerHome.Click += new System.EventHandler(this.btnTriggerHome_Click);
            // 
            // btnSetHomeZero
            // 
            this.btnSetHomeZero.Location = new System.Drawing.Point(10, 115);
            this.btnSetHomeZero.Name = "btnSetHomeZero";
            this.btnSetHomeZero.Size = new System.Drawing.Size(190, 36);
            this.btnSetHomeZero.TabIndex = 5;
            this.btnSetHomeZero.Text = "设置单圈回零零点";
            this.btnSetHomeZero.Click += new System.EventHandler(this.btnSetHomeZero_Click);
            // 
            // cmbSaveZero
            // 
            this.cmbSaveZero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaveZero.Items.AddRange(new object[] {
            "否",
            "是"});
            this.cmbSaveZero.Location = new System.Drawing.Point(210, 119);
            this.cmbSaveZero.Name = "cmbSaveZero";
            this.cmbSaveZero.Size = new System.Drawing.Size(80, 25);
            this.cmbSaveZero.TabIndex = 6;
            // 
            // btnAbortHome
            // 
            this.btnAbortHome.Location = new System.Drawing.Point(10, 165);
            this.btnAbortHome.Name = "btnAbortHome";
            this.btnAbortHome.Size = new System.Drawing.Size(160, 36);
            this.btnAbortHome.TabIndex = 7;
            this.btnAbortHome.Text = "强制中断回零";
            this.btnAbortHome.Click += new System.EventHandler(this.btnAbortHome_Click);
            // 
            // lblHomeCmdNote
            // 
            this.lblHomeCmdNote.AutoSize = true;
            this.lblHomeCmdNote.ForeColor = System.Drawing.Color.Gray;
            this.lblHomeCmdNote.Location = new System.Drawing.Point(300, 65);
            this.lblHomeCmdNote.Name = "lblHomeCmdNote";
            this.lblHomeCmdNote.Size = new System.Drawing.Size(106, 85);
            this.lblHomeCmdNote.TabIndex = 8;
            this.lblHomeCmdNote.Text = "说明：\n1. 先设置回零参数\n2. 再设单圈零点\n3. 触发回零\n4. 异常时强制中断";
            // 
            // groupStatus
            // 
            this.groupStatus.Controls.Add(this.btnReadStatus);
            this.groupStatus.Controls.Add(this.chkLiveStatus);
            this.groupStatus.Controls.Add(this.lblBusVolt);
            this.groupStatus.Controls.Add(this.txtBusVolt);
            this.groupStatus.Controls.Add(this.lblPhaseCur);
            this.groupStatus.Controls.Add(this.txtPhaseCur);
            this.groupStatus.Controls.Add(this.lblEncoder);
            this.groupStatus.Controls.Add(this.txtEncoder);
            this.groupStatus.Controls.Add(this.lblTargetPos);
            this.groupStatus.Controls.Add(this.txtTargetPos);
            this.groupStatus.Controls.Add(this.lblSpeed);
            this.groupStatus.Controls.Add(this.txtSpeed);
            this.groupStatus.Controls.Add(this.lblRealPos);
            this.groupStatus.Controls.Add(this.txtRealPos);
            this.groupStatus.Controls.Add(this.lblPosErr);
            this.groupStatus.Controls.Add(this.txtPosErr);
            this.groupStatus.Controls.Add(this.lblHoming);
            this.groupStatus.Controls.Add(this.txtHoming);
            this.groupStatus.Controls.Add(this.lblHomeFail);
            this.groupStatus.Controls.Add(this.txtHomeFail);
            this.groupStatus.Controls.Add(this.lblEnabled);
            this.groupStatus.Controls.Add(this.txtEnabled);
            this.groupStatus.Controls.Add(this.lblInPlace);
            this.groupStatus.Controls.Add(this.txtInPlace);
            this.groupStatus.Controls.Add(this.lblStall);
            this.groupStatus.Controls.Add(this.txtStall);
            this.groupStatus.Controls.Add(this.lblStallProt);
            this.groupStatus.Controls.Add(this.txtStallProt);
            this.groupStatus.Location = new System.Drawing.Point(10, 240);
            this.groupStatus.Name = "groupStatus";
            this.groupStatus.Size = new System.Drawing.Size(250, 560);
            this.groupStatus.TabIndex = 3;
            this.groupStatus.TabStop = false;
            this.groupStatus.Text = "读取系统状态";
            // 
            // btnReadStatus
            // 
            this.btnReadStatus.Location = new System.Drawing.Point(10, 28);
            this.btnReadStatus.Name = "btnReadStatus";
            this.btnReadStatus.Size = new System.Drawing.Size(130, 32);
            this.btnReadStatus.TabIndex = 0;
            this.btnReadStatus.Text = "读取系统状态参数";
            this.btnReadStatus.Click += new System.EventHandler(this.btnReadStatus_Click);
            // 
            // chkLiveStatus
            // 
            this.chkLiveStatus.AutoSize = true;
            this.chkLiveStatus.Checked = true;
            this.chkLiveStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLiveStatus.Location = new System.Drawing.Point(148, 34);
            this.chkLiveStatus.Name = "chkLiveStatus";
            this.chkLiveStatus.Size = new System.Drawing.Size(75, 21);
            this.chkLiveStatus.TabIndex = 1;
            this.chkLiveStatus.Text = "实时刷新";
            this.chkLiveStatus.CheckedChanged += new System.EventHandler(this.chkLiveStatus_CheckedChanged);
            // 
            // lblBusVolt
            // 
            this.lblBusVolt.AutoSize = true;
            this.lblBusVolt.Location = new System.Drawing.Point(10, 79);
            this.lblBusVolt.Name = "lblBusVolt";
            this.lblBusVolt.Size = new System.Drawing.Size(72, 17);
            this.lblBusVolt.TabIndex = 2;
            this.lblBusVolt.Text = "总线电压(V)";
            // 
            // txtBusVolt
            // 
            this.txtBusVolt.Location = new System.Drawing.Point(120, 75);
            this.txtBusVolt.Name = "txtBusVolt";
            this.txtBusVolt.ReadOnly = true;
            this.txtBusVolt.Size = new System.Drawing.Size(110, 23);
            this.txtBusVolt.TabIndex = 3;
            // 
            // lblPhaseCur
            // 
            this.lblPhaseCur.AutoSize = true;
            this.lblPhaseCur.Location = new System.Drawing.Point(10, 112);
            this.lblPhaseCur.Name = "lblPhaseCur";
            this.lblPhaseCur.Size = new System.Drawing.Size(71, 17);
            this.lblPhaseCur.TabIndex = 4;
            this.lblPhaseCur.Text = "相电流(mA)";
            // 
            // txtPhaseCur
            // 
            this.txtPhaseCur.Location = new System.Drawing.Point(120, 108);
            this.txtPhaseCur.Name = "txtPhaseCur";
            this.txtPhaseCur.ReadOnly = true;
            this.txtPhaseCur.Size = new System.Drawing.Size(110, 23);
            this.txtPhaseCur.TabIndex = 5;
            // 
            // lblEncoder
            // 
            this.lblEncoder.AutoSize = true;
            this.lblEncoder.Location = new System.Drawing.Point(10, 145);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(80, 17);
            this.lblEncoder.TabIndex = 6;
            this.lblEncoder.Text = "编码器线性值";
            // 
            // txtEncoder
            // 
            this.txtEncoder.Location = new System.Drawing.Point(120, 141);
            this.txtEncoder.Name = "txtEncoder";
            this.txtEncoder.ReadOnly = true;
            this.txtEncoder.Size = new System.Drawing.Size(110, 23);
            this.txtEncoder.TabIndex = 7;
            // 
            // lblTargetPos
            // 
            this.lblTargetPos.AutoSize = true;
            this.lblTargetPos.Location = new System.Drawing.Point(10, 178);
            this.lblTargetPos.Name = "lblTargetPos";
            this.lblTargetPos.Size = new System.Drawing.Size(69, 17);
            this.lblTargetPos.TabIndex = 8;
            this.lblTargetPos.Text = "目标位置(°)";
            // 
            // txtTargetPos
            // 
            this.txtTargetPos.Location = new System.Drawing.Point(120, 174);
            this.txtTargetPos.Name = "txtTargetPos";
            this.txtTargetPos.ReadOnly = true;
            this.txtTargetPos.Size = new System.Drawing.Size(110, 23);
            this.txtTargetPos.TabIndex = 9;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(10, 211);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(91, 17);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "实时转速(RPM)";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(120, 207);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(110, 23);
            this.txtSpeed.TabIndex = 11;
            // 
            // lblRealPos
            // 
            this.lblRealPos.AutoSize = true;
            this.lblRealPos.Location = new System.Drawing.Point(10, 244);
            this.lblRealPos.Name = "lblRealPos";
            this.lblRealPos.Size = new System.Drawing.Size(69, 17);
            this.lblRealPos.TabIndex = 12;
            this.lblRealPos.Text = "实时位置(°)";
            // 
            // txtRealPos
            // 
            this.txtRealPos.Location = new System.Drawing.Point(120, 240);
            this.txtRealPos.Name = "txtRealPos";
            this.txtRealPos.ReadOnly = true;
            this.txtRealPos.Size = new System.Drawing.Size(110, 23);
            this.txtRealPos.TabIndex = 13;
            // 
            // lblPosErr
            // 
            this.lblPosErr.AutoSize = true;
            this.lblPosErr.Location = new System.Drawing.Point(10, 277);
            this.lblPosErr.Name = "lblPosErr";
            this.lblPosErr.Size = new System.Drawing.Size(69, 17);
            this.lblPosErr.TabIndex = 14;
            this.lblPosErr.Text = "位置误差(°)";
            // 
            // txtPosErr
            // 
            this.txtPosErr.Location = new System.Drawing.Point(120, 273);
            this.txtPosErr.Name = "txtPosErr";
            this.txtPosErr.ReadOnly = true;
            this.txtPosErr.Size = new System.Drawing.Size(110, 23);
            this.txtPosErr.TabIndex = 15;
            // 
            // lblHoming
            // 
            this.lblHoming.AutoSize = true;
            this.lblHoming.Location = new System.Drawing.Point(10, 310);
            this.lblHoming.Name = "lblHoming";
            this.lblHoming.Size = new System.Drawing.Size(56, 17);
            this.lblHoming.TabIndex = 16;
            this.lblHoming.Text = "正在回零";
            // 
            // txtHoming
            // 
            this.txtHoming.Location = new System.Drawing.Point(120, 306);
            this.txtHoming.Name = "txtHoming";
            this.txtHoming.ReadOnly = true;
            this.txtHoming.Size = new System.Drawing.Size(110, 23);
            this.txtHoming.TabIndex = 17;
            // 
            // lblHomeFail
            // 
            this.lblHomeFail.AutoSize = true;
            this.lblHomeFail.Location = new System.Drawing.Point(10, 343);
            this.lblHomeFail.Name = "lblHomeFail";
            this.lblHomeFail.Size = new System.Drawing.Size(56, 17);
            this.lblHomeFail.TabIndex = 18;
            this.lblHomeFail.Text = "回零失败";
            // 
            // txtHomeFail
            // 
            this.txtHomeFail.Location = new System.Drawing.Point(120, 339);
            this.txtHomeFail.Name = "txtHomeFail";
            this.txtHomeFail.ReadOnly = true;
            this.txtHomeFail.Size = new System.Drawing.Size(110, 23);
            this.txtHomeFail.TabIndex = 19;
            // 
            // lblEnabled
            // 
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.Location = new System.Drawing.Point(10, 376);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(56, 17);
            this.lblEnabled.TabIndex = 20;
            this.lblEnabled.Text = "使能状态";
            // 
            // txtEnabled
            // 
            this.txtEnabled.Location = new System.Drawing.Point(120, 372);
            this.txtEnabled.Name = "txtEnabled";
            this.txtEnabled.ReadOnly = true;
            this.txtEnabled.Size = new System.Drawing.Size(110, 23);
            this.txtEnabled.TabIndex = 21;
            // 
            // lblInPlace
            // 
            this.lblInPlace.AutoSize = true;
            this.lblInPlace.Location = new System.Drawing.Point(10, 409);
            this.lblInPlace.Name = "lblInPlace";
            this.lblInPlace.Size = new System.Drawing.Size(56, 17);
            this.lblInPlace.TabIndex = 22;
            this.lblInPlace.Text = "电机到位";
            // 
            // txtInPlace
            // 
            this.txtInPlace.Location = new System.Drawing.Point(120, 405);
            this.txtInPlace.Name = "txtInPlace";
            this.txtInPlace.ReadOnly = true;
            this.txtInPlace.Size = new System.Drawing.Size(110, 23);
            this.txtInPlace.TabIndex = 23;
            // 
            // lblStall
            // 
            this.lblStall.AutoSize = true;
            this.lblStall.Location = new System.Drawing.Point(10, 442);
            this.lblStall.Name = "lblStall";
            this.lblStall.Size = new System.Drawing.Size(56, 17);
            this.lblStall.TabIndex = 24;
            this.lblStall.Text = "电机堵转";
            // 
            // txtStall
            // 
            this.txtStall.Location = new System.Drawing.Point(120, 438);
            this.txtStall.Name = "txtStall";
            this.txtStall.ReadOnly = true;
            this.txtStall.Size = new System.Drawing.Size(110, 23);
            this.txtStall.TabIndex = 25;
            // 
            // lblStallProt
            // 
            this.lblStallProt.AutoSize = true;
            this.lblStallProt.Location = new System.Drawing.Point(10, 475);
            this.lblStallProt.Name = "lblStallProt";
            this.lblStallProt.Size = new System.Drawing.Size(56, 17);
            this.lblStallProt.TabIndex = 26;
            this.lblStallProt.Text = "堵转保护";
            // 
            // txtStallProt
            // 
            this.txtStallProt.Location = new System.Drawing.Point(120, 471);
            this.txtStallProt.Name = "txtStallProt";
            this.txtStallProt.ReadOnly = true;
            this.txtStallProt.Size = new System.Drawing.Size(110, 23);
            this.txtStallProt.TabIndex = 27;
            // 
            // groupDrive
            // 
            this.groupDrive.Controls.Add(this.lblMStep);
            this.groupDrive.Controls.Add(this.numMStep);
            this.groupDrive.Controls.Add(this.lblMa);
            this.groupDrive.Controls.Add(this.numMa);
            this.groupDrive.Controls.Add(this.lblMaLimit);
            this.groupDrive.Controls.Add(this.numMaLimit);
            this.groupDrive.Controls.Add(this.lblVmLimit);
            this.groupDrive.Controls.Add(this.numVmLimit);
            this.groupDrive.Controls.Add(this.lblUartBaud);
            this.groupDrive.Controls.Add(this.numUartBaud);
            this.groupDrive.Controls.Add(this.lblCanBaud);
            this.groupDrive.Controls.Add(this.numCanBaud);
            this.groupDrive.Controls.Add(this.lblChecksumType);
            this.groupDrive.Controls.Add(this.numChecksumType);
            this.groupDrive.Controls.Add(this.lblClogRpm);
            this.groupDrive.Controls.Add(this.numClogRpm);
            this.groupDrive.Controls.Add(this.lblClogMa);
            this.groupDrive.Controls.Add(this.numClogMa);
            this.groupDrive.Controls.Add(this.lblClogMs);
            this.groupDrive.Controls.Add(this.numClogMs);
            this.groupDrive.Controls.Add(this.lblPosWindow);
            this.groupDrive.Controls.Add(this.numPosWindow);
            this.groupDrive.Controls.Add(this.lblClogPro);
            this.groupDrive.Controls.Add(this.cmbClogPro);
            this.groupDrive.Controls.Add(this.txtDriveRaw);
            this.groupDrive.Controls.Add(this.btnReadDrive);
            this.groupDrive.Controls.Add(this.btnWriteDrive);
            this.groupDrive.Controls.Add(this.lblSaveDrive);
            this.groupDrive.Controls.Add(this.cmbSaveDrive);
            this.groupDrive.Controls.Add(this.lblDriveNote);
            this.groupDrive.Controls.Add(this.lblIdAddr);
            this.groupDrive.Controls.Add(this.numId);
            this.groupDrive.Controls.Add(this.btnWriteId);
            this.groupDrive.Controls.Add(this.lblIdNote);
            this.groupDrive.Location = new System.Drawing.Point(270, 320);
            this.groupDrive.Name = "groupDrive";
            this.groupDrive.Size = new System.Drawing.Size(650, 560);
            this.groupDrive.TabIndex = 4;
            this.groupDrive.TabStop = false;
            this.groupDrive.Text = "修改驱动参数";
            // 
            // lblMStep
            // 
            this.lblMStep.AutoSize = true;
            this.lblMStep.Location = new System.Drawing.Point(10, 32);
            this.lblMStep.Name = "lblMStep";
            this.lblMStep.Size = new System.Drawing.Size(32, 17);
            this.lblMStep.TabIndex = 0;
            this.lblMStep.Text = "细分";
            // 
            // numMStep
            // 
            this.numMStep.Location = new System.Drawing.Point(120, 28);
            this.numMStep.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numMStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMStep.Name = "numMStep";
            this.numMStep.Size = new System.Drawing.Size(100, 23);
            this.numMStep.TabIndex = 1;
            this.numMStep.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(330, 32);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(83, 17);
            this.lblMa.TabIndex = 2;
            this.lblMa.Text = "开环电流(mA)";
            // 
            // numMa
            // 
            this.numMa.Location = new System.Drawing.Point(440, 28);
            this.numMa.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numMa.Name = "numMa";
            this.numMa.Size = new System.Drawing.Size(100, 23);
            this.numMa.TabIndex = 3;
            this.numMa.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblMaLimit
            // 
            this.lblMaLimit.AutoSize = true;
            this.lblMaLimit.Location = new System.Drawing.Point(10, 64);
            this.lblMaLimit.Name = "lblMaLimit";
            this.lblMaLimit.Size = new System.Drawing.Size(107, 17);
            this.lblMaLimit.TabIndex = 4;
            this.lblMaLimit.Text = "闭环最大电流(mA)";
            // 
            // numMaLimit
            // 
            this.numMaLimit.Location = new System.Drawing.Point(120, 60);
            this.numMaLimit.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numMaLimit.Name = "numMaLimit";
            this.numMaLimit.Size = new System.Drawing.Size(100, 23);
            this.numMaLimit.TabIndex = 5;
            this.numMaLimit.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // lblVmLimit
            // 
            this.lblVmLimit.AutoSize = true;
            this.lblVmLimit.Location = new System.Drawing.Point(330, 64);
            this.lblVmLimit.Name = "lblVmLimit";
            this.lblVmLimit.Size = new System.Drawing.Size(80, 17);
            this.lblVmLimit.TabIndex = 6;
            this.lblVmLimit.Text = "闭环最大转速";
            // 
            // numVmLimit
            // 
            this.numVmLimit.Location = new System.Drawing.Point(440, 60);
            this.numVmLimit.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numVmLimit.Name = "numVmLimit";
            this.numVmLimit.Size = new System.Drawing.Size(100, 23);
            this.numVmLimit.TabIndex = 7;
            this.numVmLimit.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // lblUartBaud
            // 
            this.lblUartBaud.AutoSize = true;
            this.lblUartBaud.Location = new System.Drawing.Point(10, 96);
            this.lblUartBaud.Name = "lblUartBaud";
            this.lblUartBaud.Size = new System.Drawing.Size(92, 17);
            this.lblUartBaud.TabIndex = 8;
            this.lblUartBaud.Text = "串口波特率档位";
            // 
            // numUartBaud
            // 
            this.numUartBaud.Location = new System.Drawing.Point(120, 92);
            this.numUartBaud.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUartBaud.Name = "numUartBaud";
            this.numUartBaud.Size = new System.Drawing.Size(100, 23);
            this.numUartBaud.TabIndex = 9;
            this.numUartBaud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblCanBaud
            // 
            this.lblCanBaud.AutoSize = true;
            this.lblCanBaud.Location = new System.Drawing.Point(330, 96);
            this.lblCanBaud.Name = "lblCanBaud";
            this.lblCanBaud.Size = new System.Drawing.Size(82, 17);
            this.lblCanBaud.TabIndex = 10;
            this.lblCanBaud.Text = "CAN速率档位";
            // 
            // numCanBaud
            // 
            this.numCanBaud.Location = new System.Drawing.Point(440, 92);
            this.numCanBaud.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCanBaud.Name = "numCanBaud";
            this.numCanBaud.Size = new System.Drawing.Size(100, 23);
            this.numCanBaud.TabIndex = 11;
            this.numCanBaud.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblChecksumType
            // 
            this.lblChecksumType.AutoSize = true;
            this.lblChecksumType.Location = new System.Drawing.Point(10, 128);
            this.lblChecksumType.Name = "lblChecksumType";
            this.lblChecksumType.Size = new System.Drawing.Size(80, 17);
            this.lblChecksumType.TabIndex = 12;
            this.lblChecksumType.Text = "校验方式档位";
            // 
            // numChecksumType
            // 
            this.numChecksumType.Location = new System.Drawing.Point(120, 124);
            this.numChecksumType.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numChecksumType.Name = "numChecksumType";
            this.numChecksumType.Size = new System.Drawing.Size(100, 23);
            this.numChecksumType.TabIndex = 13;
            // 
            // lblClogRpm
            // 
            this.lblClogRpm.AutoSize = true;
            this.lblClogRpm.Location = new System.Drawing.Point(10, 160);
            this.lblClogRpm.Name = "lblClogRpm";
            this.lblClogRpm.Size = new System.Drawing.Size(91, 17);
            this.lblClogRpm.TabIndex = 14;
            this.lblClogRpm.Text = "堵转转速(RPM)";
            // 
            // numClogRpm
            // 
            this.numClogRpm.Location = new System.Drawing.Point(120, 156);
            this.numClogRpm.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numClogRpm.Name = "numClogRpm";
            this.numClogRpm.Size = new System.Drawing.Size(100, 23);
            this.numClogRpm.TabIndex = 15;
            this.numClogRpm.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblClogMa
            // 
            this.lblClogMa.AutoSize = true;
            this.lblClogMa.Location = new System.Drawing.Point(330, 160);
            this.lblClogMa.Name = "lblClogMa";
            this.lblClogMa.Size = new System.Drawing.Size(83, 17);
            this.lblClogMa.TabIndex = 16;
            this.lblClogMa.Text = "堵转电流(mA)";
            // 
            // numClogMa
            // 
            this.numClogMa.Location = new System.Drawing.Point(440, 156);
            this.numClogMa.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numClogMa.Name = "numClogMa";
            this.numClogMa.Size = new System.Drawing.Size(100, 23);
            this.numClogMa.TabIndex = 17;
            this.numClogMa.Value = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            // 
            // lblClogMs
            // 
            this.lblClogMs.AutoSize = true;
            this.lblClogMs.Location = new System.Drawing.Point(10, 192);
            this.lblClogMs.Name = "lblClogMs";
            this.lblClogMs.Size = new System.Drawing.Size(81, 17);
            this.lblClogMs.TabIndex = 18;
            this.lblClogMs.Text = "堵转时间(ms)";
            // 
            // numClogMs
            // 
            this.numClogMs.Location = new System.Drawing.Point(120, 188);
            this.numClogMs.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numClogMs.Name = "numClogMs";
            this.numClogMs.Size = new System.Drawing.Size(100, 23);
            this.numClogMs.TabIndex = 19;
            this.numClogMs.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblPosWindow
            // 
            this.lblPosWindow.AutoSize = true;
            this.lblPosWindow.Location = new System.Drawing.Point(330, 192);
            this.lblPosWindow.Name = "lblPosWindow";
            this.lblPosWindow.Size = new System.Drawing.Size(56, 17);
            this.lblPosWindow.TabIndex = 20;
            this.lblPosWindow.Text = "位置窗口";
            // 
            // numPosWindow
            // 
            this.numPosWindow.Location = new System.Drawing.Point(440, 188);
            this.numPosWindow.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPosWindow.Name = "numPosWindow";
            this.numPosWindow.Size = new System.Drawing.Size(100, 23);
            this.numPosWindow.TabIndex = 21;
            this.numPosWindow.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblClogPro
            // 
            this.lblClogPro.AutoSize = true;
            this.lblClogPro.Location = new System.Drawing.Point(330, 128);
            this.lblClogPro.Name = "lblClogPro";
            this.lblClogPro.Size = new System.Drawing.Size(56, 17);
            this.lblClogPro.TabIndex = 22;
            this.lblClogPro.Text = "堵转保护";
            // 
            // cmbClogPro
            // 
            this.cmbClogPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClogPro.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cmbClogPro.Location = new System.Drawing.Point(440, 124);
            this.cmbClogPro.Name = "cmbClogPro";
            this.cmbClogPro.Size = new System.Drawing.Size(100, 25);
            this.cmbClogPro.TabIndex = 23;
            // 
            // txtDriveRaw
            // 
            this.txtDriveRaw.Location = new System.Drawing.Point(10, 230);
            this.txtDriveRaw.Name = "txtDriveRaw";
            this.txtDriveRaw.ReadOnly = true;
            this.txtDriveRaw.Size = new System.Drawing.Size(630, 23);
            this.txtDriveRaw.TabIndex = 24;
            // 
            // btnReadDrive
            // 
            this.btnReadDrive.Location = new System.Drawing.Point(10, 295);
            this.btnReadDrive.Name = "btnReadDrive";
            this.btnReadDrive.Size = new System.Drawing.Size(120, 32);
            this.btnReadDrive.TabIndex = 25;
            this.btnReadDrive.Text = "读取驱动参数";
            this.btnReadDrive.Click += new System.EventHandler(this.btnReadDrive_Click);
            // 
            // btnWriteDrive
            // 
            this.btnWriteDrive.Location = new System.Drawing.Point(140, 295);
            this.btnWriteDrive.Name = "btnWriteDrive";
            this.btnWriteDrive.Size = new System.Drawing.Size(120, 32);
            this.btnWriteDrive.TabIndex = 26;
            this.btnWriteDrive.Text = "修改驱动参数";
            this.btnWriteDrive.Click += new System.EventHandler(this.btnWriteDrive_Click);
            // 
            // lblSaveDrive
            // 
            this.lblSaveDrive.AutoSize = true;
            this.lblSaveDrive.Location = new System.Drawing.Point(270, 300);
            this.lblSaveDrive.Name = "lblSaveDrive";
            this.lblSaveDrive.Size = new System.Drawing.Size(56, 17);
            this.lblSaveDrive.TabIndex = 27;
            this.lblSaveDrive.Text = "是否存储";
            // 
            // cmbSaveDrive
            // 
            this.cmbSaveDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaveDrive.Items.AddRange(new object[] {
            "否",
            "是"});
            this.cmbSaveDrive.Location = new System.Drawing.Point(340, 296);
            this.cmbSaveDrive.Name = "cmbSaveDrive";
            this.cmbSaveDrive.Size = new System.Drawing.Size(80, 25);
            this.cmbSaveDrive.TabIndex = 28;
            // 
            // lblDriveNote
            // 
            this.lblDriveNote.AutoSize = true;
            this.lblDriveNote.ForeColor = System.Drawing.Color.Gray;
            this.lblDriveNote.Location = new System.Drawing.Point(10, 340);
            this.lblDriveNote.Name = "lblDriveNote";
            this.lblDriveNote.Size = new System.Drawing.Size(248, 34);
            this.lblDriveNote.TabIndex = 29;
            this.lblDriveNote.Text = "驱动参数按 X 系列 V2 的 24 项解析；\n参数个数不匹配时只读，避免写坏固件参数。";
            // 
            // lblIdAddr
            // 
            this.lblIdAddr.AutoSize = true;
            this.lblIdAddr.Location = new System.Drawing.Point(10, 395);
            this.lblIdAddr.Name = "lblIdAddr";
            this.lblIdAddr.Size = new System.Drawing.Size(45, 17);
            this.lblIdAddr.TabIndex = 30;
            this.lblIdAddr.Text = "ID地址";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(70, 391);
            this.numId.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(70, 23);
            this.numId.TabIndex = 31;
            this.numId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnWriteId
            // 
            this.btnWriteId.Location = new System.Drawing.Point(150, 387);
            this.btnWriteId.Name = "btnWriteId";
            this.btnWriteId.Size = new System.Drawing.Size(160, 32);
            this.btnWriteId.TabIndex = 32;
            this.btnWriteId.Text = "写入并保存ID地址";
            this.btnWriteId.Click += new System.EventHandler(this.btnWriteId_Click);
            // 
            // lblIdNote
            // 
            this.lblIdNote.AutoSize = true;
            this.lblIdNote.ForeColor = System.Drawing.Color.Gray;
            this.lblIdNote.Location = new System.Drawing.Point(320, 392);
            this.lblIdNote.Name = "lblIdNote";
            this.lblIdNote.Size = new System.Drawing.Size(140, 17);
            this.lblIdNote.TabIndex = 33;
            this.lblIdNote.Text = "改完地址要重新打开串口";
            // 
            // groupMotion
            // 
            this.groupMotion.Controls.Add(this.btnEnable);
            this.groupMotion.Controls.Add(this.btnDisable);
            this.groupMotion.Controls.Add(this.lblSyncEn);
            this.groupMotion.Controls.Add(this.cmbSyncEn);
            this.groupMotion.Controls.Add(this.lblSpeedDir);
            this.groupMotion.Controls.Add(this.cmbSpeedDir);
            this.groupMotion.Controls.Add(this.lblSpeedVal);
            this.groupMotion.Controls.Add(this.numSpeedVal);
            this.groupMotion.Controls.Add(this.lblAccVal);
            this.groupMotion.Controls.Add(this.numAccVal);
            this.groupMotion.Controls.Add(this.lblSyncSpeed);
            this.groupMotion.Controls.Add(this.cmbSyncSpeed);
            this.groupMotion.Controls.Add(this.btnSendSpeed);
            this.groupMotion.Controls.Add(this.lblPosDir);
            this.groupMotion.Controls.Add(this.cmbPosDir);
            this.groupMotion.Controls.Add(this.lblPosSpeed);
            this.groupMotion.Controls.Add(this.numPosSpeed);
            this.groupMotion.Controls.Add(this.lblPosAcc);
            this.groupMotion.Controls.Add(this.numPosAcc);
            this.groupMotion.Controls.Add(this.lblPulses);
            this.groupMotion.Controls.Add(this.numPulses);
            this.groupMotion.Controls.Add(this.lblRaF);
            this.groupMotion.Controls.Add(this.cmbRaF);
            this.groupMotion.Controls.Add(this.lblSyncPos);
            this.groupMotion.Controls.Add(this.cmbSyncPos);
            this.groupMotion.Controls.Add(this.btnSendPos);
            this.groupMotion.Location = new System.Drawing.Point(930, 240);
            this.groupMotion.Name = "groupMotion";
            this.groupMotion.Size = new System.Drawing.Size(520, 400);
            this.groupMotion.TabIndex = 5;
            this.groupMotion.TabStop = false;
            this.groupMotion.Text = "运动控制";
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(10, 30);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(130, 36);
            this.btnEnable.TabIndex = 0;
            this.btnEnable.Text = "使能驱动板";
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(150, 30);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(130, 36);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "关闭驱动板";
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lblSyncEn
            // 
            this.lblSyncEn.AutoSize = true;
            this.lblSyncEn.Location = new System.Drawing.Point(300, 37);
            this.lblSyncEn.Name = "lblSyncEn";
            this.lblSyncEn.Size = new System.Drawing.Size(32, 17);
            this.lblSyncEn.TabIndex = 2;
            this.lblSyncEn.Text = "同步";
            // 
            // cmbSyncEn
            // 
            this.cmbSyncEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyncEn.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSyncEn.Location = new System.Drawing.Point(350, 33);
            this.cmbSyncEn.Name = "cmbSyncEn";
            this.cmbSyncEn.Size = new System.Drawing.Size(80, 25);
            this.cmbSyncEn.TabIndex = 3;
            // 
            // lblSpeedDir
            // 
            this.lblSpeedDir.AutoSize = true;
            this.lblSpeedDir.Location = new System.Drawing.Point(10, 96);
            this.lblSpeedDir.Name = "lblSpeedDir";
            this.lblSpeedDir.Size = new System.Drawing.Size(32, 17);
            this.lblSpeedDir.TabIndex = 4;
            this.lblSpeedDir.Text = "方向";
            // 
            // cmbSpeedDir
            // 
            this.cmbSpeedDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeedDir.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.cmbSpeedDir.Location = new System.Drawing.Point(60, 92);
            this.cmbSpeedDir.Name = "cmbSpeedDir";
            this.cmbSpeedDir.Size = new System.Drawing.Size(80, 25);
            this.cmbSpeedDir.TabIndex = 5;
            // 
            // lblSpeedVal
            // 
            this.lblSpeedVal.AutoSize = true;
            this.lblSpeedVal.Location = new System.Drawing.Point(160, 96);
            this.lblSpeedVal.Name = "lblSpeedVal";
            this.lblSpeedVal.Size = new System.Drawing.Size(67, 17);
            this.lblSpeedVal.TabIndex = 6;
            this.lblSpeedVal.Text = "速度(RPM)";
            // 
            // numSpeedVal
            // 
            this.numSpeedVal.Location = new System.Drawing.Point(240, 92);
            this.numSpeedVal.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numSpeedVal.Name = "numSpeedVal";
            this.numSpeedVal.Size = new System.Drawing.Size(80, 23);
            this.numSpeedVal.TabIndex = 7;
            this.numSpeedVal.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblAccVal
            // 
            this.lblAccVal.AutoSize = true;
            this.lblAccVal.Location = new System.Drawing.Point(320, 96);
            this.lblAccVal.Name = "lblAccVal";
            this.lblAccVal.Size = new System.Drawing.Size(44, 17);
            this.lblAccVal.TabIndex = 8;
            this.lblAccVal.Text = "加速度";
            // 
            // numAccVal
            // 
            this.numAccVal.Location = new System.Drawing.Point(400, 92);
            this.numAccVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAccVal.Name = "numAccVal";
            this.numAccVal.Size = new System.Drawing.Size(70, 23);
            this.numAccVal.TabIndex = 9;
            this.numAccVal.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblSyncSpeed
            // 
            this.lblSyncSpeed.AutoSize = true;
            this.lblSyncSpeed.Location = new System.Drawing.Point(10, 131);
            this.lblSyncSpeed.Name = "lblSyncSpeed";
            this.lblSyncSpeed.Size = new System.Drawing.Size(32, 17);
            this.lblSyncSpeed.TabIndex = 10;
            this.lblSyncSpeed.Text = "同步";
            // 
            // cmbSyncSpeed
            // 
            this.cmbSyncSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyncSpeed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSyncSpeed.Location = new System.Drawing.Point(60, 127);
            this.cmbSyncSpeed.Name = "cmbSyncSpeed";
            this.cmbSyncSpeed.Size = new System.Drawing.Size(80, 25);
            this.cmbSyncSpeed.TabIndex = 11;
            // 
            // btnSendSpeed
            // 
            this.btnSendSpeed.Location = new System.Drawing.Point(160, 122);
            this.btnSendSpeed.Name = "btnSendSpeed";
            this.btnSendSpeed.Size = new System.Drawing.Size(120, 30);
            this.btnSendSpeed.TabIndex = 12;
            this.btnSendSpeed.Text = "发送速度指令";
            this.btnSendSpeed.Click += new System.EventHandler(this.btnSendSpeed_Click);
            // 
            // lblPosDir
            // 
            this.lblPosDir.AutoSize = true;
            this.lblPosDir.Location = new System.Drawing.Point(10, 181);
            this.lblPosDir.Name = "lblPosDir";
            this.lblPosDir.Size = new System.Drawing.Size(32, 17);
            this.lblPosDir.TabIndex = 13;
            this.lblPosDir.Text = "方向";
            // 
            // cmbPosDir
            // 
            this.cmbPosDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosDir.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.cmbPosDir.Location = new System.Drawing.Point(60, 177);
            this.cmbPosDir.Name = "cmbPosDir";
            this.cmbPosDir.Size = new System.Drawing.Size(80, 25);
            this.cmbPosDir.TabIndex = 14;
            // 
            // lblPosSpeed
            // 
            this.lblPosSpeed.AutoSize = true;
            this.lblPosSpeed.Location = new System.Drawing.Point(160, 181);
            this.lblPosSpeed.Name = "lblPosSpeed";
            this.lblPosSpeed.Size = new System.Drawing.Size(32, 17);
            this.lblPosSpeed.TabIndex = 15;
            this.lblPosSpeed.Text = "速度";
            // 
            // numPosSpeed
            // 
            this.numPosSpeed.Location = new System.Drawing.Point(210, 177);
            this.numPosSpeed.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numPosSpeed.Name = "numPosSpeed";
            this.numPosSpeed.Size = new System.Drawing.Size(70, 23);
            this.numPosSpeed.TabIndex = 16;
            this.numPosSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblPosAcc
            // 
            this.lblPosAcc.AutoSize = true;
            this.lblPosAcc.Location = new System.Drawing.Point(276, 179);
            this.lblPosAcc.Name = "lblPosAcc";
            this.lblPosAcc.Size = new System.Drawing.Size(44, 17);
            this.lblPosAcc.TabIndex = 17;
            this.lblPosAcc.Text = "加速度";
            // 
            // numPosAcc
            // 
            this.numPosAcc.Location = new System.Drawing.Point(350, 177);
            this.numPosAcc.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPosAcc.Name = "numPosAcc";
            this.numPosAcc.Size = new System.Drawing.Size(60, 23);
            this.numPosAcc.TabIndex = 18;
            this.numPosAcc.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblPulses
            // 
            this.lblPulses.AutoSize = true;
            this.lblPulses.Location = new System.Drawing.Point(10, 216);
            this.lblPulses.Name = "lblPulses";
            this.lblPulses.Size = new System.Drawing.Size(44, 17);
            this.lblPulses.TabIndex = 19;
            this.lblPulses.Text = "脉冲数";
            // 
            // numPulses
            // 
            this.numPulses.Location = new System.Drawing.Point(70, 212);
            this.numPulses.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPulses.Name = "numPulses";
            this.numPulses.Size = new System.Drawing.Size(100, 23);
            this.numPulses.TabIndex = 20;
            this.numPulses.Value = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            // 
            // lblRaF
            // 
            this.lblRaF.AutoSize = true;
            this.lblRaF.Location = new System.Drawing.Point(190, 216);
            this.lblRaF.Name = "lblRaF";
            this.lblRaF.Size = new System.Drawing.Size(61, 17);
            this.lblRaF.TabIndex = 21;
            this.lblRaF.Text = "相对/绝对";
            // 
            // cmbRaF
            // 
            this.cmbRaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaF.Items.AddRange(new object[] {
            "0 相对上次目标",
            "1 绝对零点",
            "2 相对当前位置"});
            this.cmbRaF.Location = new System.Drawing.Point(260, 212);
            this.cmbRaF.Name = "cmbRaF";
            this.cmbRaF.Size = new System.Drawing.Size(110, 25);
            this.cmbRaF.TabIndex = 22;
            // 
            // lblSyncPos
            // 
            this.lblSyncPos.AutoSize = true;
            this.lblSyncPos.Location = new System.Drawing.Point(380, 216);
            this.lblSyncPos.Name = "lblSyncPos";
            this.lblSyncPos.Size = new System.Drawing.Size(32, 17);
            this.lblSyncPos.TabIndex = 23;
            this.lblSyncPos.Text = "同步";
            // 
            // cmbSyncPos
            // 
            this.cmbSyncPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyncPos.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSyncPos.Location = new System.Drawing.Point(430, 212);
            this.cmbSyncPos.Name = "cmbSyncPos";
            this.cmbSyncPos.Size = new System.Drawing.Size(70, 25);
            this.cmbSyncPos.TabIndex = 24;
            // 
            // btnSendPos
            // 
            this.btnSendPos.Location = new System.Drawing.Point(10, 250);
            this.btnSendPos.Name = "btnSendPos";
            this.btnSendPos.Size = new System.Drawing.Size(130, 30);
            this.btnSendPos.TabIndex = 25;
            this.btnSendPos.Text = "发送位置指令";
            this.btnSendPos.Click += new System.EventHandler(this.btnSendPos_Click);
            // 
            // groupQuick
            // 
            this.groupQuick.Controls.Add(this.btnClearPos);
            this.groupQuick.Controls.Add(this.btnStopNow);
            this.groupQuick.Controls.Add(this.lblSyncStop);
            this.groupQuick.Controls.Add(this.cmbSyncStop);
            this.groupQuick.Controls.Add(this.btnSyncMove);
            this.groupQuick.Controls.Add(this.btnResetStall);
            this.groupQuick.Controls.Add(this.lblQuickNote);
            this.groupQuick.Location = new System.Drawing.Point(930, 650);
            this.groupQuick.Name = "groupQuick";
            this.groupQuick.Size = new System.Drawing.Size(520, 220);
            this.groupQuick.TabIndex = 6;
            this.groupQuick.TabStop = false;
            this.groupQuick.Text = "辅助操作";
            // 
            // btnClearPos
            // 
            this.btnClearPos.Location = new System.Drawing.Point(10, 30);
            this.btnClearPos.Name = "btnClearPos";
            this.btnClearPos.Size = new System.Drawing.Size(140, 36);
            this.btnClearPos.TabIndex = 0;
            this.btnClearPos.Text = "当前位置清零";
            this.btnClearPos.Click += new System.EventHandler(this.btnClearPos_Click);
            // 
            // btnStopNow
            // 
            this.btnStopNow.Location = new System.Drawing.Point(170, 30);
            this.btnStopNow.Name = "btnStopNow";
            this.btnStopNow.Size = new System.Drawing.Size(140, 36);
            this.btnStopNow.TabIndex = 1;
            this.btnStopNow.Text = "立即停止";
            this.btnStopNow.Click += new System.EventHandler(this.btnStopNow_Click);
            // 
            // lblSyncStop
            // 
            this.lblSyncStop.AutoSize = true;
            this.lblSyncStop.Location = new System.Drawing.Point(320, 37);
            this.lblSyncStop.Name = "lblSyncStop";
            this.lblSyncStop.Size = new System.Drawing.Size(32, 17);
            this.lblSyncStop.TabIndex = 2;
            this.lblSyncStop.Text = "同步";
            // 
            // cmbSyncStop
            // 
            this.cmbSyncStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyncStop.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSyncStop.Location = new System.Drawing.Point(380, 33);
            this.cmbSyncStop.Name = "cmbSyncStop";
            this.cmbSyncStop.Size = new System.Drawing.Size(80, 25);
            this.cmbSyncStop.TabIndex = 3;
            // 
            // btnSyncMove
            // 
            this.btnSyncMove.Location = new System.Drawing.Point(10, 85);
            this.btnSyncMove.Name = "btnSyncMove";
            this.btnSyncMove.Size = new System.Drawing.Size(140, 36);
            this.btnSyncMove.TabIndex = 4;
            this.btnSyncMove.Text = "触发同步运动";
            this.btnSyncMove.Click += new System.EventHandler(this.btnSyncMove_Click);
            // 
            // btnResetStall
            // 
            this.btnResetStall.Location = new System.Drawing.Point(170, 85);
            this.btnResetStall.Name = "btnResetStall";
            this.btnResetStall.Size = new System.Drawing.Size(140, 36);
            this.btnResetStall.TabIndex = 5;
            this.btnResetStall.Text = "解除堵转保护";
            this.btnResetStall.Click += new System.EventHandler(this.btnResetStall_Click);
            // 
            // lblQuickNote
            // 
            this.lblQuickNote.AutoSize = true;
            this.lblQuickNote.ForeColor = System.Drawing.Color.Gray;
            this.lblQuickNote.Location = new System.Drawing.Point(10, 140);
            this.lblQuickNote.Name = "lblQuickNote";
            this.lblQuickNote.Size = new System.Drawing.Size(279, 17);
            this.lblQuickNote.TabIndex = 6;
            this.lblQuickNote.Text = "同步运动用于“多机同步标志=真”的命令一起启动。";
            // 
            // groupPid
            // 
            this.groupPid.Controls.Add(this.lblKp1);
            this.groupPid.Controls.Add(this.numKp1);
            this.groupPid.Controls.Add(this.lblKp2);
            this.groupPid.Controls.Add(this.numKp2);
            this.groupPid.Controls.Add(this.lblKp3);
            this.groupPid.Controls.Add(this.numKp3);
            this.groupPid.Controls.Add(this.lblKi);
            this.groupPid.Controls.Add(this.numKi);
            this.groupPid.Controls.Add(this.btnReadPid);
            this.groupPid.Controls.Add(this.btnWritePid);
            this.groupPid.Controls.Add(this.lblSavePid);
            this.groupPid.Controls.Add(this.cmbSavePid);
            this.groupPid.Location = new System.Drawing.Point(930, 890);
            this.groupPid.Name = "groupPid";
            this.groupPid.Size = new System.Drawing.Size(520, 130);
            this.groupPid.TabIndex = 7;
            this.groupPid.TabStop = false;
            this.groupPid.Text = "修改PID参数";
            // 
            // lblKp1
            // 
            this.lblKp1.AutoSize = true;
            this.lblKp1.Location = new System.Drawing.Point(10, 33);
            this.lblKp1.Name = "lblKp1";
            this.lblKp1.Size = new System.Drawing.Size(67, 17);
            this.lblKp1.TabIndex = 0;
            this.lblKp1.Text = "位置环Kp1";
            // 
            // numKp1
            // 
            this.numKp1.Location = new System.Drawing.Point(90, 29);
            this.numKp1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numKp1.Name = "numKp1";
            this.numKp1.Size = new System.Drawing.Size(90, 23);
            this.numKp1.TabIndex = 1;
            this.numKp1.Value = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            // 
            // lblKp2
            // 
            this.lblKp2.AutoSize = true;
            this.lblKp2.Location = new System.Drawing.Point(10, 68);
            this.lblKp2.Name = "lblKp2";
            this.lblKp2.Size = new System.Drawing.Size(67, 17);
            this.lblKp2.TabIndex = 2;
            this.lblKp2.Text = "位置环Kp2";
            // 
            // numKp2
            // 
            this.numKp2.Location = new System.Drawing.Point(90, 64);
            this.numKp2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numKp2.Name = "numKp2";
            this.numKp2.Size = new System.Drawing.Size(90, 23);
            this.numKp2.TabIndex = 3;
            // 
            // lblKp3
            // 
            this.lblKp3.AutoSize = true;
            this.lblKp3.Location = new System.Drawing.Point(220, 33);
            this.lblKp3.Name = "lblKp3";
            this.lblKp3.Size = new System.Drawing.Size(60, 17);
            this.lblKp3.TabIndex = 4;
            this.lblKp3.Text = "速度环Kp";
            // 
            // numKp3
            // 
            this.numKp3.Location = new System.Drawing.Point(300, 29);
            this.numKp3.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numKp3.Name = "numKp3";
            this.numKp3.Size = new System.Drawing.Size(90, 23);
            this.numKp3.TabIndex = 5;
            this.numKp3.Value = new decimal(new int[] {
            18000,
            0,
            0,
            0});
            // 
            // lblKi
            // 
            this.lblKi.AutoSize = true;
            this.lblKi.Location = new System.Drawing.Point(220, 68);
            this.lblKi.Name = "lblKi";
            this.lblKi.Size = new System.Drawing.Size(55, 17);
            this.lblKi.TabIndex = 6;
            this.lblKi.Text = "速度环Ki";
            // 
            // numKi
            // 
            this.numKi.Location = new System.Drawing.Point(300, 64);
            this.numKi.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numKi.Name = "numKi";
            this.numKi.Size = new System.Drawing.Size(90, 23);
            this.numKi.TabIndex = 7;
            this.numKi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnReadPid
            // 
            this.btnReadPid.Location = new System.Drawing.Point(400, 28);
            this.btnReadPid.Name = "btnReadPid";
            this.btnReadPid.Size = new System.Drawing.Size(100, 30);
            this.btnReadPid.TabIndex = 8;
            this.btnReadPid.Text = "读取PID";
            this.btnReadPid.Click += new System.EventHandler(this.btnReadPid_Click);
            // 
            // btnWritePid
            // 
            this.btnWritePid.Location = new System.Drawing.Point(400, 64);
            this.btnWritePid.Name = "btnWritePid";
            this.btnWritePid.Size = new System.Drawing.Size(100, 30);
            this.btnWritePid.TabIndex = 9;
            this.btnWritePid.Text = "修改PID";
            this.btnWritePid.Click += new System.EventHandler(this.btnWritePid_Click);
            // 
            // lblSavePid
            // 
            this.lblSavePid.AutoSize = true;
            this.lblSavePid.Location = new System.Drawing.Point(10, 98);
            this.lblSavePid.Name = "lblSavePid";
            this.lblSavePid.Size = new System.Drawing.Size(56, 17);
            this.lblSavePid.TabIndex = 10;
            this.lblSavePid.Text = "是否存储";
            // 
            // cmbSavePid
            // 
            this.cmbSavePid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSavePid.Items.AddRange(new object[] {
            "否",
            "是"});
            this.cmbSavePid.Location = new System.Drawing.Point(70, 94);
            this.cmbSavePid.Name = "cmbSavePid";
            this.cmbSavePid.Size = new System.Drawing.Size(80, 25);
            this.cmbSavePid.TabIndex = 11;
            // 
            // lblToolStatus
            // 
            this.lblToolStatus.AutoSize = true;
            this.lblToolStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblToolStatus.Location = new System.Drawing.Point(10, 1030);
            this.lblToolStatus.Name = "lblToolStatus";
            this.lblToolStatus.Size = new System.Drawing.Size(32, 17);
            this.lblToolStatus.TabIndex = 8;
            this.lblToolStatus.Text = "就绪";
            // 
            // 下拉框默认项（VS 设计器重排时可能丢失 SelectedIndex，运行时会再兜底一次）
            // 
            this.cmbHomeModeP.SelectedIndex = 0;
            this.cmbHomeDirP.SelectedIndex = 0;
            this.cmbAutoHomeP.SelectedIndex = 0;
            this.cmbSaveHomeP.SelectedIndex = 0;
            this.cmbHomeModeC.SelectedIndex = 0;
            this.cmbHomeSyncC.SelectedIndex = 0;
            this.cmbSaveZero.SelectedIndex = 0;
            this.cmbSyncEn.SelectedIndex = 0;
            this.cmbSpeedDir.SelectedIndex = 0;
            this.cmbSyncSpeed.SelectedIndex = 0;
            this.cmbPosDir.SelectedIndex = 0;
            this.cmbRaF.SelectedIndex = 0;
            this.cmbSyncPos.SelectedIndex = 0;
            this.cmbSyncStop.SelectedIndex = 0;
            this.cmbClogPro.SelectedIndex = 1;
            this.cmbSaveDrive.SelectedIndex = 0;
            this.cmbSavePid.SelectedIndex = 0;
            // 
            // ZdtToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 940);
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "ZdtToolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZDT 调试工具 — 参数 / 回零 / 运动";
            this.scrollPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.groupSerial.ResumeLayout(false);
            this.groupSerial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToolAddr)).EndInit();
            this.groupHomeParams.ResumeLayout(false);
            this.groupHomeParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeSpeedP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHomeTimeoutP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSlMs)).EndInit();
            this.groupHomeCmd.ResumeLayout(false);
            this.groupHomeCmd.PerformLayout();
            this.groupStatus.ResumeLayout(false);
            this.groupStatus.PerformLayout();
            this.groupDrive.ResumeLayout(false);
            this.groupDrive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVmLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUartBaud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanBaud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChecksumType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClogRpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClogMa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClogMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.groupMotion.ResumeLayout(false);
            this.groupMotion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPulses)).EndInit();
            this.groupQuick.ResumeLayout(false);
            this.groupQuick.PerformLayout();
            this.groupPid.ResumeLayout(false);
            this.groupPid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.GroupBox groupSerial;
        private System.Windows.Forms.GroupBox groupHomeParams;
        private System.Windows.Forms.GroupBox groupHomeCmd;
        private System.Windows.Forms.GroupBox groupStatus;
        private System.Windows.Forms.GroupBox groupDrive;
        private System.Windows.Forms.GroupBox groupMotion;
        private System.Windows.Forms.GroupBox groupQuick;
        private System.Windows.Forms.GroupBox groupPid;
        private System.Windows.Forms.Label lblToolPort;
        private System.Windows.Forms.ComboBox cboToolPort;
        private System.Windows.Forms.Label lblToolBaud;
        private System.Windows.Forms.ComboBox cboToolBaud;
        private System.Windows.Forms.Label lblToolAddr;
        private System.Windows.Forms.NumericUpDown numToolAddr;
        private System.Windows.Forms.Label lblChecksum;
        private System.Windows.Forms.TextBox txtChecksum;
        private System.Windows.Forms.Button btnToolOpen;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.Label lblHomeModeP;
        private System.Windows.Forms.ComboBox cmbHomeModeP;
        private System.Windows.Forms.Label lblHomeDirP;
        private System.Windows.Forms.ComboBox cmbHomeDirP;
        private System.Windows.Forms.Label lblHomeSpeedP;
        private System.Windows.Forms.NumericUpDown numHomeSpeedP;
        private System.Windows.Forms.Label lblHomeTimeoutP;
        private System.Windows.Forms.NumericUpDown numHomeTimeoutP;
        private System.Windows.Forms.Label lblSlVel;
        private System.Windows.Forms.NumericUpDown numSlVel;
        private System.Windows.Forms.Label lblSlMa;
        private System.Windows.Forms.NumericUpDown numSlMa;
        private System.Windows.Forms.Label lblSlMs;
        private System.Windows.Forms.NumericUpDown numSlMs;
        private System.Windows.Forms.Label lblAutoHomeP;
        private System.Windows.Forms.ComboBox cmbAutoHomeP;
        private System.Windows.Forms.Label lblSaveHomeP;
        private System.Windows.Forms.ComboBox cmbSaveHomeP;
        private System.Windows.Forms.Button btnReadHomeP;
        private System.Windows.Forms.Button btnWriteHomeP;
        private System.Windows.Forms.Label lblHomeNote;
        private System.Windows.Forms.Label lblHomeModeC;
        private System.Windows.Forms.ComboBox cmbHomeModeC;
        private System.Windows.Forms.Label lblHomeSyncC;
        private System.Windows.Forms.ComboBox cmbHomeSyncC;
        private System.Windows.Forms.Button btnTriggerHome;
        private System.Windows.Forms.Button btnSetHomeZero;
        private System.Windows.Forms.ComboBox cmbSaveZero;
        private System.Windows.Forms.Button btnAbortHome;
        private System.Windows.Forms.Label lblHomeCmdNote;
        private System.Windows.Forms.Button btnReadStatus;
        private System.Windows.Forms.CheckBox chkLiveStatus;
        private System.Windows.Forms.Label lblBusVolt;
        private System.Windows.Forms.TextBox txtBusVolt;
        private System.Windows.Forms.Label lblPhaseCur;
        private System.Windows.Forms.TextBox txtPhaseCur;
        private System.Windows.Forms.Label lblEncoder;
        private System.Windows.Forms.TextBox txtEncoder;
        private System.Windows.Forms.Label lblTargetPos;
        private System.Windows.Forms.TextBox txtTargetPos;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblRealPos;
        private System.Windows.Forms.TextBox txtRealPos;
        private System.Windows.Forms.Label lblPosErr;
        private System.Windows.Forms.TextBox txtPosErr;
        private System.Windows.Forms.Label lblHoming;
        private System.Windows.Forms.TextBox txtHoming;
        private System.Windows.Forms.Label lblHomeFail;
        private System.Windows.Forms.TextBox txtHomeFail;
        private System.Windows.Forms.Label lblEnabled;
        private System.Windows.Forms.TextBox txtEnabled;
        private System.Windows.Forms.Label lblInPlace;
        private System.Windows.Forms.TextBox txtInPlace;
        private System.Windows.Forms.Label lblStall;
        private System.Windows.Forms.TextBox txtStall;
        private System.Windows.Forms.Label lblStallProt;
        private System.Windows.Forms.TextBox txtStallProt;
        private System.Windows.Forms.Label lblMStep;
        private System.Windows.Forms.NumericUpDown numMStep;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.NumericUpDown numMa;
        private System.Windows.Forms.Label lblMaLimit;
        private System.Windows.Forms.NumericUpDown numMaLimit;
        private System.Windows.Forms.Label lblVmLimit;
        private System.Windows.Forms.NumericUpDown numVmLimit;
        private System.Windows.Forms.Label lblUartBaud;
        private System.Windows.Forms.NumericUpDown numUartBaud;
        private System.Windows.Forms.Label lblCanBaud;
        private System.Windows.Forms.NumericUpDown numCanBaud;
        private System.Windows.Forms.Label lblChecksumType;
        private System.Windows.Forms.NumericUpDown numChecksumType;
        private System.Windows.Forms.Label lblClogRpm;
        private System.Windows.Forms.NumericUpDown numClogRpm;
        private System.Windows.Forms.Label lblClogMa;
        private System.Windows.Forms.NumericUpDown numClogMa;
        private System.Windows.Forms.Label lblClogMs;
        private System.Windows.Forms.NumericUpDown numClogMs;
        private System.Windows.Forms.Label lblPosWindow;
        private System.Windows.Forms.NumericUpDown numPosWindow;
        private System.Windows.Forms.Label lblClogPro;
        private System.Windows.Forms.ComboBox cmbClogPro;
        private System.Windows.Forms.TextBox txtDriveRaw;
        private System.Windows.Forms.Button btnReadDrive;
        private System.Windows.Forms.Button btnWriteDrive;
        private System.Windows.Forms.Label lblSaveDrive;
        private System.Windows.Forms.ComboBox cmbSaveDrive;
        private System.Windows.Forms.Label lblDriveNote;
        private System.Windows.Forms.Label lblIdAddr;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Button btnWriteId;
        private System.Windows.Forms.Label lblIdNote;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Label lblSyncEn;
        private System.Windows.Forms.ComboBox cmbSyncEn;
        private System.Windows.Forms.Label lblSpeedDir;
        private System.Windows.Forms.ComboBox cmbSpeedDir;
        private System.Windows.Forms.Label lblSpeedVal;
        private System.Windows.Forms.NumericUpDown numSpeedVal;
        private System.Windows.Forms.Label lblAccVal;
        private System.Windows.Forms.NumericUpDown numAccVal;
        private System.Windows.Forms.Label lblSyncSpeed;
        private System.Windows.Forms.ComboBox cmbSyncSpeed;
        private System.Windows.Forms.Button btnSendSpeed;
        private System.Windows.Forms.Label lblPosDir;
        private System.Windows.Forms.ComboBox cmbPosDir;
        private System.Windows.Forms.Label lblPosSpeed;
        private System.Windows.Forms.NumericUpDown numPosSpeed;
        private System.Windows.Forms.Label lblPosAcc;
        private System.Windows.Forms.NumericUpDown numPosAcc;
        private System.Windows.Forms.Label lblPulses;
        private System.Windows.Forms.NumericUpDown numPulses;
        private System.Windows.Forms.Label lblRaF;
        private System.Windows.Forms.ComboBox cmbRaF;
        private System.Windows.Forms.Label lblSyncPos;
        private System.Windows.Forms.ComboBox cmbSyncPos;
        private System.Windows.Forms.Button btnSendPos;
        private System.Windows.Forms.Button btnClearPos;
        private System.Windows.Forms.Button btnStopNow;
        private System.Windows.Forms.Label lblSyncStop;
        private System.Windows.Forms.ComboBox cmbSyncStop;
        private System.Windows.Forms.Button btnSyncMove;
        private System.Windows.Forms.Button btnResetStall;
        private System.Windows.Forms.Label lblQuickNote;
        private System.Windows.Forms.Label lblKp1;
        private System.Windows.Forms.NumericUpDown numKp1;
        private System.Windows.Forms.Label lblKp2;
        private System.Windows.Forms.NumericUpDown numKp2;
        private System.Windows.Forms.Label lblKp3;
        private System.Windows.Forms.NumericUpDown numKp3;
        private System.Windows.Forms.Label lblKi;
        private System.Windows.Forms.NumericUpDown numKi;
        private System.Windows.Forms.Button btnReadPid;
        private System.Windows.Forms.Button btnWritePid;
        private System.Windows.Forms.Label lblSavePid;
        private System.Windows.Forms.ComboBox cmbSavePid;
        private System.Windows.Forms.Label lblToolStatus;
    }
}