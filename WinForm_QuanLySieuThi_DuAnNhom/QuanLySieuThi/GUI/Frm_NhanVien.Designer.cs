namespace QuanLySieuThi
{
    partial class Frm_NhanVien
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
            this.cbb_ChucVu = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.rdobtn_Nu = new System.Windows.Forms.RadioButton();
            this.rdobtn_Nam = new System.Windows.Forms.RadioButton();
            this.lb_GT = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lb_HT = new System.Windows.Forms.Label();
            this.lb_CV = new System.Windows.Forms.Label();
            this.lb_NS = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.lb_mnv = new System.Windows.Forms.Label();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt1_MaNhanVien = new System.Windows.Forms.TextBox();
            this.lb_TNV = new System.Windows.Forms.Label();
            this.groupBox_DanhSachNV = new System.Windows.Forms.GroupBox();
            this.dtgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox_NhanVien.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.groupBox_DanhSachNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_NhanVien
            // 
            this.groupBox_NhanVien.Controls.Add(this.dtp_NgaySinh);
            this.groupBox_NhanVien.Controls.Add(this.cbb_ChucVu);
            this.groupBox_NhanVien.Controls.Add(this.btn_Xoa);
            this.groupBox_NhanVien.Controls.Add(this.btn_Sua);
            this.groupBox_NhanVien.Controls.Add(this.btn_Them);
            this.groupBox_NhanVien.Controls.Add(this.btn_LamMoi);
            this.groupBox_NhanVien.Controls.Add(this.txt_SDT);
            this.groupBox_NhanVien.Controls.Add(this.lb_SDT);
            this.groupBox_NhanVien.Controls.Add(this.rdobtn_Nu);
            this.groupBox_NhanVien.Controls.Add(this.rdobtn_Nam);
            this.groupBox_NhanVien.Controls.Add(this.lb_GT);
            this.groupBox_NhanVien.Controls.Add(this.txt_HoTen);
            this.groupBox_NhanVien.Controls.Add(this.lb_HT);
            this.groupBox_NhanVien.Controls.Add(this.lb_CV);
            this.groupBox_NhanVien.Controls.Add(this.lb_NS);
            this.groupBox_NhanVien.Controls.Add(this.txt_MaNV);
            this.groupBox_NhanVien.Controls.Add(this.lb_mnv);
            this.groupBox_NhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NhanVien.Location = new System.Drawing.Point(33, 12);
            this.groupBox_NhanVien.Name = "groupBox_NhanVien";
            this.groupBox_NhanVien.Size = new System.Drawing.Size(1265, 213);
            this.groupBox_NhanVien.TabIndex = 0;
            this.groupBox_NhanVien.TabStop = false;
            this.groupBox_NhanVien.Text = "Thông tin nhân viên";
            this.groupBox_NhanVien.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(127, 103);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(427, 30);
            this.dtp_NgaySinh.TabIndex = 43;
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.Location = new System.Drawing.Point(127, 161);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(427, 27);
            this.cbb_ChucVu.TabIndex = 17;
            this.cbb_ChucVu.SelectedIndexChanged += new System.EventHandler(this.cbb_ChucVu_SelectedIndexChanged);
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
            this.btn_LamMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(1030, 95);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(200, 27);
            this.txt_SDT.TabIndex = 12;
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(918, 101);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(82, 19);
            this.lb_SDT.TabIndex = 11;
            this.lb_SDT.Text = "S.Đ.Thoại";
            this.lb_SDT.Click += new System.EventHandler(this.lb_SDT_Click);
            // 
            // rdobtn_Nu
            // 
            this.rdobtn_Nu.AutoSize = true;
            this.rdobtn_Nu.Location = new System.Drawing.Point(824, 99);
            this.rdobtn_Nu.Name = "rdobtn_Nu";
            this.rdobtn_Nu.Size = new System.Drawing.Size(52, 23);
            this.rdobtn_Nu.TabIndex = 10;
            this.rdobtn_Nu.TabStop = true;
            this.rdobtn_Nu.Text = "Nữ";
            this.rdobtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rdobtn_Nam
            // 
            this.rdobtn_Nam.AutoSize = true;
            this.rdobtn_Nam.Location = new System.Drawing.Point(745, 99);
            this.rdobtn_Nam.Name = "rdobtn_Nam";
            this.rdobtn_Nam.Size = new System.Drawing.Size(63, 23);
            this.rdobtn_Nam.TabIndex = 9;
            this.rdobtn_Nam.TabStop = true;
            this.rdobtn_Nam.Text = "Nam";
            this.rdobtn_Nam.UseVisualStyleBackColor = true;
            this.rdobtn_Nam.CheckedChanged += new System.EventHandler(this.rdobtn_Nam_CheckedChanged);
            // 
            // lb_GT
            // 
            this.lb_GT.AutoSize = true;
            this.lb_GT.Location = new System.Drawing.Point(637, 103);
            this.lb_GT.Name = "lb_GT";
            this.lb_GT.Size = new System.Drawing.Size(72, 19);
            this.lb_GT.TabIndex = 8;
            this.lb_GT.Text = "Giới tính";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(734, 43);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(496, 27);
            this.txt_HoTen.TabIndex = 7;
            // 
            // lb_HT
            // 
            this.lb_HT.AutoSize = true;
            this.lb_HT.Location = new System.Drawing.Point(637, 51);
            this.lb_HT.Name = "lb_HT";
            this.lb_HT.Size = new System.Drawing.Size(56, 19);
            this.lb_HT.TabIndex = 6;
            this.lb_HT.Text = "Họ tên";
            this.lb_HT.Click += new System.EventHandler(this.lb_HT_Click);
            // 
            // lb_CV
            // 
            this.lb_CV.AutoSize = true;
            this.lb_CV.Location = new System.Drawing.Point(29, 164);
            this.lb_CV.Name = "lb_CV";
            this.lb_CV.Size = new System.Drawing.Size(71, 19);
            this.lb_CV.TabIndex = 4;
            this.lb_CV.Text = "Chức vụ";
            // 
            // lb_NS
            // 
            this.lb_NS.AutoSize = true;
            this.lb_NS.Location = new System.Drawing.Point(29, 103);
            this.lb_NS.Name = "lb_NS";
            this.lb_NS.Size = new System.Drawing.Size(82, 19);
            this.lb_NS.TabIndex = 3;
            this.lb_NS.Text = "Ngày sinh";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(127, 45);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(427, 27);
            this.txt_MaNV.TabIndex = 1;
            // 
            // lb_mnv
            // 
            this.lb_mnv.AutoSize = true;
            this.lb_mnv.Location = new System.Drawing.Point(29, 48);
            this.lb_mnv.Name = "lb_mnv";
            this.lb_mnv.Size = new System.Drawing.Size(58, 19);
            this.lb_mnv.TabIndex = 0;
            this.lb_mnv.Text = "Mã NV";
            // 
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.Controls.Add(this.btn_TimKiem);
            this.groupBox_TimKiem.Controls.Add(this.txt1_MaNhanVien);
            this.groupBox_TimKiem.Controls.Add(this.lb_TNV);
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimKiem.Location = new System.Drawing.Point(33, 246);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Size = new System.Drawing.Size(1265, 97);
            this.groupBox_TimKiem.TabIndex = 1;
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
            // txt1_MaNhanVien
            // 
            this.txt1_MaNhanVien.Location = new System.Drawing.Point(794, 40);
            this.txt1_MaNhanVien.Name = "txt1_MaNhanVien";
            this.txt1_MaNhanVien.Size = new System.Drawing.Size(292, 27);
            this.txt1_MaNhanVien.TabIndex = 17;
            // 
            // lb_TNV
            // 
            this.lb_TNV.AutoSize = true;
            this.lb_TNV.Location = new System.Drawing.Point(637, 43);
            this.lb_TNV.Name = "lb_TNV";
            this.lb_TNV.Size = new System.Drawing.Size(106, 19);
            this.lb_TNV.TabIndex = 17;
            this.lb_TNV.Text = "Mã nhân viên";
            this.lb_TNV.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_DanhSachNV
            // 
            this.groupBox_DanhSachNV.Controls.Add(this.dtgv_NhanVien);
            this.groupBox_DanhSachNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhSachNV.Location = new System.Drawing.Point(33, 364);
            this.groupBox_DanhSachNV.Name = "groupBox_DanhSachNV";
            this.groupBox_DanhSachNV.Size = new System.Drawing.Size(1265, 295);
            this.groupBox_DanhSachNV.TabIndex = 2;
            this.groupBox_DanhSachNV.TabStop = false;
            this.groupBox_DanhSachNV.Text = "Danh sách nhân viên";
            // 
            // dtgv_NhanVien
            // 
            this.dtgv_NhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_NhanVien.Location = new System.Drawing.Point(25, 26);
            this.dtgv_NhanVien.Name = "dtgv_NhanVien";
            this.dtgv_NhanVien.RowHeadersWidth = 51;
            this.dtgv_NhanVien.RowTemplate.Height = 24;
            this.dtgv_NhanVien.Size = new System.Drawing.Size(1224, 263);
            this.dtgv_NhanVien.TabIndex = 0;
            this.dtgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_NhanVien_CellContentClick);
            this.dtgv_NhanVien.Click += new System.EventHandler(this.dtgv_NhanVien_Click);
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 671);
            this.Controls.Add(this.groupBox_DanhSachNV);
            this.Controls.Add(this.groupBox_TimKiem);
            this.Controls.Add(this.groupBox_NhanVien);
            this.Name = "Frm_NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox_NhanVien.ResumeLayout(false);
            this.groupBox_NhanVien.PerformLayout();
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_TimKiem.PerformLayout();
            this.groupBox_DanhSachNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NhanVien;
        private System.Windows.Forms.Label lb_CV;
        private System.Windows.Forms.Label lb_NS;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label lb_mnv;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lb_HT;
        private System.Windows.Forms.Label lb_GT;
        private System.Windows.Forms.RadioButton rdobtn_Nu;
        private System.Windows.Forms.RadioButton rdobtn_Nam;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox groupBox_DanhSachNV;
        private System.Windows.Forms.DataGridView dtgv_NhanVien;
        private System.Windows.Forms.ComboBox cbb_ChucVu;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt1_MaNhanVien;
        private System.Windows.Forms.Label lb_TNV;
    }
}