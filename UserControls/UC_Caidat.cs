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
    public partial class UC_Caidat : UserControl
    {
        public static UC_Caidat UCSettings;
        public float StartAutoTimeC1;
        public float StartAutoTimeC2;
        public float StopAutoTimeC1;
        public float StopAutoTimeC2;
        public float StartManTimeC1;
        public float StartManTimeC2;
        public float StopManTimeC1;
        public float StopManTimeC2;
        public float Stepmotor01ThuanPosition;
        public float Stepmotor02ThuanPosition;
        public float Stepmotor01NghichPosition;
        public float Stepmotor02NghichPosition;
        public int Stepmotor01Speed;
        public int Stepmotor02Speed;
        public float Loadcell1Max;
        public float Loadcell2Max;
        public float Loadcell1AutoZeroingTime;
        public float Loadcell2AutoZeroingTime;
        public float Loadcell1AutoZeroingWeight;
        public float Loadcell2AutoZeroingWeight;


        public UC_Caidat()
        {
            InitializeComponent();
            UCSettings = this;
        }

        private void UC_Caidat_Load(object sender, EventArgs e)
        {
            txtBoxAutoStartTimeC1.Text = Properties.Settings.Default["StartAutoTime_C1"].ToString();
            txtBoxAutoStartTimeC2.Text = Properties.Settings.Default["StartAutoTime_C2"].ToString();
            txtBoxAutoStopTimeC1.Text = Properties.Settings.Default["StopAutoTime_C1"].ToString();
            txtBoxAutoStopTimeC2.Text = Properties.Settings.Default["StopAutoTime_C2"].ToString();
            txtBoxManStartTimeC1.Text = Properties.Settings.Default["StartManTime_C1"].ToString();
            txtBoxManStartTimeC2.Text = Properties.Settings.Default["StartManTime_C2"].ToString();
            txtBoxManStopTimeC1.Text = Properties.Settings.Default["StopManTime_C1"].ToString();
            txtBoxManStopTimeC2.Text = Properties.Settings.Default["StopManTime_C2"].ToString();
            txtBoxPulseDownStepmotor01.Text = Properties.Settings.Default["Stepmotor01_Thuan_Position"].ToString();
            txtBoxPulseUpStepmotor01.Text = Properties.Settings.Default["Stepmotor01_Nghich_Position"].ToString();
            txtBoxPulseDownStepmotor02.Text = Properties.Settings.Default["Stepmotor02_Thuan_Position"].ToString();
            txtBoxPulseUpStepmotor02.Text = Properties.Settings.Default["Stepmotor02_Nghich_Position"].ToString();
            txtBoxVelocityStepmotor01.Text = Properties.Settings.Default["Stepmotor01_Speed"].ToString();
            txtBoxVelocityStepmotor02.Text = Properties.Settings.Default["Stepmotor02_Speed"].ToString();
            txtBoxMaxLoadcell1.Text = Properties.Settings.Default["Loadcell1_Max"].ToString();
            txtBoxMaxLoadcell2.Text = Properties.Settings.Default["Loadcell2_Max"].ToString();
            txtBoxBalanceTimeLoadcell1.Text = Properties.Settings.Default["Loadcell1_AutoZeroingTime"].ToString();
            txtBoxBalanceTimeLoadcell2.Text = Properties.Settings.Default["Loadcell2_AutoZeroingTime"].ToString();
            txtBoxBalanceWeightLoadcell1.Text = Properties.Settings.Default["Loadcell1_AutoZeroingWeight"].ToString();
            txtBoxBalanceWeightLoadcell2.Text = Properties.Settings.Default["Loadcell2_AutoZeroingWeight"].ToString();

        }

        private void btnEditAutoStartTime_Click(object sender, EventArgs e)
        {
            DialogResult EditStartAutoTimeConfirm = MessageBox.Show("Bạn có muốn chỉnh sửa thời gian Start Auto ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditStartAutoTimeConfirm == DialogResult.Yes)
            {
                txtBoxAutoStartTimeC1.Enabled = true;
                txtBoxAutoStartTimeC2.Enabled = true;
                btnEditAutoStartTime.Enabled = false;
                btnSaveAutoStartTime.Enabled = true;
            }
        }

        private void btnSaveAutoStartTime_Click(object sender, EventArgs e)
        {
            DialogResult SaveStartAutoTimeConfirm = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thời gian Start Auto ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveStartAutoTimeConfirm == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxAutoStartTimeC1.Text, out StartAutoTimeC1))
                {
                    Properties.Settings.Default.StartAutoTime_C1 = StartAutoTimeC1;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxAutoStartTimeC1.Text, 30);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Start Auto Conveyor01 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxAutoStartTimeC2.Text, out StartAutoTimeC2))
                {
                    Properties.Settings.Default.StartAutoTime_C2 = StartAutoTimeC2;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxAutoStartTimeC2.Text, 31);
                }    
                else
                {
                    MessageBox.Show("Giá trị thời gian Start Auto Conveyor02 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
                txtBoxAutoStartTimeC1.Enabled = false;
                txtBoxAutoStartTimeC2.Enabled = false;
                btnEditAutoStartTime.Enabled = true;
                btnSaveAutoStartTime.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnEditAutoStopTime_Click(object sender, EventArgs e)
        {
            DialogResult EditStopAutoTimeConfirm = MessageBox.Show("Bạn có muốn chỉnh sửa thời gian Stop Auto ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditStopAutoTimeConfirm == DialogResult.Yes)
            {
                txtBoxAutoStopTimeC1.Enabled = true;
                txtBoxAutoStopTimeC2.Enabled = true;
                btnEditAutoStopTime.Enabled = false;
                btnSaveAutoStopTime.Enabled = true;
            }
        }

        private void btnSaveAutoStopTime_Click(object sender, EventArgs e)
        {
            DialogResult SaveStopAutoTimeConfirm = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thời gian Stop Auto ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveStopAutoTimeConfirm == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxAutoStopTimeC1.Text, out StopAutoTimeC1))
                {
                    Properties.Settings.Default.StopAutoTime_C1 = StopAutoTimeC1;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxAutoStopTimeC1.Text, 32);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Stop Auto Conveyor01 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxAutoStopTimeC2.Text, out StopAutoTimeC2))
                {
                    Properties.Settings.Default.StopAutoTime_C2 = StopAutoTimeC2;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxAutoStopTimeC2.Text, 33);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Stop Auto Conveyor02 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtBoxAutoStopTimeC1.Enabled = false;
                txtBoxAutoStopTimeC2.Enabled = false;
                btnEditAutoStopTime.Enabled = true;
                btnSaveAutoStopTime.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnEditManStartTime_Click(object sender, EventArgs e)
        {
            DialogResult EditStartManTimeConfirm = MessageBox.Show("Bạn có muốn chỉnh sửa thời gian Start Manual ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditStartManTimeConfirm == DialogResult.Yes)
            {
                txtBoxManStartTimeC1.Enabled = true;
                txtBoxManStartTimeC2.Enabled = true;
                btnEditManStartTime.Enabled = false;
                btnSaveManStartTime.Enabled = true;
            }
        }

        private void btnSaveManStartTime_Click(object sender, EventArgs e)
        {
            DialogResult SaveStartManTimeConfirm = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thời gian Start Manual ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveStartManTimeConfirm == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxManStartTimeC1.Text, out StartManTimeC1))
                {
                    Properties.Settings.Default.StartAutoTime_C1 = StartManTimeC1;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxManStartTimeC1.Text, 34);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Start Manual Conveyor01 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxManStartTimeC2.Text, out StartManTimeC2))
                {
                    Properties.Settings.Default.StartManTime_C2 = StartManTimeC2;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxManStartTimeC2.Text, 35);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Start Manual Conveyor02 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtBoxManStartTimeC1.Enabled = false;
                txtBoxManStartTimeC2.Enabled = false;
                btnEditManStartTime.Enabled = true;
                btnSaveManStartTime.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnEditManStopTime_Click(object sender, EventArgs e)
        {
            DialogResult EditStoptManTimeConfirm = MessageBox.Show("Bạn có muốn chỉnh sửa thời gian Stop Manual ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditStoptManTimeConfirm == DialogResult.Yes)
            {
                txtBoxManStopTimeC1.Enabled = true;
                txtBoxManStopTimeC2.Enabled = true;
                btnEditManStopTime.Enabled = false;
                btnSaveManStopTime.Enabled = true;
            }
        }

        private void btnSaveManStopTime_Click(object sender, EventArgs e)
        {
            DialogResult SaveStopManTimeConfirm = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thời gian Stop Manual ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveStopManTimeConfirm == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxManStopTimeC1.Text, out StopManTimeC1))
                {
                    Properties.Settings.Default.StopAutoTime_C1 = StopManTimeC1;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxManStopTimeC1.Text, 36);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Stop Manual Conveyor01 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxManStopTimeC2.Text, out StopManTimeC2))
                {
                    Properties.Settings.Default.StopManTime_C2 = StopManTimeC2;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxManStopTimeC2.Text, 37);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Stop Manual Conveyor02 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtBoxManStopTimeC1.Enabled = false;
                txtBoxManStopTimeC2.Enabled = false;
                btnEditManStopTime.Enabled = true;
                btnSaveManStopTime.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnEditStepmotor01_Click(object sender, EventArgs e)
        {
            DialogResult EditStepmotor01 = MessageBox.Show("Bạn có muốn chỉnh sửa thông số Stepmotor 1 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditStepmotor01 == DialogResult.Yes)
            {
                txtBoxPulseDownStepmotor01.Enabled = true;
                txtBoxPulseUpStepmotor01.Enabled = true;
                txtBoxVelocityStepmotor01.Enabled = true;
                btnEditStepmotor01.Enabled = false;
                btnSaveStepmotor01.Enabled = true;
            }
        }

        private void btnSaveStepmotor01_Click(object sender, EventArgs e)
        {
            DialogResult SaveStepmotor01 = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thông số Stepmotor 1 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveStepmotor01 == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxPulseDownStepmotor01.Text, out Stepmotor01ThuanPosition))
                {
                    Properties.Settings.Default.Stepmotor01_Thuan_Position = Stepmotor01ThuanPosition;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxPulseDownStepmotor01.Text, 38);
                }
                else
                {
                    MessageBox.Show("Giá trị vị trí Thuận(Down) Stepmotor01 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxPulseUpStepmotor01.Text, out Stepmotor01NghichPosition))
                {
                    Properties.Settings.Default.Stepmotor01_Nghich_Position = Stepmotor01NghichPosition;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxPulseUpStepmotor01.Text, 39);
                }
                else
                {
                    MessageBox.Show("Giá trị vị trí Nghịch(Up) Stepmotor01 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(txtBoxVelocityStepmotor01.Text, out Stepmotor01Speed))
                {
                    Properties.Settings.Default.Stepmotor01_Speed = Stepmotor01Speed;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxVelocityStepmotor01.Text, 42);

                }
                else
                {
                    MessageBox.Show("Giá trị vị trí Tốc độ Stepmotor01 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtBoxPulseDownStepmotor01.Enabled = false;
                txtBoxPulseUpStepmotor01.Enabled = false;
                txtBoxVelocityStepmotor01.Enabled = false;
                btnEditStepmotor01.Enabled = true;
                btnSaveStepmotor01.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }
        private void btnEditStepmotor02_Click(object sender, EventArgs e)
        {
            DialogResult EditStepmotor01 = MessageBox.Show("Bạn có muốn chỉnh sửa thông số Stepmotor 2 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditStepmotor01 == DialogResult.Yes)
            {
                txtBoxPulseDownStepmotor02.Enabled = true;
                txtBoxPulseUpStepmotor02.Enabled = true;
                txtBoxVelocityStepmotor02.Enabled = true;
                btnEditStepmotor02.Enabled = false;
                btnSaveStepmotor02.Enabled = true;
            }
        }

        private void btnSaveStepmotor02_Click(object sender, EventArgs e)
        {
            DialogResult SaveStepmotor01 = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thông số Stepmotor 2 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveStepmotor01 == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxPulseDownStepmotor02.Text, out Stepmotor02ThuanPosition))
                {
                    Properties.Settings.Default.Stepmotor02_Thuan_Position = Stepmotor02ThuanPosition;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxPulseDownStepmotor02.Text, 40);
                }
                else
                {
                    MessageBox.Show("Giá trị vị trí Thuận(Down) Stepmotor02 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxPulseUpStepmotor02.Text, out Stepmotor02NghichPosition))
                {
                    Properties.Settings.Default.Stepmotor02_Nghich_Position = Stepmotor02NghichPosition;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxPulseUpStepmotor02.Text, 41);
                }
                else
                {
                    MessageBox.Show("Giá trị vị trí Nghịch(Up) Stepmotor02 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.TryParse(txtBoxVelocityStepmotor02.Text, out Stepmotor02Speed))
                {
                    Properties.Settings.Default.Stepmotor02_Speed = Stepmotor02Speed;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxVelocityStepmotor02.Text, 43);
                }
                else
                {
                    MessageBox.Show("Giá trị vị trí Tốc độ Stepmotor02 không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtBoxPulseDownStepmotor02.Enabled = false;
                txtBoxPulseUpStepmotor02.Enabled = false;
                txtBoxVelocityStepmotor02.Enabled = false;
                btnEditStepmotor02.Enabled = true;
                btnSaveStepmotor02.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }

        private void btnEditLoadcell1_Click(object sender, EventArgs e)
        {
            DialogResult EditLoadcell1 = MessageBox.Show("Bạn có muốn chỉnh sửa thông số Loadcell 1 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditLoadcell1 == DialogResult.Yes)
            {
                txtBoxMaxLoadcell1.Enabled = true;
                txtBoxBalanceTimeLoadcell1.Enabled = true;
                txtBoxBalanceWeightLoadcell1.Enabled = true;
                btnEditLoadcell1.Enabled = false;
                btnSaveLoadcell1.Enabled = true;
            }
        }

        private void btnSaveLoadcell1_Click(object sender, EventArgs e)
        {
            DialogResult SaveLoadcell1 = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thông số Loadcell 1 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveLoadcell1 == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxMaxLoadcell1.Text, out Loadcell1Max))
                {
                    Properties.Settings.Default.Loadcell1_Max = Loadcell1Max;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxMaxLoadcell1.Text, 44);
                }
                else if (Loadcell1Max > 1000)
                {
                    MessageBox.Show("Giá trị cân nặng Loadcell1 Maximum là dưới 1000 !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Giá trị cân nặng Loadcell1 Maximum không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxBalanceTimeLoadcell1.Text, out Loadcell1AutoZeroingTime))
                {
                    Properties.Settings.Default.Loadcell1_AutoZeroingTime = Loadcell1AutoZeroingTime;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxBalanceTimeLoadcell1.Text, 46);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Zeroing Loadcell1 không hợp lệ !", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxBalanceWeightLoadcell1.Text, out Loadcell1AutoZeroingWeight))
                {
                    Properties.Settings.Default.Loadcell1_AutoZeroingWeight = Loadcell1AutoZeroingWeight;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxBalanceWeightLoadcell1.Text, 48);
                }
                else
                {
                    MessageBox.Show("Giá trị cân nặng Zeroing Loadcell1 không hợp lệ !", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtBoxMaxLoadcell1.Enabled = false;
                txtBoxBalanceTimeLoadcell1.Enabled = false;
                txtBoxBalanceWeightLoadcell1.Enabled = false;
                btnEditLoadcell1.Enabled = true;
                btnSaveLoadcell1.Enabled = false;
                Properties.Settings.Default.Save();
            }
            
        }
        private void btnEditLoadcell2_Click(object sender, EventArgs e)
        {
            DialogResult EditLoadcell2 = MessageBox.Show("Bạn có muốn chỉnh sửa thông số Loadcell 2 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (EditLoadcell2 == DialogResult.Yes)
            {
                txtBoxMaxLoadcell2.Enabled = true;
                txtBoxBalanceTimeLoadcell2.Enabled = true;
                txtBoxBalanceWeightLoadcell2.Enabled = true;
                btnEditLoadcell2.Enabled = false;
                btnSaveLoadcell2.Enabled = true;
            }
        }

        private void btnSaveLoadcell2_Click(object sender, EventArgs e)
        {
            DialogResult SaveLoadcell2 = MessageBox.Show("Bạn có muốn lưu chỉnh sửa thông số Loadcell 2 ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveLoadcell2 == DialogResult.Yes)
            {
                if (float.TryParse(txtBoxMaxLoadcell2.Text, out Loadcell2Max))
                {
                    Properties.Settings.Default.Loadcell2_Max = Loadcell2Max;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxMaxLoadcell2.Text, 45);
                }
                else if (Loadcell2Max > 1000)
                {
                    MessageBox.Show("Giá trị cân nặng Loadcell 2 Maximum là dưới 1000 !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Giá trị cân nặng Loadcell 2 Maximum không hợp lệ !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxBalanceTimeLoadcell2.Text, out Loadcell2AutoZeroingTime))
                {
                    Properties.Settings.Default.Loadcell2_AutoZeroingTime = Loadcell2AutoZeroingTime;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxBalanceTimeLoadcell2.Text, 47);
                }
                else
                {
                    MessageBox.Show("Giá trị thời gian Zeroing Loadcell 2 không hợp lệ !", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (float.TryParse(txtBoxBalanceWeightLoadcell2.Text, out Loadcell2AutoZeroingWeight))
                {
                    Properties.Settings.Default.Loadcell2_AutoZeroingWeight = Loadcell2AutoZeroingWeight;
                    Form_Admin.frmAdmin.LoaddataUC(txtBoxBalanceWeightLoadcell2.Text, 49);
                }
                else
                {
                    MessageBox.Show("Giá trị cân nặng Zeroing Loadcell 2 không hợp lệ !", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtBoxMaxLoadcell2.Enabled = false;
                txtBoxBalanceTimeLoadcell2.Enabled = false;
                txtBoxBalanceWeightLoadcell2.Enabled = false;
                btnEditLoadcell2.Enabled = true;
                btnSaveLoadcell2.Enabled = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
