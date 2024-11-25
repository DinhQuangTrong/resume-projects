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
    public partial class Frm_NhanVien : Form
    {
        string chuoi = "select * from NhanVien";
        private DuLieuCBX duLieuCBX = new DuLieuCBX();
        public Frm_NhanVien()
        {
            InitializeComponent();
            duLieuCBX.sqlMaChucVu = "select maChucVu from ChucVu";
            duLieuCBX.tenCotMaChucVu = "maChucVu";
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaChucVu, cbb_ChucVu, duLieuCBX.tenCotMaChucVu);


            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_NhanVien);
            TenBang();
        }
        public void TenBang()
        {
            dtgv_NhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dtgv_NhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dtgv_NhanVien.Columns[2].HeaderText = "Ngày sinh";
            dtgv_NhanVien.Columns[3].HeaderText = "Giới tính";
            dtgv_NhanVien.Columns[4].HeaderText = "Điện thoại";
            dtgv_NhanVien.Columns[5].HeaderText = "Mã chức vụ";


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lb_HT_Click(object sender, EventArgs e)
        {

        }

        private void lb_SDT_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KetNoiSQL.LamMoi(chuoi, dtgv_NhanVien);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txt_MaNV.Text = "";
            txt_HoTen.Text = "";
            dtp_NgaySinh.Text = "";
            txt_SDT.Text = "";
            cbb_ChucVu.Text = "";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            string gioiTinh = "";
            if (rdobtn_Nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdobtn_Nu.Checked)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maNV = txt_MaNV.Text.Trim();


            if (string.IsNullOrEmpty(maNV))
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dtgv_NhanVien.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maNV)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MaNV.Text = "";
                        return;
                    }
                }

                if (txt_MaNV.Text == "" || txt_HoTen.Text == "" || dtp_NgaySinh.Text == "" || gioiTinh == "" || txt_SDT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK);
                }
                else
                {
                    string sql1 = "Insert into NhanVIen values('" + txt_MaNV.Text + "','" + txt_HoTen.Text + "','" + dtp_NgaySinh.Value + "','" + gioiTinh + "','" + txt_SDT.Text + "', '" + cbb_ChucVu.Text + "')";
                    KetNoiSQL.Them(sql1, dtgv_NhanVien);

                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_NhanVien);
                    TenBang();
                    Clear();

                }
            }
        }
        public string XuLyRadioButton(string gioiTinh)
        {
            if (rdobtn_Nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdobtn_Nu.Checked)
            {
                gioiTinh = "Nữ";
            }

            return gioiTinh;
        }
        private void rdobtn_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_NhanVien_Click(object sender, EventArgs e)
        {
            int chiMuc = dtgv_NhanVien.CurrentRow.Index;
            string gioiTinh = "";
            string gioiTinh1 = XuLyRadioButton(gioiTinh);
            txt_MaNV.Text = dtgv_NhanVien.Rows[chiMuc].Cells[0].Value.ToString();
            txt_HoTen.Text = dtgv_NhanVien.Rows[chiMuc].Cells[1].Value.ToString();
            dtp_NgaySinh.Text = dtgv_NhanVien.Rows[chiMuc].Cells[2].Value.ToString();
            gioiTinh1 = dtgv_NhanVien.Rows[chiMuc].Cells[3].Value.ToString();
            txt_SDT.Text = dtgv_NhanVien.Rows[chiMuc].Cells[4].Value.ToString();
            cbb_ChucVu.Text = dtgv_NhanVien.Rows[chiMuc].Cells[5].Value.ToString();
            TenBang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string gioiTinh = "";
            string sql = "Update NhanVien set hoTen = '" + txt_HoTen.Text + "',ngaySinh = N'" + dtp_NgaySinh.Value + "',gioiTinh = N'" + XuLyRadioButton(gioiTinh) + "',dienThoai = '" + txt_SDT.Text + "',maChucVu = '" + cbb_ChucVu.Text + "' where maNV = '" + txt_MaNV.Text + "'";
            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_NhanVien);
            TenBang();
            Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from NhanVien where maNV = '" + txt_MaNV.Text + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_NhanVien);
            TenBang();
            Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String sqlTimKiem = "Select * from NhanVien where maNV LIKE '%" + txt1_MaNhanVien.Text + "%' ";
            KetNoiSQL.TimKiem(sqlTimKiem, dtgv_NhanVien);
            TenBang();
        }

        private void cbb_ChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
