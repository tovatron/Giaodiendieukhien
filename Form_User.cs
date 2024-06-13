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
using static System.Net.Mime.MediaTypeNames;
using OPCAutomation;

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
            add_usercontrol(new UC_Dieukhien());
            KEPServerEX_Connect();
        }
        //========================================KEPServerEX CONNECT======================================
         static int tagNumber = 12;       // Cài đặt số lượng tag của project
         static int PLCscantime = 1000;  // Cài đặt thời gian quét PLC

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
         private void KEPServerEX_Connect()
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
                 //----------------------Xử lý giá trị tag-----------------------------
                 if (getTagID == 0)
                 {
                 }
            }
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
                Form_Login loginform = new Form_Login();
                loginform.ShowDialog();
                this.Close();
            }
        }
    }
}
