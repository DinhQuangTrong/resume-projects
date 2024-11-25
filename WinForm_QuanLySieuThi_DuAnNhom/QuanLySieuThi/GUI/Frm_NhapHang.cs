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
    public partial class Frm_NhapHang : Form
    {
        
        private DuLieuCBX duLieuCBX = new DuLieuCBX();
        private string chuoi = "Select * from PhieuNhap";
        private string chuoiSP = "Select maSP, tenSP from SanPham";
        public Frm_NhapHang()
        {
            InitializeComponent();

            duLieuCBX.sqlMaNCC = "Select maNhaCC FROM NhaCungCap";
            duLieuCBX.tenCotMaNCC = "maNhaCC";
            duLieuCBX.sqlMaNV = "Select maNV FROM NhanVien";
            duLieuCBX.tenCotMaNV = "maNV";
            duLieuCBX.sqlMaSP = "Select maSP,tenSP From SanPham";
            duLieuCBX.tenCotMaSP = "maSP";

            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaNCC, cbx_MaNhaCC, duLieuCBX.tenCotMaNCC);
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaNV, cbx_MaNhanVien, duLieuCBX.tenCotMaNV);
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaSP, cbx_MaSP, duLieuCBX.tenCotMaSP);

            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_PN);
            KetNoiSQL.ChuoiKetNoi(chuoiSP, dtgv_TKSanPham);

            TenBangPhieuNhapChiTiet();
            TenBangPhieuNhap();
            TenBangSanPhamChiTiet();



        }
        private void TenBangPhieuNhapChiTiet()
        {
            if(dtgv_PhieuNhap.RowCount != 0)
            {
                dtgv_PhieuNhap.Columns[0].HeaderText = "Mã sản phẩm";
                dtgv_PhieuNhap.Columns[1].HeaderText = "Số lượng";
                dtgv_PhieuNhap.Columns[2].HeaderText = "Đơn giá";
                dtgv_PhieuNhap.Columns[3].HeaderText = "Mã phiếu nhập";
                dtgv_PhieuNhap.Columns[4].HeaderText = "Thành tiền";
                txt_DonGia.Enabled = false;
            }
        }
        private void TenBangPhieuNhap()
        {
            if (dtgv_PN.RowCount != 0)
            {
                dtgv_PN.Columns[0].HeaderText = "Mã Phiếu nhập";
                dtgv_PN.Columns[1].HeaderText = "Mã nhà cung cấp";
                dtgv_PN.Columns[2].HeaderText = "Mã nhân viên";
                dtgv_PN.Columns[3].HeaderText = "Ngày nhập";
            }
        }

        private void TenBangSanPhamChiTiet()
        {
            if (dtgv_TKSanPham.RowCount != 0)
            {
                dtgv_TKSanPham.Columns[0].HeaderText = "Mã sản phẩm";
                dtgv_TKSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            }
        }

        private void Clear()
        {
            txt_MaPN.Text = "";
            cbx_MaNhanVien.Text = "";
            cbx_MaNhaCC.Text = "";
            dtp_NgayNhap.Text = "";
        }
        private void Clear1()
        {
            cbx_MaSP.Text = "";
            txt_SoLuong.Text = "";
            txt_DonGia.Text = "";
        }

        private void groupBox_NhapHang_Enter(object sender, EventArgs e)
        {

        }
        private void cbb_MaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void TongThanhTien()
        {
            double tongThanhTien = 0;


            foreach (DataGridViewRow row in dtgv_PhieuNhap.Rows)
            {

                double thanhTien;
                if (double.TryParse(row.Cells[4].Value?.ToString(), out thanhTien))
                {

                    tongThanhTien += thanhTien;
                }
            }


            lb_ThanhTien.Text = tongThanhTien.ToString();
        }
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            string chuoi1 = "Select * From PhieuNhapChiTiet Where maPhieuNhap = '" + txt_MaPN.Text + "'";

            KetNoiSQL.LamMoi(chuoi, dtgv_PN);
            KetNoiSQL.LamMoi(chuoi1, dtgv_PhieuNhap);
            txt_MaPN.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;


        }

        private void dtgv_PhieuNhap_Click(object sender, EventArgs e)
        {
            if (dtgv_PhieuNhap.CurrentRow != null)
            {
                int chiMuc = dtgv_PhieuNhap.CurrentRow.Index;
                cbx_MaSP.Text = dtgv_PhieuNhap.Rows[chiMuc].Cells[0].Value.ToString();
                txt_SoLuong.Text = dtgv_PhieuNhap.Rows[chiMuc].Cells[1].Value.ToString();
                txt_DonGia.Text = dtgv_PhieuNhap.Rows[chiMuc].Cells[2].Value.ToString();
                txt_MaPN.Text = dtgv_PhieuNhap.Rows[chiMuc].Cells[3].Value.ToString();
                TenBangPhieuNhapChiTiet();               
            }
            
        }

        private void dtgv_PN_Click_1(object sender, EventArgs e)
        {
            dtgv_PhieuNhap.Columns.Clear();
            int chiMuc = dtgv_PN.CurrentRow.Index;
            string maPhieuNhap = txt_MaPN.Text;
            string sql = "Select * From PhieuNhapChiTiet Where maPhieuNhap = '" + maPhieuNhap + "'";
            txt_MaPN.Text = dtgv_PN.Rows[chiMuc].Cells[0].Value.ToString();
            cbx_MaNhaCC.Text = dtgv_PN.Rows[chiMuc].Cells[1].Value.ToString();
            cbx_MaNhanVien.Text = dtgv_PN.Rows[chiMuc].Cells[2].Value.ToString();
            dtp_NgayNhap.Text = dtgv_PN.Rows[chiMuc].Cells[3].Value.ToString();
            KetNoiSQL.ClickDTGV(sql, dtgv_PhieuNhap);
            TenBangPhieuNhap();
            TenBangPhieuNhapChiTiet();
            txt_MaPN.Enabled = false;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void cbx_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {


            string maSP = cbx_MaSP.Text.Trim();

            // Nếu mã sản phẩm trống thì không cần kiểm tra

            // Nếu mã sản phẩm không trùng, tiếp tục lấy thông tin đơn giá
            string sql = "SELECT donGia FROM SanPham WHERE maSP = '" + maSP + "'";
            SqlDataReader reader = KetNoiSQL.Showtext(sql);

            if (reader != null && reader.HasRows)
            {
                reader.Read();
                string donGia = reader["donGia"].ToString();
                txt_DonGia.Text = donGia;
            }
            reader.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaPN.Text == "" || cbx_MaNhanVien.Text == "" || cbx_MaNhaCC.Text == "" || dtp_NgayNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK);
            }
            
            else
            {
                string sqlCheck = "SELECT COUNT(*) FROM PhieuNhap WHERE MaPhieuNhap = '" + txt_MaPN.Text + "'";
                int count = KetNoiSQL.Dem(sqlCheck); 

                if (count > 0)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK);
                }
                else
                {
                    // Nếu MaPN không trùng, thực hiện thêm vào cơ sở dữ liệu
                    string sql = "INSERT INTO PhieuNhap VALUES ('" + txt_MaPN.Text + "','" + cbx_MaNhaCC.Text + "', '" + cbx_MaNhanVien.Text + "','" + dtp_NgayNhap.Value + "')";
                    KetNoiSQL.Them(sql, dtgv_PN);
                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_PN);
                    TenBangPhieuNhap();
                    Clear1();
                }          
            }
        }

        private void btn1_Them_Click(object sender, EventArgs e)
        {
            string maSP = cbx_MaSP.Text.Trim();

            // Nếu mã sản phẩm trống thì không cần kiểm tra
            if (string.IsNullOrEmpty(maSP))
            {
                return;
            }

            
            foreach (DataGridViewRow row in dtgv_PhieuNhap.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maSP)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại trong bảng phiếu nhập chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbx_MaSP.Text = "";
                    return;
                }
            }
            bool maPNTonTai = false;
            foreach (DataGridViewRow row in dtgv_PN.Rows)
            {
                if (row.Cells[0].Value?.ToString() == txt_MaPN.Text)
                {
                    maPNTonTai = true;
                    break;
                }
            }

            if (!maPNTonTai)
            {
                MessageBox.Show("Mã phiếu nhập không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            // Tiếp tục thêm dữ liệu vào bảng PhieuNhapChiTiet
            if (txt_MaPN.Text == "" || cbx_MaSP.Text == "" || txt_SoLuong.Text == "" || txt_DonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                string chuoi1 = "Select * From PhieuNhapChiTiet Where maPhieuNhap = '" + txt_MaPN.Text + "'";

                double soLuong = double.Parse(txt_SoLuong.Text);
                double gia = double.Parse(txt_DonGia.Text);
                double thanhTien = soLuong * gia;
                string sql = "Insert into PhieuNhapChiTiet values('" + cbx_MaSP.Text + "','" + txt_SoLuong.Text + "', '" + txt_DonGia.Text + "','" + txt_MaPN.Text + "','" + thanhTien + "')";
                KetNoiSQL.Them(sql, dtgv_PhieuNhap);
                KetNoiSQL.ChuoiKetNoi(chuoi1, dtgv_PhieuNhap);
                TenBangPhieuNhapChiTiet();
                TongThanhTien();
                ThemSoluongTon();
            }
            btn_Luu.Enabled = true;
            Clear1();
        }

        private void btn1_Xoa_Click(object sender, EventArgs e)
        {
            string chuoi1 = "Select * From PhieuNhapChiTiet Where maPhieuNhap = '" + txt_MaPN.Text + "'";

            string sql = "Delete from PhieuNhapChiTiet where maSP = '" + cbx_MaSP.Text + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi1, dtgv_PhieuNhap);
            TenBangPhieuNhapChiTiet();
            TongThanhTien();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from PhieuNhap where maPhieuNhap = '" + txt_MaPN.Text + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_PN);
            TenBangPhieuNhap();
           

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            string sql = "Update PhieuNhap set maNCC = '" + cbx_MaNhaCC.Text + "',maNV = N'" + cbx_MaNhanVien.Text  + "',ngayNhap = N'" + dtp_NgayNhap.Value + "' where maPhieuNhap = '" + txt_MaPN.Text + "'";
            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_PN);
            TenBangPhieuNhap();
            Clear();
        }

       private void ThemSoluongTon()
       {
            string sqlSoLuongTon = "SELECT soLuongTon FROM SanPham WHERE maSP = '" + cbx_MaSP.Text.Trim() + "'";
            SqlDataReader reader = KetNoiSQL.Showtext(sqlSoLuongTon);

            if (reader != null && reader.HasRows)
            {
                reader.Read();
                int soLuongTonHienTai = Convert.ToInt32(reader["soLuongTon"]);

                // Lấy số lượng mới nhập từ txt_SoLuong
                int soLuongMoi = Convert.ToInt32(txt_SoLuong.Text);

                // Cập nhật số lượng tồn mới
                int soLuongTonMoi = soLuongTonHienTai + soLuongMoi;

                // Cập nhật số lượng tồn mới vào cơ sở dữ liệu
                string sqlCapNhatSoLuong = "UPDATE SanPham SET soLuongTon = " + soLuongTonMoi + " WHERE maSP = '" + cbx_MaSP.Text.Trim() + "'";
                KetNoiSQL.CapNhatSoLuongTon(sqlCapNhatSoLuong);

                // Đóng kết nối và đóng đối tượng SqlDataReader
                reader.Close();

                // Hiển thị thông báo thành công
                MessageBox.Show("Thêm phiếu nhập chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Đóng kết nối và đóng đối tượng SqlDataReader
                reader.Close();

                // Hiển thị thông báo lỗi nếu không tìm thấy số lượng tồn
                MessageBox.Show("Không tìm thấy sản phẩm trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgv_TKSanPham_Click(object sender, EventArgs e)
        {
            int chiMuc = dtgv_TKSanPham.CurrentRow.Index;

            cbx_MaSP.Text = dtgv_TKSanPham.Rows[chiMuc].Cells[0].Value.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String sqlTimKiem = "Select maSP, tenSP from SanPham where maSP = '" + txt_TimKiem.Text + "' OR tenSP LIKE '%" + txt_TimKiem.Text + "%' ";
            KetNoiSQL.TimKiem(sqlTimKiem, dtgv_TKSanPham);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string chuoi1 = "Select * From PhieuNhapChiTiet Where maPhieuNhap = '" + txt_MaPN.Text + "'";

            KetNoiSQL.Luu(chuoi, dtgv_PN);
            KetNoiSQL.Luu(chuoi1, dtgv_PhieuNhap);
            btn_Them.Enabled = true;
            txt_MaPN.Enabled = true;
            btn_Luu.Enabled = false;
            Clear();
            Clear1();
        }
    }
}
