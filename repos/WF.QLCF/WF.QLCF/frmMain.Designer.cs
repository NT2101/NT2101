namespace WF.QLCF
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMenu_Account = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu_User = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.plnMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnMenu_Account,
            this.btnMenu_User,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barButtonItem3);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1048, 183);
            // 
            // btnMenu_Account
            // 
            this.btnMenu_Account.Caption = "Quản Lý Tài Khoản";
            this.btnMenu_Account.Id = 1;
            this.btnMenu_Account.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnMenu_Account.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnMenu_Account.Name = "btnMenu_Account";
            this.btnMenu_Account.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenu_Account_ItemClick);
            // 
            // btnMenu_User
            // 
            this.btnMenu_User.Caption = "Quản Lý Người Dùng";
            this.btnMenu_User.Id = 2;
            this.btnMenu_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnMenu_User.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnMenu_User.Name = "btnMenu_User";
            this.btnMenu_User.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenu_User_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đăng Nhập";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMenu_Account);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMenu_User);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Người Dùng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tiện Ích";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo Cáo Thống Kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Hệ Thống";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup4.ImageOptions.Image")));
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lblAccountName);
            this.panelControl1.Location = new System.Drawing.Point(0, 501);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1005, 24);
            this.panelControl1.TabIndex = 1;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(43, 2);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(76, 17);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Xin chào,...";
            // 
            // plnMain
            // 
            this.plnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plnMain.Location = new System.Drawing.Point(0, 183);
            this.plnMain.Name = "plnMain";
            this.plnMain.Size = new System.Drawing.Size(1048, 403);
            this.plnMain.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 586);
            this.Controls.Add(this.plnMain);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnMenu_Account;
        private DevExpress.XtraBars.BarButtonItem btnMenu_User;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Panel plnMain;
    }
}