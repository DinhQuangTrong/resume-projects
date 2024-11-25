namespace QuanLySieuThi
{
    partial class Frm_ChucVu
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
            this.groupBox_ThuongHieu = new System.Windows.Forms.GroupBox();
            this.txt_TenChucVu = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.lb_Mota = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_tenCV = new System.Windows.Forms.Label();
            this.txt_MaChucVu = new System.Windows.Forms.TextBox();
            this.lb_MaCV = new System.Windows.Forms.Label();
            this.groupBox_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt1_MaChucVu = new System.Windows.Forms.TextBox();
            this.lb_TTH = new System.Windows.Forms.Label();
            this.groupBox_DanhSachCV = new System.Windows.Forms.GroupBox();
            this.dtgv_ChucVu = new System.Windows.Forms.DataGridView();
            this.groupBox_ThuongHieu.SuspendLayout();
            this.groupBox_TimKiem.SuspendLayout();
            this.groupBox_DanhSachCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_ThuongHieu
            // 
            this.groupBox_ThuongHieu.Controls.Add(this.txt_TenChucVu);
            this.groupBox_ThuongHieu.Controls.Add(this.txt_MoTa);
            this.groupBox_ThuongHieu.Controls.Add(this.lb_Mota);
            this.groupBox_ThuongHieu.Controls.Add(this.btn_LamMoi);
            this.groupBox_ThuongHieu.Controls.Add(this.btn_Xoa);
            this.groupBox_ThuongHieu.Controls.Add(this.btn_Sua);
            this.groupBox_ThuongHieu.Controls.Add(this.btn_Them);
            this.groupBox_ThuongHieu.Controls.Add(this.lb_tenCV);
            this.groupBox_ThuongHieu.Controls.Add(this.txt_MaChucVu);
            this.groupBox_ThuongHieu.Controls.Add(this.lb_MaCV);
            this.groupBox_ThuongHieu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ThuongHieu.Location = new System.Drawing.Point(13, 12);
            this.groupBox_ThuongHieu.Name = "groupBox_ThuongHieu";
            this.groupBox_ThuongHieu.Size = new System.Drawing.Size(1305, 256);
            this.groupBox_ThuongHieu.TabIndex = 4;
            this.groupBox_ThuongHieu.TabStop = false;
            this.groupBox_ThuongHieu.Text = "Thông tin chức vụ";
            // 
            // txt_TenChucVu
            // 
            this.txt_TenChucVu.Location = new System.Drawing.Point(670, 39);
            this.txt_TenChucVu.Name = "txt_TenChucVu";
            this.txt_TenChucVu.Size = new System.Drawing.Size(360, 27);
            this.txt_TenChucVu.TabIndex = 48;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(153, 98);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(877, 125);
            this.txt_MoTa.TabIndex = 26;
            // 
            // lb_Mota
            // 
            this.lb_Mota.AutoSize = true;
            this.lb_Mota.Location = new System.Drawing.Point(31, 101);
            this.lb_Mota.Name = "lb_Mota";
            this.lb_Mota.Size = new System.Drawing.Size(54, 19);
            this.lb_Mota.TabIndex = 25;
            this.lb_Mota.Text = "Mô Tả";
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
            this.btn_Xoa.Location = new System.Drawing.Point(1134, 204);
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
            // lb_tenCV
            // 
            this.lb_tenCV.AutoSize = true;
            this.lb_tenCV.Location = new System.Drawing.Point(543, 43);
            this.lb_tenCV.Name = "lb_tenCV";
            this.lb_tenCV.Size = new System.Drawing.Size(100, 19);
            this.lb_tenCV.TabIndex = 2;
            this.lb_tenCV.Text = "Tên chức vụ";
            // 
            // txt_MaChucVu
            // 
            this.txt_MaChucVu.Location = new System.Drawing.Point(153, 39);
            this.txt_MaChucVu.Name = "txt_MaChucVu";
            this.txt_MaChucVu.Size = new System.Drawing.Size(337, 27);
            this.txt_MaChucVu.TabIndex = 1;
            // 
            // lb_MaCV
            // 
            this.lb_MaCV.AutoSize = true;
            this.lb_MaCV.Location = new System.Drawing.Point(31, 42);
            this.lb_MaCV.Name = "lb_MaCV";
            this.lb_MaCV.Size = new System.Drawing.Size(95, 19);
            this.lb_MaCV.TabIndex = 0;
            this.lb_MaCV.Text = "Mã chức vụ";
            // 
            // groupBox_TimKiem
            // 
            this.groupBox_TimKiem.Controls.Add(this.btn_TimKiem);
            this.groupBox_TimKiem.Controls.Add(this.txt1_MaChucVu);
            this.groupBox_TimKiem.Controls.Add(this.lb_TTH);
            this.groupBox_TimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_TimKiem.Location = new System.Drawing.Point(13, 296);
            this.groupBox_TimKiem.Name = "groupBox_TimKiem";
            this.groupBox_TimKiem.Size = new System.Drawing.Size(1305, 97);
            this.groupBox_TimKiem.TabIndex = 24;
            this.groupBox_TimKiem.TabStop = false;
            this.groupBox_TimKiem.Text = "Tìm kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Image = global::QuanLySieuThi.Properties.Resources.icons8_search_16;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(1134, 34);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_TimKiem.Size = new System.Drawing.Size(121, 42);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt1_MaChucVu
            // 
            this.txt1_MaChucVu.Location = new System.Drawing.Point(810, 43);
            this.txt1_MaChucVu.Name = "txt1_MaChucVu";
            this.txt1_MaChucVu.Size = new System.Drawing.Size(292, 27);
            this.txt1_MaChucVu.TabIndex = 17;
            // 
            // lb_TTH
            // 
            this.lb_TTH.AutoSize = true;
            this.lb_TTH.Location = new System.Drawing.Point(675, 46);
            this.lb_TTH.Name = "lb_TTH";
            this.lb_TTH.Size = new System.Drawing.Size(95, 19);
            this.lb_TTH.TabIndex = 17;
            this.lb_TTH.Text = "Mã chức vụ";
            // 
            // groupBox_DanhSachCV
            // 
            this.groupBox_DanhSachCV.Controls.Add(this.dtgv_ChucVu);
            this.groupBox_DanhSachCV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhSachCV.Location = new System.Drawing.Point(13, 412);
            this.groupBox_DanhSachCV.Name = "groupBox_DanhSachCV";
            this.groupBox_DanhSachCV.Size = new System.Drawing.Size(1305, 295);
            this.groupBox_DanhSachCV.TabIndex = 25;
            this.groupBox_DanhSachCV.TabStop = false;
            this.groupBox_DanhSachCV.Text = "Danh sách chức vụ";
            // 
            // dtgv_ChucVu
            // 
            this.dtgv_ChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChucVu.Location = new System.Drawing.Point(25, 26);
            this.dtgv_ChucVu.Name = "dtgv_ChucVu";
            this.dtgv_ChucVu.RowHeadersWidth = 51;
            this.dtgv_ChucVu.RowTemplate.Height = 24;
            this.dtgv_ChucVu.Size = new System.Drawing.Size(1264, 263);
            this.dtgv_ChucVu.TabIndex = 0;
            this.dtgv_ChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChucVu_CellContentClick);
            this.dtgv_ChucVu.Click += new System.EventHandler(this.dtgv_ChucVu_Click);
            // 
            // Frm_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 594);
            this.Controls.Add(this.groupBox_DanhSachCV);
            this.Controls.Add(this.groupBox_TimKiem);
            this.Controls.Add(this.groupBox_ThuongHieu);
            this.Name = "Frm_ChucVu";
            this.Text = "ChucVu";
            this.groupBox_ThuongHieu.ResumeLayout(false);
            this.groupBox_ThuongHieu.PerformLayout();
            this.groupBox_TimKiem.ResumeLayout(false);
            this.groupBox_TimKiem.PerformLayout();
            this.groupBox_DanhSachCV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ThuongHieu;
        private System.Windows.Forms.TextBox txt_TenChucVu;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.Label lb_Mota;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lb_tenCV;
        private System.Windows.Forms.TextBox txt_MaChucVu;
        private System.Windows.Forms.Label lb_MaCV;
        private System.Windows.Forms.GroupBox groupBox_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt1_MaChucVu;
        private System.Windows.Forms.Label lb_TTH;
        private System.Windows.Forms.GroupBox groupBox_DanhSachCV;
        private System.Windows.Forms.DataGridView dtgv_ChucVu;
    }
}