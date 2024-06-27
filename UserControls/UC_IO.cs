using Giaodiendieukhien.Sources;
using SymbolFactoryDotNet;
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
    public partial class UC_IO : UserControl
    {
        private float Loadcell1value;
        private float Loadcell2value;
        public bool IOStatus;
        public static UC_IO UCIO;
        Status_Display sttdp = new Status_Display();
        public UC_IO()
        {
            InitializeComponent();
            UCIO = this;
        }

        private void UC_IO_Load(object sender, EventArgs e)
        {
        }

        private void btnOnIO_Click(object sender, EventArgs e)      // Bật chế độ IO để hiển thị các giá trị Input và Output lên giao diện
        {
            DialogResult OnIOConfirm = MessageBox.Show("Bạn có muốn bật chế độ IO không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OnIOConfirm == DialogResult.Yes)
            {
                IOStatus = true;
                btnOffIO.Enabled = true;
                btnOnIO.Enabled = false;
                symbLampIOStatus.DiscreteValue1 = true;
            }
        }

        private void btnOffIO_Click(object sender, EventArgs e)     //Tắt chế độ IO
        {
            DialogResult OffIOConfirm = MessageBox.Show("Bạn có muốn bật chế độ IO không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (OffIOConfirm == DialogResult.Yes)
            {
                IOStatus = false;
                btnOffIO.Enabled = false;
                btnOnIO.Enabled = true;
                timer1.Enabled = false;
                symbLampIOStatus.DiscreteValue1 = false;
                symbLampAutoIO.DiscreteValue1 = false;
                symbLampManIO.DiscreteValue1 = false;
                symbLampEMSIO.DiscreteValue1 = false;
                symbLampSystemIO.DiscreteValue1 = false;
                symbLampStepmotor01IO.DiscreteValue1 = false;
                symbLampStepmotor02IO.DiscreteValue1 = false;
                symbLampTiemCanIO.DiscreteValue1 = false;
                symbLampC1IO.DiscreteValue1 = false;
                symbLampC2IO.DiscreteValue1 = false;
                symbLampLoadcell1IO.DiscreteValue1 = false;
                symbLampLoadcell2IO.DiscreteValue1 = false;
                txtBoxLoadcell1Weight.Text = string.Empty;
                txtBoxLoadcell2Weight.Text = string.Empty;
                txtBoxLoadcell1Max.Text = string.Empty;
                txtBoxLoadcell2Max.Text = string.Empty;
                txtBoxLoadcell1AI.Text = string.Empty;
                txtBoxLoadcell2AI.Text = string.Empty;
            }
        }
        private void ButtonClicked(int tagValue)
        {
            if (IOStatus == true)
            {
                Form_Admin.frmAdmin.Button_PLC_Clicked(tagValue);
            }
        }

        private void btnUpStepmotor01IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(10);
        }

        private void btnDownStepmotor01IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(9);
        }

        private void btnUpStepmotor02IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(12);
        }

        private void btnDownStepmotor02IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(11);
        }

        private void btnOnC1IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(5);
        }

        private void btnOffC1IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(6);
        }

        private void btnOnC2IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(7);
        }

        private void btnOffC2IO_Click(object sender, EventArgs e)
        {
            ButtonClicked(8);
        }

        private void timer1_Tick(object sender, EventArgs e)        //Timer cập nhật giá trị đèn báo và các giá trị trong textbox trên giao diện UC_IO
        {
            symbLampAutoIO.DiscreteValue1 = UC_Dieukhien.UCControl.symbLampAuto.DiscreteValue1;
            symbLampManIO.DiscreteValue1 = UC_Dieukhien.UCControl.symbLampMan.DiscreteValue1;
            symbLampEMSIO.DiscreteValue1 = UC_Dieukhien.UCControl.symbLampStopEMS.DiscreteValue1;
            sttdp.stt_Lamp(symbLampSystemIO, Form_Admin.frmAdmin.tag29value);
            sttdp.stt_Lamp(symbLampStepmotor01IO, Form_Admin.frmAdmin.tag13value);
            sttdp.stt_Lamp(symbLampStepmotor02IO, Form_Admin.frmAdmin.tag15value);
            sttdp.stt_Lamp(symbLampTiemCanIO, Form_Admin.frmAdmin.tag76value);
            sttdp.stt_Lamp(symbLampC1IO, Form_Admin.frmAdmin.tag27value);
            sttdp.stt_Lamp(symbLampC2IO, Form_Admin.frmAdmin.tag28value);
            if (Form_Admin.frmAdmin.tag79value == "True")
            {
                symbLampErrorSignalIO.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;           //Chế độ nhấp nháy cho đèn báo lỗi
            }
            else
            {
                symbLampErrorSignalIO.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
            }
            txtBoxLoadcell1Weight.Text = Form_Admin.frmAdmin.tag25value;
            txtBoxLoadcell2Weight.Text = Form_Admin.frmAdmin.tag26value;
            float.TryParse(Form_Admin.frmAdmin.tag25value, out Loadcell1value);
            if (Loadcell1value > 0)
            {
                symbLampLoadcell1IO.DiscreteValue1 = true;
            }
            else
            {
                symbLampLoadcell1IO.DiscreteValue1 = false;
            }
            float.TryParse(Form_Admin.frmAdmin.tag26value, out Loadcell2value);
            if (Loadcell2value > 0)
            {
                symbLampLoadcell2IO.DiscreteValue1 = true;
            }
            else
            {
                symbLampLoadcell2IO.DiscreteValue1 = false;
            }
            txtBoxLoadcell1Max.Text = Form_Admin.frmAdmin.tag44value;
            txtBoxLoadcell2Max.Text = Form_Admin.frmAdmin.tag45value;
            txtBoxLoadcell1AI.Text = Form_Admin.frmAdmin.tag77value;
            txtBoxLoadcell2AI.Text = Form_Admin.frmAdmin.tag78value;
        }
    }
}
