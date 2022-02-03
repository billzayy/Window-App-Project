namespace QUANLY1
{
    partial class DangNhap
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPass.Location = new System.Drawing.Point(183, 167);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(207, 27);
            this.txtPass.TabIndex = 11;
            this.txtPass.Tag = "";
            // 
            // lblChuaCoTaiKhoan
            // 
            this.lblChuaCoTaiKhoan.AutoSize = true;
            this.lblChuaCoTaiKhoan.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblChuaCoTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChuaCoTaiKhoan.Location = new System.Drawing.Point(201, 336);
            this.lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            this.lblChuaCoTaiKhoan.Size = new System.Drawing.Size(152, 21);
            this.lblChuaCoTaiKhoan.TabIndex = 17;
            this.lblChuaCoTaiKhoan.Text = "Chưa có tài khoản ?";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangNhap.Location = new System.Drawing.Point(205, 282);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(130, 36);
            this.btnDangNhap.TabIndex = 14;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTenDangNhap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTenDangNhap.Location = new System.Drawing.Point(183, 100);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(207, 27);
            this.txtTenDangNhap.TabIndex = 10;
            this.txtTenDangNhap.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(307, -44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đăng Nhập";
            // 
            // lbDN
            // 
            this.lbDN.AutoSize = true;
            this.lbDN.Font = new System.Drawing.Font("Palatino Linotype", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbDN.Location = new System.Drawing.Point(40, 100);
            this.lbDN.Name = "lbDN";
            this.lbDN.Size = new System.Drawing.Size(114, 27);
            this.lbDN.TabIndex = 19;
            this.lbDN.Text = "Tài Khoản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mật Khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(56, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chức Vụ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(199, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đăng Nhập";
            // 
            // cmbVC
            // 
            this.cmbVC.FormattingEnabled = true;
            this.cmbVC.Items.AddRange(new object[] {
            "Quản Lí",
            "Nhân Viên"});
            this.cmbVC.Location = new System.Drawing.Point(183, 234);
            this.cmbVC.Name = "cmbVC";
            this.cmbVC.Size = new System.Drawing.Size(207, 21);
            this.cmbVC.TabIndex = 23;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 397);
            this.Controls.Add(this.cmbVC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDN);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblChuaCoTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblChuaCoTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVC;
    }
}