namespace QuanLySieuThi
{
    partial class Form_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TrangChu));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_LoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.memu_KhuyenMai = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.thươngHiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_LapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_NhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Header.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.flowLayoutPanel1);
            this.panel_Header.Controls.Add(this.menuStrip1);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(6);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1890, 68);
            this.panel_Header.TabIndex = 0;
            this.panel_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(162, 107);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(16, 16);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m,
            this.menu_DanhMuc,
            this.menu_BanHang,
            this.menu_NhapHang,
            this.menu_BaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1890, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // m
            // 
            this.m.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_DangXuat});
            this.m.Image = global::QuanLySieuThi.Properties.Resources.icons8_setting_ios_17_filled_32;
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(196, 48);
            this.m.Text = "Hệ thống";
            this.m.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menu_DangXuat
            // 
            this.menu_DangXuat.Image = global::QuanLySieuThi.Properties.Resources.icons8_Logout_32;
            this.menu_DangXuat.Name = "menu_DangXuat";
            this.menu_DangXuat.Size = new System.Drawing.Size(333, 54);
            this.menu_DangXuat.Text = "Đăng xuất";
            this.menu_DangXuat.Click += new System.EventHandler(this.menu_DangXuat_Click);
            // 
            // menu_DanhMuc
            // 
            this.menu_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_NhanVien,
            this.menu_LoaiSanPham,
            this.menu_SanPham,
            this.memu_KhuyenMai,
            this.menu_NhaCungCap,
            this.menu_KhachHang,
            this.menu_TaiKhoan,
            this.thươngHiệuToolStripMenuItem,
            this.chứcVụToolStripMenuItem});
            this.menu_DanhMuc.Image = global::QuanLySieuThi.Properties.Resources.icons8_descending_sorting_32;
            this.menu_DanhMuc.Name = "menu_DanhMuc";
            this.menu_DanhMuc.Size = new System.Drawing.Size(214, 48);
            this.menu_DanhMuc.Text = "Danh mục";
            // 
            // menu_NhanVien
            // 
            this.menu_NhanVien.Image = global::QuanLySieuThi.Properties.Resources.icons8_user_group_32;
            this.menu_NhanVien.Name = "menu_NhanVien";
            this.menu_NhanVien.Size = new System.Drawing.Size(398, 54);
            this.menu_NhanVien.Text = "Nhân viên";
            this.menu_NhanVien.Click += new System.EventHandler(this.menu_NhanVien_Click);
            // 
            // menu_LoaiSanPham
            // 
            this.menu_LoaiSanPham.Image = global::QuanLySieuThi.Properties.Resources.icons8_box_32;
            this.menu_LoaiSanPham.Name = "menu_LoaiSanPham";
            this.menu_LoaiSanPham.Size = new System.Drawing.Size(398, 54);
            this.menu_LoaiSanPham.Text = "Loại sản phẩm";
            this.menu_LoaiSanPham.Click += new System.EventHandler(this.menu_LoaiSanPham_Click);
            // 
            // menu_SanPham
            // 
            this.menu_SanPham.Image = global::QuanLySieuThi.Properties.Resources.icons8_product_32;
            this.menu_SanPham.Name = "menu_SanPham";
            this.menu_SanPham.Size = new System.Drawing.Size(398, 54);
            this.menu_SanPham.Text = "Sản phẩm";
            this.menu_SanPham.Click += new System.EventHandler(this.menu_SanPham_Click);
            // 
            // memu_KhuyenMai
            // 
            this.memu_KhuyenMai.Image = global::QuanLySieuThi.Properties.Resources.icons8_discount_32;
            this.memu_KhuyenMai.Name = "memu_KhuyenMai";
            this.memu_KhuyenMai.Size = new System.Drawing.Size(398, 54);
            this.memu_KhuyenMai.Text = "Khuyến mại";
            this.memu_KhuyenMai.Click += new System.EventHandler(this.memu_KhuyenMai_Click);
            // 
            // menu_NhaCungCap
            // 
            this.menu_NhaCungCap.Image = global::QuanLySieuThi.Properties.Resources.icons8_supplier_32;
            this.menu_NhaCungCap.Name = "menu_NhaCungCap";
            this.menu_NhaCungCap.Size = new System.Drawing.Size(398, 54);
            this.menu_NhaCungCap.Text = "Nhà cung cấp";
            this.menu_NhaCungCap.Click += new System.EventHandler(this.menu_NhaCungCap_Click);
            // 
            // menu_KhachHang
            // 
            this.menu_KhachHang.Image = global::QuanLySieuThi.Properties.Resources.icons8_customer_32;
            this.menu_KhachHang.Name = "menu_KhachHang";
            this.menu_KhachHang.Size = new System.Drawing.Size(398, 54);
            this.menu_KhachHang.Text = "Khách hàng";
            this.menu_KhachHang.Click += new System.EventHandler(this.menu_KhachHang_Click);
            // 
            // menu_TaiKhoan
            // 
            this.menu_TaiKhoan.Image = global::QuanLySieuThi.Properties.Resources.icons8_acount_32;
            this.menu_TaiKhoan.Name = "menu_TaiKhoan";
            this.menu_TaiKhoan.Size = new System.Drawing.Size(398, 54);
            this.menu_TaiKhoan.Text = "Tài khoản";
            this.menu_TaiKhoan.Click += new System.EventHandler(this.menu_TaiKhoan_Click);
            // 
            // thươngHiệuToolStripMenuItem
            // 
            this.thươngHiệuToolStripMenuItem.Image = global::QuanLySieuThi.Properties.Resources.icons8_brand_32;
            this.thươngHiệuToolStripMenuItem.Name = "thươngHiệuToolStripMenuItem";
            this.thươngHiệuToolStripMenuItem.Size = new System.Drawing.Size(398, 54);
            this.thươngHiệuToolStripMenuItem.Text = "Thương Hiệu";
            this.thươngHiệuToolStripMenuItem.Click += new System.EventHandler(this.thươngHiệuToolStripMenuItem_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Image = global::QuanLySieuThi.Properties.Resources.icons8_card_32;
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(398, 54);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // menu_BanHang
            // 
            this.menu_BanHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_LapHoaDon});
            this.menu_BanHang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_BanHang.Image = global::QuanLySieuThi.Properties.Resources.icons8_billsetting_32;
            this.menu_BanHang.Name = "menu_BanHang";
            this.menu_BanHang.Size = new System.Drawing.Size(212, 48);
            this.menu_BanHang.Text = "Bán Hàng";
            this.menu_BanHang.Click += new System.EventHandler(this.menu_HoaDon_Click);
            // 
            // menu_LapHoaDon
            // 
            this.menu_LapHoaDon.Image = global::QuanLySieuThi.Properties.Resources.icons8_bill_32;
            this.menu_LapHoaDon.Name = "menu_LapHoaDon";
            this.menu_LapHoaDon.Size = new System.Drawing.Size(448, 54);
            this.menu_LapHoaDon.Text = "Lập hóa đơn";
            this.menu_LapHoaDon.Click += new System.EventHandler(this.menu_LapHoaDon_Click);
            // 
            // menu_NhapHang
            // 
            this.menu_NhapHang.Image = global::QuanLySieuThi.Properties.Resources.icons8_handle_with_care_32;
            this.menu_NhapHang.Name = "menu_NhapHang";
            this.menu_NhapHang.Size = new System.Drawing.Size(225, 48);
            this.menu_NhapHang.Text = "Nhập hàng";
            this.menu_NhapHang.Click += new System.EventHandler(this.menu_NhapHang_Click);
            // 
            // menu_BaoCao
            // 
            this.menu_BaoCao.Image = global::QuanLySieuThi.Properties.Resources.icons8_report_32;
            this.menu_BaoCao.Name = "menu_BaoCao";
            this.menu_BaoCao.Size = new System.Drawing.Size(184, 48);
            this.menu_BaoCao.Text = "Báo cáo";
            this.menu_BaoCao.Click += new System.EventHandler(this.menu_BaoCao_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_Body.Controls.Add(this.pictureBox1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 68);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(6);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1890, 966);
            this.panel_Body.TabIndex = 1;
            this.panel_Body.Tag = "panel_Body";
            this.panel_Body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Body_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1890, 966);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 1034);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Header);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_TrangChu";
            this.Text = "HỆ THỐNG QUẢN LÝ SIÊU THỊ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_BanHang;
        private System.Windows.Forms.ToolStripMenuItem menu_NhapHang;
        private System.Windows.Forms.ToolStripMenuItem menu_BaoCao;
        private System.Windows.Forms.ToolStripMenuItem menu_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menu_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem menu_SanPham;
        private System.Windows.Forms.ToolStripMenuItem memu_KhuyenMai;
        private System.Windows.Forms.ToolStripMenuItem menu_NhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem menu_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem menu_TaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menu_LapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem m;
        private System.Windows.Forms.ToolStripMenuItem menu_DangXuat;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.ToolStripMenuItem menu_LoaiSanPham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thươngHiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
    }
}

