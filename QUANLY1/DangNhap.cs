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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nguoidung tk = new nguoidung();
            tk.MaTk = txtTenDangNhap.Text;
            tk.Matkhau = txtPass.Text;
            tk.LoaiTK = cmbVC.Text;
            if (tk.KiemtraTK() == false)
            {
                MessageBox.Show("Thông tin Tài Khoản hoặc Mật Khẩu Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                main.maTk = txtTenDangNhap.Text;
                main.loaiTK = cmbVC.Text;
                main.loaiTK = cmbVC.Text;
                this.Close();
            }
        }
    }
}
