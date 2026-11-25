namespace ZdtMotorGui
{
    /// <summary>
    /// 单轴面板的设计器文件：所有按钮、输入框、分组框都在这里创建。
    /// 这样在 Visual Studio 里打开 MainForm 或 AxisPanel 的设计器，
    /// 都能直接看到完整界面，而不是运行时才出现。
    /// </summary>
    partial class AxisPanel
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

        #region 组件设计器生成的代码

        private void InitializeComponent()
        {
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.posPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPosBig = new System.Windows.Forms.Label();
            this.lblPosCaption = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupParam = new System.Windows.Forms.GroupBox();
            this.paramLayout = new System.Windows.Forms.TableLayoutPanel();
            this.row1Param = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.lblPpr = new System.Windows.Forms.Label();
            this.numPpr = new System.Windows.Forms.NumericUpDown();
            this.lblUnitsCaption = new System.Windows.Forms.Label();
            this.numUnits = new System.Windows.Forms.NumericUpDown();
            this.lblUnitUnits = new System.Windows.Forms.Label();
            this.row2Param = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblAcc = new System.Windows.Forms.Label();
            this.numAcc = new System.Windows.Forms.NumericUpDown();
            this.chkInvert = new System.Windows.Forms.CheckBox();
            this.groupMove = new System.Windows.Forms.GroupBox();
            this.moveLayout = new System.Windows.Forms.TableLayoutPanel();
            this.row1Move = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTarget = new System.Windows.Forms.Label();
            this.numTarget = new System.Windows.Forms.NumericUpDown();
            this.lblUnitTarget = new System.Windows.Forms.Label();
            this.rdoAbs = new System.Windows.Forms.RadioButton();
            this.rdoRel = new System.Windows.Forms.RadioButton();
            this.row2Move = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupJog = new System.Windows.Forms.GroupBox();
            this.jogLayout = new System.Windows.Forms.TableLayoutPanel();
            this.row1Jog = new System.Windows.Forms.FlowLayoutPanel();
            this.btnJogNeg = new System.Windows.Forms.Button();
            this.btnJogPos = new System.Windows.Forms.Button();
            this.lblJogHint = new System.Windows.Forms.Label();
            this.row2Jog = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStep = new System.Windows.Forms.Label();
            this.numStep = new System.Windows.Forms.NumericUpDown();
            this.lblUnitStep = new System.Windows.Forms.Label();
            this.btnStepNeg = new System.Windows.Forms.Button();
            this.btnStepPos = new System.Windows.Forms.Button();
            this.groupHome = new System.Windows.Forms.GroupBox();
            this.homeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rowHome = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHomeMode = new System.Windows.Forms.Label();
            this.cmbHomeMode = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHomeAbort = new System.Windows.Forms.Button();
            this.groupZero = new System.Windows.Forms.GroupBox();
            this.zeroLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rowZero = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSetZero = new System.Windows.Forms.Button();
            this.btnClearPos = new System.Windows.Forms.Button();
            this.btnResetStall = new System.Windows.Forms.Button();
            this.groupLimit = new System.Windows.Forms.GroupBox();
            this.limitLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rowLimit = new System.Windows.Forms.FlowLayoutPanel();
            this.chkUseLimits = new System.Windows.Forms.CheckBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.lblUnitLimit = new System.Windows.Forms.Label();
            this.scrollPanel.SuspendLayout();
            this.rootLayout.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.posPanel.SuspendLayout();
            this.groupParam.SuspendLayout();
            this.paramLayout.SuspendLayout();
            this.row1Param.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).BeginInit();
            this.row2Param.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcc)).BeginInit();
            this.groupMove.SuspendLayout();
            this.moveLayout.SuspendLayout();
            this.row1Move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            this.row2Move.SuspendLayout();
            this.groupJog.SuspendLayout();
            this.jogLayout.SuspendLayout();
            this.row1Jog.SuspendLayout();
            this.row2Jog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
            this.groupHome.SuspendLayout();
            this.homeLayout.SuspendLayout();
            this.rowHome.SuspendLayout();
            this.groupZero.SuspendLayout();
            this.zeroLayout.SuspendLayout();
            this.rowZero.SuspendLayout();
            this.groupLimit.SuspendLayout();
            this.limitLayout.SuspendLayout();
            this.rowLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.rootLayout);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(560, 760);
            this.scrollPanel.TabIndex = 0;
            // 
            // rootLayout
            // 
            this.rootLayout.AutoSize = true;
            this.rootLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Controls.Add(this.headerLayout, 0, 0);
            this.rootLayout.Controls.Add(this.posPanel, 0, 1);
            this.rootLayout.Controls.Add(this.groupParam, 0, 2);
            this.rootLayout.Controls.Add(this.groupMove, 0, 3);
            this.rootLayout.Controls.Add(this.groupJog, 0, 4);
            this.rootLayout.Controls.Add(this.groupHome, 0, 5);
            this.rootLayout.Controls.Add(this.groupZero, 0, 6);
            this.rootLayout.Controls.Add(this.groupLimit, 0, 7);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.Padding = new System.Windows.Forms.Padding(2);
            this.rootLayout.RowCount = 8;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootLayout.Size = new System.Drawing.Size(560, 691);
            this.rootLayout.TabIndex = 0;
            // 
            // headerLayout
            // 
            this.headerLayout.AutoSize = true;
            this.headerLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerLayout.ColumnCount = 2;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.headerLayout.Controls.Add(this.lblTitle, 0, 0);
            this.headerLayout.Controls.Add(this.chkEnable, 1, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(5, 5);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.headerLayout.Size = new System.Drawing.Size(550, 35);
            this.headerLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(4, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(26, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "轴";
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Location = new System.Drawing.Point(495, 10);
            this.chkEnable.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(51, 21);
            this.chkEnable.TabIndex = 1;
            this.chkEnable.Text = "使能";
            this.chkEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckedChanged);
            // 
            // posPanel
            // 
            this.posPanel.AutoSize = true;
            this.posPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.posPanel.Controls.Add(this.lblPosBig);
            this.posPanel.Controls.Add(this.lblPosCaption);
            this.posPanel.Controls.Add(this.lblFeedback);
            this.posPanel.Controls.Add(this.lblStatus);
            this.posPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.posPanel.Location = new System.Drawing.Point(4, 43);
            this.posPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.posPanel.Name = "posPanel";
            this.posPanel.Size = new System.Drawing.Size(552, 95);
            this.posPanel.TabIndex = 1;
            this.posPanel.WrapContents = false;
            // 
            // lblPosBig
            // 
            this.lblPosBig.AutoSize = true;
            this.lblPosBig.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold);
            this.lblPosBig.Location = new System.Drawing.Point(4, 0);
            this.lblPosBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosBig.Name = "lblPosBig";
            this.lblPosBig.Size = new System.Drawing.Size(111, 36);
            this.lblPosBig.TabIndex = 0;
            this.lblPosBig.Text = "0.00 °";
            // 
            // lblPosCaption
            // 
            this.lblPosCaption.AutoSize = true;
            this.lblPosCaption.ForeColor = System.Drawing.Color.Gray;
            this.lblPosCaption.Location = new System.Drawing.Point(6, 36);
            this.lblPosCaption.Margin = new System.Windows.Forms.Padding(6, 0, 4, 2);
            this.lblPosCaption.Name = "lblPosCaption";
            this.lblPosCaption.Size = new System.Drawing.Size(224, 17);
            this.lblPosCaption.TabIndex = 1;
            this.lblPosCaption.Text = "软件位置（累计指令，不是编码器反馈）";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(6, 55);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(6, 0, 4, 2);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(54, 17);
            this.lblFeedback.TabIndex = 2;
            this.lblFeedback.Text = "反馈：--";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(6, 74);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 4, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 17);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "未连接";
            // 
            // groupParam
            // 
            this.groupParam.AutoSize = true;
            this.groupParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupParam.Controls.Add(this.paramLayout);
            this.groupParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupParam.Location = new System.Drawing.Point(4, 146);
            this.groupParam.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupParam.Name = "groupParam";
            this.groupParam.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.groupParam.Size = new System.Drawing.Size(552, 97);
            this.groupParam.TabIndex = 2;
            this.groupParam.TabStop = false;
            this.groupParam.Text = "参数与换算";
            // 
            // paramLayout
            // 
            this.paramLayout.AutoSize = true;
            this.paramLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paramLayout.ColumnCount = 1;
            this.paramLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paramLayout.Controls.Add(this.row1Param, 0, 0);
            this.paramLayout.Controls.Add(this.row2Param, 0, 1);
            this.paramLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.paramLayout.Location = new System.Drawing.Point(6, 20);
            this.paramLayout.Name = "paramLayout";
            this.paramLayout.Padding = new System.Windows.Forms.Padding(2);
            this.paramLayout.RowCount = 2;
            this.paramLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.paramLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.paramLayout.Size = new System.Drawing.Size(540, 71);
            this.paramLayout.TabIndex = 0;
            // 
            // row1Param
            // 
            this.row1Param.AutoSize = true;
            this.row1Param.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row1Param.Controls.Add(this.lblAddress);
            this.row1Param.Controls.Add(this.numAddress);
            this.row1Param.Controls.Add(this.lblPpr);
            this.row1Param.Controls.Add(this.numPpr);
            this.row1Param.Controls.Add(this.lblUnitsCaption);
            this.row1Param.Controls.Add(this.numUnits);
            this.row1Param.Controls.Add(this.lblUnitUnits);
            this.row1Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1Param.Location = new System.Drawing.Point(4, 3);
            this.row1Param.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row1Param.Name = "row1Param";
            this.row1Param.Size = new System.Drawing.Size(532, 31);
            this.row1Param.TabIndex = 0;
            this.row1Param.WrapContents = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(4, 7);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(32, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "地址";
            // 
            // numAddress
            // 
            this.numAddress.Location = new System.Drawing.Point(40, 4);
            this.numAddress.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numAddress.Maximum = new decimal(new int[] {
            247,
            0,
            0,
            0});
            this.numAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddress.Name = "numAddress";
            this.numAddress.Size = new System.Drawing.Size(60, 23);
            this.numAddress.TabIndex = 1;
            this.numAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAddress.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // lblPpr
            // 
            this.lblPpr.AutoSize = true;
            this.lblPpr.Location = new System.Drawing.Point(112, 7);
            this.lblPpr.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblPpr.Name = "lblPpr";
            this.lblPpr.Size = new System.Drawing.Size(49, 17);
            this.lblPpr.TabIndex = 2;
            this.lblPpr.Text = "脉冲/圈";
            // 
            // numPpr
            // 
            this.numPpr.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPpr.Location = new System.Drawing.Point(165, 4);
            this.numPpr.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numPpr.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numPpr.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPpr.Name = "numPpr";
            this.numPpr.Size = new System.Drawing.Size(90, 23);
            this.numPpr.TabIndex = 3;
            this.numPpr.Value = new decimal(new int[] {
            3200,
            0,
            0,
            0});
            this.numPpr.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // lblUnitsCaption
            // 
            this.lblUnitsCaption.AutoSize = true;
            this.lblUnitsCaption.Location = new System.Drawing.Point(267, 7);
            this.lblUnitsCaption.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitsCaption.Name = "lblUnitsCaption";
            this.lblUnitsCaption.Size = new System.Drawing.Size(56, 17);
            this.lblUnitsCaption.TabIndex = 4;
            this.lblUnitsCaption.Text = "每圈角度";
            // 
            // numUnits
            // 
            this.numUnits.DecimalPlaces = 3;
            this.numUnits.Location = new System.Drawing.Point(327, 4);
            this.numUnits.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numUnits.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUnits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUnits.Name = "numUnits";
            this.numUnits.Size = new System.Drawing.Size(80, 23);
            this.numUnits.TabIndex = 5;
            this.numUnits.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numUnits.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // lblUnitUnits
            // 
            this.lblUnitUnits.AutoSize = true;
            this.lblUnitUnits.Location = new System.Drawing.Point(419, 7);
            this.lblUnitUnits.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitUnits.Name = "lblUnitUnits";
            this.lblUnitUnits.Size = new System.Drawing.Size(13, 17);
            this.lblUnitUnits.TabIndex = 6;
            this.lblUnitUnits.Text = "°";
            // 
            // row2Param
            // 
            this.row2Param.AutoSize = true;
            this.row2Param.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row2Param.Controls.Add(this.lblSpeed);
            this.row2Param.Controls.Add(this.numSpeed);
            this.row2Param.Controls.Add(this.lblAcc);
            this.row2Param.Controls.Add(this.numAcc);
            this.row2Param.Controls.Add(this.chkInvert);
            this.row2Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2Param.Location = new System.Drawing.Point(4, 36);
            this.row2Param.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row2Param.Name = "row2Param";
            this.row2Param.Size = new System.Drawing.Size(532, 32);
            this.row2Param.TabIndex = 1;
            this.row2Param.WrapContents = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(4, 7);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(67, 17);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "速度(RPM)";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(75, 4);
            this.numSpeed.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numSpeed.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(70, 23);
            this.numSpeed.TabIndex = 1;
            this.numSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSpeed.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(157, 7);
            this.lblAcc.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(85, 17);
            this.lblAcc.TabIndex = 2;
            this.lblAcc.Text = "加速度(0-255)";
            // 
            // numAcc
            // 
            this.numAcc.Location = new System.Drawing.Point(246, 4);
            this.numAcc.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numAcc.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAcc.Name = "numAcc";
            this.numAcc.Size = new System.Drawing.Size(60, 23);
            this.numAcc.TabIndex = 3;
            this.numAcc.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAcc.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // chkInvert
            // 
            this.chkInvert.AutoSize = true;
            this.chkInvert.Location = new System.Drawing.Point(324, 7);
            this.chkInvert.Margin = new System.Windows.Forms.Padding(10, 7, 4, 4);
            this.chkInvert.Name = "chkInvert";
            this.chkInvert.Size = new System.Drawing.Size(75, 21);
            this.chkInvert.TabIndex = 4;
            this.chkInvert.Text = "方向反转";
            this.chkInvert.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // groupMove
            // 
            this.groupMove.AutoSize = true;
            this.groupMove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupMove.Controls.Add(this.moveLayout);
            this.groupMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMove.Location = new System.Drawing.Point(4, 249);
            this.groupMove.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupMove.Name = "groupMove";
            this.groupMove.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.groupMove.Size = new System.Drawing.Size(552, 104);
            this.groupMove.TabIndex = 3;
            this.groupMove.TabStop = false;
            this.groupMove.Text = "定位（位置模式）";
            // 
            // moveLayout
            // 
            this.moveLayout.AutoSize = true;
            this.moveLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.moveLayout.ColumnCount = 1;
            this.moveLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.moveLayout.Controls.Add(this.row1Move, 0, 0);
            this.moveLayout.Controls.Add(this.row2Move, 0, 1);
            this.moveLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveLayout.Location = new System.Drawing.Point(6, 20);
            this.moveLayout.Name = "moveLayout";
            this.moveLayout.Padding = new System.Windows.Forms.Padding(2);
            this.moveLayout.RowCount = 2;
            this.moveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.moveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.moveLayout.Size = new System.Drawing.Size(540, 78);
            this.moveLayout.TabIndex = 0;
            // 
            // row1Move
            // 
            this.row1Move.AutoSize = true;
            this.row1Move.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row1Move.Controls.Add(this.lblTarget);
            this.row1Move.Controls.Add(this.numTarget);
            this.row1Move.Controls.Add(this.lblUnitTarget);
            this.row1Move.Controls.Add(this.rdoAbs);
            this.row1Move.Controls.Add(this.rdoRel);
            this.row1Move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1Move.Location = new System.Drawing.Point(4, 3);
            this.row1Move.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row1Move.Name = "row1Move";
            this.row1Move.Size = new System.Drawing.Size(532, 32);
            this.row1Move.TabIndex = 0;
            this.row1Move.WrapContents = false;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(4, 7);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(32, 17);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "目标";
            // 
            // numTarget
            // 
            this.numTarget.DecimalPlaces = 2;
            this.numTarget.Location = new System.Drawing.Point(40, 4);
            this.numTarget.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numTarget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTarget.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numTarget.Name = "numTarget";
            this.numTarget.Size = new System.Drawing.Size(90, 23);
            this.numTarget.TabIndex = 1;
            // 
            // lblUnitTarget
            // 
            this.lblUnitTarget.AutoSize = true;
            this.lblUnitTarget.Location = new System.Drawing.Point(142, 7);
            this.lblUnitTarget.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitTarget.Name = "lblUnitTarget";
            this.lblUnitTarget.Size = new System.Drawing.Size(13, 17);
            this.lblUnitTarget.TabIndex = 2;
            this.lblUnitTarget.Text = "°";
            // 
            // rdoAbs
            // 
            this.rdoAbs.AutoSize = true;
            this.rdoAbs.Checked = true;
            this.rdoAbs.Location = new System.Drawing.Point(169, 7);
            this.rdoAbs.Margin = new System.Windows.Forms.Padding(12, 7, 2, 4);
            this.rdoAbs.Name = "rdoAbs";
            this.rdoAbs.Size = new System.Drawing.Size(50, 21);
            this.rdoAbs.TabIndex = 3;
            this.rdoAbs.TabStop = true;
            this.rdoAbs.Text = "绝对";
            // 
            // rdoRel
            // 
            this.rdoRel.AutoSize = true;
            this.rdoRel.Location = new System.Drawing.Point(223, 7);
            this.rdoRel.Margin = new System.Windows.Forms.Padding(2, 7, 2, 4);
            this.rdoRel.Name = "rdoRel";
            this.rdoRel.Size = new System.Drawing.Size(50, 21);
            this.rdoRel.TabIndex = 4;
            this.rdoRel.Text = "相对";
            // 
            // row2Move
            // 
            this.row2Move.AutoSize = true;
            this.row2Move.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row2Move.Controls.Add(this.btnMove);
            this.row2Move.Controls.Add(this.btnStop);
            this.row2Move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2Move.Location = new System.Drawing.Point(4, 37);
            this.row2Move.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row2Move.Name = "row2Move";
            this.row2Move.Size = new System.Drawing.Size(532, 38);
            this.row2Move.TabIndex = 1;
            this.row2Move.WrapContents = false;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(4, 4);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(90, 30);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "运行";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(102, 4);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupJog
            // 
            this.groupJog.AutoSize = true;
            this.groupJog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupJog.Controls.Add(this.jogLayout);
            this.groupJog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupJog.Location = new System.Drawing.Point(4, 359);
            this.groupJog.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupJog.Name = "groupJog";
            this.groupJog.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.groupJog.Size = new System.Drawing.Size(552, 110);
            this.groupJog.TabIndex = 4;
            this.groupJog.TabStop = false;
            this.groupJog.Text = "点动 / 微调";
            // 
            // jogLayout
            // 
            this.jogLayout.AutoSize = true;
            this.jogLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jogLayout.ColumnCount = 1;
            this.jogLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.jogLayout.Controls.Add(this.row1Jog, 0, 0);
            this.jogLayout.Controls.Add(this.row2Jog, 0, 1);
            this.jogLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.jogLayout.Location = new System.Drawing.Point(6, 20);
            this.jogLayout.Name = "jogLayout";
            this.jogLayout.Padding = new System.Windows.Forms.Padding(2);
            this.jogLayout.RowCount = 2;
            this.jogLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.jogLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.jogLayout.Size = new System.Drawing.Size(540, 84);
            this.jogLayout.TabIndex = 0;
            // 
            // row1Jog
            // 
            this.row1Jog.AutoSize = true;
            this.row1Jog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row1Jog.Controls.Add(this.btnJogNeg);
            this.row1Jog.Controls.Add(this.btnJogPos);
            this.row1Jog.Controls.Add(this.lblJogHint);
            this.row1Jog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1Jog.Location = new System.Drawing.Point(4, 3);
            this.row1Jog.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row1Jog.Name = "row1Jog";
            this.row1Jog.Size = new System.Drawing.Size(532, 40);
            this.row1Jog.TabIndex = 0;
            this.row1Jog.WrapContents = false;
            // 
            // btnJogNeg
            // 
            this.btnJogNeg.Location = new System.Drawing.Point(4, 4);
            this.btnJogNeg.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogNeg.Name = "btnJogNeg";
            this.btnJogNeg.Size = new System.Drawing.Size(100, 32);
            this.btnJogNeg.TabIndex = 0;
            this.btnJogNeg.Text = "◀ 点动";
            this.btnJogNeg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogNeg_MouseDown);
            this.btnJogNeg.MouseLeave += new System.EventHandler(this.btnJogNeg_MouseLeave);
            this.btnJogNeg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogNeg_MouseUp);
            // 
            // btnJogPos
            // 
            this.btnJogPos.Location = new System.Drawing.Point(112, 4);
            this.btnJogPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogPos.Name = "btnJogPos";
            this.btnJogPos.Size = new System.Drawing.Size(100, 32);
            this.btnJogPos.TabIndex = 1;
            this.btnJogPos.Text = "点动 ▶";
            this.btnJogPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogPos_MouseDown);
            this.btnJogPos.MouseLeave += new System.EventHandler(this.btnJogPos_MouseLeave);
            this.btnJogPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogPos_MouseUp);
            // 
            // lblJogHint
            // 
            this.lblJogHint.AutoSize = true;
            this.lblJogHint.ForeColor = System.Drawing.Color.Gray;
            this.lblJogHint.Location = new System.Drawing.Point(220, 12);
            this.lblJogHint.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.lblJogHint.Name = "lblJogHint";
            this.lblJogHint.Size = new System.Drawing.Size(212, 17);
            this.lblJogHint.TabIndex = 2;
            this.lblJogHint.Text = "按住移动，松开平滑停；受软限位限制";
            // 
            // row2Jog
            // 
            this.row2Jog.AutoSize = true;
            this.row2Jog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row2Jog.Controls.Add(this.lblStep);
            this.row2Jog.Controls.Add(this.numStep);
            this.row2Jog.Controls.Add(this.lblUnitStep);
            this.row2Jog.Controls.Add(this.btnStepNeg);
            this.row2Jog.Controls.Add(this.btnStepPos);
            this.row2Jog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2Jog.Location = new System.Drawing.Point(4, 45);
            this.row2Jog.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row2Jog.Name = "row2Jog";
            this.row2Jog.Size = new System.Drawing.Size(532, 36);
            this.row2Jog.TabIndex = 1;
            this.row2Jog.WrapContents = false;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(4, 7);
            this.lblStep.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(32, 17);
            this.lblStep.TabIndex = 0;
            this.lblStep.Text = "步长";
            // 
            // numStep
            // 
            this.numStep.DecimalPlaces = 2;
            this.numStep.Location = new System.Drawing.Point(40, 4);
            this.numStep.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numStep.Name = "numStep";
            this.numStep.Size = new System.Drawing.Size(80, 23);
            this.numStep.TabIndex = 1;
            this.numStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUnitStep
            // 
            this.lblUnitStep.AutoSize = true;
            this.lblUnitStep.Location = new System.Drawing.Point(132, 7);
            this.lblUnitStep.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitStep.Name = "lblUnitStep";
            this.lblUnitStep.Size = new System.Drawing.Size(13, 17);
            this.lblUnitStep.TabIndex = 2;
            this.lblUnitStep.Text = "°";
            // 
            // btnStepNeg
            // 
            this.btnStepNeg.Location = new System.Drawing.Point(151, 4);
            this.btnStepNeg.Margin = new System.Windows.Forms.Padding(4);
            this.btnStepNeg.Name = "btnStepNeg";
            this.btnStepNeg.Size = new System.Drawing.Size(80, 28);
            this.btnStepNeg.TabIndex = 3;
            this.btnStepNeg.Text = "− 步进";
            this.btnStepNeg.Click += new System.EventHandler(this.btnStepNeg_Click);
            // 
            // btnStepPos
            // 
            this.btnStepPos.Location = new System.Drawing.Point(239, 4);
            this.btnStepPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnStepPos.Name = "btnStepPos";
            this.btnStepPos.Size = new System.Drawing.Size(80, 28);
            this.btnStepPos.TabIndex = 4;
            this.btnStepPos.Text = "+ 步进";
            this.btnStepPos.Click += new System.EventHandler(this.btnStepPos_Click);
            // 
            // groupHome
            // 
            this.groupHome.AutoSize = true;
            this.groupHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupHome.Controls.Add(this.homeLayout);
            this.groupHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupHome.Location = new System.Drawing.Point(4, 475);
            this.groupHome.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupHome.Name = "groupHome";
            this.groupHome.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.groupHome.Size = new System.Drawing.Size(552, 68);
            this.groupHome.TabIndex = 5;
            this.groupHome.TabStop = false;
            this.groupHome.Text = "回零";
            // 
            // homeLayout
            // 
            this.homeLayout.AutoSize = true;
            this.homeLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeLayout.ColumnCount = 1;
            this.homeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.homeLayout.Controls.Add(this.rowHome, 0, 0);
            this.homeLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeLayout.Location = new System.Drawing.Point(6, 20);
            this.homeLayout.Name = "homeLayout";
            this.homeLayout.Padding = new System.Windows.Forms.Padding(2);
            this.homeLayout.RowCount = 1;
            this.homeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.homeLayout.Size = new System.Drawing.Size(540, 42);
            this.homeLayout.TabIndex = 0;
            // 
            // rowHome
            // 
            this.rowHome.AutoSize = true;
            this.rowHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rowHome.Controls.Add(this.lblHomeMode);
            this.rowHome.Controls.Add(this.cmbHomeMode);
            this.rowHome.Controls.Add(this.btnHome);
            this.rowHome.Controls.Add(this.btnHomeAbort);
            this.rowHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowHome.Location = new System.Drawing.Point(4, 3);
            this.rowHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rowHome.Name = "rowHome";
            this.rowHome.Size = new System.Drawing.Size(532, 36);
            this.rowHome.TabIndex = 0;
            this.rowHome.WrapContents = false;
            // 
            // lblHomeMode
            // 
            this.lblHomeMode.AutoSize = true;
            this.lblHomeMode.Location = new System.Drawing.Point(4, 7);
            this.lblHomeMode.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblHomeMode.Name = "lblHomeMode";
            this.lblHomeMode.Size = new System.Drawing.Size(32, 17);
            this.lblHomeMode.TabIndex = 0;
            this.lblHomeMode.Text = "模式";
            // 
            // cmbHomeMode
            // 
            this.cmbHomeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeMode.Items.AddRange(new object[] {
            "单圈就近回零",
            "单圈方向回零",
            "碰撞回零（无限位）",
            "限位开关回零",
            "回坐标原点"});
            this.cmbHomeMode.Location = new System.Drawing.Point(40, 4);
            this.cmbHomeMode.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.cmbHomeMode.Name = "cmbHomeMode";
            this.cmbHomeMode.Size = new System.Drawing.Size(150, 25);
            this.cmbHomeMode.TabIndex = 1;
            this.cmbHomeMode.SelectedIndexChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(202, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 28);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "回零";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHomeAbort
            // 
            this.btnHomeAbort.Location = new System.Drawing.Point(290, 4);
            this.btnHomeAbort.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeAbort.Name = "btnHomeAbort";
            this.btnHomeAbort.Size = new System.Drawing.Size(90, 28);
            this.btnHomeAbort.TabIndex = 3;
            this.btnHomeAbort.Text = "中止回零";
            this.btnHomeAbort.Click += new System.EventHandler(this.btnHomeAbort_Click);
            // 
            // groupZero
            // 
            this.groupZero.AutoSize = true;
            this.groupZero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupZero.Controls.Add(this.zeroLayout);
            this.groupZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupZero.Location = new System.Drawing.Point(4, 549);
            this.groupZero.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupZero.Name = "groupZero";
            this.groupZero.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.groupZero.Size = new System.Drawing.Size(552, 68);
            this.groupZero.TabIndex = 6;
            this.groupZero.TabStop = false;
            this.groupZero.Text = "零点与保护";
            // 
            // zeroLayout
            // 
            this.zeroLayout.AutoSize = true;
            this.zeroLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zeroLayout.ColumnCount = 1;
            this.zeroLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.zeroLayout.Controls.Add(this.rowZero, 0, 0);
            this.zeroLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.zeroLayout.Location = new System.Drawing.Point(6, 20);
            this.zeroLayout.Name = "zeroLayout";
            this.zeroLayout.Padding = new System.Windows.Forms.Padding(2);
            this.zeroLayout.RowCount = 1;
            this.zeroLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.zeroLayout.Size = new System.Drawing.Size(540, 42);
            this.zeroLayout.TabIndex = 0;
            // 
            // rowZero
            // 
            this.rowZero.AutoSize = true;
            this.rowZero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rowZero.Controls.Add(this.btnSetZero);
            this.rowZero.Controls.Add(this.btnClearPos);
            this.rowZero.Controls.Add(this.btnResetStall);
            this.rowZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowZero.Location = new System.Drawing.Point(4, 3);
            this.rowZero.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rowZero.Name = "rowZero";
            this.rowZero.Size = new System.Drawing.Size(532, 36);
            this.rowZero.TabIndex = 0;
            this.rowZero.WrapContents = false;
            // 
            // btnSetZero
            // 
            this.btnSetZero.Location = new System.Drawing.Point(4, 4);
            this.btnSetZero.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetZero.Name = "btnSetZero";
            this.btnSetZero.Size = new System.Drawing.Size(130, 28);
            this.btnSetZero.TabIndex = 0;
            this.btnSetZero.Text = "设零（掉电保存）";
            this.btnSetZero.Click += new System.EventHandler(this.btnSetZero_Click);
            // 
            // btnClearPos
            // 
            this.btnClearPos.Location = new System.Drawing.Point(142, 4);
            this.btnClearPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPos.Name = "btnClearPos";
            this.btnClearPos.Size = new System.Drawing.Size(90, 28);
            this.btnClearPos.TabIndex = 1;
            this.btnClearPos.Text = "位置清零";
            this.btnClearPos.Click += new System.EventHandler(this.btnClearPos_Click);
            // 
            // btnResetStall
            // 
            this.btnResetStall.Location = new System.Drawing.Point(240, 4);
            this.btnResetStall.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetStall.Name = "btnResetStall";
            this.btnResetStall.Size = new System.Drawing.Size(90, 28);
            this.btnResetStall.TabIndex = 2;
            this.btnResetStall.Text = "解除堵转";
            this.btnResetStall.Click += new System.EventHandler(this.btnResetStall_Click);
            // 
            // groupLimit
            // 
            this.groupLimit.AutoSize = true;
            this.groupLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupLimit.Controls.Add(this.limitLayout);
            this.groupLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLimit.Location = new System.Drawing.Point(4, 623);
            this.groupLimit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupLimit.Name = "groupLimit";
            this.groupLimit.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.groupLimit.Size = new System.Drawing.Size(552, 64);
            this.groupLimit.TabIndex = 7;
            this.groupLimit.TabStop = false;
            this.groupLimit.Text = "软限位（只限制定位和点动）";
            // 
            // limitLayout
            // 
            this.limitLayout.AutoSize = true;
            this.limitLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.limitLayout.ColumnCount = 1;
            this.limitLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.limitLayout.Controls.Add(this.rowLimit, 0, 0);
            this.limitLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.limitLayout.Location = new System.Drawing.Point(6, 20);
            this.limitLayout.Name = "limitLayout";
            this.limitLayout.Padding = new System.Windows.Forms.Padding(2);
            this.limitLayout.RowCount = 1;
            this.limitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.limitLayout.Size = new System.Drawing.Size(540, 38);
            this.limitLayout.TabIndex = 0;
            // 
            // rowLimit
            // 
            this.rowLimit.AutoSize = true;
            this.rowLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rowLimit.Controls.Add(this.chkUseLimits);
            this.rowLimit.Controls.Add(this.lblMin);
            this.rowLimit.Controls.Add(this.numMin);
            this.rowLimit.Controls.Add(this.lblMax);
            this.rowLimit.Controls.Add(this.numMax);
            this.rowLimit.Controls.Add(this.lblUnitLimit);
            this.rowLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowLimit.Location = new System.Drawing.Point(4, 3);
            this.rowLimit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rowLimit.Name = "rowLimit";
            this.rowLimit.Size = new System.Drawing.Size(532, 32);
            this.rowLimit.TabIndex = 0;
            this.rowLimit.WrapContents = false;
            // 
            // chkUseLimits
            // 
            this.chkUseLimits.AutoSize = true;
            this.chkUseLimits.Checked = true;
            this.chkUseLimits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseLimits.Location = new System.Drawing.Point(4, 7);
            this.chkUseLimits.Margin = new System.Windows.Forms.Padding(4, 7, 10, 4);
            this.chkUseLimits.Name = "chkUseLimits";
            this.chkUseLimits.Size = new System.Drawing.Size(87, 21);
            this.chkUseLimits.TabIndex = 0;
            this.chkUseLimits.Text = "启用软限位";
            this.chkUseLimits.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(105, 7);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(32, 17);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "最小";
            // 
            // numMin
            // 
            this.numMin.DecimalPlaces = 2;
            this.numMin.Location = new System.Drawing.Point(141, 4);
            this.numMin.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(90, 23);
            this.numMin.TabIndex = 2;
            this.numMin.Value = new decimal(new int[] {
            3600,
            0,
            0,
            -2147483648});
            this.numMin.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(243, 7);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(32, 17);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "最大";
            // 
            // numMax
            // 
            this.numMax.DecimalPlaces = 2;
            this.numMax.Location = new System.Drawing.Point(279, 4);
            this.numMax.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numMax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(90, 23);
            this.numMax.TabIndex = 4;
            this.numMax.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numMax.ValueChanged += new System.EventHandler(this.SettingsChanged);
            // 
            // lblUnitLimit
            // 
            this.lblUnitLimit.AutoSize = true;
            this.lblUnitLimit.Location = new System.Drawing.Point(381, 7);
            this.lblUnitLimit.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitLimit.Name = "lblUnitLimit";
            this.lblUnitLimit.Size = new System.Drawing.Size(13, 17);
            this.lblUnitLimit.TabIndex = 5;
            this.lblUnitLimit.Text = "°";
            // 
            // AxisPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.Name = "AxisPanel";
            this.Size = new System.Drawing.Size(560, 760);
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.rootLayout.ResumeLayout(false);
            this.rootLayout.PerformLayout();
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.posPanel.ResumeLayout(false);
            this.posPanel.PerformLayout();
            this.groupParam.ResumeLayout(false);
            this.groupParam.PerformLayout();
            this.paramLayout.ResumeLayout(false);
            this.paramLayout.PerformLayout();
            this.row1Param.ResumeLayout(false);
            this.row1Param.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).EndInit();
            this.row2Param.ResumeLayout(false);
            this.row2Param.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcc)).EndInit();
            this.groupMove.ResumeLayout(false);
            this.groupMove.PerformLayout();
            this.moveLayout.ResumeLayout(false);
            this.moveLayout.PerformLayout();
            this.row1Move.ResumeLayout(false);
            this.row1Move.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            this.row2Move.ResumeLayout(false);
            this.groupJog.ResumeLayout(false);
            this.groupJog.PerformLayout();
            this.jogLayout.ResumeLayout(false);
            this.jogLayout.PerformLayout();
            this.row1Jog.ResumeLayout(false);
            this.row1Jog.PerformLayout();
            this.row2Jog.ResumeLayout(false);
            this.row2Jog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
            this.groupHome.ResumeLayout(false);
            this.groupHome.PerformLayout();
            this.homeLayout.ResumeLayout(false);
            this.homeLayout.PerformLayout();
            this.rowHome.ResumeLayout(false);
            this.rowHome.PerformLayout();
            this.groupZero.ResumeLayout(false);
            this.groupZero.PerformLayout();
            this.zeroLayout.ResumeLayout(false);
            this.zeroLayout.PerformLayout();
            this.rowZero.ResumeLayout(false);
            this.groupLimit.ResumeLayout(false);
            this.groupLimit.PerformLayout();
            this.limitLayout.ResumeLayout(false);
            this.limitLayout.PerformLayout();
            this.rowLimit.ResumeLayout(false);
            this.rowLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.FlowLayoutPanel posPanel;
        private System.Windows.Forms.Label lblPosBig;
        private System.Windows.Forms.Label lblPosCaption;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupParam;
        private System.Windows.Forms.TableLayoutPanel paramLayout;
        private System.Windows.Forms.FlowLayoutPanel row1Param;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.NumericUpDown numAddress;
        private System.Windows.Forms.Label lblPpr;
        private System.Windows.Forms.NumericUpDown numPpr;
        private System.Windows.Forms.Label lblUnitsCaption;
        private System.Windows.Forms.NumericUpDown numUnits;
        private System.Windows.Forms.Label lblUnitUnits;
        private System.Windows.Forms.FlowLayoutPanel row2Param;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.NumericUpDown numAcc;
        private System.Windows.Forms.CheckBox chkInvert;
        private System.Windows.Forms.GroupBox groupMove;
        private System.Windows.Forms.TableLayoutPanel moveLayout;
        private System.Windows.Forms.FlowLayoutPanel row1Move;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.NumericUpDown numTarget;
        private System.Windows.Forms.Label lblUnitTarget;
        private System.Windows.Forms.RadioButton rdoAbs;
        private System.Windows.Forms.RadioButton rdoRel;
        private System.Windows.Forms.FlowLayoutPanel row2Move;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupJog;
        private System.Windows.Forms.TableLayoutPanel jogLayout;
        private System.Windows.Forms.FlowLayoutPanel row1Jog;
        private System.Windows.Forms.Button btnJogNeg;
        private System.Windows.Forms.Button btnJogPos;
        private System.Windows.Forms.Label lblJogHint;
        private System.Windows.Forms.FlowLayoutPanel row2Jog;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.NumericUpDown numStep;
        private System.Windows.Forms.Label lblUnitStep;
        private System.Windows.Forms.Button btnStepNeg;
        private System.Windows.Forms.Button btnStepPos;
        private System.Windows.Forms.GroupBox groupHome;
        private System.Windows.Forms.TableLayoutPanel homeLayout;
        private System.Windows.Forms.FlowLayoutPanel rowHome;
        private System.Windows.Forms.Label lblHomeMode;
        private System.Windows.Forms.ComboBox cmbHomeMode;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHomeAbort;
        private System.Windows.Forms.GroupBox groupZero;
        private System.Windows.Forms.TableLayoutPanel zeroLayout;
        private System.Windows.Forms.FlowLayoutPanel rowZero;
        private System.Windows.Forms.Button btnSetZero;
        private System.Windows.Forms.Button btnClearPos;
        private System.Windows.Forms.Button btnResetStall;
        private System.Windows.Forms.GroupBox groupLimit;
        private System.Windows.Forms.TableLayoutPanel limitLayout;
        private System.Windows.Forms.FlowLayoutPanel rowLimit;
        private System.Windows.Forms.CheckBox chkUseLimits;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label lblUnitLimit;
    }
}
