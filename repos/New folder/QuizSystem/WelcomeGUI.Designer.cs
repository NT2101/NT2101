namespace QuizSystem
{
    partial class WelcomeGUI
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lblGuide = new DevExpress.XtraEditors.LabelControl();
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.splitContainerControl1.Panel1.Controls.Add(this.lblGuide);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblWelcome);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1007, 574);
            this.splitContainerControl1.SplitterPosition = 118;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lblGuide
            // 
            this.lblGuide.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic);
            this.lblGuide.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblGuide.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblGuide.Location = new System.Drawing.Point(330, 68);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(405, 22);
            this.lblGuide.TabIndex = 7;
            this.lblGuide.Text = "(Hãy đăng nhập để có thể sử dụng các chức năng)";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lblWelcome.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblWelcome.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.AppearancePressed.BackColor2 = System.Drawing.Color.Transparent;
            this.lblWelcome.AppearancePressed.BorderColor = System.Drawing.Color.Transparent;
            this.lblWelcome.AppearancePressed.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.LineColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(326, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(409, 41);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Hệ Thống Thi Trắc Nghiệm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizSystem.Properties.Resources.exams;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "WelcomeGUI";
            this.Size = new System.Drawing.Size(1007, 574);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl lblGuide;
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
