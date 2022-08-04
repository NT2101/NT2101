namespace QuizSystem
{
    partial class CreateTestQuiz
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
            this.btnToLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnToRight = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridQuizDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridQuesList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateNewQuiz = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboChooseQuiz = new System.Windows.Forms.ComboBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuizDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
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
            this.btnToLeft.Location = new System.Drawing.Point(398, 312);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(91, 75);
            this.btnToLeft.TabIndex = 25;
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
            this.btnToRight.Location = new System.Drawing.Point(398, 219);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(91, 75);
            this.btnToRight.TabIndex = 24;
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
            this.groupControl3.Controls.Add(this.gridQuizDetail);
            this.groupControl3.Location = new System.Drawing.Point(495, 103);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(379, 396);
            this.groupControl3.TabIndex = 18;
            this.groupControl3.Text = "Danh Sách Câu Hỏi Bộ Đề";
            // 
            // gridQuizDetail
            // 
            this.gridQuizDetail.Location = new System.Drawing.Point(16, 35);
            this.gridQuizDetail.MainView = this.gridView2;
            this.gridQuizDetail.Name = "gridQuizDetail";
            this.gridQuizDetail.Size = new System.Drawing.Size(351, 349);
            this.gridQuizDetail.TabIndex = 0;
            this.gridQuizDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView2.GridControl = this.gridQuizDetail;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Đề Thi";
            this.gridColumn3.FieldName = "QuizID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã Câu Hỏi";
            this.gridColumn4.FieldName = "QuesID";
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
            this.groupControl2.Controls.Add(this.gridQuesList);
            this.groupControl2.Location = new System.Drawing.Point(0, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(392, 396);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Danh Sách Câu Hỏi";
            // 
            // gridQuesList
            // 
            this.gridQuesList.Location = new System.Drawing.Point(15, 35);
            this.gridQuesList.MainView = this.gridView1;
            this.gridQuesList.Name = "gridQuesList";
            this.gridQuesList.Size = new System.Drawing.Size(359, 349);
            this.gridQuesList.TabIndex = 0;
            this.gridQuesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn2});
            this.gridView1.GridControl = this.gridQuesList;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Câu Hỏi";
            this.gridColumn1.FieldName = "QuestionID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nội Dung";
            this.gridColumn2.FieldName = "Content";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Teal;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionImage = global::QuizSystem.Properties.Resources.test__1_;
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnRefresh);
            this.groupControl1.Controls.Add(this.btnCreateNewQuiz);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.cboChooseQuiz);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 103);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Thông Tin Đề";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.Image = global::QuizSystem.Properties.Resources.button_on_off;
            this.btnExit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(758, 26);
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
            this.btnRefresh.Location = new System.Drawing.Point(630, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 71);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreateNewQuiz
            // 
            this.btnCreateNewQuiz.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCreateNewQuiz.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreateNewQuiz.Appearance.Options.UseFont = true;
            this.btnCreateNewQuiz.Appearance.Options.UseForeColor = true;
            this.btnCreateNewQuiz.Image = global::QuizSystem.Properties.Resources.exam__1_1;
            this.btnCreateNewQuiz.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCreateNewQuiz.Location = new System.Drawing.Point(495, 25);
            this.btnCreateNewQuiz.Name = "btnCreateNewQuiz";
            this.btnCreateNewQuiz.Size = new System.Drawing.Size(105, 72);
            this.btnCreateNewQuiz.TabIndex = 26;
            this.btnCreateNewQuiz.Text = "Tạo Đề Mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chọn Bộ Đề:";
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
            this.cboChooseQuiz.Location = new System.Drawing.Point(115, 40);
            this.cboChooseQuiz.Name = "cboChooseQuiz";
            this.cboChooseQuiz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboChooseQuiz.Size = new System.Drawing.Size(277, 26);
            this.cboChooseQuiz.TabIndex = 6;
            this.cboChooseQuiz.Text = "--Lựa Chọn--";
            this.cboChooseQuiz.DropDown += new System.EventHandler(this.cboChooseQuiz_DropDown);
            // 
            // groupControl4
            // 
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 480);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(874, 19);
            this.groupControl4.TabIndex = 26;
            // 
            // CreateTestQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(874, 499);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnToRight);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateTestQuiz";
            this.Text = "Tạo Đề Thi Mới";
            this.Load += new System.EventHandler(this.CreateTestQuiz_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateTestQuiz_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuizDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboChooseQuiz;
        private DevExpress.XtraEditors.SimpleButton btnCreateNewQuiz;
        private DevExpress.XtraEditors.SimpleButton btnToRight;
        private DevExpress.XtraEditors.SimpleButton btnToLeft;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraGrid.GridControl gridQuizDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gridQuesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}