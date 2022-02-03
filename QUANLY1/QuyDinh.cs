using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY1
{
    public partial class QuyDinh : Form
    {
        public QuyDinh()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoaiTK.GetData();
            dataGridView3.DataSource = SoTien.GetData();
            dataGridView2.DataSource = ThoiGian.GetData();
            PHOMRONG();
            PHOMRONG1();
            PHOMRONG2();
        }

        private void QuyDinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.frmQD = null;
        }
        #region ChinhFormData
        public void PHOMRONG()
        {
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 270;
        }
        public void PHOMRONG1()
        {
            dataGridView3.Columns[0].Width = 240;
        }
        public void PHOMRONG2()
        {
            dataGridView2.Columns[0].Width = 240;
            dataGridView2.Columns[1].Width = 240;
        }
        #endregion

        #region ThayDoiKiHan_SoTienToiThieu
        private void button3_them_Click(object sender, EventArgs e)
        {
            LoaiTK a = new LoaiTK();
            a.MaSo = textBox_Maso.Text;
            a.LoaiTk = textBox2_Loaitietkiem.Text;
            a.PhanTR = double.Parse(textBox3_phantram.Text);
            a.Insert();
            dataGridView1.DataSource = LoaiTK.GetData();
        }

        private void button2_thaydoi_Click(object sender, EventArgs e)
        {
            LoaiTK a = new LoaiTK();
            a.MaSo = textBox_Maso.Text;
            a.LoaiTk = textBox2_Loaitietkiem.Text;
            a.PhanTR = double.Parse(textBox3_phantram.Text);
            a.Update();
            dataGridView1.DataSource = LoaiTK.GetData();
        }

        private void button1_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thật sự muốn xóa : " + textBox_Maso.Text + " và có tên là : " + textBox2_Loaitietkiem.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
                return;
            LoaiTK a = new LoaiTK();
            a.MaSo = textBox_Maso.Text;
            a.Delete();
            dataGridView1.DataSource = LoaiTK.GetData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int i = dataGridView1.SelectedRows[0].Index;
                textBox_Maso.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox2_Loaitietkiem.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox3_phantram.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
               
            }
        }
        #endregion

        #region ThayDoiThoiGianToiThieu_LaiSuat
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int i = dataGridView2.SelectedRows[0].Index;
                textBox1_MaSoDanhThu.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
                textBox1_thoigian.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int i = dataGridView3.SelectedRows[0].Index;
                textBox1_Sotien.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void button2_Sua_Click(object sender, EventArgs e)
        {
            SoTien a = new SoTien();
            a.Sotien = float.Parse(textBox1_Sotien.Text);
            a.Update();
            dataGridView3.DataSource = SoTien.GetData();
        }

        private void button1_thaydoingay_Click(object sender, EventArgs e)
        {
            ThoiGian a = new ThoiGian();
            a.MaSo = textBox1_MaSoDanhThu.Text;
            a.Ngay = textBox1_thoigian.Text;
            a.Update();
            dataGridView2.DataSource = ThoiGian.GetData();
        }
        #endregion
    }
}
