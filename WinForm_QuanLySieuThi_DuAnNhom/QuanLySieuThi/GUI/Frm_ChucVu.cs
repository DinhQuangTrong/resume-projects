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
    public partial class Frm_ChucVu : Form
    {
        public string chuoi = "SELECT * FROM ChucVu";

        public Frm_ChucVu()
        {
            InitializeComponent();
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_ChucVu);

            if (KetNoiSQL.dt != null && KetNoiSQL.dt.Rows.Count > 0)
            {
                TenBang();
            }
            else
            {
                MessageBox.Show("Dtgv_TaiKhoan không có dữ liệu !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TenBang()
        {
            dtgv_ChucVu.Columns[0].HeaderText = "Mã chức vụ";
            dtgv_ChucVu.Columns[1].HeaderText = "Tên chức vụ";
            dtgv_ChucVu.Columns[2].HeaderText = "Mô tả";
        }
        private void Clear()
        {
            txt_MaChucVu.Text = "";
            txt_TenChucVu.Text = "";
            txt_MoTa.Text = "";

        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ChucVu";
            KetNoiSQL.LamMoi(sql, dtgv_ChucVu);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KetNoiSQL.dt != null && KetNoiSQL.dt.Rows.Count > 0)
            {
                string maChucVu = txt_MaChucVu.Text.Trim();


                if (string.IsNullOrEmpty(maChucVu))
                {
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dtgv_ChucVu.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maChucVu)
                        {
                            MessageBox.Show("Mã chức vụ đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_MaChucVu.Text = "";
                            return;
                        }
                    }
                    if (string.IsNullOrEmpty(txt_MaChucVu.Text) || string.IsNullOrEmpty(txt_TenChucVu.Text) || string.IsNullOrEmpty(txt_MoTa.Text))
                    {
                        MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else
                    {
                        string sql = $"INSERT INTO ChucVu VALUES(N'{txt_MaChucVu.Text}', N'{txt_TenChucVu.Text}', N'{txt_MoTa.Text}')";
                        KetNoiSQL.Them(sql, dtgv_ChucVu);
                        KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_ChucVu);
                        TenBang();
                        Clear();
                    }
                    
                }
            }

            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_MaChucVu.Text) && !string.IsNullOrEmpty(txt_TenChucVu.Text) && !string.IsNullOrEmpty(txt_MoTa.Text))
            {
                string sql = $"UPDATE ChucVu SET tenChucVu = N'{txt_TenChucVu.Text}', moTa = N'{txt_MoTa.Text}' WHERE maChucVu = N'{txt_MaChucVu.Text}'";
                KetNoiSQL.Sua(sql);
                KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_ChucVu);
                TenBang();
                Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string chucvu = txt_MaChucVu.Text;
            string sql = $"DELETE FROM ChucVu WHERE maChucVu = '{chucvu}'";
            KetNoiSQL.Xoa(sql);

        }

        private void dtgv_ChucVu_Click(object sender, EventArgs e)
        {
            int index = dtgv_ChucVu.CurrentRow.Index;
            txt_MaChucVu.Text = dtgv_ChucVu.Rows[index].Cells[0].Value.ToString();
            txt_TenChucVu.Text = dtgv_ChucVu.Rows[index].Cells[1].Value.ToString();
            txt_MoTa.Text = dtgv_ChucVu.Rows[index].Cells[2].Value.ToString();
            TenBang();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlSearch = $"SELECT * FROM ChucVu WHERE maChucVu LIKE '%{txt1_MaChucVu.Text}%'";
            KetNoiSQL.TimKiem(sqlSearch, dtgv_ChucVu);
            TenBang();
        }

        private void dtgv_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
