namespace Giaodiendieukhien
{
    partial class Form_User
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMinimizeUF = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCloseappUF = new System.Windows.Forms.Button();
            this.pnlTabsUF = new System.Windows.Forms.Panel();
            this.pnlReportUF = new System.Windows.Forms.Panel();
            this.pnlControlUF = new System.Windows.Forms.Panel();
            this.pnlMonitorUF = new System.Windows.Forms.Panel();
            this.btnReportUF = new System.Windows.Forms.Button();
            this.btnControlUF = new System.Windows.Forms.Button();
            this.btnMonitorUF = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPLCStatusUF = new System.Windows.Forms.Label();
            this.lbUserUF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMainUF = new System.Windows.Forms.Panel();
            this.Timer_Watchdog = new System.Windows.Forms.Timer(this.components);
            this.Reconnect_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlTabsUF.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnMinimizeUF);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCloseappUF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 32);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btnMinimizeUF
            // 
            this.btnMinimizeUF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizeUF.BackgroundImage")));
            this.btnMinimizeUF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizeUF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeUF.FlatAppearance.BorderSize = 0;
            this.btnMinimizeUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeUF.Location = new System.Drawing.Point(1298, 0);
            this.btnMinimizeUF.Name = "btnMinimizeUF";
            this.btnMinimizeUF.Size = new System.Drawing.Size(34, 32);
            this.btnMinimizeUF.TabIndex = 1;
            this.btnMinimizeUF.UseVisualStyleBackColor = true;
            this.btnMinimizeUF.Click += new System.EventHandler(this.btnMinimizeUF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giao diện giám sát, điều khiển dòng than";
            // 
            // btnCloseappUF
            // 
            this.btnCloseappUF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseappUF.BackgroundImage")));
            this.btnCloseappUF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseappUF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseappUF.FlatAppearance.BorderSize = 0;
            this.btnCloseappUF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseappUF.Location = new System.Drawing.Point(1332, 0);
            this.btnCloseappUF.Name = "btnCloseappUF";
            this.btnCloseappUF.Size = new System.Drawing.Size(34, 32);
            this.btnCloseappUF.TabIndex = 2;
            this.btnCloseappUF.UseVisualStyleBackColor = true;
            this.btnCloseappUF.Click += new System.EventHandler(this.btnCloseappUF_Click);
            // 
            // pnlTabsUF
            // 
            this.pnlTabsUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.pnlTabsUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTabsUF.Controls.Add(this.pnlReportUF);
            this.pnlTabsUF.Controls.Add(this.pnlControlUF);
            this.pnlTabsUF.Controls.Add(this.pnlMonitorUF);
            this.pnlTabsUF.Controls.Add(this.btnReportUF);
            this.pnlTabsUF.Controls.Add(this.btnControlUF);
            this.pnlTabsUF.Controls.Add(this.btnMonitorUF);
            this.pnlTabsUF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabsUF.ForeColor = System.Drawing.Color.White;
            this.pnlTabsUF.Location = new System.Drawing.Point(0, 32);
            this.pnlTabsUF.Name = "pnlTabsUF";
            this.pnlTabsUF.Size = new System.Drawing.Size(1366, 50);
            this.pnlTabsUF.TabIndex = 2;
            // 
            // pnlReportUF
            // 
            this.pnlReportUF.BackColor = System.Drawing.Color.White;
            this.pnlReportUF.Location = new System.Drawing.Point(307, 4);
            this.pnlReportUF.Name = "pnlReportUF";
            this.pnlReportUF.Size = new System.Drawing.Size(9, 9);
            this.pnlReportUF.TabIndex = 10;
            // 
            // pnlControlUF
            // 
            this.pnlControlUF.BackColor = System.Drawing.Color.Lime;
            this.pnlControlUF.Location = new System.Drawing.Point(102, 4);
            this.pnlControlUF.Name = "pnlControlUF";
            this.pnlControlUF.Size = new System.Drawing.Size(9, 9);
            this.pnlControlUF.TabIndex = 10;
            // 
            // pnlMonitorUF
            // 
            this.pnlMonitorUF.BackColor = System.Drawing.Color.White;
            this.pnlMonitorUF.Location = new System.Drawing.Point(209, 4);
            this.pnlMonitorUF.Name = "pnlMonitorUF";
            this.pnlMonitorUF.Size = new System.Drawing.Size(9, 9);
            this.pnlMonitorUF.TabIndex = 10;
            // 
            // btnReportUF
            // 
            this.btnReportUF.BackColor = System.Drawing.Color.White;
            this.btnReportUF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportUF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportUF.ForeColor = System.Drawing.Color.Black;
            this.btnReportUF.Image = ((System.Drawing.Image)(resources.GetObject("btnReportUF.Image")));
            this.btnReportUF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportUF.Location = new System.Drawing.Point(224, -1);
            this.btnReportUF.Name = "btnReportUF";
            this.btnReportUF.Size = new System.Drawing.Size(99, 48);
            this.btnReportUF.TabIndex = 3;
            this.btnReportUF.Text = "Báo cáo";
            this.btnReportUF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportUF.UseVisualStyleBackColor = false;
            this.btnReportUF.Click += new System.EventHandler(this.click_Button);
            // 
            // btnControlUF
            // 
            this.btnControlUF.BackColor = System.Drawing.Color.White;
            this.btnControlUF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnControlUF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlUF.ForeColor = System.Drawing.Color.Black;
            this.btnControlUF.Image = ((System.Drawing.Image)(resources.GetObject("btnControlUF.Image")));
            this.btnControlUF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControlUF.Location = new System.Drawing.Point(-1, -1);
            this.btnControlUF.Name = "btnControlUF";
            this.btnControlUF.Size = new System.Drawing.Size(119, 48);
            this.btnControlUF.TabIndex = 2;
            this.btnControlUF.Text = "Điều khiển";
            this.btnControlUF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnControlUF.UseVisualStyleBackColor = false;
            this.btnControlUF.Click += new System.EventHandler(this.click_Button);
            // 
            // btnMonitorUF
            // 
            this.btnMonitorUF.BackColor = System.Drawing.Color.White;
            this.btnMonitorUF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonitorUF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorUF.ForeColor = System.Drawing.Color.Black;
            this.btnMonitorUF.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitorUF.Image")));
            this.btnMonitorUF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitorUF.Location = new System.Drawing.Point(117, -1);
            this.btnMonitorUF.Name = "btnMonitorUF";
            this.btnMonitorUF.Size = new System.Drawing.Size(108, 48);
            this.btnMonitorUF.TabIndex = 1;
            this.btnMonitorUF.Text = "Giám sát";
            this.btnMonitorUF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonitorUF.UseVisualStyleBackColor = false;
            this.btnMonitorUF.Click += new System.EventHandler(this.click_Button);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lbPLCStatusUF);
            this.panel3.Controls.Add(this.lbUserUF);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 736);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 32);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(564, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 6;
            // 
            // lbPLCStatusUF
            // 
            this.lbPLCStatusUF.AutoSize = true;
            this.lbPLCStatusUF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLCStatusUF.ForeColor = System.Drawing.Color.Red;
            this.lbPLCStatusUF.Location = new System.Drawing.Point(591, 7);
            this.lbPLCStatusUF.Name = "lbPLCStatusUF";
            this.lbPLCStatusUF.Size = new System.Drawing.Size(92, 19);
            this.lbPLCStatusUF.TabIndex = 5;
            this.lbPLCStatusUF.Text = "Ngắt kết nối";
            // 
            // lbUserUF
            // 
            this.lbUserUF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserUF.Location = new System.Drawing.Point(31, 5);
            this.lbUserUF.Name = "lbUserUF";
            this.lbUserUF.Size = new System.Drawing.Size(106, 23);
            this.lbUserUF.TabIndex = 9;
            this.lbUserUF.Text = "label1";
            this.lbUserUF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(1132, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(144, 32);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1276, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMainUF
            // 
            this.pnlMainUF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.pnlMainUF.Location = new System.Drawing.Point(0, 82);
            this.pnlMainUF.Name = "pnlMainUF";
            this.pnlMainUF.Size = new System.Drawing.Size(1366, 654);
            this.pnlMainUF.TabIndex = 4;
            // 
            // Timer_Watchdog
            // 
            this.Timer_Watchdog.Interval = 3000;
            this.Timer_Watchdog.Tick += new System.EventHandler(this.Timer_Watchdog_Tick);
            // 
            // Reconnect_Timer
            // 
            this.Reconnect_Timer.Tick += new System.EventHandler(this.Reconnect_Timer_Tick);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlMainUF);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTabsUF);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_User";
            this.Text = "Form_User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlTabsUF.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMinimizeUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCloseappUF;
        private System.Windows.Forms.Panel pnlTabsUF;
        private System.Windows.Forms.Button btnReportUF;
        private System.Windows.Forms.Button btnControlUF;
        private System.Windows.Forms.Button btnMonitorUF;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        public System.Windows.Forms.Label lbUserUF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMainUF;
        private System.Windows.Forms.Panel pnlReportUF;
        private System.Windows.Forms.Panel pnlControlUF;
        private System.Windows.Forms.Panel pnlMonitorUF;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbPLCStatusUF;
        private System.Windows.Forms.Timer Timer_Watchdog;
        private System.Windows.Forms.Timer Reconnect_Timer;
    }
}