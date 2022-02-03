using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QUANLY1
{
    class BaoCaoChi
    {
        private string maso;
        private string loaitietkie;
        private DateTime ngay;
        private float tongchi;

        #region Properties
        public string MaSo { get => maso; set => maso = value; }
        public string LoaiTietKie { get => loaitietkie; set => loaitietkie = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public float TongChi { get => tongchi; set => tongchi = value; }
        #endregion

        public void Insert()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "INSERT INTO BaoCaochi VALUES(@MaSo, @LoaiTietKiem, @Ngay, @Tongchi)";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@Ngay", Ngay);
                sqlcomd.Parameters.AddWithValue("@LoaiTietKiem", LoaiTietKie);               
                sqlcomd.Parameters.AddWithValue("@Tongchi", TongChi);
                conn.Open();
                sqlcomd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !", "Thông báo");
            }

        }
        public void Update9()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "UPDATE BaoCaochi SET Ngay = @Ngay,Tongchi = @Tongchi, LoaiTietKiem = @LoaiTietKiem WHERE MaSo = @MaSo";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@Ngay", Ngay);
                sqlcomd.Parameters.AddWithValue("@LoaiTietKiem", LoaiTietKie);                
                sqlcomd.Parameters.AddWithValue("@Tongchi", TongChi);
                conn.Open();
                sqlcomd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sừa được, Lỗi rồi !", "Thông báo");
            }
        }
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BaoCaochi ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public static DataTable GetData1()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True"); 
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SoTietKiem ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}
