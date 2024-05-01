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
            //-----------------------Nút bấm Manual--------------------------
            string tagID_1 = "Channel1.Device1.Open_Van1";
            string tagID_2 = "Channel1.Device1.Close_Van1";
            string tagID_3 = "Channel1.Device1.Open_Van2";
            string tagID_4 = "Channel1.Device1.Close_Van2";
            string tagID_5 = "Channel1.Device1.Open_Van3";
            string tagID_6 = "Channel1.Device1.Close_Van3";
            string tagID_7 = "Channel1.Device1.Open_Conveyor1";
            string tagID_8 = "Channel1.Device1.Close_Conveyor1";
            string tagID_9 = "Channel1.Device1.Open_Conveyor2";
            string tagID_10 = "Channel1.Device1.Close_Conveyor2";
            string tagID_11 = "Channel1.Device1.Gatthan_Up1";
            string tagID_12 = "Channel1.Device1.Gatthan_Down1";
            string tagID_13 = "Channel1.Device1.Gatthan_Up2";
            string tagID_14 = "Channel1.Device1.Gatthan_Down2";
            //------------------------Nút bấm vật lý-------------------------
            string tagID_18 = "Channel1.Device1.Emergency_Button";
            string tagID_19 = "Channel1.Device1.Reset_Button";
            //---------------------Trạng thái (Output)-----------------------
            string tagID_15 = "Channel1.Device1.ManualStatus";
            string tagID_16 = "Channel1.Device1.AutoStatus";
            string tagID_17 = "Channel1.Device1.EmergencyStatus";
            string tagID_20 = "Channel1.Device1.Van1_Status";
            string tagID_21 = "Channel1.Device1.Van2_Status";
            string tagID_22 = "Channel1.Device1.Van3_Status";
            string tagID_23 = "Channel1.Device1.Conveyor1_Status";
            string tagID_24 = "Channel1.Device1.Conveyor2_Status";
            string tagID_25 = "Channel1.Device1.Gatthan1_Status";
            string tagID_26 = "Channel1.Device1.Gatthan2_Status";
            //---------------------------Input-------------------------------
            string tagID_27 = "Channel1.Device1.Loadcell1";
            string tagID_28 = "Channel1.Device1.Loadcell2";
            string tagID_29 = "Channel1.Device1.Loadcell3";
            //-------------------------Kết nối PLC---------------------------
            string tagID_30 = "Channel1.Device1.Watchdog";
            string tagID_31 = "Channel1.Device1.Report_Trigger";

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

