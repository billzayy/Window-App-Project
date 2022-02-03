using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Globalization;
namespace QUANLY1
{
    public partial class Bao_cao : Form
    {
        string strConnectionString = @"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTableName = null;
        DataTable dtTableName = null;
        public Bao_cao()
        {
            InitializeComponent();
            dataGridView3.DataSource = SoTietKiem.GetData();
            dataGridView7.DataSource = BaoCaoThu.GetData();
            dataGridView4.DataSource = BCDanhSachHoatDong.GetData();
            dataGridView1.DataSource = BCDanhSachHoatDong.GetData();
            
            LoadData1();
            LoadData2();
            LoadData3();
            PHOMRONG();
            PHOMRONG5();
        }
        #region LoadData
        private void LoadData1()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from SoTietKiem", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView3.DataSource = dtTableName;
        }
        private void LoadData2()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from BaoCaothu", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView7.DataSource = dtTableName;
        }
        private void LoadData3()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from BaoCaochi", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView8.DataSource = dtTableName;
        }
        #endregion

        #region ChinhDataGridView
        public void PHOMRONG()
        {
            dataGridView3.Columns[0].Width = 110;
            dataGridView3.Columns[1].Width = 140;
            dataGridView3.Columns[2].Width = 180;
            dataGridView3.Columns[3].Width = 290;
            dataGridView3.Columns[4].Width = 160;
            dataGridView3.Columns[5].Width = 160;
            dataGridView3.Columns[6].Width = 140;
        }
        public void PHOMRONG5()
        {
            dataGridView1.Columns[0].Width = 280;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 290;
            dataGridView1.Columns[3].Width = 200;
        }
        #endregion

        #region BCSoTietKiem
        private void Bao_cao_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.frmBC = null;
        }

        private void button_timkiemsotietkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM SoTietKiem WHERE MaSo = @MaSo";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@MaSo", textBox_Masotiet.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)

            {
                string dir = folder.SelectedPath;

                _Application app = new Microsoft.Office.Interop.Excel.Application();

                _Workbook workbook = app.Workbooks.Add(Type.Missing);

                _Worksheet worksheet = null;

                worksheet = workbook.Sheets["Sheet1"];

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Exported from gridview";

                for (int i = 1; i < dataGridView3.Columns.Count + 1; i++)

                    worksheet.Cells[1, i] = dataGridView3.Columns[i - 1].HeaderText;

                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)

                {
                    for (int j = 0; j < dataGridView3.Columns.Count; j++)

                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView3.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(dir + "output.xlsx");

                app.Quit();
            }
        }
        #endregion

        #region BCDoanhThuHanhNgay
        private void dataGridView7_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count > 0)
            {
                int i = dataGridView7.SelectedRows[0].Index;
                textBox_Masogui2.Text = dataGridView7.Rows[i].Cells[0].Value.ToString();
                comboBox_loaitietkiemguitong.Text = dataGridView7.Rows[i].Cells[1].Value.ToString();
                textBox_tongtienthugui.Text = dataGridView7.Rows[i].Cells[3].Value.ToString();               
                dateTimePicker7.Value = DateTime.Parse(dataGridView7.Rows[i].Cells[2].Value.ToString());
            }
        }
        private void button1_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM BaoCaothu WHERE Ngay = @Ngay";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker2.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView7.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void dataGridView8_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView8.SelectedRows.Count > 0)
            {
                int i = dataGridView8.SelectedRows[0].Index;
                textBox1_MaSochi.Text = dataGridView8.Rows[i].Cells[0].Value.ToString();
                comboBox1_loaitietkiemchi.Text = dataGridView8.Rows[i].Cells[1].Value.ToString();
                textBox2_tongchi.Text = dataGridView8.Rows[i].Cells[3].Value.ToString();
                dateTimePicker8.Value = DateTime.Parse(dataGridView8.Rows[i].Cells[2].Value.ToString());
            }
        }

        private void button1_timkiwmthu_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM BaoCaochi WHERE Ngay = @Ngay";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker4.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView8.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
            conn.Close();
        }
     
        private void button1_tinh_Click(object sender, EventArgs e)
        {
            BaoCaoChi s = new BaoCaoChi();
            BaoCaoThu a =  new BaoCaoThu();
            BCDanhSachHoatDong x = new BCDanhSachHoatDong();

            s.LoaiTietKie = comboBox_loaitietkiemguitong.Text;
            s.Ngay = dateTimePicker7.Value;
            s.TongChi = float.Parse(textBox2_tongchi.Text);
            a.LoaiTietKie = comboBox1_loaitietkiemchi.Text;
            a.Ngay = dateTimePicker8.Value;
            a.TongThu = float.Parse(textBox_tongtienthugui.Text);

            if (s.Ngay == a.Ngay)
            {
                if (s.LoaiTietKie == a.LoaiTietKie)
                {
                    x.Ngay = dateTimePicker5.Value;
                    textBox1_loaitk.Text = s.LoaiTietKie.ToString();
                    x.loaiTK = textBox1_loaitk.Text;
                    textBox2_tongthu.Text = a.TongThu.ToString();
                    x.TongThu = float.Parse(textBox2_tongthu.Text);
                    textBox3_tongchi.Text = s.TongChi.ToString();
                    x.TongChi = float.Parse(textBox2_tongchi.Text);
                    x.Chenhlech = a.TongThu - s.TongChi;
                    tb_tongchi.Text = x.Chenhlech.ToString();
                    x.Chenhlech = float.Parse(tb_tongchi.Text);
                }
                else

                    MessageBox.Show("Loại tiết kiệm không giống nhau", "Thông báo");
            }
            else
                MessageBox.Show("Ngày tính của tồng chi và tổng thu không giống nhau ", "Thông báo");
        }

        private void button3_luu_Click(object sender, EventArgs e)
        {
            BCDanhSachHoatDong x = new BCDanhSachHoatDong();
            x.Ngay = dateTimePicker5.Value;
            x.loaiTK = textBox1_loaitk.Text;
            x.TongThu = float.Parse(textBox2_tongthu.Text);
            x.TongChi = float.Parse(textBox2_tongchi.Text);
            x.Chenhlech = float.Parse(tb_tongchi.Text);
            x.Insert();
            dataGridView4.DataSource = BCDanhSachHoatDong.GetData();
        }
        #endregion

        #region BCDoanhThuNgay
        private void button2_timkiemngay_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM BCDanhSachHDNgay WHERE Ngay = @Ngay";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker1.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
            conn.Close();
        }

        private void button1_bai_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                string dir = folder.SelectedPath;

                _Application app = new Microsoft.Office.Interop.Excel.Application();

                _Workbook workbook = app.Workbooks.Add(Type.Missing);

                _Worksheet worksheet = null;

                worksheet = workbook.Sheets["Sheet1"];

                worksheet = workbook.ActiveSheet;
   
                worksheet.Name = "Exported from gridview";
  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)

                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(dir + "output.xlsx");

                app.Quit();

            }
        }
        #endregion
    }
}
