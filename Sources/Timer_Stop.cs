using Giaodiendieukhien.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaodiendieukhien.Sources
{
    class Timer_Stop
    {
        public static void TimerStop()
        {
            //Dừng timer tại UC_Hethong nếu chuyển sang tab khác
            if (Form_Admin.frmAdmin != null && Form_Admin.frmAdmin.IsTimerUCSystemRunning == true)
            {
                UC_Hethong.UCSystem.StopTimer();
                return;
            }
            //Dừng timer tại UC_Giamsat nếu chuyển sang tab khác
            if (Form_Admin.frmAdmin != null && Form_Admin.frmAdmin.IsTimerUCWatchRunning == true)
            {
                UC_Giamsat.UCWatch.StopTimer();
                return;
            }
            else if (Form_User.frmUser != null && Form_User.frmUser.IsTimerUCWatchRunning == true)
            {
                UC_Giamsat.UCWatch.StopTimer();
                return;
            }
        }
    }
}
