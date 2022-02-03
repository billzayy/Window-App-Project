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
    class ThoiGian
    {
        private string ngay;

        private string maso;
        public string MaSo { get => maso; set => maso = value; }
        public string Ngay { get => ngay; set => ngay = value; }

        public void Update()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "UPDATE ThoiGian Set Ngay = @Ngay WHERE MaSo = @MaSo ";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            sqlcomd.Parameters.AddWithValue("@Ngay", Ngay);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ThoiGian ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}
