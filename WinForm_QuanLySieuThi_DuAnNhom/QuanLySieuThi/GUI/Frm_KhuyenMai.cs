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
    public partial class Frm_KhuyenMai : Form
    {
        public string chuoi = "Select * from KhuyenMai";
        private DuLieuCBX duLieuCBX = new DuLieuCBX();
        public Frm_KhuyenMai()
        {
            InitializeComponent();
            duLieuCBX.sqlMaKH = "select maKH from KhachHang";
            duLieuCBX.tenCotMaKH = "maKH";
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaKH, cbb_MaKH, duLieuCBX.tenCotMaKH);
            KetNoiSQL.XuLyCBX(duLieuCBX.sqlMaKH, cbb_MaKH1, duLieuCBX.tenCotMaKH);

            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_KhuyenMai);
            

            if (KetNoiSQL.dt != null && KetNoiSQL.dt.Rows.Count > 0)
            {
                TenBang();
            }
            else
            {
                MessageBox.Show("Khuyến mãi không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TenBang()
        {
            dtgv_KhuyenMai.Columns[0].HeaderText = "Mã khuyến mãi";
            dtgv_KhuyenMai.Columns[0].Width = 200;
            dtgv_KhuyenMai.Columns[1].HeaderText = "Phần trăm khuyến mãi";
            dtgv_KhuyenMai.Columns[1].Width = 150;
            dtgv_KhuyenMai.Columns[2].HeaderText = "Ngày bắt đầu";
            dtgv_KhuyenMai.Columns[2].Width = 100;
            dtgv_KhuyenMai.Columns[3].HeaderText = "Ngày kết thúc";
            dtgv_KhuyenMai.Columns[3].Width = 100;
            
            dtgv_KhuyenMai.Columns[4].HeaderText = "Mã khách hàng";
            dtgv_KhuyenMai.Columns[4].Width = 700;
            dtgv_KhuyenMai.Columns[5].HeaderText = "Mô tả";
            dtgv_KhuyenMai.Columns[5].Width = 700;


        }

        private void dtgv_KhuyenMai_Click(object sender, EventArgs e)
        {
            int soThuTu = dtgv_KhuyenMai.CurrentRow.Index;
            txt_MaKM.Text = dtgv_KhuyenMai.Rows[soThuTu].Cells[0].Value.ToString();
            txt_PhanTramKM.Text = dtgv_KhuyenMai.Rows[soThuTu].Cells[1].Value.ToString();

            string ngayBDString = dtgv_KhuyenMai.Rows[soThuTu].Cells[2].Value.ToString();
            DateTime ngayBD;
            if (DateTime.TryParse(ngayBDString, out ngayBD))
            {
                dtp_NgayBD.Value = ngayBD;
            }

            string ngayKTString = dtgv_KhuyenMai.Rows[soThuTu].Cells[3].Value.ToString();
            DateTime ngayKT;
            if (DateTime.TryParse(ngayKTString, out ngayKT))
            {
                dtp_NgayKT.Value = ngayKT;
            }



            cbb_MaKH.Text= dtgv_KhuyenMai.Rows[soThuTu].Cells[4].Value.ToString();
            txt_Mota.Text = dtgv_KhuyenMai.Rows[soThuTu].Cells[5].Value.ToString();
         
            TenBang();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maKhuyenMai = txt_MaKM.Text.Trim();


            if (string.IsNullOrEmpty(maKhuyenMai))
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dtgv_KhuyenMai.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maKhuyenMai)
                    {
                        MessageBox.Show("Mã khuyến mãi đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MaKM.Text = "";
                        return;
                    }
                }

                // Lấy giá trị ngày/tháng/năm từ DateTimePicker
                string ngayBD = dtp_NgayBD.Value.ToString("yyyy-MM-dd");
                string ngayKT = dtp_NgayKT.Value.ToString("yyyy-MM-dd");

                if (txt_MaKM.Text == "" || txt_PhanTramKM.Text == "" || txt_Mota.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql1 = "Insert into KhuyenMai values(N'" + txt_MaKM.Text + "','" + float.Parse(txt_PhanTramKM.Text) + "','" + ngayBD + "','" + ngayKT + "','" + cbb_MaKH.Text + "',N'" + txt_Mota.Text + "')";
                    KetNoiSQL.Them(sql1, dtgv_KhuyenMai);
                    KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_KhuyenMai);
                    TenBang();
                }
            }

            Clear();
        }

        private void Clear()
        {
            txt_MaKM.Text = "";
            cbb_MaKH.Text = "";
            txt_PhanTramKM.Clear();
            txt_Mota.Text = "";

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            KetNoiSQL.LamMoi("Select * from KhuyenMai", dtgv_KhuyenMai);
            Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from KhuyenMai where maKM = N'" + txt_MaKM.Text+ "'";
            KetNoiSQL.Xoa(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_KhuyenMai);
            TenBang();
            Clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Lấy giá trị ngày/tháng/năm từ DateTimePicker
            string ngayBD = dtp_NgayBD.Value.ToString("yyyy-MM-dd");
            string ngayKT = dtp_NgayKT.Value.ToString("yyyy-MM-dd");

            string sql = "Update KhuyenMai set phanTramKhuyenMai = '" + float.Parse(txt_PhanTramKM.Text) + "',ngayBatDau = '" + ngayBD + "',ngayKetthuc = '" + ngayKT + "',maKH = '"+ cbb_MaKH.Text + "',moTa = N'" + txt_Mota.Text + "' where maKM = N'" + txt_MaKM.Text+ "'";
            KetNoiSQL.Sua(sql);
            KetNoiSQL.ChuoiKetNoi(chuoi, dtgv_KhuyenMai);
            TenBang();
            Clear();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maKHTimKiem = cbb_MaKH1.Text;
            string sqlTimKiem = "Select * from KhuyenMai where maKH LIKE '%"+ maKHTimKiem +"%'";
            KetNoiSQL.TimKiem(sqlTimKiem, dtgv_KhuyenMai);
            TenBang();
        }
        
        private void dtgv_KhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
