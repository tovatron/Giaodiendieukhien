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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            add_usercontrol(new UC_Camera());
        }

        private void add_usercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMainAF.Controls.Clear();
            pnlMainAF.Controls.Add(userControl);
            userControl.BringToFront();
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
                case "btnCameraAF":
                    add_usercontrol(new UC_Camera());
                    pnlCameraAF.BackColor = Color.Lime;
                    break;
                case "btnMonitorAF":
                    add_usercontrol(new UC_Giamsat());
                    pnlMonitorAF.BackColor = Color.Lime;
                    break;
                case "btnControlAF":
                    add_usercontrol(new UC_Dieukhien());
                    pnlControlAF.BackColor = Color.Lime;
                    break;
                case "btnReportAF":
                    add_usercontrol(new UC_Baocao());
                    pnlReportAF.BackColor = Color.Lime;
                    break;
                case "btnChartAF":
                    add_usercontrol(new UC_Bieudo());
                    pnlChartAF.BackColor = Color.Lime;
                    break;
                case "btnSettingAF":
                    add_usercontrol(new UC_Caidat());
                    pnlSettingAF.BackColor = Color.Lime;
                    break;
                case "btnSystemAF":
                    add_usercontrol(new UC_Hethong());
                    pnlSystemAF.BackColor = Color.Lime;
                    break;
                case "btnIOAF":
                    add_usercontrol(new UC_IO());
                    pnlIOAF.BackColor = Color.Lime;
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
            DateTime dataTime = DateTime.Now;
            this.lbTime.Text = dataTime.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult LogoutConfirm = MessageBox.Show("Bạn có muốn đăng xuất không ?","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(LogoutConfirm == DialogResult.Yes)
            {
                this.Hide();
                Form1 loginform = new Form1();
                loginform.ShowDialog();
                this.Close();
            }
        }
    }
}
