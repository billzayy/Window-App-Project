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
    class BaoCaoThu 
    {
        private string maso;
        private string loaitietkie;
        private string loaitietkiem;
        private float tongthu;
        private float sotiengui;
        private float sogui;
        private DateTime ngay;
        private DateTime ngaymoso;
        private DateTime ngaygui;

        #region Properties
        public DateTime NgayGui { get => ngaygui; set => ngaygui = value; }//
        public float SoGui { get => sogui; set => sogui = value; }
        public string MaSo { get => maso; set => maso = value; }
        public string LoaiTietKie { get => loaitietkie; set => loaitietkie = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public float TongThu { get => tongthu; set => tongthu = value; }

        public DateTime NgayMoSo { get => ngaymoso; set => ngaymoso = value; }
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
                sqlcomd.CommandText = "INSERT INTO BaoCaothu VALUES(@MaSo, @LoaiTietKiem, @Ngay, @TongThu)";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@Ngay", Ngay);                  
                sqlcomd.Parameters.AddWithValue("@LoaiTietKiem", LoaiTietKie);
                sqlcomd.Parameters.AddWithValue("@TongThu", TongThu);              
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
                sqlcomd.CommandText = "UPDATE BaoCaothu SET Ngay = @Ngay,Tongthu = @TongThu, LoaiTietKiem = @LoaiTietKiem WHERE MaSo = @MaSo";
                sqlcomd.Parameters.AddWithValue("@MaSo", MaSo);
                sqlcomd.Parameters.AddWithValue("@Ngay", Ngay);
                if (NgayMoSo == Ngay)
                {
                    sqlcomd.Parameters.AddWithValue("@LoaiTietKiem", LoaiTietKie);
                    if (LoaiTietKiem == LoaiTietKie)
                    {
                        sqlcomd.Parameters.AddWithValue("@TongThu", TongThu);
                    }
                    else
                        MessageBox.Show("Loại tiết kiệm không giống nhau !!");
                }
                else
                    MessageBox.Show("Ngày mở sổ và ngày tính không giống nhau !!");
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BaoCaothu ", conn);
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

