namespace QuanLySieuThi
{
    partial class Frm_NhaCungCap
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.lb_SĐT = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_TenNhaCC = new System.Windows.Forms.TextBox();
            this.lb_TNCC = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_DC = new System.Windows.Forms.Label();
            this.txt_MaNhaCC = new System.Windows.Forms.TextBox();
            this.lb_MNCC = new System.Windows.Forms.Label();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt1_TimKiem = new System.Windows.Forms.TextBox();
            this.lb_MaNhaCC = new System.Windows.Forms.Label();
            this.groupBox_DanhSachNCC = new System.Windows.Forms.GroupBox();
            this.dtgv_NhaCungCap = new System.Windows.Forms.DataGridView();
            this.groupBox_NhanVien.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.groupBox_DanhSachNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_NhanVien
            // 
            this.groupBox_NhanVien.Controls.Add(this.txt_Email);
            this.groupBox_NhanVien.Controls.Add(this.lb_Email);
            this.groupBox_NhanVien.Controls.Add(this.txt_DienThoai);
            this.groupBox_NhanVien.Controls.Add(this.lb_SĐT);
            this.groupBox_NhanVien.Controls.Add(this.btn_Xoa);
            this.groupBox_NhanVien.Controls.Add(this.btn_Sua);
            this.groupBox_NhanVien.Controls.Add(this.btn_Them);
            this.groupBox_NhanVien.Controls.Add(this.btn_LamMoi);
            this.groupBox_NhanVien.Controls.Add(this.txt_TenNhaCC);
            this.groupBox_NhanVien.Controls.Add(this.lb_TNCC);
            this.groupBox_NhanVien.Controls.Add(this.txt_DiaChi);
            this.groupBox_NhanVien.Controls.Add(this.lb_DC);
            this.groupBox_NhanVien.Controls.Add(this.txt_MaNhaCC);
            this.groupBox_NhanVien.Controls.Add(this.lb_MNCC);
            this.groupBox_NhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NhanVien.Location = new System.Drawing.Point(24, 12);
            this.groupBox_NhanVien.Name = "groupBox_NhanVien";
            this.groupBox_NhanVien.Size = new System.Drawing.Size(1299, 213);
            this.groupBox_NhanVien.TabIndex = 1;
            this.groupBox_NhanVien.TabStop = false;
            this.groupBox_NhanVien.Text = "Thông tin nhà cung cấp";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(127, 161);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(427, 27);
            this.txt_Email.TabIndex = 20;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(29, 164);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(49, 19);
            this.lb_Email.TabIndex = 19;
            this.lb_Email.Text = "Email";
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(734, 100);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(475, 27);
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
            // txt_TenNhaCC
            // 
            this.txt_TenNhaCC.Location = new System.Drawing.Point(734, 43);
            this.txt_TenNhaCC.Name = "txt_TenNhaCC";
            this.txt_TenNhaCC.Size = new System.Drawing.Size(475, 27);
            this.txt_TenNhaCC.TabIndex = 7;
            // 
            // lb_TNCC
            // 
            this.lb_TNCC.AutoSize = true;
            this.lb_TNCC.Location = new System.Drawing.Point(637, 51);
            this.lb_TNCC.Name = "lb_TNCC";
            this.lb_TNCC.Size = new System.Drawing.Size(76, 19);
            this.lb_TNCC.TabIndex = 6;
            this.lb_TNCC.Text = "Tên NCC";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(127, 103);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(427, 27);
            this.txt_DiaChi.TabIndex = 5;
            // 
            // lb_DC
            // 
            this.lb_DC.AutoSize = true;
            this.lb_DC.Location = new System.Drawing.Point(29, 108);
            this.lb_DC.Name = "lb_DC";
            this.lb_DC.Size = new System.Drawing.Size(61, 19);
            this.lb_DC.TabIndex = 4;
            this.lb_DC.Text = "Địa chỉ";
            // 
            // txt_MaNhaCC
            // 
            this.txt_MaNhaCC.Location = new System.Drawing.Point(127, 45);
            this.txt_MaNhaCC.Name = "txt_MaNhaCC";
            this.txt_MaNhaCC.Size = new System.Drawing.Size(427, 27);
            this.txt_MaNhaCC.TabIndex = 1;
            // 
            // lb_MNCC
            // 
            this.lb_MNCC.AutoSize = true;
            this.lb_MNCC.Location = new System.Drawing.Point(29, 48);
            this.lb_MNCC.Name = "lb_MNCC";
            this.lb_MNCC.Size = new System.Drawing.Size(71, 19);
            this.lb_MNCC.TabIndex = 0;
            this.lb_MNCC.Text = "Mã NCC";
            // 
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.Controls.Add(this.btn_TimKiem);
            this.groupBox_TimKiem.Controls.Add(this.txt1_TimKiem);
            this.groupBox_TimKiem.Controls.Add(this.lb_MaNhaCC);
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimKiem.Location = new System.Drawing.Point(29, 253);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Size = new System.Drawing.Size(1294, 97);
            this.groupBox_TimKiem.TabIndex = 23;
            this.groupBox_TimKiem.TabStop = false;
            this.groupBox_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::QuanLySieuThi.Properties.Resources.icons8_search_16;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(1133, 34);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(121, 42);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt1_TimKiem
            // 
            this.txt1_TimKiem.Location = new System.Drawing.Point(810, 43);
            this.txt1_TimKiem.Name = "txt1_TimKiem";
            this.txt1_TimKiem.Size = new System.Drawing.Size(292, 27);
            this.txt1_TimKiem.TabIndex = 17;
            this.txt1_TimKiem.TextChanged += new System.EventHandler(this.txt1_TenNhaCungCap_TextChanged);
            // 
            // lb_MaNhaCC
            // 
            this.lb_MaNhaCC.AutoSize = true;
            this.lb_MaNhaCC.Location = new System.Drawing.Point(653, 46);
            this.lb_MaNhaCC.Name = "lb_MaNhaCC";
            this.lb_MaNhaCC.Size = new System.Drawing.Size(136, 19);
            this.lb_MaNhaCC.TabIndex = 17;
            this.lb_MaNhaCC.Text = "Mã nhà cung cấp";
            // 
            // groupBox_DanhSachNCC
            // 
            this.groupBox_DanhSachNCC.Controls.Add(this.dtgv_NhaCungCap);
            this.groupBox_DanhSachNCC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhSachNCC.Location = new System.Drawing.Point(29, 375);
            this.groupBox_DanhSachNCC.Name = "groupBox_DanhSachNCC";
            this.groupBox_DanhSachNCC.Size = new System.Drawing.Size(1294, 295);
            this.groupBox_DanhSachNCC.TabIndex = 24;
            this.groupBox_DanhSachNCC.TabStop = false;
            this.groupBox_DanhSachNCC.Text = "Danh sách Nhà Cung Cấp";
            // 
            // dtgv_NhaCungCap
            // 
            this.dtgv_NhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_NhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_NhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_NhaCungCap.Location = new System.Drawing.Point(25, 26);
            this.dtgv_NhaCungCap.Name = "dtgv_NhaCungCap";
            this.dtgv_NhaCungCap.RowHeadersWidth = 51;
            this.dtgv_NhaCungCap.RowTemplate.Height = 24;
            this.dtgv_NhaCungCap.Size = new System.Drawing.Size(1253, 263);
            this.dtgv_NhaCungCap.TabIndex = 0;
            this.dtgv_NhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_NhaCungCap_CellContentClick);
            this.dtgv_NhaCungCap.Click += new System.EventHandler(this.dtgv_NhaCungCap_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 545);
            this.Controls.Add(this.groupBox_DanhSachNCC);
            this.Controls.Add(this.groupBox_TimKiem);
            this.Controls.Add(this.groupBox_NhanVien);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.groupBox_NhanVien.ResumeLayout(false);
            this.groupBox_NhanVien.PerformLayout();
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_TimKiem.PerformLayout();
            this.groupBox_DanhSachNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NhanVien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.TextBox txt_TenNhaCC;
        private System.Windows.Forms.Label lb_TNCC;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_DC;
        private System.Windows.Forms.TextBox txt_MaNhaCC;
        private System.Windows.Forms.Label lb_MNCC;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.Label lb_SĐT;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt1_TimKiem;
        private System.Windows.Forms.Label lb_MaNhaCC;
        private System.Windows.Forms.GroupBox groupBox_DanhSachNCC;
        private System.Windows.Forms.DataGridView dtgv_NhaCungCap;
    }
}