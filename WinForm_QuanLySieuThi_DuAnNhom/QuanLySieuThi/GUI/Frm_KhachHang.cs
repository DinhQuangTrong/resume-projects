using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLySieuThi
{
    public partial class Frm_KhachHang : Form
    {
        private string chuoi = "Select * from KhachHang";
        public Frm_KhachHang()
        {
            InitializeComponent();
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_Khachhang);
        }
        public void TenBang()
        {
            dtgv_Khachhang.Columns[0].HeaderText = "Mã khách hàng";
            dtgv_Khachhang.Columns[1].HeaderText = "Tên khách hàng";
            dtgv_Khachhang.Columns[2].HeaderText = "Ngày sinh";
            dtgv_Khachhang.Columns[3].HeaderText = "email";
            dtgv_Khachhang.Columns[4].HeaderText = "Điện thoại";
            dtgv_Khachhang.Columns[5].HeaderText = "Địa chỉ";

        }
        public void Clear()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            txt_Email.Text = "";
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            KetNoiSQL.LamMoi(chuoi, dtgv_Khachhang);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            string maKH = txt_MaKH.Text.Trim();


            if (string.IsNullOrEmpty(maKH))
            {
                return;
            }
            foreach (DataGridViewRow row in dtgv_Khachhang.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maKH)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_MaKH.Text = "";
                    return;
                }
            }


            if (txt_MaKH.Text == "" || txt_TenKH.Text == "" || dtp_NgaySinh.Text == "" || txt_Email.Text == "" || txt_DienThoai.Text == "" || txt_DiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into KhachHang values('" + txt_MaKH.Text + "','" + txt_TenKH.Text + "','" + dtp_NgaySinh.Value + "','" + txt_Email.Text + "',N'" + txt_DienThoai.Text + "', '" + txt_DiaChi.Text + "')";
                KetNoiSQL.Them(sql1,dtgv_Khachhang);

                KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_Khachhang);
                TenBang();
                Clear();


            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update KhachHang set maKH = '" + txt_MaKH.Text + "',tenKH = '" + txt_TenKH.Text + "',ngaySinh = '" + dtp_NgaySinh.Value + "',diaChi = '" + txt_Email.Text + "',dienThoai = '" + txt_DienThoai.Text + "',email = '" + txt_DiaChi.Text + "' where maKH = '" + txt_MaKH.Text + "'";

            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_Khachhang);
            TenBang();
            Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from KhachHang where maKH = '" + txt_MaKH.Text + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_Khachhang);
            TenBang();
            Clear();
        }

        private void dtgv_Khachhang_Click(object sender, EventArgs e)
        {
            int chiMuc = dtgv_Khachhang.CurrentRow.Index;

            txt_MaKH.Text = dtgv_Khachhang.Rows[chiMuc].Cells[0].Value.ToString();
            txt_TenKH.Text = dtgv_Khachhang.Rows[chiMuc].Cells[1].Value.ToString();
            dtp_NgaySinh.Text = dtgv_Khachhang.Rows[chiMuc].Cells[2].Value.ToString();
            txt_Email.Text = dtgv_Khachhang.Rows[chiMuc].Cells[3].Value.ToString();
            txt_DienThoai.Text = dtgv_Khachhang.Rows[chiMuc].Cells[4].Value.ToString();
            txt_DiaChi.Text = dtgv_Khachhang.Rows[chiMuc].Cells[5].Value.ToString();
            TenBang();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1_MaKhachHang.Text))
            {
                String sqlTimKiem = "Select * from KhachHang where maKH LIKE '%" + txt1_MaKhachHang.Text + "%' ";
                KetNoiSQL.TimKiem(sqlTimKiem, dtgv_Khachhang);
                TenBang();
            }
            else
            {
                KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_Khachhang);
            }
        }

        private void dtgv_Khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
