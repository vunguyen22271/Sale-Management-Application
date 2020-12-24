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
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                user.Username = txtUser.Text.Trim();
                user.Password = txtPass.Text.Trim();
                if(user.Login() == true)
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
                    MessageBox.Show("Sai tai khoan hoac mat khau");
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
