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
    class LoaiTK
    {
        private string maso;
        private string loaitk;
        public double phantr;

        #region Properties
        public double PhanTR { get => phantr; set => phantr = value; }
        public string MaSo { get => maso; set => maso = value; }
        public string LoaiTk { get => loaitk; set => loaitk = value; }
        #endregion

        public void Insert()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "INSERT INTO LOAITK VALUES(@MaSo, @LoaiTk, @PhanTr)";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            sqlcomd.Parameters.AddWithValue("@LoaiTk", LoaiTk);
            sqlcomd.Parameters.AddWithValue("@PhanTr", PhanTR);                       
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "UPDATE LOAITK SET LoaiTk = @LoaiTk, PhanTr =@PhanTr WHERE MaSo = @MaSo ";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            sqlcomd.Parameters.AddWithValue("@LoaiTk", LoaiTk);
            sqlcomd.Parameters.AddWithValue("@PhanTr", PhanTR);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.Connection = conn;
            sqlcomd.CommandText = "DELETE FROM LOAITK WHERE MaSo = @MaSo";
            sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
            conn.Open();
            sqlcomd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAITK ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}
