using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;

namespace PLC_Emulator
{
    public partial class PLC : Form, INotifyPropertyChanged
    {
        #region Data Bind
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public bool LOT_RUNNING
        {
            get => plc.LOT_RUNNING;
            set
            {
                if (plc.LOT_RUNNING != value)
                {
                    plc.LOT_RUNNING = value;
                    OnPropertyChanged(nameof(LOT_RUNNING));
                }
            }
        }

        public string CURRENT_LOT
        {
            get => plc.CURRENT_LOT_ID;
            set
            {
                if (plc.CURRENT_LOT_ID != value)
                {
                    plc.CURRENT_LOT_ID = value;
                    OnPropertyChanged(nameof(CURRENT_LOT));
                }
            }
        }

        public bool CUT
        {
            get => plc.CUT_END;
            set
            {
                if (plc.CUT_END != value)
                {
                    plc.CUT_END = value;
                    OnPropertyChanged(nameof(CUT));
                }
            }
        }

        public bool SAMPLE_END
        {
            get => plc.SAMPLE_END;
            set
            {
                if (plc.SAMPLE_END != value)
                {
                    plc.SAMPLE_END = value;
                    OnPropertyChanged(nameof(SAMPLE_END));
                }
            }
        }

        public bool INPUT_LOT_JOIN
        {
            get => plc.INPUT_LOT_JOIN;
            set
            {
                if (plc.INPUT_LOT_JOIN != value)
                {
                    plc.INPUT_LOT_JOIN = value;
                    OnPropertyChanged(nameof(INPUT_LOT_JOIN));
                }
            }
        }

        public bool UW_ACTIVE_CORE
        {
            get => plc.UW_ACTIVE_CORE;
            set
            {
                if (plc.UW_ACTIVE_CORE != value)
                {
                    plc.UW_ACTIVE_CORE = value;
                    OnPropertyChanged(nameof(UW_ACTIVE_CORE));
                }
            }
        }
        public bool RW_ACTIVE_CORE
        {
            get => plc.RW_ACTIVE_CORE;
            set
            {
                if (plc.RW_ACTIVE_CORE != value)
                {
                    plc.RW_ACTIVE_CORE = value;
                    OnPropertyChanged(nameof(RW_ACTIVE_CORE));
                }
            }
        }

        public bool UWA_ID_OK
        {
            get => plc.server.ReadBool("B1100").Content;
            set
            {
                if (plc.server.ReadBool("B1100").Content != value)
                {
                    plc.server.Write("B1100", new bool[] { value });
                    OnPropertyChanged(nameof(UWA_ID_OK));
                }
            }
        }
        public bool UWB_ID_OK
        {
            get => plc.server.ReadBool("B1101").Content;
            set
            {
                if (plc.server.ReadBool("B1101").Content != value)
                {
                    plc.server.Write("B1101", new bool[] { value });
                    OnPropertyChanged(nameof(UWB_ID_OK));
                }
            }
        }

        public bool RWA_ID_OK
        {
            get => plc.server.ReadBool("B1102").Content;
            set
            {
                if (plc.server.ReadBool("B1102").Content != value)
                {
                    plc.server.Write("B1102", new bool[] { value });
                    OnPropertyChanged(nameof(RWA_ID_OK));
                }
            }
        }
        public bool RWB_ID_OK
        {
            get => plc.server.ReadBool("B1103").Content;
            set
            {
                if (plc.server.ReadBool("B1103").Content != value)
                {
                    plc.server.Write("B1103", new bool[] { value });
                    OnPropertyChanged(nameof(RWB_ID_OK));
                }
            }
        }

        public bool UWA_JOB_OK
        {
            get => plc.server.ReadBool("B1105").Content;
            set
            {
                if (plc.server.ReadBool("B1105").Content != value)
                {
                    plc.server.Write("B1105", new bool[] { value });
                    OnPropertyChanged(nameof(UWA_JOB_OK));
                }
            }
        }
        public bool UWB_JOB_OK
        {
            get => plc.server.ReadBool("B1106").Content;
            set
            {
                if (plc.server.ReadBool("B1106").Content != value)
                {
                    plc.server.Write("B1106", new bool[] { value });
                    OnPropertyChanged(nameof(UWB_JOB_OK));
                }
            }
        }


