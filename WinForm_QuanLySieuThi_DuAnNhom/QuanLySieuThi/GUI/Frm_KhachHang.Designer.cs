namespace QuanLySieuThi
{
    partial class Frm_KhachHang
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
            this.groupBox_NhanVien = new System.Windows.Forms.GroupBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lb_NS = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.lb_SĐT = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.lb_TKH = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_DC = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.lb_KH = new System.Windows.Forms.Label();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt1_MaKhachHang = new System.Windows.Forms.TextBox();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.groupBox_DanhSachKH = new System.Windows.Forms.GroupBox();
            this.dtgv_Khachhang = new System.Windows.Forms.DataGridView();
            this.groupBox_NhanVien.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.groupBox_DanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_NhanVien
            // 
            this.groupBox_NhanVien.Controls.Add(this.dtp_NgaySinh);
            this.groupBox_NhanVien.Controls.Add(this.lb_NS);
            this.groupBox_NhanVien.Controls.Add(this.txt_Email);
            this.groupBox_NhanVien.Controls.Add(this.lb_Email);
            this.groupBox_NhanVien.Controls.Add(this.txt_DienThoai);
            this.groupBox_NhanVien.Controls.Add(this.lb_SĐT);
            this.groupBox_NhanVien.Controls.Add(this.btn_Xoa);
            this.groupBox_NhanVien.Controls.Add(this.btn_Sua);
            this.groupBox_NhanVien.Controls.Add(this.btn_Them);
            this.groupBox_NhanVien.Controls.Add(this.btn_LamMoi);
            this.groupBox_NhanVien.Controls.Add(this.txt_TenKH);
            this.groupBox_NhanVien.Controls.Add(this.lb_TKH);
            this.groupBox_NhanVien.Controls.Add(this.txt_DiaChi);
            this.groupBox_NhanVien.Controls.Add(this.lb_DC);
            this.groupBox_NhanVien.Controls.Add(this.txt_MaKH);
            this.groupBox_NhanVien.Controls.Add(this.lb_KH);
            this.groupBox_NhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NhanVien.Location = new System.Drawing.Point(12, 12);
            this.groupBox_NhanVien.Name = "groupBox_NhanVien";
            this.groupBox_NhanVien.Size = new System.Drawing.Size(1288, 213);
            this.groupBox_NhanVien.TabIndex = 2;
            this.groupBox_NhanVien.TabStop = false;
            this.groupBox_NhanVien.Text = "Thông tin khách hàng";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(1066, 95);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(183, 30);
            this.dtp_NgaySinh.TabIndex = 45;
            // 
            // lb_NS
            // 
            this.lb_NS.AutoSize = true;
            this.lb_NS.Location = new System.Drawing.Point(977, 103);
            this.lb_NS.Name = "lb_NS";
            this.lb_NS.Size = new System.Drawing.Size(82, 19);
            this.lb_NS.TabIndex = 21;
            this.lb_NS.Text = "Ngày sinh";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(127, 152);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(427, 27);
            this.txt_Email.TabIndex = 20;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(29, 155);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(49, 19);
            this.lb_Email.TabIndex = 19;
            this.lb_Email.Text = "Email";
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(734, 94);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(221, 27);
            this.txt_DienThoai.TabIndex = 18;
            // 
            // lb_SĐT
            // 
            this.lb_SĐT.AutoSize = true;
            this.lb_SĐT.Location = new System.Drawing.Point(637, 102);
            this.lb_SĐT.Name = "lb_SĐT";
            this.lb_SĐT.Size = new System.Drawing.Size(83, 19);
            this.lb_SĐT.TabIndex = 17;
            this.lb_SĐT.Text = "Điện thoại";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(1088, 152);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(121, 42);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::QuanLySieuThi.Properties.Resources.icons8_edit_16;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(938, 152);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(121, 42);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(794, 152);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::QuanLySieuThi.Properties.Resources.icons8_load_161;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(641, 152);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_LamMoi.Size = new System.Drawing.Size(121, 42);
            this.btn_LamMoi.TabIndex = 13;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(734, 43);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(515, 27);
            this.txt_TenKH.TabIndex = 7;
            // 
            // lb_TKH
            // 
            this.lb_TKH.AutoSize = true;
            this.lb_TKH.Location = new System.Drawing.Point(637, 51);
            this.lb_TKH.Name = "lb_TKH";
            this.lb_TKH.Size = new System.Drawing.Size(63, 19);
            this.lb_TKH.TabIndex = 6;
            this.lb_TKH.Text = "Tên KH";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(127, 100);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(427, 27);
            this.txt_DiaChi.TabIndex = 5;
            // 
            // lb_DC
            // 
            this.lb_DC.AutoSize = true;
            this.lb_DC.Location = new System.Drawing.Point(29, 103);
            this.lb_DC.Name = "lb_DC";
            this.lb_DC.Size = new System.Drawing.Size(61, 19);
            this.lb_DC.TabIndex = 4;
            this.lb_DC.Text = "Địa chỉ";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(127, 45);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(427, 27);
            this.txt_MaKH.TabIndex = 1;
            // 
            // lb_KH
            // 
            this.lb_KH.AutoSize = true;
            this.lb_KH.Location = new System.Drawing.Point(29, 48);
            this.lb_KH.Name = "lb_KH";
            this.lb_KH.Size = new System.Drawing.Size(58, 19);
            this.lb_KH.TabIndex = 0;
            this.lb_KH.Text = "Mã KH";
            // 
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.Controls.Add(this.btn_TimKiem);
            this.groupBox_TimKiem.Controls.Add(this.txt1_MaKhachHang);
            this.groupBox_TimKiem.Controls.Add(this.lb_TenKH);
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimKiem.Location = new System.Drawing.Point(12, 255);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Size = new System.Drawing.Size(1288, 97);
            this.groupBox_TimKiem.TabIndex = 3;
            this.groupBox_TimKiem.TabStop = false;
            this.groupBox_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::QuanLySieuThi.Properties.Resources.icons8_search_16;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(1109, 31);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(121, 42);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt1_MaKhachHang
            // 
            this.txt1_MaKhachHang.Location = new System.Drawing.Point(794, 40);
            this.txt1_MaKhachHang.Name = "txt1_MaKhachHang";
            this.txt1_MaKhachHang.Size = new System.Drawing.Size(292, 27);
            this.txt1_MaKhachHang.TabIndex = 17;
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(637, 43);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(121, 19);
            this.lb_TenKH.TabIndex = 17;
            this.lb_TenKH.Text = "Mã khách hàng";
            // 
            // groupBox_DanhSachKH
            // 
            this.groupBox_DanhSachKH.Controls.Add(this.dtgv_Khachhang);
            this.groupBox_DanhSachKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhSachKH.Location = new System.Drawing.Point(12, 380);
            this.groupBox_DanhSachKH.Name = "groupBox_DanhSachKH";
            this.groupBox_DanhSachKH.Size = new System.Drawing.Size(1288, 295);
            this.groupBox_DanhSachKH.TabIndex = 4;
            this.groupBox_DanhSachKH.TabStop = false;
            this.groupBox_DanhSachKH.Text = "Danh sách khách hàng";
            // 
            // dtgv_Khachhang
            // 
            this.dtgv_Khachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Khachhang.Location = new System.Drawing.Point(25, 26);
            this.dtgv_Khachhang.Name = "dtgv_Khachhang";
            this.dtgv_Khachhang.RowHeadersWidth = 51;
            this.dtgv_Khachhang.RowTemplate.Height = 24;
            this.dtgv_Khachhang.Size = new System.Drawing.Size(1247, 263);
            this.dtgv_Khachhang.TabIndex = 0;
            this.dtgv_Khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Khachhang_CellContentClick);
            this.dtgv_Khachhang.Click += new System.EventHandler(this.dtgv_Khachhang_Click);
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 606);
            this.Controls.Add(this.groupBox_DanhSachKH);
            this.Controls.Add(this.groupBox_TimKiem);
            this.Controls.Add(this.groupBox_NhanVien);
            this.Name = "Frm_KhachHang";
            this.Text = "Khachhang";
            this.groupBox_NhanVien.ResumeLayout(false);
            this.groupBox_NhanVien.PerformLayout();
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_TimKiem.PerformLayout();
            this.groupBox_DanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NhanVien;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.Label lb_SĐT;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label lb_TKH;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_DC;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label lb_KH;
        private System.Windows.Forms.Label lb_NS;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt1_MaKhachHang;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.GroupBox groupBox_DanhSachKH;
        private System.Windows.Forms.DataGridView dtgv_Khachhang;
    }
}