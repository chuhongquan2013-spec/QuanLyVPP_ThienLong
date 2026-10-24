using BLL;
using ChuDucthuy_2024611075.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuDucthuy_2024611075
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            NhanVienBLL nvBLL = new NhanVienBLL();
            string result = nvBLL.Login(username, password);

            if (result == "SUCCESS")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                FormMain frmMain = new FormMain();
                this.Hide(); 
                frmMain.ShowDialog(); 
                this.Close(); 
            }
            else
            {
                MessageBox.Show(result, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    } 
} 