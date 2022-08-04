namespace QuizSystem
{
    partial class DoQuizGUI
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
            this.progressDoQuiz = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnHead = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.grbQuesContent = new DevExpress.XtraEditors.GroupControl();
            this.lblRemainingTime = new DevExpress.XtraEditors.LabelControl();
            this.lblTestTime = new DevExpress.XtraEditors.LabelControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grbQuesttionTop = new System.Windows.Forms.GroupBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.radSelectTopD = new System.Windows.Forms.RadioButton();
            this.radSelectTopC = new System.Windows.Forms.RadioButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.radSelectTopB = new System.Windows.Forms.RadioButton();
            this.radSelectTopA = new System.Windows.Forms.RadioButton();
            this.lblTopContent = new DevExpress.XtraEditors.LabelControl();
            this.grbInforStudent = new DevExpress.XtraEditors.GroupControl();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.picAvaStudent = new System.Windows.Forms.PictureBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.grbInforQuiz = new DevExpress.XtraEditors.GroupControl();
            this.cboChooseQuiz = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.tmrQuizTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressDoQuiz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbQuesContent)).BeginInit();
            this.grbQuesContent.SuspendLayout();
            this.grbQuesttionTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbInforStudent)).BeginInit();
            this.grbInforStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvaStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbInforQuiz)).BeginInit();
            this.grbInforQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // progressDoQuiz
            // 
            this.progressDoQuiz.Location = new System.Drawing.Point(598, 380);
            this.progressDoQuiz.Name = "progressDoQuiz";
            this.progressDoQuiz.Size = new System.Drawing.Size(405, 18);
            this.progressDoQuiz.TabIndex = 21;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Location = new System.Drawing.Point(604, 357);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 17);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Tiến Trình Làm Bài";
            // 
            // btnStart
            // 
            this.btnStart.Image = global::QuizSystem.Properties.Resources.power_button;
            this.btnStart.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(604, 405);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 58);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSubmit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Appearance.Options.UseForeColor = true;
            this.btnSubmit.Image = global::QuizSystem.Properties.Resources.up_arrow;
            this.btnSubmit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSubmit.Location = new System.Drawing.Point(894, 404);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 59);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Nộp Bài Thi";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.Image = global::QuizSystem.Properties.Resources.logout;
            this.btnExit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(770, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 59);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLast
            // 
            this.btnLast.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnLast.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLast.Appearance.Options.UseFont = true;
            this.btnLast.Appearance.Options.UseForeColor = true;
            this.btnLast.Image = global::QuizSystem.Properties.Resources.right_chevron;
            this.btnLast.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnLast.Location = new System.Drawing.Point(916, 295);
            this.btnLast.Name = "btnLast";
            this.btnLast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLast.Size = new System.Drawing.Size(88, 48);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = "Cuối Cùng";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnHead
            // 
            this.btnHead.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHead.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHead.Appearance.Options.UseFont = true;
            this.btnHead.Appearance.Options.UseForeColor = true;
            this.btnHead.Image = global::QuizSystem.Properties.Resources.left_chevron;
            this.btnHead.Location = new System.Drawing.Point(599, 295);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(92, 48);
            this.btnHead.TabIndex = 19;
            this.btnHead.Text = "Đầu Tiên";
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.Image = global::QuizSystem.Properties.Resources.left_arrow;
            this.btnBack.Location = new System.Drawing.Point(706, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 48);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Lùi Lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.Image = global::QuizSystem.Properties.Resources.right_arrow;
            this.btnNext.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnNext.Location = new System.Drawing.Point(812, 295);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 48);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Kế Tiếp";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grbQuesContent
            // 
            this.grbQuesContent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbQuesContent.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grbQuesContent.Appearance.Options.UseBackColor = true;
            this.grbQuesContent.Appearance.Options.UseFont = true;
            this.grbQuesContent.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbQuesContent.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbQuesContent.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbQuesContent.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grbQuesContent.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbQuesContent.AppearanceCaption.Options.UseBackColor = true;
            this.grbQuesContent.AppearanceCaption.Options.UseBorderColor = true;
            this.grbQuesContent.AppearanceCaption.Options.UseFont = true;
            this.grbQuesContent.AppearanceCaption.Options.UseForeColor = true;
            this.grbQuesContent.CaptionImage = global::QuizSystem.Properties.Resources.question;
            this.grbQuesContent.Controls.Add(this.lblRemainingTime);
            this.grbQuesContent.Controls.Add(this.lblTestTime);
            this.grbQuesContent.Controls.Add(this.linkLabel1);
            this.grbQuesContent.Controls.Add(this.grbQuesttionTop);
            this.grbQuesContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbQuesContent.Location = new System.Drawing.Point(0, 0);
            this.grbQuesContent.Name = "grbQuesContent";
            this.grbQuesContent.Size = new System.Drawing.Size(592, 478);
            this.grbQuesContent.TabIndex = 16;
            this.grbQuesContent.Text = "Nội Dung Câu Hỏi";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRemainingTime.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRemainingTime.Location = new System.Drawing.Point(402, 46);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(110, 17);
            this.lblRemainingTime.TabIndex = 27;
            this.lblRemainingTime.Text = "Thời Gian Còn Lại:";
            // 
            // lblTestTime
            // 
            this.lblTestTime.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTestTime.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTestTime.Location = new System.Drawing.Point(180, 46);
            this.lblTestTime.Name = "lblTestTime";
            this.lblTestTime.Size = new System.Drawing.Size(87, 17);
            this.lblTestTime.TabIndex = 26;
            this.lblTestTime.Text = "Thời Gian Thi: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(266, 444);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 19);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trang 1";
            // 
            // grbQuesttionTop
            // 
            this.grbQuesttionTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbQuesttionTop.BackColor = System.Drawing.Color.Transparent;
            this.grbQuesttionTop.Controls.Add(this.labelControl11);
            this.grbQuesttionTop.Controls.Add(this.labelControl12);
            this.grbQuesttionTop.Controls.Add(this.radSelectTopD);
            this.grbQuesttionTop.Controls.Add(this.radSelectTopC);
            this.grbQuesttionTop.Controls.Add(this.labelControl10);
            this.grbQuesttionTop.Controls.Add(this.labelControl9);
            this.grbQuesttionTop.Controls.Add(this.radSelectTopB);
            this.grbQuesttionTop.Controls.Add(this.radSelectTopA);
            this.grbQuesttionTop.Controls.Add(this.lblTopContent);
            this.grbQuesttionTop.ForeColor = System.Drawing.Color.Green;
            this.grbQuesttionTop.Location = new System.Drawing.Point(5, 79);
            this.grbQuesttionTop.Name = "grbQuesttionTop";
            this.grbQuesttionTop.Size = new System.Drawing.Size(582, 362);
            this.grbQuesttionTop.TabIndex = 0;
            this.grbQuesttionTop.TabStop = false;
            this.grbQuesttionTop.Text = "Câu Hỏi";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl11.Location = new System.Drawing.Point(26, 308);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(16, 19);
            this.labelControl11.TabIndex = 37;
            this.labelControl11.Text = "D.";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl12.Location = new System.Drawing.Point(25, 249);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(15, 19);
            this.labelControl12.TabIndex = 36;
            this.labelControl12.Text = "C.";
            // 
            // radSelectTopD
            // 
            this.radSelectTopD.AutoSize = true;
            this.radSelectTopD.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radSelectTopD.ForeColor = System.Drawing.Color.Teal;
            this.radSelectTopD.Location = new System.Drawing.Point(48, 308);
            this.radSelectTopD.Name = "radSelectTopD";
            this.radSelectTopD.Size = new System.Drawing.Size(99, 18);
            this.radSelectTopD.TabIndex = 35;
            this.radSelectTopD.TabStop = true;
            this.radSelectTopD.Text = "Phương Án D";
            this.radSelectTopD.UseVisualStyleBackColor = true;
            this.radSelectTopD.CheckedChanged += new System.EventHandler(this.radSelectTopD_CheckedChanged);
            // 
            // radSelectTopC
            // 
            this.radSelectTopC.AutoSize = true;
            this.radSelectTopC.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radSelectTopC.ForeColor = System.Drawing.Color.Teal;
            this.radSelectTopC.Location = new System.Drawing.Point(48, 249);
            this.radSelectTopC.Name = "radSelectTopC";
            this.radSelectTopC.Size = new System.Drawing.Size(98, 18);
            this.radSelectTopC.TabIndex = 34;
            this.radSelectTopC.TabStop = true;
            this.radSelectTopC.Text = "Phương Án C";
            this.radSelectTopC.UseVisualStyleBackColor = true;
            this.radSelectTopC.CheckedChanged += new System.EventHandler(this.radSelectTopC_CheckedChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl10.Location = new System.Drawing.Point(25, 190);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(14, 19);
            this.labelControl10.TabIndex = 33;
            this.labelControl10.Text = "B.";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Location = new System.Drawing.Point(23, 129);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(16, 19);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "A.";
            // 
            // radSelectTopB
            // 
            this.radSelectTopB.AutoSize = true;
            this.radSelectTopB.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radSelectTopB.ForeColor = System.Drawing.Color.Teal;
            this.radSelectTopB.Location = new System.Drawing.Point(48, 191);
            this.radSelectTopB.Name = "radSelectTopB";
            this.radSelectTopB.Size = new System.Drawing.Size(98, 18);
            this.radSelectTopB.TabIndex = 27;
            this.radSelectTopB.TabStop = true;
            this.radSelectTopB.Text = "Phương Án B";
            this.radSelectTopB.UseVisualStyleBackColor = true;
            this.radSelectTopB.CheckedChanged += new System.EventHandler(this.radSelectTopB_CheckedChanged);
            // 
            // radSelectTopA
            // 
            this.radSelectTopA.AutoSize = true;
            this.radSelectTopA.Font = new System.Drawing.Font("Tahoma", 9F);
            this.radSelectTopA.ForeColor = System.Drawing.Color.Teal;
            this.radSelectTopA.Location = new System.Drawing.Point(47, 131);
            this.radSelectTopA.Name = "radSelectTopA";
            this.radSelectTopA.Size = new System.Drawing.Size(99, 18);
            this.radSelectTopA.TabIndex = 26;
            this.radSelectTopA.TabStop = true;
            this.radSelectTopA.Text = "Phương Án A";
            this.radSelectTopA.UseVisualStyleBackColor = true;
            this.radSelectTopA.CheckedChanged += new System.EventHandler(this.radSelectTopA_CheckedChanged);
            // 
            // lblTopContent
            // 
            this.lblTopContent.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTopContent.Appearance.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTopContent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTopContent.LineVisible = true;
            this.lblTopContent.Location = new System.Drawing.Point(48, 35);
            this.lblTopContent.Name = "lblTopContent";
            this.lblTopContent.Size = new System.Drawing.Size(140, 17);
            this.lblTopContent.TabIndex = 25;
            this.lblTopContent.Text = "Nội Dung Câu Hỏi Trên";
            // 
            // grbInforStudent
            // 
            this.grbInforStudent.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grbInforStudent.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grbInforStudent.AppearanceCaption.Options.UseFont = true;
            this.grbInforStudent.AppearanceCaption.Options.UseForeColor = true;
            this.grbInforStudent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.grbInforStudent.CaptionImage = global::QuizSystem.Properties.Resources.student__2_;
            this.grbInforStudent.Controls.Add(this.txtFaculty);
            this.grbInforStudent.Controls.Add(this.labelControl4);
            this.grbInforStudent.Controls.Add(this.labelControl3);
            this.grbInforStudent.Controls.Add(this.labelControl2);
            this.grbInforStudent.Controls.Add(this.txtStudentName);
            this.grbInforStudent.Controls.Add(this.picAvaStudent);
            this.grbInforStudent.Controls.Add(this.txtStudentID);
            this.grbInforStudent.Location = new System.Drawing.Point(598, 3);
            this.grbInforStudent.Name = "grbInforStudent";
            this.grbInforStudent.Size = new System.Drawing.Size(405, 133);
            this.grbInforStudent.TabIndex = 15;
            this.grbInforStudent.Text = "Thông Tin Sinh Viên";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(196, 102);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(142, 21);
            this.txtFaculty.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl4.Location = new System.Drawing.Point(116, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 17);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Thuộc Khoa";
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
            this.txtStudentName.Size = new System.Drawing.Size(204, 21);
            this.txtStudentName.TabIndex = 2;
            // 
            // picAvaStudent
            // 
            this.picAvaStudent.Image = global::QuizSystem.Properties.Resources.student1;
            this.picAvaStudent.Location = new System.Drawing.Point(15, 26);
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
            this.txtStudentID.Size = new System.Drawing.Size(142, 21);
            this.txtStudentID.TabIndex = 0;
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
            this.grbInforQuiz.Controls.Add(this.labelControl5);
            this.grbInforQuiz.Controls.Add(this.labelControl6);
            this.grbInforQuiz.Controls.Add(this.pictureBox2);
            this.grbInforQuiz.Controls.Add(this.txtSubjectName);
            this.grbInforQuiz.Location = new System.Drawing.Point(598, 142);
            this.grbInforQuiz.Name = "grbInforQuiz";
            this.grbInforQuiz.Size = new System.Drawing.Size(405, 138);
            this.grbInforQuiz.TabIndex = 14;
            this.grbInforQuiz.Text = "Thông Tin Đề Thi";
            // 
            // cboChooseQuiz
            // 
            this.cboChooseQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChooseQuiz.ForeColor = System.Drawing.Color.Navy;
            this.cboChooseQuiz.FormattingEnabled = true;
            this.cboChooseQuiz.Items.AddRange(new object[] {
            "Student",
            "Lecturer",
            "TestingRoom"});
            this.cboChooseQuiz.Location = new System.Drawing.Point(196, 33);
            this.cboChooseQuiz.Name = "cboChooseQuiz";
            this.cboChooseQuiz.Size = new System.Drawing.Size(175, 24);
            this.cboChooseQuiz.TabIndex = 32;
            this.cboChooseQuiz.Text = "--Lựa Chọn--";
            this.cboChooseQuiz.DropDown += new System.EventHandler(this.cboChooseQuiz_DropDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl5.Location = new System.Drawing.Point(146, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 17);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Mã Đề";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl6.Location = new System.Drawing.Point(136, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 16);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "Môn Thi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuizSystem.Properties.Resources.test1;
            this.pictureBox2.Location = new System.Drawing.Point(15, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Enabled = false;
            this.txtSubjectName.Location = new System.Drawing.Point(196, 73);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(204, 21);
            this.txtSubjectName.TabIndex = 29;
            // 
            // tmrQuizTime
            // 
            this.tmrQuizTime.Interval = 1000;
            this.tmrQuizTime.Tick += new System.EventHandler(this.tmrQuizTime_Tick);
            // 
            // DoQuizGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.progressDoQuiz);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnHead);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grbQuesContent);
            this.Controls.Add(this.grbInforStudent);
            this.Controls.Add(this.grbInforQuiz);
            this.Name = "DoQuizGUI";
            this.Size = new System.Drawing.Size(1015, 478);
            this.Load += new System.EventHandler(this.DoQuizGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressDoQuiz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbQuesContent)).EndInit();
            this.grbQuesContent.ResumeLayout(false);
            this.grbQuesContent.PerformLayout();
            this.grbQuesttionTop.ResumeLayout(false);
            this.grbQuesttionTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbInforStudent)).EndInit();
            this.grbInforStudent.ResumeLayout(false);
            this.grbInforStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvaStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbInforQuiz)).EndInit();
            this.grbInforQuiz.ResumeLayout(false);
            this.grbInforQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbInforQuiz;
        private DevExpress.XtraEditors.GroupControl grbInforStudent;
        private DevExpress.XtraEditors.GroupControl grbQuesContent;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnHead;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.ProgressBarControl progressDoQuiz;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private System.Windows.Forms.PictureBox picAvaStudent;
        private System.Windows.Forms.TextBox txtStudentID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grbQuesttionTop;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.RadioButton radSelectTopD;
        private System.Windows.Forms.RadioButton radSelectTopC;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RadioButton radSelectTopB;
        private System.Windows.Forms.RadioButton radSelectTopA;
        private DevExpress.XtraEditors.LabelControl lblTopContent;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtSubjectName;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.Timer tmrQuizTime;
        private DevExpress.XtraEditors.LabelControl lblRemainingTime;
        private DevExpress.XtraEditors.LabelControl lblTestTime;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.ComboBox cboChooseQuiz;
    }
}
