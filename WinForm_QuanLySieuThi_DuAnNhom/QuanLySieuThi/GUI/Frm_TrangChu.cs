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
    public partial class Form_TrangChu : Form
    {
        public Form_TrangChu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void menu_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_NhanVien());
        }


        private void menu_LoaiSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_LoaiSanPham());

        }

        private void menu_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_SanPham());
        }

        private void memu_KhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_KhuyenMai());
        }
        private void menu_NhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_NhaCungCap());
        }

        private void menu_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_KhachHang());
        }

        private void menu_TaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_TaiKhoan());

        }
        private void menu_LapHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_LapHoaDon());

        }

        private void menu_NhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_NhapHang());

        }

        private void menu_BaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_BaoCao());

        } 
        private void thươngHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_ThuongHieu());
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_ChucVu());
        }
        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu_DangNhap_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_HoaDon_Click(object sender, EventArgs e)
        {

        }

        private void menu_DangXuat_Click(object sender, EventArgs e)
        {
            var title = "Xác nhận ";
            var message = "Bạn có chắc chắn muốn đăng xuất ?";
            var ans = ShowConfirmMessage(title, message);

            if (ans == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Close();

                // Mở form đăng nhập
                var loginForm = new Frm_DangNhap();
                loginForm.Show();
            }
        }
        private DialogResult ShowConfirmMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

       
    }
}
