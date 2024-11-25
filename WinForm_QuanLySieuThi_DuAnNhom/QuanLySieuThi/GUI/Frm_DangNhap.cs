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
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
            CenterToParent();
        }
        private DialogResult ShowConfirmMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            var title = "Xác nhận";
            var message = "Bạn có chắc muốn hủy bỏ ?";
            var ans = ShowConfirmMessage(title, message);

            if (ans == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_TaiKhoan.Text;
            string matKhau = txt_MatKhau.Text;

            if (KetNoiSQL.KiemTraDangNhap(taiKhoan, matKhau))
            {
                if (sender.Equals(btn_DangNhap))
                {
                    var newForm = new Form_TrangChu();
                    newForm.Show();
                    this.Hide();   // ẩn form đăng nhập 
                }
            }

            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
