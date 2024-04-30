using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Giaodiendieukhien
{
    public partial class Form_User : Form
    {
        public Form_User()
        {
            InitializeComponent();
        }
        private void Form_User_Load(object sender, EventArgs e)
        {
            timer1.Start();
            add_usercontrol(new UC_Camera());
        }
        private void add_usercontrol (UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMainUF.Controls.Clear();
            pnlMainUF.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void click_Button (object sender, EventArgs e)
        {
            foreach(var pnl in pnlTabsUF.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.White;
            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnCameraUF":
                    add_usercontrol(new UC_Camera());
                    pnlCameraUF.BackColor = Color.Lime;
                    break;
                case "btnMonitorUF":
                    add_usercontrol(new UC_Giamsat());
                    pnlMonitorUF.BackColor = Color.Lime;
                    break;
                case "btnControlUF":
                    add_usercontrol(new UC_Dieukhien());
                    pnlControlUF.BackColor = Color.Lime;
                    break;
                case "btnReportUF":
                    add_usercontrol(new UC_Baocao());
                    pnlReportUF.BackColor = Color.Lime;
                    break;
                case "btnChartUF":
                    add_usercontrol(new UC_Bieudo());
                    pnlChartUF.BackColor = Color.Lime;
                    break;
                default:
                    break;
            }
        }
        private void btnCloseappUF_Click(object sender, EventArgs e)
        {
            DialogResult CConfirm = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng ?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(CConfirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        private void btnMinimizeUF_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataTime = DateTime.Now;
            this.lbTime.Text = dataTime.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult LogoutConfirm = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (LogoutConfirm == DialogResult.Yes)
            {
                this.Hide();
                Form1 loginform = new Form1();
                loginform.ShowDialog();
                this.Close();
            }
        }
    }
}
