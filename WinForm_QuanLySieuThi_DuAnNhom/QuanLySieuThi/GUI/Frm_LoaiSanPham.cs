using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLySieuThi
{
    
    public partial class Frm_LoaiSanPham : Form
    {

        public string chuoi = "Select * from LoaiSanPham";
        public Frm_LoaiSanPham()
        {
            InitializeComponent();

            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_LoaiSanPham);
          

            if (KetNoiSQL.dt != null && KetNoiSQL.dt.Rows.Count > 0)
            {
                TenBang();
            }
            else
            {
                MessageBox.Show("Loại sản phẩm không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void TenBang()
        {
            dtgv_LoaiSanPham.Columns[0].HeaderText = "Mã loại sản phẩm";
            dtgv_LoaiSanPham.Columns[0].Width = 250;
            dtgv_LoaiSanPham.Columns[1].HeaderText = "Tên loại sản phẩm";
            dtgv_LoaiSanPham.Columns[1].Width = 250;
            dtgv_LoaiSanPham.Columns[2].HeaderText = "Mô tả";
            dtgv_LoaiSanPham.Columns[2].Width = 500;


        }






        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maLoaiSP = txt_MaLoai.Text.Trim();


            if (string.IsNullOrEmpty(maLoaiSP))
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dtgv_LoaiSanPham.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maLoaiSP)
                    {
                        MessageBox.Show("Mã loại Sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MaLoai.Text = "";
                        return;
                    }
                }


                if (txt_MaLoai.Text == "" || txt_TenLoai.Text == "" || txt_Mota.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql1 = "Insert into LoaiSanPham values(N'" + txt_MaLoai.Text.Trim() + "',N'" + txt_TenLoai.Text.Trim() + "',N'" + txt_Mota.Text.Trim() + "')";
                    KetNoiSQL.Them(sql1, dtgv_LoaiSanPham);
                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_LoaiSanPham);
                    TenBang();
                }
            }

            Clear();
        }

        public void Clear()
        {
            txt_MaLoai.Text = "";
            txt_TenLoai.Text = "";
            txt_Mota.Text = "";
           
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            KetNoiSQL.LamMoi("Select * from LoaiSanPham", dtgv_LoaiSanPham);
            Clear();
        }

        private void lb_TenSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

                string sql = "delete from LoaiSanPham where maLoaiSP = N'"+txt_MaLoai.Text.Trim()+"'";
                KetNoiSQL.Xoa(sql);
                KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_LoaiSanPham);
                TenBang();
                Clear();
           
        }

     
        private void dtgv_LoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiMuc = dtgv_LoaiSanPham.CurrentRow.Index;

            txt_MaLoai.Text = dtgv_LoaiSanPham.Rows[chiMuc].Cells[0].Value.ToString();
            txt_TenLoai.Text = dtgv_LoaiSanPham.Rows[chiMuc].Cells[1].Value.ToString();
            txt_Mota.Text = dtgv_LoaiSanPham.Rows[chiMuc].Cells[2].Value.ToString();
            TenBang();
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update LoaiSanPham set tenLoaiSP = N'" + txt_TenLoai.Text.Trim() + "',moTa = N'" + txt_Mota.Text.Trim() + "' where maLoaiSP = N'" + txt_MaLoai.Text.Trim() + "'";
            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_LoaiSanPham);
            TenBang();
            Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "Select * from LoaiSanPham where tenLoaiSP LIKE N'%" + txt1_TenLoaiSP.Text.Trim() + "%'";
            KetNoiSQL.TimKiem(sqlTimKiem, dtgv_LoaiSanPham);
            TenBang();
        }

        private void dtgv_LoaiSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
