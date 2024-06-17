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
    public partial class UC_Dieukhien : UserControl
    {
        public static UC_Dieukhien UCControl;
        public UC_Dieukhien()
        {
            InitializeComponent();
            UCControl = this;
        }

        private void UC_Dieukhien_Load(object sender, EventArgs e)
        {
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(2);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(2);
            }

        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(3);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(3);
            }
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(4);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(4);
            }
        }

        private void btnSTARTC1_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(5);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(5);
            }
        }

        private void btnSTOPC1_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(6);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(6);
            }
        }

        private void btnSTARTC2_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(7);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(7);
            }
        }

        private void btnSTOPC2_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(8);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(8);
            }
        }
        private void btnDownStepmotor01_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(9);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(9);
            }
        }

        private void btnUpStepmotor01_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(10);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(10);
            }
        }

        private void btnDownStepmotor02_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(11);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(11);
            }
        }

        private void btnUpStepmotor02_Click(object sender, EventArgs e)
        {
            if (Form_Admin.frmAdmin != null)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(12);
            }
            else if (Form_User.frmUser != null)
            {
                Form_User.frmUser.Button_PLC_Clicked(12);
            }
        }


    }
}
