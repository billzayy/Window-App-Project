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
    class BCDanhSachHoatDong
    {
        private string loaitk;
        private DateTime ngay;
        private float tongthu;
        private float tongchi;
        private float chenhlech;

        #region Properties
        public string loaiTK { get => loaitk; set => loaitk = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public float TongThu { get => tongthu; set => tongthu = value; }
        public float Chenhlech { get => chenhlech; set => chenhlech = value; }
        public float TongChi { get => tongchi; set => tongchi = value; }
        #endregion

        public void Insert()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True"); 
                SqlCommand sqlcomd = new SqlCommand();
                sqlcomd.Connection = conn;
                sqlcomd.CommandText = "INSERT INTO BCDanhSachHDNgay VALUES (@LoaiTietKiem, @Ngay, @TongThu, @TongChi, @Chechlech)";
                sqlcomd.Parameters.AddWithValue("@LoaiTietKiem", loaiTK);
                sqlcomd.Parameters.AddWithValue("@Ngay", Ngay);
                sqlcomd.Parameters.AddWithValue("@TongThu", TongThu);              
                sqlcomd.Parameters.AddWithValue("@TongChi", TongChi);
                sqlcomd.Parameters.AddWithValue("@Chechlech", Chenhlech);
                conn.Open();
                sqlcomd.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi !", "Thông báo");
            }
        }
        public static DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BCDanhSachHDNgay ", conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;

        }
    }
}
