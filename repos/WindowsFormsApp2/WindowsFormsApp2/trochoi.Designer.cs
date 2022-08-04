namespace WindowsFormsApp2
{
    partial class trochoi
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
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.txtttc = new System.Windows.Forms.TextBox();
            this.txtmtc = new System.Windows.Forms.TextBox();
            this.btxuat = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvtc = new System.Windows.Forms.DataGridView();
            this.ttc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dientich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvtc)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(394, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 29);
            this.label11.TabIndex = 42;
            this.label11.Text = "Trò Chơi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtk);
            this.groupBox2.Controls.Add(this.txtTk);
            this.groupBox2.Location = new System.Drawing.Point(28, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 77);
            this.groupBox2.TabIndex = 41;
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
            this.groupBox1.Controls.Add(this.txtdientich);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbtrangthai);
            this.groupBox1.Controls.Add(this.txtttc);
            this.groupBox1.Controls.Add(this.txtmtc);
            this.groupBox1.Controls.Add(this.btxuat);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.txtvitri);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 231);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtdientich
            // 
            this.txtdientich.Location = new System.Drawing.Point(258, 123);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.Size = new System.Drawing.Size(129, 22);
            this.txtdientich.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Diện tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Trạng thái";
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Bảo trì",
            "Hỏng",
            "Sử dụng dược"});
            this.cbtrangthai.Location = new System.Drawing.Point(635, 79);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(132, 24);
            this.cbtrangthai.TabIndex = 32;
            // 
            // txtttc
            // 
            this.txtttc.Location = new System.Drawing.Point(258, 28);
            this.txtttc.Name = "txtttc";
            this.txtttc.Size = new System.Drawing.Size(129, 22);
            this.txtttc.TabIndex = 29;
            // 
            // txtmtc
            // 
            this.txtmtc.Location = new System.Drawing.Point(258, 81);
            this.txtmtc.Name = "txtmtc";
            this.txtmtc.Size = new System.Drawing.Size(129, 22);
            this.txtmtc.TabIndex = 28;
            // 
            // btxuat
            // 
            this.btxuat.Location = new System.Drawing.Point(879, 178);
            this.btxuat.Name = "btxuat";
            this.btxuat.Size = new System.Drawing.Size(75, 23);
            this.btxuat.TabIndex = 27;
            this.btxuat.Text = "Xuất";
            this.btxuat.UseVisualStyleBackColor = true;
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(787, 178);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 26;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(857, 445);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 25;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(978, 122);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 24;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(879, 122);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 23;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(787, 122);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 22;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(635, 33);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(129, 22);
            this.txtvitri.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Vị Trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Trò Chơi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Trò Chơi";
            // 
            // grvtc
            // 
            this.grvtc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvtc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ttc,
            this.mtc,
            this.dientich,
            this.vitri});
            this.grvtc.Location = new System.Drawing.Point(28, 511);
            this.grvtc.Name = "grvtc";
            this.grvtc.RowTemplate.Height = 24;
            this.grvtc.Size = new System.Drawing.Size(660, 233);
            this.grvtc.TabIndex = 43;
            this.grvtc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvtc_CellClick);
            // 
            // ttc
            // 
            this.ttc.DataPropertyName = "ttc";
            this.ttc.FillWeight = 150F;
            this.ttc.HeaderText = "Tên Trò Chơi";
            this.ttc.Name = "ttc";
            this.ttc.Width = 150;
            // 
            // mtc
            // 
            this.mtc.DataPropertyName = "mtc";
            this.mtc.HeaderText = "Mã Trò Chơi";
            this.mtc.Name = "mtc";
            this.mtc.Width = 150;
            // 
            // dientich
            // 
            this.dientich.DataPropertyName = "dientich";
            this.dientich.HeaderText = "Diện tích";
            this.dientich.Name = "dientich";
            // 
            // vitri
            // 
            this.vitri.DataPropertyName = "vitri";
            this.vitri.HeaderText = "Vị Trí";
            this.vitri.Name = "vitri";
            // 
            // trochoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 775);
            this.Controls.Add(this.grvtc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btthoat);
            this.Name = "trochoi";
            this.Text = "trochoi";
            this.Load += new System.EventHandler(this.trochoi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvtc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbtk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvtc;
        private System.Windows.Forms.TextBox txtttc;
        private System.Windows.Forms.TextBox txtmtc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.TextBox txtdientich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dientich;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitri;
    }
}