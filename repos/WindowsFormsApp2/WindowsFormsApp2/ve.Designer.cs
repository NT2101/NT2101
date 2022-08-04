namespace WindowsFormsApp2
{
    partial class ve
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
            this.grvv = new System.Windows.Forms.DataGridView();
            this.mv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slvte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slvnl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvnl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbtk = new System.Windows.Forms.CheckBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgvte = new System.Windows.Forms.TextBox();
            this.txtgvnl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbk = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsvnl = new System.Windows.Forms.TextBox();
            this.svnl = new System.Windows.Forms.Label();
            this.txtsvte = new System.Windows.Forms.TextBox();
            this.svte = new System.Windows.Forms.Label();
            this.dtNI = new System.Windows.Forms.DateTimePicker();
            this.btxuat = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtmv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btlTinhTien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvv
            // 
            this.grvv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mv,
            this.ni,
            this.mk,
            this.slvte,
            this.slvnl,
            this.thanhtien,
            this.gvnl,
            this.gvte});
            this.grvv.Location = new System.Drawing.Point(60, 543);
            this.grvv.Name = "grvv";
            this.grvv.RowTemplate.Height = 24;
            this.grvv.Size = new System.Drawing.Size(938, 195);
            this.grvv.TabIndex = 41;
            this.grvv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvv_CellClick);
            // 
            // mv
            // 
            this.mv.DataPropertyName = "mv";
            this.mv.HeaderText = "Mã Vé";
            this.mv.Name = "mv";
            // 
            // ni
            // 
            this.ni.DataPropertyName = "ni";
            this.ni.HeaderText = "Ngày In";
            this.ni.Name = "ni";
            // 
            // mk
            // 
            this.mk.DataPropertyName = "mk";
            this.mk.HeaderText = "Khu";
            this.mk.Name = "mk";
            // 
            // slvte
            // 
            this.slvte.DataPropertyName = "slvte";
            this.slvte.HeaderText = "Số Vé Trẻ Em";
            this.slvte.Name = "slvte";
            this.slvte.Width = 150;
            // 
            // slvnl
            // 
            this.slvnl.DataPropertyName = "slvnl";
            this.slvnl.HeaderText = "Số vé người lớn";
            this.slvnl.Name = "slvnl";
            this.slvnl.Width = 150;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // gvnl
            // 
            this.gvnl.DataPropertyName = "gvnl";
            this.gvnl.HeaderText = "Giá vé người lớn";
            this.gvnl.Name = "gvnl";
            // 
            // gvte
            // 
            this.gvte.DataPropertyName = "gvte";
            this.gvte.HeaderText = "Giá vé trẻ em";
            this.gvte.Name = "gvte";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(527, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "Vé";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbtk);
            this.groupBox2.Controls.Add(this.txtTk);
            this.groupBox2.Location = new System.Drawing.Point(46, 447);
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
            this.cbtk.CheckedChanged += new System.EventHandler(this.cbtk_CheckedChanged_1);
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(153, 32);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(243, 22);
            this.txtTk.TabIndex = 28;
            this.txtTk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTk_KeyDown_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btlTinhTien);
            this.groupBox1.Controls.Add(this.txtthanhtien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtgvte);
            this.groupBox1.Controls.Add(this.txtgvnl);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsvnl);
            this.groupBox1.Controls.Add(this.svnl);
            this.groupBox1.Controls.Add(this.txtsvte);
            this.groupBox1.Controls.Add(this.svte);
            this.groupBox1.Controls.Add(this.dtNI);
            this.groupBox1.Controls.Add(this.btxuat);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.txtmv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 289);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(635, 159);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(231, 22);
            this.txtthanhtien.TabIndex = 40;
           
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Giá vé trẻ em";
            // 
            // txtgvte
            // 
            this.txtgvte.Location = new System.Drawing.Point(243, 123);
            this.txtgvte.Name = "txtgvte";
            this.txtgvte.Size = new System.Drawing.Size(231, 22);
            this.txtgvte.TabIndex = 37;
            // 
            // txtgvnl
            // 
            this.txtgvnl.Location = new System.Drawing.Point(243, 164);
            this.txtgvnl.Name = "txtgvnl";
            this.txtgvnl.Size = new System.Drawing.Size(231, 22);
            this.txtgvnl.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Giá vé người lớn";
            // 
            // cbk
            // 
            this.cbk.FormattingEnabled = true;
            this.cbk.Location = new System.Drawing.Point(636, 119);
            this.cbk.Name = "cbk";
            this.cbk.Size = new System.Drawing.Size(231, 24);
            this.cbk.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mã khu";
            // 
            // txtsvnl
            // 
            this.txtsvnl.Location = new System.Drawing.Point(636, 81);
            this.txtsvnl.Name = "txtsvnl";
            this.txtsvnl.Size = new System.Drawing.Size(231, 22);
            this.txtsvnl.TabIndex = 32;
            // 
            // svnl
            // 
            this.svnl.AutoSize = true;
            this.svnl.Location = new System.Drawing.Point(545, 81);
            this.svnl.Name = "svnl";
            this.svnl.Size = new System.Drawing.Size(68, 17);
            this.svnl.TabIndex = 31;
            this.svnl.Text = "Số Vé NL";
            // 
            // txtsvte
            // 
            this.txtsvte.Location = new System.Drawing.Point(636, 33);
            this.txtsvte.Name = "txtsvte";
            this.txtsvte.Size = new System.Drawing.Size(231, 22);
            this.txtsvte.TabIndex = 30;
            // 
            // svte
            // 
            this.svte.AutoSize = true;
            this.svte.Location = new System.Drawing.Point(543, 36);
            this.svte.Name = "svte";
            this.svte.Size = new System.Drawing.Size(68, 17);
            this.svte.TabIndex = 29;
            this.svte.Text = "Số Vé TE";
            // 
            // dtNI
            // 
            this.dtNI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNI.Location = new System.Drawing.Point(243, 82);
            this.dtNI.Name = "dtNI";
            this.dtNI.Size = new System.Drawing.Size(231, 22);
            this.dtNI.TabIndex = 28;
            // 
            // btxuat
            // 
            this.btxuat.Location = new System.Drawing.Point(739, 240);
            this.btxuat.Name = "btxuat";
            this.btxuat.Size = new System.Drawing.Size(75, 23);
            this.btxuat.TabIndex = 27;
            this.btxuat.Text = "Xuất";
            this.btxuat.UseVisualStyleBackColor = true;
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(635, 240);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 26;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(842, 240);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 25;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(842, 199);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 24;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(739, 199);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 23;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(635, 199);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 22;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtmv
            // 
            this.txtmv.Location = new System.Drawing.Point(243, 33);
            this.txtmv.Name = "txtmv";
            this.txtmv.Size = new System.Drawing.Size(231, 22);
            this.txtmv.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Vé";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btlTinhTien
            // 
            this.btlTinhTien.Location = new System.Drawing.Point(486, 199);
            this.btlTinhTien.Name = "btlTinhTien";
            this.btlTinhTien.Size = new System.Drawing.Size(125, 23);
            this.btlTinhTien.TabIndex = 41;
            this.btlTinhTien.Text = "Thành Tiền";
            this.btlTinhTien.UseVisualStyleBackColor = true;
            this.btlTinhTien.Click += new System.EventHandler(this.btlTinhTien_Click);
            // 
            // ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 750);
            this.Controls.Add(this.grvv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ve";
            this.Text = "ve";
            this.Load += new System.EventHandler(this.ve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbtk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNI;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtmv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsvte;
        private System.Windows.Forms.Label svte;
        private System.Windows.Forms.TextBox txtsvnl;
        private System.Windows.Forms.Label svnl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgvte;
        private System.Windows.Forms.TextBox txtgvnl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn mv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
        private System.Windows.Forms.DataGridViewTextBoxColumn slvte;
        private System.Windows.Forms.DataGridViewTextBoxColumn slvnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvte;
        private System.Windows.Forms.Button btlTinhTien;
    }
}