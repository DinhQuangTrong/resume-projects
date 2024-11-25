namespace QuanLySieuThi
{
    partial class Frm_DangNhap
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.lb_MK = new System.Windows.Forms.Label();
            this.lb_TK = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Thoat.Location = new System.Drawing.Point(171, 248);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(146, 42);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_TaiKhoan.Location = new System.Drawing.Point(304, 107);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(228, 30);
            this.txt_TaiKhoan.TabIndex = 11;
            // 
            // lb_MK
            // 
            this.lb_MK.AutoSize = true;
            this.lb_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lb_MK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_MK.Location = new System.Drawing.Point(171, 181);
            this.lb_MK.Name = "lb_MK";
            this.lb_MK.Size = new System.Drawing.Size(111, 26);
            this.lb_MK.TabIndex = 10;
            this.lb_MK.Text = "Mật Khẩu:";
            // 
            // lb_TK
            // 
            this.lb_TK.AutoSize = true;
            this.lb_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lb_TK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_TK.Location = new System.Drawing.Point(166, 107);
            this.lb_TK.Name = "lb_TK";
            this.lb_TK.Size = new System.Drawing.Size(116, 26);
            this.lb_TK.TabIndex = 9;
            this.lb_TK.Text = "Tài Khoản:";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DangNhap.Location = new System.Drawing.Point(371, 248);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(161, 42);
            this.btn_DangNhap.TabIndex = 15;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_DangNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 95);
            this.panel1.TabIndex = 16;
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_DangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lb_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_DangNhap.Location = new System.Drawing.Point(0, 0);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(706, 95);
            this.lb_DangNhap.TabIndex = 8;
            this.lb_DangNhap.Text = "Đăng Nhập";
            this.lb_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_MatKhau.Location = new System.Drawing.Point(304, 177);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(228, 30);
            this.txt_MatKhau.TabIndex = 12;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(706, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.lb_MK);
            this.Controls.Add(this.lb_TK);
            this.Name = "Frm_DangNhap";
            this.Text = "DangNhap";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label lb_MK;
        private System.Windows.Forms.Label lb_TK;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_DangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
    }
}