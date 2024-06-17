namespace Giaodiendieukhien
{
    partial class UC_Giamsat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxLoadcell1Max = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBunke1Weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStatusBunke1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxLoadcell2Max = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxBunke2Weight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxStatusBunke2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxStatusBunke3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtGVWeightBunke1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtGVWeightBunke2 = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dtGVDeviceBunke3 = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dtGVDevicesAndSignal = new System.Windows.Forms.DataGridView();
            this.zgchartBunkes = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_showdata = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVWeightBunke1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVWeightBunke2)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDeviceBunke3)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDevicesAndSignal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxLoadcell1Max);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxBunke1Weight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxStatusBunke1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtBoxLoadcell1Max
            // 
            this.txtBoxLoadcell1Max.Enabled = false;
            this.txtBoxLoadcell1Max.Location = new System.Drawing.Point(179, 171);
            this.txtBoxLoadcell1Max.Name = "txtBoxLoadcell1Max";
            this.txtBoxLoadcell1Max.ReadOnly = true;
            this.txtBoxLoadcell1Max.Size = new System.Drawing.Size(121, 25);
            this.txtBoxLoadcell1Max.TabIndex = 11;
            this.txtBoxLoadcell1Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Khối lượng cài đặt(max)";
            // 
            // txtBoxBunke1Weight
            // 
            this.txtBoxBunke1Weight.Enabled = false;
            this.txtBoxBunke1Weight.Location = new System.Drawing.Point(179, 108);
            this.txtBoxBunke1Weight.Name = "txtBoxBunke1Weight";
            this.txtBoxBunke1Weight.ReadOnly = true;
            this.txtBoxBunke1Weight.Size = new System.Drawing.Size(121, 25);
            this.txtBoxBunke1Weight.TabIndex = 5;
            this.txtBoxBunke1Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khối lượng thực tế";
            // 
            // txtBoxStatusBunke1
            // 
            this.txtBoxStatusBunke1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStatusBunke1.Location = new System.Drawing.Point(179, 49);
            this.txtBoxStatusBunke1.Name = "txtBoxStatusBunke1";
            this.txtBoxStatusBunke1.ReadOnly = true;
            this.txtBoxStatusBunke1.Size = new System.Drawing.Size(121, 25);
            this.txtBoxStatusBunke1.TabIndex = 3;
            this.txtBoxStatusBunke1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trạng thái Bunke";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 52;
            this.label6.Text = "Thông số Bunke 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 28);
            this.label8.TabIndex = 54;
            this.label8.Text = "Thông số Bunke 2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxLoadcell2Max);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxBunke2Weight);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtBoxStatusBunke2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(359, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 415);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // txtBoxLoadcell2Max
            // 
            this.txtBoxLoadcell2Max.Enabled = false;
            this.txtBoxLoadcell2Max.Location = new System.Drawing.Point(179, 172);
            this.txtBoxLoadcell2Max.Name = "txtBoxLoadcell2Max";
            this.txtBoxLoadcell2Max.ReadOnly = true;
            this.txtBoxLoadcell2Max.Size = new System.Drawing.Size(121, 25);
            this.txtBoxLoadcell2Max.TabIndex = 11;
            this.txtBoxLoadcell2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Khối lượng cài đặt(max)";
            // 
            // txtBoxBunke2Weight
            // 
            this.txtBoxBunke2Weight.Enabled = false;
            this.txtBoxBunke2Weight.Location = new System.Drawing.Point(179, 110);
            this.txtBoxBunke2Weight.Name = "txtBoxBunke2Weight";
            this.txtBoxBunke2Weight.ReadOnly = true;
            this.txtBoxBunke2Weight.Size = new System.Drawing.Size(121, 25);
            this.txtBoxBunke2Weight.TabIndex = 5;
            this.txtBoxBunke2Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Khối lượng thực tế";
            // 
            // txtBoxStatusBunke2
            // 
            this.txtBoxStatusBunke2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStatusBunke2.Location = new System.Drawing.Point(179, 51);
            this.txtBoxStatusBunke2.Name = "txtBoxStatusBunke2";
            this.txtBoxStatusBunke2.ReadOnly = true;
            this.txtBoxStatusBunke2.Size = new System.Drawing.Size(121, 25);
            this.txtBoxStatusBunke2.TabIndex = 3;
            this.txtBoxStatusBunke2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Trạng thái Bunke";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(779, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 28);
            this.label15.TabIndex = 54;
            this.label15.Text = "Thông số Bunke 3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxStatusBunke3);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(701, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 415);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            // 
            // txtBoxStatusBunke3
            // 
            this.txtBoxStatusBunke3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStatusBunke3.Location = new System.Drawing.Point(176, 52);
            this.txtBoxStatusBunke3.Name = "txtBoxStatusBunke3";
            this.txtBoxStatusBunke3.ReadOnly = true;
            this.txtBoxStatusBunke3.Size = new System.Drawing.Size(121, 25);
            this.txtBoxStatusBunke3.TabIndex = 3;
            this.txtBoxStatusBunke3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 19);
            this.label20.TabIndex = 2;
            this.label20.Text = "Trạng thái Bunke";
            // 
            // dtGVWeightBunke1
            // 
            this.dtGVWeightBunke1.AllowUserToAddRows = false;
            this.dtGVWeightBunke1.BackgroundColor = System.Drawing.Color.White;
            this.dtGVWeightBunke1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVWeightBunke1.Location = new System.Drawing.Point(0, 19);
            this.dtGVWeightBunke1.Name = "dtGVWeightBunke1";
            this.dtGVWeightBunke1.ReadOnly = true;
            this.dtGVWeightBunke1.RowHeadersVisible = false;
            this.dtGVWeightBunke1.Size = new System.Drawing.Size(323, 478);
            this.dtGVWeightBunke1.TabIndex = 55;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtGVWeightBunke1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 497);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khối lượng Bunke 1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtGVWeightBunke2);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(359, 441);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 497);
            this.groupBox5.TabIndex = 58;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Khối lượng Bunke 2";
            // 
            // dtGVWeightBunke2
            // 
            this.dtGVWeightBunke2.AllowUserToAddRows = false;
            this.dtGVWeightBunke2.BackgroundColor = System.Drawing.Color.White;
            this.dtGVWeightBunke2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVWeightBunke2.Location = new System.Drawing.Point(0, 19);
            this.dtGVWeightBunke2.Name = "dtGVWeightBunke2";
            this.dtGVWeightBunke2.ReadOnly = true;
            this.dtGVWeightBunke2.RowHeadersVisible = false;
            this.dtGVWeightBunke2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtGVWeightBunke2.Size = new System.Drawing.Size(323, 478);
            this.dtGVWeightBunke2.TabIndex = 55;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dtGVDeviceBunke3);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(701, 441);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(323, 497);
            this.groupBox9.TabIndex = 59;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Trạng thái Bunke 3";
            // 
            // dtGVDeviceBunke3
            // 
            this.dtGVDeviceBunke3.AllowUserToAddRows = false;
            this.dtGVDeviceBunke3.BackgroundColor = System.Drawing.Color.White;
            this.dtGVDeviceBunke3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVDeviceBunke3.Location = new System.Drawing.Point(0, 19);
            this.dtGVDeviceBunke3.Name = "dtGVDeviceBunke3";
            this.dtGVDeviceBunke3.ReadOnly = true;
            this.dtGVDeviceBunke3.RowHeadersVisible = false;
            this.dtGVDeviceBunke3.Size = new System.Drawing.Size(323, 478);
            this.dtGVDeviceBunke3.TabIndex = 55;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dtGVDevicesAndSignal);
            this.groupBox10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(1056, 15);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(836, 415);
            this.groupBox10.TabIndex = 60;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Trạng thái thiết bị và tín hiệu";
            // 
            // dtGVDevicesAndSignal
            // 
            this.dtGVDevicesAndSignal.AllowUserToAddRows = false;
            this.dtGVDevicesAndSignal.BackgroundColor = System.Drawing.Color.White;
            this.dtGVDevicesAndSignal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVDevicesAndSignal.Location = new System.Drawing.Point(0, 19);
            this.dtGVDevicesAndSignal.Name = "dtGVDevicesAndSignal";
            this.dtGVDevicesAndSignal.ReadOnly = true;
            this.dtGVDevicesAndSignal.RowHeadersVisible = false;
            this.dtGVDevicesAndSignal.Size = new System.Drawing.Size(836, 396);
            this.dtGVDevicesAndSignal.TabIndex = 55;
            // 
            // zgchartBunkes
            // 
            this.zgchartBunkes.IsEnableHZoom = false;
            this.zgchartBunkes.IsEnableVZoom = false;
            this.zgchartBunkes.Location = new System.Drawing.Point(1056, 460);
            this.zgchartBunkes.Name = "zgchartBunkes";
            this.zgchartBunkes.ScrollGrace = 0D;
            this.zgchartBunkes.ScrollMaxX = 0D;
            this.zgchartBunkes.ScrollMaxY = 0D;
            this.zgchartBunkes.ScrollMaxY2 = 0D;
            this.zgchartBunkes.ScrollMinX = 0D;
            this.zgchartBunkes.ScrollMinY = 0D;
            this.zgchartBunkes.ScrollMinY2 = 0D;
            this.zgchartBunkes.Size = new System.Drawing.Size(861, 478);
            this.zgchartBunkes.TabIndex = 0;
            this.zgchartBunkes.UseExtendedPrintDialog = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_showdata
            // 
            this.timer_showdata.Interval = 5000;
            this.timer_showdata.Tick += new System.EventHandler(this.timer_showdata_Tick);
            // 
            // UC_Giamsat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.zgchartBunkes);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Giamsat";
            this.Size = new System.Drawing.Size(1920, 970);
            this.Load += new System.EventHandler(this.UC_Giamsat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVWeightBunke1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVWeightBunke2)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDeviceBunke3)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDevicesAndSignal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private ZedGraph.ZedGraphControl zgchartBunkes;
        public System.Windows.Forms.TextBox txtBoxBunke1Weight;
        public System.Windows.Forms.TextBox txtBoxStatusBunke1;
        public System.Windows.Forms.TextBox txtBoxLoadcell1Max;
        public System.Windows.Forms.TextBox txtBoxLoadcell2Max;
        public System.Windows.Forms.TextBox txtBoxBunke2Weight;
        public System.Windows.Forms.TextBox txtBoxStatusBunke2;
        public System.Windows.Forms.TextBox txtBoxStatusBunke3;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dtGVWeightBunke1;
        public System.Windows.Forms.DataGridView dtGVWeightBunke2;
        public System.Windows.Forms.DataGridView dtGVDeviceBunke3;
        public System.Windows.Forms.DataGridView dtGVDevicesAndSignal;
        public System.Windows.Forms.Timer timer_showdata;
    }
}
