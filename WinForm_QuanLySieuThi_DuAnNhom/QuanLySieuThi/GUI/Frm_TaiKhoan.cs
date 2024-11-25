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
    public partial class Frm_TaiKhoan : Form
    {
        public string chuoi = "SELECT * FROM TaiKhoan";
        private DuLieuCBX duLieuCBX = new DuLieuCBX();

        public Frm_TaiKhoan()
        {
            InitializeComponent();

            duLieuCBX.sqlMaChucVu = "select maChucVu from ChucVu";
            duLieuCBX.tenCotMaChucVu = "maChucVu";
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaChucVu, combo_MaCV, duLieuCBX.tenCotMaChucVu);

            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_TaiKhoan);

            if (KetNoiSQL.dt != null && KetNoiSQL.dt.Rows.Count > 0)
            {
                TenBang();
            }
            else
            {
                MessageBox.Show("Dtgv_TaiKhoan không có dữ liệu !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            string sqlLamMoi = "SELECT * FROM TaiKhoan";
            KetNoiSQL.LamMoi(sqlLamMoi, dtgv_TaiKhoan);
        }
        private void TenBang()
        {
            dtgv_TaiKhoan.Columns[0].HeaderText = "Tài khoản";
            dtgv_TaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            dtgv_TaiKhoan.Columns[2].HeaderText = "Mã chức vụ";
        }

        private void Clear()
        {
            txt_TaiKhoan.Text = "";
            txt_MatKhau.Text = "";
            combo_MaCV.SelectedIndex = 0;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
          
            if (combo_MaCV != null && !string.IsNullOrEmpty(txt_TaiKhoan.Text) && !string.IsNullOrEmpty(txt_MatKhau.Text) && combo_MaCV.SelectedIndex != -1)
            {                      
                string taiKhoan = txt_TaiKhoan.Text.Trim();


                if (string.IsNullOrEmpty(taiKhoan))
                {
                    return;
                }
                else
                {
                    foreach (DataGridViewRow row in dtgv_TaiKhoan.Rows)
                    {
                        if (row.Cells[0].Value != null && (row.Cells[0].Value.ToString() == taiKhoan))
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_TaiKhoan.Text = "";
                            return;
                        }
                    }
                    string sql = $"INSERT INTO TaiKhoan VALUES(N'{txt_TaiKhoan.Text}', N'{txt_MatKhau.Text}', N'{combo_MaCV.Text}')";
                    KetNoiSQL.Them(sql, dtgv_TaiKhoan);
                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_TaiKhoan);
                    TenBang();
                    Clear();         
                }
                
            }
            else
            {
                
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (combo_MaCV != null && !string.IsNullOrEmpty(txt_TaiKhoan.Text) && !string.IsNullOrEmpty(txt_MatKhau.Text) && combo_MaCV.SelectedIndex != -1)
            {
                string sql = $"UPDATE TaiKhoan SET   matKhau = N'{txt_MatKhau.Text}' , maChucVu = {combo_MaCV.Text} where taiKhoan = N'{txt_TaiKhoan.Text}'";
                KetNoiSQL.Sua(sql);
                KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_TaiKhoan);
                TenBang();
                Clear();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM TaiKhoan WHERE taiKhoan = N'{txt_TaiKhoan.Text}'";
            KetNoiSQL.Xoa(sql);
        }

        private void dtgv_TaiKhoan_Click(object sender, EventArgs e)
        {
            int index = dtgv_TaiKhoan.CurrentRow.Index;
            txt_TaiKhoan.Text = dtgv_TaiKhoan.Rows[index].Cells[0].Value.ToString();
            txt_MatKhau.Text = dtgv_TaiKhoan.Rows[index].Cells[1].Value.ToString();
            combo_MaCV.Text = dtgv_TaiKhoan.Rows[index].Cells[2].Value.ToString();
            TenBang();
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_MaCV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
