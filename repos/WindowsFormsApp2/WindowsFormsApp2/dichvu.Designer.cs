namespace WindowsFormsApp2
{
    partial class dichvu
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
            this.grvdv = new System.Windows.Forms.DataGridView();
            this.mdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbtk = new System.Windows.Forms.CheckBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbk = new System.Windows.Forms.ComboBox();
            this.btxuat = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txttdv = new System.Windows.Forms.TextBox();
            this.txtmdv = new System.Windows.Forms.TextBox();
            this.txtgdv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvdv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvdv
            // 
            this.grvdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mdv,
            this.tdv,
            this.mk,
            this.gdv});
            this.grvdv.Location = new System.Drawing.Point(67, 494);
            this.grvdv.Name = "grvdv";
            this.grvdv.RowTemplate.Height = 24;
            this.grvdv.Size = new System.Drawing.Size(604, 265);
            this.grvdv.TabIndex = 41;
            this.grvdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvdv_CellClick);
            // 
            // mdv
            // 
            this.mdv.DataPropertyName = "mdv";
            this.mdv.HeaderText = "Mã Dịch Vụ";
            this.mdv.Name = "mdv";
            // 
            // tdv
            // 
            this.tdv.DataPropertyName = "tdv";
            this.tdv.HeaderText = "Tên Dịch Vụ";
            this.tdv.Name = "tdv";
            // 
            // mk
            // 
            this.mk.DataPropertyName = "mk";
            this.mk.HeaderText = "Mã Khu";
            this.mk.Name = "mk";
            // 
            // gdv
            // 
            this.gdv.DataPropertyName = "gdv";
            this.gdv.HeaderText = "Giá Dịch Vụ";
            this.gdv.Name = "gdv";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(551, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "Dịch Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtk);
            this.groupBox2.Controls.Add(this.txtTk);
            this.groupBox2.Location = new System.Drawing.Point(67, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 77);
            this.groupBox2.TabIndex = 39;
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
            this.groupBox1.Controls.Add(this.cbk);
            this.groupBox1.Controls.Add(this.btxuat);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.txttdv);
            this.groupBox1.Controls.Add(this.txtmdv);
            this.groupBox1.Controls.Add(this.txtgdv);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 231);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // cbk
            // 
            this.cbk.FormattingEnabled = true;
            this.cbk.Location = new System.Drawing.Point(733, 31);
            this.cbk.Name = "cbk";
            this.cbk.Size = new System.Drawing.Size(129, 24);
            this.cbk.TabIndex = 28;
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
            // txttdv
            // 
            this.txttdv.Location = new System.Drawing.Point(243, 33);
            this.txttdv.Name = "txttdv";
            this.txttdv.Size = new System.Drawing.Size(129, 22);
            this.txttdv.TabIndex = 21;
            // 
            // txtmdv
            // 
            this.txtmdv.Location = new System.Drawing.Point(243, 84);
            this.txtmdv.Name = "txtmdv";
            this.txtmdv.Size = new System.Drawing.Size(129, 22);
            this.txtmdv.TabIndex = 20;
            // 
            // txtgdv
            // 
            this.txtgdv.Location = new System.Drawing.Point(733, 86);
            this.txtgdv.Name = "txtgdv";
            this.txtgdv.Size = new System.Drawing.Size(129, 22);
            this.txtgdv.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Giá Dịch Vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã Khu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 726);
            this.Controls.Add(this.grvdv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "dichvu";
            this.Text = "dichvu";
            this.Load += new System.EventHandler(this.dichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvdv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvdv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbtk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbk;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txttdv;
        private System.Windows.Forms.TextBox txtmdv;
        private System.Windows.Forms.TextBox txtgdv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdv;
    }
}