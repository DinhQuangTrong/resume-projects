namespace QuanLySieuThi
{
    partial class Frm_LapHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ChuThich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_HD = new System.Windows.Forms.DataGridView();
            this.cbx_MaNV = new System.Windows.Forms.ComboBox();
            this.cbx_MaKH = new System.Windows.Forms.ComboBox();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.lb_NgayBĐ = new System.Windows.Forms.Label();
            this.lb_KH = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_TenKM = new System.Windows.Forms.Label();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TienThua = new System.Windows.Forms.TextBox();
            this.btn_LuuHoaDon = new System.Windows.Forms.Button();
            this.lb_TienThua = new System.Windows.Forms.Label();
            this.txt_TienKhach = new System.Windows.Forms.TextBox();
            this.lb_TK = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lb_TT = new System.Windows.Forms.Label();
            this.cbx_PTKM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_ChiTiet = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dtgv_TKSanPham = new System.Windows.Forms.DataGridView();
            this.dtgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.cbx_MaSP = new System.Windows.Forms.ComboBox();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.btn1_Xoa = new System.Windows.Forms.Button();
            this.btn1_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_SanPham = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_ChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TKSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ChuThich);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtgv_HD);
            this.groupBox1.Controls.Add(this.cbx_MaNV);
            this.groupBox1.Controls.Add(this.cbx_MaKH);
            this.groupBox1.Controls.Add(this.dtp_NgayLap);
            this.groupBox1.Controls.Add(this.lb_NgayBĐ);
            this.groupBox1.Controls.Add(this.lb_KH);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.lb_TenKM);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.lb_MaHD);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txt_ChuThich
            // 
            this.txt_ChuThich.Location = new System.Drawing.Point(132, 228);
            this.txt_ChuThich.Name = "txt_ChuThich";
            this.txt_ChuThich.Size = new System.Drawing.Size(439, 27);
            this.txt_ChuThich.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Chú thích";
            // 
            // dtgv_HD
            // 
            this.dtgv_HD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HD.Location = new System.Drawing.Point(592, 19);
            this.dtgv_HD.Name = "dtgv_HD";
            this.dtgv_HD.RowHeadersWidth = 51;
            this.dtgv_HD.RowTemplate.Height = 24;
            this.dtgv_HD.Size = new System.Drawing.Size(714, 256);
            this.dtgv_HD.TabIndex = 50;
            this.dtgv_HD.Click += new System.EventHandler(this.dtgv_HD_Click);
            // 
            // cbx_MaNV
            // 
            this.cbx_MaNV.FormattingEnabled = true;
            this.cbx_MaNV.Location = new System.Drawing.Point(186, 126);
            this.cbx_MaNV.Name = "cbx_MaNV";
            this.cbx_MaNV.Size = new System.Drawing.Size(239, 27);
            this.cbx_MaNV.TabIndex = 45;
            this.cbx_MaNV.SelectedIndexChanged += new System.EventHandler(this.cbx_MaNV_SelectedIndexChanged);
            // 
            // cbx_MaKH
            // 
            this.cbx_MaKH.FormattingEnabled = true;
            this.cbx_MaKH.Location = new System.Drawing.Point(186, 81);
            this.cbx_MaKH.Name = "cbx_MaKH";
            this.cbx_MaKH.Size = new System.Drawing.Size(239, 27);
            this.cbx_MaKH.TabIndex = 44;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLap.Location = new System.Drawing.Point(186, 172);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(239, 30);
            this.dtp_NgayLap.TabIndex = 43;
            // 
            // lb_NgayBĐ
            // 
            this.lb_NgayBĐ.AutoSize = true;
            this.lb_NgayBĐ.Location = new System.Drawing.Point(38, 180);
            this.lb_NgayBĐ.Name = "lb_NgayBĐ";
            this.lb_NgayBĐ.Size = new System.Drawing.Size(73, 19);
            this.lb_NgayBĐ.TabIndex = 42;
            this.lb_NgayBĐ.Text = "Ngày lập";
            // 
            // lb_KH
            // 
            this.lb_KH.AutoSize = true;
            this.lb_KH.Location = new System.Drawing.Point(33, 84);
            this.lb_KH.Name = "lb_KH";
            this.lb_KH.Size = new System.Drawing.Size(121, 19);
            this.lb_KH.TabIndex = 27;
            this.lb_KH.Text = "Mã khách hàng";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::QuanLySieuThi.Properties.Resources.icons8_load_161;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(450, 180);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_LamMoi.Size = new System.Drawing.Size(121, 42);
            this.btn_LamMoi.TabIndex = 21;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(450, 132);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(121, 42);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Image = global::QuanLySieuThi.Properties.Resources.icons8_edit_16;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(450, 84);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(121, 42);
            this.btn_Sua.TabIndex = 23;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(450, 27);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lb_TenKM
            // 
            this.lb_TenKM.AutoSize = true;
            this.lb_TenKM.Location = new System.Drawing.Point(33, 129);
            this.lb_TenKM.Name = "lb_TenKM";
            this.lb_TenKM.Size = new System.Drawing.Size(106, 19);
            this.lb_TenKM.TabIndex = 2;
            this.lb_TenKM.Text = "Mã nhân viên";
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(186, 39);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(239, 27);
            this.txt_MaHD.TabIndex = 1;
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Location = new System.Drawing.Point(33, 39);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(98, 19);
            this.lb_MaHD.TabIndex = 0;
            this.lb_MaHD.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.txt_TienThua);
            this.groupBox2.Controls.Add(this.btn_LuuHoaDon);
            this.groupBox2.Controls.Add(this.lb_TienThua);
            this.groupBox2.Controls.Add(this.txt_TienKhach);
            this.groupBox2.Controls.Add(this.lb_TK);
            this.groupBox2.Controls.Add(this.txt_TongTien);
            this.groupBox2.Controls.Add(this.lb_TT);
            this.groupBox2.Controls.Add(this.cbx_PTKM);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox_ChiTiet);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.cbx_MaSP);
            this.groupBox2.Controls.Add(this.lb_SoLuong);
            this.groupBox2.Controls.Add(this.btn1_Xoa);
            this.groupBox2.Controls.Add(this.btn1_Them);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lb_SanPham);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1345, 533);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(759, 36);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(251, 27);
            this.txt_DonGia.TabIndex = 55;
            // 
            // txt_TienThua
            // 
            this.txt_TienThua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TienThua.Location = new System.Drawing.Point(592, 488);
            this.txt_TienThua.Name = "txt_TienThua";
            this.txt_TienThua.ReadOnly = true;
            this.txt_TienThua.Size = new System.Drawing.Size(286, 27);
            this.txt_TienThua.TabIndex = 54;
            // 
            // btn_LuuHoaDon
            // 
            this.btn_LuuHoaDon.Enabled = false;
            this.btn_LuuHoaDon.Image = global::QuanLySieuThi.Properties.Resources.Luu;
            this.btn_LuuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuHoaDon.Location = new System.Drawing.Point(1008, 451);
            this.btn_LuuHoaDon.Name = "btn_LuuHoaDon";
            this.btn_LuuHoaDon.Padding = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.btn_LuuHoaDon.Size = new System.Drawing.Size(94, 42);
            this.btn_LuuHoaDon.TabIndex = 46;
            this.btn_LuuHoaDon.Text = "Lưu ";
            this.btn_LuuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LuuHoaDon.UseVisualStyleBackColor = true;
            this.btn_LuuHoaDon.Click += new System.EventHandler(this.btn_LuuHoaDon_Click);
            // 
            // lb_TienThua
            // 
            this.lb_TienThua.AutoSize = true;
            this.lb_TienThua.Location = new System.Drawing.Point(471, 496);
            this.lb_TienThua.Name = "lb_TienThua";
            this.lb_TienThua.Size = new System.Drawing.Size(77, 19);
            this.lb_TienThua.TabIndex = 53;
            this.lb_TienThua.Text = "Tiền thừa";
            // 
            // txt_TienKhach
            // 
            this.txt_TienKhach.Location = new System.Drawing.Point(592, 427);
            this.txt_TienKhach.Name = "txt_TienKhach";
            this.txt_TienKhach.Size = new System.Drawing.Size(286, 27);
            this.txt_TienKhach.TabIndex = 52;
            // 
            // lb_TK
            // 
            this.lb_TK.AutoSize = true;
            this.lb_TK.Location = new System.Drawing.Point(460, 430);
            this.lb_TK.Name = "lb_TK";
            this.lb_TK.Size = new System.Drawing.Size(88, 19);
            this.lb_TK.TabIndex = 51;
            this.lb_TK.Text = "Tiền khách";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Location = new System.Drawing.Point(165, 488);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(260, 27);
            this.txt_TongTien.TabIndex = 50;
            this.txt_TongTien.Text = "0";
            // 
            // lb_TT
            // 
            this.lb_TT.AutoSize = true;
            this.lb_TT.Location = new System.Drawing.Point(38, 491);
            this.lb_TT.Name = "lb_TT";
            this.lb_TT.Size = new System.Drawing.Size(76, 19);
            this.lb_TT.TabIndex = 49;
            this.lb_TT.Text = "Tổng tiền";
            // 
            // cbx_PTKM
            // 
            this.cbx_PTKM.FormattingEnabled = true;
            this.cbx_PTKM.Location = new System.Drawing.Point(165, 427);
            this.cbx_PTKM.Name = "cbx_PTKM";
            this.cbx_PTKM.Size = new System.Drawing.Size(260, 27);
            this.cbx_PTKM.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Khuyến mãi";
            // 
            // groupBox_ChiTiet
            // 
            this.groupBox_ChiTiet.Controls.Add(this.btn_TimKiem);
            this.groupBox_ChiTiet.Controls.Add(this.txt_TimKiem);
            this.groupBox_ChiTiet.Controls.Add(this.dtgv_TKSanPham);
            this.groupBox_ChiTiet.Controls.Add(this.dtgv_ChiTietHoaDon);
            this.groupBox_ChiTiet.Location = new System.Drawing.Point(35, 84);
            this.groupBox_ChiTiet.Name = "groupBox_ChiTiet";
            this.groupBox_ChiTiet.Size = new System.Drawing.Size(1290, 337);
            this.groupBox_ChiTiet.TabIndex = 46;
            this.groupBox_ChiTiet.TabStop = false;
            this.groupBox_ChiTiet.Text = "Chi tiết";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::QuanLySieuThi.Properties.Resources.icons8_search_16;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(1155, 18);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(90, 42);
            this.btn_TimKiem.TabIndex = 57;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(947, 27);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(195, 27);
            this.txt_TimKiem.TabIndex = 56;
            // 
            // dtgv_TKSanPham
            // 
            this.dtgv_TKSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_TKSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_TKSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TKSanPham.Location = new System.Drawing.Point(947, 66);
            this.dtgv_TKSanPham.Name = "dtgv_TKSanPham";
            this.dtgv_TKSanPham.RowHeadersWidth = 51;
            this.dtgv_TKSanPham.RowTemplate.Height = 24;
            this.dtgv_TKSanPham.Size = new System.Drawing.Size(331, 244);
            this.dtgv_TKSanPham.TabIndex = 53;
            this.dtgv_TKSanPham.Click += new System.EventHandler(this.dtgv_TKSanPham_Click);
            // 
            // dtgv_ChiTietHoaDon
            // 
            this.dtgv_ChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSP,
            this.soLuong,
            this.donGia,
            this.maHD,
            this.thanhTien});
            this.dtgv_ChiTietHoaDon.Location = new System.Drawing.Point(25, 27);
            this.dtgv_ChiTietHoaDon.Name = "dtgv_ChiTietHoaDon";
            this.dtgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dtgv_ChiTietHoaDon.RowTemplate.Height = 24;
            this.dtgv_ChiTietHoaDon.Size = new System.Drawing.Size(903, 283);
            this.dtgv_ChiTietHoaDon.TabIndex = 0;
            this.dtgv_ChiTietHoaDon.Click += new System.EventHandler(this.dtgv_ChiTietHoaDon_Click);
            // 
            // maSP
            // 
            this.maSP.HeaderText = "Mã sản phẩm";
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
            // maHD
            // 
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(511, 39);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(157, 27);
            this.txt_SoLuong.TabIndex = 45;
            // 
            // cbx_MaSP
            // 
            this.cbx_MaSP.FormattingEnabled = true;
            this.cbx_MaSP.Location = new System.Drawing.Point(132, 39);
            this.cbx_MaSP.Name = "cbx_MaSP";
            this.cbx_MaSP.Size = new System.Drawing.Size(260, 27);
            this.cbx_MaSP.TabIndex = 44;
            this.cbx_MaSP.SelectedIndexChanged += new System.EventHandler(this.cbx_MaSP_SelectedIndexChanged);
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(428, 42);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(77, 19);
            this.lb_SoLuong.TabIndex = 27;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // btn1_Xoa
            // 
            this.btn1_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn1_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1_Xoa.Location = new System.Drawing.Point(1183, 30);
            this.btn1_Xoa.Name = "btn1_Xoa";
            this.btn1_Xoa.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn1_Xoa.Size = new System.Drawing.Size(121, 42);
            this.btn1_Xoa.TabIndex = 24;
            this.btn1_Xoa.Text = "Xóa";
            this.btn1_Xoa.UseVisualStyleBackColor = true;
            this.btn1_Xoa.Click += new System.EventHandler(this.btn1_Xoa_Click_1);
            // 
            // btn1_Them
            // 
            this.btn1_Them.Image = global::QuanLySieuThi.Properties.Resources.icons8_add_16;
            this.btn1_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1_Them.Location = new System.Drawing.Point(1056, 30);
            this.btn1_Them.Name = "btn1_Them";
            this.btn1_Them.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn1_Them.Size = new System.Drawing.Size(121, 42);
            this.btn1_Them.TabIndex = 22;
            this.btn1_Them.Text = "Thêm";
            this.btn1_Them.UseVisualStyleBackColor = true;
            this.btn1_Them.Click += new System.EventHandler(this.btn1_ThemCTHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // lb_SanPham
            // 
            this.lb_SanPham.AutoSize = true;
            this.lb_SanPham.Location = new System.Drawing.Point(31, 42);
            this.lb_SanPham.Name = "lb_SanPham";
            this.lb_SanPham.Size = new System.Drawing.Size(83, 19);
            this.lb_SanPham.TabIndex = 0;
            this.lb_SanPham.Text = "Sản phẩm";
            // 
            // Frm_LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 797);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_LapHoaDon";
            this.Text = "LapHoaDon";
            this.Load += new System.EventHandler(this.Frm_LapHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_ChiTiet.ResumeLayout(false);
            this.groupBox_ChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TKSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label lb_NgayBĐ;
        private System.Windows.Forms.Label lb_KH;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb_TenKM;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.ComboBox cbx_MaKH;
        private System.Windows.Forms.ComboBox cbx_MaNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_MaSP;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Button btn1_Xoa;
        private System.Windows.Forms.Button btn1_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_SanPham;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.GroupBox groupBox_ChiTiet;
        private System.Windows.Forms.DataGridView dtgv_ChiTietHoaDon;
        private System.Windows.Forms.Button btn_LuuHoaDon;
        private System.Windows.Forms.DataGridView dtgv_HD;
        private System.Windows.Forms.TextBox txt_TienThua;
        private System.Windows.Forms.Label lb_TienThua;
        private System.Windows.Forms.TextBox txt_TienKhach;
        private System.Windows.Forms.Label lb_TK;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label lb_TT;
        private System.Windows.Forms.ComboBox cbx_PTKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.TextBox txt_ChuThich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.DataGridView dtgv_TKSanPham;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}