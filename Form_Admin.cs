using Giaodiendieukhien.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;
using Giaodiendieukhien.UserControls;
using DoAnChiaDongThan;
using System.Reflection;
using System.Threading;

namespace Giaodiendieukhien
{
    public partial class Form_Admin : Form
    {
        public static Form_Admin frmAdmin;
        public bool IsTimerUCSystemRunning = false;
        public bool IsTimerUCWatchRunning = false;
        public bool ISUCIORunning = false;
        public bool ISUCWatchRunning = false;
        public bool ISTimerUCSimRunning = false;
        public bool LoadDatatoPLC = false;
        public string tag13value;       //Stepmotor 1 chạy thuận
        public string tag15value;       //Stepmotor 2 chạy thuận
        public string tag17value;       //Trạng thái Bunke 1
        public string tag18value;       //Trạng thái Bunke 2
        public string tag19value;       //Trạng thái Bunke 3
        public string tag76value;       //Trạng thái cảm biến tiệm cận điện dung
        public string tag25value;       //Thông số cân nặng Loadcell 1
        public string tag26value;       //Thông số cân nặng Loadcell 2
        public string tag27value;       //Giá trị tín hiệu Băng tải 1
        public string tag28value;       //Giá trị tín hiệu Băng tải 2
        public string tag29value;       //Giá trị tín hiệu Hệ thống
        public string tag44value;       //Giá trị Max của Loadcell1
        public string tag45value;       //Giá trị Max của Loadcell2
        public string tag68value;
        public string tag69value;
        public string tag70value;
        public string tag71value;
        public string tag72value;
        public string tag73value;
        public string tag74value;
        public string tag75value;
        public string tag77value;       //Giá trị Analog Input của Loadcell 1
        public string tag78value;       //Giá trị Analog Input của Loadcell 2
        public string tag79value;       //Giá trị tín hiệu Error
        public string tag80value;       //Dừng cân loadcell 1
        public string tag81value;       //Chạy cân loadcell 1
        public string tag82value;       //Dừng cân loadcell 2
        public string tag83value;       //Chạy cân loadcell 2
        Status_Display statusdisplay = new Status_Display();

        public Form_Admin()
        {
            InitializeComponent();
            frmAdmin = this;
        }
        public string Watchdog_Value = "";

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            timer1.Start(); //Timer hiển thị ngày giờ.
            add_usercontrol(new UC_Dieukhien()); //Khởi chạy UC_Dieukhien khi vào Form1
            KEPServerEX_Connect(); // Kết nối với PLC
            Loaddata();
            Timer_Watchdog.Interval = Properties.Settings.Default.PLC_Timeout;
        }
        //========================================KEPServerEX CONNECT======================================
        static int tagNumber = 85;       // Cài đặt số lượng tag của project
        static int PLCscantime = Properties.Settings.Default.PLC_Scantime;  // Cài đặt thời gian quét PLC

        // Gọi các kết nối OPC
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;
        public string Groupname;

