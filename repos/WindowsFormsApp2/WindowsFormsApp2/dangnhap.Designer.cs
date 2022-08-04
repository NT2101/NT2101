namespace WindowsFormsApp2
{
    partial class dangnhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btlT = new System.Windows.Forms.Button();
            this.btlDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Đăng Nhập";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(385, 241);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(169, 22);
            this.txtMK.TabIndex = 25;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(385, 196);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(169, 22);
            this.txtTK.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tài Khoản";
            // 
            // btlT
            // 
            this.btlT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlT.Location = new System.Drawing.Point(433, 296);
            this.btlT.Name = "btlT";
            this.btlT.Size = new System.Drawing.Size(121, 28);
            this.btlT.TabIndex = 21;
            this.btlT.Text = "Thoát";
            this.btlT.UseVisualStyleBackColor = true;
            this.btlT.Click += new System.EventHandler(this.btlT_Click);
            // 
            // btlDN
            // 
            this.btlDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlDN.Location = new System.Drawing.Point(250, 296);
            this.btlDN.Name = "btlDN";
            this.btlDN.Size = new System.Drawing.Size(121, 28);
            this.btlDN.TabIndex = 20;
            this.btlDN.Text = "Đăng Nhập";
            this.btlDN.UseVisualStyleBackColor = true;
            this.btlDN.Click += new System.EventHandler(this.btlDN_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btlT);
            this.Controls.Add(this.btlDN);
            this.Name = "dangnhap";
            this.Text = "dangnhap";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btlT;
        private System.Windows.Forms.Button btlDN;
    }
}