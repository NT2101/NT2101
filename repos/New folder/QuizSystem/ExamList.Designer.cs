namespace QuizSystem
{
    partial class ExamList
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
            this.btnToLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnToRight = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cboChooseLecturer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridExamList = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridStudentList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.cboChooseRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateNewQuiz = new DevExpress.XtraEditors.SimpleButton();
            this.cboChooseSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToLeft
            // 
            this.btnToLeft.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnToLeft.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnToLeft.Appearance.Options.UseFont = true;
            this.btnToLeft.Appearance.Options.UseForeColor = true;
            this.btnToLeft.Image = global::QuizSystem.Properties.Resources.chevron;
            this.btnToLeft.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnToLeft.Location = new System.Drawing.Point(477, 303);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(91, 75);
            this.btnToLeft.TabIndex = 31;
            this.btnToLeft.Text = "Qua Trái";
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnToRight.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnToRight.Appearance.Options.UseFont = true;
            this.btnToRight.Appearance.Options.UseForeColor = true;
            this.btnToRight.Image = global::QuizSystem.Properties.Resources.chevron__1_;
            this.btnToRight.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnToRight.Location = new System.Drawing.Point(477, 191);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(91, 75);
            this.btnToRight.TabIndex = 30;
            this.btnToRight.Text = "Qua Phải";
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Olive;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.CaptionImage = global::QuizSystem.Properties.Resources.checklist;
            this.groupControl3.Controls.Add(this.gridExamList);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl3.Location = new System.Drawing.Point(586, 103);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(429, 375);
            this.groupControl3.TabIndex = 27;
            this.groupControl3.Text = "Danh Sách Sinh Viên Thi";
            // 
            // cboChooseLecturer
            // 
            this.cboChooseLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChooseLecturer.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic);
            this.cboChooseLecturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cboChooseLecturer.FormattingEnabled = true;
            this.cboChooseLecturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboChooseLecturer.Items.AddRange(new object[] {
            "Dễ",
            "Khó",
            "Rất Dễ",
            "Rất Khó",
            "Trung Bình"});
            this.cboChooseLecturer.Location = new System.Drawing.Point(364, 65);
            this.cboChooseLecturer.Name = "cboChooseLecturer";
            this.cboChooseLecturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChooseLecturer.Size = new System.Drawing.Size(251, 26);
            this.cboChooseLecturer.TabIndex = 34;
            this.cboChooseLecturer.Text = "--Lựa Chọn--";
            this.cboChooseLecturer.DropDown += new System.EventHandler(this.cboChooseLecturer_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(361, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Chọn Giám Thị:";
            // 
            // gridExamList
            // 
            this.gridExamList.Location = new System.Drawing.Point(16, 35);
            this.gridExamList.MainView = this.gridView2;
            this.gridExamList.Name = "gridExamList";
            this.gridExamList.Size = new System.Drawing.Size(408, 308);
            this.gridExamList.TabIndex = 0;
            this.gridExamList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Navy;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.GroupPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Blue;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Olive;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.HorzLine.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gridExamList;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Danh Sách";
            this.gridColumn3.FieldName = "ListID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã Số Sinh Viên";
            this.gridColumn4.FieldName = "StudentID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupControl2.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl2.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupControl2.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.CaptionImage = global::QuizSystem.Properties.Resources.questions2;
            this.groupControl2.Controls.Add(this.gridStudentList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(458, 375);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "Danh Sách Sinh Viên";
            // 
            // gridStudentList
            // 
            this.gridStudentList.Location = new System.Drawing.Point(15, 35);
            this.gridStudentList.MainView = this.gridView1;
            this.gridStudentList.Name = "gridStudentList";
            this.gridStudentList.Size = new System.Drawing.Size(425, 321);
            this.gridStudentList.TabIndex = 0;
            this.gridStudentList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FixedLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FixedLine.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Teal;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Navy;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Green;
            this.gridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridStudentList;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Số Sinh Viên";
            this.gridColumn1.FieldName = "StudentID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Khoa";
            this.gridColumn5.FieldName = "FacultyID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Teal;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionImage = global::QuizSystem.Properties.Resources.test__1_;
            this.groupControl1.Controls.Add(this.cboChooseLecturer);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cboChooseRoom);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnCreateNewQuiz);
            this.groupControl1.Controls.Add(this.cboChooseSubject);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1015, 103);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "Thông Tin Danh Sách Thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(26, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chọn Môn Thi";
            // 
            // cboChooseRoom
            // 
            this.cboChooseRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChooseRoom.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic);
            this.cboChooseRoom.ForeColor = System.Drawing.Color.Teal;
            this.cboChooseRoom.FormattingEnabled = true;
            this.cboChooseRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboChooseRoom.Items.AddRange(new object[] {
            "Dễ",
            "Khó",
            "Rất Dễ",
            "Rất Khó",
            "Trung Bình"});
            this.cboChooseRoom.Location = new System.Drawing.Point(133, 65);
            this.cboChooseRoom.Name = "cboChooseRoom";
            this.cboChooseRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChooseRoom.Size = new System.Drawing.Size(216, 26);
            this.cboChooseRoom.TabIndex = 33;
            this.cboChooseRoom.Text = "--Lựa Chọn--";
            this.cboChooseRoom.DropDown += new System.EventHandler(this.cboChooseRoom_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Chọn Phòng Thi";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.Image = global::QuizSystem.Properties.Resources.button_on_off;
            this.btnExit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(906, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 70);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.Image = global::QuizSystem.Properties.Resources._32v;
            this.btnRefresh.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(776, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 71);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreateNewQuiz
            // 
            this.btnCreateNewQuiz.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnCreateNewQuiz.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreateNewQuiz.Appearance.Options.UseFont = true;
            this.btnCreateNewQuiz.Appearance.Options.UseForeColor = true;
            this.btnCreateNewQuiz.Image = global::QuizSystem.Properties.Resources.list1;
            this.btnCreateNewQuiz.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCreateNewQuiz.Location = new System.Drawing.Point(639, 27);
            this.btnCreateNewQuiz.Name = "btnCreateNewQuiz";
            this.btnCreateNewQuiz.Size = new System.Drawing.Size(110, 72);
            this.btnCreateNewQuiz.TabIndex = 26;
            this.btnCreateNewQuiz.Text = "Tạo Danh Sách";
            // 
            // cboChooseSubject
            // 
            this.cboChooseSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChooseSubject.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Italic);
            this.cboChooseSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboChooseSubject.FormattingEnabled = true;
            this.cboChooseSubject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboChooseSubject.Items.AddRange(new object[] {
            "Dễ",
            "Khó",
            "Rất Dễ",
            "Rất Khó",
            "Trung Bình"});
            this.cboChooseSubject.Location = new System.Drawing.Point(133, 25);
            this.cboChooseSubject.Name = "cboChooseSubject";
            this.cboChooseSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChooseSubject.Size = new System.Drawing.Size(216, 26);
            this.cboChooseSubject.TabIndex = 6;
            this.cboChooseSubject.Text = "--Lựa Chọn--";
            this.cboChooseSubject.DropDown += new System.EventHandler(this.cboChooseSubject_DropDown);
            // 
            // ExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ExamList";
            this.Size = new System.Drawing.Size(1015, 478);
            this.Load += new System.EventHandler(this.ExamList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridExamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnToLeft;
        private DevExpress.XtraEditors.SimpleButton btnToRight;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridExamList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridStudentList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnCreateNewQuiz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboChooseSubject;
        private System.Windows.Forms.ComboBox cboChooseRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChooseLecturer;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