        public string UW_A_CARRIER_ID
        {
            get => plc.UW_A_CARRIER_ID;
            set
            {
                if (plc.UW_A_CARRIER_ID != value)
                {
                    plc.UW_A_CARRIER_ID = value;
                    txUWA_Carrier.Text = value;
                }
            }
        }

        public string UW_B_CARRIER_ID
        {
            get => plc.UW_B_CARRIER_ID;
            set
            {
                if (plc.UW_B_CARRIER_ID != value)
                {
                    plc.UW_B_CARRIER_ID = value;
                    txUWB_Carrier.Text = value;
                }
            }
        }

        public string RW_A_CARRIER_ID
        {
            get => plc.RW_A_CARRIER_ID;
            set
            {
                if (plc.RW_A_CARRIER_ID != value)
                {
                    plc.RW_A_CARRIER_ID = value;
                    txRWA_Carrier.Text = value;
                }
            }
        }

        public string RW_B_CARRIER_ID
        {
            get => plc.RW_B_CARRIER_ID;
            set
            {
                if (plc.RW_B_CARRIER_ID != value)
                {
                    plc.RW_B_CARRIER_ID = value;
                    txRWB_Carrier.Text = value;
                }
            }
        }

        public string UW_A_CARRIER_LOT_ID
        {
            get => plc.UW_A_CARRIER_LOT_ID;
            set
            {
                if (plc.UW_A_CARRIER_LOT_ID != value)
                {
                    plc.UW_A_CARRIER_LOT_ID = value;
                    OnPropertyChanged(nameof(UW_A_CARRIER_LOT_ID));
                }
            }
        }

        public string UW_B_CARRIER_LOT_ID
        {
            get => plc.UW_B_CARRIER_LOT_ID;
            set
            {
                if (plc.UW_B_CARRIER_LOT_ID != value)
                {
                    plc.UW_B_CARRIER_LOT_ID = value;
                    OnPropertyChanged(nameof(UW_B_CARRIER_LOT_ID));
                }
            }
        }

        public string RW_A_CARRIER_LOT_ID
        {
            get => plc.RW_A_CARRIER_LOT_ID;
            set
            {
                if (plc.RW_A_CARRIER_LOT_ID != value)
                {
                    plc.RW_A_CARRIER_LOT_ID = value;
                    OnPropertyChanged(nameof(RW_A_CARRIER_LOT_ID));
                }
            }
        }

        public string RW_B_CARRIER_LOT_ID
        {
            get => plc.RW_B_CARRIER_LOT_ID;
            set
            {
                if (plc.RW_B_CARRIER_LOT_ID != value)
                {
                    plc.RW_B_CARRIER_LOT_ID = value;
                    OnPropertyChanged(nameof(RW_B_CARRIER_LOT_ID));
                }
            }
        }
        #endregion

        #region 변수
        private RollPress plc;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private int time_out_chk = 0;
        private bool host_msg_popup = false;
        #endregion

        #region 상수 및 enum
        private const int CommTimeoutLimit = 30;
        private const int CommCheckReset = 999;

        public enum EqpState
        {
            Idle = 0,
            Run = 1,
            Trouble = 4,
            UserStop = 8
        }
        #endregion


