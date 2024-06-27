using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaodiendieukhien.Sources
{
    public static class class_KEPServerEX
    {
        public static string[] tagread(int tagnumber)
        {
            string tagID_1 = "Channel1.Device1.Watchdog";
            string tagID_76 = "Channel1.Device1.TiemCan_Sensor";
            //Xử lý thông tin khu vực: UC_Dieukhien
            string tagID_2 = "Channel1.Device1.START_Command";
            string tagID_3 = "Channel1.Device1.STOP_Command";
            string tagID_4 = "Channel1.Device1.RESET_Command";
            string tagID_5 = "Channel1.Device1.START_Manual_C1";
            string tagID_6 = "Channel1.Device1.STOP_Manual_C1";
            string tagID_7 = "Channel1.Device1.START_Manual_C2";
            string tagID_8 = "Channel1.Device1.STOP_Manual_C2";
            string tagID_9 = "Channel1.Device1.START_Manual_Stepmotor01";
            string tagID_10 = "Channel1.Device1.STOP_Manual_Stepmotor01";
            string tagID_11 = "Channel1.Device1.START_Manual_Stepmotor02";
            string tagID_12 = "Channel1.Device1.STOP_Manual_Stepmotor02";
            string tagID_13 = "Channel1.Device1.Running_Thuan_Stepmotor01";
            string tagID_14 = "Channel1.Device1.Running_Nghich_Stepmotor01";
            string tagID_15 = "Channel1.Device1.Running_Thuan_Stepmotor02";
            string tagID_16 = "Channel1.Device1.Running_Nghich_Stepmotor02";
            string tagID_17 = "Channel1.Device1.Bunke1_Full";
            string tagID_18 = "Channel1.Device1.Bunke2_Full";
            string tagID_19 = "Channel1.Device1.Bunke3_Full";
            string tagID_20 = "Channel1.Device1.symb_LampAuto";
            string tagID_21 = "Channel1.Device1.symb_LampManual";
            string tagID_22 = "Channel1.Device1.symb_LampEMS";
            string tagID_23 = "Channel1.Device1.symb_ResetIn";
            string tagID_24 = "Channel1.Device1.symb_ResetOut";
            string tagID_25 = "Channel1.Device1.Loadcell1_RealWeight";
            string tagID_26 = "Channel1.Device1.Loadcell2_RealWeight";
            string tagID_27 = "Channel1.Device1.Conveyor01_Running";
            string tagID_28 = "Channel1.Device1.Conveyor02_Running";
            string tagID_29 = "Channel1.Device1.SYSTEM_Running";
            string tagID_86 = "Channel1.Device1.Home_Command_Stepmotor01";
            string tagID_87 = "Channel1.Device1.Home_Command_Stepmotor02";
            ////Xử lý thông tin khu vực: UC_Caidat
            string tagID_30 = "Channel1.Device1.START_AutoTime_C1";
            string tagID_31 = "Channel1.Device1.START_AutoTime_C2";
            string tagID_32 = "Channel1.Device1.STOP_AutoTime_C1";
            string tagID_33 = "Channel1.Device1.STOP_AutoTime_C2";
            string tagID_34 = "Channel1.Device1.START_ManTime_C1";
            string tagID_35 = "Channel1.Device1.START_ManTime_C2";
            string tagID_36 = "Channel1.Device1.STOP_ManTime_C1";
            string tagID_37 = "Channel1.Device1.STOP_ManTime_C2";
            string tagID_38 = "Channel1.Device1.Stepmotor01_Thuan_Position";
            string tagID_39 = "Channel1.Device1.Stepmotor01_Nghich_Position";
            string tagID_40 = "Channel1.Device1.Stepmotor02_Thuan_Position";
            string tagID_41 = "Channel1.Device1.Stepmotor02_Nghich_Position";
            string tagID_42 = "Channel1.Device1.Stepmotor01_Speed";
            string tagID_43 = "Channel1.Device1.Stepmotor02_Speed";
            string tagID_44 = "Channel1.Device1.Loadcell1_Max";
            string tagID_45 = "Channel1.Device1.Loadcell2_Max";
            string tagID_46 = "Channel1.Device1.Loadcell1_AutoZeroingTime";
            string tagID_47 = "Channel1.Device1.Loadcell2_AutoZeroingTime";
            string tagID_48 = "Channel1.Device1.Loadcell1_AutoZeroingWeight";
            string tagID_49 = "Channel1.Device1.Loadcell2_AutoZeroingWeight";
            ////Xử lý thông tin khu vực: UC_Simulation
            string tagID_50 = "Channel1.Device1.START_ErrorSim";
            string tagID_51 = "Channel1.Device1.STOP_ErrorSim";
            string tagID_52 = "Channel1.Device1.START_LoadcellSim";
            string tagID_53 = "Channel1.Device1.STOP_LoadcellSim";
            string tagID_54 = "Channel1.Device1.ON_Pull_C1";
            string tagID_55 = "Channel1.Device1.OFF_Pull_C1";
            string tagID_56 = "Channel1.Device1.ON_Sway_C1";
            string tagID_57 = "Channel1.Device1.OFF_Sway_C1";
            string tagID_58 = "Channel1.Device1.ON_Overload_C1";
            string tagID_59 = "Channel1.Device1.OFF_Overload_C2";
            string tagID_60 = "Channel1.Device1.ON_Pull_C2";
            string tagID_61 = "Channel1.Device1.OFF_Pull_C2";
            string tagID_62 = "Channel1.Device1.ON_Sway_C2";
            string tagID_63 = "Channel1.Device1.OFF_Sway_C2";
            string tagID_64 = "Channel1.Device1.ON_Overload_C2";
            string tagID_65 = "Channel1.Device1.OFF_Overload_C2";
            string tagID_66 = "Channel1.Device1.ZeroingSim_Loadcell1";
            string tagID_67 = "Channel1.Device1.ZeroingSim_Loadcell2";
            string tagID_68 = "Channel1.Device1.symb_ErrorSimRunning";
            string tagID_69 = "Channel1.Device1.symb_LoadcellSimRunning";
            string tagID_70 = "Channel1.Device1.symb_Pull_C1";
            string tagID_71 = "Channel1.Device1.symb_Pull_C2";
            string tagID_72 = "Channel1.Device1.symb_Sway_C1";
            string tagID_73 = "Channel1.Device1.symb_Sway_C2";
            string tagID_74 = "Channel1.Device1.symb_Overload_C1";
            string tagID_75 = "Channel1.Device1.symb_Overload_C2";
            //Xử lý thông tin khu vực: UC_IO
            string tagID_77 = "Channel1.Device1.Analog_Loadcell1";
            string tagID_78 = "Channel1.Device1.Analog_Loadcell2";
            string tagID_79 = "Channel1.Device1.ERROR_Signal";
            string tagID_80 = "Channel1.Device1.STOP_Weighting_Loadcell1";
            string tagID_81 = "Channel1.Device1.START_Weighting_Loadcell1";
            string tagID_82 = "Channel1.Device1.STOP_Weighting_Loadcell2";
            string tagID_83 = "Channel1.Device1.START_Weighting_Loadcell2";
            //Hiển thị dữ liệu trên DataGridView
            string tagID_84 = "Channel1.Device1.Report_Trigger_Bunke1";
            string tagID_85 = "Channel1.Device1.Report_Trigger_Bunke2";


            // Ghi giá trị tag vào các tagnumber
            string[] tags;
            tags = new string[tagnumber];
            tags.SetValue(tagID_1, 1);
            tags.SetValue(tagID_2, 2);
            tags.SetValue(tagID_3, 3);
            tags.SetValue(tagID_4, 4);
            tags.SetValue(tagID_5, 5);
            tags.SetValue(tagID_6, 6);
            tags.SetValue(tagID_7, 7);
            tags.SetValue(tagID_8, 8);
            tags.SetValue(tagID_9, 9);
            tags.SetValue(tagID_10, 10);
            tags.SetValue(tagID_11, 11);
            tags.SetValue(tagID_12, 12);
            tags.SetValue(tagID_13, 13);
            tags.SetValue(tagID_14, 14);
            tags.SetValue(tagID_15, 15);
            tags.SetValue(tagID_16, 16);
            tags.SetValue(tagID_17, 17);
            tags.SetValue(tagID_18, 18);
            tags.SetValue(tagID_19, 19);
            tags.SetValue(tagID_20, 20);
            tags.SetValue(tagID_21, 21);
            tags.SetValue(tagID_22, 22);
            tags.SetValue(tagID_23, 23);
            tags.SetValue(tagID_24, 24);
            tags.SetValue(tagID_25, 25);
            tags.SetValue(tagID_26, 26);
            tags.SetValue(tagID_27, 27);
            tags.SetValue(tagID_28, 28);
            tags.SetValue(tagID_29, 29);
            tags.SetValue(tagID_30, 30);
            tags.SetValue(tagID_31, 31);
            tags.SetValue(tagID_32, 32);
            tags.SetValue(tagID_33, 33);
            tags.SetValue(tagID_34, 34);
            tags.SetValue(tagID_35, 35);
            tags.SetValue(tagID_36, 36);
            tags.SetValue(tagID_37, 37);
            tags.SetValue(tagID_38, 38);
            tags.SetValue(tagID_39, 39);
            tags.SetValue(tagID_40, 40);
            tags.SetValue(tagID_41, 41);
            tags.SetValue(tagID_42, 42);
            tags.SetValue(tagID_43, 43);
            tags.SetValue(tagID_44, 44);
            tags.SetValue(tagID_45, 45);
            tags.SetValue(tagID_46, 46);
            tags.SetValue(tagID_47, 47);
            tags.SetValue(tagID_48, 48);
            tags.SetValue(tagID_49, 49);
            tags.SetValue(tagID_50, 50);
            tags.SetValue(tagID_51, 51);
            tags.SetValue(tagID_52, 52);
            tags.SetValue(tagID_53, 53);
            tags.SetValue(tagID_54, 54);
            tags.SetValue(tagID_55, 55);
            tags.SetValue(tagID_56, 56);
            tags.SetValue(tagID_57, 57);
            tags.SetValue(tagID_58, 58);
            tags.SetValue(tagID_59, 59);
            tags.SetValue(tagID_60, 60);
            tags.SetValue(tagID_61, 61);
            tags.SetValue(tagID_62, 62);
            tags.SetValue(tagID_63, 63);
            tags.SetValue(tagID_64, 64);
            tags.SetValue(tagID_65, 65);
            tags.SetValue(tagID_66, 66);
            tags.SetValue(tagID_67, 67);
            tags.SetValue(tagID_68, 68);
            tags.SetValue(tagID_69, 69);
            tags.SetValue(tagID_70, 70);
            tags.SetValue(tagID_71, 71);
            tags.SetValue(tagID_72, 72);
            tags.SetValue(tagID_73, 73);
            tags.SetValue(tagID_74, 74);
            tags.SetValue(tagID_75, 75);
            tags.SetValue(tagID_76, 76);
            tags.SetValue(tagID_77, 77);
            tags.SetValue(tagID_78, 78);
            tags.SetValue(tagID_79, 79);
            tags.SetValue(tagID_80, 80);
            tags.SetValue(tagID_81, 81);
            tags.SetValue(tagID_82, 82);
            tags.SetValue(tagID_83, 83);
            tags.SetValue(tagID_84, 84);
            tags.SetValue(tagID_85, 85);
            tags.SetValue(tagID_86, 86);
            tags.SetValue(tagID_87, 87);
            return tags;
        }
        // Class tạo array đọc ID tags - mặc định không đổi
        public static Int32[] tagID(int tagnumber)
        {
            Int32[] cltarr;
            cltarr = new Int32[tagnumber];
            for (int i = 1; i < tagnumber; i++)
            {
                cltarr.SetValue(i, i);
            }
            return cltarr;
        }
    }
}

