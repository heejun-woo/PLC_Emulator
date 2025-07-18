using HslCommunication.Profinet.Melsec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Emulator
{
    public class RollPress
    {
        public MelsecMcServer server = new MelsecMcServer(false);

        public RollPress(int port)
        {
            server.ServerStart(port);
        }

        #region [C1] Communication Management
        public Int16 EQP_COMM_CHK
        {
            get => server.ReadInt16("W3800").Content;
            set => server.Write("W3800", new Int16[] { value });
        }

        public bool HOST_COMM_CHK
        {
            get => server.ReadBool("B3000").Content;
            set => server.Write("B3000", new bool[] { value });
        }

        public bool HOST_COMM_CHK_CONF
        {
            get => server.ReadBool("B3800").Content;
            set => server.Write("B3800", new bool[] { value });
        }

        public bool COMM_ON
        {
            get => server.ReadBool("B3808").Content;
            set => server.Write("B3808", new bool[] { value });
        }

        public bool COMM_OFF
        {
            get => server.ReadBool("B3809").Content;
            set => server.Write("B3809", new bool[] { value });
        }
        #endregion

        #region [C2-1] Equipment State Change Report
        public Int16 EQP_STAT
        {
            get => server.ReadInt16("W3810").Content;
            set => server.Write("W3810", new Int16[] { value });
        }
        public Int16 EQP_SUBSTAT
        {
            get => server.ReadInt16("W3812").Content;
            set => server.Write("W3812", new Int16[] { value });
        }
        public Int16 ALARM_CODE
        {
            get => server.ReadInt16("W3811").Content;
            set => server.Write("W3811", new Int16[] { value });
        }
        public bool LOT_RUNNING
        {
            get => server.ReadBool("B380A").Content;
            set => server.Write("B380A", new bool[] { value });
        }
        public string CURRENT_LOT_ID
        {
            get => server.ReadString("W3878", 16).Content;
            set => server.Write("W3878", value, 16);
        }
        #endregion

        #region  [C2-3] Host Alarm Message Send
        public bool HOST_MSG_SEND
        {
            get => server.ReadBool("B3002").Content;
            set => server.Write("B3002", new bool[] { value });
        }
        public Int16 HOST_MSG_SYSTEM
        {
            get => server.ReadInt16("W5C00").Content;
            set => server.Write("W5C00", new Int16[] { value });
        }
        public Int16 HOST_MSG_STOP_TYPE
        {
            get => server.ReadInt16("W5C01").Content;
            set => server.Write("W5C01", new Int16[] { value });
        }
        public Int16 HOST_MSG_SISP_TYPE
        {
            get => server.ReadInt16("W5C02").Content;
            set => server.Write("W5C02", new Int16[] { value });
        }
        public string HOST_MSG
        {
            get => server.ReadString("W5C08", 128).Content;
            set => server.Write("W5C08", value, 128);
        }
        #endregion

        #region [C2-4] Equipment Operation Mode Change Report
        public bool AUTO_MODE
        {
            get => server.ReadBool("B380B").Content;
            set => server.Write("B380B", new bool[] { value });
        }

        public bool IT_PASS
        {
            get => server.ReadBool("B380D").Content;
            set => server.Write("B380D", new bool[] { value });
        }

        public Int16 LNAG_TYPE
        {
            get => server.ReadInt16("W3900").Content;
            set => server.Write("W3900", new Int16[] { value });
        }

        public bool INPUT_LOT_JOIN
        {
            get => server.ReadBool("B3B20").Content;
            set => server.Write("B3B20", new bool[] { value });
        }

        public bool TANDEM_PRESSING
        {
            get => server.ReadBool("B395E").Content;
            set => server.Write("B395E", new bool[] { value });
        }
        #endregion

        #region [C2-8] Alarm Set Report
        public bool ALARM_SET_RPT_CONF
        {
            get => server.ReadBool("B3078").Content;
            set => server.Write("B3078", new bool[] { value });
        }
        public bool ALARM_SET_RPT
        {
            get => server.ReadBool("B3878").Content;
            set => server.Write("B3878", new bool[] { value });
        }
        public Int16 ALARM_SET_ID
        {
            get => server.ReadInt16("W39F8").Content;
            set => server.Write("W39F8", new Int16[] { value });
        }
        #endregion

        #region [C2-9] Alarm Reset Report
        public bool ALARM_RESET_RPT_CONF
        {
            get => server.ReadBool("B307A").Content;
            set => server.Write("B307A", new bool[] { value });
        }
        public bool ALARM_RESET_RPT
        {
            get => server.ReadBool("B387A").Content;
            set => server.Write("B387A", new bool[] { value });
        }
        public Int16 ALARM_RESET_ID
        {
            get => server.ReadInt16("W39FA").Content;
            set => server.Write("W39FA", new Int16[] { value });
        }
        #endregion

        #region [G2] Carrier Management
        public bool UW_ACTIVE_CORE
        {
            get => server.ReadBool("B3940").Content;
            set => server.Write("B3940", new bool[] { value });
        }

        public bool RW_ACTIVE_CORE
        {
            get => server.ReadBool("B3942").Content;
            set => server.Write("B3942", new bool[] { value });
        }

        #region UW_A
        public bool UW_A_ID_RPT
        {
            get => server.ReadBool("B3850").Content;
            set => server.Write("B3850", new bool[] { value });
        }
        public bool UW_A_ID_RPT_CONF
        {
            get => server.ReadBool("B3050").Content;
            set => server.Write("B3050", new bool[] { value });
        }
        public Int16 UW_A_ID_RPT_CONF_ACK
        {
            get => server.ReadInt16("W3050").Content;
            set => server.Write("W3050", new Int16[] { value });
        }

        public bool UW_A_JOB_START_RPT
        {
            get => server.ReadBool("B3880").Content;
            set => server.Write("B3880", new bool[] { value });
        }
        public bool UW_A_JOB_START_CONF
        {
            get => server.ReadBool("B3080").Content;
            set => server.Write("B3080", new bool[] { value });
        }
        public Int16 UW_A_JOB_START_CONF_ACK
        {
            get => server.ReadInt16("W3080").Content;
            set => server.Write("W3080", new Int16[] { value });
        }

        public bool UW_A_JOB_END_RPT
        {
            get => server.ReadBool("B38A0").Content;
            set => server.Write("B38A0", new bool[] { value });
        }
        public bool UW_A_JOB_END_CONF
        {
            get => server.ReadBool("B30A0").Content;
            set => server.Write("B30A0", new bool[] { value });
        }

        public bool UW_A_OUT_RPT
        {
            get => server.ReadBool("B3890").Content;
            set => server.Write("B3890", new bool[] { value });
        }
        public bool UW_A_OUT_CONF
        {
            get => server.ReadBool("B3090").Content;
            set => server.Write("B3090", new bool[] { value });
        }


        public Int32 UW_A_O_WIP_LENGTH
        {
            get => server.ReadInt32("W31A0").Content;
            set => server.Write("W31A0", new Int32[] { value });
        }

        public string UW_A_O_CARRIER_LOT_ID
        {
            get => server.ReadString("W3230", 16).Content;
            set => server.Write("W3230", value, 16);
        }

        public bool UW_A_RFID_USE
        {
            get => server.ReadBool("B3A50").Content;
            set => server.Write("B3A50", new bool[] { value });
        }

        public Int16 UW_A_READING_TYPE
        {
            get => server.ReadInt16("W3A2D").Content;
            set => server.Write("W3A2D", new Int16[] { value });
        }

        public string UW_A_CARRIER_ID
        {
            get => server.ReadString("W3A00", 16).Content;
            set => server.Write("W3A00", value, 16);
        }

        public string UW_A_CARRIER_LOT_ID
        {
            get => server.ReadString("W3A18", 16).Content;
            set => server.Write("W3A18", value, 16);
        }
        public Int32 UW_A_WIP_LENGTH
        {
            get => server.ReadInt32("W3A20").Content;
            set => server.Write("W3A20", new Int32[] { value });
        }
        public Int32 UW_A_INPUT_LENGTH
        {
            get => server.ReadInt32("W3A24").Content;
            set => server.Write("W3A24", new Int32[] { value });
        }

        public Int32 UW_A_REMIAN_LENGTH
        {
            get => server.ReadInt32("W3A28").Content;
            set => server.Write("W3A28", new Int32[] { value });
        }

        public Int16 UW_A_JOB_END_TYPE
        {
            get => server.ReadInt16("W3A2C").Content;
            set => server.Write("W3A2C", new Int16[] { value });
        }
        #endregion

        #region UW_B
        public bool UW_B_ID_RPT
        {
            get => server.ReadBool("B3851").Content;
            set => server.Write("B3851", new bool[] { value });
        }
        public bool UW_B_ID_RPT_CONF
        {
            get => server.ReadBool("B3051").Content;
            set => server.Write("B3051", new bool[] { value });
        }
        public Int16 UW_B_ID_RPT_CONF_ACK
        {
            get => server.ReadInt16("W3051").Content;
            set => server.Write("W3051", new Int16[] { value });
        }

        public bool UW_B_JOB_START_RPT
        {
            get => server.ReadBool("B3881").Content;
            set => server.Write("B3881", new bool[] { value });
        }
        public bool UW_B_JOB_START_CONF
        {
            get => server.ReadBool("B3081").Content;
            set => server.Write("B3081", new bool[] { value });
        }
        public Int16 UW_B_JOB_START_CONF_ACK
        {
            get => server.ReadInt16("W3081").Content;
            set => server.Write("W3081", new Int16[] { value });
        }

        public bool UW_B_JOB_END_RPT
        {
            get => server.ReadBool("B38A1").Content;
            set => server.Write("B38A1", new bool[] { value });
        }
        public bool UW_B_JOB_END_CONF
        {
            get => server.ReadBool("B30A1").Content;
            set => server.Write("B30A1", new bool[] { value });
        }

        public bool UW_B_OUT_RPT
        {
            get => server.ReadBool("B3891").Content;
            set => server.Write("B3891", new bool[] { value });
        }
        public bool UW_B_OUT_CONF
        {
            get => server.ReadBool("B3091").Content;
            set => server.Write("B3091", new bool[] { value });
        }


        public Int32 UW_B_O_WIP_LENGTH
        {
            get => server.ReadInt32("W31A6").Content;
            set => server.Write("W31A6", new Int32[] { value });
        }

        public string UW_B_O_CARRIER_LOT_ID
        {
            get => server.ReadString("W3238", 16).Content;
            set => server.Write("W3238", value, 16);
        }

        public bool UW_B_RFID_USE
        {
            get => server.ReadBool("B3A51").Content;
            set => server.Write("B3A51", new bool[] { value });
        }

        public Int16 UW_B_READING_TYPE
        {
            get => server.ReadInt16("W3A6D").Content;
            set => server.Write("W3A6D", new Int16[] { value });
        }

        public string UW_B_CARRIER_ID
        {
            get => server.ReadString("W3A40", 16).Content;
            set => server.Write("W3A40", value, 16);
        }

        public string UW_B_CARRIER_LOT_ID
        {
            get => server.ReadString("W3A58", 16).Content;
            set => server.Write("W3A58", value, 16);
        }
        public Int32 UW_B_WIP_LENGTH
        {
            get => server.ReadInt32("W3A60").Content;
            set => server.Write("W3A60", new Int32[] { value });
        }
        public Int32 UW_B_INPUT_LENGTH
        {
            get => server.ReadInt32("W3A64").Content;
            set => server.Write("W3A64", new Int32[] { value });
        }

        public Int32 UW_B_REMIAN_LENGTH
        {
            get => server.ReadInt32("W3A68").Content;
            set => server.Write("W3A68", new Int32[] { value });
        }

        public Int16 UW_B_JOB_END_TYPE
        {
            get => server.ReadInt16("W3A6C").Content;
            set => server.Write("W3A6C", new Int16[] { value });
        }
        #endregion

        #region RW_A
        public bool RW_A_ID_RPT
        {
            get => server.ReadBool("B3852").Content;
            set => server.Write("B3852", new bool[] { value });
        }
        public bool RW_A_ID_RPT_CONF
        {
            get => server.ReadBool("B3052").Content;
            set => server.Write("B3052", new bool[] { value });
        }
        public Int16 RW_A_ID_RPT_CONF_ACK
        {
            get => server.ReadInt16("W3052").Content;
            set => server.Write("W3052", new int[] { value });
        }


        public bool RW_A_OUT_RPT
        {
            get => server.ReadBool("B3892").Content;
            set => server.Write("B3892", new bool[] { value });
        }
        public bool RW_A_OUT_CONF
        {
            get => server.ReadBool("B3092").Content;
            set => server.Write("B3092", new bool[] { value });
        }

        public bool RW_A_RFID_USE
        {
            get => server.ReadBool("B3A52").Content;
            set => server.Write("B3A52", new bool[] { value });
        }

        public Int16 RW_A_READING_TYPE
        {
            get => server.ReadInt16("W3B2D").Content;
            set => server.Write("W3B2D", new Int16[] { value });
        }

        public string RW_A_CARRIER_ID
        {
            get => server.ReadString("W3B00", 16).Content;
            set => server.Write("W3B00", value, 16);
        }

        public string RW_A_CARRIER_LOT_ID
        {
            get => server.ReadString("W3B18", 16).Content;
            set => server.Write("W3B18", value, 16);
        }
        public Int32 RW_A_WORK_LENGTH
        {
            get => server.ReadInt32("W3B24").Content;
            set => server.Write("W3B24", new Int32[] { value });
        }

        #endregion

        #region RW_B
        public bool RW_B_ID_RPT
        {
            get => server.ReadBool("B3853").Content;
            set => server.Write("B3853", new bool[] { value });
        }
        public bool RW_B_ID_RPT_CONF
        {
            get => server.ReadBool("B3053").Content;
            set => server.Write("B3053", new bool[] { value });
        }
        public Int16 RW_B_ID_RPT_CONF_ACK
        {
            get => server.ReadInt16("W3053").Content;
            set => server.Write("W3053", new Int16[] { value });
        }


        public bool RW_B_OUT_RPT
        {
            get => server.ReadBool("B3893").Content;
            set => server.Write("B3893", new bool[] { value });
        }
        public bool RW_B_OUT_CONF
        {
            get => server.ReadBool("B3093").Content;
            set => server.Write("B3093", new bool[] { value });
        }

        public bool RW_B_RFID_USE
        {
            get => server.ReadBool("B3A53").Content;
            set => server.Write("B3A53", new bool[] { value });
        }

        public Int16 RW_B_READING_TYPE
        {
            get => server.ReadInt16("W3B6D").Content;
            set => server.Write("W3B6D", new Int16[] { value });
        }

        public string RW_B_CARRIER_ID
        {
            get => server.ReadString("W3B40", 16).Content;
            set => server.Write("W3B40", value, 16);
        }

        public string RW_B_CARRIER_LOT_ID
        {
            get => server.ReadString("W3B58", 16).Content;
            set => server.Write("W3B58", value, 16);
        }
        public Int32 RW_B_WORK_LENGTH
        {
            get => server.ReadInt32("W3B64").Content;
            set => server.Write("W3B64", new Int32[] { value });
        }

        #endregion
        #endregion

        #region [G3-2] Lot Start Report
        public bool LOT_START_RPT
        {
            get => server.ReadBool("B3812").Content;
            set => server.Write("B3812", new bool[] { value });
        }

        public bool LOT_START_RPT_CONF
        {
            get => server.ReadBool("B3012").Content;
            set => server.Write("B3012", new bool[] { value });
        }

        public Int16 LOT_START_RPT_CONF_ACK
        {
            get => server.ReadInt16("W3012").Content;
            set => server.Write("W3012", new Int16[] { value });
        }

        public string LOT_START_O_LOT_ID
        {
            get => server.ReadString("W3128", 16).Content;
            set => server.Write("W3128", value, 16);
        }
        #endregion

        #region [G3-3] Lot End Report
        public bool LOT_END_RPT
        {
            get => server.ReadBool("B3813").Content;
            set => server.Write("B3813", new bool[] { value });
        }

        public bool LOT_END_RPT_CONF
        {
            get => server.ReadBool("B3013").Content;
            set => server.Write("B3013", new bool[] { value });
        }

        public bool SAMPLE_END
        {
            get => server.ReadBool("B395B").Content;
            set => server.Write("B395B", new bool[] { value });
        }

        public bool CUT_END
        {
            get => server.ReadBool("B395C").Content;
            set => server.Write("B395C", new bool[] { value });
        }

        public bool RW_END_CORE
        {
            get => server.ReadBool("B3943").Content;
            set => server.Write("B3943", new bool[] { value });
        }


        public string HIST_RW_A_CARRIER_ID
        {
            get => server.ReadString("W3B80", 16).Content;
            set => server.Write("W3B80", value, 16);
        }

        public string HIST_RW_A_CARRIER_LOT_ID
        {
            get => server.ReadString("W3B98", 16).Content;
            set => server.Write("W3B98", value, 16);
        }

        public Int32 HIST_RW_A_WORK_LENGTH  
        {
            get => server.ReadInt32("W3BA4").Content;
            set => server.Write("W3BA4", new Int32[] { value });
        }

        public string HIST_RW_B_CARRIER_ID
        {
            get => server.ReadString("W3BC0", 16).Content;
            set => server.Write("W3BC0", value, 16);
        }
        public string HIST_RW_B_CARRIER_LOT_ID
        {
            get => server.ReadString("W3BD8", 16).Content;
            set => server.Write("W3BD8", value, 16);
        }
        public Int32 HIST_RW_B_WORK_LENGTH
        {
            get => server.ReadInt32("W3BE4").Content;
            set => server.Write("W3BE4", new Int32[] { value });
        }

        public Int16 UW_INPUT_LOT_CNT
        {
            get => server.ReadInt16("W38BC").Content;
            set => server.Write("W38BC", new Int16[] { value });
        }

        public string HIST_UW1_CARRIER_ID
        {
            get => server.ReadString("W3DC0", 16).Content;
            set => server.Write("W3DC0", value, 16);
        }
        public string HIST_UW1_CARRIER_LOT_ID
        {
            get => server.ReadString("W3DC8", 16).Content;
            set => server.Write("W3DC8", value, 16);
        }
        public Int32 HIST_UW1_WORK_LENGTH
        {
            get => server.ReadInt32("W3DD0").Content;
            set => server.Write("W3DD0", new Int32[] { value });
        }

        public Int16 HIST_UW1_JOB_END_TYPE
        {
            get => server.ReadInt16("W3DD8").Content;
            set => server.Write("W3DD8", new Int16[] { value });
        }

        public bool HIST_UW1_JOB_END_CORE
        {
            get => server.ReadBool("B3BC0").Content;
            set => server.Write("B3BC0", new bool[] { value });
        }

        public string HIST_UW2_CARRIER_ID
        {
            get => server.ReadString("W3DE0", 16).Content;
            set => server.Write("W3DE0", value, 16);
        }
        public string HIST_UW2_CARRIER_LOT_ID
        {
            get => server.ReadString("W3DE8", 16).Content;
            set => server.Write("W3DE8", value, 16);
        }
        public Int32 HIST_UW2_WORK_LENGTH
        {
            get => server.ReadInt16("W3DF0").Content;
            set => server.Write("W3DF0", new Int32[] { value });
        }

        public Int16 HIST_UW2_JOB_END_TYPE
        {
            get => server.ReadInt16("W3DF8").Content;
            set => server.Write("ReadInt32", new Int16[] { value });
        }

        public bool HIST_UW2_JOB_END_CORE
        {
            get => server.ReadBool("B3BC4").Content;
            set => server.Write("B3BC4", new bool[] { value });
        }

        public string HIST_UW3_CARRIER_ID
        {
            get => server.ReadString("W3E00", 16).Content;
            set => server.Write("W3E00", value, 16);
        }
        public string HIST_UW3_CARRIER_LOT_ID
        {
            get => server.ReadString("W3E08", 16).Content;
            set => server.Write("W3E08", value, 16);
        }
        public Int32 HIST_UW3_WORK_LENGTH
        {
            get => server.ReadInt32("W3E10").Content;
            set => server.Write("W3E10", new Int32[] { value });
        }

        public Int16 HIST_UW3_JOB_END_TYPE
        {
            get => server.ReadInt16("W3E18").Content;
            set => server.Write("W3E18", new Int16[] { value });
        }

        public bool HIST_UW3_JOB_END_CORE
        {
            get => server.ReadBool("B3BC8").Content;
            set => server.Write("B3BC8", new bool[] { value });
        }

        public string HIST_UW4_CARRIER_ID
        {
            get => server.ReadString("W3E20", 16).Content;
            set => server.Write("W3E20", value, 16);
        }
        public string HIST_UW4_CARRIER_LOT_ID
        {
            get => server.ReadString("W3E28", 16).Content;
            set => server.Write("W3E28", value, 16);
        }
        public Int32 HIST_UW4_WORK_LENGTH
        {
            get => server.ReadInt32("W3E30").Content;
            set => server.Write("W3E30", new Int32[] { value });
        }

        public Int16 HIST_UW4_JOB_END_TYPE
        {
            get => server.ReadInt16("W3E38").Content;
            set => server.Write("W3E38", new Int16[] { value });
        }

        public bool HIST_UW4_JOB_END_CORE
        {
            get => server.ReadBool("B3BCC").Content;
            set => server.Write("B3BCC", new bool[] { value });
        }
        #endregion


    }
}