        public PLC()
        {
            InitializeComponent();

            #region Data Bind
            ckLotRunning.DataBindings.Add("Checked", this, nameof(LOT_RUNNING), false, DataSourceUpdateMode.OnPropertyChanged);
            chkCut.DataBindings.Add("Checked", this, nameof(CUT), false, DataSourceUpdateMode.OnPropertyChanged);
            chkSample.DataBindings.Add("Checked", this, nameof(SAMPLE_END), false, DataSourceUpdateMode.OnPropertyChanged);
            chkInputLot.DataBindings.Add("Checked", this, nameof(INPUT_LOT_JOIN), false, DataSourceUpdateMode.OnPropertyChanged);

            chkUW_Active.DataBindings.Add("Checked", this, nameof(UW_ACTIVE_CORE), false, DataSourceUpdateMode.OnPropertyChanged);
            chkRW_Active.DataBindings.Add("Checked", this, nameof(RW_ACTIVE_CORE), false, DataSourceUpdateMode.OnPropertyChanged);

            ckUWA_ID.DataBindings.Add("Checked", this, nameof(UWA_ID_OK), false, DataSourceUpdateMode.OnPropertyChanged);
            ckUWB_ID.DataBindings.Add("Checked", this, nameof(UWB_ID_OK), false, DataSourceUpdateMode.OnPropertyChanged);
            ckRWA_ID.DataBindings.Add("Checked", this, nameof(RWA_ID_OK), false, DataSourceUpdateMode.OnPropertyChanged);
            ckRWB_ID.DataBindings.Add("Checked", this, nameof(RWB_ID_OK), false, DataSourceUpdateMode.OnPropertyChanged);
            ckUWA_JOB.DataBindings.Add("Checked", this, nameof(UWA_JOB_OK), false, DataSourceUpdateMode.OnPropertyChanged);
            ckUWB_JOB.DataBindings.Add("Checked", this, nameof(UWB_JOB_OK), false, DataSourceUpdateMode.OnPropertyChanged);

            lbCurrentLot.DataBindings.Add(propertyName: "Text", dataSource: this, dataMember: nameof(CURRENT_LOT), formattingEnabled: false, DataSourceUpdateMode.OnPropertyChanged);

            lbUWA_CarrierLot.DataBindings.Add(propertyName: "Text", dataSource: this, dataMember: nameof(UW_A_CARRIER_LOT_ID), formattingEnabled: false, DataSourceUpdateMode.OnPropertyChanged);
            lbUWB_CarrierLot.DataBindings.Add(propertyName: "Text", dataSource: this, dataMember: nameof(UW_B_CARRIER_LOT_ID), formattingEnabled: false, DataSourceUpdateMode.OnPropertyChanged);
            lbRWA_CarrierLot.DataBindings.Add(propertyName: "Text", dataSource: this, dataMember: nameof(RW_A_CARRIER_LOT_ID), formattingEnabled: false, DataSourceUpdateMode.OnPropertyChanged);
            lbRWB_CarrierLot.DataBindings.Add(propertyName: "Text", dataSource: this, dataMember: nameof(RW_B_CARRIER_LOT_ID), formattingEnabled: false, DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            plc = new RollPress(6000);

            var loaded = PlcMemoryHelper.LoadSnapshotFromJson("plc_memory.json");
            if (loaded != null)
                PlcMemoryHelper.RestoreSnapshotToServer(loaded, plc.server);

            timer.Interval = 1000; // milliseconds
            timer.Tick += timer_Tick;
            timer.Start();

            UI_RELOAD();
        }

        #region Common

        private void PLC_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlcMemorySnapshot backup = PlcMemoryHelper.ReadSnapshot(plc.server, wStart: 1000, wCount: 19000, bStart: 1000, bCount: 19000);
            PlcMemoryHelper.SaveSnapshotToJson(backup, "plc_memory.json");
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (plc == null) return;

            #region [C1] Communication Management
            if (plc.EQP_COMM_CHK == CommCheckReset) plc.EQP_COMM_CHK = 0;
            else plc.EQP_COMM_CHK++;

            if (plc.HOST_COMM_CHK_CONF != plc.HOST_COMM_CHK)
            {
                plc.HOST_COMM_CHK_CONF = plc.HOST_COMM_CHK;
                plc.COMM_ON = true;
                time_out_chk = 0;
                UpdateCommStatus(true);
            }
            else
            {
                time_out_chk++;
            }

            if (time_out_chk > CommTimeoutLimit)
            {
                plc.COMM_OFF = false;
                UpdateCommStatus(false);
            }
            #endregion

            #region [C2-3] Host Alarm Message Send
            if (plc.HOST_MSG_SEND && !host_msg_popup)
            {
                MessageBox.Show(plc.HOST_MSG);
                host_msg_popup = true;
            }
            else if (!plc.HOST_MSG_SEND && host_msg_popup)
            {
                host_msg_popup = false;
            }
            #endregion

            if (LOT_RUNNING && plc.EQP_STAT == 1)
            {
                if (UW_ACTIVE_CORE) plc.UW_A_INPUT_LENGTH += 1;
                else plc.UW_B_INPUT_LENGTH += 1;

                if (RW_ACTIVE_CORE) plc.RW_A_WORK_LENGTH += 1;
                else plc.RW_B_WORK_LENGTH += 1;
            }

        }