        static int arrlength = tagNumber + 1;
        Array OPtags = class_KEPServerEX.tagread(arrlength);
        Array tagID = class_KEPServerEX.tagID(arrlength);
        Array WriteItems = Array.CreateInstance(typeof(object), arrlength);
        Array tagHandles = Array.CreateInstance(typeof(Int32), arrlength);
        Array OPCError = Array.CreateInstance(typeof(Int32), arrlength);
        Array dataType = Array.CreateInstance(typeof(Int16), arrlength);
        Array AccessPaths = Array.CreateInstance(typeof(string), arrlength);
        // Chương trình con kết nối (Connect)
        public void KEPServerEX_Connect()
        {
            string IOServer = "Kepware.KEPServerEX.V6";
            string IOGroup = "OPCGroup1";
            OPCServer = new OPCAutomation.OPCServer();
            OPCServer.Connect(IOServer, "");
            PLC = OPCServer.OPCGroups.Add(IOGroup);
            PLC.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(dataScan);
            PLC.UpdateRate = PLCscantime;
            PLC.IsSubscribed = PLC.IsActive;
            PLC.OPCItems.DefaultIsActive = true;
            PLC.OPCItems.AddItems(tagNumber, ref OPtags, ref tagID,
                 out tagHandles, out OPCError, dataType, AccessPaths);
        }
        private void dataScan(int ID, int NumItems, ref Array tagID,
             ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                // lấy giá trị tag\
                if (getTagID == 1) // Giá trị Watchdog
                {
                    Watchdog_Value = tagValue;
                }
                if (getTagID == 13) // Stepmotor 01 chạy thuận
                {
                    tag13value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusStepmotor01.Text = "Down";
                        UC_Dieukhien.UCControl.lbStatusStepmotor01.ForeColor = Color.Green;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Gạt than 1";
                        string data3 = "Chạy thuận";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 14) // Stepmotor 01 chạy nghịch
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusStepmotor01.Text = "Up";
                        UC_Dieukhien.UCControl.lbStatusStepmotor01.ForeColor = Color.Red;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Gạt than 1";
                        string data3 = "Chạy nghịch";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 15) // Stepmotor 02 chạy thuận
                {
                    tag15value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusStepmotor02.Text = "Down";
                        UC_Dieukhien.UCControl.lbStatusStepmotor02.ForeColor = Color.Green;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Gạt than 2";
                        string data3 = "Chạy thuận";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 16) // Stepmotor 02 chạy nghịch
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusStepmotor02.Text = "Up";
                        UC_Dieukhien.UCControl.lbStatusStepmotor02.ForeColor = Color.Red;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Gạt than 2";
                        string data3 = "Chạy nghịch";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 17) // Trạng thái Bunke 1
                {
                    tag17value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusBunke1.Text = "Full";
                        UC_Dieukhien.UCControl.lbStatusBunke1.ForeColor = Color.Red;
                        //ucwatch.txtBoxStatusBunke1.Text = "Full";
                        //ucwatch.txtBoxStatusBunke1.ForeColor = Color.Red;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Loadcell 1";
                        string data3 = "Max";
                        string data4 = "Giá trị đọc" + tag25value;

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.lbStatusBunke1.Text = "Not Full";
                        UC_Dieukhien.UCControl.lbStatusBunke1.ForeColor = Color.Green;
                        //ucwatch.txtBoxStatusBunke1.Text = "Not Full";
                        //ucwatch.txtBoxStatusBunke1.ForeColor = Color.Green;
                    }
                }
                if (getTagID == 18) // Trạng thái bunke 2
                {
                    tag18value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusBunke2.Text = "Full";
                        UC_Dieukhien.UCControl.lbStatusBunke2.ForeColor = Color.Red;
                        //ucwatch.txtBoxStatusBunke2.Text = "Full";
                        //ucwatch.txtBoxStatusBunke2.ForeColor = Color.Red;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.lbStatusBunke2.Text = "Not Full";
                        UC_Dieukhien.UCControl.lbStatusBunke2.ForeColor = Color.Green;
                        //ucwatch.txtBoxStatusBunke2.Text = "Not Full";
                        //ucwatch.txtBoxStatusBunke2.ForeColor = Color.Green;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Loadcell 2";
                        string data3 = "Max";
                        string data4 = "Giá trị max" + tag26value;

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 19) // Trạng thái Bunke 3
                {
                    tag19value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusBunke3.Text = "Full";
                        UC_Dieukhien.UCControl.lbStatusBunke3.ForeColor = Color.Red;
                        //ucwatch.txtBoxStatusBunke3.Text = "Full";
                        //ucwatch.txtBoxStatusBunke3.ForeColor = Color.Red;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.lbStatusBunke3.Text = "Not Full";
                        UC_Dieukhien.UCControl.lbStatusBunke3.ForeColor = Color.Green;
                        //ucwatch.txtBoxStatusBunke3.Text = "Not Full";
                        //ucwatch.txtBoxStatusBunke3.ForeColor = Color.Green;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Bunke 3";
                        string data3 = "Đã đầy";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 20) //Tín hiệu đèn Auto
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.symbLampAuto.DiscreteValue1 = true;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.symbLampAuto.DiscreteValue1 = false;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Tín hiệu Auto";
                        string data3 = "Kích hoạt";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 21)     //Tín hiệu đèn Manual
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.symbLampMan.DiscreteValue1 = true;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.symbLampMan.DiscreteValue1 = false;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Tín hiệu Manual";
                        string data3 = "Kích hoạt";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 22)     //Tín hiệu đèn Dừng Khẩn cấp
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.symbLampStopEMS.DiscreteValue1 = true;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.symbLampStopEMS.DiscreteValue1 = false;

                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Kích hoạt";
                        string data4 = "Dừng khẩn cấp";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 23)     //Tín hiệu đèn Reset phòng điều khiển
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.symbLampResetIn.DiscreteValue1 = true;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.symbLampResetIn.DiscreteValue1 = false;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Reset";
                        string data4 = "Reset phòng điều khiển";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 24)     //Tín hiệu Reset tủ điện
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.symbLampResetOut.DiscreteValue1 = true;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.symbLampResetOut.DiscreteValue1 = false;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Reset";
                        string data4 = "Reset tủ điện";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 25)     //Thông số Loadcell 1
                {
                    tag25value = tagValue;
                    UC_Dieukhien.UCControl.txtBoxLoadcell1.Text = tagValue;
                }
                if (getTagID == 26)     //Thông số Loadcell 2
                {
                    tag26value = tagValue;
                    UC_Dieukhien.UCControl.txtBoxLoadcell2.Text = tagValue;
                }
                if (getTagID == 27)     //Tín hiệu đèn Băng tải 1
                {
                    tag27value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusC1.Text = "Running";
                        UC_Dieukhien.UCControl.lbStatusC1.ForeColor = Color.Green;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.lbStatusC1.Text = "Stopped";
                        UC_Dieukhien.UCControl.lbStatusC1.ForeColor = Color.Red;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Băng tải 1";
                        string data3 = "Khởi động";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                    else if (tagValue == "False")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Băng tải 1";
                        string data3 = "Dừng chạy";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 28)     //Tín hiệu đèn Băng tải 2
                {
                    tag28value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusC2.Text = "Running";
                        UC_Dieukhien.UCControl.lbStatusC2.ForeColor = Color.Green;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.lbStatusC2.Text = "Stopped";
                        UC_Dieukhien.UCControl.lbStatusC2.ForeColor = Color.Red;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Băng tải 2";
                        string data3 = "Khởi động";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                    else if (tagValue == "False")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Băng tải 2";
                        string data3 = "Dừng chạy";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 29)     //Tín hiệu đèn Hệ thống
                {
                    tag29value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.symbLampSystemRunning.DiscreteValue1 = true;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.symbLampSystemRunning.DiscreteValue1 = false;
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Hệ thống";
                        string data3 = "Khởi động";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                    else if (tagValue == "False")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Hệ thống";
                        string data3 = "Dừng hoạt động";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 44)     //Giá trị tối đa của Loadcell 1
                {
                    tag44value = tagValue;
                    //ucwatch.txtBoxLoadcell1Max.Text = tagValue;
                }
                if (getTagID == 45)     //Giá trị tối đa của Loadcell 2
                {
                    tag45value = tagValue;
                    //ucwatch.txtBoxLoadcell2Max.Text = tagValue;
                }
                if (getTagID == 68)
                {
                    tag68value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSimError, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error Simulation";
                        string data3 = "Kích hoạt";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 69)
                {
                    tag69value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSimLoadcell, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Loadcells Simulation";
                        string data3 = "Kích hoạt";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 70)
                {
                    tag70value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampPullC1, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Simulation";
                        string data4 = "Cảm biến giật dây băng tải 1";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 71)
                {
                    tag71value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampPullC2, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Simulation";
                        string data4 = "Cảm biến giật dây băng tải 2";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 72)
                {
                    tag72value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSwayC1, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Simulation";
                        string data4 = "Cảm biến lệch băng băng tải 1";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 73)
                {
                    tag73value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSwayC2, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Simulation";
                        string data4 = "Cảm biến lệch băng băng tải 2";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 74)
                {
                    tag74value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampOLC1, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Simulation";
                        string data4 = "Cảm biến quá tải băng tải 1";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 75)
                {
                    tag75value = tagValue;
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampOLC2, tagValue);
                    }
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Error";
                        string data3 = "Simulation";
                        string data4 = "Cảm biến quá tải băng tải 2";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 76)
                {
                    tag76value = tagValue;
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Bunke3_data";
                        string collum1 = "date_time";
                        string collum2 = "sensor_status";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "ĐÃ ĐẦY";

                        class_Database.cmd_SQLWrite(sqltable_name,
                            collum1, data1,
                            collum2, data2);
                    }
                    else if (tagValue == "False")
                    {
                        string sqltable_name = "Bunke3_data";
                        string collum1 = "date_time";
                        string collum2 = "sensor_status";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "CHƯA ĐẦY";

                        class_Database.cmd_SQLWrite(sqltable_name,
                            collum1, data1,
                            collum2, data2);
                    }
                }

                if (getTagID == 77)
                {
                    tag77value = tagValue;                                      
                }
                if (getTagID == 78)
                {
                    tag78value = tagValue;
                }
                if (getTagID == 79)
                {
                    tag79value = tagValue;
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.symbLampErrorSignal.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;
                    }
                    else
                    {
                        UC_Dieukhien.UCControl.symbLampErrorSignal.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
                    }
                }
                if (getTagID == 80)
                {
                    tag80value = tagValue;
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Loadcell 1";
                        string data3 = "Dừng cân";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 81)
                {
                    tag81value = tagValue;
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Loadcell 1";
                        string data3 = "Chạy cân";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 82)
                {
                    tag82value = tagValue;
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Loadcell 2";
                        string data3 = "Dừng cân";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 83)
                {
                    tag83value = tagValue;
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Devices_data";
                        string column1 = "date_time";
                        string column2 = "device_name";
                        string column3 = "device_status";
                        string column4 = "note";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = "Loadcell 2";
                        string data3 = "Chạy cân";
                        string data4 = "";

                        class_Database.cmd_SQLWrite1(sqltable_name,
                            column1, data1,
                            column2, data2,
                            column3, data3,
                            column4, data4);
                    }
                }
                if (getTagID == 84)
                {
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Bunke1_data";
                        string collum1 = "date_time";
                        string collum2 = "data_loadcell1";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = tag25value;

                        class_Database.cmd_SQLWrite(sqltable_name,
                            collum1, data1,
                            collum2, data2);
                    }
                }
                if (getTagID == 85)
                {
                    if (tagValue == "True")
                    {
                        string sqltable_name = "Bunke2_data";
                        string collum1 = "date_time";
                        string collum2 = "data_loadcell1";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = tag26value;

                        class_Database.cmd_SQLWrite(sqltable_name,
                            collum1, data1,
                            collum2, data2);
                    }
                }

            }
        }
        // Gửi giá trị Boolean từ C# lên KEPServerEX khu vực UC_Dieukhien
        public void Button_PLC_Clicked(int tagValue)
        {
            WriteItems.SetValue(1, tagValue);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, tagValue);
        }
        private void add_usercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMainAF.Controls.Clear();
            pnlMainAF.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void bringtofront_usercontrol(UserControl btfUserControl)
        {
            pnlMainAF.Controls.Clear();
            pnlMainAF.Controls.Add(btfUserControl);
            btfUserControl.BringToFront();
        }
        private void click_Button(object sender, EventArgs e)
        {
            foreach (var pnl in pnlTabsAF.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.White;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnMonitorAF":
                    Timer_Stop.TimerStop();
                    if (UC_Giamsat.UCWatch != null)
                    {
                        bringtofront_usercontrol(UC_Giamsat.UCWatch);
                        UC_Giamsat.UCWatch.RunTimer();
                    }
                    else
                    {
                        add_usercontrol(new UC_Giamsat());
                        ISUCWatchRunning = true;
                    }
                    pnlMonitorAF.BackColor = Color.Lime;
                    break;
                case "btnControlAF":
                    Timer_Stop.TimerStop();
                    if (UC_Dieukhien.UCControl != null)
                    {
                        bringtofront_usercontrol(UC_Dieukhien.UCControl);
                    }
                    else
                    {
                        add_usercontrol(new UC_Dieukhien());
                    }

                    pnlControlAF.BackColor = Color.Lime;
                    break;
                case "btnReportAF":
                    Timer_Stop.TimerStop();
                    if (UC_Baocao.UCReport != null)
                    {
                        bringtofront_usercontrol(UC_Baocao.UCReport);
                    }
                    else
                    {
                        add_usercontrol(new UC_Baocao());
                    }
                    pnlReportAF.BackColor = Color.Lime;
                    break;
                case "btnSettingAF":
                    Timer_Stop.TimerStop();
                    if (UC_Caidat.UCSettings != null)
                    {
                        bringtofront_usercontrol(UC_Caidat.UCSettings);
                    }
                    else
                    {
                        add_usercontrol(new UC_Caidat());
                    }
                    pnlSettingAF.BackColor = Color.Lime;
                    break;
                case "btnSystemAF":
                    Timer_Stop.TimerStop();
                    if (UC_Hethong.UCSystem != null)
                    {
                        bringtofront_usercontrol(UC_Hethong.UCSystem);
                        UC_Hethong.UCSystem.RunTimer();
                    }
                    else
                    {
                        add_usercontrol(new UC_Hethong());
                    }
                    pnlSystemAF.BackColor = Color.Lime;
                    break;
                case "btnIOAF":
                    Timer_Stop.TimerStop();
                    if (UC_IO.UCIO != null)
                    {
                        bringtofront_usercontrol(UC_IO.UCIO);
                    }
                    else
                    {
                        add_usercontrol(new UC_IO());
                        ISUCIORunning = true;
                    }
                    pnlIOAF.BackColor = Color.Lime;
                    break;
                case "btnSimAF":
                    Timer_Stop.TimerStop();
                    if (UC_Simulation.UCSim != null)
                    {
                        bringtofront_usercontrol(UC_Simulation.UCSim);
                    }
                    else
                    {
                        add_usercontrol(new UC_Simulation());
                    }                   
                    pnlSimAF.BackColor = Color.Lime;
                    break;
                default:
                    break;
            }
        }
        private void btnCloseappAF_Click(object sender, EventArgs e)
        {
            DialogResult CConfirm = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CConfirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnMinimizeAF_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (UC_Simulation.UCSim != null)
            {
                UC_Simulation.UCSim.symbLampSystem.DiscreteValue1 = UC_Dieukhien.UCControl.symbLampSystemRunning.DiscreteValue1; //Thay đổi trạng thái đèn báo mở hệ thống ở UC_Simulation
            }
            if (ISUCIORunning == true && UC_IO.UCIO.IOStatus == true)
            {
                UC_IO.UCIO.timer1.Enabled = true;
            }
            if (LoadDatatoPLC == false && lbPLCStatusAF.Text == "Đã kết nối")
            {
                Loaddata();
                LoadDatatoPLC = true;
            }
            DateTime dataTime = DateTime.Now;   
            this.lbTime.Text = dataTime.ToString(); //Hiển thị thời gian thực.
        }
        private void Timer_Watchdog_Tick(object sender, EventArgs e)
        {
            class_Watchdog.WatchdogStatus(lbPLCStatusAF, Watchdog_Value);
            if (UC_Hethong.UCSystem != null)
            {
                UC_Hethong.UCSystem.lbPLCStatus.Text = lbPLCStatusAF.Text;
                UC_Hethong.UCSystem.lbPLCStatus.ForeColor = lbPLCStatusAF.ForeColor;
            }    
        }
        private void Reconnect_Timer_Tick(object sender, EventArgs e)       //Thời gian PLC tự động kết nối lại khi bị mất kết nối
        {
            Reconnect_Timer.Interval = Properties.Settings.Default.PLC_Reconnect_Time;
            if (UC_Hethong.UCSystem.IsDisconnectPLCPressed == false && lbPLCStatusAF.Text == "Ngắt kết nối")
            {
                KEPServerEX_Connect();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult LogoutConfirm = MessageBox.Show("Bạn có muốn đăng xuất không ?","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(LogoutConfirm == DialogResult.Yes)
            {
                this.Hide();
                Form_Login loginform = new Form_Login();
                loginform.ShowDialog();
                LoadDatatoPLC = false;
                this.Close();
            }
        }


        private void Loaddata() //Tải data từ Data C# xuống PLC
        {
            WriteItems.SetValue(Properties.Settings.Default.StartAutoTime_C1.ToString(), 30);
            WriteItems.SetValue(Properties.Settings.Default.StartAutoTime_C2.ToString(), 31);
            WriteItems.SetValue(Properties.Settings.Default.StopAutoTime_C1.ToString(), 32);
            WriteItems.SetValue(Properties.Settings.Default.StopAutoTime_C2.ToString(), 33);
            WriteItems.SetValue(Properties.Settings.Default.StartManTime_C1.ToString(), 34);
            WriteItems.SetValue(Properties.Settings.Default.StartManTime_C2.ToString(), 35);
            WriteItems.SetValue(Properties.Settings.Default.StopManTime_C1.ToString(), 36);
            WriteItems.SetValue(Properties.Settings.Default.StopManTime_C2.ToString(), 37);
            WriteItems.SetValue(Properties.Settings.Default.Stepmotor01_Thuan_Position.ToString(), 38);
            WriteItems.SetValue(Properties.Settings.Default.Stepmotor01_Nghich_Position.ToString(), 39);
            WriteItems.SetValue(Properties.Settings.Default.Stepmotor02_Thuan_Position.ToString(), 40);
            WriteItems.SetValue(Properties.Settings.Default.Stepmotor02_Nghich_Position.ToString(), 41);
            WriteItems.SetValue(Properties.Settings.Default.Stepmotor01_Speed.ToString(), 42);
            WriteItems.SetValue(Properties.Settings.Default.Stepmotor02_Speed.ToString(), 43);
            WriteItems.SetValue(Properties.Settings.Default.Loadcell1_Max.ToString(), 44);
            WriteItems.SetValue(Properties.Settings.Default.Loadcell2_Max.ToString(), 45);
            WriteItems.SetValue(Properties.Settings.Default.Loadcell1_AutoZeroingTime.ToString(), 46);
            WriteItems.SetValue(Properties.Settings.Default.Loadcell2_AutoZeroingTime.ToString(), 47);
            WriteItems.SetValue(Properties.Settings.Default.Loadcell1_AutoZeroingWeight.ToString(), 48);
            WriteItems.SetValue(Properties.Settings.Default.Loadcell2_AutoZeroingWeight.ToString(), 49);

            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        public void LoaddataUC(string tb, int tagValue) //Tải data nhận được từ UserControl xuống PLC
        {
            WriteItems.SetValue(tb, tagValue);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

    }
}
