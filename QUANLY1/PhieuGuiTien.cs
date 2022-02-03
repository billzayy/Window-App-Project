using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QUANLY1
{
    class PhieuGuiTien : SoTien
    {
        private DateTime ngaygui;
        private float sogui;
        private string maso;
        private string khachhang;
        private float sotien;

        #region Properties
        public float SoTien { get => sotien; set => sotien = value; }
        public string MaSo { get => maso; set => maso = value; }
        public string KhachHang { get => khachhang; set => khachhang = value; }
        public DateTime NgayGui { get => ngaygui; set => ngaygui = value; }
        public float SoGui { get => sogui; set => sogui = value; }
        #endregion

        public void Insert()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "INSERT INTO PhieuGuiTien VALUES (@MaSo, @KhachHang, @NgayGui, @SoTienGui)";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@KhachHang", KhachHang);
                sqlcomd.Parameters.AddWithValue("@NgayGui", NgayGui);
                if (SoGui >= SoTien)
                    sqlcomd.Parameters.AddWithValue("@SoTienGui", SoGui);
                else
                    MessageBox.Show("Số tiền gửi chưa đủ để mở sổ");
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
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "UPDATE PhieuGuiTien SET  KhachHang  =@KhachHang, NgayGui=@NgayGui, SoTienGui =@SoTienGui WHERE MaSo =@MaSo";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            sqlcomd.Parameters.AddWithValue("@KhachHang", KhachHang);
            sqlcomd.Parameters.AddWithValue("@NgayGui", NgayGui);
            if (SoGui >= SoTien)
                sqlcomd.Parameters.AddWithValue("@SoTienGui", SoGui);
            else
                MessageBox.Show("Số tiền gửi chưa đủ để mở sổ ");
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "DELETE FROM PhieuGuiTien WHERE MaSo = @MaSo";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhieuGuiTien ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;

        }
    }
}
