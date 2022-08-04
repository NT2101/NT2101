namespace WindowsFormsApp2
{
    partial class khuvuichoi
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
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbtk = new System.Windows.Forms.CheckBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbttc = new System.Windows.Forms.ComboBox();
            this.dtgdc = new System.Windows.Forms.DateTimePicker();
            this.btxuat = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.cbk = new System.Windows.Forms.ComboBox();
            this.dtgmc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grvkvc = new System.Windows.Forms.DataGridView();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvkvc)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(396, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 29);
            this.label11.TabIndex = 32;
            this.label11.Text = "Khu Vui Chơi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtk);
            this.groupBox2.Controls.Add(this.txtTk);
            this.groupBox2.Location = new System.Drawing.Point(27, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 77);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // cbtk
            // 
            this.cbtk.AutoSize = true;
            this.cbtk.Location = new System.Drawing.Point(24, 33);
            this.cbtk.Name = "cbtk";
            this.cbtk.Size = new System.Drawing.Size(86, 21);
            this.cbtk.TabIndex = 29;
            this.cbtk.Text = "Tìm kiếm";
            this.cbtk.UseVisualStyleBackColor = true;
            this.cbtk.CheckedChanged += new System.EventHandler(this.cbtk_CheckedChanged);
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(153, 32);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(243, 22);
            this.txtTk.TabIndex = 28;
            this.txtTk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTk_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbttc);
            this.groupBox1.Controls.Add(this.dtgdc);
            this.groupBox1.Controls.Add(this.btxuat);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.cbk);
            this.groupBox1.Controls.Add(this.dtgmc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 231);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbttc
            // 
            this.cbttc.FormattingEnabled = true;
            this.cbttc.Location = new System.Drawing.Point(243, 75);
            this.cbttc.Name = "cbttc";
            this.cbttc.Size = new System.Drawing.Size(133, 24);
            this.cbttc.TabIndex = 31;
            // 
            // dtgdc
            // 
            this.dtgdc.CustomFormat = "";
            this.dtgdc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgdc.Location = new System.Drawing.Point(505, 72);
            this.dtgdc.Name = "dtgdc";
            this.dtgdc.Size = new System.Drawing.Size(231, 22);
            this.dtgdc.TabIndex = 28;
            // 
            // btxuat
            // 
            this.btxuat.Location = new System.Drawing.Point(850, 178);
            this.btxuat.Name = "btxuat";
            this.btxuat.Size = new System.Drawing.Size(75, 23);
            this.btxuat.TabIndex = 27;
            this.btxuat.Text = "Xuất";
            this.btxuat.UseVisualStyleBackColor = true;
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(746, 178);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 26;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(953, 178);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 25;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(953, 122);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 24;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(850, 122);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 23;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(746, 122);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 22;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // cbk
            // 
            this.cbk.FormattingEnabled = true;
            this.cbk.Location = new System.Drawing.Point(243, 26);
            this.cbk.Name = "cbk";
            this.cbk.Size = new System.Drawing.Size(129, 24);
            this.cbk.TabIndex = 14;
            // 
            // dtgmc
            // 
            this.dtgmc.CustomFormat = "";
            this.dtgmc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgmc.Location = new System.Drawing.Point(505, 28);
            this.dtgmc.Name = "dtgmc";
            this.dtgmc.Size = new System.Drawing.Size(231, 22);
            this.dtgmc.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã Khu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Trò Chơi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ đóng cửa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ mở cửa";
            // 
            // grvkvc
            // 
            this.grvkvc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvkvc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mk,
            this.ttc,
            this.gmc,
            this.gdc});
            this.grvkvc.Location = new System.Drawing.Point(89, 476);
            this.grvkvc.Name = "grvkvc";
            this.grvkvc.RowTemplate.Height = 24;
            this.grvkvc.Size = new System.Drawing.Size(895, 194);
            this.grvkvc.TabIndex = 33;
            this.grvkvc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvkvc_CellClick);
            // 
            // mk
            // 
            this.mk.DataPropertyName = "mk";
            this.mk.HeaderText = "Mã Khu";
            this.mk.Name = "mk";
            // 
            // ttc
            // 
            this.ttc.DataPropertyName = "ttc";
            this.ttc.HeaderText = "Tên trò chơi";
            this.ttc.Name = "ttc";
            this.ttc.Width = 150;
            // 
            // gmc
            // 
            this.gmc.DataPropertyName = "gmc";
            this.gmc.HeaderText = "Giờ Mở Cửa";
            this.gmc.Name = "gmc";
            this.gmc.Width = 150;
            // 
            // gdc
            // 
            this.gdc.DataPropertyName = "gdc";
            this.gdc.HeaderText = "Giờ Đóng Cửa";
            this.gdc.Name = "gdc";
            this.gdc.Width = 150;
            // 
            // khuvuichoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 717);
            this.Controls.Add(this.grvkvc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "khuvuichoi";
            this.Text = "khuvuichoi";
            this.Load += new System.EventHandler(this.khuvuichoi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvkvc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbtk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtgdc;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.ComboBox cbk;
        private System.Windows.Forms.DateTimePicker dtgmc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grvkvc;
        private System.Windows.Forms.ComboBox cbttc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdc;
    }
}