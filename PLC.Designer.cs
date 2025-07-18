
namespace PLC_Emulator
{
    partial class PLC
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbComm = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btAlarm = new System.Windows.Forms.Button();
            this.txAlarmCode = new System.Windows.Forms.TextBox();
            this.btUserStop = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckRWB_ID = new System.Windows.Forms.CheckBox();
            this.txRWB_Carrier = new System.Windows.Forms.TextBox();
            this.lbRWB_CarrierLot = new System.Windows.Forms.Label();
            this.chkRW_Active = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckRWA_ID = new System.Windows.Forms.CheckBox();
            this.txRWA_Carrier = new System.Windows.Forms.TextBox();
            this.lbRWA_CarrierLot = new System.Windows.Forms.Label();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.ckUWB_JOB = new System.Windows.Forms.CheckBox();
            this.ckUWB_ID = new System.Windows.Forms.CheckBox();
            this.txUWB_Carrier = new System.Windows.Forms.TextBox();
            this.lbUWB_CarrierLot = new System.Windows.Forms.Label();
            this.chkUW_Active = new System.Windows.Forms.CheckBox();
            this.chkInputLot = new System.Windows.Forms.CheckBox();
            this.chkCut = new System.Windows.Forms.CheckBox();
            this.chkSample = new System.Windows.Forms.CheckBox();
            this.ckLotRunning = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckUWA_JOB = new System.Windows.Forms.CheckBox();
            this.ckUWA_ID = new System.Windows.Forms.CheckBox();
            this.txUWA_Carrier = new System.Windows.Forms.TextBox();
            this.lbUWA_CarrierLot = new System.Windows.Forms.Label();
            this.btnLotEnd = new System.Windows.Forms.Button();
            this.btbLotStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbWorkLenth = new System.Windows.Forms.Label();
            this.lbCurrentLot = new System.Windows.Forms.Label();
            this.lbEqpStat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btUWA_Out = new System.Windows.Forms.Button();
            this.btUWB_Out = new System.Windows.Forms.Button();
            this.btRWB_Out = new System.Windows.Forms.Button();
            this.btRWA_Out = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.group2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbComm
            // 
            this.lbComm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbComm.Location = new System.Drawing.Point(0, 0);
            this.lbComm.Name = "lbComm";
            this.lbComm.Size = new System.Drawing.Size(139, 75);
            this.lbComm.TabIndex = 0;
            this.lbComm.Text = "label1";
            this.lbComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 469);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.Location = new System.Drawing.Point(657, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 51);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "PLC SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(214, 78);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(84, 34);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btAlarm
            // 
            this.btAlarm.Location = new System.Drawing.Point(123, 73);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.Size = new System.Drawing.Size(84, 34);
            this.btAlarm.TabIndex = 3;
            this.btAlarm.Text = "ALARM";
            this.btAlarm.UseVisualStyleBackColor = true;
            this.btAlarm.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // txAlarmCode
            // 
            this.txAlarmCode.Location = new System.Drawing.Point(17, 78);
            this.txAlarmCode.Name = "txAlarmCode";
            this.txAlarmCode.Size = new System.Drawing.Size(100, 28);
            this.txAlarmCode.TabIndex = 2;
            // 
            // btUserStop
            // 
            this.btUserStop.Location = new System.Drawing.Point(107, 27);
            this.btUserStop.Name = "btUserStop";
            this.btUserStop.Size = new System.Drawing.Size(109, 34);
            this.btUserStop.TabIndex = 1;
            this.btUserStop.Text = "User Stop";
            this.btUserStop.UseVisualStyleBackColor = true;
            this.btUserStop.Click += new System.EventHandler(this.btUserStop_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(17, 27);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(84, 34);
            this.btRun.TabIndex = 0;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.chkRW_Active);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.group2);
            this.tabPage2.Controls.Add(this.chkUW_Active);
            this.tabPage2.Controls.Add(this.chkInputLot);
            this.tabPage2.Controls.Add(this.chkCut);
            this.tabPage2.Controls.Add(this.chkSample);
            this.tabPage2.Controls.Add(this.ckLotRunning);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnLotEnd);
            this.tabPage2.Controls.Add(this.btbLotStart);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LOT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckRWB_ID);
            this.groupBox4.Controls.Add(this.txRWB_Carrier);
            this.groupBox4.Controls.Add(this.lbRWB_CarrierLot);
            this.groupBox4.Location = new System.Drawing.Point(391, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 98);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RW B";
            // 
            // ckRWB_ID
            // 
            this.ckRWB_ID.AutoSize = true;
            this.ckRWB_ID.Enabled = false;
            this.ckRWB_ID.Location = new System.Drawing.Point(246, 31);
            this.ckRWB_ID.Name = "ckRWB_ID";
            this.ckRWB_ID.Size = new System.Drawing.Size(80, 22);
            this.ckRWB_ID.TabIndex = 7;
            this.ckRWB_ID.Text = "ID Rpt";
            this.ckRWB_ID.UseVisualStyleBackColor = true;
            // 
            // txRWB_Carrier
            // 
            this.txRWB_Carrier.Location = new System.Drawing.Point(21, 29);
            this.txRWB_Carrier.Name = "txRWB_Carrier";
            this.txRWB_Carrier.Size = new System.Drawing.Size(178, 28);
            this.txRWB_Carrier.TabIndex = 2;
            this.txRWB_Carrier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txRWB_Carrier_KeyDown);
            // 
            // lbRWB_CarrierLot
            // 
            this.lbRWB_CarrierLot.AutoSize = true;
            this.lbRWB_CarrierLot.Location = new System.Drawing.Point(22, 65);
            this.lbRWB_CarrierLot.Name = "lbRWB_CarrierLot";
            this.lbRWB_CarrierLot.Size = new System.Drawing.Size(161, 18);
            this.lbRWB_CarrierLot.TabIndex = 1;
            this.lbRWB_CarrierLot.Text = "RW B Carrier Lot ID";
            // 
            // chkRW_Active
            // 
            this.chkRW_Active.AutoSize = true;
            this.chkRW_Active.Location = new System.Drawing.Point(411, 169);
            this.chkRW_Active.Name = "chkRW_Active";
            this.chkRW_Active.Size = new System.Drawing.Size(161, 22);
            this.chkRW_Active.TabIndex = 11;
            this.chkRW_Active.Text = "RW Active Core";
            this.chkRW_Active.UseVisualStyleBackColor = true;
            this.chkRW_Active.CheckedChanged += new System.EventHandler(this.chkRW_Active_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckRWA_ID);
            this.groupBox5.Controls.Add(this.txRWA_Carrier);
            this.groupBox5.Controls.Add(this.lbRWA_CarrierLot);
            this.groupBox5.Location = new System.Drawing.Point(391, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 98);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RW A";
            // 
            // ckRWA_ID
            // 
            this.ckRWA_ID.AutoSize = true;
            this.ckRWA_ID.Enabled = false;
            this.ckRWA_ID.Location = new System.Drawing.Point(246, 31);
            this.ckRWA_ID.Name = "ckRWA_ID";
            this.ckRWA_ID.Size = new System.Drawing.Size(80, 22);
            this.ckRWA_ID.TabIndex = 7;
            this.ckRWA_ID.Text = "ID Rpt";
            this.ckRWA_ID.UseVisualStyleBackColor = true;
            // 
            // txRWA_Carrier
            // 
            this.txRWA_Carrier.Location = new System.Drawing.Point(21, 29);
            this.txRWA_Carrier.Name = "txRWA_Carrier";
            this.txRWA_Carrier.Size = new System.Drawing.Size(178, 28);
            this.txRWA_Carrier.TabIndex = 2;
            this.txRWA_Carrier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txRWA_Carrier_KeyDown);
            // 
            // lbRWA_CarrierLot
            // 
            this.lbRWA_CarrierLot.AutoSize = true;
            this.lbRWA_CarrierLot.Location = new System.Drawing.Point(22, 65);
            this.lbRWA_CarrierLot.Name = "lbRWA_CarrierLot";
            this.lbRWA_CarrierLot.Size = new System.Drawing.Size(162, 18);
            this.lbRWA_CarrierLot.TabIndex = 1;
            this.lbRWA_CarrierLot.Text = "RW A Carrier Lot ID";
            // 
            // group2
            // 
            this.group2.Controls.Add(this.ckUWB_JOB);
            this.group2.Controls.Add(this.ckUWB_ID);
            this.group2.Controls.Add(this.txUWB_Carrier);
            this.group2.Controls.Add(this.lbUWB_CarrierLot);
            this.group2.Location = new System.Drawing.Point(21, 319);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(345, 98);
            this.group2.TabIndex = 9;
            this.group2.TabStop = false;
            this.group2.Text = "UW B";
            // 
            // ckUWB_JOB
            // 
            this.ckUWB_JOB.AutoSize = true;
            this.ckUWB_JOB.Enabled = false;
            this.ckUWB_JOB.Location = new System.Drawing.Point(246, 59);
            this.ckUWB_JOB.Name = "ckUWB_JOB";
            this.ckUWB_JOB.Size = new System.Drawing.Size(95, 22);
            this.ckUWB_JOB.TabIndex = 8;
            this.ckUWB_JOB.Text = "Job Rpt";
            this.ckUWB_JOB.UseVisualStyleBackColor = true;
            // 
            // ckUWB_ID
            // 
            this.ckUWB_ID.AutoSize = true;
            this.ckUWB_ID.Enabled = false;
            this.ckUWB_ID.Location = new System.Drawing.Point(246, 31);
            this.ckUWB_ID.Name = "ckUWB_ID";
            this.ckUWB_ID.Size = new System.Drawing.Size(80, 22);
            this.ckUWB_ID.TabIndex = 7;
            this.ckUWB_ID.Text = "ID Rpt";
            this.ckUWB_ID.UseVisualStyleBackColor = true;
            // 
            // txUWB_Carrier
            // 
            this.txUWB_Carrier.Location = new System.Drawing.Point(21, 29);
            this.txUWB_Carrier.Name = "txUWB_Carrier";
            this.txUWB_Carrier.Size = new System.Drawing.Size(178, 28);
            this.txUWB_Carrier.TabIndex = 2;
            this.txUWB_Carrier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lbUWB_CarrierLot
            // 
            this.lbUWB_CarrierLot.AutoSize = true;
            this.lbUWB_CarrierLot.Location = new System.Drawing.Point(22, 65);
            this.lbUWB_CarrierLot.Name = "lbUWB_CarrierLot";
            this.lbUWB_CarrierLot.Size = new System.Drawing.Size(162, 18);
            this.lbUWB_CarrierLot.TabIndex = 1;
            this.lbUWB_CarrierLot.Text = "UW A Carrier Lot ID";
            // 
            // chkUW_Active
            // 
            this.chkUW_Active.AutoSize = true;
            this.chkUW_Active.Location = new System.Drawing.Point(41, 169);
            this.chkUW_Active.Name = "chkUW_Active";
            this.chkUW_Active.Size = new System.Drawing.Size(161, 22);
            this.chkUW_Active.TabIndex = 7;
            this.chkUW_Active.Text = "UW Active Core";
            this.chkUW_Active.UseVisualStyleBackColor = true;
            this.chkUW_Active.CheckedChanged += new System.EventHandler(this.chkUW_Active_CheckedChanged);
            // 
            // chkInputLot
            // 
            this.chkInputLot.AutoSize = true;
            this.chkInputLot.Location = new System.Drawing.Point(539, 122);
            this.chkInputLot.Name = "chkInputLot";
            this.chkInputLot.Size = new System.Drawing.Size(141, 22);
            this.chkInputLot.TabIndex = 6;
            this.chkInputLot.Text = "Input Lot Join";
            this.chkInputLot.UseVisualStyleBackColor = true;
            // 
            // chkCut
            // 
            this.chkCut.AutoSize = true;
            this.chkCut.Location = new System.Drawing.Point(472, 122);
            this.chkCut.Name = "chkCut";
            this.chkCut.Size = new System.Drawing.Size(61, 22);
            this.chkCut.TabIndex = 5;
            this.chkCut.Text = "Cut";
            this.chkCut.UseVisualStyleBackColor = true;
            // 
            // chkSample
            // 
            this.chkSample.AutoSize = true;
            this.chkSample.Location = new System.Drawing.Point(373, 122);
            this.chkSample.Name = "chkSample";
            this.chkSample.Size = new System.Drawing.Size(93, 22);
            this.chkSample.TabIndex = 4;
            this.chkSample.Text = "Sample";
            this.chkSample.UseVisualStyleBackColor = true;
            // 
            // ckLotRunning
            // 
            this.ckLotRunning.AutoSize = true;
            this.ckLotRunning.Enabled = false;
            this.ckLotRunning.Location = new System.Drawing.Point(373, 55);
            this.ckLotRunning.Name = "ckLotRunning";
            this.ckLotRunning.Size = new System.Drawing.Size(129, 22);
            this.ckLotRunning.TabIndex = 3;
            this.ckLotRunning.Text = "Lot Running";
            this.ckLotRunning.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckUWA_JOB);
            this.groupBox2.Controls.Add(this.ckUWA_ID);
            this.groupBox2.Controls.Add(this.txUWA_Carrier);
            this.groupBox2.Controls.Add(this.lbUWA_CarrierLot);
            this.groupBox2.Location = new System.Drawing.Point(21, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UW A";
            // 
            // ckUWA_JOB
            // 
            this.ckUWA_JOB.AutoSize = true;
            this.ckUWA_JOB.Enabled = false;
            this.ckUWA_JOB.Location = new System.Drawing.Point(246, 59);
            this.ckUWA_JOB.Name = "ckUWA_JOB";
            this.ckUWA_JOB.Size = new System.Drawing.Size(95, 22);
            this.ckUWA_JOB.TabIndex = 8;
            this.ckUWA_JOB.Text = "Job Rpt";
            this.ckUWA_JOB.UseVisualStyleBackColor = true;
            // 
            // ckUWA_ID
            // 
            this.ckUWA_ID.AutoSize = true;
            this.ckUWA_ID.Enabled = false;
            this.ckUWA_ID.Location = new System.Drawing.Point(246, 31);
            this.ckUWA_ID.Name = "ckUWA_ID";
            this.ckUWA_ID.Size = new System.Drawing.Size(80, 22);
            this.ckUWA_ID.TabIndex = 7;
            this.ckUWA_ID.Text = "ID Rpt";
            this.ckUWA_ID.UseVisualStyleBackColor = true;
            // 
            // txUWA_Carrier
            // 
            this.txUWA_Carrier.Location = new System.Drawing.Point(21, 29);
            this.txUWA_Carrier.Name = "txUWA_Carrier";
            this.txUWA_Carrier.Size = new System.Drawing.Size(178, 28);
            this.txUWA_Carrier.TabIndex = 2;
            this.txUWA_Carrier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txUWA_Carrier_KeyDown);
            // 
            // lbUWA_CarrierLot
            // 
            this.lbUWA_CarrierLot.AutoSize = true;
            this.lbUWA_CarrierLot.Location = new System.Drawing.Point(22, 65);
            this.lbUWA_CarrierLot.Name = "lbUWA_CarrierLot";
            this.lbUWA_CarrierLot.Size = new System.Drawing.Size(162, 18);
            this.lbUWA_CarrierLot.TabIndex = 1;
            this.lbUWA_CarrierLot.Text = "UW A Carrier Lot ID";
            // 
            // btnLotEnd
            // 
            this.btnLotEnd.Location = new System.Drawing.Point(638, 45);
            this.btnLotEnd.Name = "btnLotEnd";
            this.btnLotEnd.Size = new System.Drawing.Size(98, 47);
            this.btnLotEnd.TabIndex = 1;
            this.btnLotEnd.Text = "Lot End";
            this.btnLotEnd.UseVisualStyleBackColor = true;
            this.btnLotEnd.Click += new System.EventHandler(this.btnLotEnd_Click);
            // 
            // btbLotStart
            // 
            this.btbLotStart.Location = new System.Drawing.Point(521, 45);
            this.btbLotStart.Name = "btbLotStart";
            this.btbLotStart.Size = new System.Drawing.Size(98, 47);
            this.btbLotStart.TabIndex = 1;
            this.btbLotStart.Text = "Lot Start";
            this.btbLotStart.UseVisualStyleBackColor = true;
            this.btbLotStart.Click += new System.EventHandler(this.btbLotStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbWorkLenth);
            this.groupBox1.Controls.Add(this.lbCurrentLot);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Lot";
            // 
            // lbWorkLenth
            // 
            this.lbWorkLenth.AutoSize = true;
            this.lbWorkLenth.Location = new System.Drawing.Point(232, 36);
            this.lbWorkLenth.Name = "lbWorkLenth";
            this.lbWorkLenth.Size = new System.Drawing.Size(83, 18);
            this.lbWorkLenth.TabIndex = 1;
            this.lbWorkLenth.Text = "Work Qty";
            // 
            // lbCurrentLot
            // 
            this.lbCurrentLot.AutoSize = true;
            this.lbCurrentLot.Location = new System.Drawing.Point(18, 36);
            this.lbCurrentLot.Name = "lbCurrentLot";
            this.lbCurrentLot.Size = new System.Drawing.Size(118, 18);
            this.lbCurrentLot.TabIndex = 0;
            this.lbCurrentLot.Text = "Current Lot ID";
            // 
            // lbEqpStat
            // 
            this.lbEqpStat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEqpStat.Location = new System.Drawing.Point(639, 0);
            this.lbEqpStat.Name = "lbEqpStat";
            this.lbEqpStat.Size = new System.Drawing.Size(139, 75);
            this.lbEqpStat.TabIndex = 2;
            this.lbEqpStat.Text = "label1";
            this.lbEqpStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(159, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "ESHG Roll Press - Ver3.1.1_20241111";
            // 
            // btUWA_Out
            // 
            this.btUWA_Out.Location = new System.Drawing.Point(19, 37);
            this.btUWA_Out.Name = "btUWA_Out";
            this.btUWA_Out.Size = new System.Drawing.Size(99, 28);
            this.btUWA_Out.TabIndex = 14;
            this.btUWA_Out.Text = "UW A Out";
            this.btUWA_Out.UseVisualStyleBackColor = true;
            this.btUWA_Out.Click += new System.EventHandler(this.btUWA_Out_Click);
            // 
            // btUWB_Out
            // 
            this.btUWB_Out.Location = new System.Drawing.Point(19, 71);
            this.btUWB_Out.Name = "btUWB_Out";
            this.btUWB_Out.Size = new System.Drawing.Size(99, 28);
            this.btUWB_Out.TabIndex = 15;
            this.btUWB_Out.Text = "UW B Out";
            this.btUWB_Out.UseVisualStyleBackColor = true;
            this.btUWB_Out.Click += new System.EventHandler(this.btUWB_Out_Click);
            // 
            // btRWB_Out
            // 
            this.btRWB_Out.Location = new System.Drawing.Point(124, 71);
            this.btRWB_Out.Name = "btRWB_Out";
            this.btRWB_Out.Size = new System.Drawing.Size(99, 28);
            this.btRWB_Out.TabIndex = 17;
            this.btRWB_Out.Text = "RW B Out";
            this.btRWB_Out.UseVisualStyleBackColor = true;
            this.btRWB_Out.Click += new System.EventHandler(this.btRWB_Out_Click);
            // 
            // btRWA_Out
            // 
            this.btRWA_Out.Location = new System.Drawing.Point(124, 37);
            this.btRWA_Out.Name = "btRWA_Out";
            this.btRWA_Out.Size = new System.Drawing.Size(99, 28);
            this.btRWA_Out.TabIndex = 16;
            this.btRWA_Out.Text = "RW A Out";
            this.btRWA_Out.UseVisualStyleBackColor = true;
            this.btRWA_Out.Click += new System.EventHandler(this.btRWA_Out_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btUWA_Out);
            this.groupBox3.Controls.Add(this.btRWB_Out);
            this.groupBox3.Controls.Add(this.btUWB_Out);
            this.groupBox3.Controls.Add(this.btRWA_Out);
            this.groupBox3.Location = new System.Drawing.Point(519, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 114);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carrier Output";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btUserStop);
            this.groupBox6.Controls.Add(this.btRun);
            this.groupBox6.Controls.Add(this.txAlarmCode);
            this.groupBox6.Controls.Add(this.btReset);
            this.groupBox6.Controls.Add(this.btAlarm);
            this.groupBox6.Location = new System.Drawing.Point(8, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(305, 126);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "EQP State Control";
            // 
            // PLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEqpStat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbComm);
            this.Name = "PLC";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PLC_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbComm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btUserStop;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Label lbEqpStat;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btAlarm;
        private System.Windows.Forms.TextBox txAlarmCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCurrentLot;
        private System.Windows.Forms.Button btnLotEnd;
        private System.Windows.Forms.Button btbLotStart;
        private System.Windows.Forms.Label lbWorkLenth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txUWA_Carrier;
        private System.Windows.Forms.Label lbUWA_CarrierLot;
        private System.Windows.Forms.CheckBox ckLotRunning;
        private System.Windows.Forms.CheckBox chkInputLot;
        private System.Windows.Forms.CheckBox chkCut;
        private System.Windows.Forms.CheckBox chkSample;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckUWA_JOB;
        private System.Windows.Forms.CheckBox ckUWA_ID;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.CheckBox ckUWB_JOB;
        private System.Windows.Forms.CheckBox ckUWB_ID;
        private System.Windows.Forms.TextBox txUWB_Carrier;
        private System.Windows.Forms.Label lbUWB_CarrierLot;
        private System.Windows.Forms.CheckBox chkUW_Active;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckRWB_ID;
        private System.Windows.Forms.TextBox txRWB_Carrier;
        private System.Windows.Forms.Label lbRWB_CarrierLot;
        private System.Windows.Forms.CheckBox chkRW_Active;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckRWA_ID;
        private System.Windows.Forms.TextBox txRWA_Carrier;
        private System.Windows.Forms.Label lbRWA_CarrierLot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btUWA_Out;
        private System.Windows.Forms.Button btRWB_Out;
        private System.Windows.Forms.Button btUWB_Out;
        private System.Windows.Forms.Button btRWA_Out;
    }
}

