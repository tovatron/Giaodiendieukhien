using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodiendieukhien.UserControls
{
    public partial class UC_Simulation : UserControl
    {
        public static UC_Simulation UCSim;
        public UC_Simulation()
        {
            InitializeComponent();
            UCSim = this;
        }

        private void UC_Simulation_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartSimError_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(50);
        }

        private void btnStopSimError_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(51);
        }

        private void btnStartSimLoadcell_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(52);
        }

        private void btnStopSimLoadcell_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(53);
        }

        private void btnOnPullC1_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(54);
        }

        private void btnOffPullC1_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(55);
        }

        private void btnOnSwayC1_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(56);
        }

        private void btnOffSwayC1_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(57);
        }

        private void btnOnOLC1_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(58);
        }

        private void btnOffOLC1_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(59);
        }

        private void btnOnPullC2_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(60);
        }

        private void btnOffPullC2_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(61);
        }

        private void btnOnSwayC2_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(62);
        }

        private void btnOffSwayC2_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(63);
        }

        private void btnOnOLC2_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(64);
        }

        private void btnOffOLC2_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(65);
        }

        private void btnZeroingSimLoadcell1_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(66);
        }

        private void btnZeroingSimLoadcell2_Click(object sender, EventArgs e)
        {
            Form_Admin.frmAdmin.Button_PLC_Clicked(67);
        }
    }
}
