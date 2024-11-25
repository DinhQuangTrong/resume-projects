namespace QuanLySieuThi
{
    partial class Frm_BaoCao
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
            this.lb_Doanhthu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ChonNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_ChiTiet = new System.Windows.Forms.GroupBox();
            this.dtgv_Chitiet = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox_ChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Doanhthu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_ChonNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo ngày:";
            // 
            // lb_Doanhthu
            // 
            this.lb_Doanhthu.AutoSize = true;
            this.lb_Doanhthu.Location = new System.Drawing.Point(715, 43);
            this.lb_Doanhthu.Name = "lb_Doanhthu";
            this.lb_Doanhthu.Size = new System.Drawing.Size(18, 19);
            this.lb_Doanhthu.TabIndex = 3;
            this.lb_Doanhthu.Text = "0";
            this.lb_Doanhthu.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng doanh thu: ";
            // 
            // dtp_ChonNgay
            // 
            this.dtp_ChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ChonNgay.Location = new System.Drawing.Point(100, 43);
            this.dtp_ChonNgay.Name = "dtp_ChonNgay";
            this.dtp_ChonNgay.Size = new System.Drawing.Size(200, 27);
            this.dtp_ChonNgay.TabIndex = 1;
            this.dtp_ChonNgay.Value = new System.DateTime(2024, 4, 11, 16, 7, 24, 0);
            this.dtp_ChonNgay.ValueChanged += new System.EventHandler(this.dtp_ChonNgay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày";
            // 
            // groupBox_ChiTiet
            // 
            this.groupBox_ChiTiet.Controls.Add(this.dtgv_Chitiet);
            this.groupBox_ChiTiet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ChiTiet.Location = new System.Drawing.Point(13, 139);
            this.groupBox_ChiTiet.Name = "groupBox_ChiTiet";
            this.groupBox_ChiTiet.Size = new System.Drawing.Size(1311, 414);
            this.groupBox_ChiTiet.TabIndex = 1;
            this.groupBox_ChiTiet.TabStop = false;
            this.groupBox_ChiTiet.Text = "Chi tiết";
            // 
            // dtgv_Chitiet
            // 
            this.dtgv_Chitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Chitiet.Location = new System.Drawing.Point(7, 42);
            this.dtgv_Chitiet.Name = "dtgv_Chitiet";
            this.dtgv_Chitiet.RowHeadersWidth = 51;
            this.dtgv_Chitiet.RowTemplate.Height = 24;
            this.dtgv_Chitiet.Size = new System.Drawing.Size(1298, 366);
            this.dtgv_Chitiet.TabIndex = 0;
            this.dtgv_Chitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Chitiet_CellContentClick);
            // 
            // Frm_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.groupBox_ChiTiet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_BaoCao";
            this.Text = "BaoCao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_ChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Chitiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_ChonNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Doanhthu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_ChiTiet;
        private System.Windows.Forms.DataGridView dtgv_Chitiet;
    }
}