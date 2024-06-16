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
            if (Form_Admin.frmAdmin.IsTimerUCSystemRunning == true)
            {
                UC_Hethong.UCSystem.StopTimer();
            }
            if (Form_Admin.frmAdmin.IsTimerUCWatchRunning == true)
            {
                UC_Giamsat.UCWatch.StopTimer();
            }
        }
    }
}
