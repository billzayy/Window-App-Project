using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QUANLY1
{
    public partial class Form2 : Form
    {
        string strConnectionString = @"Data Source=BILL\BILLZAY;Initial Catalog=Saving_Money;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daTableName = null;
        DataTable dtTableName = null;
        #region Form2
        public Form2()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
            LoadData2();
            LoadData3();
            LoadData9();
            PHOMRONG();
            PHOMRONG1();
            PHOMRONG2();
            PHOMRONG3();

            dataGridView1.DataSource = SoTietKiem.GetData();
            dataGridView2.DataSource = PhieuGuiTien.GetData();
            dataGridView3.DataSource = PhieuRutTien.GetData();
            dataGridView5.DataSource = SoTietKiem.GetData();
            
            comboBox_Loaitietkiem.ValueMember = "MaSo";
            comboBox_Loaitietkiem.DisplayMember = "LoaiTK";
            DataSet1.LOAITKDataTable b = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter a = new DataSet1TableAdapters.LOAITKTableAdapter();
            b.Reset();
            a.Fill(b);
            comboBox_Loaitietkiem.DataSource = b;

            comboBox1_loaitietkiemrut.ValueMember = "MaSo";
            comboBox1_loaitietkiemrut.DisplayMember = "LoaiTK";
            DataSet1.LOAITKDataTable c = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter d = new DataSet1TableAdapters.LOAITKTableAdapter();
            c.Reset();
            d.Fill(c);
            comboBox1_loaitietkiemrut.DataSource = c;
            
            comboBox1_loaitietkiemtongthu.ValueMember = "MaSo";
            comboBox1_loaitietkiemtongthu.DisplayMember = "LoaiTK";
            DataSet1.LOAITKDataTable w = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter r = new DataSet1TableAdapters.LOAITKTableAdapter();
            w.Reset();
            r.Fill(w);
            comboBox1_loaitietkiemtongthu.DataSource = w;
            
            comboBox_loaitietkiemguitong.ValueMember = "MaSo";
            comboBox_loaitietkiemguitong.DisplayMember = "LoaiTK";
            DataSet1.LOAITKDataTable l = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter u = new DataSet1TableAdapters.LOAITKTableAdapter();
            l.Reset();
            u.Fill(l);
            comboBox_loaitietkiemguitong.DataSource = l;

            comboBox1_loaitietkiemchi.ValueMember = "MaSo";
            comboBox1_loaitietkiemchi.DisplayMember = "LoaiTK";
            DataSet1.LOAITKDataTable o = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter f = new DataSet1TableAdapters.LOAITKTableAdapter();
            o.Reset();
            f.Fill(o);
            comboBox1_loaitietkiemchi.DataSource = o;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.baoCaothuTableAdapter.Fill(this.saving_MoneyDataSet7.BaoCaothu);
            this.soTietKiemTableAdapter6.Fill(this.saving_MoneyDataSet6.SoTietKiem);

            comboBox_sotientoithieu.DataSource = SoTien.GetData();
            comboBox_sotientoithieu.DisplayMember = "SoTienTt";

            comboBox_sotienguitoithieu.DataSource = SoTien.GetData();
            comboBox_sotienguitoithieu.DisplayMember = "SoTienTt";

            comboBox1_thaydoingay.DataSource = ThoiGian.GetData();
            comboBox1_thaydoingay.DisplayMember = "Ngay";
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.frm = null;
        }
        #endregion
        #region LoadData
        private void LoadData1()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from SoTietKiem", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView4.DataSource = dtTableName;
        }

        private void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from SoTietKiem", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView5.DataSource = dtTableName;
        }
        private void LoadData2()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from BaoCaothu", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView6.DataSource = dtTableName;
        }
        private void LoadData3()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from BaoCaothu", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView7.DataSource = dtTableName;
        }
        private void LoadData9()
        {
            conn = new SqlConnection(strConnectionString);
            daTableName = new SqlDataAdapter("select *from BaoCaochi", conn);
            dtTableName = new DataTable();
            daTableName.Fill(dtTableName);
            dataGridView8.DataSource = dtTableName;
        }
        #endregion
        #region ChinhFormData
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 240;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 150;
        }
        public void PHOMRONG1()
        {
            dataGridView2.Columns[0].Width = 90;
            dataGridView2.Columns[1].Width = 170;
            dataGridView2.Columns[2].Width = 145;
            dataGridView2.Columns[3].Width = 140;
        }
        public void PHOMRONG2()
        {
            dataGridView3.Columns[0].Width = 90;
            dataGridView3.Columns[1].Width = 160;
            dataGridView3.Columns[2].Width = 140;
            dataGridView3.Columns[3].Width = 125;
        }
        public void PHOMRONG3()
        {
            dataGridView7.Columns[0].Width = 50;
            dataGridView7.Columns[1].Width = 125;
            dataGridView7.Columns[2].Width = 130;
        }
        #endregion

        #region SoTietKiem
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                textBox_Masotiet.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                tb_CMND.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                tb_Khachhang.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                tb_DiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                comboBox_Loaitietkiem.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                tb_SoTien.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
        }
        private void dataGridView6_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                int i = dataGridView6.SelectedRows[0].Index;
                textBox_MaSothu.Text = dataGridView6.Rows[i].Cells[2].Value.ToString();//
                comboBox1_loaitietkiemtongthu.Text = dataGridView6.Rows[i].Cells[1].Value.ToString();//
                tb_thu.Text = dataGridView6.Rows[i].Cells[3].Value.ToString();//
                dateTimePicker6.Value = DateTime.Parse(dataGridView6.Rows[i].Cells[0].Value.ToString());//
            }
        }

        private void comboBox1_loaitietkiemtongthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1.LOAITKDataTable w = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter r = new DataSet1TableAdapters.LOAITKTableAdapter();
            w.Reset();
            w = r.LOAITK_SET(int.Parse(comboBox1_loaitietkiemtongthu.SelectedValue.ToString()));
            string thongtin = w.Rows[0]["LoaiTK"].ToString();
            comboBox1_loaitietkiemtongthu.Text = thongtin.ToString();
        }
        private void comboBox_Loaitietkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1.LOAITKDataTable b = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter a = new DataSet1TableAdapters.LOAITKTableAdapter();
            b.Reset();
            b = a.LOAITK_SET(int.Parse(comboBox_Loaitietkiem.SelectedValue.ToString()));
            string thongtin = b.Rows[0]["PhanTr"].ToString();
            textBox1_phantram.Text = thongtin.ToString();
        }

        private void button_thuchien_Click(object sender, EventArgs e)
        {
            SoTietKiem s = new SoTietKiem();

            s.MaSo = textBox_Masotiet.Text;
            s.KhachHang = tb_Khachhang.Text;
            s.NgayMoSo = dateTimePicker1.Value;
            s.CMND = tb_CMND.Text;
            s.DiaChi = tb_DiaChi.Text;
            s.SoTien = float.Parse(comboBox_sotientoithieu.Text);
            s.SoTienGui = float.Parse(tb_SoTien.Text);
            s.LoaiTietKiem = comboBox_Loaitietkiem.Text;

            s.Insert();
            dataGridView1.DataSource = SoTietKiem.GetData();
        }
        private void button_nhaplai_Click(object sender, EventArgs e)
        {
            SoTietKiem s = new SoTietKiem();

            s.MaSo = textBox_Masotiet.Text;
            s.KhachHang = tb_Khachhang.Text;
            s.NgayMoSo = dateTimePicker1.Value;
            s.CMND = tb_CMND.Text;
            s.DiaChi = tb_DiaChi.Text;
            s.SoTien = float.Parse(comboBox_sotientoithieu.Text);
            s.SoTienGui = float.Parse(tb_SoTien.Text);
            s.LoaiTietKiem = comboBox_Loaitietkiem.Text;

            s.Update();
            dataGridView1.DataSource = SoTietKiem.GetData();
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            SoTietKiem s = new SoTietKiem();

            s.MaSo = textBox_Masotiet.Text;

            s.Delete();
            dataGridView1.DataSource = SoTietKiem.GetData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BaoCaoThu t = new BaoCaoThu();
            SoTietKiem s = new SoTietKiem();

            s.NgayMoSo = dateTimePicker1.Value;
            s.LoaiTietKiem = comboBox_Loaitietkiem.Text;

            t.MaSo = textBox_MaSothu.Text;
            t.Ngay = dateTimePicker6.Value;
            t.LoaiTietKie = comboBox1_loaitietkiemtongthu.Text;
            t.TongThu = 0;

            t.Insert();
            dataGridView6.DataSource = BaoCaoThu.GetData();
        }
        private void button2_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM BaoCaothu WHERE Ngay = @Ngay";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker6.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView6.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoTietKiem s = new SoTietKiem();
            BaoCaoThu t = new BaoCaoThu();
            float tong;

            s.MaSo = textBox_Masotiet.Text;
            s.KhachHang = tb_Khachhang.Text;
            s.NgayMoSo = dateTimePicker1.Value;
            s.CMND = tb_CMND.Text;
            s.DiaChi = tb_DiaChi.Text;
            s.SoTien = float.Parse(comboBox_sotientoithieu.Text);
            s.SoTienGui = float.Parse(tb_SoTien.Text);
            s.SoTien = float.Parse(comboBox_sotientoithieu.Text);
            t.NgayMoSo = dateTimePicker1.Value;
            t.SoTienGui = float.Parse(tb_SoTien.Text);
            t.LoaiTietKiem = comboBox_Loaitietkiem.Text;
            t.MaSo = textBox_MaSothu.Text;
            t.LoaiTietKie = comboBox1_loaitietkiemtongthu.Text;
            t.Ngay = dateTimePicker6.Value;
            t.TongThu = float.Parse(tb_thu.Text);

            tong = t.TongThu + s.SoTienGui;
            tb_thu.Text = tong.ToString();

            t.Update();
            dataGridView6.DataSource = BaoCaoThu.GetData();
        }
        #endregion

        #region PhieuGuiTien
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int i = dataGridView2.SelectedRows[0].Index;
                textBox_maso.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
                TB_khachhang2.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                dateTimePicker2.Value = DateTime.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
                tb_sotiengui2.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            }
        }
        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                int i = dataGridView4.SelectedRows[0].Index;
                textBox1_maso.Text = dataGridView4.Rows[i].Cells[0].Value.ToString();
                tb_cmnddd.Text = dataGridView4.Rows[i].Cells[1].Value.ToString();
                textBox13_khachhang.Text = dataGridView4.Rows[i].Cells[2].Value.ToString();
                textBox1_diachi.Text = dataGridView4.Rows[i].Cells[5].Value.ToString();
                tb_laoitietliem.Text = dataGridView4.Rows[i].Cells[3].Value.ToString();
                textBox_soguitien.Text = dataGridView4.Rows[i].Cells[4].Value.ToString();
                dateTimePicker4.Value = DateTime.Parse(dataGridView4.Rows[i].Cells[6].Value.ToString());
            }
        }
        private void dataGridView7_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count > 0)
            {
                int i = dataGridView7.SelectedRows[0].Index;
                textBox_Masogui2.Text = dataGridView7.Rows[i].Cells[0].Value.ToString();//
                comboBox_loaitietkiemguitong.Text = dataGridView7.Rows[i].Cells[1].Value.ToString();//
                textBox_tongtienthugui.Text = dataGridView7.Rows[i].Cells[3].Value.ToString();//
                dateTimePicker7.Value = DateTime.Parse(dataGridView7.Rows[i].Cells[2].Value.ToString());//
            }
        }

        private void comboBox_loaitietkiemguitong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1.LOAITKDataTable l = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter u = new DataSet1TableAdapters.LOAITKTableAdapter();
            l.Reset();
            l = u.LOAITK_SET(int.Parse(comboBox_loaitietkiemguitong.SelectedValue.ToString()));
            string thongtin = l.Rows[0]["LoaiTK"].ToString();
            comboBox_loaitietkiemguitong.Text = thongtin.ToString();
        }

        private void tb_thuchien2_Click_1(object sender, EventArgs e)
        {
            PhieuGuiTien c = new PhieuGuiTien();
            SoTietKiem s = new SoTietKiem();
            c.MaSo = textBox_maso.Text;
            c.KhachHang = TB_khachhang2.Text;
            c.NgayGui = dateTimePicker2.Value;
            s.LoaiTietKiem = tb_laoitietliem.Text;
            c.SoTien = float.Parse(comboBox_sotientoithieu.Text);
            if (s.LoaiTietKiem == "Không kỳ hạn")
            {
                s.SoTien = float.Parse(comboBox_sotientoithieu.Text);
                c.SoGui = float.Parse(tb_sotiengui2.Text);
            }
            else
                MessageBox.Show("Chỉ có loại tiết kiệm không kỳ hạn mới gửi ");                                 
            
            c.Insert();
            dataGridView2.DataSource = PhieuGuiTien.GetData();
        }
        private void bt_nhaplai2_Click_1(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thật sự muốn muốn sửa lại mạ số : " + textBox_maso.Text + " !!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                return;
            SoTietKiem s = new SoTietKiem();
            PhieuGuiTien c = new PhieuGuiTien();
            c.MaSo = textBox_maso.Text;
            c.KhachHang = TB_khachhang2.Text;
            c.NgayGui = dateTimePicker2.Value;
            c.SoTien = float.Parse(comboBox_sotientoithieu.Text);
            s.Sotien = float.Parse(comboBox_sotientoithieu.Text);//
            c.SoGui = float.Parse(tb_sotiengui2.Text);
            c.Update();
            dataGridView2.DataSource = PhieuGuiTien.GetData();
        }
        private void bt_xoa2_Click_1(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thật sự muốn xóa khách hàng có mã số là : " + textBox_maso.Text + " và có tên là : " + TB_khachhang2.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                return;
            PhieuGuiTien c = new PhieuGuiTien();
            c.MaSo = textBox_maso.Text;
            c.Delete();
            dataGridView2.DataSource = PhieuGuiTien.GetData();
        }
        private void button3_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM BaoCaothu WHERE Ngay = @Ngay";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker7.Text);
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
        private void button_tinh_Click(object sender, EventArgs e)
        {
            SoTietKiem s = new SoTietKiem();
            PhieuGuiTien c = new PhieuGuiTien();

            s.MaSo = textBox1_maso.Text;
            s.KhachHang = textBox13_khachhang.Text;
            s.NgayMoSo = dateTimePicker4.Value;
            s.CMND = tb_cmnddd.Text;
            s.DiaChi = textBox1_diachi.Text;
            s.LoaiTietKiem = tb_laoitietliem.Text;
            s.SoTienGui = float.Parse(textBox_soguitien.Text);
            s.SoTienGui = float.Parse(textBox_tong.Text);
            c.SoGui = float.Parse(tb_sotiengui2.Text);

            double tongtien;
            tongtien = (s.SoTienGui + c.SoGui);
            textBox_tong.Text = tongtien.ToString();

            s.Update();
            dataGridView4.DataSource = SoTietKiem.GetData();
        }
        private void button_Moso_Click(object sender, EventArgs e)
        {
            BaoCaoThu t = new BaoCaoThu();

            t.MaSo = textBox_Masogui2.Text;
            t.Ngay = dateTimePicker7.Value;
            t.LoaiTietKie = comboBox_loaitietkiemguitong.Text;
            t.TongThu = 0;

            t.Insert();
            dataGridView7.DataSource = BaoCaoThu.GetData();
        }
        private void button_timkiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM SoTietKiem WHERE MaSo = @MaSo";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@MaSo", textBox1_timkiem.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView4.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
            conn.Close();
        }
        private void button3_thunghiem_Click(object sender, EventArgs e)
        {
            BaoCaoThu t = new BaoCaoThu();
            PhieuGuiTien c = new PhieuGuiTien();
            SoTietKiem s = new SoTietKiem();

            c.NgayGui = dateTimePicker2.Value;
            s.LoaiTietKiem = tb_laoitietliem.Text;
            t.LoaiTietKiem = tb_laoitietliem.Text;

            t.NgayMoSo = dateTimePicker2.Value;
            t.Ngay = dateTimePicker7.Value;
            c.SoTien = float.Parse(comboBox_sotientoithieu.Text);
            if (s.LoaiTietKiem == "Không kỳ hạn")
            {

                c.SoGui = float.Parse(tb_sotiengui2.Text);
                t.SoGui = float.Parse(tb_sotiengui2.Text);
                float tong;
                t.MaSo = textBox_Masogui2.Text;
                t.LoaiTietKie = comboBox_loaitietkiemguitong.Text;
                t.TongThu = float.Parse(textBox_tongtienthugui.Text);
                tong = t.TongThu + c.SoGui;
                textBox_tongtienthugui.Text = tong.ToString();
                t.TongThu = float.Parse(textBox_tongtienthugui.Text);
            }
            else
                MessageBox.Show("Chỉ có loại tiết kiệm không kỳ hạn mới gửi ");
            t.Update();
            dataGridView7.DataSource = BaoCaoThu.GetData();
        }
        #endregion

        #region PhieuRutTien
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int i = dataGridView3.SelectedRows[0].Index;
                tb_Maso3.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
                tb_khachhang3.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
                dateTimePicker3.Value = DateTime.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString());
                tb_sotienrut3.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            }
        }
        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                int i = dataGridView5.SelectedRows[0].Index;
                textBox_Masoryt.Text = dataGridView5.Rows[i].Cells[0].Value.ToString();
                textBox_cmndryt.Text = dataGridView5.Rows[i].Cells[1].Value.ToString();
                textBox_khachhangryt.Text = dataGridView5.Rows[i].Cells[2].Value.ToString();
                textBox_diachiryt.Text = dataGridView5.Rows[i].Cells[3].Value.ToString();
                comboBox1_loaitietkiemrut.Text = dataGridView5.Rows[i].Cells[4].Value.ToString();
                textBox_sotienryt.Text = dataGridView5.Rows[i].Cells[5].Value.ToString();
                dateTimePicker5.Value = DateTime.Parse(dataGridView5.Rows[i].Cells[6].Value.ToString());
            }
        }
        private void dataGridView8_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView8.SelectedRows.Count > 0)
            {
                int i = dataGridView8.SelectedRows[0].Index;
                textBox1_MaSochi.Text = dataGridView8.Rows[i].Cells[0].Value.ToString();//
                comboBox1_loaitietkiemchi.Text = dataGridView8.Rows[i].Cells[1].Value.ToString();//
                textBox2_tongchi.Text = dataGridView8.Rows[i].Cells[3].Value.ToString();//
                dateTimePicker8.Value = DateTime.Parse(dataGridView8.Rows[i].Cells[2].Value.ToString());//
            }
        }

        private void comboBox1_loaitietkiemrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1.LOAITKDataTable c = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter d = new DataSet1TableAdapters.LOAITKTableAdapter();
            c.Reset();
            c = d.LOAITK_SET(int.Parse(comboBox1_loaitietkiemrut.SelectedValue.ToString()));
            string thongtin = c.Rows[0]["PhanTr"].ToString();
            textBox_laixuatrut.Text = thongtin.ToString();
        }
        private void comboBox1_loaitietkiemchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet1.LOAITKDataTable o = new DataSet1.LOAITKDataTable();
            DataSet1TableAdapters.LOAITKTableAdapter f = new DataSet1TableAdapters.LOAITKTableAdapter();
            o.Reset();
            o = f.LOAITK_SET(int.Parse(comboBox1_loaitietkiemchi.SelectedValue.ToString()));
            string thongtin = o.Rows[0]["LoaiTK"].ToString();
            comboBox1_loaitietkiemchi.Text = thongtin.ToString();
        }

        private void bt_thuchien3_Click(object sender, EventArgs e)
        {
            SoTietKiem s = new SoTietKiem();
            PhieuRutTien c = new PhieuRutTien();

            s.MaSo = textBox_Masoryt.Text;
            s.KhachHang = textBox_khachhangryt.Text;
            s.CMND = textBox_cmndryt.Text;
            s.DiaChi = textBox_diachiryt.Text;
            s.SoTienGui = float.Parse(textBox_sotienryt.Text);
            s.LoaiTietKiem = comboBox1_loaitietkiemrut.Text;
            s.NgayMoSo = dateTimePicker3.Value;

            c.MaSo = tb_Maso3.Text;
            c.KhachHang = tb_khachhang3.Text;
            c.NgayRut = dateTimePicker3.Value;
            c.SoRut = float.Parse(tb_sotienrut3.Text);

            c.Insert();
            dataGridView3.DataSource = PhieuRutTien.GetData();
        }
        private void bt_NhapLai3_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thật sự muốn muốn sửa lại mạ số :  " + tb_Maso3.Text + " !!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                return;
            PhieuRutTien c = new PhieuRutTien();
            c.MaSo = tb_Maso3.Text;
            c.KhachHang = tb_khachhang3.Text;
            c.NgayRut = dateTimePicker3.Value;
            c.SoRut = float.Parse(tb_sotienrut3.Text);
            c.Update();
            dataGridView3.DataSource = PhieuRutTien.GetData();
        }
        private void button_timkiemru_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM SoTietKiem WHERE MaSo = @MaSo";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@MaSo", textBox_timkiemrut.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView5.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm được, Lỗi rồi !");
            }
            conn.Close();
        }
        private void button1_tienlai3thang_Click(object sender, EventArgs e)
        {
            float phantram;
            double tongtien = 0;
            PhieuRutTien c = new PhieuRutTien();
            SoTietKiem s = new SoTietKiem();
            phantram = float.Parse(textBox_laixuatrut.Text);
            double songaythue;
            if (dateTimePicker3.Text == dateTimePicker5.Text)
                songaythue = 1;
            else
            {
                TimeSpan giatri = dateTimePicker3.Value - dateTimePicker5.Value;
                songaythue = Math.Round(giatri.TotalDays, 0);
                textBox_tienlai.Text = songaythue.ToString();
            }
            int ngay;
            ngay = Int32.Parse(comboBox1_thaydoingay.Text);
            //
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 2 tháng")
            {

                if (songaythue >= 60)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365));
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 3 tháng")
            {

                if (songaythue >= 90)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365));
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 6 tháng")
            {
                if (songaythue >= 180)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365));
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 9 tháng")
            {
                if (songaythue >= 270)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 100) * (songaythue / 365));
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 12 tháng")
            {
                if (songaythue >= 365)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365));
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 18 tháng")
            {
                if (songaythue >= 545)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365));
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 24 tháng")
            {
                if (songaythue >= 730)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365));
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //
            if (comboBox1_loaitietkiemrut.Text == "Không kỳ hạn")
            {
                if (songaythue >= ngay)
                {
                    if (songaythue >= 20)
                    {
                        s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                        tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365));
                        tb_sotienrut3.Text = tongtien.ToString();
                        c.SoRut = float.Parse(tb_sotienrut3.Text);
                    }
                    else
                        MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Chưa qua kỳ hạn mở sổ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button_hoantat_Click(object sender, EventArgs e)
        {
            float phantram;
            phantram = float.Parse(textBox_laixuatrut.Text);
            int ngay;
            ngay = Int32.Parse(comboBox1_thaydoingay.Text);
            float tongtiencontrong = 0;
            double tongtien = 0;
            PhieuRutTien c = new PhieuRutTien();
            SoTietKiem s = new SoTietKiem();
            //luongthang = Convert.ToInt32(comboBox1_loaitietkiem.Text);
            double songaythue;
            if (dateTimePicker3.Text == dateTimePicker5.Text)
                songaythue = 1;
            else
            {
                TimeSpan giatri = dateTimePicker3.Value - dateTimePicker5.Value;
                songaythue = Math.Round(giatri.TotalDays, 0);
                textBox_tienlai.Text = songaythue.ToString();
            }

            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 2 tháng")
            {
                if (songaythue >= 60)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365)) + s.SoTienGui;
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 3 tháng")
            {
                if (songaythue >= 90)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365)) + s.SoTienGui;
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                    tongtiencontrong = s.SoTienGui - s.SoTienGui;
                    textBox_tongtientrongsoluc.Text = tongtiencontrong.ToString();
                    s.SoTienGui = float.Parse(textBox_tongtientrongsoluc.Text);
                }
            }
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 6 tháng")
            {
                if (songaythue >= 180)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365)) + s.SoTienGui;
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                    tongtiencontrong = s.SoTienGui - s.SoTienGui;
                    textBox_tongtientrongsoluc.Text = tongtiencontrong.ToString();
                    s.SoTienGui = float.Parse(textBox_tongtientrongsoluc.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 9 tháng")
            {
                if (songaythue >= 270)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365)) + s.SoTienGui;
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 12 tháng")
            {
                if (songaythue >= 365)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365)) + s.SoTienGui;
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                    tongtiencontrong = s.SoTienGui - s.SoTienGui;
                    textBox_tongtientrongsoluc.Text = tongtiencontrong.ToString();
                    s.SoTienGui = float.Parse(textBox_tongtientrongsoluc.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (comboBox1_loaitietkiemrut.Text == "Kỳ hạn 24 tháng")
            {
                if (songaythue >= 730)
                {
                    s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                    tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365)) + s.SoTienGui;
                    tb_sotienrut3.Text = tongtien.ToString();
                    c.SoRut = float.Parse(tb_sotienrut3.Text);
                }
                else
                    MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (comboBox1_loaitietkiemrut.Text == "Không kỳ hạn")
            {
                if (songaythue >= ngay)
                {
                    if (songaythue >= 23)
                    {
                        s.SoTienGui = float.Parse(textBox_sotienryt.Text);
                        tongtien = (s.SoTienGui * (phantram / 10) * (songaythue / 365)) + s.SoTienGui;
                        tb_sotienrut3.Text = tongtien.ToString();
                        c.SoRut = float.Parse(tb_sotienrut3.Text);
                        tongtiencontrong = s.SoTienGui - s.SoTienGui;
                        textBox_tongtientrongsoluc.Text = tongtiencontrong.ToString();
                        s.SoTienGui = float.Parse(textBox_tongtientrongsoluc.Text);
                    }
                    else
                        MessageBox.Show("Chưa tới kì hạn rút ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Chưa qua kỳ hạn mở sổ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button1_ruthettien_Click(object sender, EventArgs e)
        {
            SoTietKiem s = new SoTietKiem();
            PhieuRutTien c = new PhieuRutTien();

            s.MaSo = textBox_Masoryt.Text;
            s.KhachHang = textBox_khachhangryt.Text;      
            s.CMND = textBox_cmndryt.Text;
            s.DiaChi = textBox_diachiryt.Text;           
            s.SoTienGui = float.Parse(textBox_tongtientrongsoluc.Text);
            s.LoaiTietKiem = comboBox1_loaitietkiemrut.Text;
            s.NgayMoSo = dateTimePicker3.Value;
            s.Update1();

            c.MaSo = tb_Maso3.Text;
            c.KhachHang = tb_khachhang3.Text;
            c.NgayRut = dateTimePicker3.Value;
            c.SoRut = float.Parse(tb_sotienrut3.Text);
            c.Insert();

            dataGridView3.DataSource = PhieuRutTien.GetData();
            dataGridView5.DataSource = SoTietKiem.GetData();
        }
        private void button2_dschi_Click(object sender, EventArgs e)
        {
            BaoCaoChi t = new BaoCaoChi();

            t.MaSo = textBox1_MaSochi.Text;
            t.Ngay = dateTimePicker8.Value;
            t.LoaiTietKie = comboBox1_loaitietkiemchi.Text;
            t.TongChi = 0;

            t.Insert();
            dataGridView8.DataSource = BaoCaoThu.GetData();
        }
        private void button2_timkiemchitieu_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string sqlTimKiem = "SELECT *FROM BaoCaochi WHERE Ngay = @Ngay";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, conn);
                cmd.Parameters.AddWithValue("@Ngay", dateTimePicker8.Text);
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
        private void button_tomgthuchi_Click(object sender, EventArgs e)
        {
            BaoCaoChi t = new BaoCaoChi();
            SoTietKiem s = new SoTietKiem();
            PhieuRutTien c = new PhieuRutTien();
            float tong;

            s.LoaiTietKiem = comboBox1_loaitietkiemrut.Text;
            s.NgayMoSo = dateTimePicker3.Value;
            c.NgayRut = dateTimePicker3.Value;
            c.SoRut = float.Parse(tb_sotienrut3.Text);
            t.MaSo = textBox1_MaSochi.Text;
            t.LoaiTietKie = comboBox1_loaitietkiemchi.Text;
            t.TongChi = float.Parse(textBox2_tongchi.Text);

            tong = t.TongChi + c.SoRut;
            if (s.LoaiTietKiem == t.LoaiTietKie)
            {
                t.Ngay = dateTimePicker8.Value;
                if (c.NgayRut == t.Ngay)
                {
                    //t.TongChi = float.Parse(textBox2_tongchi.Text);
                    //tong = t.TongChi + c.SoRut;
                    textBox2_tongchi.Text = tong.ToString();
                    t.TongChi = float.Parse(textBox2_tongchi.Text);
                }
            }
            t.Update9();
            dataGridView8.DataSource = BaoCaoChi.GetData();
        }
        private void bt_xoa3_Click_1(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thật sự muốn xóa khách hàng có mã số là : " + tb_Maso3.Text + " và có tên là : " + tb_khachhang3.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                return;
            PhieuRutTien c = new PhieuRutTien();
            c.MaSo = tb_Maso3.Text;
            c.Delete();
            dataGridView3.DataSource = PhieuRutTien.GetData();
        }
        #endregion
    }
}
   
