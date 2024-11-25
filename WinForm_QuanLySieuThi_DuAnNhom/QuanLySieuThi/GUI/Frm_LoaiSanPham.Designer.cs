namespace QuanLySieuThi
{
    partial class Frm_LoaiSanPham
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
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.lb_Mota = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenLoai = new System.Windows.Forms.TextBox();
            this.lb_TenLoai = new System.Windows.Forms.Label();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.lb_MaLoai = new System.Windows.Forms.Label();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt1_TenLoaiSP = new System.Windows.Forms.TextBox();
            this.lb_TenSanPham = new System.Windows.Forms.Label();
            this.groupBox_DanhSachLoaiSP = new System.Windows.Forms.GroupBox();
            this.dtgv_LoaiSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.groupBox_DanhSachLoaiSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LoaiSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Mota);
            this.groupBox1.Controls.Add(this.lb_Mota);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_TenLoai);
            this.groupBox1.Controls.Add(this.lb_TenLoai);
            this.groupBox1.Controls.Add(this.txt_MaLoai);
            this.groupBox1.Controls.Add(this.lb_MaLoai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(115, 98);
            this.txt_Mota.Multiline = true;
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(916, 114);
            this.txt_Mota.TabIndex = 26;
            // 
            // lb_Mota
            // 
            this.lb_Mota.AutoSize = true;
            this.lb_Mota.Location = new System.Drawing.Point(31, 101);
            this.lb_Mota.Name = "lb_Mota";
            this.lb_Mota.Size = new System.Drawing.Size(49, 19);
            this.lb_Mota.TabIndex = 25;
            this.lb_Mota.Text = "Mô tả";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::QuanLySieuThi.Properties.Resources.icons8_load_161;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(1134, 31);
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
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.icons8_delete_16;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(1134, 194);
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
            this.btn_Sua.Image = global::QuanLySieuThi.Properties.Resources.icons8_edit_16;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(1134, 146);
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
            this.btn_Them.Location = new System.Drawing.Point(1134, 89);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenLoai
            // 
            this.txt_TenLoai.Location = new System.Drawing.Point(690, 39);
            this.txt_TenLoai.Name = "txt_TenLoai";
            this.txt_TenLoai.Size = new System.Drawing.Size(310, 27);
            this.txt_TenLoai.TabIndex = 3;
            // 
            // lb_TenLoai
            // 
            this.lb_TenLoai.AutoSize = true;
            this.lb_TenLoai.Location = new System.Drawing.Point(593, 42);
            this.lb_TenLoai.Name = "lb_TenLoai";
            this.lb_TenLoai.Size = new System.Drawing.Size(66, 19);
            this.lb_TenLoai.TabIndex = 2;
            this.lb_TenLoai.Text = "Tên loại";
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Location = new System.Drawing.Point(115, 39);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(306, 27);
            this.txt_MaLoai.TabIndex = 1;
            // 
            // lb_MaLoai
            // 
            this.lb_MaLoai.AutoSize = true;
            this.lb_MaLoai.Location = new System.Drawing.Point(31, 42);
            this.lb_MaLoai.Name = "lb_MaLoai";
            this.lb_MaLoai.Size = new System.Drawing.Size(61, 19);
            this.lb_MaLoai.TabIndex = 0;
            this.lb_MaLoai.Text = "Mã loại";
            // 
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.Controls.Add(this.btn_TimKiem);
            this.groupBox_TimKiem.Controls.Add(this.txt1_TenLoaiSP);
            this.groupBox_TimKiem.Controls.Add(this.lb_TenSanPham);
            this.groupBox_TimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimKiem.Location = new System.Drawing.Point(0, 0);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Size = new System.Drawing.Size(1280, 156);
            this.groupBox_TimKiem.TabIndex = 23;
            this.groupBox_TimKiem.TabStop = false;
            this.groupBox_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::QuanLySieuThi.Properties.Resources.icons8_search_16;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(1057, 53);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(121, 42);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt1_TenLoaiSP
            // 
            this.txt1_TenLoaiSP.Location = new System.Drawing.Point(746, 62);
            this.txt1_TenLoaiSP.Multiline = true;
            this.txt1_TenLoaiSP.Name = "txt1_TenLoaiSP";
            this.txt1_TenLoaiSP.Size = new System.Drawing.Size(272, 34);
            this.txt1_TenLoaiSP.TabIndex = 17;
            // 
            // lb_TenSanPham
            // 
            this.lb_TenSanPham.AutoSize = true;
            this.lb_TenSanPham.Location = new System.Drawing.Point(611, 70);
            this.lb_TenSanPham.Name = "lb_TenSanPham";
            this.lb_TenSanPham.Size = new System.Drawing.Size(66, 19);
            this.lb_TenSanPham.TabIndex = 17;
            this.lb_TenSanPham.Text = "Tên loại";
            this.lb_TenSanPham.Click += new System.EventHandler(this.lb_TenSanPham_Click);
            // 
            // groupBox_DanhSachLoaiSP
            // 
            this.groupBox_DanhSachLoaiSP.Controls.Add(this.dtgv_LoaiSanPham);
            this.groupBox_DanhSachLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_DanhSachLoaiSP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhSachLoaiSP.Location = new System.Drawing.Point(0, 0);
            this.groupBox_DanhSachLoaiSP.Name = "groupBox_DanhSachLoaiSP";
            this.groupBox_DanhSachLoaiSP.Size = new System.Drawing.Size(1280, 151);
            this.groupBox_DanhSachLoaiSP.TabIndex = 24;
            this.groupBox_DanhSachLoaiSP.TabStop = false;
            this.groupBox_DanhSachLoaiSP.Text = "Danh sách loại Sản phẩm";
            // 
            // dtgv_LoaiSanPham
            // 
            this.dtgv_LoaiSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_LoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_LoaiSanPham.Location = new System.Drawing.Point(3, 27);
            this.dtgv_LoaiSanPham.Name = "dtgv_LoaiSanPham";
            this.dtgv_LoaiSanPham.RowHeadersWidth = 51;
            this.dtgv_LoaiSanPham.RowTemplate.Height = 24;
            this.dtgv_LoaiSanPham.Size = new System.Drawing.Size(1268, 124);
            this.dtgv_LoaiSanPham.TabIndex = 0;
            this.dtgv_LoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_LoaiSanPham_CellClick);
            this.dtgv_LoaiSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_LoaiSanPham_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 238);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_TimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 156);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox_DanhSachLoaiSP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 394);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 151);
            this.panel3.TabIndex = 27;
            // 
            // Frm_LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_LoaiSanPham";
            this.Text = "LoaiSanPham";
            this.Load += new System.EventHandler(this.LoaiSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_TimKiem.PerformLayout();
            this.groupBox_DanhSachLoaiSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LoaiSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenLoai;
        private System.Windows.Forms.Label lb_TenLoai;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.Label lb_MaLoai;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.Label lb_Mota;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt1_TenLoaiSP;
        private System.Windows.Forms.Label lb_TenSanPham;
        private System.Windows.Forms.GroupBox groupBox_DanhSachLoaiSP;
        private System.Windows.Forms.DataGridView dtgv_LoaiSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}