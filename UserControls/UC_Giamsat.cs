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

namespace Giaodiendieukhien
{
    public partial class UC_Giamsat : UserControl
    {
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
        }
        public void StopTimer()
        {
            timer1.Stop();
            timer1.Dispose();
            timer_showdata.Stop();
            timer_showdata.Dispose();
            Form_Admin.frmAdmin.IsTimerUCWatchRunning = false;
        }
        public void RunTimer()
        {
            timer1.Start();
            timer_showdata.Start();
            Form_Admin.frmAdmin.IsTimerUCWatchRunning = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
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
                txtBoxStatusBunke3 .ForeColor = Color.Red;
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
        }

        private void ShowDatatoDTGV()
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

        private void timer_showdata_Tick(object sender, EventArgs e)
        {
            ShowDatatoDTGV();
        }
    }
}
