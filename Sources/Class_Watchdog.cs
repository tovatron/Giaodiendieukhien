using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//================================Chương trình kiểm tra kết nối giữa PLC và C#=================================
namespace DoAnChiaDongThan
{
    public static class class_Watchdog
    {
        static string valold = "";
        public static void WatchdogStatus(PictureBox pBoxPLCs, Label lbPLCs, string valnow)
        {
            if (valnow != valold)
            {
                pBoxPLCs.BackColor = Color.Green;
                lbPLCs.Text = "Connected";
            }
            else
            {
                pBoxPLCs.BackColor = Color.Red;
                lbPLCs.Text = "Disconnected";
            }
            valold = valnow;
        }
    }
}