        private void UI_RELOAD()
        {
            UpdateCommStatus(plc.COMM_ON);
            UpdateEqpStatus(plc.EQP_STAT);

            txUWA_Carrier.Text = UW_A_CARRIER_ID;
            txUWB_Carrier.Text = UW_B_CARRIER_ID;
            txRWA_Carrier.Text = RW_A_CARRIER_ID;
            txRWB_Carrier.Text = RW_B_CARRIER_ID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PlcMemorySnapshot backup = PlcMemoryHelper.ReadSnapshot(plc.server, wStart: 1000, wCount: 19000, bStart: 1000, bCount: 19000);
            PlcMemoryHelper.SaveSnapshotToJson(backup, "plc_memory.json");
        }

        #endregion

        #region [C1] Communication Management

        private void UpdateCommStatus(bool isOnline)
        {
            lbComm.BackColor = isOnline ? Color.Green : Color.Red;
            lbComm.Text = isOnline ? "COMM ON" : "COMM OFF";
        }

        #endregion

        #region [C2-1] Equipment State Change Report

        private void UpdateEqpStatus(int state)
        {
            switch (state)
            {
                case (int)EqpState.Run:
                    lbEqpStat.BackColor = Color.Green;
                    lbEqpStat.Text = "Run";
                    break;
                case (int)EqpState.UserStop:
                    lbEqpStat.BackColor = Color.Blue;
                    lbEqpStat.Text = "User Stop";
                    break;
                case (int)EqpState.Trouble:
                    lbEqpStat.BackColor = Color.Red;
                    lbEqpStat.Text = "Trouble";
                    break;
                default:
                    lbEqpStat.BackColor = Color.Gray;
                    lbEqpStat.Text = "Unknown";
                    break;
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            if (plc.EQP_STAT == (int)EqpState.Trouble) return;

            plc.EQP_STAT = (int)EqpState.Run;
            plc.EQP_SUBSTAT = 0;

            UpdateEqpStatus(plc.EQP_STAT);
        }

        private void btUserStop_Click(object sender, EventArgs e)
        {
            if (plc.EQP_STAT > (int)EqpState.Trouble) return;

            plc.EQP_STAT = (int)EqpState.UserStop;
            plc.EQP_SUBSTAT = 0;

            UpdateEqpStatus(plc.EQP_STAT);
        }

        private void btAlarm_Click(object sender, EventArgs e)
        {
            if (short.TryParse(txAlarmCode.Text, out short code))
            {
                plc.ALARM_CODE = code;

                if (plc.EQP_STAT < (int)EqpState.Trouble)
                {
                    plc.EQP_STAT = (int)EqpState.Trouble;
                    plc.EQP_SUBSTAT = 0;

                    UpdateEqpStatus(plc.EQP_STAT);
                }

                AlarmSetReport(code);
            }
        }

        private async void btReset_Click(object sender, EventArgs e)
        {
            plc.ALARM_CODE = 0;

            if (plc.EQP_STAT == (int)EqpState.Trouble)
            {
                plc.EQP_STAT = (int)EqpState.UserStop;
                plc.EQP_SUBSTAT = 118;

                UpdateEqpStatus(plc.EQP_STAT);
            }

            if (QueueAlarm.Count == 0) return;

            while (true)
            {
                if (QueueAlarm.Count > 0)
                {
                    if (plc.ALARM_RESET_RPT == false)
                    {
                        Thread.Sleep(500);
                        await AlarmReSetReport(QueueAlarm.Dequeue());
                    }
                }
                else
                {
                    if (plc.ALARM_RESET_RPT == false)
                    {
                        Thread.Sleep(500);
                        await AlarmReSetReport(0);
                        break;
                    }
                }
            }
        }
        Queue<Int16> QueueAlarm = new Queue<Int16>();
        private readonly object queueLock = new object();

        private async Task AlarmSetReport(Int16 code)
        {
            QueueAlarm.Enqueue(code);

            plc.ALARM_SET_ID = code;
            plc.ALARM_SET_RPT = true;

            int t = 0;
            while (true)
            {
                await Task.Delay(1000);  // 비동기 대기
                t += 1;
                if (t > 30)
                {
                    MessageBox.Show("Time Out");
                    break;
                }

                if (plc.ALARM_SET_RPT_CONF == false) continue;
                else break;
            }
            plc.ALARM_SET_RPT = false;
            plc.ALARM_SET_ID = 0;
        }


        private async Task AlarmReSetReport(Int16 code)
        {
            plc.ALARM_RESET_ID = code;
            plc.ALARM_RESET_RPT = true;

            int t = 0;
            while (true)
            {
                await Task.Delay(1000);  // 비동기 대기
                t += 1;
                if (t > 30)
                {
                    MessageBox.Show("Time Out");
                    break;
                }

                if (plc.ALARM_RESET_RPT_CONF == false) continue;
                else break;
            }
            plc.ALARM_RESET_RPT = false;
            plc.ALARM_RESET_ID = 0;
        }
        #endregion

        #region [G2] Carrier Management

        private async void chkUW_Active_CheckedChanged(object sender, EventArgs e)
        {
            UW_ACTIVE_CORE = (sender as CheckBox).Checked;

            if (UW_ACTIVE_CORE)
            {
                if (UWA_ID_OK)
                    await UWA_JOB_START();

                if (UWB_JOB_OK)
                    await UWB_JOB_END();
            }
            else
            {
                if (UWB_ID_OK)
                    await UWB_JOB_START();

                if (UWA_JOB_OK)
                    await UWA_JOB_END();
            }
        }

        private void chkRW_Active_CheckedChanged(object sender, EventArgs e)
        {

        }


        private async Task UWA_JOB_START()
        {
            plc.UW_A_JOB_START_RPT = true;
            var helper = new PlcHelper();
            if (await helper.WaitForConfirmationAsync(() => plc.UW_A_JOB_START_CONF, () => plc.UW_A_JOB_START_CONF_ACK))
                UWA_JOB_OK = true;
            plc.UW_A_JOB_START_RPT = false;
        }

        private async Task UWB_JOB_START()
        {
            plc.UW_B_JOB_START_RPT = true;
            var helper = new PlcHelper();
            if (await helper.WaitForConfirmationAsync(() => plc.UW_B_JOB_START_CONF, () => plc.UW_B_JOB_START_CONF_ACK))
                UWB_JOB_OK = true;
            plc.UW_B_JOB_START_RPT = false;
        }

        private async Task UWA_JOB_END(short EndType = 1)
        {
            plc.UW_A_JOB_END_TYPE = EndType;
            plc.UW_A_JOB_END_RPT = true;
            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(() => plc.UW_A_JOB_END_CONF);
            if (result)
            {
                UWA_JOB_OK = false;
                UWA_ID_OK = false;
                SaveUWHistory('A');
            }
            plc.UW_A_JOB_END_RPT = false;
        }

        private async Task UWB_JOB_END(short EndType = 1)
        {
            plc.UW_A_JOB_END_TYPE = EndType;
            plc.UW_B_JOB_END_RPT = true;
            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(() => plc.UW_B_JOB_END_CONF);
            if (result)
            {
                UWB_JOB_OK = false;
                UWB_ID_OK = false;
                SaveUWHistory('B');
            }
            plc.UW_B_JOB_END_RPT = false;
        }

        private void SaveUWHistory(char unit)
        {
            string carrierId = unit == 'A' ? UW_A_CARRIER_ID : UW_B_CARRIER_ID;
            string carrierLotId = unit == 'A' ? UW_A_CARRIER_LOT_ID : UW_B_CARRIER_LOT_ID;
            int inputLength = unit == 'A' ? plc.UW_A_INPUT_LENGTH : plc.UW_B_INPUT_LENGTH;
            short endType = unit == 'A' ? plc.UW_A_JOB_END_TYPE : plc.UW_B_JOB_END_TYPE;

            switch (plc.UW_INPUT_LOT_CNT)
            {
                case 0:
                    plc.HIST_UW1_CARRIER_ID = carrierId;
                    plc.HIST_UW1_CARRIER_LOT_ID = carrierLotId;
                    plc.HIST_UW1_JOB_END_CORE = UW_ACTIVE_CORE;
                    plc.HIST_UW1_WORK_LENGTH = inputLength;
                    plc.HIST_UW1_JOB_END_TYPE = endType;
                    break;
                case 1:
                    if (INPUT_LOT_JOIN)
                    {
                        plc.HIST_UW2_CARRIER_ID = carrierId;
                        plc.HIST_UW2_CARRIER_LOT_ID = carrierLotId;
                        plc.HIST_UW2_JOB_END_CORE = UW_ACTIVE_CORE;
                        plc.HIST_UW2_WORK_LENGTH = inputLength;
                        plc.HIST_UW2_JOB_END_TYPE = endType;
                    }
                    break;
                case 2:
                    if (INPUT_LOT_JOIN)
                    {
                        plc.HIST_UW3_CARRIER_ID = carrierId;
                        plc.HIST_UW3_CARRIER_LOT_ID = carrierLotId;
                        plc.HIST_UW3_JOB_END_CORE = UW_ACTIVE_CORE;
                        plc.HIST_UW3_WORK_LENGTH = inputLength;
                        plc.HIST_UW3_JOB_END_TYPE = endType;
                    }
                    break;
                case 3:
                    if (INPUT_LOT_JOIN)
                    {
                        plc.HIST_UW4_CARRIER_ID = carrierId;
                        plc.HIST_UW4_CARRIER_LOT_ID = carrierLotId;
                        plc.HIST_UW4_JOB_END_CORE = UW_ACTIVE_CORE;
                        plc.HIST_UW4_WORK_LENGTH = inputLength;
                        plc.HIST_UW4_JOB_END_TYPE = endType;
                    }
                    break;
            }

            if (plc.UW_INPUT_LOT_CNT > 0 && INPUT_LOT_JOIN) plc.UW_INPUT_LOT_CNT++;
            else plc.UW_INPUT_LOT_CNT = 1;

            if (plc.UW_INPUT_LOT_CNT == 4) INPUT_LOT_JOIN = false;
        }

        private async Task HandleCarrierInput(string id, Action setReportFlags, Func<bool> confFlag, Func<int> ackCode, Action onSuccess)
        {
            setReportFlags();
            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(confFlag, ackCode);
            if (result) onSuccess();
        }

        private async void txUWA_Carrier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var tb = sender as TextBox;
            if (tb.Text.Length < 5) return;
            UW_A_CARRIER_ID = tb.Text;

            await HandleCarrierInput(
                UW_A_CARRIER_ID,
                () =>
                {
                    plc.UW_A_ID_RPT = true;
                    plc.UW_A_RFID_USE = true;
                    plc.UW_A_READING_TYPE = 1;
                },
                () => plc.UW_A_ID_RPT_CONF,
                () => plc.UW_A_ID_RPT_CONF_ACK,
                () =>
                {
                    UW_A_CARRIER_LOT_ID = plc.UW_A_O_CARRIER_LOT_ID;
                    UWA_ID_OK = true;
                }
            );

            plc.UW_A_ID_RPT = false;
            if (UW_ACTIVE_CORE) await UWA_JOB_START();
        }

