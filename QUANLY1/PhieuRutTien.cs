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
    class PhieuRutTien
    {
        private string maso;
        private float sorut;
        private DateTime ngayrut;
        private string khachang;

        #region Properties
        public string MaSo { get => maso; set => maso = value; }
        public float SoRut { get => sorut; set => sorut = value; }
        public string KhachHang { get => khachang; set => khachang = value; }
        public DateTime NgayRut { get => ngayrut; set => ngayrut = value; }
        #endregion Properties

        public void Insert()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "INSERT INTO PhieuRutTien VALUES (@MaSo, @KhachHang, @NgayRut, @SoTienRut)";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@KhachHang", KhachHang);
                sqlcomd.Parameters.AddWithValue("@NgayRut", NgayRut);
                sqlcomd.Parameters.AddWithValue("@SoTienRut", SoRut);
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
            sqlcomd.CommandText = "UPDATE PhieuRutTien SET  KhachHang  =@KhachHang, NgayRut=@NgayRut, SoTienRut =@SoTienRut WHERE MaSo =@MaSo";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            sqlcomd.Parameters.AddWithValue("@KhachHang", KhachHang);
            sqlcomd.Parameters.AddWithValue("@NgayRut", NgayRut);
            sqlcomd.Parameters.AddWithValue("@SoTienRut", SoRut);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "DELETE FROM PhieuRutTien WHERE MaSo = @MaSo";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhieuRutTien ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}
