using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore.Controls;

namespace ShoeStore.Views
{
    public partial class frmDangNhap : Form
    {
        User user = new User();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user.Username = txtUser.Text.Trim();
            user.Password = txtPass.Text.Trim();
            if (user.Username != "" && user.Password != "")
            {
                if (user.Username.Length <= 3 || user.Password.Length <= 3)
                {
                    MessageBox.Show("Độ dài username, password phải từ 4 ký tự trở lên");
                    return;
                }
                if (user.Login() == true)
                {
                    if(user.PhanQuyen == "0") //admin
                    {
                        frmMDI form = new frmMDI(user);
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmInHoaDon form = new frmInHoaDon(user);
                        form.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền tài khoản và mật khẩu!");
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin_Click(sender, e);
                }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
