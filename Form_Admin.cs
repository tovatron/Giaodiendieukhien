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
        public bool ISUCIORunning = false;
        private float loadcell1value;
        private float loadcell2value;
        public string tag13value;
        public string tag15value;
        public string tag76value;
        public string tag25value;       //Thông số cân nặng Loadcell 1
        public string tag26value;       //Thông số cân nặng Loadcell 2
        public string tag27value;       //Giá trị tín hiệu Băng tải 1
        public string tag28value;       //Giá trị tín hiệu Băng tải 2
        public string tag29value;       //Giá trị tín hiệu Hệ thống
        public string tag44value;       //Giá trị Max của Loadcell1
        public string tag45value;       //Giá trị Max của Loadcell2
        public string tag77value;       //Giá trị Analog Input của Loadcell 1
        public string tag78value;       //Giá trị Analog Input của Loadcell 2
        public string tag79value;       //Giá trị tín hiệu Error
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
        static int tagNumber = 79;       // Cài đặt số lượng tag của project
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
                }
                if (getTagID == 14) // Stepmotor 01 chạy nghịch
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusStepmotor01.Text = "Up";
                        UC_Dieukhien.UCControl.lbStatusStepmotor01.ForeColor = Color.Red;
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
                }
                if (getTagID == 16) // Stepmotor 02 chạy nghịch
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusStepmotor02.Text = "Up";
                        UC_Dieukhien.UCControl.lbStatusStepmotor02.ForeColor = Color.Red;
                    }
                }
                if (getTagID == 17) // Trạng thái Bunke 1
                {
                    if (tagValue == "True")
                    {
                        UC_Dieukhien.UCControl.lbStatusBunke1.Text = "Full";
                        UC_Dieukhien.UCControl.lbStatusBunke1.ForeColor = Color.Red;
                        //ucwatch.txtBoxStatusBunke1.Text = "Full";
                        //ucwatch.txtBoxStatusBunke1.ForeColor = Color.Red;
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
                }
                if (getTagID == 19) // Trạng thái Bunke 3
                {
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
                }
                if (getTagID == 25)     //Thông số Loadcell 1
                {
                    tag25value = tagValue;
                    UC_Dieukhien.UCControl.txtBoxLoadcell1.Text = tagValue;
                    //ucwatch.txtBoxBunke1Weight.Text = tagValue;
                }
                if (getTagID == 26)     //Thông số Loadcell 2
                {
                    tag26value = tagValue;
                    UC_Dieukhien.UCControl.txtBoxLoadcell2.Text = tagValue;
                    //ucwatch.txtBoxBunke2Weight.Text = tagValue;
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
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSimError, tagValue);
                    }
                }
                if (getTagID == 69)
                {
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSimLoadcell, tagValue);
                    }
                }
                if (getTagID == 70)
                {
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampPullC1, tagValue);
                    }
                }
                if (getTagID == 71)
                {
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampPullC2, tagValue);
                    }
                }
                if (getTagID == 72)
                {
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSwayC1, tagValue);
                    }
                }
                if (getTagID == 73)
                {
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampSwayC2, tagValue);
                    }
                }
                if (getTagID == 74)
                {
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampOLC1, tagValue);
                    }
                }
                if (getTagID == 75)
                {
                    if (UC_Simulation.UCSim != null)
                    {
                        statusdisplay.stt_Lamp(UC_Simulation.UCSim.symbLampOLC2, tagValue);
                    }
                }
                if (getTagID == 76)
                {
                    tag76value = tagValue;
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
                    }
                    else
                    {
                        add_usercontrol(new UC_Giamsat());
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
            if (UC_Hethong.UCSystem.IsDisconnectPLCPressed == false && UC_Hethong.UCSystem.lbPLCStatus.Text == "Ngắt kết nối")
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
