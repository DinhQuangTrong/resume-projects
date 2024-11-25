using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class Frm_SanPham : Form
    {
        public string chuoi = "Select * from SanPham ";
        private DuLieuCBX duLieu = new DuLieuCBX();
        public Frm_SanPham()
        {
            InitializeComponent();

            duLieu.sqlMaLoaiSP = "Select maloaiSP from LoaiSanPham";
            duLieu.tenCotMaLoaiSP = "maloaiSP";
            duLieu.sqlMaThuongHieu = "Select maThuongHieu from ThuongHieu";
            duLieu.tenCotMaThuongHieu = "maThuongHieu";

            KetNoiSQL.XuLyCBX(duLieu.sqlMaLoaiSP, cbb_LoaiSP, duLieu.tenCotMaLoaiSP);
            KetNoiSQL.XuLyCBX(duLieu.sqlMaThuongHieu, cbb_ThuongHieu, duLieu.tenCotMaThuongHieu);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_SanPham);
            


            TenBang();
        }

        private void TenBang()
        {
            dtgv_SanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dtgv_SanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dtgv_SanPham.Columns[2].HeaderText = "Mã loại sản phẩm";
            dtgv_SanPham.Columns[3].HeaderText = "Số lượng tồn";
            dtgv_SanPham.Columns[4].HeaderText = "Màu sắc";
            dtgv_SanPham.Columns[5].HeaderText = "Ngày sản xuất";
            dtgv_SanPham.Columns[6].HeaderText = "Ngày hết hạn";
            dtgv_SanPham.Columns[7].HeaderText = "Mã thương hiệu";
            dtgv_SanPham.Columns[8].HeaderText = "Đơn giá";
            dtgv_SanPham.Columns[9].HeaderText = "kích thước";
            dtgv_SanPham.Columns[10].HeaderText = "Mô tả";


        }
        public void Clear()
        {
            txt_MaSP.Text = "";
            txt_TenSP.Text = "";
            cbb_LoaiSP.Text = "";
            txt_SoLuongTon.Text = "";
            cbb_ThuongHieu.Text = "";
            txt_MauSac.Text = "";
            txt_DonGia.Text = "";
            txt_KichThuoc.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MS_TextChanged(object sender, EventArgs e)
        {

        }

        private void SanPham_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maSP = txt_MaSP.Text.Trim();


            if (string.IsNullOrEmpty(maSP))
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dtgv_SanPham.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maSP)
                    {
                        MessageBox.Show("Mã Sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MaSP.Text = "";
                        return;
                    }
                }

                if (txt_MaSP.Text == "" || txt_TenSP.Text == "" || txt_SoLuongTon.Text == "" || txt_DonGia.Text == "" || txt_KichThuoc.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int soLuongTon;
                    if (!int.TryParse(txt_SoLuongTon.Text, out soLuongTon))
                    {
                        MessageBox.Show("Số lượng tồn phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    int donGia;
                    if (!int.TryParse(txt_DonGia.Text, out donGia))
                    {
                        MessageBox.Show("Đơn giá phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql1 = "INSERT INTO SanPham VALUES(N'" + txt_MaSP.Text + "', N'" + txt_TenSP.Text + "', N'" + cbb_LoaiSP.Text
                        + "', '" + txt_SoLuongTon.Text + "', '" + txt_MauSac.Text + "', '" + dtp_NgaySX.Value + "', '" + dtp_NgayHH.Value + "', N'" + cbb_ThuongHieu.Text
                        + "', '" + txt_DonGia.Text + "', N'" + txt_KichThuoc.Text + "', N'" + txt_MoTa.Text + "')";
                    KetNoiSQL.Them(sql1, dtgv_SanPham);

                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_SanPham);
                    TenBang();
                    Clear();

                }
            }
            
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            KetNoiSQL.LamMoi(chuoi, dtgv_SanPham);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            string sql = "Update SanPham set maSP = '" + txt_MaSP.Text + "',tenSP = '" + txt_TenSP.Text +
                "',maLoaiSP = '" + cbb_LoaiSP.Text + "',soLuongTon = '" + txt_SoLuongTon.Text + "',mauSac = '" + txt_MauSac.Text + "',ngaySX = '" + dtp_NgaySX.Value +
                "',ngayHH = '" + dtp_NgayHH.Value + "',maThuongHieu = '" + cbb_ThuongHieu.Text + "',donGia = '" + txt_DonGia.Text +
                "',kichThuoc = '" + txt_KichThuoc.Text + "',moTa = '" + txt_MoTa.Text + "' where maSP = '" + txt_MaSP.Text + "'";

            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_SanPham);
            TenBang();
            Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from SanPham where maSP = '" + txt_MaSP.Text + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_SanPham);
            TenBang();
            Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1_MaSanPham.Text))
            {
                String sqlTimKiem = "Select * from SanPham where maSP ='" + txt1_MaSanPham.Text + "' OR tenSP LIKE '%" + txt1_MaSanPham.Text + "%'  ";
                KetNoiSQL.TimKiem(sqlTimKiem, dtgv_SanPham);
                TenBang();
            }
            else
            {
                KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_SanPham);
            }
        }

        private void dtgv_SanPham_Click(object sender, EventArgs e)
        {
            int chiMuc = dtgv_SanPham.CurrentRow.Index;

            txt_MaSP.Text = dtgv_SanPham.Rows[chiMuc].Cells[0].Value.ToString();
            txt_TenSP.Text = dtgv_SanPham.Rows[chiMuc].Cells[1].Value.ToString();
            cbb_LoaiSP.Text = dtgv_SanPham.Rows[chiMuc].Cells[2].Value.ToString();
            txt_SoLuongTon.Text = dtgv_SanPham.Rows[chiMuc].Cells[3].Value.ToString();
            txt_MauSac.Text = dtgv_SanPham.Rows[chiMuc].Cells[4].Value.ToString();
            dtp_NgaySX.Text = dtgv_SanPham.Rows[chiMuc].Cells[5].Value.ToString();
            dtp_NgayHH.Text = dtgv_SanPham.Rows[chiMuc].Cells[6].Value.ToString();
            cbb_ThuongHieu.Text = dtgv_SanPham.Rows[chiMuc].Cells[7].Value.ToString();
            txt_DonGia.Text = dtgv_SanPham.Rows[chiMuc].Cells[8].Value.ToString();
            txt_KichThuoc.Text = dtgv_SanPham.Rows[chiMuc].Cells[9].Value.ToString();
            txt_MoTa.Text = dtgv_SanPham.Rows[chiMuc].Cells[10].Value.ToString();

            TenBang();
        }

        private void dtgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
