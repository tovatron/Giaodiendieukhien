namespace Giaodiendieukhien
{
    partial class UC_Hethong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Hethong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditPLC = new System.Windows.Forms.Button();
            this.btnSavePLC = new System.Windows.Forms.Button();
            this.txtBoxReconnectTime = new System.Windows.Forms.TextBox();
            this.txtBoxPLCTimeout = new System.Windows.Forms.TextBox();
            this.txtBoxPLCScantime = new System.Windows.Forms.TextBox();
            this.txtBoxPLCType = new System.Windows.Forms.TextBox();
            this.txtBoxPLCIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisconnectPLC = new System.Windows.Forms.Button();
            this.btnConnectPLC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxWatchdog_value = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPLCStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.lbDataSource = new System.Windows.Forms.Label();
            this.txtBoxDataPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxLoginName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxDataName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxServerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditPLC);
            this.groupBox1.Controls.Add(this.btnSavePLC);
            this.groupBox1.Controls.Add(this.txtBoxReconnectTime);
            this.groupBox1.Controls.Add(this.txtBoxPLCTimeout);
            this.groupBox1.Controls.Add(this.txtBoxPLCScantime);
            this.groupBox1.Controls.Add(this.txtBoxPLCType);
            this.groupBox1.Controls.Add(this.txtBoxPLCIP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDisconnectPLC);
            this.groupBox1.Controls.Add(this.btnConnectPLC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxWatchdog_value);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbPLCStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tham số PLC";
            // 
            // btnEditPLC
            // 
            this.btnEditPLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditPLC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPLC.Location = new System.Drawing.Point(72, 393);
            this.btnEditPLC.Name = "btnEditPLC";
            this.btnEditPLC.Size = new System.Drawing.Size(108, 46);
            this.btnEditPLC.TabIndex = 109;
            this.btnEditPLC.Text = "Edit";
            this.btnEditPLC.UseVisualStyleBackColor = false;
            this.btnEditPLC.Click += new System.EventHandler(this.btnEditPLC_Click);
            // 
            // btnSavePLC
            // 
            this.btnSavePLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSavePLC.Enabled = false;
            this.btnSavePLC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePLC.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePLC.Image")));
            this.btnSavePLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePLC.Location = new System.Drawing.Point(186, 393);
            this.btnSavePLC.Name = "btnSavePLC";
            this.btnSavePLC.Size = new System.Drawing.Size(107, 46);
            this.btnSavePLC.TabIndex = 17;
            this.btnSavePLC.Text = "     Save";
            this.btnSavePLC.UseVisualStyleBackColor = false;
            this.btnSavePLC.Click += new System.EventHandler(this.btnSavePLC_Click);
            // 
            // txtBoxReconnectTime
            // 
            this.txtBoxReconnectTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxReconnectTime.Enabled = false;
            this.txtBoxReconnectTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxReconnectTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxReconnectTime.Location = new System.Drawing.Point(244, 350);
            this.txtBoxReconnectTime.Name = "txtBoxReconnectTime";
            this.txtBoxReconnectTime.Size = new System.Drawing.Size(107, 25);
            this.txtBoxReconnectTime.TabIndex = 16;
            this.txtBoxReconnectTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPLCTimeout
            // 
            this.txtBoxPLCTimeout.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxPLCTimeout.Enabled = false;
            this.txtBoxPLCTimeout.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPLCTimeout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxPLCTimeout.Location = new System.Drawing.Point(244, 311);
            this.txtBoxPLCTimeout.Name = "txtBoxPLCTimeout";
            this.txtBoxPLCTimeout.Size = new System.Drawing.Size(107, 25);
            this.txtBoxPLCTimeout.TabIndex = 15;
            this.txtBoxPLCTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPLCScantime
            // 
            this.txtBoxPLCScantime.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxPLCScantime.Enabled = false;
            this.txtBoxPLCScantime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPLCScantime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxPLCScantime.Location = new System.Drawing.Point(244, 272);
            this.txtBoxPLCScantime.Name = "txtBoxPLCScantime";
            this.txtBoxPLCScantime.Size = new System.Drawing.Size(107, 25);
            this.txtBoxPLCScantime.TabIndex = 14;
            this.txtBoxPLCScantime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPLCType
            // 
            this.txtBoxPLCType.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxPLCType.Enabled = false;
            this.txtBoxPLCType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPLCType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxPLCType.Location = new System.Drawing.Point(244, 233);
            this.txtBoxPLCType.Name = "txtBoxPLCType";
            this.txtBoxPLCType.Size = new System.Drawing.Size(107, 25);
            this.txtBoxPLCType.TabIndex = 13;
            this.txtBoxPLCType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPLCIP
            // 
            this.txtBoxPLCIP.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxPLCIP.Enabled = false;
            this.txtBoxPLCIP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPLCIP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxPLCIP.Location = new System.Drawing.Point(160, 155);
            this.txtBoxPLCIP.Name = "txtBoxPLCIP";
            this.txtBoxPLCIP.Size = new System.Drawing.Size(191, 25);
            this.txtBoxPLCIP.TabIndex = 12;
            this.txtBoxPLCIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "PLC Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "PLC Reconnect time (ms)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "PLC Timeout (ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "PLC Tag scan time (ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ IP của PLC";
            // 
            // btnDisconnectPLC
            // 
            this.btnDisconnectPLC.BackColor = System.Drawing.Color.Red;
            this.btnDisconnectPLC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectPLC.Location = new System.Drawing.Point(199, 73);
            this.btnDisconnectPLC.Name = "btnDisconnectPLC";
            this.btnDisconnectPLC.Size = new System.Drawing.Size(136, 43);
            this.btnDisconnectPLC.TabIndex = 6;
            this.btnDisconnectPLC.Text = "PLC Disconnect";
            this.btnDisconnectPLC.UseVisualStyleBackColor = false;
            this.btnDisconnectPLC.Click += new System.EventHandler(this.btnDisconnectPLC_Click);
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.BackColor = System.Drawing.Color.Lime;
            this.btnConnectPLC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectPLC.Location = new System.Drawing.Point(32, 73);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(136, 43);
            this.btnConnectPLC.TabIndex = 5;
            this.btnConnectPLC.Text = "PLC Connect";
            this.btnConnectPLC.UseVisualStyleBackColor = false;
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Watchdog";
            // 
            // txtBoxWatchdog_value
            // 
            this.txtBoxWatchdog_value.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxWatchdog_value.Enabled = false;
            this.txtBoxWatchdog_value.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWatchdog_value.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxWatchdog_value.Location = new System.Drawing.Point(313, 17);
            this.txtBoxWatchdog_value.Name = "txtBoxWatchdog_value";
            this.txtBoxWatchdog_value.ReadOnly = true;
            this.txtBoxWatchdog_value.Size = new System.Drawing.Size(52, 25);
            this.txtBoxWatchdog_value.TabIndex = 3;
            this.txtBoxWatchdog_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(104, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 2;
            // 
            // lbPLCStatus
            // 
            this.lbPLCStatus.AutoSize = true;
            this.lbPLCStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLCStatus.ForeColor = System.Drawing.Color.Red;
            this.lbPLCStatus.Location = new System.Drawing.Point(131, 34);
            this.lbPLCStatus.Name = "lbPLCStatus";
            this.lbPLCStatus.Size = new System.Drawing.Size(92, 19);
            this.lbPLCStatus.TabIndex = 1;
            this.lbPLCStatus.Text = "Ngắt kết nối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết nối PLC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditData);
            this.groupBox2.Controls.Add(this.btnSaveData);
            this.groupBox2.Controls.Add(this.lbDataSource);
            this.groupBox2.Controls.Add(this.txtBoxDataPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxLoginName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtBoxDataName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBoxServerName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(427, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 445);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Setting";
            // 
            // btnEditData
            // 
            this.btnEditData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditData.Location = new System.Drawing.Point(246, 212);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(108, 46);
            this.btnEditData.TabIndex = 110;
            this.btnEditData.Text = "Edit";
            this.btnEditData.UseVisualStyleBackColor = false;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaveData.Enabled = false;
            this.btnSaveData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveData.Image")));
            this.btnSaveData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveData.Location = new System.Drawing.Point(360, 212);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(107, 46);
            this.btnSaveData.TabIndex = 18;
            this.btnSaveData.Text = "     Save";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // lbDataSource
            // 
            this.lbDataSource.AutoSize = true;
            this.lbDataSource.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbDataSource.Location = new System.Drawing.Point(6, 424);
            this.lbDataSource.Name = "lbDataSource";
            this.lbDataSource.Size = new System.Drawing.Size(72, 15);
            this.lbDataSource.TabIndex = 26;
            this.lbDataSource.Text = "Data Source=";
            // 
            // txtBoxDataPassword
            // 
            this.txtBoxDataPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDataPassword.Enabled = false;
            this.txtBoxDataPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDataPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxDataPassword.Location = new System.Drawing.Point(161, 176);
            this.txtBoxDataPassword.Name = "txtBoxDataPassword";
            this.txtBoxDataPassword.Size = new System.Drawing.Size(306, 25);
            this.txtBoxDataPassword.TabIndex = 25;
            this.txtBoxDataPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Server Name";
            // 
            // txtBoxLoginName
            // 
            this.txtBoxLoginName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxLoginName.Enabled = false;
            this.txtBoxLoginName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxLoginName.Location = new System.Drawing.Point(161, 137);
            this.txtBoxLoginName.Name = "txtBoxLoginName";
            this.txtBoxLoginName.Size = new System.Drawing.Size(306, 25);
            this.txtBoxLoginName.TabIndex = 24;
            this.txtBoxLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Database Name";
            // 
            // txtBoxDataName
            // 
            this.txtBoxDataName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDataName.Enabled = false;
            this.txtBoxDataName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDataName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxDataName.Location = new System.Drawing.Point(161, 98);
            this.txtBoxDataName.Name = "txtBoxDataName";
            this.txtBoxDataName.Size = new System.Drawing.Size(306, 25);
            this.txtBoxDataName.TabIndex = 23;
            this.txtBoxDataName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Login Username";
            // 
            // txtBoxServerName
            // 
            this.txtBoxServerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxServerName.Enabled = false;
            this.txtBoxServerName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServerName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxServerName.Location = new System.Drawing.Point(161, 59);
            this.txtBoxServerName.Name = "txtBoxServerName";
            this.txtBoxServerName.Size = new System.Drawing.Size(306, 25);
            this.txtBoxServerName.TabIndex = 22;
            this.txtBoxServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Database Password";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Hethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Hethong";
            this.Size = new System.Drawing.Size(1920, 970);
            this.Load += new System.EventHandler(this.UC_Hethong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxReconnectTime;
        private System.Windows.Forms.TextBox txtBoxPLCTimeout;
        private System.Windows.Forms.TextBox txtBoxPLCScantime;
        private System.Windows.Forms.TextBox txtBoxPLCType;
        private System.Windows.Forms.TextBox txtBoxPLCIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSavePLC;
        private System.Windows.Forms.TextBox txtBoxDataPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxLoginName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxDataName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxServerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveData;
        public System.Windows.Forms.Label lbPLCStatus;
        public System.Windows.Forms.TextBox txtBoxWatchdog_value;
        public System.Windows.Forms.Button btnDisconnectPLC;
        public System.Windows.Forms.Button btnConnectPLC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEditPLC;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Label lbDataSource;
    }
}
