using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QUANLY1
{
    class SoTien
    {
        private float sotien;

        public float Sotien { get => sotien; set => sotien = value; }

        public void Insert()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "INSERT INTO SoTien VALUES(@SoTienTt)";
            sqlcomd.Parameters.AddWithValue("@SoTienTt", Sotien);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "UPDATE SoTien Set SoTienTt = @SoTienTt ";
            sqlcomd.Parameters.AddWithValue("@SoTienTt", Sotien);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SoTien ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}
