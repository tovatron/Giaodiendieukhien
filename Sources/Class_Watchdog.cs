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
        public static void WatchdogStatus(Label lbPLCStatus, string valnow)
        {
            if (valnow != valold)
            {
                lbPLCStatus.Text = "Đã kết nối";
                lbPLCStatus.ForeColor = Color.Green;
            }
            else
            {
                lbPLCStatus.Text = "Ngắt kết nối";
                lbPLCStatus.ForeColor = Color.Red;
            }
            valold = valnow;
        }
    }
}
