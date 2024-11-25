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
    public partial class Frm_ThuongHieu : Form
    {

        public string chuoi = "Select * from ThuongHieu ";
        public Frm_ThuongHieu()
        {
            InitializeComponent();

            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_ThuongHieu);

            if (KetNoiSQL.dt != null && KetNoiSQL.dt.Rows.Count > 0)
            {
                TenBang();
            }
            else
            {
                MessageBox.Show("Thương hiệu không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TenBang()
        {
            dtgv_ThuongHieu.Columns[0].HeaderText = "Mã thương hiệu";
            dtgv_ThuongHieu.Columns[0].Width = 250;
            dtgv_ThuongHieu.Columns[1].HeaderText = "Tên thương hiệu";
            dtgv_ThuongHieu.Columns[1].Width = 250;
            dtgv_ThuongHieu.Columns[2].HeaderText = "Quốc gia";
            dtgv_ThuongHieu.Columns[2].Width = 150;
            dtgv_ThuongHieu.Columns[3].HeaderText = "Mô tả";
            dtgv_ThuongHieu.Columns[3].Width = 150;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maThuongHieu = txt_MaThuongHieu.Text.Trim();


            if (string.IsNullOrEmpty(maThuongHieu))
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dtgv_ThuongHieu.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maThuongHieu)
                    {
                        MessageBox.Show("Mã thương hiệu đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MaThuongHieu.Text = "";
                        return;
                    }
                }

                if (txt_MaThuongHieu.Text == "" || txt_TenThuongHieu.Text == "" || txt_QuocGia.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql1 = "Insert into ThuongHieu values(N'" + txt_MaThuongHieu.Text + "',N'" + txt_TenThuongHieu.Text + "',N'" + txt_QuocGia.Text + "',N'" + txt_MoTa.Text + "')";
                    KetNoiSQL.Them(sql1, dtgv_ThuongHieu);

                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_ThuongHieu);
                    TenBang();
                    Clear();

                }
            }
        }

        private void Clear()
        {
            txt_MaThuongHieu.Text = "";
            txt_TenThuongHieu.Text = "";
            txt_QuocGia.Text = "";
            txt_MoTa.Text = "";
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            KetNoiSQL.LamMoi("Select * from ThuongHieu", dtgv_ThuongHieu);
            Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ThuongHieu where maThuongHieu = N'" + txt_MaThuongHieu.Text.Trim() + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_ThuongHieu);
            TenBang();
            Clear();
        }

        private void dtgv_ThuongHieu_Click(object sender, EventArgs e)
        {
            int chiMuc = dtgv_ThuongHieu.CurrentRow.Index;

            txt_MaThuongHieu.Text = dtgv_ThuongHieu.Rows[chiMuc].Cells[0].Value.ToString();
            txt_TenThuongHieu.Text = dtgv_ThuongHieu.Rows[chiMuc].Cells[1].Value.ToString();
            txt_QuocGia.Text = dtgv_ThuongHieu.Rows[chiMuc].Cells[2].Value.ToString();
            txt_MoTa.Text = dtgv_ThuongHieu.Rows[chiMuc].Cells[3].Value.ToString();
            TenBang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update ThuongHieu set tenThuongHieu = N'" + txt_TenThuongHieu.Text.Trim() + "',quocGia = N'"+ txt_QuocGia.Text.Trim()+"',moTa = N'" + txt_MoTa.Text.Trim() + "' where maThuongHieu = N'" + txt_MaThuongHieu.Text.Trim() + "'";
            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_ThuongHieu);
            TenBang();
            Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "Select * from ThuongHieu where tenThuongHieu LIKE N'%" + txt1_TenThuongHieu.Text.Trim() + "%'";
            KetNoiSQL.TimKiem(sqlTimKiem, dtgv_ThuongHieu);
            TenBang();
        }

        private void dtgv_ThuongHieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
