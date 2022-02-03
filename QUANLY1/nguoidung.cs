using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QUANLY1
{
    class nguoidung
    {
        private string maTk;
        private string matkhau;
        private string loaiTK;

        #region Properties
        public string MaTk { get => maTk; set => maTk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string LoaiTK { get => loaiTK; set => loaiTK = value; }
        #endregion

        static SqlConnection conn = new SqlConnection(@"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True");

        public bool KiemtraTK()
        {
            string sql = "SELECT * FROM DANGNHAP WHERE Dangnhap = @Dangnhap and Matkhau =  @Matkhau and LoaiTK = @LoaiTK ";
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.CommandText = sql;
            sqlcomd.Connection = conn;
            sqlcomd.Parameters.AddWithValue("@Dangnhap", MaTk);
            sqlcomd.Parameters.AddWithValue("@Matkhau", Matkhau);
            sqlcomd.Parameters.AddWithValue("@LoaiTK", LoaiTK);
            SqlDataAdapter da = new SqlDataAdapter(sqlcomd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            if (tb.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