        private async void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var tb = sender as TextBox;
            if (tb.Text.Length < 5) return;
            UW_B_CARRIER_ID = tb.Text;

            await HandleCarrierInput(
                UW_B_CARRIER_ID,
                () =>
                {
                    plc.UW_B_RFID_USE = true;
                    plc.UW_B_READING_TYPE = 1;
                    plc.UW_B_ID_RPT = true;
                },
                () => plc.UW_B_ID_RPT_CONF,
                () => plc.UW_B_ID_RPT_CONF_ACK,
                () =>
                {
                    UW_B_CARRIER_LOT_ID = plc.UW_B_O_CARRIER_LOT_ID;
                    UWB_ID_OK = true;
                }
            );

            plc.UW_B_ID_RPT = false;
            if (!UW_ACTIVE_CORE) await UWB_JOB_START();
        }


        private void txRWA_Carrier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as TextBox).Text.Length < 5) return;

                RW_A_CARRIER_ID = (sender as TextBox).Text;

                plc.RW_A_ID_RPT = true;
                plc.RW_A_RFID_USE = true;
                plc.RW_A_READING_TYPE = 1;

                int t = 0;
                while (true)
                {
                    Thread.Sleep(1000);
                    t += 1;
                    if (t > 30) { MessageBox.Show("Time Out"); break; }

                    if (plc.RW_A_ID_RPT_CONF == false) continue;
                    else
                    {
                        if (plc.RW_A_ID_RPT_CONF_ACK == 10)
                        {
                            RWA_ID_OK = true;
                        }

                        break;
                    }

                }
                plc.RW_A_ID_RPT = false;
            }
        }

        private void txRWB_Carrier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((sender as TextBox).Text.Length < 5) return;

                RW_B_CARRIER_ID = (sender as TextBox).Text;

                plc.RW_B_ID_RPT = true;
                plc.RW_B_RFID_USE = true;
                plc.RW_B_READING_TYPE = 1;

                int t = 0;
                while (true)
                {
                    Thread.Sleep(1000);
                    t += 1;
                    if (t > 30) { MessageBox.Show("Time Out"); break; }

                    if (plc.RW_B_ID_RPT_CONF == false) continue;
                    else
                    {
                        if (plc.RW_B_ID_RPT_CONF_ACK == 10)
                        {
                            RWB_ID_OK = true;
                        }

                        break;
                    }

                }
                plc.RW_B_ID_RPT = false;
            }
        }

        private async void btUWA_Out_Click(object sender, EventArgs e)
        {
            if (UWA_JOB_OK) return;

            plc.UW_A_OUT_RPT = true;

            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(() => plc.UW_A_OUT_CONF);
            if (result)
            {
                UW_A_CARRIER_ID = string.Empty;
                UW_A_CARRIER_LOT_ID = string.Empty;

                plc.UW_A_INPUT_LENGTH = 0;
                plc.UW_A_WIP_LENGTH = 0;
                plc.UW_A_REMIAN_LENGTH = 0;
                plc.UW_A_JOB_END_TYPE = 0;

                UWA_JOB_OK = false;
                UWA_ID_OK = false;
            }

            plc.UW_A_OUT_RPT = false;
        }

        private async void btUWB_Out_Click(object sender, EventArgs e)
        {
            if (UWB_JOB_OK) return;

            plc.UW_B_OUT_RPT = true;

            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(() => plc.UW_B_OUT_CONF);
            if (result)
            {
                UW_B_CARRIER_ID = string.Empty;
                UW_B_CARRIER_LOT_ID = string.Empty;

                plc.UW_B_INPUT_LENGTH = 0;
                plc.UW_B_WIP_LENGTH = 0;
                plc.UW_B_REMIAN_LENGTH = 0;
                plc.UW_B_JOB_END_TYPE = 0;

                UWB_JOB_OK = false;
                UWB_ID_OK = false;
            }

            plc.UW_B_OUT_RPT = false;
        }

        private async void btRWA_Out_Click(object sender, EventArgs e)
        {
            if (RW_ACTIVE_CORE && LOT_RUNNING) return;

            plc.RW_A_OUT_RPT = true;

            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(() => plc.RW_A_OUT_CONF);
            if (result)
            {
                RW_A_CARRIER_ID = string.Empty;
                RW_A_CARRIER_LOT_ID = string.Empty;

                RWA_ID_OK = false;
            }

            plc.RW_A_OUT_RPT = false;
        }

        private async void btRWB_Out_Click(object sender, EventArgs e)
        {
            if (!RW_ACTIVE_CORE && LOT_RUNNING) return;

            plc.RW_B_OUT_RPT = true;

            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(() => plc.RW_B_OUT_CONF);
            if (result)
            {
                RW_B_CARRIER_ID = string.Empty;
                RW_B_CARRIER_LOT_ID = string.Empty;

                RWB_ID_OK = false;
            }

            plc.RW_B_OUT_RPT = false;
        }

        #endregion

        #region [G3] Lot Management
        private async void btbLotStart_Click(object sender, EventArgs e)
        {
            plc.LOT_START_RPT = true;

            var helper = new PlcHelper();
            if (await helper.WaitForConfirmationAsync(() => plc.LOT_START_RPT_CONF, () => plc.LOT_START_RPT_CONF_ACK))
            {
                CURRENT_LOT = plc.LOT_START_O_LOT_ID;

                if (RW_ACTIVE_CORE)
                    RW_A_CARRIER_LOT_ID = CURRENT_LOT;
                else
                    RW_B_CARRIER_LOT_ID = CURRENT_LOT;

                LOT_RUNNING = true;
            }

            plc.LOT_START_RPT = false;
        }

        private async void btnLotEnd_Click(object sender, EventArgs e)
        {
            if (!LOT_RUNNING) return;

            if (plc.CUT_END || plc.UW_INPUT_LOT_CNT == 0)
            {
                if (UW_ACTIVE_CORE)
                    await UWA_JOB_END(2);
                else
                    await UWB_JOB_END(1);
            }

            plc.LOT_END_RPT = true;
            plc.RW_END_CORE = RW_ACTIVE_CORE;

            if (RW_ACTIVE_CORE)
            {
                plc.HIST_RW_A_CARRIER_ID = RW_A_CARRIER_ID;
                plc.HIST_RW_A_CARRIER_LOT_ID = RW_A_CARRIER_LOT_ID;
                plc.HIST_RW_A_WORK_LENGTH = plc.RW_A_WORK_LENGTH;
            }
            else
            {
                plc.HIST_RW_B_CARRIER_ID = RW_B_CARRIER_ID;
                plc.HIST_RW_B_CARRIER_LOT_ID = RW_B_CARRIER_LOT_ID;
                plc.HIST_RW_A_WORK_LENGTH = plc.RW_B_WORK_LENGTH;
            }

            LOT_RUNNING = false;
            CURRENT_LOT = string.Empty;

            var helper = new PlcHelper();
            bool result = await helper.WaitForConfirmationAsync(() => plc.LOT_END_RPT_CONF);
            if (result)
            {
                plc.UW_INPUT_LOT_CNT = 0;
                for (int i = 1; i <= 4; i++)
                {
                    typeof(PLC).GetProperty($"HIST_UW{i}_CARRIER_ID")?.SetValue(plc, string.Empty);
                    typeof(PLC).GetProperty($"HIST_UW{i}_CARRIER_LOT_ID")?.SetValue(plc, string.Empty);
                    typeof(PLC).GetProperty($"HIST_UW{i}_JOB_END_CORE")?.SetValue(plc, false);
                    typeof(PLC).GetProperty($"HIST_UW{i}_WORK_LENGTH")?.SetValue(plc, 0);
                    typeof(PLC).GetProperty($"HIST_UW{i}_JOB_END_TYPE")?.SetValue(plc, 0);
                }
            }

            plc.LOT_END_RPT = false;
        } 
        #endregion

    }

}
