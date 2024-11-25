namespace QuanLySieuThi
{
    partial class Frm_NhapHang
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
            this.groupBox_NhapHang = new System.Windows.Forms.GroupBox();
            this.dtgv_PN = new System.Windows.Forms.DataGridView();
            this.cbx_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.cbx_MaNhaCC = new System.Windows.Forms.ComboBox();
            this.lb_MaNCC = new System.Windows.Forms.Label();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lb_NgayNhap = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.txt_MaPN = new System.Windows.Forms.TextBox();
            this.lb_MaPN = new System.Windows.Forms.Label();
            this.groupBox_PhieuNhap = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            this.lb_TT = new System.Windows.Forms.Label();
            this.groupBox_ChiTiet = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dtgv_TKSanPham = new System.Windows.Forms.DataGridView();
            this.dtgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_MaSP = new System.Windows.Forms.ComboBox();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.btn1_Xoa = new System.Windows.Forms.Button();
            this.btn1_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lb_SanPham = new System.Windows.Forms.Label();
            this.groupBox_NhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PN)).BeginInit();
            this.groupBox_PhieuNhap.SuspendLayout();
            this.groupBox_ChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TKSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_NhapHang
            // 
            this.groupBox_NhapHang.Controls.Add(this.dtgv_PN);
            this.groupBox_NhapHang.Controls.Add(this.cbx_MaNhanVien);
            this.groupBox_NhapHang.Controls.Add(this.cbx_MaNhaCC);
            this.groupBox_NhapHang.Controls.Add(this.lb_MaNCC);
            this.groupBox_NhapHang.Controls.Add(this.dtp_NgayNhap);
            this.groupBox_NhapHang.Controls.Add(this.lb_NgayNhap);
            this.groupBox_NhapHang.Controls.Add(this.btn_LamMoi);
            this.groupBox_NhapHang.Controls.Add(this.btn_Xoa);
            this.groupBox_NhapHang.Controls.Add(this.btn_Sua);
            this.groupBox_NhapHang.Controls.Add(this.btn_Them);
            this.groupBox_NhapHang.Controls.Add(this.lb_NhanVien);
            this.groupBox_NhapHang.Controls.Add(this.txt_MaPN);
            this.groupBox_NhapHang.Controls.Add(this.lb_MaPN);
            this.groupBox_NhapHang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NhapHang.Location = new System.Drawing.Point(32, 23);
            this.groupBox_NhapHang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_NhapHang.Name = "groupBox_NhapHang";
            this.groupBox_NhapHang.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_NhapHang.Size = new System.Drawing.Size(2796, 515);
            this.groupBox_NhapHang.TabIndex = 2;
            this.groupBox_NhapHang.TabStop = false;
            this.groupBox_NhapHang.Text = "Thông tin phiếu nhập";
            this.groupBox_NhapHang.Enter += new System.EventHandler(this.groupBox_NhapHang_Enter);
            // 
            // dtgv_PN
            // 
            this.dtgv_PN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_PN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PN.Location = new System.Drawing.Point(1268, 27);
            this.dtgv_PN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgv_PN.Name = "dtgv_PN";
            this.dtgv_PN.RowHeadersWidth = 51;
            this.dtgv_PN.RowTemplate.Height = 24;
            this.dtgv_PN.Size = new System.Drawing.Size(1490, 457);
            this.dtgv_PN.TabIndex = 49;
            this.dtgv_PN.Click += new System.EventHandler(this.dtgv_PN_Click_1);
            // 
            // cbx_MaNhanVien
            // 
            this.cbx_MaNhanVien.FormattingEnabled = true;
            this.cbx_MaNhanVien.Location = new System.Drawing.Point(318, 234);
            this.cbx_MaNhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbx_MaNhanVien.Name = "cbx_MaNhanVien";
            this.cbx_MaNhanVien.Size = new System.Drawing.Size(580, 47);
            this.cbx_MaNhanVien.TabIndex = 48;
            // 
            // cbx_MaNhaCC
            // 
            this.cbx_MaNhaCC.FormattingEnabled = true;
            this.cbx_MaNhaCC.Location = new System.Drawing.Point(318, 147);
            this.cbx_MaNhaCC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbx_MaNhaCC.Name = "cbx_MaNhaCC";
            this.cbx_MaNhaCC.Size = new System.Drawing.Size(580, 47);
            this.cbx_MaNhaCC.TabIndex = 47;
            this.cbx_MaNhaCC.SelectedIndexChanged += new System.EventHandler(this.cbb_MaNCC_SelectedIndexChanged);
            // 
            // lb_MaNCC
            // 
            this.lb_MaNCC.AutoSize = true;
            this.lb_MaNCC.Location = new System.Drawing.Point(64, 153);
            this.lb_MaNCC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_MaNCC.Name = "lb_MaNCC";
            this.lb_MaNCC.Size = new System.Drawing.Size(149, 39);
            this.lb_MaNCC.TabIndex = 46;
            this.lb_MaNCC.Text = "Mã NCC";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(318, 320);
            this.dtp_NgayNhap.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(580, 53);
            this.dtp_NgayNhap.TabIndex = 43;
            // 
            // lb_NgayNhap
            // 
            this.lb_NgayNhap.AutoSize = true;
            this.lb_NgayNhap.Location = new System.Drawing.Point(64, 324);
            this.lb_NgayNhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_NgayNhap.Name = "lb_NgayNhap";
            this.lb_NgayNhap.Size = new System.Drawing.Size(179, 39);
            this.lb_NgayNhap.TabIndex = 42;
            this.lb_NgayNhap.Text = "Ngày nhập";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::QuanLySieuThi.Properties.Resources.icons8_load_161;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(984, 60);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_LamMoi.Size = new System.Drawing.Size(224, 81);
            this.btn_LamMoi.TabIndex = 21;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(984, 403);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(224, 81);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::QuanLySieuThi.Properties.Resources.icons8_edit_16;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(984, 296);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(224, 81);
            this.btn_Sua.TabIndex = 23;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(984, 178);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(224, 81);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Location = new System.Drawing.Point(64, 240);
            this.lb_NhanVien.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(227, 39);
            this.lb_NhanVien.TabIndex = 2;
            this.lb_NhanVien.Text = "Mã Nhân viên";
            // 
            // txt_MaPN
            // 
            this.txt_MaPN.Location = new System.Drawing.Point(318, 60);
            this.txt_MaPN.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_MaPN.Name = "txt_MaPN";
            this.txt_MaPN.Size = new System.Drawing.Size(580, 47);
            this.txt_MaPN.TabIndex = 1;
            // 
            // lb_MaPN
            // 
            this.lb_MaPN.AutoSize = true;
            this.lb_MaPN.Location = new System.Drawing.Point(64, 76);
            this.lb_MaPN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_MaPN.Name = "lb_MaPN";
            this.lb_MaPN.Size = new System.Drawing.Size(122, 39);
            this.lb_MaPN.TabIndex = 0;
            this.lb_MaPN.Text = "Mã PN";
            // 
            // groupBox_PhieuNhap
            // 
            this.groupBox_PhieuNhap.Controls.Add(this.btn_Luu);
            this.groupBox_PhieuNhap.Controls.Add(this.txt_DonGia);
            this.groupBox_PhieuNhap.Controls.Add(this.label1);
            this.groupBox_PhieuNhap.Controls.Add(this.lb_ThanhTien);
            this.groupBox_PhieuNhap.Controls.Add(this.lb_TT);
            this.groupBox_PhieuNhap.Controls.Add(this.groupBox_ChiTiet);
            this.groupBox_PhieuNhap.Controls.Add(this.cbx_MaSP);
            this.groupBox_PhieuNhap.Controls.Add(this.lb_SoLuong);
            this.groupBox_PhieuNhap.Controls.Add(this.btn1_Xoa);
            this.groupBox_PhieuNhap.Controls.Add(this.btn1_Them);
            this.groupBox_PhieuNhap.Controls.Add(this.label3);
            this.groupBox_PhieuNhap.Controls.Add(this.txt_SoLuong);
            this.groupBox_PhieuNhap.Controls.Add(this.lb_SanPham);
            this.groupBox_PhieuNhap.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_PhieuNhap.Location = new System.Drawing.Point(32, 550);
            this.groupBox_PhieuNhap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_PhieuNhap.Name = "groupBox_PhieuNhap";
            this.groupBox_PhieuNhap.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_PhieuNhap.Size = new System.Drawing.Size(2796, 936);
            this.groupBox_PhieuNhap.TabIndex = 47;
            this.groupBox_PhieuNhap.TabStop = false;
            this.groupBox_PhieuNhap.Text = "Chi tiết phiếu nhập";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Image = global::QuanLySieuThi.Properties.Resources.Luu;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(2516, 827);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_Luu.Size = new System.Drawing.Size(224, 81);
            this.btn_Luu.TabIndex = 57;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(1634, 70);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(506, 47);
            this.txt_DonGia.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2238, 852);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 55;
            this.label1.Text = "( vnd )";
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Location = new System.Drawing.Point(2038, 852);
            this.lb_ThanhTien.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(170, 39);
            this.lb_ThanhTien.TabIndex = 54;
            this.lb_ThanhTien.Text = "................ ";
            this.lb_ThanhTien.Click += new System.EventHandler(this.cbb_MaNCC_SelectedIndexChanged);
            // 
            // lb_TT
            // 
            this.lb_TT.AutoSize = true;
            this.lb_TT.Location = new System.Drawing.Point(1838, 852);
            this.lb_TT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_TT.Name = "lb_TT";
            this.lb_TT.Size = new System.Drawing.Size(176, 39);
            this.lb_TT.TabIndex = 49;
            this.lb_TT.Text = "Thành tiền";
            // 
            // groupBox_ChiTiet
            // 
            this.groupBox_ChiTiet.Controls.Add(this.btn_TimKiem);
            this.groupBox_ChiTiet.Controls.Add(this.txt_TimKiem);
            this.groupBox_ChiTiet.Controls.Add(this.dtgv_TKSanPham);
            this.groupBox_ChiTiet.Controls.Add(this.dtgv_PhieuNhap);
            this.groupBox_ChiTiet.Location = new System.Drawing.Point(70, 163);
            this.groupBox_ChiTiet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_ChiTiet.Name = "groupBox_ChiTiet";
            this.groupBox_ChiTiet.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_ChiTiet.Size = new System.Drawing.Size(2714, 653);
            this.groupBox_ChiTiet.TabIndex = 46;
            this.groupBox_ChiTiet.TabStop = false;
            this.groupBox_ChiTiet.Text = "Chi tiết";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::QuanLySieuThi.Properties.Resources.icons8_search_16;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(2508, 33);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(180, 81);
            this.btn_TimKiem.TabIndex = 60;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(2040, 50);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(420, 47);
            this.txt_TimKiem.TabIndex = 59;
            // 
            // dtgv_TKSanPham
            // 
            this.dtgv_TKSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_TKSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_TKSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TKSanPham.Location = new System.Drawing.Point(2040, 126);
            this.dtgv_TKSanPham.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgv_TKSanPham.Name = "dtgv_TKSanPham";
            this.dtgv_TKSanPham.RowHeadersWidth = 51;
            this.dtgv_TKSanPham.RowTemplate.Height = 24;
            this.dtgv_TKSanPham.Size = new System.Drawing.Size(662, 475);
            this.dtgv_TKSanPham.TabIndex = 58;
            this.dtgv_TKSanPham.Click += new System.EventHandler(this.dtgv_TKSanPham_Click);
            // 
            // dtgv_PhieuNhap
            // 
            this.dtgv_PhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSP,
            this.soLuong,
            this.donGia,
            this.maPN,
            this.thanhTien});
            this.dtgv_PhieuNhap.Location = new System.Drawing.Point(50, 52);
            this.dtgv_PhieuNhap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgv_PhieuNhap.Name = "dtgv_PhieuNhap";
            this.dtgv_PhieuNhap.RowHeadersWidth = 51;
            this.dtgv_PhieuNhap.RowTemplate.Height = 24;
            this.dtgv_PhieuNhap.Size = new System.Drawing.Size(1966, 548);
            this.dtgv_PhieuNhap.TabIndex = 0;
            this.dtgv_PhieuNhap.Click += new System.EventHandler(this.dtgv_PhieuNhap_Click);
            // 
            // maSP
            // 
            this.maSP.HeaderText = "Mã Sản Phẩm";
            this.maSP.MinimumWidth = 6;
            this.maSP.Name = "maSP";
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            // 
            // maPN
            // 
            this.maPN.HeaderText = "Mã phiếu nhập";
            this.maPN.MinimumWidth = 6;
            this.maPN.Name = "maPN";
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            // 
            // cbx_MaSP
            // 
            this.cbx_MaSP.FormattingEnabled = true;
            this.cbx_MaSP.Location = new System.Drawing.Point(318, 76);
            this.cbx_MaSP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbx_MaSP.Name = "cbx_MaSP";
            this.cbx_MaSP.Size = new System.Drawing.Size(516, 47);
            this.cbx_MaSP.TabIndex = 44;
            this.cbx_MaSP.SelectedIndexChanged += new System.EventHandler(this.cbx_MaSP_SelectedIndexChanged);
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(876, 81);
            this.lb_SoLuong.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(156, 39);
            this.lb_SoLuong.TabIndex = 27;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // btn1_Xoa
            // 
            this.btn1_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn1_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1_Xoa.Location = new System.Drawing.Point(2516, 58);
            this.btn1_Xoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn1_Xoa.Name = "btn1_Xoa";
            this.btn1_Xoa.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn1_Xoa.Size = new System.Drawing.Size(242, 81);
            this.btn1_Xoa.TabIndex = 24;
            this.btn1_Xoa.Text = "Xóa";
            this.btn1_Xoa.UseVisualStyleBackColor = true;
            this.btn1_Xoa.Click += new System.EventHandler(this.btn1_Xoa_Click);
            // 
            // btn1_Them
            // 
            this.btn1_Them.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.btn1_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1_Them.Location = new System.Drawing.Point(2218, 58);
            this.btn1_Them.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn1_Them.Name = "btn1_Them";
            this.btn1_Them.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btn1_Them.Size = new System.Drawing.Size(242, 81);
            this.btn1_Them.TabIndex = 22;
            this.btn1_Them.Text = "Thêm";
            this.btn1_Them.UseVisualStyleBackColor = true;
            this.btn1_Them.Click += new System.EventHandler(this.btn1_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1450, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(1060, 76);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(344, 47);
            this.txt_SoLuong.TabIndex = 1;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // lb_SanPham
            // 
            this.lb_SanPham.AutoSize = true;
            this.lb_SanPham.Location = new System.Drawing.Point(62, 81);
            this.lb_SanPham.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_SanPham.Name = "lb_SanPham";
            this.lb_SanPham.Size = new System.Drawing.Size(219, 39);
            this.lb_SanPham.TabIndex = 0;
            this.lb_SanPham.Text = "Mã sản phẩm";
            // 
            // Frm_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2634, 1466);
            this.Controls.Add(this.groupBox_PhieuNhap);
            this.Controls.Add(this.groupBox_NhapHang);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frm_NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.groupBox_NhapHang.ResumeLayout(false);
            this.groupBox_NhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PN)).EndInit();
            this.groupBox_PhieuNhap.ResumeLayout(false);
            this.groupBox_PhieuNhap.PerformLayout();
            this.groupBox_ChiTiet.ResumeLayout(false);
            this.groupBox_ChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TKSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NhapHang;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.Label lb_NgayNhap;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.TextBox txt_MaPN;
        private System.Windows.Forms.Label lb_MaPN;
        private System.Windows.Forms.ComboBox cbx_MaNhaCC;
        private System.Windows.Forms.Label lb_MaNCC;
        private System.Windows.Forms.ComboBox cbx_MaNhanVien;
        private System.Windows.Forms.GroupBox groupBox_PhieuNhap;
        private System.Windows.Forms.Label lb_TT;
        private System.Windows.Forms.GroupBox groupBox_ChiTiet;
        private System.Windows.Forms.DataGridView dtgv_PhieuNhap;
        private System.Windows.Forms.ComboBox cbx_MaSP;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Button btn1_Xoa;
        private System.Windows.Forms.Button btn1_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lb_SanPham;
        private System.Windows.Forms.Label lb_ThanhTien;
        private System.Windows.Forms.DataGridView dtgv_PN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dtgv_TKSanPham;
        private System.Windows.Forms.Button btn_Luu;
    }
}