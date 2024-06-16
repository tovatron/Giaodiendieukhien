using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Giaodiendieukhien.Sources
{
    public static class class_AutoResize
    {

        public static void AutoResize(DataGridView dtgv)
        {
            dtgv.SuspendLayout();
            dtgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtgv.ResumeLayout();
        }
    }
}
