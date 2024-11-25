using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLySieuThi
{
    public partial class Frm_BaoCao : Form
    {
        public string chuoi = @"SELECT HoaDon.maHD, HoaDon.maKH, HoaDon.maNV, HoaDon.ngayLap, HoaDonChiTiet.maSP,HoaDonChiTiet.thanhTien, HoaDon.ghiChu
                                FROM HoaDon, HoaDonChiTiet
                                WHERE HoaDon.maHD = HoaDonChiTiet.maHD
                                GROUP BY HoaDon.maHD, HoaDon.maKH, HoaDon.maNV,  HoaDon.ngayLap,HoaDonChiTiet.maSP,HoaDonChiTiet.thanhTien, HoaDon.ghiChu";
                                
        public Frm_BaoCao()
        {
            InitializeComponent();

            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_Chitiet);
            TenBang();
        }

        private void TenBang()
        {
            dtgv_Chitiet.Columns[0].HeaderText = "Mã hóa đơn";
            dtgv_Chitiet.Columns[0].Width = 200;
            dtgv_Chitiet.Columns[1].HeaderText = "Mã khách hàng";
            dtgv_Chitiet.Columns[1].Width = 200;
            dtgv_Chitiet.Columns[2].HeaderText = "Mã nhân viên";
            dtgv_Chitiet.Columns[2].Width = 200;
            
            dtgv_Chitiet.Columns[3].HeaderText = "Ngày lập";
            dtgv_Chitiet.Columns[3].Width = 150;
            dtgv_Chitiet.Columns[4].HeaderText = "Mã sản phẩm";
            dtgv_Chitiet.Columns[4].Width = 200;
            dtgv_Chitiet.Columns[5].HeaderText = "Thành tiền";
            dtgv_Chitiet.Columns[5].Width = 150;
            dtgv_Chitiet.Columns[6].HeaderText = "Ghi chú";
            dtgv_Chitiet.Columns[6].Width = 200;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ChonNgay_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày được chọn từ DateTimePicker         
            string ngayChon = dtp_ChonNgay.Value.ToString("yyyy-MM-dd");

            // Truy vấn cơ sở dữ liệu để lấy thông tin
            string sql = @"SELECT HoaDon.maHD, HoaDon.maKH, HoaDon.maNV,  HoaDon.ngayLap, HoaDonChiTiet.maSP,HoaDonChiTiet.thanhTien, HoaDon.ghiChu
                            FROM HoaDon, HoaDonChiTiet
                             WHERE HoaDon.maHD = HoaDonChiTiet.maHD AND ngayLap = '" + ngayChon + @"'
                             GROUP BY HoaDon.maHD, HoaDon.maKH, HoaDon.maNV,  HoaDon.ngayLap, HoaDonChiTiet.maSP,HoaDonChiTiet.thanhTien, HoaDon.ghiChu";

            KetNoiSQL.ChuoiKetNoi(sql, dtgv_Chitiet);
            TenBang();

            // Tính tổng doanh thu từ cột thanhTien trong DataTable dt
            decimal tongDoanhThu = 0;
            foreach (DataRow row in KetNoiSQL.dt.Rows)
            {
                // Sử dụng kiểu dữ liệu để tránh mất mát chính xác trong phép tính tiền tệ
                tongDoanhThu += Convert.ToDecimal(row["thanhTien"]);
            }

            // Hiển thị tổng doanh thu trên lbl_Hien
          
            lb_Doanhthu.Text = tongDoanhThu.ToString(); 
        }

        private void dtgv_Chitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
