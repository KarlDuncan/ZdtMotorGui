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
            // 单轴面板布局顺序（建议用 VS 设计器查看）：
            // 标题+使能 -> 位置显示 -> 参数与换算 -> 定位 -> 点动/微调
            // -> 回零 -> 零点与保护 -> 软限位。
            // 事件统一在属性设置之后挂接，功能代码在 AxisPanel.cs。
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
            this.row2Param.SuspendLayout();
            this.groupMove.SuspendLayout();
            this.moveLayout.SuspendLayout();
            this.row1Move.SuspendLayout();
            this.row2Move.SuspendLayout();
            this.groupJog.SuspendLayout();
            this.jogLayout.SuspendLayout();
            this.row1Jog.SuspendLayout();
            this.row2Jog.SuspendLayout();
            this.groupHome.SuspendLayout();
            this.homeLayout.SuspendLayout();
            this.rowHome.SuspendLayout();
            this.groupZero.SuspendLayout();
            this.zeroLayout.SuspendLayout();
            this.rowZero.SuspendLayout();
            this.groupLimit.SuspendLayout();
            this.limitLayout.SuspendLayout();
            this.rowLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLayout
            // 
            this.headerLayout.AutoSize = true;
            this.headerLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerLayout.ColumnCount = 2;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.headerLayout.Controls.Add(this.lblTitle, 0, 0);
            this.headerLayout.Controls.Add(this.chkEnable, 1, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "轴";
            // 
            // chkEnable
            // 
            this.chkEnable.AutoSize = true;
            this.chkEnable.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Text = "使能";
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
            this.posPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.posPanel.Name = "posPanel";
            this.posPanel.WrapContents = false;
            // 
            // lblPosBig
            // 
            this.lblPosBig.AutoSize = true;
            this.lblPosBig.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold);
            this.lblPosBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosBig.Name = "lblPosBig";
            this.lblPosBig.Text = "0.00 °";
            // 
            // lblPosCaption
            // 
            this.lblPosCaption.AutoSize = true;
            this.lblPosCaption.ForeColor = System.Drawing.Color.Gray;
            this.lblPosCaption.Margin = new System.Windows.Forms.Padding(6, 0, 4, 2);
            this.lblPosCaption.Name = "lblPosCaption";
            this.lblPosCaption.Text = "软件位置（累计指令，不是编码器反馈）";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(6, 0, 4, 2);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Text = "反馈：--";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 4, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "未连接";
            // 
            // groupParam
            // 
            this.groupParam.AutoSize = true;
            this.groupParam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupParam.Controls.Add(this.paramLayout);
            this.groupParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupParam.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupParam.Name = "groupParam";
            this.groupParam.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
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
            this.paramLayout.Name = "paramLayout";
            this.paramLayout.Padding = new System.Windows.Forms.Padding(2);
            this.paramLayout.RowCount = 2;
            this.paramLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.paramLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
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
            this.row1Param.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row1Param.Name = "row1Param";
            this.row1Param.WrapContents = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "地址";
            // 
            // numAddress
            // 
            this.numAddress.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numAddress.Maximum = new decimal(new int[] { 247, 0, 0, 0 });
            this.numAddress.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numAddress.Name = "numAddress";
            this.numAddress.Size = new System.Drawing.Size(60, 23);
            this.numAddress.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPpr
            // 
            this.lblPpr.AutoSize = true;
            this.lblPpr.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblPpr.Name = "lblPpr";
            this.lblPpr.Text = "脉冲/圈";
            // 
            // numPpr
            // 
            this.numPpr.Increment = new decimal(new int[] { 200, 0, 0, 0 });
            this.numPpr.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numPpr.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            this.numPpr.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            this.numPpr.Name = "numPpr";
            this.numPpr.Size = new System.Drawing.Size(90, 23);
            this.numPpr.Value = new decimal(new int[] { 3200, 0, 0, 0 });
            // 
            // lblUnitsCaption
            // 
            this.lblUnitsCaption.AutoSize = true;
            this.lblUnitsCaption.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitsCaption.Name = "lblUnitsCaption";
            this.lblUnitsCaption.Text = "每圈角度";
            // 
            // numUnits
            // 
            this.numUnits.DecimalPlaces = 3;
            this.numUnits.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numUnits.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numUnits.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            this.numUnits.Name = "numUnits";
            this.numUnits.Size = new System.Drawing.Size(80, 23);
            this.numUnits.Value = new decimal(new int[] { 360, 0, 0, 0 });
            // 
            // lblUnitUnits
            // 
            this.lblUnitUnits.AutoSize = true;
            this.lblUnitUnits.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitUnits.Name = "lblUnitUnits";
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
            this.row2Param.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row2Param.Name = "row2Param";
            this.row2Param.WrapContents = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Text = "速度(RPM)";
            // 
            // numSpeed
            // 
            this.numSpeed.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numSpeed.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            this.numSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(70, 23);
            this.numSpeed.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Text = "加速度(0-255)";
            // 
            // numAcc
            // 
            this.numAcc.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numAcc.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            this.numAcc.Name = "numAcc";
            this.numAcc.Size = new System.Drawing.Size(60, 23);
            this.numAcc.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // chkInvert
            // 
            this.chkInvert.AutoSize = true;
            this.chkInvert.Margin = new System.Windows.Forms.Padding(10, 7, 4, 4);
            this.chkInvert.Name = "chkInvert";
            this.chkInvert.Text = "方向反转";
            // 
            // groupMove
            // 
            this.groupMove.AutoSize = true;
            this.groupMove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupMove.Controls.Add(this.moveLayout);
            this.groupMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMove.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupMove.Name = "groupMove";
            this.groupMove.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
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
            this.moveLayout.Name = "moveLayout";
            this.moveLayout.Padding = new System.Windows.Forms.Padding(2);
            this.moveLayout.RowCount = 2;
            this.moveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.moveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
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
            this.row1Move.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row1Move.Name = "row1Move";
            this.row1Move.WrapContents = false;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Text = "目标";
            // 
            // numTarget
            // 
            this.numTarget.DecimalPlaces = 2;
            this.numTarget.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numTarget.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numTarget.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.numTarget.Name = "numTarget";
            this.numTarget.Size = new System.Drawing.Size(90, 23);
            // 
            // lblUnitTarget
            // 
            this.lblUnitTarget.AutoSize = true;
            this.lblUnitTarget.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitTarget.Name = "lblUnitTarget";
            this.lblUnitTarget.Text = "°";
            // 
            // rdoAbs
            // 
            this.rdoAbs.AutoSize = true;
            this.rdoAbs.Checked = true;
            this.rdoAbs.Margin = new System.Windows.Forms.Padding(12, 7, 2, 4);
            this.rdoAbs.Name = "rdoAbs";
            this.rdoAbs.TabStop = true;
            this.rdoAbs.Text = "绝对";
            // 
            // rdoRel
            // 
            this.rdoRel.AutoSize = true;
            this.rdoRel.Margin = new System.Windows.Forms.Padding(2, 7, 2, 4);
            this.rdoRel.Name = "rdoRel";
            this.rdoRel.Text = "相对";
            // 
            // row2Move
            // 
            this.row2Move.AutoSize = true;
            this.row2Move.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row2Move.Controls.Add(this.btnMove);
            this.row2Move.Controls.Add(this.btnStop);
            this.row2Move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row2Move.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row2Move.Name = "row2Move";
            this.row2Move.WrapContents = false;
            // 
            // btnMove
            // 
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(90, 30);
            this.btnMove.Text = "运行";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 30);
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // groupJog
            // 
            this.groupJog.AutoSize = true;
            this.groupJog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupJog.Controls.Add(this.jogLayout);
            this.groupJog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupJog.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupJog.Name = "groupJog";
            this.groupJog.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
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
            this.jogLayout.Name = "jogLayout";
            this.jogLayout.Padding = new System.Windows.Forms.Padding(2);
            this.jogLayout.RowCount = 2;
            this.jogLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.jogLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            // 
            // row1Jog
            // 
            this.row1Jog.AutoSize = true;
            this.row1Jog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row1Jog.Controls.Add(this.btnJogNeg);
            this.row1Jog.Controls.Add(this.btnJogPos);
            this.row1Jog.Controls.Add(this.lblJogHint);
            this.row1Jog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.row1Jog.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row1Jog.Name = "row1Jog";
            this.row1Jog.WrapContents = false;
            // 
            // btnJogNeg
            // 
            this.btnJogNeg.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogNeg.Name = "btnJogNeg";
            this.btnJogNeg.Size = new System.Drawing.Size(100, 32);
            this.btnJogNeg.Text = "◀ 点动";
            // 
            // btnJogPos
            // 
            this.btnJogPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogPos.Name = "btnJogPos";
            this.btnJogPos.Size = new System.Drawing.Size(100, 32);
            this.btnJogPos.Text = "点动 ▶";
            // 
            // lblJogHint
            // 
            this.lblJogHint.AutoSize = true;
            this.lblJogHint.ForeColor = System.Drawing.Color.Gray;
            this.lblJogHint.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.lblJogHint.Name = "lblJogHint";
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
            this.row2Jog.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.row2Jog.Name = "row2Jog";
            this.row2Jog.WrapContents = false;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblStep.Name = "lblStep";
            this.lblStep.Text = "步长";
            // 
            // numStep
            // 
            this.numStep.DecimalPlaces = 2;
            this.numStep.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            this.numStep.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numStep.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numStep.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            this.numStep.Name = "numStep";
            this.numStep.Size = new System.Drawing.Size(80, 23);
            this.numStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblUnitStep
            // 
            this.lblUnitStep.AutoSize = true;
            this.lblUnitStep.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitStep.Name = "lblUnitStep";
            this.lblUnitStep.Text = "°";
            // 
            // btnStepNeg
            // 
            this.btnStepNeg.Margin = new System.Windows.Forms.Padding(4);
            this.btnStepNeg.Name = "btnStepNeg";
            this.btnStepNeg.Size = new System.Drawing.Size(80, 28);
            this.btnStepNeg.Text = "− 步进";
            // 
            // btnStepPos
            // 
            this.btnStepPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnStepPos.Name = "btnStepPos";
            this.btnStepPos.Size = new System.Drawing.Size(80, 28);
            this.btnStepPos.Text = "+ 步进";
            // 
            // groupHome
            // 
            this.groupHome.AutoSize = true;
            this.groupHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupHome.Controls.Add(this.homeLayout);
            this.groupHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupHome.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupHome.Name = "groupHome";
            this.groupHome.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
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
            this.homeLayout.Name = "homeLayout";
            this.homeLayout.Padding = new System.Windows.Forms.Padding(2);
            this.homeLayout.RowCount = 1;
            this.homeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
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
            this.rowHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rowHome.Name = "rowHome";
            this.rowHome.WrapContents = false;
            // 
            // lblHomeMode
            // 
            this.lblHomeMode.AutoSize = true;
            this.lblHomeMode.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblHomeMode.Name = "lblHomeMode";
            this.lblHomeMode.Text = "模式";
            // 
            // cmbHomeMode
            // 
            this.cmbHomeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeMode.Items.AddRange(new object[] { "单圈就近回零", "单圈方向回零", "碰撞回零（无限位）", "限位开关回零", "回坐标原点" });
            this.cmbHomeMode.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.cmbHomeMode.Name = "cmbHomeMode";
            this.cmbHomeMode.SelectedIndex = 0;
            this.cmbHomeMode.Size = new System.Drawing.Size(150, 25);
            // 
            // btnHome
            // 
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 28);
            this.btnHome.Text = "回零";
            // 
            // btnHomeAbort
            // 
            this.btnHomeAbort.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeAbort.Name = "btnHomeAbort";
            this.btnHomeAbort.Size = new System.Drawing.Size(90, 28);
            this.btnHomeAbort.Text = "中止回零";
            // 
            // groupZero
            // 
            this.groupZero.AutoSize = true;
            this.groupZero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupZero.Controls.Add(this.zeroLayout);
            this.groupZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupZero.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupZero.Name = "groupZero";
            this.groupZero.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
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
            this.zeroLayout.Name = "zeroLayout";
            this.zeroLayout.Padding = new System.Windows.Forms.Padding(2);
            this.zeroLayout.RowCount = 1;
            this.zeroLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            // 
            // rowZero
            // 
            this.rowZero.AutoSize = true;
            this.rowZero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rowZero.Controls.Add(this.btnSetZero);
            this.rowZero.Controls.Add(this.btnClearPos);
            this.rowZero.Controls.Add(this.btnResetStall);
            this.rowZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowZero.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rowZero.Name = "rowZero";
            this.rowZero.WrapContents = false;
            // 
            // btnSetZero
            // 
            this.btnSetZero.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetZero.Name = "btnSetZero";
            this.btnSetZero.Size = new System.Drawing.Size(130, 28);
            this.btnSetZero.Text = "设零（掉电保存）";
            // 
            // btnClearPos
            // 
            this.btnClearPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPos.Name = "btnClearPos";
            this.btnClearPos.Size = new System.Drawing.Size(90, 28);
            this.btnClearPos.Text = "位置清零";
            // 
            // btnResetStall
            // 
            this.btnResetStall.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetStall.Name = "btnResetStall";
            this.btnResetStall.Size = new System.Drawing.Size(90, 28);
            this.btnResetStall.Text = "解除堵转";
            // 
            // groupLimit
            // 
            this.groupLimit.AutoSize = true;
            this.groupLimit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupLimit.Controls.Add(this.limitLayout);
            this.groupLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLimit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.groupLimit.Name = "groupLimit";
            this.groupLimit.Padding = new System.Windows.Forms.Padding(6, 4, 6, 6);
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
            this.limitLayout.Name = "limitLayout";
            this.limitLayout.Padding = new System.Windows.Forms.Padding(2);
            this.limitLayout.RowCount = 1;
            this.limitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
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
            this.rowLimit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.rowLimit.Name = "rowLimit";
            this.rowLimit.WrapContents = false;
            // 
            // chkUseLimits
            // 
            this.chkUseLimits.AutoSize = true;
            this.chkUseLimits.Checked = true;
            this.chkUseLimits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseLimits.Margin = new System.Windows.Forms.Padding(4, 7, 10, 4);
            this.chkUseLimits.Name = "chkUseLimits";
            this.chkUseLimits.Text = "启用软限位";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblMin.Name = "lblMin";
            this.lblMin.Text = "最小";
            // 
            // numMin
            // 
            this.numMin.DecimalPlaces = 2;
            this.numMin.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numMin.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numMin.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(90, 23);
            this.numMin.Value = new decimal(new int[] { 3600, 0, 0, -2147483648 });
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblMax.Name = "lblMax";
            this.lblMax.Text = "最大";
            // 
            // numMax
            // 
            this.numMax.DecimalPlaces = 2;
            this.numMax.Margin = new System.Windows.Forms.Padding(2, 4, 8, 4);
            this.numMax.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numMax.Minimum = new decimal(new int[] { 1000000, 0, 0, -2147483648 });
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(90, 23);
            this.numMax.Value = new decimal(new int[] { 3600, 0, 0, 0 });
            // 
            // lblUnitLimit
            // 
            this.lblUnitLimit.AutoSize = true;
            this.lblUnitLimit.Margin = new System.Windows.Forms.Padding(4, 7, 2, 4);
            this.lblUnitLimit.Name = "lblUnitLimit";
            this.lblUnitLimit.Text = "°";
            // 
            // 控件事件（放在设计器里，VS 里双击控件就能跳到代码）
            // 
            this.chkEnable.CheckedChanged += new System.EventHandler(this.chkEnable_CheckedChanged);
            this.numAddress.ValueChanged += new System.EventHandler(this.SettingsChanged);
            this.numPpr.ValueChanged += new System.EventHandler(this.SettingsChanged);
            this.numUnits.ValueChanged += new System.EventHandler(this.SettingsChanged);
            this.numSpeed.ValueChanged += new System.EventHandler(this.SettingsChanged);
            this.numAcc.ValueChanged += new System.EventHandler(this.SettingsChanged);
            this.numMin.ValueChanged += new System.EventHandler(this.SettingsChanged);
            this.numMax.ValueChanged += new System.EventHandler(this.SettingsChanged);
            this.chkInvert.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            this.chkUseLimits.CheckedChanged += new System.EventHandler(this.SettingsChanged);
            this.cmbHomeMode.SelectedIndexChanged += new System.EventHandler(this.SettingsChanged);
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnJogNeg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogNeg_MouseDown);
            this.btnJogNeg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogNeg_MouseUp);
            this.btnJogNeg.MouseLeave += new System.EventHandler(this.btnJogNeg_MouseLeave);
            this.btnJogPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogPos_MouseDown);
            this.btnJogPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogPos_MouseUp);
            this.btnJogPos.MouseLeave += new System.EventHandler(this.btnJogPos_MouseLeave);
            this.btnStepNeg.Click += new System.EventHandler(this.btnStepNeg_Click);
            this.btnStepPos.Click += new System.EventHandler(this.btnStepPos_Click);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHomeAbort.Click += new System.EventHandler(this.btnHomeAbort_Click);
            this.btnSetZero.Click += new System.EventHandler(this.btnSetZero_Click);
            this.btnClearPos.Click += new System.EventHandler(this.btnClearPos_Click);
            this.btnResetStall.Click += new System.EventHandler(this.btnResetStall_Click);
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
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.Padding = new System.Windows.Forms.Padding(2);
            this.rootLayout.RowCount = 8;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.rootLayout);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Name = "scrollPanel";
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
            this.row2Param.ResumeLayout(false);
            this.row2Param.PerformLayout();
            this.groupMove.ResumeLayout(false);
            this.groupMove.PerformLayout();
            this.moveLayout.ResumeLayout(false);
            this.moveLayout.PerformLayout();
            this.row1Move.ResumeLayout(false);
            this.row1Move.PerformLayout();
            this.row2Move.ResumeLayout(false);
            this.row2Move.PerformLayout();
            this.groupJog.ResumeLayout(false);
            this.groupJog.PerformLayout();
            this.jogLayout.ResumeLayout(false);
            this.jogLayout.PerformLayout();
            this.row1Jog.ResumeLayout(false);
            this.row1Jog.PerformLayout();
            this.row2Jog.ResumeLayout(false);
            this.row2Jog.PerformLayout();
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
            this.rowZero.PerformLayout();
            this.groupLimit.ResumeLayout(false);
            this.groupLimit.PerformLayout();
            this.limitLayout.ResumeLayout(false);
            this.limitLayout.PerformLayout();
            this.rowLimit.ResumeLayout(false);
            this.rowLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
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
