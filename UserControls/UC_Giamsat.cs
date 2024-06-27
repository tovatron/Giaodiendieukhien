using Giaodiendieukhien.Sources;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Giaodiendieukhien
{
    public partial class UC_Giamsat : UserControl
    {
        //Khai báo 2 line trên đồ thị
        LineItem line1;
        LineItem line2;
        //Thông số của các line hiển thị trên đồ thị
        RollingPointPairList listvalue1;
        RollingPointPairList listvalue2;
        int TickStart;
        //Chế độ nhìn của Đồ thị
        public static UC_Giamsat UCWatch;
        public UC_Giamsat()
        {
            InitializeComponent();
            UCWatch = this;
        }

        private void UC_Giamsat_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer_showdata.Enabled = true;
            TickStart = Environment.TickCount;          //Bắt đầu đếm từ thời điểm hệ thống chạy
            KhoitaoZedgraph();
        }
        private void KhoitaoZedgraph()      //Khởi tạo Đồ thị
        {
            GraphPane graphPane = zgchartBunkes.GraphPane;
            graphPane.Title.Text = "Biểu đồ giá trị khối lượng Bunke 1, 2";         //Đặt tên cho biểu đồ
            graphPane.YAxis.Title.Text = "Khối lượng";                              //Tên trục Y
            graphPane.XAxis.Title.Text = "Thời gian";                               //Tên trục X

            listvalue1 = new RollingPointPairList(5000);                            //Hiển thị tối đa 5000 điểm
            listvalue2 = new RollingPointPairList(5000);

            line1 = graphPane.AddCurve("Khối lượng Bunke 1", listvalue1, Color.Blue, SymbolType.None);              //Kiểu đường line.
            line2 = graphPane.AddCurve("Khối lượng Bunke 2", listvalue2, Color.Black, SymbolType.None);

            graphPane.YAxis.Scale.Min = 0;              //Min Y
            graphPane.YAxis.Scale.Max = 1000;           //Max Y
            graphPane.YAxis.Scale.MinorStep = 0;
            graphPane.YAxis.Scale.MajorStep = 100;



            graphPane.XAxis.Scale.Min = 0;              //Min X
            graphPane.XAxis.Scale.Max = 30;             //Max Y
            graphPane.XAxis.Scale.MinorStep = 1;
            graphPane.XAxis.Scale.MajorStep = 5;

            zgchartBunkes.AxisChange();
        }
        // Vẽ đường đồ thị theo thời gian theo các giá trị từ PLC trả về
        public void Draw(float loadcell1, float loadcell2)
        {
            line1 = zgchartBunkes.GraphPane.CurveList[0] as LineItem;
            line2 = zgchartBunkes.GraphPane.CurveList[1] as LineItem;
            if (line1 == null || line2 == null)
                return;
            IPointListEdit listvalue1 = line1.Points as IPointListEdit;
            IPointListEdit listvalue2 = line2.Points as IPointListEdit;
            if (listvalue1 == null || listvalue2 == null)
                return;
            double time = (Environment.TickCount - TickStart) / 1000.0;
            listvalue1.Add(time, loadcell1);
            listvalue2.Add(time, loadcell2);
            Scale xScale = zgchartBunkes.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30.0;
            }
            zgchartBunkes.AxisChange();
            zgchartBunkes.Invalidate();
        }
        public void StopTimer()            //Dừng Timer
        {
            timer1.Stop();
            timer1.Dispose();
            timer_showdata.Stop();
            timer_showdata.Dispose();
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.IsTimerUCWatchRunning = false;
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.IsTimerUCWatchRunning = false;
            }

        }
        public void RunTimer()              //Chạy timer
        {
            timer1.Start();
            timer_showdata.Start();
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.IsTimerUCWatchRunning = true;
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.IsTimerUCWatchRunning = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)        //Timer cập nhật trạng thái Bunke và vẽ đồ thị theo thời gian
        {
            if (Form_Admin.frmAdmin != null)
            {
                if (Form_Admin.frmAdmin.tag17value == "True")
                {
                    txtBoxStatusBunke1.Text = "Full";
                    txtBoxStatusBunke1.ForeColor = Color.Red;
                }
                else
                {
                    txtBoxStatusBunke1.Text = "Not Full";
                    txtBoxStatusBunke1.ForeColor = Color.Green;
                }

                if (Form_Admin.frmAdmin.tag18value == "True")
                {
                    txtBoxStatusBunke2.Text = "Full";
                    txtBoxStatusBunke2.ForeColor = Color.Red;
                }
                else
                {
                    txtBoxStatusBunke2.Text = "Not Full";
                    txtBoxStatusBunke2.ForeColor = Color.Green;
                }

                if (Form_Admin.frmAdmin.tag19value == "True")
                {
                    txtBoxStatusBunke3.Text = "Full";
                    txtBoxStatusBunke3.ForeColor = Color.Red;
                }
                else
                {
                    txtBoxStatusBunke3.Text = "Not Full";
                    txtBoxStatusBunke3.ForeColor = Color.Green;
                }
                txtBoxBunke1Weight.Text = Form_Admin.frmAdmin.tag25value;
                txtBoxBunke2Weight.Text = Form_Admin.frmAdmin.tag26value;
                txtBoxLoadcell1Max.Text = Form_Admin.frmAdmin.tag44value;
                txtBoxLoadcell2Max.Text = Form_Admin.frmAdmin.tag45value;
                if (Form_Admin.frmAdmin.tag25value != null || Form_Admin.frmAdmin.tag26value != null)
                {
                    Draw(float.Parse(Form_Admin.frmAdmin.tag25value), float.Parse(Form_Admin.frmAdmin.tag26value));
                }
            }
            else if (Form_User.frmUser != null)
            {
                if (Form_User.frmUser.tag17value == "True")
                {
                    txtBoxStatusBunke1.Text = "Full";
                    txtBoxStatusBunke1.ForeColor = Color.Red;
                }
                else
                {
                    txtBoxStatusBunke1.Text = "Not Full";
                    txtBoxStatusBunke1.ForeColor = Color.Green;
                }

                if (Form_User.frmUser.tag18value == "True")
                {
                    txtBoxStatusBunke2.Text = "Full";
                    txtBoxStatusBunke2.ForeColor = Color.Red;
                }
                else
                {
                    txtBoxStatusBunke2.Text = "Not Full";
                    txtBoxStatusBunke2.ForeColor = Color.Green;
                }

                if (Form_User.frmUser.tag19value == "True")
                {
                    txtBoxStatusBunke3.Text = "Full";
                    txtBoxStatusBunke3.ForeColor = Color.Red;
                }
                else
                {
                    txtBoxStatusBunke3.Text = "Not Full";
                    txtBoxStatusBunke3.ForeColor = Color.Green;
                }
                txtBoxBunke1Weight.Text = Form_User.frmUser.tag25value;
                txtBoxBunke2Weight.Text = Form_User.frmUser.tag26value;
                txtBoxLoadcell1Max.Text = Form_User.frmUser.tag44value;
                txtBoxLoadcell2Max.Text = Form_User.frmUser.tag45value;
                if (Form_User.frmUser.tag25value != null || Form_User.frmUser.tag26value != null)
                {
                    Draw(float.Parse(Form_User.frmUser.tag25value), float.Parse(Form_User.frmUser.tag26value));
                }
            }
           
        }

        private void ShowDatatoDTGV()           // Truy vấn, truyền câu lệnh query vào SQL để tìm và hiển thị các giá trị lên Datagridview
        {
            string sqlSelectBunke1 = "SELECT date_time, loadcell1_data FROM Bunke1_data WHERE date_time >= CONVERT (date, GETDATE())";
            class_Database.sqlDisplay(sqlSelectBunke1, dtGVWeightBunke1);
            dtGVWeightBunke1.Columns[0].HeaderText = "Ngày tháng";
            dtGVWeightBunke1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
            dtGVWeightBunke1.Columns[1].HeaderText = "Cân nặng (g)";
            class_AutoResize.AutoResize(dtGVWeightBunke1);

            string sqlSelectBunke2 = "SELECT date_time, loadcell2_data FROM Bunke2_data WHERE date_time >= CONVERT (date, GETDATE())";
            class_Database.sqlDisplay(sqlSelectBunke2, dtGVWeightBunke2);
            dtGVWeightBunke2.Columns[0].HeaderText = "Ngày tháng";
            dtGVWeightBunke2.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
            dtGVWeightBunke2.Columns[1].HeaderText = "Cân nặng (g)";
            class_AutoResize.AutoResize(dtGVWeightBunke2);

            string sqlSelectBunke3 = "SELECT date_time, sensor_status FROM Bunke3_data WHERE date_time >= CONVERT (date, GETDATE())";
            class_Database.sqlDisplay(sqlSelectBunke3, dtGVDeviceBunke3);
            dtGVDeviceBunke3.Columns[0].HeaderText = "Ngày tháng";
            dtGVDeviceBunke3.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
            dtGVDeviceBunke3.Columns[1].HeaderText = "Trạng thái";
            class_AutoResize.AutoResize(dtGVDeviceBunke3);

            string sqlSelectDnS = "SELECT date_time, device_name, device_status, note FROM Devices_data WHERE date_time >= CONVERT (date, GETDATE())";
            class_Database.sqlDisplay(sqlSelectDnS, dtGVDevicesAndSignal);
            dtGVDevicesAndSignal.Columns[0].HeaderText = "Ngày tháng";
            dtGVDevicesAndSignal.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
            dtGVDevicesAndSignal.Columns[1].HeaderText = "Thiết bị, tín hiệu";
            dtGVDevicesAndSignal.Columns[2].HeaderText = "Trạng thái";
            dtGVDevicesAndSignal.Columns[3].HeaderText = "Ghi chú";
            class_AutoResize.AutoResize(dtGVDevicesAndSignal);
        }

        private void timer_showdata_Tick(object sender, EventArgs e)           //Hiển thị giá trị lên Datagridview sau mỗi vòng lặp timer
        {
            ShowDatatoDTGV();       
        }
    }
}
