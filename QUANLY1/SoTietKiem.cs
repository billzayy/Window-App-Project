using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY1
{
    class SoTietKiem : SoTien
    {
        private string maso;
        private string khachhang;
        private DateTime ngaymoso;
        private string cmnd;
        private string diachi;
        private float sotiengui;
        private string loaitietkiem;
        private float sotien;

        #region Properties
        public float SoTien { get => sotien; set => sotien = value; }
        public string MaSo { get => maso; set => maso = value; }
        public string KhachHang { get => khachhang; set => khachhang = value; }
        public DateTime NgayMoSo { get => ngaymoso; set => ngaymoso = value; }
        public string CMND { get => cmnd; set => cmnd = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public float SoTienGui { get => sotiengui; set => sotiengui = value; }
        public string LoaiTietKiem { get => loaitietkiem; set => loaitietkiem = value; }
        #endregion

        public void Insert()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "INSERT INTO SoTietKiem VALUES(@MaSo, @CMND, @KhachHang, @DiaChi, @LoaiTK, @SoTienGui, @NgayMoSo)";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@KhachHang", KhachHang);
                sqlcomd.Parameters.AddWithValue("@SoTienGui", SoTienGui);
                if (SoTienGui >= SoTien)
                {
                    sqlcomd.Parameters.AddWithValue("@NgayMoSo", NgayMoSo);
                    sqlcomd.Parameters.AddWithValue("@CMND", CMND);
                    sqlcomd.Parameters.AddWithValue("@DiaChi", DiaChi);
                    sqlcomd.Parameters.AddWithValue("@LoaiTK", LoaiTietKiem);
                }
                else
                {
                    MessageBox.Show("Số tiền gửi chưa đủ để mở sổ");
                }
                conn.Open();
                sqlcomd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !", "Thông báo");
            }
        }
        public void Update()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "UPDATE SoTietKiem SET CMND = @CMND, KhachHang  =@KhachHang, DiaChi = @DiaChi, LoaiTK = @LoaiTK, SoTienGui = @SoTienGui, NgayMoSo = @NgayMoSo WHERE MaSo = @MaSo";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@KhachHang", KhachHang);
                sqlcomd.Parameters.AddWithValue("@NgayMoSo", NgayMoSo);
                sqlcomd.Parameters.AddWithValue("@CMND", CMND);
                sqlcomd.Parameters.AddWithValue("@DiaChi", DiaChi);
                if (SoTienGui >= SoTien)
                    sqlcomd.Parameters.AddWithValue("@SoTienGui", SoTienGui);
                else
                    MessageBox.Show("Số tiền gửi chưa đủ để mở sổ");
                sqlcomd.Parameters.AddWithValue("@LoaiTK", LoaiTietKiem);
                conn.Open();
                sqlcomd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi !", "Thông báo");
            }
        }
        public void Delete()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "DELETE FROM SoTietKiem WHERE MaSo = @MaSo";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update1()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "UPDATE SoTietKiem SET CMND = @CMND, KhachHang  =@KhachHang, DiaChi = @DiaChi, LoaiTK = @LoaiTK, SoTienGui = @SoTienGui, NgayMoSo = @NgayMoSo WHERE MaSo = @MaSo";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@KhachHang", KhachHang);
                sqlcomd.Parameters.AddWithValue("@NgayMoSo", NgayMoSo);
                sqlcomd.Parameters.AddWithValue("@CMND", CMND);
                sqlcomd.Parameters.AddWithValue("@DiaChi", DiaChi);
                sqlcomd.Parameters.AddWithValue("@SoTienGui", SoTienGui);
                sqlcomd.Parameters.AddWithValue("@LoaiTK", LoaiTietKiem);
                conn.Open();
                sqlcomd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi !", "Thông báo");
            }
        }      
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SoTietKiem ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public static DataTable GetData1()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SoTien ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}

    