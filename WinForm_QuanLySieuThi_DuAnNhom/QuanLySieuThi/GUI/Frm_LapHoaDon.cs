using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace QuanLySieuThi
{
    public partial class Frm_LapHoaDon : Form
    {
        private DuLieuCBX duLieuCBX = new DuLieuCBX();
        private string chuoi = "Select * from HoaDon";
        private string chuoiSP = "Select maSP, tenSP from SanPham";
        private bool conHang = true;
        public Frm_LapHoaDon()
        {
            InitializeComponent();
            duLieuCBX.sqlMaNV = "select maNV from NhanVien";
            duLieuCBX.tenCotMaNV = "maNV";
            duLieuCBX.sqlMaKH = "select maKH from KhachHang";
            duLieuCBX.tenCotMaKH = "maKH";
            duLieuCBX.sqlMaSP = "select maSP from SanPham";
            duLieuCBX.tenCotMaSP = "maSP";
            duLieuCBX.sqlTyLeKM = "select phanTramKhuyenMai from KhuyenMai where maKH = '" + cbx_MaKH.Text + "'";
            duLieuCBX.tenCotTyLeKM = "phanTramKhuyenMai";
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaNV, cbx_MaNV, duLieuCBX.tenCotMaNV);
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaKH, cbx_MaKH, duLieuCBX.tenCotMaKH);
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaSP, cbx_MaSP, duLieuCBX.tenCotMaSP);
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlTyLeKM, cbx_PTKM, duLieuCBX.tenCotTyLeKM);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_HD);
            KetNoiSQL.ChuoiKetNoi(chuoiSP, dtgv_TKSanPham);

            TenBangHoaDonChiTiet();
            TenBangHoaDon();
            TenBangSanPhamChiTiet();


        }

        private void TenBangHoaDon()
        {
            if (dtgv_HD.RowCount != 0)
            {
                dtgv_HD.Columns[0].HeaderText = "Mã hóa đơn";
                dtgv_HD.Columns[1].HeaderText = "Mã nhân viên";
                dtgv_HD.Columns[2].HeaderText = "Mã khách hàng";
                dtgv_HD.Columns[3].HeaderText = "Ngày Lập";
                dtgv_HD.Columns[4].HeaderText = "Chú thích";
            }
        }
        private void TenBangHoaDonChiTiet()
        {
            if (dtgv_ChiTietHoaDon.RowCount != 0)
            {
                dtgv_ChiTietHoaDon.Columns["maSP"].HeaderText = "Mã sản phẩm";
                dtgv_ChiTietHoaDon.Columns["soLuong"].HeaderText = "Số lượng";
                dtgv_ChiTietHoaDon.Columns["donGia"].HeaderText = "Đơn giá";
                dtgv_ChiTietHoaDon.Columns["maHD"].HeaderText = "Mã hóa đơn";
                dtgv_ChiTietHoaDon.Columns["thanhTien"].HeaderText = "Thành tiền";
                txt_DonGia.Enabled = false;
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
            txt_MaHD.Text = "";
            cbx_MaNV.Text = "";
            cbx_MaKH.Text = "";
            dtp_NgayLap.Text = "";
        }
        private void Clear1()
        {
            cbx_MaSP.Text = "";
            txt_SoLuong.Text = "";
            txt_DonGia.Text = "";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaHD.Text == "" || cbx_MaKH.Text == "" || cbx_MaNV.Text == "" || dtp_NgayLap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK);
            }

            else
            {
                string sqlCheck = "SELECT COUNT(*) FROM HoaDon WHERE MaHD = '" + txt_MaHD.Text + "'";
                int count = KetNoiSQL.Dem(sqlCheck);

                if (count > 0)
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại!", "Lỗi", MessageBoxButtons.OK);
                }
                else
                {
                   
                    string sql = "INSERT INTO HoaDon VALUES ('" + txt_MaHD.Text + "','" + cbx_MaNV.Text + "', '" + cbx_MaKH.Text + "','" + dtp_NgayLap.Value + "','" + txt_ChuThich.Text + "')";
                    KetNoiSQL.Them(sql, dtgv_HD);
                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_HD);
                    TenBangHoaDon();
                    Clear1();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from HoaDon where maHD = '" + txt_MaHD.Text + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_HD);
            TenBangHoaDon();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update HoaDon set maNV = '" + cbx_MaNV.Text + "',maKH = N'" + cbx_MaKH.Text + "',ngayLap = N'" + dtp_NgayLap.Value + "',ghiChu = N'" + txt_ChuThich + "' where maHD = '" + txt_MaHD.Text + "'";
            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_HD);
            TenBangHoaDon();
            Clear();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            string chuoi1 = "Select * From HoaDonChiTiet Where maHD = '" + txt_MaHD.Text + "'";

            KetNoiSQL.LamMoi(chuoi, dtgv_HD);
            TongThanhTien();
            txt_MaHD.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            Clear();
            Clear1();   
        }

        private void btn1_ThemCTHD_Click(object sender, EventArgs e)
        {
            string maSP = cbx_MaSP.Text.Trim();

            // Nếu mã sản phẩm trống thì không cần kiểm tra
            if (string.IsNullOrEmpty(maSP))
            {
                return;
            }

            // Duyệt qua từng hàng trong dtgv_PhieuNhap để kiểm tra mã sản phẩm đã tồn tại chưa
            foreach (DataGridViewRow row in dtgv_ChiTietHoaDon.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maSP)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại trong bảng hóa đơn chi tiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbx_MaSP.Text = "";
                    return;
                }
            }
            // Kiểm tra xem maPN có tồn tại trong dtgv_PN không
            bool maHDTonTai = false;
            foreach (DataGridViewRow row in dtgv_HD.Rows)
            {
                if (row.Cells[0].Value?.ToString() == txt_MaHD.Text)
                {
                    maHDTonTai = true;
                    break;
                }
            }

            if (!maHDTonTai)
            {
                MessageBox.Show("Mã hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                return;
            }

            // Tiếp tục thêm dữ liệu vào bảng PhieuNhapChiTiet
            if (txt_MaHD.Text == "" || cbx_MaSP.Text == "" || txt_SoLuong.Text == "" || txt_DonGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                string chuoi1 = "Select * From HoaDonChiTiet Where maHD = '" + txt_MaHD.Text + "'";

                double soLuong = double.Parse(txt_SoLuong.Text);
                double gia = double.Parse(txt_DonGia.Text);
                double thanhTien = soLuong * gia;
                GiamSoluongTon();
                if(conHang)
                {
                    string sql = "Insert into HoaDonChiTiet values('" + cbx_MaSP.Text + "','" + txt_SoLuong.Text + "', '" + txt_DonGia.Text + "','" + txt_MaHD.Text + "','" + thanhTien + "')";
                    KetNoiSQL.Them(sql, dtgv_ChiTietHoaDon);
                    KetNoiSQL.ChuoiKetNoi(chuoi1, dtgv_ChiTietHoaDon);
                    TenBangHoaDonChiTiet();
                    TongThanhTien();
                }
                else
                {
                    return;
                }
               
            }
            btn_LuuHoaDon.Enabled = true;
            Clear1();
        }

        private void btn1_Xoa_Click_1(object sender, EventArgs e)
        {
            string chuoi1 = "Select * From HoaDonChiTiet Where maHD = '" + txt_MaHD.Text + "'";

            string sql = "Delete from HoaDonChiTiet where maSP = '" + cbx_MaSP.Text + "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi1, dtgv_ChiTietHoaDon);
            TenBangHoaDonChiTiet();
            TongThanhTien();
        }

        private void cbx_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = cbx_MaSP.Text.Trim();


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

        private void cbx_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TongThanhTien()
        {
            double tongThanhTien = 0;
            if(txt_TienKhach.Text == ""|| cbx_PTKM.Text == "")
            {
                txt_TienKhach.Text = "0";
                cbx_PTKM.Text = "0";

            }
            else
            {
                double phanTramKhuyenMai = double.Parse(cbx_PTKM.Text);
                double tyLeKhuyenMai = phanTramKhuyenMai / 100.0;
                int tienKhach = int.Parse(txt_TienKhach.Text);
                foreach (DataGridViewRow row in dtgv_ChiTietHoaDon.Rows)
                {
                    double thanhTien;
                    if (double.TryParse(row.Cells[4].Value?.ToString(), out thanhTien))
                    {

                        tongThanhTien += thanhTien;
                    }
                }
                double tienGiamGia = (tongThanhTien * tyLeKhuyenMai) / 100;
                double thanhToan = tongThanhTien - tienGiamGia;
                double tienTHua = tienKhach - thanhToan;
                txt_TongTien.Text = thanhToan.ToString();
                txt_TienThua.Text = tienTHua.ToString();
            }
            
        }

        private void dtgv_HD_Click(object sender, EventArgs e)
        {
            duLieuCBX.sqlTyLeKM = "select phanTramKhuyenMai from KhuyenMai where maKH = '" + cbx_MaKH.Text + "'";
            duLieuCBX.tenCotTyLeKM = "phanTramKhuyenMai";
            dtgv_ChiTietHoaDon.Columns.Clear();
            int chiMuc = dtgv_HD.CurrentRow.Index;
            string maHoaDon = txt_MaHD.Text;
            string sql = "Select * From HoaDonChiTiet Where maHD = '" + maHoaDon + "'";
            txt_MaHD.Text = dtgv_HD.Rows[chiMuc].Cells[0].Value.ToString();
            cbx_MaNV.Text = dtgv_HD.Rows[chiMuc].Cells[1].Value.ToString();
            cbx_MaKH.Text = dtgv_HD.Rows[chiMuc].Cells[2].Value.ToString();
            dtp_NgayLap.Text = dtgv_HD.Rows[chiMuc].Cells[3].Value.ToString();
            KetNoiSQL.ClickDTGV(sql, dtgv_ChiTietHoaDon);
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlTyLeKM, cbx_PTKM, duLieuCBX.tenCotTyLeKM);
            TenBangHoaDon();
            TenBangHoaDonChiTiet();
            TongThanhTien();
            txt_MaHD.Enabled = false;
            btn_Them.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

        private void dtgv_ChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (dtgv_ChiTietHoaDon.CurrentRow != null)
            {
                int chiMuc = dtgv_ChiTietHoaDon.CurrentRow.Index;
                cbx_MaSP.Text = dtgv_ChiTietHoaDon.Rows[chiMuc].Cells[0].Value.ToString();
                txt_SoLuong.Text = dtgv_ChiTietHoaDon.Rows[chiMuc].Cells[1].Value.ToString();
                txt_DonGia.Text = dtgv_ChiTietHoaDon.Rows[chiMuc].Cells[2].Value.ToString();
                txt_MaHD.Text = dtgv_ChiTietHoaDon.Rows[chiMuc].Cells[3].Value.ToString();
                TenBangHoaDonChiTiet();

            }
        }
        private void GiamSoluongTon()
        {
            string sqlSoLuongTon = "SELECT soLuongTon FROM SanPham WHERE maSP = '" + cbx_MaSP.Text.Trim() + "'";
            SqlDataReader reader = KetNoiSQL.Showtext(sqlSoLuongTon);

            if (reader != null && reader.HasRows)
            {
                reader.Read();
                int soLuongTonHienTai = Convert.ToInt32(reader["soLuongTon"]);
                int soLuongMoi = Convert.ToInt32(txt_SoLuong.Text);
                int soLuongTonMoi = soLuongTonHienTai - soLuongMoi;
                if (soLuongTonMoi <= 0)
                {
                    conHang = false;
                    string thongBao = "Sản phẩm hiện chỉ còn " + soLuongTonHienTai + " sản phẩm tồn. Không đủ số lượng.";
                    MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sqlCapNhatSoLuong = "UPDATE SanPham SET soLuongTon = " + soLuongTonMoi + " WHERE maSP = '" + cbx_MaSP.Text.Trim() + "'";
                    KetNoiSQL.CapNhatSoLuongTon(sqlCapNhatSoLuong);
                    conHang = true;
                    MessageBox.Show("Thêm phiếu nhập chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reader.Close();
            }
            else
            {     
                reader.Close();
                MessageBox.Show("Không tìm thấy sản phẩm trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_LapHoaDon_Load(object sender, EventArgs e)
        {

        }
        
        private void dtgv_TKSanPham_Click(object sender, EventArgs e)
        {
            int chiMuc = dtgv_TKSanPham.CurrentRow.Index;

            cbx_MaSP.Text = dtgv_TKSanPham.Rows[chiMuc].Cells[0].Value.ToString();
            TenBangSanPhamChiTiet();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String sqlTimKiem = "Select maSP, tenSP from SanPham where maSP = '" + txt_TimKiem.Text + "' OR tenSP LIKE '%" + txt_TimKiem.Text + "%' ";
            KetNoiSQL.TimKiem(sqlTimKiem, dtgv_TKSanPham);
            
        }

        private void btn_LuuHoaDon_Click(object sender, EventArgs e)
        {
            string chuoi1 = "Select * From HoaDonChiTiet Where maHD = '" + txt_MaHD.Text + "'";

            KetNoiSQL.Luu(chuoi, dtgv_HD);
            TongThanhTien();
            btn_Them.Enabled = true;
            txt_MaHD.Enabled = true;
            btn_LuuHoaDon.Enabled = false;
            Clear();
            Clear1();
        }
    }
}
