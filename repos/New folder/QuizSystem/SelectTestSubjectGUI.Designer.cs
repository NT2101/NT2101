namespace QuizSystem
{
    partial class SelectTestSubjectGUI
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
            this.grbInforStudent = new DevExpress.XtraEditors.GroupControl();
            this.txtFacalty = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.picAvaStudent = new System.Windows.Forms.PictureBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.grbInforQuiz = new DevExpress.XtraEditors.GroupControl();
            this.cboChooseQuiz = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grbInforStudent)).BeginInit();
            this.grbInforStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvaStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbInforQuiz)).BeginInit();
            this.grbInforQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInforStudent
            // 
            this.grbInforStudent.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grbInforStudent.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grbInforStudent.AppearanceCaption.Options.UseFont = true;
            this.grbInforStudent.AppearanceCaption.Options.UseForeColor = true;
            this.grbInforStudent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.grbInforStudent.CaptionImage = global::QuizSystem.Properties.Resources.student__2_;
            this.grbInforStudent.Controls.Add(this.txtBirthDate);
            this.grbInforStudent.Controls.Add(this.txtFacalty);
            this.grbInforStudent.Controls.Add(this.labelControl1);
            this.grbInforStudent.Controls.Add(this.labelControl4);
            this.grbInforStudent.Controls.Add(this.labelControl3);
            this.grbInforStudent.Controls.Add(this.labelControl2);
            this.grbInforStudent.Controls.Add(this.txtStudentName);
            this.grbInforStudent.Controls.Add(this.picAvaStudent);
            this.grbInforStudent.Controls.Add(this.txtStudentID);
            this.grbInforStudent.Location = new System.Drawing.Point(12, 12);
            this.grbInforStudent.Name = "grbInforStudent";
            this.grbInforStudent.Size = new System.Drawing.Size(510, 172);
            this.grbInforStudent.TabIndex = 17;
            this.grbInforStudent.Text = "Thông Tin Sinh Viên";
            // 
            // txtFacalty
            // 
            this.txtFacalty.Enabled = false;
            this.txtFacalty.Location = new System.Drawing.Point(196, 140);
            this.txtFacalty.Name = "txtFacalty";
            this.txtFacalty.Size = new System.Drawing.Size(204, 21);
            this.txtFacalty.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl1.Location = new System.Drawing.Point(152, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 16);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Khoa";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl4.Location = new System.Drawing.Point(123, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Ngày Sinh";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl3.Location = new System.Drawing.Point(146, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 16);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "MSSV";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(136, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 17);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Họ Tên";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Location = new System.Drawing.Point(196, 65);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(280, 21);
            this.txtStudentName.TabIndex = 2;
            // 
            // picAvaStudent
            // 
            this.picAvaStudent.Image = global::QuizSystem.Properties.Resources.student1;
            this.picAvaStudent.Location = new System.Drawing.Point(22, 47);
            this.picAvaStudent.Name = "picAvaStudent";
            this.picAvaStudent.Size = new System.Drawing.Size(95, 101);
            this.picAvaStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvaStudent.TabIndex = 1;
            this.picAvaStudent.TabStop = false;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(196, 27);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(164, 21);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.Enter += new System.EventHandler(this.txtStudentID_Enter);
            this.txtStudentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentID_KeyDown);
            // 
            // grbInforQuiz
            // 
            this.grbInforQuiz.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grbInforQuiz.AppearanceCaption.ForeColor = System.Drawing.Color.Olive;
            this.grbInforQuiz.AppearanceCaption.Options.UseFont = true;
            this.grbInforQuiz.AppearanceCaption.Options.UseForeColor = true;
            this.grbInforQuiz.CaptionImage = global::QuizSystem.Properties.Resources.exam1;
            this.grbInforQuiz.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.grbInforQuiz.Controls.Add(this.cboChooseQuiz);
            this.grbInforQuiz.Controls.Add(this.txtSubject);
            this.grbInforQuiz.Controls.Add(this.labelControl5);
            this.grbInforQuiz.Controls.Add(this.labelControl6);
            this.grbInforQuiz.Controls.Add(this.pictureBox2);
            this.grbInforQuiz.Location = new System.Drawing.Point(12, 190);
            this.grbInforQuiz.Name = "grbInforQuiz";
            this.grbInforQuiz.Size = new System.Drawing.Size(510, 138);
            this.grbInforQuiz.TabIndex = 16;
            this.grbInforQuiz.Text = "Nhập Thông Tin Đề Thi";
            // 
            // cboChooseQuiz
            // 
            this.cboChooseQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChooseQuiz.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic);
            this.cboChooseQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboChooseQuiz.FormattingEnabled = true;
            this.cboChooseQuiz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboChooseQuiz.Items.AddRange(new object[] {
            "Dễ",
            "Khó",
            "Rất Dễ",
            "Rất Khó",
            "Trung Bình"});
            this.cboChooseQuiz.Location = new System.Drawing.Point(199, 37);
            this.cboChooseQuiz.Name = "cboChooseQuiz";
            this.cboChooseQuiz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChooseQuiz.Size = new System.Drawing.Size(202, 26);
            this.cboChooseQuiz.TabIndex = 32;
            this.cboChooseQuiz.Text = "--Lựa Chọn--";
            this.cboChooseQuiz.DropDown += new System.EventHandler(this.cboChooseQuiz_DropDown);
            // 
            // txtSubject
            // 
            this.txtSubject.Enabled = false;
            this.txtSubject.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSubject.ForeColor = System.Drawing.Color.Maroon;
            this.txtSubject.Location = new System.Drawing.Point(197, 86);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(204, 24);
            this.txtSubject.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl5.Location = new System.Drawing.Point(152, 46);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 17);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Mã Đề";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl6.Location = new System.Drawing.Point(123, 91);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 16);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Mã Môn Thi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuizSystem.Properties.Resources.test1;
            this.pictureBox2.Location = new System.Drawing.Point(22, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(288, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOK.Appearance.Options.UseForeColor = true;
            this.btnOK.Location = new System.Drawing.Point(177, 334);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 39);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Enabled = false;
            this.txtBirthDate.Location = new System.Drawing.Point(196, 102);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(164, 21);
            this.txtBirthDate.TabIndex = 30;
            // 
            // SelectTestSubjectGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(534, 383);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grbInforStudent);
            this.Controls.Add(this.grbInforQuiz);
            this.Name = "SelectTestSubjectGUI";
            this.Text = "Chọn Môn Thi";
            this.Load += new System.EventHandler(this.SelectTestSubjectGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbInforStudent)).EndInit();
            this.grbInforStudent.ResumeLayout(false);
            this.grbInforStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvaStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbInforQuiz)).EndInit();
            this.grbInforQuiz.ResumeLayout(false);
            this.grbInforQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbInforStudent;
        private System.Windows.Forms.TextBox txtFacalty;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.PictureBox picAvaStudent;
        private System.Windows.Forms.TextBox txtStudentID;
        private DevExpress.XtraEditors.GroupControl grbInforQuiz;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cboChooseQuiz;
        private System.Windows.Forms.TextBox txtBirthDate;
    }
}