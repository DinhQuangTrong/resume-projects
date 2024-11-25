using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Drawing;


namespace QuanLySieuThi
{
    public class KetNoiSQL
    {
        public static string sqlCon = @"Data Source=DESKTOP-3LJII6Q\SQLEXPRESS;Initial Catalog=QuanLyST;Integrated Security=True;Encrypt=False";
        public static SqlConnection myCon = new SqlConnection(sqlCon);

        
        public static SqlCommand sqlCom;
        public static SqlDataAdapter sqlADT;
        public static DataTable dt;

        public static SqlCommandBuilder sqlCB;
        public static SqlDataReader Showtext(string sql)
        {
            SqlDataReader read = null;
            try
            {
                myCon = new SqlConnection(sqlCon);
                myCon.Open();
                sqlCom = new SqlCommand(sql, myCon);
                read = sqlCom.ExecuteReader();

            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi kết nối!\n" + ex.Message); }
            return read;
        }
        // ham ket noi
        public static void ChuoiKetNoi(string chuoi, DataGridView dtgv)
        {
            try
            {
                sqlADT = new SqlDataAdapter(chuoi, sqlCon);
                dt = new DataTable();
                sqlCB = new SqlCommandBuilder(sqlADT);
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");
            }
        }

        public static void LamMoi(string sql, DataGridView dtgv)
        {

            try
            {
                sqlADT = new SqlDataAdapter(sql, myCon);
                sqlCB = new SqlCommandBuilder(sqlADT);
                DataTable dt = new DataTable();
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
                MessageBox.Show("Làm mới thành công !", "Thông báo ");
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }
        }

        public static void ClickDTGV(string sql, DataGridView dtgv)
        {
            try
            {
                myCon = new SqlConnection(sqlCon);
                myCon.Open();
                sqlCom = new SqlCommand(sql, myCon);
                sqlADT = new SqlDataAdapter(sqlCom);
                DataTable dt = new DataTable();
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }

        public static void Them(string sql, DataGridView dtgv)
        {
            try
            {
                myCon = new SqlConnection(sqlCon);
                myCon.Open();
                sqlCom = new SqlCommand(sql, myCon);
                sqlADT = new SqlDataAdapter(sqlCom);
                
                DataTable dt = new DataTable();
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
                MessageBox.Show("Thêm thành công !", "Thông báo ", MessageBoxButtons.OK);
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }
        public static void Xoa(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    myCon = new SqlConnection(sqlCon);

                    myCon.Open();
                    sqlCom = new SqlCommand(sql, myCon);
                    MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        public static void Sua(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    myCon = new SqlConnection(sqlCon);
                    myCon.Open();
                    sqlCom = new SqlCommand(sql, myCon);
                    sqlCom.ExecuteNonQuery();
                    myCon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }

        public static void CapNhatSoLuongTon(string sql)
        {       
                try
                {
                    myCon = new SqlConnection(sqlCon);
                    myCon.Open();
                    sqlCom = new SqlCommand(sql, myCon);
                    sqlCom.ExecuteNonQuery();
                    myCon.Close();                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            
        }

        public static void TimKiem(string sql, DataGridView dtgv)
        {
            try
            {
               
                sqlADT = new SqlDataAdapter(sql, myCon);
                DataTable dt = new DataTable();
                sqlCB = new SqlCommandBuilder(sqlADT);
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

 
        }

        public static void XuLyCBX(string sql, ComboBox cbx, string tenCot)
        {
            sqlADT = new SqlDataAdapter(sql, sqlCon);
            DataTable dt = new DataTable();
            sqlADT.Fill(dt);
            cbx.DataSource = dt;
            cbx.DisplayMember = tenCot;
            cbx.ValueMember = tenCot;
        }

        public static void XuLyCBX(string sql, ComboBox cbx, string tenBang, string tenCot)
        {
            sqlADT = new SqlDataAdapter(sql, sqlCon);
            DataTable dt = new DataTable();
            sqlADT.Fill(dt);
            cbx.DataSource = dt;
            cbx.DisplayMember = tenCot;
            cbx.ValueMember = tenBang;

        }


        public static int Dem(string sql)
        {
            int count = 0;
            try
            {
                myCon = new SqlConnection(sqlCon);
                myCon.Open();
                sqlCom = new SqlCommand(sql, myCon);
                count = Convert.ToInt32(sqlCom.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                myCon.Close();
            }
            return count;
        }

        public static bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE taikhoan = @TaiKhoan AND matKhau = @MatKhau";

            using (SqlConnection connection = new SqlConnection(sqlCon))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int count = Convert.ToInt32(result);
                            return count > 0;
                        }
                        else
                        {
                            // Trường hợp không có kết quả trả về từ câu truy vấn
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public static void Luu(string sql, DataGridView dtgv)
        {

            try
            {
                sqlADT = new SqlDataAdapter(sql, myCon);
                sqlCB = new SqlCommandBuilder(sqlADT);
                DataTable dt = new DataTable();
                sqlADT.Fill(dt);
                dtgv.DataSource = dt;
                MessageBox.Show("Lưu thành công !", "Thông báo ");
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }
        }


    }

}
