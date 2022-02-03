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
    public partial class main : Form
    {
        public static string maTk;
        public static string loaiTK;

        public main()
        {
            InitializeComponent();
        }
        public static Form2 frm;

        private void NV_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new Form2();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.WindowState = FormWindowState.Normal;

        }
        public static Bao_cao frmBC;
        private void bÁOCÁODOANHTHUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBC == null)
            {
                frmBC = new Bao_cao();
                frmBC.MdiParent = this;
                frmBC.Show();
            }
            else
                frmBC.WindowState = FormWindowState.Normal;

        }
        public static QuyDinh frmQD;
        private void qUYĐỊNHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaiTK == "Quản Lí")
            {
                QuyDinh frmQD = new QuyDinh();
                frmQD.MdiParent = this;
                frmQD.Show();
            }
            else
                MessageBox.Show("Bạn ko có quyền Sử Dụng frm này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (frmQD == null)
            {
                frmQD = new QuyDinh();
                frmQD.MdiParent = this;

            }
            else
                frmQD.WindowState = FormWindowState.Normal;
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
            DangNhap f = new DangNhap();
            f.ShowDialog();
        }

        private void main_Activated(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = maTk;
            if (loaiTK == "Quản Lí")

                qUYĐỊNHToolStripMenuItem.Enabled = true;
            else
                qUYĐỊNHToolStripMenuItem.Enabled = false;
        }
    }
}
