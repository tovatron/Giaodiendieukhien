using DoAnChiaDongThan;
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

namespace Giaodiendieukhien
{
    public partial class UC_Hethong : UserControl
    {
        // Khai báo giá trị DataSource để truy cập vào Server SQL
        public string DataSource = "";
        string ServerName = "";
        string DatabaseName = "";
        string Login_UserName = "";
        string Password = "";
        //---------------------------------
        public static UC_Hethong UCSystem;
        public int PLC_Scantime;            //THời gian Scan các giá trị trên KEPServerEX
        public int PLC_Timeout;             //Thời gian thay đổi trạng thái thông tin kết nối
        public int PLC_ReconnectTime;       //Thời gian tự động kết nối lại với PLC nếu tự mất tín hiệu
        public bool IsDisconnectPLCPressed = false;
        public UC_Hethong()
        {
            InitializeComponent();
            UCSystem = this;
        }
        private void UC_Hethong_Load(object sender, EventArgs e)
        {
            //Gán giá trị từ Properties vào các biến string
            ServerName = Properties.Settings.Default.Data_ServerName;           
            DatabaseName = Properties.Settings.Default.Data_Name;
            Login_UserName = Properties.Settings.Default.Data_LoginUser;
            Password = Properties.Settings.Default.Data_Password;
            DataSource = @"Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + Login_UserName + ";Password=" + Password;
            lbDataSource.Text = DataSource;

            timer1.Enabled = true;
            Form_Admin.frmAdmin.IsTimerUCSystemRunning = true;

            //Gán giá trị trong Properties vào các Textbox để hiển thị thông tin cho người dùng.
            txtBoxPLCIP.Text = Properties.Settings.Default["IP_PLC"].ToString();
            txtBoxPLCScantime.Text = Properties.Settings.Default["PLC_Scantime"].ToString();
            txtBoxPLCType.Text = Properties.Settings.Default["PLC_Type"].ToString();
            txtBoxPLCTimeout.Text = Properties.Settings.Default["PLC_Timeout"].ToString();
            txtBoxReconnectTime.Text = Properties.Settings.Default["PLC_Reconnect_Time"].ToString();
            txtBoxServerName.Text = Properties.Settings.Default["Data_ServerName"].ToString();
            txtBoxDataName.Text = Properties.Settings.Default["Data_Name"].ToString();
            txtBoxLoginName.Text = Properties.Settings.Default["Data_LoginUser"].ToString();
            txtBoxDataPassword.Text = Properties.Settings.Default["Data_Password"].ToString();
        }
        public void StopTimer()
        {
            timer1.Stop();
            timer1.Dispose();
            Form_Admin.frmAdmin.IsTimerUCSystemRunning = false;
        }
        public void RunTimer()
        {
            timer1.Start();
            Form_Admin.frmAdmin.IsTimerUCSystemRunning = true;
        }
        private void btnConnectPLC_Click(object sender, EventArgs e)        //Nút bấm kết nối với PLC
        {
            DialogResult ConnectConfirm = MessageBox.Show("Kết nối với PLC ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ConnectConfirm == DialogResult.Yes)
            {
                Form_Admin.frmAdmin.KEPServerEX_Connect();
                IsDisconnectPLCPressed = false;
            }
        }

        private void btnDisconnectPLC_Click(object sender, EventArgs e)     //Nút ngắt kết nối với PLC
        {
            DialogResult DisconnectConfirm = MessageBox.Show("Bạn có muốn ngắt kết nối với PLC không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DisconnectConfirm == DialogResult.Yes)
            {
                Form_Admin.frmAdmin.OPCServer.Disconnect();
                IsDisconnectPLCPressed = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtBoxWatchdog_value.Text = Form_Admin.frmAdmin.Watchdog_Value;     //Hiển thị giá trị Watchdog theo timer1 (Giá trị Watchdog lấy từ PLC)
        }

        private void btnEditPLC_Click(object sender, EventArgs e)       //Chỉnh sửa các tham số của PLC
        {
            DialogResult EditPLCConfirm = MessageBox.Show("Bạn có muốn chỉnh sửa các tham số của PLC ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditPLCConfirm == DialogResult.Yes)
            {
                btnEditPLC.Enabled = false;
                btnSavePLC.Enabled = true;
                txtBoxPLCIP.Enabled = true;
                txtBoxPLCScantime.Enabled = true;
                txtBoxPLCTimeout.Enabled = true;
                txtBoxPLCType.Enabled = true;
                txtBoxReconnectTime.Enabled = true;
            }
        }

        private void btnSavePLC_Click(object sender, EventArgs e)       //Lưu thông tin sau khi đã chỉnh sửa xong các tham số của PLC
        {
            DialogResult SavePLCConfirm = MessageBox.Show("Bạn có muốn lưu thông tin các tham số của PLC ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SavePLCConfirm == DialogResult.Yes)
            {
                Properties.Settings.Default.IP_PLC = txtBoxPLCIP.Text;
                Properties.Settings.Default.PLC_Type = txtBoxPLCType.Text;
                if (int.TryParse(txtBoxPLCScantime.Text,out PLC_Scantime))
                {
                    Properties.Settings.Default.PLC_Scantime = PLC_Scantime;
                }
                else
                {
                    MessageBox.Show("Giá trị PLC Scantime không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(txtBoxPLCTimeout.Text, out PLC_Timeout))
                {
                    Properties.Settings.Default.PLC_Timeout = PLC_Timeout;
                    Form_Admin.frmAdmin.Timer_Watchdog.Interval = Properties.Settings.Default.PLC_Timeout;
                }
                else
                {
                    MessageBox.Show("Giá trị PLC Timeout không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(txtBoxReconnectTime.Text, out PLC_ReconnectTime))
                {
                    Properties.Settings.Default.PLC_Reconnect_Time = PLC_ReconnectTime;
                }
                else
                {
                    MessageBox.Show("Giá trị PLC Reconnect Time không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnEditPLC.Enabled = true;
                btnSavePLC.Enabled = false;
                txtBoxPLCIP.Enabled = false;
                txtBoxPLCScantime.Enabled = false;
                txtBoxPLCTimeout.Enabled = false;
                txtBoxPLCType.Enabled = false;
                txtBoxReconnectTime.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnEditData_Click(object sender, EventArgs e)          // Chỉnh sửa thông tin truy cập vào SQL
        {
            DialogResult EditDataConfirm = MessageBox.Show("Bạn có muốn chỉnh sửa thông tin của Database ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditDataConfirm == DialogResult.Yes)
            {
                txtBoxServerName.Enabled = true;
                txtBoxDataName.Enabled = true;
                txtBoxLoginName.Enabled = true;
                txtBoxDataPassword.Enabled = true;
                btnEditData.Enabled = false;
                btnSaveData.Enabled = true;
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)          //Lưu chỉnh sửa thông tin truy cập vào SQL
        {
            DialogResult SaveDataConfirm = MessageBox.Show("Bạn có muốn lưu thông tin của Database ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveDataConfirm == DialogResult.Yes)
            {
                txtBoxServerName.Enabled = false;
                txtBoxDataName.Enabled = false;
                txtBoxLoginName.Enabled = false;
                txtBoxDataPassword.Enabled = false;
                btnEditData.Enabled = true;
                btnSaveData.Enabled = false;
                Properties.Settings.Default.Data_ServerName = txtBoxServerName.Text;
                Properties.Settings.Default.Data_Name = txtBoxDataName.Text;
                Properties.Settings.Default.Data_LoginUser = txtBoxLoginName.Text;
                Properties.Settings.Default.Data_Password = txtBoxDataPassword.Text;
                ServerName = Properties.Settings.Default.Data_ServerName;
                DatabaseName = Properties.Settings.Default.Data_Name;
                Login_UserName = Properties.Settings.Default.Data_LoginUser;
                Password = Properties.Settings.Default.Data_Password;
                DataSource = @"Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";User ID=" + Login_UserName + ";Password=" + Password;
                lbDataSource.Text = DataSource;
                Properties.Settings.Default.Save();
            }
        }
    }
}
 