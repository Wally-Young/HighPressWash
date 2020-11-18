using System.Drawing;

namespace HighPressWash
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAlreadyTime = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtSetTime = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtHomePos2 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtHomePos1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userButton3 = new HslCommunication.Controls.UserButton();
            this.btnEstop = new HslCommunication.Controls.UserButton();
            this.btnChangeMode = new HslCommunication.Controls.UserButton();
            this.userButton1 = new HslCommunication.Controls.UserButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new HslCommunication.Controls.UserButton();
            this.btnDown = new HslCommunication.Controls.UserButton();
            this.btnBegin = new HslCommunication.Controls.UserButton();
            this.ucAlarmLamp1 = new HZH_Controls.Controls.UCAlarmLamp();
            this.ucConduit13 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit12 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit10 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit8 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit14 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit6 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit4 = new HZH_Controls.Controls.UCConduit();
            this.WaterVaVel6 = new HZH_Controls.Controls.UCValve();
            this.WaterVaVel5 = new HZH_Controls.Controls.UCValve();
            this.WaterVaVel4 = new HZH_Controls.Controls.UCValve();
            this.WaterVaVel3 = new HZH_Controls.Controls.UCValve();
            this.WaterVaVel2 = new HZH_Controls.Controls.UCValve();
            this.label39 = new System.Windows.Forms.Label();
            this.WaterVaVel1 = new HZH_Controls.Controls.UCValve();
            this.label16 = new System.Windows.Forms.Label();
            this.ucBottle2 = new HZH_Controls.Controls.UCBottle();
            this.label13 = new System.Windows.Forms.Label();
            this.lbEquipmentStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ucConduit11 = new HZH_Controls.Controls.UCConduit();
            this.AirVavel6 = new HZH_Controls.Controls.UCValve();
            this.ucBlower1 = new HZH_Controls.Controls.UCBlower();
            this.AirVavel5 = new HZH_Controls.Controls.UCValve();
            this.ucBottle1 = new HZH_Controls.Controls.UCBottle();
            this.AirVavel4 = new HZH_Controls.Controls.UCValve();
            this.ucValve1 = new HZH_Controls.Controls.UCValve();
            this.AirVavel3 = new HZH_Controls.Controls.UCValve();
            this.AirVavel2 = new HZH_Controls.Controls.UCValve();
            this.AirVavel1 = new HZH_Controls.Controls.UCValve();
            this.ucConduit7 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit2 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit9 = new HZH_Controls.Controls.UCConduit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucConduit18 = new HZH_Controls.Controls.UCConduit();
            this.label6 = new System.Windows.Forms.Label();
            this.ucConduit5 = new HZH_Controls.Controls.UCConduit();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucConduit1 = new HZH_Controls.Controls.UCConduit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbIsReady = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtHomeWashPress = new System.Windows.Forms.TextBox();
            this.txtWashNum = new System.Windows.Forms.TextBox();
            this.ucConduit3 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit15 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit16 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit17 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit19 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit20 = new HZH_Controls.Controls.UCConduit();
            this.ucConduit21 = new HZH_Controls.Controls.UCConduit();
            this.btnManualWrite = new System.Windows.Forms.TabPage();
            this.txtPosition1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMotorMove = new System.Windows.Forms.TextBox();
            this.ucRadioButton8 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton7 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton6 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton5 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton4 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton3 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton2 = new HZH_Controls.Controls.UCRadioButton();
            this.CBmotorMove = new HZH_Controls.Controls.UCRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EnbleLowFreq = new System.Windows.Forms.CheckBox();
            this.BtnToStandy = new HslCommunication.Controls.UserButton();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSetFreq = new System.Windows.Forms.TextBox();
            this.txtSetPres = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.BtnToWorkPos = new HslCommunication.Controls.UserButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtWashPress = new System.Windows.Forms.TextBox();
            this.txtPosition2 = new System.Windows.Forms.TextBox();
            this.BtnGasVel6 = new HslCommunication.Controls.UserButton();
            this.BtnGasVel5 = new HslCommunication.Controls.UserButton();
            this.BtnWash6 = new HslCommunication.Controls.UserButton();
            this.BtnGasVel4 = new HslCommunication.Controls.UserButton();
            this.BtnWash5 = new HslCommunication.Controls.UserButton();
            this.BtnGasVel3 = new HslCommunication.Controls.UserButton();
            this.userButton21 = new HslCommunication.Controls.UserButton();
            this.userButton20 = new HslCommunication.Controls.UserButton();
            this.userButton19 = new HslCommunication.Controls.UserButton();
            this.userButton18 = new HslCommunication.Controls.UserButton();
            this.BtnWash4 = new HslCommunication.Controls.UserButton();
            this.BtnHighPres = new HslCommunication.Controls.UserButton();
            this.BtnGasVel2 = new HslCommunication.Controls.UserButton();
            this.BtnWash3 = new HslCommunication.Controls.UserButton();
            this.BtnOverVel = new HslCommunication.Controls.UserButton();
            this.BtnGasVel1 = new HslCommunication.Controls.UserButton();
            this.BtnWash2 = new HslCommunication.Controls.UserButton();
            this.BtnWash1 = new HslCommunication.Controls.UserButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label40 = new System.Windows.Forms.Label();
            this.txtSystemMaxPres = new System.Windows.Forms.TextBox();
            this.EnbleLowFrequency = new System.Windows.Forms.CheckBox();
            this.btnSaveParam = new HslCommunication.Controls.UserButton();
            this.BtnClearParam = new HslCommunication.Controls.UserButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtWorkSpeed = new System.Windows.Forms.TextBox();
            this.txtWorkPos = new System.Windows.Forms.TextBox();
            this.txtLowFreq = new System.Windows.Forms.TextBox();
            this.txtPresMax = new System.Windows.Forms.TextBox();
            this.txtSetWaterPres = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAutoStartTime = new System.Windows.Forms.TextBox();
            this.NegMaxLimit = new System.Windows.Forms.TextBox();
            this.txtPosLimit = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtIdleSpeed = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtAerify = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtIdlePos = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtPresMin = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtWaterCompensate = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridParam = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Water1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Water2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Warter3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Water4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Water5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Water6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gas1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gas2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gas3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gas4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gas5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gas6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNext = new HslCommunication.Controls.UserButton();
            this.BtnPrevious = new HslCommunication.Controls.UserButton();
            this.label23 = new System.Windows.Forms.Label();
            this.txtWashSetTime = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ucPagerControl21 = new HZH_Controls.Controls.UCPagerControl2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.userButton2 = new HslCommunication.Controls.UserButton();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DGCurrentAlarm = new System.Windows.Forms.DataGridView();
            this.BeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriggerValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DGHistoryAlarm = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verificationComponent1 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuitemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.手动界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报警界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolPLCConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolServiceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.btnManualWrite.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParam)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCurrentAlarm)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGHistoryAlarm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.btnManualWrite);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 10);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 674);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ucAlarmLamp1);
            this.tabPage1.Controls.Add(this.ucConduit13);
            this.tabPage1.Controls.Add(this.ucConduit12);
            this.tabPage1.Controls.Add(this.ucConduit10);
            this.tabPage1.Controls.Add(this.ucConduit8);
            this.tabPage1.Controls.Add(this.ucConduit14);
            this.tabPage1.Controls.Add(this.ucConduit6);
            this.tabPage1.Controls.Add(this.ucConduit4);
            this.tabPage1.Controls.Add(this.WaterVaVel6);
            this.tabPage1.Controls.Add(this.WaterVaVel5);
            this.tabPage1.Controls.Add(this.WaterVaVel4);
            this.tabPage1.Controls.Add(this.WaterVaVel3);
            this.tabPage1.Controls.Add(this.WaterVaVel2);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.WaterVaVel1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.ucBottle2);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.lbEquipmentStatus);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.ucConduit11);
            this.tabPage1.Controls.Add(this.AirVavel6);
            this.tabPage1.Controls.Add(this.ucBlower1);
            this.tabPage1.Controls.Add(this.AirVavel5);
            this.tabPage1.Controls.Add(this.ucBottle1);
            this.tabPage1.Controls.Add(this.AirVavel4);
            this.tabPage1.Controls.Add(this.ucValve1);
            this.tabPage1.Controls.Add(this.AirVavel3);
            this.tabPage1.Controls.Add(this.AirVavel2);
            this.tabPage1.Controls.Add(this.AirVavel1);
            this.tabPage1.Controls.Add(this.ucConduit7);
            this.tabPage1.Controls.Add(this.ucConduit2);
            this.tabPage1.Controls.Add(this.ucConduit9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ucConduit18);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ucConduit5);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ucConduit1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lbIsReady);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.txtHomeWashPress);
            this.tabPage1.Controls.Add(this.txtWashNum);
            this.tabPage1.Controls.Add(this.ucConduit3);
            this.tabPage1.Controls.Add(this.ucConduit15);
            this.tabPage1.Controls.Add(this.ucConduit16);
            this.tabPage1.Controls.Add(this.ucConduit17);
            this.tabPage1.Controls.Add(this.ucConduit19);
            this.tabPage1.Controls.Add(this.ucConduit20);
            this.tabPage1.Controls.Add(this.ucConduit21);
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAlreadyTime);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.txtSetTime);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.txtHomePos2);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.txtHomePos1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(11, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 199);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            // 
            // txtAlreadyTime
            // 
            this.txtAlreadyTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtAlreadyTime.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtAlreadyTime.Location = new System.Drawing.Point(172, 165);
            this.txtAlreadyTime.Name = "txtAlreadyTime";
            this.txtAlreadyTime.Size = new System.Drawing.Size(119, 30);
            this.txtAlreadyTime.TabIndex = 25;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtAlreadyTime, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtAlreadyTime, "");
            this.verificationComponent1.SetVerificationModel(this.txtAlreadyTime, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtAlreadyTime, false);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(19, 168);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(158, 20);
            this.label34.TabIndex = 42;
            this.label34.Text = "已冲洗时间(S):";
            // 
            // txtSetTime
            // 
            this.txtSetTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSetTime.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSetTime.Location = new System.Drawing.Point(172, 121);
            this.txtSetTime.Name = "txtSetTime";
            this.txtSetTime.Size = new System.Drawing.Size(119, 30);
            this.txtSetTime.TabIndex = 25;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtSetTime, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtSetTime, "");
            this.verificationComponent1.SetVerificationModel(this.txtSetTime, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtSetTime, false);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(2, 124);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(179, 20);
            this.label33.TabIndex = 42;
            this.label33.Text = "冲洗设定时间(S):";
            // 
            // txtHomePos2
            // 
            this.txtHomePos2.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHomePos2.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtHomePos2.Location = new System.Drawing.Point(172, 77);
            this.txtHomePos2.Name = "txtHomePos2";
            this.txtHomePos2.Size = new System.Drawing.Size(119, 30);
            this.txtHomePos2.TabIndex = 25;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtHomePos2, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtHomePos2, "");
            this.verificationComponent1.SetVerificationModel(this.txtHomePos2, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtHomePos2, false);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(2, 80);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(201, 20);
            this.label32.TabIndex = 42;
            this.label32.Text = "电机2当前位置(mm):";
            // 
            // txtHomePos1
            // 
            this.txtHomePos1.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHomePos1.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtHomePos1.Location = new System.Drawing.Point(172, 33);
            this.txtHomePos1.Name = "txtHomePos1";
            this.txtHomePos1.Size = new System.Drawing.Size(119, 30);
            this.txtHomePos1.TabIndex = 25;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtHomePos1, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtHomePos1, "");
            this.verificationComponent1.SetVerificationModel(this.txtHomePos1, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtHomePos1, false);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "电机1当前位置(mm):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userButton3);
            this.groupBox2.Controls.Add(this.btnEstop);
            this.groupBox2.Controls.Add(this.btnChangeMode);
            this.groupBox2.Controls.Add(this.userButton1);
            this.groupBox2.Location = new System.Drawing.Point(0, 567);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 95);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            // 
            // userButton3
            // 
            this.userButton3.ActiveColor = System.Drawing.Color.DarkOrange;
            this.userButton3.BackColor = System.Drawing.Color.Transparent;
            this.userButton3.CustomerInformation = "";
            this.userButton3.EnableColor = System.Drawing.Color.DarkGray;
            this.userButton3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.userButton3.Location = new System.Drawing.Point(180, 28);
            this.userButton3.Margin = new System.Windows.Forms.Padding(5);
            this.userButton3.Name = "userButton3";
            this.userButton3.OriginalColor = System.Drawing.Color.DarkGray;
            this.userButton3.Size = new System.Drawing.Size(146, 52);
            this.userButton3.TabIndex = 22;
            this.userButton3.Tag = "H207";
            this.userButton3.TextColor = System.Drawing.Color.White;
            this.userButton3.UIText = "下载参数";
            this.userButton3.Click += new System.EventHandler(this.btnLoadDownParam_Click);
            // 
            // btnEstop
            // 
            this.btnEstop.ActiveColor = System.Drawing.Color.DarkOrange;
            this.btnEstop.BackColor = System.Drawing.Color.Transparent;
            this.btnEstop.CustomerInformation = "";
            this.btnEstop.EnableColor = System.Drawing.Color.DarkGray;
            this.btnEstop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnEstop.Location = new System.Drawing.Point(538, 26);
            this.btnEstop.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstop.Name = "btnEstop";
            this.btnEstop.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnEstop.Size = new System.Drawing.Size(135, 59);
            this.btnEstop.TabIndex = 20;
            this.btnEstop.Tag = "M510";
            this.btnEstop.TextColor = System.Drawing.Color.White;
            this.btnEstop.UIText = "急 停";
            this.btnEstop.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.ActiveColor = System.Drawing.Color.DarkOrange;
            this.btnChangeMode.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeMode.CustomerInformation = "";
            this.btnChangeMode.EnableColor = System.Drawing.Color.Gray;
            this.btnChangeMode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnChangeMode.Location = new System.Drawing.Point(8, 26);
            this.btnChangeMode.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.OriginalColor = System.Drawing.Color.DarkGray;
            this.btnChangeMode.Size = new System.Drawing.Size(135, 59);
            this.btnChangeMode.TabIndex = 20;
            this.btnChangeMode.Tag = "H207";
            this.btnChangeMode.TextColor = System.Drawing.Color.White;
            this.btnChangeMode.UIText = "手动模式";
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // userButton1
            // 
            this.userButton1.ActiveColor = System.Drawing.Color.DarkOrange;
            this.userButton1.BackColor = System.Drawing.Color.Transparent;
            this.userButton1.CustomerInformation = "";
            this.userButton1.EnableColor = System.Drawing.Color.DarkGray;
            this.userButton1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.userButton1.Location = new System.Drawing.Point(357, 26);
            this.userButton1.Margin = new System.Windows.Forms.Padding(4);
            this.userButton1.Name = "userButton1";
            this.userButton1.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(196)))), ((int)(((byte)(81)))));
            this.userButton1.Size = new System.Drawing.Size(135, 59);
            this.userButton1.TabIndex = 20;
            this.userButton1.Tag = "M506";
            this.userButton1.TextColor = System.Drawing.Color.White;
            this.userButton1.UIText = "原点回归";
            this.userButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.userButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnBegin);
            this.groupBox1.Location = new System.Drawing.Point(781, 567);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 95);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.ActiveColor = System.Drawing.Color.DarkOrange;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.CustomerInformation = "";
            this.btnStop.EnableColor = System.Drawing.Color.DarkGray;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(412, 26);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.btnStop.Size = new System.Drawing.Size(135, 59);
            this.btnStop.TabIndex = 20;
            this.btnStop.Tag = "M514";
            this.btnStop.TextColor = System.Drawing.Color.White;
            this.btnStop.UIText = "停 止";
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // btnDown
            // 
            this.btnDown.ActiveColor = System.Drawing.Color.DarkOrange;
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.CustomerInformation = "";
            this.btnDown.EnableColor = System.Drawing.Color.DarkGray;
            this.btnDown.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnDown.Location = new System.Drawing.Point(8, 26);
            this.btnDown.Margin = new System.Windows.Forms.Padding(5);
            this.btnDown.Name = "btnDown";
            this.btnDown.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.btnDown.Size = new System.Drawing.Size(135, 59);
            this.btnDown.TabIndex = 20;
            this.btnDown.Tag = "M512";
            this.btnDown.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDown.UIText = "上压/下行";
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // btnBegin
            // 
            this.btnBegin.ActiveColor = System.Drawing.Color.DarkOrange;
            this.btnBegin.BackColor = System.Drawing.Color.Transparent;
            this.btnBegin.CustomerInformation = "";
            this.btnBegin.EnableColor = System.Drawing.Color.DarkGray;
            this.btnBegin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnBegin.Location = new System.Drawing.Point(210, 26);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(4);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.btnBegin.Size = new System.Drawing.Size(135, 59);
            this.btnBegin.TabIndex = 20;
            this.btnBegin.Tag = "M513";
            this.btnBegin.TextColor = System.Drawing.Color.White;
            this.btnBegin.UIText = "开 始";
            this.btnBegin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.btnBegin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // ucAlarmLamp1
            // 
            this.ucAlarmLamp1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.ucAlarmLamp1.Lampstand = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.ucAlarmLamp1.Location = new System.Drawing.Point(66, 504);
            this.ucAlarmLamp1.Name = "ucAlarmLamp1";
            this.ucAlarmLamp1.Size = new System.Drawing.Size(83, 67);
            this.ucAlarmLamp1.TabIndex = 82;
            this.ucAlarmLamp1.TwinkleSpeed = 0;
            // 
            // ucConduit13
            // 
            this.ucConduit13.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit13.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit13.ConduitWidth = 50;
            this.ucConduit13.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit13.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit13.LiquidSpeed = 100;
            this.ucConduit13.Location = new System.Drawing.Point(1305, 261);
            this.ucConduit13.Name = "ucConduit13";
            this.ucConduit13.Size = new System.Drawing.Size(16, 231);
            this.ucConduit13.TabIndex = 54;
            // 
            // ucConduit12
            // 
            this.ucConduit12.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit12.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit12.ConduitWidth = 50;
            this.ucConduit12.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit12.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit12.LiquidSpeed = 100;
            this.ucConduit12.Location = new System.Drawing.Point(1220, 261);
            this.ucConduit12.Name = "ucConduit12";
            this.ucConduit12.Size = new System.Drawing.Size(16, 231);
            this.ucConduit12.TabIndex = 54;
            // 
            // ucConduit10
            // 
            this.ucConduit10.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit10.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit10.ConduitWidth = 50;
            this.ucConduit10.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit10.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit10.LiquidSpeed = 100;
            this.ucConduit10.Location = new System.Drawing.Point(1133, 259);
            this.ucConduit10.Name = "ucConduit10";
            this.ucConduit10.Size = new System.Drawing.Size(16, 231);
            this.ucConduit10.TabIndex = 54;
            // 
            // ucConduit8
            // 
            this.ucConduit8.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit8.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit8.ConduitWidth = 50;
            this.ucConduit8.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit8.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit8.LiquidSpeed = 100;
            this.ucConduit8.Location = new System.Drawing.Point(1045, 262);
            this.ucConduit8.Name = "ucConduit8";
            this.ucConduit8.Size = new System.Drawing.Size(16, 231);
            this.ucConduit8.TabIndex = 54;
            // 
            // ucConduit14
            // 
            this.ucConduit14.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit14.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit14.ConduitWidth = 50;
            this.ucConduit14.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit14.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit14.LiquidSpeed = 100;
            this.ucConduit14.Location = new System.Drawing.Point(810, 100);
            this.ucConduit14.Name = "ucConduit14";
            this.ucConduit14.Size = new System.Drawing.Size(13, 103);
            this.ucConduit14.TabIndex = 54;
            // 
            // ucConduit6
            // 
            this.ucConduit6.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit6.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit6.ConduitWidth = 50;
            this.ucConduit6.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit6.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit6.LiquidSpeed = 100;
            this.ucConduit6.Location = new System.Drawing.Point(960, 262);
            this.ucConduit6.Name = "ucConduit6";
            this.ucConduit6.Size = new System.Drawing.Size(16, 231);
            this.ucConduit6.TabIndex = 54;
            // 
            // ucConduit4
            // 
            this.ucConduit4.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit4.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit4.ConduitWidth = 50;
            this.ucConduit4.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit4.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit4.LiquidSpeed = 100;
            this.ucConduit4.Location = new System.Drawing.Point(876, 261);
            this.ucConduit4.Name = "ucConduit4";
            this.ucConduit4.Size = new System.Drawing.Size(16, 231);
            this.ucConduit4.TabIndex = 54;
            // 
            // WaterVaVel6
            // 
            this.WaterVaVel6.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel6.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel6.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel6.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.WaterVaVel6.LiquidSpeed = 100;
            this.WaterVaVel6.Location = new System.Drawing.Point(1283, 172);
            this.WaterVaVel6.Name = "WaterVaVel6";
            this.WaterVaVel6.Opened = true;
            this.WaterVaVel6.Size = new System.Drawing.Size(44, 90);
            this.WaterVaVel6.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.WaterVaVel6.TabIndex = 61;
            this.WaterVaVel6.Tag = "M31";
            this.WaterVaVel6.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.WaterVaVel6.ValveStyle = HZH_Controls.Controls.ValveStyle.Vertical_Right;
            this.WaterVaVel6.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // WaterVaVel5
            // 
            this.WaterVaVel5.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel5.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel5.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel5.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.WaterVaVel5.LiquidSpeed = 100;
            this.WaterVaVel5.Location = new System.Drawing.Point(1197, 172);
            this.WaterVaVel5.Name = "WaterVaVel5";
            this.WaterVaVel5.Opened = true;
            this.WaterVaVel5.Size = new System.Drawing.Size(44, 90);
            this.WaterVaVel5.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.WaterVaVel5.TabIndex = 61;
            this.WaterVaVel5.Tag = "M30";
            this.WaterVaVel5.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.WaterVaVel5.ValveStyle = HZH_Controls.Controls.ValveStyle.Vertical_Right;
            this.WaterVaVel5.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // WaterVaVel4
            // 
            this.WaterVaVel4.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel4.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel4.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel4.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.WaterVaVel4.LiquidSpeed = 100;
            this.WaterVaVel4.Location = new System.Drawing.Point(1111, 172);
            this.WaterVaVel4.Name = "WaterVaVel4";
            this.WaterVaVel4.Opened = true;
            this.WaterVaVel4.Size = new System.Drawing.Size(44, 90);
            this.WaterVaVel4.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.WaterVaVel4.TabIndex = 61;
            this.WaterVaVel4.Tag = "M29";
            this.WaterVaVel4.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.WaterVaVel4.ValveStyle = HZH_Controls.Controls.ValveStyle.Vertical_Right;
            this.WaterVaVel4.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // WaterVaVel3
            // 
            this.WaterVaVel3.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel3.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel3.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel3.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.WaterVaVel3.LiquidSpeed = 100;
            this.WaterVaVel3.Location = new System.Drawing.Point(1022, 172);
            this.WaterVaVel3.Name = "WaterVaVel3";
            this.WaterVaVel3.Opened = true;
            this.WaterVaVel3.Size = new System.Drawing.Size(44, 90);
            this.WaterVaVel3.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.WaterVaVel3.TabIndex = 61;
            this.WaterVaVel3.Tag = "M28";
            this.WaterVaVel3.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.WaterVaVel3.ValveStyle = HZH_Controls.Controls.ValveStyle.Vertical_Right;
            this.WaterVaVel3.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // WaterVaVel2
            // 
            this.WaterVaVel2.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel2.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel2.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel2.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.WaterVaVel2.LiquidSpeed = 100;
            this.WaterVaVel2.Location = new System.Drawing.Point(938, 172);
            this.WaterVaVel2.Name = "WaterVaVel2";
            this.WaterVaVel2.Opened = true;
            this.WaterVaVel2.Size = new System.Drawing.Size(44, 90);
            this.WaterVaVel2.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.WaterVaVel2.TabIndex = 61;
            this.WaterVaVel2.Tag = "M27";
            this.WaterVaVel2.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.WaterVaVel2.ValveStyle = HZH_Controls.Controls.ValveStyle.Vertical_Right;
            this.WaterVaVel2.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(539, 433);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(62, 20);
            this.label39.TabIndex = 37;
            this.label39.Text = "气阀6";
            // 
            // WaterVaVel1
            // 
            this.WaterVaVel1.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel1.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.WaterVaVel1.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.WaterVaVel1.LiquidSpeed = 100;
            this.WaterVaVel1.Location = new System.Drawing.Point(853, 172);
            this.WaterVaVel1.Name = "WaterVaVel1";
            this.WaterVaVel1.Opened = true;
            this.WaterVaVel1.Size = new System.Drawing.Size(44, 90);
            this.WaterVaVel1.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.WaterVaVel1.TabIndex = 61;
            this.WaterVaVel1.Tag = "M26";
            this.WaterVaVel1.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.WaterVaVel1.ValveStyle = HZH_Controls.Controls.ValveStyle.Vertical_Right;
            this.WaterVaVel1.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(539, 389);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "气阀5";
            // 
            // ucBottle2
            // 
            this.ucBottle2.BottleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBottle2.BottleMouthColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.ucBottle2.Direction = HZH_Controls.Controls.Direction.Down;
            this.ucBottle2.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucBottle2.Location = new System.Drawing.Point(843, 513);
            this.ucBottle2.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucBottle2.Name = "ucBottle2";
            this.ucBottle2.NO = null;
            this.ucBottle2.Size = new System.Drawing.Size(522, 112);
            this.ucBottle2.TabIndex = 81;
            this.ucBottle2.Title = "";
            this.ucBottle2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(539, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "气阀4";
            // 
            // lbEquipmentStatus
            // 
            this.lbEquipmentStatus.AutoSize = true;
            this.lbEquipmentStatus.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEquipmentStatus.Location = new System.Drawing.Point(184, 534);
            this.lbEquipmentStatus.Name = "lbEquipmentStatus";
            this.lbEquipmentStatus.Size = new System.Drawing.Size(110, 24);
            this.lbEquipmentStatus.TabIndex = 39;
            this.lbEquipmentStatus.Text = "设备状态";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "气阀3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(539, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "气阀2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(539, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "气阀1";
            // 
            // ucConduit11
            // 
            this.ucConduit11.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit11.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_Up;
            this.ucConduit11.ConduitWidth = 50;
            this.ucConduit11.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit11.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit11.LiquidSpeed = 100;
            this.ucConduit11.Location = new System.Drawing.Point(341, 203);
            this.ucConduit11.Name = "ucConduit11";
            this.ucConduit11.Size = new System.Drawing.Size(482, 12);
            this.ucConduit11.TabIndex = 74;
            // 
            // AirVavel6
            // 
            this.AirVavel6.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel6.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel6.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel6.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.AirVavel6.LiquidSpeed = 100;
            this.AirVavel6.Location = new System.Drawing.Point(592, 434);
            this.AirVavel6.Name = "AirVavel6";
            this.AirVavel6.Opened = true;
            this.AirVavel6.Size = new System.Drawing.Size(97, 36);
            this.AirVavel6.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.AirVavel6.TabIndex = 68;
            this.AirVavel6.Tag = "M25";
            this.AirVavel6.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.AirVavel6.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            this.AirVavel6.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // ucBlower1
            // 
            this.ucBlower1.BlowerColor = System.Drawing.Color.LimeGreen;
            this.ucBlower1.EntranceDirection = HZH_Controls.Controls.BlowerEntranceDirection.Left;
            this.ucBlower1.ExitDirection = HZH_Controls.Controls.BlowerExitDirection.Right;
            this.ucBlower1.FanColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucBlower1.Location = new System.Drawing.Point(441, 75);
            this.ucBlower1.Name = "ucBlower1";
            this.ucBlower1.Size = new System.Drawing.Size(117, 60);
            this.ucBlower1.TabIndex = 70;
            this.ucBlower1.TurnAround = HZH_Controls.Controls.TurnAround.None;
            this.ucBlower1.TurnSpeed = 100;
            // 
            // AirVavel5
            // 
            this.AirVavel5.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel5.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel5.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel5.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.AirVavel5.LiquidSpeed = 100;
            this.AirVavel5.Location = new System.Drawing.Point(592, 394);
            this.AirVavel5.Name = "AirVavel5";
            this.AirVavel5.Opened = true;
            this.AirVavel5.Size = new System.Drawing.Size(92, 35);
            this.AirVavel5.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.AirVavel5.TabIndex = 68;
            this.AirVavel5.Tag = "M24";
            this.AirVavel5.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.AirVavel5.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            this.AirVavel5.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // ucBottle1
            // 
            this.ucBottle1.BottleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBottle1.BottleMouthColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.ucBottle1.Direction = HZH_Controls.Controls.Direction.Down;
            this.ucBottle1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucBottle1.Location = new System.Drawing.Point(374, 6);
            this.ucBottle1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ucBottle1.Name = "ucBottle1";
            this.ucBottle1.NO = null;
            this.ucBottle1.Size = new System.Drawing.Size(67, 172);
            this.ucBottle1.TabIndex = 79;
            this.ucBottle1.Title = "过滤器";
            this.ucBottle1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // AirVavel4
            // 
            this.AirVavel4.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel4.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel4.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel4.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.AirVavel4.LiquidSpeed = 100;
            this.AirVavel4.Location = new System.Drawing.Point(592, 357);
            this.AirVavel4.Name = "AirVavel4";
            this.AirVavel4.Opened = true;
            this.AirVavel4.Size = new System.Drawing.Size(92, 35);
            this.AirVavel4.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.AirVavel4.TabIndex = 68;
            this.AirVavel4.Tag = "M23";
            this.AirVavel4.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.AirVavel4.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            this.AirVavel4.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // ucValve1
            // 
            this.ucValve1.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucValve1.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucValve1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucValve1.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucValve1.LiquidSpeed = 100;
            this.ucValve1.Location = new System.Drawing.Point(770, 61);
            this.ucValve1.Name = "ucValve1";
            this.ucValve1.Opened = true;
            this.ucValve1.Size = new System.Drawing.Size(92, 45);
            this.ucValve1.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucValve1.TabIndex = 68;
            this.ucValve1.Tag = "M33";
            this.ucValve1.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucValve1.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            this.ucValve1.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // AirVavel3
            // 
            this.AirVavel3.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel3.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel3.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel3.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.AirVavel3.LiquidSpeed = 100;
            this.AirVavel3.Location = new System.Drawing.Point(592, 320);
            this.AirVavel3.Name = "AirVavel3";
            this.AirVavel3.Opened = true;
            this.AirVavel3.Size = new System.Drawing.Size(92, 35);
            this.AirVavel3.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.AirVavel3.TabIndex = 68;
            this.AirVavel3.Tag = "M22";
            this.AirVavel3.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.AirVavel3.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            this.AirVavel3.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // AirVavel2
            // 
            this.AirVavel2.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel2.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel2.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel2.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.AirVavel2.LiquidSpeed = 100;
            this.AirVavel2.Location = new System.Drawing.Point(591, 280);
            this.AirVavel2.Name = "AirVavel2";
            this.AirVavel2.Opened = true;
            this.AirVavel2.Size = new System.Drawing.Size(92, 35);
            this.AirVavel2.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.AirVavel2.TabIndex = 68;
            this.AirVavel2.Tag = "M21";
            this.AirVavel2.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.AirVavel2.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            this.AirVavel2.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // AirVavel1
            // 
            this.AirVavel1.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel1.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.AirVavel1.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.AirVavel1.LiquidSpeed = 100;
            this.AirVavel1.Location = new System.Drawing.Point(594, 245);
            this.AirVavel1.Name = "AirVavel1";
            this.AirVavel1.Opened = true;
            this.AirVavel1.Size = new System.Drawing.Size(92, 36);
            this.AirVavel1.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.AirVavel1.TabIndex = 68;
            this.AirVavel1.Tag = "M20";
            this.AirVavel1.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.AirVavel1.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            this.AirVavel1.Click += new System.EventHandler(this.WaterVaVel3_Click);
            // 
            // ucConduit7
            // 
            this.ucConduit7.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit7.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_None;
            this.ucConduit7.ConduitWidth = 50;
            this.ucConduit7.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit7.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit7.LiquidSpeed = 100;
            this.ucConduit7.Location = new System.Drawing.Point(1069, 100);
            this.ucConduit7.Name = "ucConduit7";
            this.ucConduit7.Size = new System.Drawing.Size(17, 62);
            this.ucConduit7.TabIndex = 46;
            // 
            // ucConduit2
            // 
            this.ucConduit2.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit2.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_Right_None;
            this.ucConduit2.ConduitWidth = 50;
            this.ucConduit2.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit2.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit2.LiquidSpeed = 100;
            this.ucConduit2.Location = new System.Drawing.Point(412, 263);
            this.ucConduit2.Name = "ucConduit2";
            this.ucConduit2.Size = new System.Drawing.Size(15, 190);
            this.ucConduit2.TabIndex = 57;
            // 
            // ucConduit9
            // 
            this.ucConduit9.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit9.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Vertical_None_Right;
            this.ucConduit9.ConduitWidth = 50;
            this.ucConduit9.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit9.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit9.LiquidSpeed = 100;
            this.ucConduit9.Location = new System.Drawing.Point(327, 61);
            this.ucConduit9.Name = "ucConduit9";
            this.ucConduit9.Size = new System.Drawing.Size(15, 154);
            this.ucConduit9.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(1258, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 69);
            this.label8.TabIndex = 36;
            this.label8.Text = "水阀6";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1172, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 69);
            this.label7.TabIndex = 36;
            this.label7.Text = "水阀5";
            // 
            // ucConduit18
            // 
            this.ucConduit18.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit18.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit18.ConduitWidth = 50;
            this.ucConduit18.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit18.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit18.LiquidSpeed = 100;
            this.ucConduit18.Location = new System.Drawing.Point(3, 453);
            this.ucConduit18.Name = "ucConduit18";
            this.ucConduit18.Size = new System.Drawing.Size(482, 12);
            this.ucConduit18.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1087, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 71);
            this.label6.TabIndex = 36;
            this.label6.Text = "水阀4";
            // 
            // ucConduit5
            // 
            this.ucConduit5.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit5.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_Down_Down;
            this.ucConduit5.ConduitWidth = 50;
            this.ucConduit5.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit5.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit5.LiquidSpeed = 100;
            this.ucConduit5.Location = new System.Drawing.Point(874, 157);
            this.ucConduit5.Name = "ucConduit5";
            this.ucConduit5.Size = new System.Drawing.Size(450, 15);
            this.ucConduit5.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(997, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 69);
            this.label5.TabIndex = 36;
            this.label5.Text = "水阀3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(914, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 69);
            this.label2.TabIndex = 36;
            this.label2.Text = "水阀2";
            // 
            // ucConduit1
            // 
            this.ucConduit1.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit1.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit1.ConduitWidth = 50;
            this.ucConduit1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit1.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit1.LiquidSpeed = 100;
            this.ucConduit1.Location = new System.Drawing.Point(-1, 47);
            this.ucConduit1.Name = "ucConduit1";
            this.ucConduit1.Size = new System.Drawing.Size(383, 17);
            this.ucConduit1.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(779, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "溢流阀";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(829, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 71);
            this.label10.TabIndex = 36;
            this.label10.Text = "水阀1";
            // 
            // lbIsReady
            // 
            this.lbIsReady.AutoSize = true;
            this.lbIsReady.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbIsReady.Location = new System.Drawing.Point(71, 480);
            this.lbIsReady.Name = "lbIsReady";
            this.lbIsReady.Size = new System.Drawing.Size(93, 20);
            this.lbIsReady.TabIndex = 40;
            this.lbIsReady.Text = "未准备好";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(16, 78);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(114, 20);
            this.label41.TabIndex = 28;
            this.label41.Text = "产品型号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "清洗水压KPa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "当前冲洗号";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBox2.Location = new System.Drawing.Point(136, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 30);
            this.textBox2.TabIndex = 23;
            this.verificationComponent1.SetVerificationCustomRegex(this.textBox2, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBox2, "");
            this.verificationComponent1.SetVerificationModel(this.textBox2, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBox2, false);
            // 
            // txtHomeWashPress
            // 
            this.txtHomeWashPress.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHomeWashPress.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtHomeWashPress.Location = new System.Drawing.Point(179, 144);
            this.txtHomeWashPress.Name = "txtHomeWashPress";
            this.txtHomeWashPress.Size = new System.Drawing.Size(119, 30);
            this.txtHomeWashPress.TabIndex = 23;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtHomeWashPress, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtHomeWashPress, "");
            this.verificationComponent1.SetVerificationModel(this.txtHomeWashPress, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtHomeWashPress, false);
            // 
            // txtWashNum
            // 
            this.txtWashNum.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtWashNum.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtWashNum.Location = new System.Drawing.Point(12, 144);
            this.txtWashNum.Name = "txtWashNum";
            this.txtWashNum.Size = new System.Drawing.Size(119, 30);
            this.txtWashNum.TabIndex = 24;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtWashNum, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtWashNum, "");
            this.verificationComponent1.SetVerificationModel(this.txtWashNum, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtWashNum, false);
            // 
            // ucConduit3
            // 
            this.ucConduit3.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit3.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_Down;
            this.ucConduit3.ConduitWidth = 50;
            this.ucConduit3.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit3.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit3.LiquidSpeed = 100;
            this.ucConduit3.Location = new System.Drawing.Point(552, 85);
            this.ucConduit3.Name = "ucConduit3";
            this.ucConduit3.Size = new System.Drawing.Size(534, 15);
            this.ucConduit3.TabIndex = 44;
            // 
            // ucConduit15
            // 
            this.ucConduit15.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit15.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit15.ConduitWidth = 50;
            this.ucConduit15.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit15.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit15.LiquidSpeed = 100;
            this.ucConduit15.Location = new System.Drawing.Point(427, 263);
            this.ucConduit15.Name = "ucConduit15";
            this.ucConduit15.Size = new System.Drawing.Size(452, 14);
            this.ucConduit15.TabIndex = 74;
            // 
            // ucConduit16
            // 
            this.ucConduit16.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit16.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit16.ConduitWidth = 50;
            this.ucConduit16.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit16.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit16.LiquidSpeed = 100;
            this.ucConduit16.Location = new System.Drawing.Point(427, 299);
            this.ucConduit16.Name = "ucConduit16";
            this.ucConduit16.Size = new System.Drawing.Size(537, 10);
            this.ucConduit16.TabIndex = 87;
            // 
            // ucConduit17
            // 
            this.ucConduit17.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit17.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit17.ConduitWidth = 50;
            this.ucConduit17.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit17.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit17.LiquidSpeed = 100;
            this.ucConduit17.Location = new System.Drawing.Point(418, 339);
            this.ucConduit17.Name = "ucConduit17";
            this.ucConduit17.Size = new System.Drawing.Size(632, 10);
            this.ucConduit17.TabIndex = 87;
            // 
            // ucConduit19
            // 
            this.ucConduit19.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit19.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit19.ConduitWidth = 50;
            this.ucConduit19.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit19.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit19.LiquidSpeed = 100;
            this.ucConduit19.Location = new System.Drawing.Point(418, 376);
            this.ucConduit19.Name = "ucConduit19";
            this.ucConduit19.Size = new System.Drawing.Size(720, 11);
            this.ucConduit19.TabIndex = 87;
            // 
            // ucConduit20
            // 
            this.ucConduit20.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit20.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit20.ConduitWidth = 50;
            this.ucConduit20.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit20.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit20.LiquidSpeed = 100;
            this.ucConduit20.Location = new System.Drawing.Point(418, 409);
            this.ucConduit20.Name = "ucConduit20";
            this.ucConduit20.Size = new System.Drawing.Size(804, 15);
            this.ucConduit20.TabIndex = 87;
            // 
            // ucConduit21
            // 
            this.ucConduit21.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConduit21.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.ucConduit21.ConduitWidth = 50;
            this.ucConduit21.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucConduit21.LiquidDirection = HZH_Controls.Controls.LiquidDirection.None;
            this.ucConduit21.LiquidSpeed = 100;
            this.ucConduit21.Location = new System.Drawing.Point(476, 453);
            this.ucConduit21.Name = "ucConduit21";
            this.ucConduit21.Size = new System.Drawing.Size(834, 12);
            this.ucConduit21.TabIndex = 87;
            // 
            // btnManualWrite
            // 
            this.btnManualWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.btnManualWrite.Controls.Add(this.txtPosition1);
            this.btnManualWrite.Controls.Add(this.groupBox5);
            this.btnManualWrite.Controls.Add(this.groupBox3);
            this.btnManualWrite.Controls.Add(this.label20);
            this.btnManualWrite.Controls.Add(this.label19);
            this.btnManualWrite.Controls.Add(this.label18);
            this.btnManualWrite.Controls.Add(this.txtWashPress);
            this.btnManualWrite.Controls.Add(this.txtPosition2);
            this.btnManualWrite.Controls.Add(this.BtnGasVel6);
            this.btnManualWrite.Controls.Add(this.BtnGasVel5);
            this.btnManualWrite.Controls.Add(this.BtnWash6);
            this.btnManualWrite.Controls.Add(this.BtnGasVel4);
            this.btnManualWrite.Controls.Add(this.BtnWash5);
            this.btnManualWrite.Controls.Add(this.BtnGasVel3);
            this.btnManualWrite.Controls.Add(this.userButton21);
            this.btnManualWrite.Controls.Add(this.userButton20);
            this.btnManualWrite.Controls.Add(this.userButton19);
            this.btnManualWrite.Controls.Add(this.userButton18);
            this.btnManualWrite.Controls.Add(this.BtnWash4);
            this.btnManualWrite.Controls.Add(this.BtnHighPres);
            this.btnManualWrite.Controls.Add(this.BtnGasVel2);
            this.btnManualWrite.Controls.Add(this.BtnWash3);
            this.btnManualWrite.Controls.Add(this.BtnOverVel);
            this.btnManualWrite.Controls.Add(this.BtnGasVel1);
            this.btnManualWrite.Controls.Add(this.BtnWash2);
            this.btnManualWrite.Controls.Add(this.BtnWash1);
            this.btnManualWrite.Location = new System.Drawing.Point(4, 14);
            this.btnManualWrite.Name = "btnManualWrite";
            this.btnManualWrite.Padding = new System.Windows.Forms.Padding(3);
            this.btnManualWrite.Size = new System.Drawing.Size(1342, 661);
            this.btnManualWrite.TabIndex = 1;
            this.btnManualWrite.Text = "参数写入";
            // 
            // txtPosition1
            // 
            this.txtPosition1.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPosition1.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtPosition1.Location = new System.Drawing.Point(279, 28);
            this.txtPosition1.Name = "txtPosition1";
            this.txtPosition1.ReadOnly = true;
            this.txtPosition1.Size = new System.Drawing.Size(130, 30);
            this.txtPosition1.TabIndex = 28;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtPosition1, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtPosition1, "");
            this.verificationComponent1.SetVerificationModel(this.txtPosition1, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtPosition1, false);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txtMotorMove);
            this.groupBox5.Controls.Add(this.ucRadioButton8);
            this.groupBox5.Controls.Add(this.ucRadioButton7);
            this.groupBox5.Controls.Add(this.ucRadioButton6);
            this.groupBox5.Controls.Add(this.ucRadioButton5);
            this.groupBox5.Controls.Add(this.ucRadioButton4);
            this.groupBox5.Controls.Add(this.ucRadioButton3);
            this.groupBox5.Controls.Add(this.ucRadioButton2);
            this.groupBox5.Controls.Add(this.CBmotorMove);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox5.Location = new System.Drawing.Point(201, 87);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 505);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "电机移动mm";
            // 
            // txtMotorMove
            // 
            this.txtMotorMove.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMotorMove.Location = new System.Drawing.Point(41, 459);
            this.txtMotorMove.Name = "txtMotorMove";
            this.txtMotorMove.Size = new System.Drawing.Size(156, 35);
            this.txtMotorMove.TabIndex = 2;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtMotorMove, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtMotorMove, "");
            this.verificationComponent1.SetVerificationModel(this.txtMotorMove, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtMotorMove, false);
            this.txtMotorMove.MouseLeave += new System.EventHandler(this.txtMotorMove_MouseLeave);
            // 
            // ucRadioButton8
            // 
            this.ucRadioButton8.Checked = false;
            this.ucRadioButton8.GroupName = null;
            this.ucRadioButton8.Location = new System.Drawing.Point(41, 349);
            this.ucRadioButton8.Name = "ucRadioButton8";
            this.ucRadioButton8.Size = new System.Drawing.Size(191, 30);
            this.ucRadioButton8.TabIndex = 1;
            this.ucRadioButton8.TextValue = "   50mm";
            this.ucRadioButton8.CheckedChangeEvent += new System.EventHandler(this.CBmotorMove_CheckedChangeEvent);
            // 
            // ucRadioButton7
            // 
            this.ucRadioButton7.Checked = false;
            this.ucRadioButton7.GroupName = null;
            this.ucRadioButton7.Location = new System.Drawing.Point(41, 403);
            this.ucRadioButton7.Name = "ucRadioButton7";
            this.ucRadioButton7.Size = new System.Drawing.Size(191, 30);
            this.ucRadioButton7.TabIndex = 1;
            this.ucRadioButton7.TextValue = "   自定义";
            // 
            // ucRadioButton6
            // 
            this.ucRadioButton6.Checked = false;
            this.ucRadioButton6.GroupName = null;
            this.ucRadioButton6.Location = new System.Drawing.Point(41, 295);
            this.ucRadioButton6.Name = "ucRadioButton6";
            this.ucRadioButton6.Size = new System.Drawing.Size(191, 30);
            this.ucRadioButton6.TabIndex = 1;
            this.ucRadioButton6.TextValue = "   20mm";
            this.ucRadioButton6.CheckedChangeEvent += new System.EventHandler(this.CBmotorMove_CheckedChangeEvent);
            // 
            // ucRadioButton5
            // 
            this.ucRadioButton5.Checked = false;
            this.ucRadioButton5.GroupName = null;
            this.ucRadioButton5.Location = new System.Drawing.Point(41, 241);
            this.ucRadioButton5.Name = "ucRadioButton5";
            this.ucRadioButton5.Size = new System.Drawing.Size(191, 30);
            this.ucRadioButton5.TabIndex = 1;
            this.ucRadioButton5.TextValue = "   10mm";
            this.ucRadioButton5.CheckedChangeEvent += new System.EventHandler(this.CBmotorMove_CheckedChangeEvent);
            // 
            // ucRadioButton4
            // 
            this.ucRadioButton4.Checked = false;
            this.ucRadioButton4.GroupName = null;
            this.ucRadioButton4.Location = new System.Drawing.Point(41, 187);
            this.ucRadioButton4.Name = "ucRadioButton4";
            this.ucRadioButton4.Size = new System.Drawing.Size(191, 30);
            this.ucRadioButton4.TabIndex = 1;
            this.ucRadioButton4.TextValue = "  5.0mm";
            this.ucRadioButton4.CheckedChangeEvent += new System.EventHandler(this.CBmotorMove_CheckedChangeEvent);
            // 
            // ucRadioButton3
            // 
            this.ucRadioButton3.Checked = false;
            this.ucRadioButton3.GroupName = null;
            this.ucRadioButton3.Location = new System.Drawing.Point(41, 133);
            this.ucRadioButton3.Name = "ucRadioButton3";
            this.ucRadioButton3.Size = new System.Drawing.Size(191, 30);
            this.ucRadioButton3.TabIndex = 1;
            this.ucRadioButton3.TextValue = "  1.0mm";
            this.ucRadioButton3.CheckedChangeEvent += new System.EventHandler(this.CBmotorMove_CheckedChangeEvent);
            // 
            // ucRadioButton2
            // 
            this.ucRadioButton2.Checked = false;
            this.ucRadioButton2.GroupName = null;
            this.ucRadioButton2.Location = new System.Drawing.Point(41, 79);
            this.ucRadioButton2.Name = "ucRadioButton2";
            this.ucRadioButton2.Size = new System.Drawing.Size(191, 30);
            this.ucRadioButton2.TabIndex = 1;
            this.ucRadioButton2.TextValue = "  0.5mm";
            this.ucRadioButton2.CheckedChangeEvent += new System.EventHandler(this.CBmotorMove_CheckedChangeEvent);
            // 
            // CBmotorMove
            // 
            this.CBmotorMove.Checked = false;
            this.CBmotorMove.GroupName = null;
            this.CBmotorMove.Location = new System.Drawing.Point(41, 25);
            this.CBmotorMove.Name = "CBmotorMove";
            this.CBmotorMove.Size = new System.Drawing.Size(191, 30);
            this.CBmotorMove.TabIndex = 1;
            this.CBmotorMove.TextValue = "  0.1mm";
            this.CBmotorMove.CheckedChangeEvent += new System.EventHandler(this.CBmotorMove_CheckedChangeEvent);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EnbleLowFreq);
            this.groupBox3.Controls.Add(this.BtnToStandy);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtSetFreq);
            this.groupBox3.Controls.Add(this.txtSetPres);
            this.groupBox3.Controls.Add(this.txtSpeed);
            this.groupBox3.Controls.Add(this.txtPos);
            this.groupBox3.Controls.Add(this.BtnToWorkPos);
            this.groupBox3.Location = new System.Drawing.Point(982, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 326);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // EnbleLowFreq
            // 
            this.EnbleLowFreq.AutoSize = true;
            this.EnbleLowFreq.Location = new System.Drawing.Point(160, 214);
            this.EnbleLowFreq.Name = "EnbleLowFreq";
            this.EnbleLowFreq.Size = new System.Drawing.Size(157, 24);
            this.EnbleLowFreq.TabIndex = 34;
            this.EnbleLowFreq.Text = "手动频率使能";
            this.EnbleLowFreq.UseVisualStyleBackColor = true;
            this.EnbleLowFreq.CheckedChanged += new System.EventHandler(this.EnbleLowFreq_CheckedChanged);
            // 
            // BtnToStandy
            // 
            this.BtnToStandy.ActiveColor = System.Drawing.Color.Orange;
            this.BtnToStandy.BackColor = System.Drawing.Color.Transparent;
            this.BtnToStandy.CustomerInformation = "";
            this.BtnToStandy.EnableColor = System.Drawing.Color.Orange;
            this.BtnToStandy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnToStandy.Location = new System.Drawing.Point(28, 254);
            this.BtnToStandy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnToStandy.Name = "BtnToStandy";
            this.BtnToStandy.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnToStandy.Size = new System.Drawing.Size(134, 46);
            this.BtnToStandy.TabIndex = 32;
            this.BtnToStandy.TextColor = System.Drawing.Color.White;
            this.BtnToStandy.UIText = "当前位置到待机位";
            this.BtnToStandy.Click += new System.EventHandler(this.BtnToStandy_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 181);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(200, 20);
            this.label31.TabIndex = 31;
            this.label31.Text = "手动频率设定(Hz)：";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 134);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(211, 20);
            this.label30.TabIndex = 31;
            this.label30.Text = "手动水压设定(KPa)：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(200, 20);
            this.label22.TabIndex = 31;
            this.label22.Text = "电机速度（mm/s）：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(199, 20);
            this.label21.TabIndex = 31;
            this.label21.Text = "电机工作位（mm）：";
            // 
            // txtSetFreq
            // 
            this.txtSetFreq.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSetFreq.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSetFreq.Location = new System.Drawing.Point(195, 178);
            this.txtSetFreq.Name = "txtSetFreq";
            this.txtSetFreq.Size = new System.Drawing.Size(109, 30);
            this.txtSetFreq.TabIndex = 30;
            this.txtSetFreq.Tag = "28";
            this.verificationComponent1.SetVerificationCustomRegex(this.txtSetFreq, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtSetFreq, "");
            this.verificationComponent1.SetVerificationModel(this.txtSetFreq, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtSetFreq, false);
            this.txtSetFreq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetPres_KeyDown);
            // 
            // txtSetPres
            // 
            this.txtSetPres.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSetPres.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSetPres.Location = new System.Drawing.Point(195, 127);
            this.txtSetPres.Name = "txtSetPres";
            this.txtSetPres.Size = new System.Drawing.Size(109, 30);
            this.txtSetPres.TabIndex = 30;
            this.txtSetPres.Tag = "27";
            this.verificationComponent1.SetVerificationCustomRegex(this.txtSetPres, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtSetPres, "");
            this.verificationComponent1.SetVerificationModel(this.txtSetPres, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtSetPres, false);
            this.txtSetPres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetPres_KeyDown);
            // 
            // txtSpeed
            // 
            this.txtSpeed.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSpeed.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtSpeed.Location = new System.Drawing.Point(195, 76);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(109, 30);
            this.txtSpeed.TabIndex = 30;
            this.txtSpeed.Tag = "609";
            this.verificationComponent1.SetVerificationCustomRegex(this.txtSpeed, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtSpeed, "");
            this.verificationComponent1.SetVerificationModel(this.txtSpeed, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtSpeed, false);
            this.txtSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetPres_KeyDown);
            // 
            // txtPos
            // 
            this.txtPos.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPos.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtPos.Location = new System.Drawing.Point(195, 25);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(109, 30);
            this.txtPos.TabIndex = 30;
            this.txtPos.Tag = "610";
            this.verificationComponent1.SetVerificationCustomRegex(this.txtPos, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtPos, "");
            this.verificationComponent1.SetVerificationModel(this.txtPos, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtPos, false);
            this.txtPos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSetPres_KeyDown);
            // 
            // BtnToWorkPos
            // 
            this.BtnToWorkPos.ActiveColor = System.Drawing.Color.Orange;
            this.BtnToWorkPos.BackColor = System.Drawing.Color.Transparent;
            this.BtnToWorkPos.CustomerInformation = "";
            this.BtnToWorkPos.EnableColor = System.Drawing.Color.Orange;
            this.BtnToWorkPos.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnToWorkPos.Location = new System.Drawing.Point(190, 254);
            this.BtnToWorkPos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnToWorkPos.Name = "BtnToWorkPos";
            this.BtnToWorkPos.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnToWorkPos.Size = new System.Drawing.Size(134, 46);
            this.BtnToWorkPos.TabIndex = 0;
            this.BtnToWorkPos.TextColor = System.Drawing.Color.White;
            this.BtnToWorkPos.UIText = "当前位置到工作位";
            this.BtnToWorkPos.Click += new System.EventHandler(this.BtnToWorkPos_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(978, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(224, 24);
            this.label20.TabIndex = 29;
            this.label20.Text = "清洗水压（KPa）：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(542, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(274, 24);
            this.label19.TabIndex = 29;
            this.label19.Text = "电机2当前位置（mm）：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(21, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(274, 24);
            this.label18.TabIndex = 29;
            this.label18.Text = "电机1当前位置（mm）：";
            // 
            // txtWashPress
            // 
            this.txtWashPress.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtWashPress.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtWashPress.Location = new System.Drawing.Point(1208, 25);
            this.txtWashPress.Name = "txtWashPress";
            this.txtWashPress.ReadOnly = true;
            this.txtWashPress.Size = new System.Drawing.Size(130, 30);
            this.txtWashPress.TabIndex = 28;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtWashPress, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtWashPress, "");
            this.verificationComponent1.SetVerificationModel(this.txtWashPress, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtWashPress, false);
            // 
            // txtPosition2
            // 
            this.txtPosition2.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPosition2.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtPosition2.Location = new System.Drawing.Point(803, 25);
            this.txtPosition2.Name = "txtPosition2";
            this.txtPosition2.ReadOnly = true;
            this.txtPosition2.Size = new System.Drawing.Size(130, 30);
            this.txtPosition2.TabIndex = 28;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtPosition2, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtPosition2, "");
            this.verificationComponent1.SetVerificationModel(this.txtPosition2, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtPosition2, false);
            // 
            // BtnGasVel6
            // 
            this.BtnGasVel6.ActiveColor = System.Drawing.Color.Orange;
            this.BtnGasVel6.BackColor = System.Drawing.Color.Transparent;
            this.BtnGasVel6.CustomerInformation = "";
            this.BtnGasVel6.EnableColor = System.Drawing.Color.Orange;
            this.BtnGasVel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGasVel6.Location = new System.Drawing.Point(488, 546);
            this.BtnGasVel6.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGasVel6.Name = "BtnGasVel6";
            this.BtnGasVel6.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnGasVel6.Size = new System.Drawing.Size(134, 46);
            this.BtnGasVel6.TabIndex = 0;
            this.BtnGasVel6.Tag = "M25";
            this.BtnGasVel6.TextColor = System.Drawing.Color.White;
            this.BtnGasVel6.UIText = "气阀6";
            this.BtnGasVel6.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnGasVel5
            // 
            this.BtnGasVel5.ActiveColor = System.Drawing.Color.Orange;
            this.BtnGasVel5.BackColor = System.Drawing.Color.Transparent;
            this.BtnGasVel5.CustomerInformation = "";
            this.BtnGasVel5.EnableColor = System.Drawing.Color.Orange;
            this.BtnGasVel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGasVel5.Location = new System.Drawing.Point(488, 455);
            this.BtnGasVel5.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGasVel5.Name = "BtnGasVel5";
            this.BtnGasVel5.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnGasVel5.Size = new System.Drawing.Size(134, 46);
            this.BtnGasVel5.TabIndex = 0;
            this.BtnGasVel5.Tag = "M24";
            this.BtnGasVel5.TextColor = System.Drawing.Color.White;
            this.BtnGasVel5.UIText = "气阀5";
            this.BtnGasVel5.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnWash6
            // 
            this.BtnWash6.ActiveColor = System.Drawing.Color.Orange;
            this.BtnWash6.BackColor = System.Drawing.Color.Transparent;
            this.BtnWash6.CustomerInformation = "";
            this.BtnWash6.EnableColor = System.Drawing.Color.Orange;
            this.BtnWash6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnWash6.Location = new System.Drawing.Point(749, 546);
            this.BtnWash6.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWash6.Name = "BtnWash6";
            this.BtnWash6.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnWash6.Size = new System.Drawing.Size(134, 46);
            this.BtnWash6.TabIndex = 0;
            this.BtnWash6.Tag = "M31";
            this.BtnWash6.TextColor = System.Drawing.Color.White;
            this.BtnWash6.UIText = "冲洗阀6";
            this.BtnWash6.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnGasVel4
            // 
            this.BtnGasVel4.ActiveColor = System.Drawing.Color.Orange;
            this.BtnGasVel4.BackColor = System.Drawing.Color.Transparent;
            this.BtnGasVel4.CustomerInformation = "";
            this.BtnGasVel4.EnableColor = System.Drawing.Color.Orange;
            this.BtnGasVel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGasVel4.Location = new System.Drawing.Point(488, 363);
            this.BtnGasVel4.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGasVel4.Name = "BtnGasVel4";
            this.BtnGasVel4.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnGasVel4.Size = new System.Drawing.Size(134, 46);
            this.BtnGasVel4.TabIndex = 0;
            this.BtnGasVel4.Tag = "M23";
            this.BtnGasVel4.TextColor = System.Drawing.Color.White;
            this.BtnGasVel4.UIText = "气阀4";
            this.BtnGasVel4.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnWash5
            // 
            this.BtnWash5.ActiveColor = System.Drawing.Color.Orange;
            this.BtnWash5.BackColor = System.Drawing.Color.Transparent;
            this.BtnWash5.CustomerInformation = "";
            this.BtnWash5.EnableColor = System.Drawing.Color.Orange;
            this.BtnWash5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnWash5.Location = new System.Drawing.Point(749, 455);
            this.BtnWash5.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWash5.Name = "BtnWash5";
            this.BtnWash5.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnWash5.Size = new System.Drawing.Size(134, 46);
            this.BtnWash5.TabIndex = 0;
            this.BtnWash5.Tag = "M30";
            this.BtnWash5.TextColor = System.Drawing.Color.White;
            this.BtnWash5.UIText = "冲洗阀5";
            this.BtnWash5.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnGasVel3
            // 
            this.BtnGasVel3.ActiveColor = System.Drawing.Color.Orange;
            this.BtnGasVel3.BackColor = System.Drawing.Color.Transparent;
            this.BtnGasVel3.CustomerInformation = "";
            this.BtnGasVel3.EnableColor = System.Drawing.Color.Orange;
            this.BtnGasVel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGasVel3.Location = new System.Drawing.Point(488, 271);
            this.BtnGasVel3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGasVel3.Name = "BtnGasVel3";
            this.BtnGasVel3.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnGasVel3.Size = new System.Drawing.Size(134, 46);
            this.BtnGasVel3.TabIndex = 0;
            this.BtnGasVel3.Tag = "M22";
            this.BtnGasVel3.TextColor = System.Drawing.Color.White;
            this.BtnGasVel3.UIText = "气阀3";
            this.BtnGasVel3.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // userButton21
            // 
            this.userButton21.ActiveColor = System.Drawing.Color.Orange;
            this.userButton21.BackColor = System.Drawing.Color.Transparent;
            this.userButton21.CustomerInformation = "";
            this.userButton21.EnableColor = System.Drawing.Color.Orange;
            this.userButton21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.userButton21.Location = new System.Drawing.Point(35, 517);
            this.userButton21.Margin = new System.Windows.Forms.Padding(4);
            this.userButton21.Name = "userButton21";
            this.userButton21.OriginalColor = System.Drawing.Color.DarkGray;
            this.userButton21.Size = new System.Drawing.Size(146, 46);
            this.userButton21.TabIndex = 0;
            this.userButton21.Tag = "M534";
            this.userButton21.TextColor = System.Drawing.Color.White;
            this.userButton21.UIText = "复位";
            this.userButton21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.userButton21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // userButton20
            // 
            this.userButton20.ActiveColor = System.Drawing.Color.Orange;
            this.userButton20.BackColor = System.Drawing.Color.Transparent;
            this.userButton20.CustomerInformation = "";
            this.userButton20.EnableColor = System.Drawing.Color.Orange;
            this.userButton20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.userButton20.Location = new System.Drawing.Point(35, 405);
            this.userButton20.Margin = new System.Windows.Forms.Padding(4);
            this.userButton20.Name = "userButton20";
            this.userButton20.OriginalColor = System.Drawing.Color.DarkGray;
            this.userButton20.Size = new System.Drawing.Size(146, 46);
            this.userButton20.TabIndex = 0;
            this.userButton20.Tag = "M531";
            this.userButton20.TextColor = System.Drawing.Color.White;
            this.userButton20.UIText = "上   升";
            this.userButton20.Click += new System.EventHandler(this.btnChangeMode_Click);
            this.userButton20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.userButton20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // userButton19
            // 
            this.userButton19.ActiveColor = System.Drawing.Color.Orange;
            this.userButton19.BackColor = System.Drawing.Color.Transparent;
            this.userButton19.CustomerInformation = "";
            this.userButton19.EnableColor = System.Drawing.Color.Orange;
            this.userButton19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.userButton19.Location = new System.Drawing.Point(35, 271);
            this.userButton19.Margin = new System.Windows.Forms.Padding(4);
            this.userButton19.Name = "userButton19";
            this.userButton19.OriginalColor = System.Drawing.Color.DarkGray;
            this.userButton19.Size = new System.Drawing.Size(146, 46);
            this.userButton19.TabIndex = 0;
            this.userButton19.Tag = "M530";
            this.userButton19.TextColor = System.Drawing.Color.White;
            this.userButton19.UIText = "下  降";
            this.userButton19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.userButton19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // userButton18
            // 
            this.userButton18.ActiveColor = System.Drawing.Color.Orange;
            this.userButton18.BackColor = System.Drawing.Color.Transparent;
            this.userButton18.CustomerInformation = "";
            this.userButton18.EnableColor = System.Drawing.Color.Orange;
            this.userButton18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.userButton18.Location = new System.Drawing.Point(35, 141);
            this.userButton18.Margin = new System.Windows.Forms.Padding(4);
            this.userButton18.Name = "userButton18";
            this.userButton18.OriginalColor = System.Drawing.Color.DarkGray;
            this.userButton18.Size = new System.Drawing.Size(146, 46);
            this.userButton18.TabIndex = 0;
            this.userButton18.Tag = "H207";
            this.userButton18.TextColor = System.Drawing.Color.White;
            this.userButton18.UIText = "手动模式";
            this.userButton18.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnWash4
            // 
            this.BtnWash4.ActiveColor = System.Drawing.Color.Orange;
            this.BtnWash4.BackColor = System.Drawing.Color.Transparent;
            this.BtnWash4.CustomerInformation = "";
            this.BtnWash4.EnableColor = System.Drawing.Color.Orange;
            this.BtnWash4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnWash4.Location = new System.Drawing.Point(749, 363);
            this.BtnWash4.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWash4.Name = "BtnWash4";
            this.BtnWash4.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnWash4.Size = new System.Drawing.Size(134, 46);
            this.BtnWash4.TabIndex = 0;
            this.BtnWash4.Tag = "M29";
            this.BtnWash4.TextColor = System.Drawing.Color.White;
            this.BtnWash4.UIText = "冲洗阀4";
            this.BtnWash4.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnHighPres
            // 
            this.BtnHighPres.ActiveColor = System.Drawing.Color.Orange;
            this.BtnHighPres.BackColor = System.Drawing.Color.Transparent;
            this.BtnHighPres.CustomerInformation = "";
            this.BtnHighPres.EnableColor = System.Drawing.Color.Orange;
            this.BtnHighPres.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnHighPres.Location = new System.Drawing.Point(1060, 179);
            this.BtnHighPres.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHighPres.Name = "BtnHighPres";
            this.BtnHighPres.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnHighPres.Size = new System.Drawing.Size(134, 46);
            this.BtnHighPres.TabIndex = 0;
            this.BtnHighPres.Tag = "M34";
            this.BtnHighPres.TextColor = System.Drawing.Color.White;
            this.BtnHighPres.UIText = "高压水泵";
            this.BtnHighPres.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnGasVel2
            // 
            this.BtnGasVel2.ActiveColor = System.Drawing.Color.Orange;
            this.BtnGasVel2.BackColor = System.Drawing.Color.Transparent;
            this.BtnGasVel2.CustomerInformation = "";
            this.BtnGasVel2.EnableColor = System.Drawing.Color.Orange;
            this.BtnGasVel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGasVel2.Location = new System.Drawing.Point(488, 179);
            this.BtnGasVel2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGasVel2.Name = "BtnGasVel2";
            this.BtnGasVel2.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnGasVel2.Size = new System.Drawing.Size(134, 46);
            this.BtnGasVel2.TabIndex = 0;
            this.BtnGasVel2.Tag = "M21";
            this.BtnGasVel2.TextColor = System.Drawing.Color.White;
            this.BtnGasVel2.UIText = "气阀2";
            this.BtnGasVel2.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnWash3
            // 
            this.BtnWash3.ActiveColor = System.Drawing.Color.Orange;
            this.BtnWash3.BackColor = System.Drawing.Color.Transparent;
            this.BtnWash3.CustomerInformation = "";
            this.BtnWash3.EnableColor = System.Drawing.Color.Orange;
            this.BtnWash3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnWash3.Location = new System.Drawing.Point(749, 271);
            this.BtnWash3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWash3.Name = "BtnWash3";
            this.BtnWash3.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnWash3.Size = new System.Drawing.Size(134, 46);
            this.BtnWash3.TabIndex = 0;
            this.BtnWash3.Tag = "M28";
            this.BtnWash3.TextColor = System.Drawing.Color.White;
            this.BtnWash3.UIText = "冲洗阀3";
            this.BtnWash3.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnOverVel
            // 
            this.BtnOverVel.ActiveColor = System.Drawing.Color.Orange;
            this.BtnOverVel.BackColor = System.Drawing.Color.Transparent;
            this.BtnOverVel.CustomerInformation = "";
            this.BtnOverVel.EnableColor = System.Drawing.Color.Orange;
            this.BtnOverVel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnOverVel.Location = new System.Drawing.Point(1060, 87);
            this.BtnOverVel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOverVel.Name = "BtnOverVel";
            this.BtnOverVel.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnOverVel.Size = new System.Drawing.Size(134, 46);
            this.BtnOverVel.TabIndex = 0;
            this.BtnOverVel.Tag = "M33";
            this.BtnOverVel.TextColor = System.Drawing.Color.White;
            this.BtnOverVel.UIText = "溢流阀";
            this.BtnOverVel.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnGasVel1
            // 
            this.BtnGasVel1.ActiveColor = System.Drawing.Color.Orange;
            this.BtnGasVel1.BackColor = System.Drawing.Color.Transparent;
            this.BtnGasVel1.CustomerInformation = "";
            this.BtnGasVel1.EnableColor = System.Drawing.Color.Orange;
            this.BtnGasVel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnGasVel1.Location = new System.Drawing.Point(488, 87);
            this.BtnGasVel1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGasVel1.Name = "BtnGasVel1";
            this.BtnGasVel1.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnGasVel1.Size = new System.Drawing.Size(134, 46);
            this.BtnGasVel1.TabIndex = 0;
            this.BtnGasVel1.Tag = "M20";
            this.BtnGasVel1.TextColor = System.Drawing.Color.White;
            this.BtnGasVel1.UIText = "气阀1";
            this.BtnGasVel1.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnWash2
            // 
            this.BtnWash2.ActiveColor = System.Drawing.Color.Orange;
            this.BtnWash2.BackColor = System.Drawing.Color.Transparent;
            this.BtnWash2.CustomerInformation = "";
            this.BtnWash2.EnableColor = System.Drawing.Color.Orange;
            this.BtnWash2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnWash2.Location = new System.Drawing.Point(749, 179);
            this.BtnWash2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWash2.Name = "BtnWash2";
            this.BtnWash2.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnWash2.Size = new System.Drawing.Size(134, 46);
            this.BtnWash2.TabIndex = 0;
            this.BtnWash2.Tag = "M27";
            this.BtnWash2.TextColor = System.Drawing.Color.White;
            this.BtnWash2.UIText = "冲洗阀2";
            this.BtnWash2.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // BtnWash1
            // 
            this.BtnWash1.ActiveColor = System.Drawing.Color.Orange;
            this.BtnWash1.BackColor = System.Drawing.Color.Transparent;
            this.BtnWash1.CustomerInformation = "";
            this.BtnWash1.EnableColor = System.Drawing.Color.Orange;
            this.BtnWash1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BtnWash1.Location = new System.Drawing.Point(749, 87);
            this.BtnWash1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWash1.Name = "BtnWash1";
            this.BtnWash1.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.BtnWash1.Size = new System.Drawing.Size(134, 46);
            this.BtnWash1.TabIndex = 0;
            this.BtnWash1.Tag = "M26";
            this.BtnWash1.TextColor = System.Drawing.Color.White;
            this.BtnWash1.UIText = "冲洗阀1";
            this.BtnWash1.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 14);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1342, 661);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1336, 655);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Controls.Add(this.ucPagerControl21);
            this.tabPage4.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1328, 621);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "参数设置";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.splitContainer1.Panel1.Controls.Add(this.label40);
            this.splitContainer1.Panel1.Controls.Add(this.txtSystemMaxPres);
            this.splitContainer1.Panel1.Controls.Add(this.EnbleLowFrequency);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveParam);
            this.splitContainer1.Panel1.Controls.Add(this.BtnClearParam);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtInterval);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkPos);
            this.splitContainer1.Panel1.Controls.Add(this.txtLowFreq);
            this.splitContainer1.Panel1.Controls.Add(this.txtPresMax);
            this.splitContainer1.Panel1.Controls.Add(this.txtSetWaterPres);
            this.splitContainer1.Panel1.Controls.Add(this.label29);
            this.splitContainer1.Panel1.Controls.Add(this.label38);
            this.splitContainer1.Panel1.Controls.Add(this.label24);
            this.splitContainer1.Panel1.Controls.Add(this.label36);
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.label27);
            this.splitContainer1.Panel1.Controls.Add(this.label25);
            this.splitContainer1.Panel1.Controls.Add(this.txtAutoStartTime);
            this.splitContainer1.Panel1.Controls.Add(this.NegMaxLimit);
            this.splitContainer1.Panel1.Controls.Add(this.txtPosLimit);
            this.splitContainer1.Panel1.Controls.Add(this.label44);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdleSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.label43);
            this.splitContainer1.Panel1.Controls.Add(this.txtAerify);
            this.splitContainer1.Panel1.Controls.Add(this.label42);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdlePos);
            this.splitContainer1.Panel1.Controls.Add(this.label37);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label35);
            this.splitContainer1.Panel1.Controls.Add(this.txtPresMin);
            this.splitContainer1.Panel1.Controls.Add(this.label26);
            this.splitContainer1.Panel1.Controls.Add(this.txtWaterCompensate);
            this.splitContainer1.Panel1.Controls.Add(this.label28);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(1322, 615);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(-3, 142);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(231, 20);
            this.label40.TabIndex = 24;
            this.label40.Text = "系统最大压力（KPa）：";
            // 
            // txtSystemMaxPres
            // 
            this.txtSystemMaxPres.Location = new System.Drawing.Point(16, 168);
            this.txtSystemMaxPres.Name = "txtSystemMaxPres";
            this.txtSystemMaxPres.Size = new System.Drawing.Size(124, 35);
            this.txtSystemMaxPres.TabIndex = 23;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtSystemMaxPres, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtSystemMaxPres, "");
            this.verificationComponent1.SetVerificationModel(this.txtSystemMaxPres, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtSystemMaxPres, false);
            // 
            // EnbleLowFrequency
            // 
            this.EnbleLowFrequency.AutoSize = true;
            this.EnbleLowFrequency.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnbleLowFrequency.Location = new System.Drawing.Point(975, 141);
            this.EnbleLowFrequency.Name = "EnbleLowFrequency";
            this.EnbleLowFrequency.Size = new System.Drawing.Size(241, 24);
            this.EnbleLowFrequency.TabIndex = 22;
            this.EnbleLowFrequency.Text = "自动待机低频运转禁止";
            this.EnbleLowFrequency.UseVisualStyleBackColor = true;
            // 
            // btnSaveParam
            // 
            this.btnSaveParam.ActiveColor = System.Drawing.Color.DarkOrange;
            this.btnSaveParam.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveParam.CustomerInformation = "";
            this.btnSaveParam.EnableColor = System.Drawing.Color.DarkGray;
            this.btnSaveParam.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaveParam.Location = new System.Drawing.Point(1180, 127);
            this.btnSaveParam.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveParam.Name = "btnSaveParam";
            this.btnSaveParam.OriginalColor = System.Drawing.Color.DarkGray;
            this.btnSaveParam.Size = new System.Drawing.Size(146, 39);
            this.btnSaveParam.TabIndex = 21;
            this.btnSaveParam.Tag = "H207";
            this.btnSaveParam.TextColor = System.Drawing.Color.White;
            this.btnSaveParam.UIText = "保存参数";
            this.btnSaveParam.Click += new System.EventHandler(this.btnSaveParam_Click);
            // 
            // BtnClearParam
            // 
            this.BtnClearParam.ActiveColor = System.Drawing.Color.DarkOrange;
            this.BtnClearParam.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearParam.CustomerInformation = "";
            this.BtnClearParam.EnableColor = System.Drawing.Color.DarkGray;
            this.BtnClearParam.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.BtnClearParam.Location = new System.Drawing.Point(1179, 47);
            this.BtnClearParam.Margin = new System.Windows.Forms.Padding(5);
            this.BtnClearParam.Name = "BtnClearParam";
            this.BtnClearParam.OriginalColor = System.Drawing.Color.DarkGray;
            this.BtnClearParam.Size = new System.Drawing.Size(146, 39);
            this.BtnClearParam.TabIndex = 21;
            this.BtnClearParam.Tag = "H207";
            this.BtnClearParam.TextColor = System.Drawing.Color.White;
            this.BtnClearParam.UIText = "清除参数";
            this.BtnClearParam.Click += new System.EventHandler(this.BtnClearParam_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1022, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 35);
            this.textBox1.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.textBox1, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.textBox1, "");
            this.verificationComponent1.SetVerificationModel(this.textBox1, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.textBox1, false);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(626, 168);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(124, 35);
            this.txtInterval.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtInterval, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtInterval, "");
            this.verificationComponent1.SetVerificationModel(this.txtInterval, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtInterval, false);
            // 
            // txtWorkSpeed
            // 
            this.txtWorkSpeed.Location = new System.Drawing.Point(626, 99);
            this.txtWorkSpeed.Name = "txtWorkSpeed";
            this.txtWorkSpeed.Size = new System.Drawing.Size(124, 35);
            this.txtWorkSpeed.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtWorkSpeed, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtWorkSpeed, "");
            this.verificationComponent1.SetVerificationModel(this.txtWorkSpeed, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtWorkSpeed, false);
            // 
            // txtWorkPos
            // 
            this.txtWorkPos.Location = new System.Drawing.Point(426, 168);
            this.txtWorkPos.Name = "txtWorkPos";
            this.txtWorkPos.Size = new System.Drawing.Size(124, 35);
            this.txtWorkPos.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtWorkPos, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtWorkPos, "");
            this.verificationComponent1.SetVerificationModel(this.txtWorkPos, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtWorkPos, false);
            // 
            // txtLowFreq
            // 
            this.txtLowFreq.Location = new System.Drawing.Point(226, 166);
            this.txtLowFreq.Name = "txtLowFreq";
            this.txtLowFreq.Size = new System.Drawing.Size(124, 35);
            this.txtLowFreq.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtLowFreq, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtLowFreq, "");
            this.verificationComponent1.SetVerificationModel(this.txtLowFreq, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtLowFreq, false);
            // 
            // txtPresMax
            // 
            this.txtPresMax.Location = new System.Drawing.Point(226, 31);
            this.txtPresMax.Name = "txtPresMax";
            this.txtPresMax.Size = new System.Drawing.Size(124, 35);
            this.txtPresMax.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtPresMax, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtPresMax, "");
            this.verificationComponent1.SetVerificationModel(this.txtPresMax, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtPresMax, false);
            // 
            // txtSetWaterPres
            // 
            this.txtSetWaterPres.Location = new System.Drawing.Point(16, 31);
            this.txtSetWaterPres.Name = "txtSetWaterPres";
            this.txtSetWaterPres.Size = new System.Drawing.Size(124, 35);
            this.txtSetWaterPres.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtSetWaterPres, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtSetWaterPres, "");
            this.verificationComponent1.SetVerificationModel(this.txtSetWaterPres, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtSetWaterPres, false);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(626, 148);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(198, 20);
            this.label29.TabIndex = 3;
            this.label29.Text = "生产参数上传间隔：";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(627, 77);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(170, 20);
            this.label38.TabIndex = 3;
            this.label38.Text = "工作速度(mm/s):";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(1018, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 24);
            this.label24.TabIndex = 2;
            this.label24.Text = "产品类型：";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(427, 146);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(169, 20);
            this.label36.TabIndex = 3;
            this.label36.Text = "电机工作位(mm):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(227, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "低频频率（Hz):";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(203, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(231, 20);
            this.label27.TabIndex = 3;
            this.label27.Text = "高压水泵上限（KPa）：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(16, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(189, 20);
            this.label25.TabIndex = 3;
            this.label25.Text = "水压设定（KPa）：";
            // 
            // txtAutoStartTime
            // 
            this.txtAutoStartTime.Location = new System.Drawing.Point(806, 163);
            this.txtAutoStartTime.Name = "txtAutoStartTime";
            this.txtAutoStartTime.Size = new System.Drawing.Size(124, 35);
            this.txtAutoStartTime.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtAutoStartTime, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtAutoStartTime, "");
            this.verificationComponent1.SetVerificationModel(this.txtAutoStartTime, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtAutoStartTime, false);
            // 
            // NegMaxLimit
            // 
            this.NegMaxLimit.Location = new System.Drawing.Point(801, 101);
            this.NegMaxLimit.Name = "NegMaxLimit";
            this.NegMaxLimit.Size = new System.Drawing.Size(124, 35);
            this.NegMaxLimit.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.NegMaxLimit, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.NegMaxLimit, "");
            this.verificationComponent1.SetVerificationModel(this.NegMaxLimit, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.NegMaxLimit, false);
            // 
            // txtPosLimit
            // 
            this.txtPosLimit.Location = new System.Drawing.Point(801, 32);
            this.txtPosLimit.Name = "txtPosLimit";
            this.txtPosLimit.Size = new System.Drawing.Size(124, 35);
            this.txtPosLimit.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtPosLimit, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtPosLimit, "");
            this.verificationComponent1.SetVerificationModel(this.txtPosLimit, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtPosLimit, false);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(803, 144);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(168, 20);
            this.label44.TabIndex = 3;
            this.label44.Text = "自启动时间(s)：";
            // 
            // txtIdleSpeed
            // 
            this.txtIdleSpeed.Location = new System.Drawing.Point(626, 32);
            this.txtIdleSpeed.Name = "txtIdleSpeed";
            this.txtIdleSpeed.Size = new System.Drawing.Size(124, 35);
            this.txtIdleSpeed.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtIdleSpeed, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtIdleSpeed, "");
            this.verificationComponent1.SetVerificationModel(this.txtIdleSpeed, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtIdleSpeed, false);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(798, 83);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(179, 20);
            this.label43.TabIndex = 3;
            this.label43.Text = "负向软限位(mm)：";
            // 
            // txtAerify
            // 
            this.txtAerify.Location = new System.Drawing.Point(426, 31);
            this.txtAerify.Name = "txtAerify";
            this.txtAerify.Size = new System.Drawing.Size(124, 35);
            this.txtAerify.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtAerify, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtAerify, "");
            this.verificationComponent1.SetVerificationModel(this.txtAerify, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtAerify, false);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(798, 14);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(179, 20);
            this.label42.TabIndex = 3;
            this.label42.Text = "正向软限位(mm)：";
            // 
            // txtIdlePos
            // 
            this.txtIdlePos.Location = new System.Drawing.Point(426, 101);
            this.txtIdlePos.Name = "txtIdlePos";
            this.txtIdlePos.Size = new System.Drawing.Size(124, 35);
            this.txtIdlePos.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtIdlePos, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtIdlePos, "");
            this.verificationComponent1.SetVerificationModel(this.txtIdlePos, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtIdlePos, false);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(628, 14);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(180, 20);
            this.label37.TabIndex = 3;
            this.label37.Text = "待机速度(mm/s)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(403, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "供水压力下限（KPa):";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(428, 83);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(169, 20);
            this.label35.TabIndex = 3;
            this.label35.Text = "电机待机位(mm):";
            // 
            // txtPresMin
            // 
            this.txtPresMin.Location = new System.Drawing.Point(226, 99);
            this.txtPresMin.Name = "txtPresMin";
            this.txtPresMin.Size = new System.Drawing.Size(124, 35);
            this.txtPresMin.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtPresMin, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtPresMin, "");
            this.verificationComponent1.SetVerificationModel(this.txtPresMin, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtPresMin, false);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(204, 81);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(231, 20);
            this.label26.TabIndex = 3;
            this.label26.Text = "高压水泵下限（KPa）：";
            // 
            // txtWaterCompensate
            // 
            this.txtWaterCompensate.Location = new System.Drawing.Point(16, 99);
            this.txtWaterCompensate.Name = "txtWaterCompensate";
            this.txtWaterCompensate.Size = new System.Drawing.Size(124, 35);
            this.txtWaterCompensate.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtWaterCompensate, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtWaterCompensate, "");
            this.verificationComponent1.SetVerificationModel(this.txtWaterCompensate, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtWaterCompensate, false);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(16, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(189, 20);
            this.label28.TabIndex = 3;
            this.label28.Text = "水压补偿（KPa）：";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridParam);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.splitContainer2.Panel2.Controls.Add(this.BtnNext);
            this.splitContainer2.Panel2.Controls.Add(this.BtnPrevious);
            this.splitContainer2.Panel2.Controls.Add(this.label23);
            this.splitContainer2.Panel2.Controls.Add(this.txtWashSetTime);
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer2.Size = new System.Drawing.Size(1319, 422);
            this.splitContainer2.SplitterDistance = 367;
            this.splitContainer2.TabIndex = 2;
            // 
            // dataGridParam
            // 
            this.dataGridParam.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridParam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Step,
            this.Water1,
            this.Water2,
            this.Warter3,
            this.Water4,
            this.Water5,
            this.Water6,
            this.Gas1,
            this.Gas2,
            this.Gas3,
            this.Gas4,
            this.Gas5,
            this.Gas6,
            this.Time});
            this.dataGridParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridParam.EnableHeadersVisualStyles = false;
            this.dataGridParam.Location = new System.Drawing.Point(0, 0);
            this.dataGridParam.Name = "dataGridParam";
            this.dataGridParam.RowHeadersVisible = false;
            this.dataGridParam.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dataGridParam.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridParam.RowTemplate.Height = 35;
            this.dataGridParam.Size = new System.Drawing.Size(1319, 367);
            this.dataGridParam.TabIndex = 0;
            // 
            // Step
            // 
            this.Step.DataPropertyName = "EquipmentWashNum";
            this.Step.HeaderText = "步骤";
            this.Step.MinimumWidth = 6;
            this.Step.Name = "Step";
            this.Step.Width = 125;
            // 
            // Water1
            // 
            this.Water1.DataPropertyName = "IsWaterValveOpen1";
            this.Water1.FalseValue = "否";
            this.Water1.HeaderText = "水1";
            this.Water1.MinimumWidth = 6;
            this.Water1.Name = "Water1";
            this.Water1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Water1.TrueValue = "是";
            this.Water1.Width = 90;
            // 
            // Water2
            // 
            this.Water2.DataPropertyName = "IsWaterValveOpen2";
            this.Water2.FalseValue = "否";
            this.Water2.HeaderText = "水2";
            this.Water2.MinimumWidth = 6;
            this.Water2.Name = "Water2";
            this.Water2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Water2.TrueValue = "是";
            this.Water2.Width = 90;
            // 
            // Warter3
            // 
            this.Warter3.DataPropertyName = "IsWaterValveOpen3";
            this.Warter3.FalseValue = "否";
            this.Warter3.HeaderText = "水3";
            this.Warter3.MinimumWidth = 6;
            this.Warter3.Name = "Warter3";
            this.Warter3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Warter3.TrueValue = "是";
            this.Warter3.Width = 90;
            // 
            // Water4
            // 
            this.Water4.DataPropertyName = "IsWaterValveOpen4";
            this.Water4.FalseValue = "否";
            this.Water4.HeaderText = "水4";
            this.Water4.MinimumWidth = 6;
            this.Water4.Name = "Water4";
            this.Water4.TrueValue = "是";
            this.Water4.Width = 90;
            // 
            // Water5
            // 
            this.Water5.DataPropertyName = "IsWaterValveOpen5";
            this.Water5.FalseValue = "否";
            this.Water5.HeaderText = "水5";
            this.Water5.MinimumWidth = 6;
            this.Water5.Name = "Water5";
            this.Water5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Water5.TrueValue = "是";
            this.Water5.Width = 90;
            // 
            // Water6
            // 
            this.Water6.DataPropertyName = "IsWaterValveOpen6";
            this.Water6.FalseValue = "否";
            this.Water6.HeaderText = "水6";
            this.Water6.MinimumWidth = 6;
            this.Water6.Name = "Water6";
            this.Water6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Water6.TrueValue = "是";
            this.Water6.Width = 90;
            // 
            // Gas1
            // 
            this.Gas1.DataPropertyName = "IsGasValveOpen1";
            this.Gas1.FalseValue = "否";
            this.Gas1.HeaderText = "气1";
            this.Gas1.MinimumWidth = 6;
            this.Gas1.Name = "Gas1";
            this.Gas1.TrueValue = "是";
            this.Gas1.Width = 90;
            // 
            // Gas2
            // 
            this.Gas2.DataPropertyName = "IsGasValveOpen2";
            this.Gas2.FalseValue = "否";
            this.Gas2.HeaderText = "气2";
            this.Gas2.MinimumWidth = 6;
            this.Gas2.Name = "Gas2";
            this.Gas2.TrueValue = "是";
            this.Gas2.Width = 90;
            // 
            // Gas3
            // 
            this.Gas3.DataPropertyName = "IsGasValveOpen3";
            this.Gas3.FalseValue = "否";
            this.Gas3.HeaderText = "气3";
            this.Gas3.MinimumWidth = 6;
            this.Gas3.Name = "Gas3";
            this.Gas3.TrueValue = "是";
            this.Gas3.Width = 90;
            // 
            // Gas4
            // 
            this.Gas4.DataPropertyName = "IsGasValveOpen4";
            this.Gas4.FalseValue = "否";
            this.Gas4.HeaderText = "气4";
            this.Gas4.MinimumWidth = 6;
            this.Gas4.Name = "Gas4";
            this.Gas4.TrueValue = "是";
            this.Gas4.Width = 90;
            // 
            // Gas5
            // 
            this.Gas5.DataPropertyName = "IsGasValveOpen5";
            this.Gas5.FalseValue = "否";
            this.Gas5.HeaderText = "气5";
            this.Gas5.MinimumWidth = 6;
            this.Gas5.Name = "Gas5";
            this.Gas5.TrueValue = "是";
            this.Gas5.Width = 90;
            // 
            // Gas6
            // 
            this.Gas6.DataPropertyName = "IsGasValveOpen6";
            this.Gas6.FalseValue = "否";
            this.Gas6.HeaderText = "气6";
            this.Gas6.MinimumWidth = 6;
            this.Gas6.Name = "Gas6";
            this.Gas6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gas6.TrueValue = "是";
            this.Gas6.Width = 90;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "时间";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BtnNext
            // 
            this.BtnNext.ActiveColor = System.Drawing.Color.DarkOrange;
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.CustomerInformation = "";
            this.BtnNext.EnableColor = System.Drawing.Color.DarkGray;
            this.BtnNext.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.BtnNext.Location = new System.Drawing.Point(1190, 3);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(5);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.OriginalColor = System.Drawing.Color.DarkGray;
            this.BtnNext.Size = new System.Drawing.Size(123, 39);
            this.BtnNext.TabIndex = 21;
            this.BtnNext.Tag = "H207";
            this.BtnNext.TextColor = System.Drawing.Color.White;
            this.BtnNext.UIText = "下一页";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.ActiveColor = System.Drawing.Color.DarkOrange;
            this.BtnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrevious.CustomerInformation = "";
            this.BtnPrevious.EnableColor = System.Drawing.Color.DarkGray;
            this.BtnPrevious.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.BtnPrevious.Location = new System.Drawing.Point(973, 4);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.OriginalColor = System.Drawing.Color.DarkGray;
            this.BtnPrevious.Size = new System.Drawing.Size(123, 39);
            this.BtnPrevious.TabIndex = 21;
            this.BtnPrevious.Tag = "H207";
            this.BtnPrevious.TextColor = System.Drawing.Color.White;
            this.BtnPrevious.UIText = "上一页";
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(6, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "冲洗设定总时间(S):";
            // 
            // txtWashSetTime
            // 
            this.txtWashSetTime.Location = new System.Drawing.Point(205, 7);
            this.txtWashSetTime.Name = "txtWashSetTime";
            this.txtWashSetTime.Size = new System.Drawing.Size(124, 35);
            this.txtWashSetTime.TabIndex = 4;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtWashSetTime, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtWashSetTime, "");
            this.verificationComponent1.SetVerificationModel(this.txtWashSetTime, HZH_Controls.Controls.VerificationModel.None);
            this.verificationComponent1.SetVerificationRequired(this.txtWashSetTime, false);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 422);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // ucPagerControl21
            // 
            this.ucPagerControl21.BackColor = System.Drawing.Color.White;
            this.ucPagerControl21.DataSource = ((System.Collections.Generic.List<object>)(resources.GetObject("ucPagerControl21.DataSource")));
            this.ucPagerControl21.Location = new System.Drawing.Point(33, 637);
            this.ucPagerControl21.Name = "ucPagerControl21";
            this.ucPagerControl21.PageCount = 0;
            this.ucPagerControl21.PageIndex = 1;
            this.ucPagerControl21.PageModel = HZH_Controls.Controls.PageModel.Soure;
            this.ucPagerControl21.PageSize = 10;
            this.ucPagerControl21.Size = new System.Drawing.Size(921, 41);
            this.ucPagerControl21.StartIndex = 0;
            this.ucPagerControl21.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 661);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.splitContainer3.Panel1.Controls.Add(this.userButton2);
            this.splitContainer3.Panel1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.splitContainer3.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer3.Size = new System.Drawing.Size(1336, 655);
            this.splitContainer3.SplitterDistance = 73;
            this.splitContainer3.TabIndex = 0;
            // 
            // userButton2
            // 
            this.userButton2.BackColor = System.Drawing.Color.Transparent;
            this.userButton2.CustomerInformation = "";
            this.userButton2.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.userButton2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.userButton2.Location = new System.Drawing.Point(1162, 17);
            this.userButton2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.userButton2.Name = "userButton2";
            this.userButton2.OriginalColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.userButton2.Size = new System.Drawing.Size(135, 44);
            this.userButton2.TabIndex = 0;
            this.userButton2.Tag = "M520";
            this.userButton2.TextColor = System.Drawing.Color.White;
            this.userButton2.UIText = "报警复位";
            this.userButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseDown);
            this.userButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userButton1_MouseUp);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1336, 578);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DGCurrentAlarm);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1328, 544);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "实时报警";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DGCurrentAlarm
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCurrentAlarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGCurrentAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCurrentAlarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BeginTime,
            this.TriggerValue,
            this.Description});
            this.DGCurrentAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGCurrentAlarm.Location = new System.Drawing.Point(3, 3);
            this.DGCurrentAlarm.Name = "DGCurrentAlarm";
            this.DGCurrentAlarm.RowHeadersVisible = false;
            this.DGCurrentAlarm.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.DGCurrentAlarm.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGCurrentAlarm.RowTemplate.Height = 23;
            this.DGCurrentAlarm.Size = new System.Drawing.Size(1322, 538);
            this.DGCurrentAlarm.TabIndex = 0;
            // 
            // BeginTime
            // 
            this.BeginTime.DataPropertyName = "BeginTime";
            this.BeginTime.HeaderText = "开始时间";
            this.BeginTime.MinimumWidth = 6;
            this.BeginTime.Name = "BeginTime";
            this.BeginTime.Width = 200;
            // 
            // TriggerValue
            // 
            this.TriggerValue.DataPropertyName = "TriggerValue";
            this.TriggerValue.HeaderText = "触发值";
            this.TriggerValue.MinimumWidth = 6;
            this.TriggerValue.Name = "TriggerValue";
            this.TriggerValue.Width = 200;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "报警内容";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DGHistoryAlarm);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1328, 543);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "历史报警";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DGHistoryAlarm
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHistoryAlarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGHistoryAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGHistoryAlarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.EndTime,
            this.dataGridViewTextBoxColumn3});
            this.DGHistoryAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGHistoryAlarm.Location = new System.Drawing.Point(3, 3);
            this.DGHistoryAlarm.Name = "DGHistoryAlarm";
            this.DGHistoryAlarm.RowHeadersVisible = false;
            this.DGHistoryAlarm.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.DGHistoryAlarm.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DGHistoryAlarm.RowTemplate.Height = 23;
            this.DGHistoryAlarm.Size = new System.Drawing.Size(1322, 537);
            this.DGHistoryAlarm.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BeginTime";
            this.dataGridViewTextBoxColumn1.HeaderText = "开始时间";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TriggerValue";
            this.dataGridViewTextBoxColumn2.HeaderText = "触发值";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "结束时间";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "报警内容";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // verificationComponent1
            // 
            this.verificationComponent1.AutoCloseErrorTipsTime = 3000;
            this.verificationComponent1.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verificationComponent1.ErrorTipsForeColor = System.Drawing.Color.White;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemHome,
            this.手动界面ToolStripMenuItem,
            this.参数设置ToolStripMenuItem,
            this.报警界面ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 32);
            this.menuStrip1.TabIndex = 84;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuitemHome
            // 
            this.menuitemHome.Name = "menuitemHome";
            this.menuitemHome.Size = new System.Drawing.Size(58, 28);
            this.menuitemHome.Text = "主页";
            this.menuitemHome.Click += new System.EventHandler(this.menuitemHome_Click);
            // 
            // 手动界面ToolStripMenuItem
            // 
            this.手动界面ToolStripMenuItem.Name = "手动界面ToolStripMenuItem";
            this.手动界面ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.手动界面ToolStripMenuItem.Text = "手动界面";
            this.手动界面ToolStripMenuItem.Click += new System.EventHandler(this.menuitemHome_Click);
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            this.参数设置ToolStripMenuItem.Click += new System.EventHandler(this.menuitemHome_Click);
            // 
            // 报警界面ToolStripMenuItem
            // 
            this.报警界面ToolStripMenuItem.Name = "报警界面ToolStripMenuItem";
            this.报警界面ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.报警界面ToolStripMenuItem.Text = "报警界面";
            this.报警界面ToolStripMenuItem.Click += new System.EventHandler(this.menuitemHome_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUser,
            this.toolStripStatusLabel7,
            this.toolPLCConnect,
            this.toolStripStatusLabel2,
            this.toolServiceStatus,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 23);
            this.statusStrip1.TabIndex = 87;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolUser
            // 
            this.toolUser.BackColor = System.Drawing.Color.Transparent;
            this.toolUser.ForeColor = System.Drawing.Color.Black;
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(98, 18);
            this.toolUser.Text = "当前用户：";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(218, 18);
            this.toolStripStatusLabel7.Spring = true;
            // 
            // toolPLCConnect
            // 
            this.toolPLCConnect.BackColor = System.Drawing.Color.Transparent;
            this.toolPLCConnect.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolPLCConnect.ForeColor = System.Drawing.Color.Black;
            this.toolPLCConnect.Name = "toolPLCConnect";
            this.toolPLCConnect.Size = new System.Drawing.Size(134, 18);
            this.toolPLCConnect.Text = "  PLC连接状态:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(218, 18);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolServiceStatus
            // 
            this.toolServiceStatus.BackColor = System.Drawing.Color.Transparent;
            this.toolServiceStatus.ForeColor = System.Drawing.Color.Black;
            this.toolServiceStatus.Name = "toolServiceStatus";
            this.toolServiceStatus.Size = new System.Drawing.Size(152, 18);
            this.toolServiceStatus.Text = "服务器连接状态：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(218, 18);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(296, 18);
            this.toolStripStatusLabel5.Text = "版权：柳州胜鼎工业自动化有限公司";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 674);
            this.panel1.TabIndex = 88;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(59)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.Text = "高压冲洗";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.btnManualWrite.ResumeLayout(false);
            this.btnManualWrite.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParam)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGCurrentAlarm)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGHistoryAlarm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private HZH_Controls.Controls.VerificationComponent verificationComponent1;
        private System.Windows.Forms.TabPage btnManualWrite;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 手动界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报警界面ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolPLCConnect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolServiceStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtPos;
        private HslCommunication.Controls.UserButton BtnToWorkPos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtWashPress;
        private System.Windows.Forms.TextBox txtPosition2;
        private System.Windows.Forms.TextBox txtPosition1;
        private HslCommunication.Controls.UserButton BtnGasVel6;
        private HslCommunication.Controls.UserButton BtnGasVel5;
        private HslCommunication.Controls.UserButton BtnWash6;
        private HslCommunication.Controls.UserButton BtnGasVel4;
        private HslCommunication.Controls.UserButton BtnWash5;
        private HslCommunication.Controls.UserButton BtnGasVel3;
        private HslCommunication.Controls.UserButton userButton21;
        private HslCommunication.Controls.UserButton userButton20;
        private HslCommunication.Controls.UserButton userButton19;
        private HslCommunication.Controls.UserButton userButton18;
        private HslCommunication.Controls.UserButton BtnWash4;
        private HslCommunication.Controls.UserButton BtnHighPres;
        private HslCommunication.Controls.UserButton BtnGasVel2;
        private HslCommunication.Controls.UserButton BtnWash3;
        private HslCommunication.Controls.UserButton BtnOverVel;
        private HslCommunication.Controls.UserButton BtnGasVel1;
        private HslCommunication.Controls.UserButton BtnWash2;
        private HslCommunication.Controls.UserButton BtnWash1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem menuitemHome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private HslCommunication.Controls.UserButton btnSaveParam;
        private HslCommunication.Controls.UserButton BtnClearParam;
        private System.Windows.Forms.TextBox txtPresMax;
        private System.Windows.Forms.TextBox txtSetWaterPres;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPresMin;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtWaterCompensate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridParam;
        private HslCommunication.Controls.UserButton BtnNext;
        private HslCommunication.Controls.UserButton BtnPrevious;
        private System.Windows.Forms.Splitter splitter1;
        private HZH_Controls.Controls.UCPagerControl2 ucPagerControl21;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ToolStripStatusLabel toolUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Water1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Water2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Warter3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Water4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Water5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Water6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gas1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gas2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gas3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gas4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gas5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gas6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.TextBox txtLowFreq;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAerify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWashSetTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtSetFreq;
        private System.Windows.Forms.TextBox txtSetPres;
        private System.Windows.Forms.GroupBox groupBox5;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton8;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton7;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton6;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton5;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton4;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton3;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton2;
        private HZH_Controls.Controls.UCRadioButton CBmotorMove;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtMotorMove;
        private HslCommunication.Controls.UserButton userButton2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView DGCurrentAlarm;
        private System.Windows.Forms.DataGridView DGHistoryAlarm;
        private System.Windows.Forms.CheckBox EnbleLowFrequency;
        private System.Windows.Forms.TextBox txtWorkSpeed;
        private System.Windows.Forms.TextBox txtWorkPos;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtIdleSpeed;
        private System.Windows.Forms.TextBox txtIdlePos;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabPage tabPage1;
        private HZH_Controls.Controls.UCConduit ucConduit21;
        private HZH_Controls.Controls.UCConduit ucConduit20;
        private HZH_Controls.Controls.UCConduit ucConduit19;
        private HZH_Controls.Controls.UCConduit ucConduit17;
        private HZH_Controls.Controls.UCConduit ucConduit16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtAlreadyTime;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtSetTime;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtHomePos2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtHomePos1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private HslCommunication.Controls.UserButton btnEstop;
        private HslCommunication.Controls.UserButton btnChangeMode;
        private HslCommunication.Controls.UserButton userButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private HslCommunication.Controls.UserButton btnStop;
        private HslCommunication.Controls.UserButton btnDown;
        private HslCommunication.Controls.UserButton btnBegin;
        private HZH_Controls.Controls.UCAlarmLamp ucAlarmLamp1;
        private HZH_Controls.Controls.UCConduit ucConduit13;
        private HZH_Controls.Controls.UCConduit ucConduit12;
        private HZH_Controls.Controls.UCConduit ucConduit10;
        private HZH_Controls.Controls.UCConduit ucConduit8;
        private HZH_Controls.Controls.UCConduit ucConduit14;
        private HZH_Controls.Controls.UCConduit ucConduit6;
        private HZH_Controls.Controls.UCConduit ucConduit4;
        private HZH_Controls.Controls.UCValve WaterVaVel6;
        private HZH_Controls.Controls.UCValve WaterVaVel5;
        private HZH_Controls.Controls.UCValve WaterVaVel4;
        private HZH_Controls.Controls.UCValve WaterVaVel2;
        private System.Windows.Forms.Label label39;
        private HZH_Controls.Controls.UCValve WaterVaVel1;
        private System.Windows.Forms.Label label16;
        private HZH_Controls.Controls.UCBottle ucBottle2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbEquipmentStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private HZH_Controls.Controls.UCConduit ucConduit11;
        private HZH_Controls.Controls.UCValve AirVavel6;
        private HZH_Controls.Controls.UCBlower ucBlower1;
        private HZH_Controls.Controls.UCValve AirVavel5;
        private HZH_Controls.Controls.UCBottle ucBottle1;
        private HZH_Controls.Controls.UCValve AirVavel4;
        private HZH_Controls.Controls.UCValve ucValve1;
        private HZH_Controls.Controls.UCValve AirVavel3;
        private HZH_Controls.Controls.UCValve AirVavel2;
        private HZH_Controls.Controls.UCValve AirVavel1;
        private HZH_Controls.Controls.UCConduit ucConduit7;
        private HZH_Controls.Controls.UCConduit ucConduit2;
        private HZH_Controls.Controls.UCConduit ucConduit9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private HZH_Controls.Controls.UCConduit ucConduit18;
        private System.Windows.Forms.Label label6;
        private HZH_Controls.Controls.UCConduit ucConduit5;
        private System.Windows.Forms.Label label5;
        private HZH_Controls.Controls.UCConduit ucConduit3;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCConduit ucConduit1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbIsReady;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHomeWashPress;
        private System.Windows.Forms.TextBox txtWashNum;
        private HZH_Controls.Controls.UCConduit ucConduit15;
        private HslCommunication.Controls.UserButton userButton3;
        private HslCommunication.Controls.UserButton BtnToStandy;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtSystemMaxPres;
        private HZH_Controls.Controls.UCValve WaterVaVel3;
        private System.Windows.Forms.CheckBox EnbleLowFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriggerValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtAutoStartTime;
        private System.Windows.Forms.TextBox NegMaxLimit;
        private System.Windows.Forms.TextBox txtPosLimit;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
    }
}

