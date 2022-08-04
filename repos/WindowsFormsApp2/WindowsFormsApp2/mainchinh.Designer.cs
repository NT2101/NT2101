namespace WindowsFormsApp2
{
    partial class mainchinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.khuVuiChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tròChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khuVuiChơiToolStripMenuItem,
            this.tròChơiToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.dịchVụToolStripMenuItem,
            this.véToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip1.TabIndex = 1;
            // 
            // khuVuiChơiToolStripMenuItem
            // 
            this.khuVuiChơiToolStripMenuItem.Name = "khuVuiChơiToolStripMenuItem";
            this.khuVuiChơiToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.khuVuiChơiToolStripMenuItem.Text = "Khu vui chơi";
            this.khuVuiChơiToolStripMenuItem.Click += new System.EventHandler(this.khuVuiChơiToolStripMenuItem_Click);
            // 
            // tròChơiToolStripMenuItem
            // 
            this.tròChơiToolStripMenuItem.Name = "tròChơiToolStripMenuItem";
            this.tròChơiToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.tròChơiToolStripMenuItem.Text = "Trò chơi";
            this.tròChơiToolStripMenuItem.Click += new System.EventHandler(this.tròChơiToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ";
            this.dịchVụToolStripMenuItem.Click += new System.EventHandler(this.dịchVụToolStripMenuItem_Click);
            // 
            // véToolStripMenuItem
            // 
            this.véToolStripMenuItem.Name = "véToolStripMenuItem";
            this.véToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.véToolStripMenuItem.Text = "Vé";
            this.véToolStripMenuItem.Click += new System.EventHandler(this.véToolStripMenuItem_Click_1);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // mainchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1029, 603);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainchinh";
            this.Text = "mainchinh";
            this.Load += new System.EventHandler(this.mainchinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khuVuiChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tròChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem véToolStripMenuItem;
    }
}