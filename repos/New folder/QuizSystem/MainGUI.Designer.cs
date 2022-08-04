namespace QuizSystem
{
    partial class MainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewTestRoom = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddRoom = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewExamList = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewBannedList = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewQuiz = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewQuestion = new DevExpress.XtraBars.BarButtonItem();
            this.barTextDesign = new DevExpress.XtraBars.BarStaticItem();
            this.barTextStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barTextCurrentAccount = new DevExpress.XtraBars.BarStaticItem();
            this.barTextCurrentDate = new DevExpress.XtraBars.BarStaticItem();
            this.barTextCurrentTime = new DevExpress.XtraBars.BarStaticItem();
            this.btnUpdateRoom = new DevExpress.XtraBars.BarButtonItem();
            this.barTextWelcome = new DevExpress.XtraBars.BarStaticItem();
            this.rbnSystemManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grbConfirugation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grbExit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnTestingRoom = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grbImportStudent = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grbTestRoom = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grbExamList = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnLecturer = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grbQuiz = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grbQuestion = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navControl = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemGoHome = new DevExpress.XtraNavBar.NavBarItem();
            this.navLecturerFunction = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemCreateQuestion = new DevExpress.XtraNavBar.NavBarItem();
            this.navManageFunction = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemBlendQuiz = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemCreateTestList = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemQuestionLevel = new DevExpress.XtraNavBar.NavBarItem();
            this.navStudent = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemDoQuiz = new DevExpress.XtraNavBar.NavBarItem();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogin,
            this.btnChangePassword,
            this.btnCreateAccount,
            this.btnExit,
            this.btnImportStudent,
            this.btnViewTestRoom,
            this.btnAddRoom,
            this.btnViewExamList,
            this.btnViewBannedList,
            this.btnViewQuiz,
            this.btnViewQuestion,
            this.barTextDesign,
            this.barTextStatus,
            this.barTextCurrentAccount,
            this.barTextCurrentDate,
            this.barTextCurrentTime,
            this.btnUpdateRoom,
            this.barTextWelcome});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barTextCurrentDate);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barTextCurrentTime);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnSystemManager,
            this.rbnTestingRoom,
            this.rbnLecturer});
            this.ribbonControl1.Size = new System.Drawing.Size(1235, 144);
            this.ribbonControl1.StatusBar = this.rbnStatusBar;
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.LargeGlyph = global::QuizSystem.Properties.Resources.password;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Thay Đổi Mật Khẩu";
            this.btnChangePassword.Id = 2;
            this.btnChangePassword.LargeGlyph = global::QuizSystem.Properties.Resources.images1;
            this.btnChangePassword.Name = "btnChangePassword";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Caption = "Tạo Tài Khoản Mới";
            this.btnCreateAccount.Id = 3;
            this.btnCreateAccount.LargeGlyph = global::QuizSystem.Properties.Resources.users_add_32x32;
            this.btnCreateAccount.Name = "btnCreateAccount";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát Chương Trình";
            this.btnExit.Glyph = global::QuizSystem.Properties.Resources.exit_png_32x32;
            this.btnExit.Id = 4;
            this.btnExit.LargeGlyph = global::QuizSystem.Properties.Resources.exit_png_32x32;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnImportStudent
            // 
            this.btnImportStudent.Caption = "Import Danh Sách Sinh Viên";
            this.btnImportStudent.Id = 5;
            this.btnImportStudent.LargeGlyph = global::QuizSystem.Properties.Resources.tap;
            this.btnImportStudent.Name = "btnImportStudent";
            this.btnImportStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportStudent_ItemClick);
            // 
            // btnViewTestRoom
            // 
            this.btnViewTestRoom.Caption = "Xem Các Phòng Thi";
            this.btnViewTestRoom.Id = 6;
            this.btnViewTestRoom.LargeGlyph = global::QuizSystem.Properties.Resources.student;
            this.btnViewTestRoom.Name = "btnViewTestRoom";
            this.btnViewTestRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewTestRoom_ItemClick);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Caption = "Thêm Phòng";
            this.btnAddRoom.Glyph = global::QuizSystem.Properties.Resources.Add_16x16;
            this.btnAddRoom.Id = 7;
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddRoom_ItemClick);
            // 
            // btnViewExamList
            // 
            this.btnViewExamList.Caption = "Xem Danh Sách Thi";
            this.btnViewExamList.Id = 10;
            this.btnViewExamList.LargeGlyph = global::QuizSystem.Properties.Resources.verification_of_delivery_list_clipboard_symbol;
            this.btnViewExamList.Name = "btnViewExamList";
            this.btnViewExamList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewExamList_ItemClick);
            // 
            // btnViewBannedList
            // 
            this.btnViewBannedList.Caption = "Xem Danh Sách Cấm Thi";
            this.btnViewBannedList.Id = 11;
            this.btnViewBannedList.LargeGlyph = global::QuizSystem.Properties.Resources.list__1_;
            this.btnViewBannedList.Name = "btnViewBannedList";
            this.btnViewBannedList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewBannedList_ItemClick);
            // 
            // btnViewQuiz
            // 
            this.btnViewQuiz.Caption = "Xem Danh Sách Đề Thi";
            this.btnViewQuiz.Id = 12;
            this.btnViewQuiz.LargeGlyph = global::QuizSystem.Properties.Resources.exam__1_;
            this.btnViewQuiz.Name = "btnViewQuiz";
            this.btnViewQuiz.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewQuiz_ItemClick);
            // 
            // btnViewQuestion
            // 
            this.btnViewQuestion.Caption = "Xem Danh Sách Câu Hỏi";
            this.btnViewQuestion.Id = 13;
            this.btnViewQuestion.LargeGlyph = global::QuizSystem.Properties.Resources.test;
            this.btnViewQuestion.Name = "btnViewQuestion";
            this.btnViewQuestion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewQuestion_ItemClick);
            // 
            // barTextDesign
            // 
            this.barTextDesign.Caption = "Thuộc thiết kế của: Hoàng Phúc";
            this.barTextDesign.Glyph = global::QuizSystem.Properties.Resources.asda;
            this.barTextDesign.Id = 14;
            this.barTextDesign.Name = "barTextDesign";
            this.barTextDesign.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barTextStatus
            // 
            this.barTextStatus.Caption = "Trạng Thái: (Chờ đăng nhập)";
            this.barTextStatus.Glyph = global::QuizSystem.Properties.Resources.xzczxcc_16x16;
            this.barTextStatus.Id = 15;
            this.barTextStatus.Name = "barTextStatus";
            this.barTextStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barTextCurrentAccount
            // 
            this.barTextCurrentAccount.Caption = "Tài khoản hiện đang sử dụng: (Chưa đăng nhập)";
            this.barTextCurrentAccount.Glyph = global::QuizSystem.Properties.Resources.multiple_users_silhouette__16x16;
            this.barTextCurrentAccount.Id = 16;
            this.barTextCurrentAccount.Name = "barTextCurrentAccount";
            this.barTextCurrentAccount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barTextCurrentDate
            // 
            this.barTextCurrentDate.Caption = " Ngày Tháng";
            this.barTextCurrentDate.Glyph = global::QuizSystem.Properties.Resources.calendar_with_spring_binder_and_date_blocks;
            this.barTextCurrentDate.Id = 17;
            this.barTextCurrentDate.Name = "barTextCurrentDate";
            this.barTextCurrentDate.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barTextCurrentTime
            // 
            this.barTextCurrentTime.Caption = "Thời gian hiện tại: ";
            this.barTextCurrentTime.Glyph = global::QuizSystem.Properties.Resources.circular_clock;
            this.barTextCurrentTime.Id = 18;
            this.barTextCurrentTime.Name = "barTextCurrentTime";
            this.barTextCurrentTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Caption = "Cập Nhập";
            this.btnUpdateRoom.Glyph = global::QuizSystem.Properties.Resources.pencil_16x16;
            this.btnUpdateRoom.Id = 19;
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateRoom_ItemClick);
            // 
            // barTextWelcome
            // 
            this.barTextWelcome.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barTextWelcome.Caption = "Chào Sinh Viên: ";
            this.barTextWelcome.Enabled = false;
            this.barTextWelcome.Id = 20;
            this.barTextWelcome.Name = "barTextWelcome";
            this.barTextWelcome.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rbnSystemManager
            // 
            this.rbnSystemManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grbConfirugation,
            this.grbExit});
            this.rbnSystemManager.Image = global::QuizSystem.Properties.Resources._32882_200__16x16;
            this.rbnSystemManager.Name = "rbnSystemManager";
            this.rbnSystemManager.Text = "Quản Trị Hệ Thống";
            // 
            // grbConfirugation
            // 
            this.grbConfirugation.ItemLinks.Add(this.btnLogin);
            this.grbConfirugation.ItemLinks.Add(this.btnChangePassword);
            this.grbConfirugation.ItemLinks.Add(this.btnCreateAccount);
            this.grbConfirugation.Name = "grbConfirugation";
            this.grbConfirugation.Text = "Cấu Hình Đăng Nhập";
            // 
            // grbExit
            // 
            this.grbExit.ItemLinks.Add(this.btnExit);
            this.grbExit.Name = "grbExit";
            this.grbExit.Text = "Thoát ";
            // 
            // rbnTestingRoom
            // 
            this.rbnTestingRoom.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grbImportStudent,
            this.grbTestRoom,
            this.grbExamList});
            this.rbnTestingRoom.Image = global::QuizSystem.Properties.Resources.icon;
            this.rbnTestingRoom.Name = "rbnTestingRoom";
            this.rbnTestingRoom.Text = "Phòng Khảo Thí";
            // 
            // grbImportStudent
            // 
            this.grbImportStudent.ItemLinks.Add(this.btnImportStudent);
            this.grbImportStudent.Name = "grbImportStudent";
            this.grbImportStudent.Text = "Sinh Viên";
            // 
            // grbTestRoom
            // 
            this.grbTestRoom.ItemLinks.Add(this.btnViewTestRoom);
            this.grbTestRoom.ItemLinks.Add(this.btnAddRoom);
            this.grbTestRoom.ItemLinks.Add(this.btnUpdateRoom);
            this.grbTestRoom.Name = "grbTestRoom";
            this.grbTestRoom.Text = "Phòng Thi";
            // 
            // grbExamList
            // 
            this.grbExamList.ItemLinks.Add(this.btnViewExamList);
            this.grbExamList.ItemLinks.Add(this.btnViewBannedList);
            this.grbExamList.Name = "grbExamList";
            this.grbExamList.Text = "Danh Sách Thi";
            // 
            // rbnLecturer
            // 
            this.rbnLecturer.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grbQuiz,
            this.grbQuestion});
            this.rbnLecturer.Image = global::QuizSystem.Properties.Resources.staff_16x16;
            this.rbnLecturer.Name = "rbnLecturer";
            this.rbnLecturer.Text = "Giảng Viên";
            // 
            // grbQuiz
            // 
            this.grbQuiz.ItemLinks.Add(this.btnViewQuiz);
            this.grbQuiz.Name = "grbQuiz";
            this.grbQuiz.Text = " Đề Thi";
            // 
            // grbQuestion
            // 
            this.grbQuestion.ItemLinks.Add(this.btnViewQuestion);
            this.grbQuestion.Name = "grbQuestion";
            this.grbQuestion.Text = "Câu Hỏi";
            // 
            // rbnStatusBar
            // 
            this.rbnStatusBar.ItemLinks.Add(this.barTextDesign);
            this.rbnStatusBar.ItemLinks.Add(this.barTextStatus);
            this.rbnStatusBar.ItemLinks.Add(this.barTextCurrentAccount);
            this.rbnStatusBar.ItemLinks.Add(this.barTextWelcome);
            this.rbnStatusBar.Location = new System.Drawing.Point(0, 622);
            this.rbnStatusBar.Name = "rbnStatusBar";
            this.rbnStatusBar.Ribbon = this.ribbonControl1;
            this.rbnStatusBar.Size = new System.Drawing.Size(1235, 27);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 144);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1235, 478);
            this.splitContainerControl1.SplitterPosition = 215;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navControl;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navControl,
            this.navLecturerFunction,
            this.navManageFunction,
            this.navStudent});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navItemGoHome,
            this.navItemCreateQuestion,
            this.navItemBlendQuiz,
            this.navItemCreateTestList,
            this.navItemQuestionLevel,
            this.navItemDoQuiz});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 215;
            this.navBarControl1.Size = new System.Drawing.Size(215, 478);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navControl
            // 
            this.navControl.Caption = "Các Điều Khiển";
            this.navControl.Expanded = true;
            this.navControl.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemGoHome)});
            this.navControl.Name = "navControl";
            this.navControl.SmallImage = global::QuizSystem.Properties.Resources.controls;
            // 
            // navItemGoHome
            // 
            this.navItemGoHome.Caption = "Về trang chủ";
            this.navItemGoHome.Name = "navItemGoHome";
            this.navItemGoHome.SmallImage = global::QuizSystem.Properties.Resources.back_16x16;
            // 
            // navLecturerFunction
            // 
            this.navLecturerFunction.Caption = "Chức năng của Giảng Viên";
            this.navLecturerFunction.Expanded = true;
            this.navLecturerFunction.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemCreateQuestion)});
            this.navLecturerFunction.Name = "navLecturerFunction";
            this.navLecturerFunction.SmallImage = global::QuizSystem.Properties.Resources.staff_16x16;
            // 
            // navItemCreateQuestion
            // 
            this.navItemCreateQuestion.Caption = "Soạn câu hỏi";
            this.navItemCreateQuestion.Name = "navItemCreateQuestion";
            this.navItemCreateQuestion.SmallImage = global::QuizSystem.Properties.Resources.customer_service;
            this.navItemCreateQuestion.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemCreateQuestion_LinkClicked);
            // 
            // navManageFunction
            // 
            this.navManageFunction.Caption = "Các Chức Năng Quản Trị";
            this.navManageFunction.Expanded = true;
            this.navManageFunction.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemBlendQuiz),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemCreateTestList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemQuestionLevel)});
            this.navManageFunction.Name = "navManageFunction";
            this.navManageFunction.SmallImage = global::QuizSystem.Properties.Resources.share;
            // 
            // navItemBlendQuiz
            // 
            this.navItemBlendQuiz.Caption = "Trộn đề - tạo đề thi";
            this.navItemBlendQuiz.Name = "navItemBlendQuiz";
            this.navItemBlendQuiz.SmallImage = global::QuizSystem.Properties.Resources.shuffle;
            this.navItemBlendQuiz.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemBlendQuiz_LinkClicked);
            // 
            // navItemCreateTestList
            // 
            this.navItemCreateTestList.Caption = "Lập danh sách thi";
            this.navItemCreateTestList.Name = "navItemCreateTestList";
            this.navItemCreateTestList.SmallImage = global::QuizSystem.Properties.Resources.list;
            this.navItemCreateTestList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemCreateTestList_LinkClicked);
            // 
            // navItemQuestionLevel
            // 
            this.navItemQuestionLevel.Caption = "Cập nhập độ khó câu hỏi";
            this.navItemQuestionLevel.Name = "navItemQuestionLevel";
            this.navItemQuestionLevel.SmallImage = global::QuizSystem.Properties.Resources.questions;
            this.navItemQuestionLevel.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemQuestionLevel_LinkClicked);
            // 
            // navStudent
            // 
            this.navStudent.Caption = "Sinh Viên";
            this.navStudent.Expanded = true;
            this.navStudent.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemDoQuiz)});
            this.navStudent.Name = "navStudent";
            this.navStudent.SmallImage = global::QuizSystem.Properties.Resources.learning;
            // 
            // navItemDoQuiz
            // 
            this.navItemDoQuiz.Caption = "Làm Bài Thi";
            this.navItemDoQuiz.Name = "navItemDoQuiz";
            this.navItemDoQuiz.SmallImage = global::QuizSystem.Properties.Resources.exam2;
            this.navItemDoQuiz.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItemDoQuiz_LinkClicked);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1015, 478);
            this.panelMain.TabIndex = 0;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 649);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.rbnStatusBar);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnSystemManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbConfirugation;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnCreateAccount;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnImportStudent;
        private DevExpress.XtraBars.BarButtonItem btnViewTestRoom;
        private DevExpress.XtraBars.BarButtonItem btnAddRoom;
        private DevExpress.XtraBars.BarButtonItem btnViewExamList;
        private DevExpress.XtraBars.BarButtonItem btnViewBannedList;
        private DevExpress.XtraBars.BarButtonItem btnViewQuiz;
        private DevExpress.XtraBars.BarButtonItem btnViewQuestion;
        private DevExpress.XtraBars.BarStaticItem barTextDesign;
        private DevExpress.XtraBars.BarStaticItem barTextStatus;
        private DevExpress.XtraBars.BarStaticItem barTextCurrentAccount;
        private DevExpress.XtraBars.BarStaticItem barTextCurrentDate;
        private DevExpress.XtraBars.BarStaticItem barTextCurrentTime;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbExit;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnTestingRoom;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbImportStudent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbTestRoom;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbExamList;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnLecturer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbQuiz;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbQuestion;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rbnStatusBar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navControl;
        private DevExpress.XtraNavBar.NavBarItem navItemGoHome;
        private DevExpress.XtraNavBar.NavBarGroup navLecturerFunction;
        private DevExpress.XtraNavBar.NavBarItem navItemCreateQuestion;
        private DevExpress.XtraNavBar.NavBarGroup navManageFunction;
        private DevExpress.XtraNavBar.NavBarItem navItemBlendQuiz;
        private DevExpress.XtraNavBar.NavBarItem navItemCreateTestList;
        private DevExpress.XtraNavBar.NavBarItem navItemQuestionLevel;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.BarButtonItem btnUpdateRoom;
        private DevExpress.XtraNavBar.NavBarGroup navStudent;
        private DevExpress.XtraNavBar.NavBarItem navItemDoQuiz;
        private DevExpress.XtraBars.BarStaticItem barTextWelcome;
    }
}