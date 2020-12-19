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
            txtPass.Text = "admin01";
            txtUser.Text = "admin01";
            if(txtUser.Text != "" && txtPass.Text != "")
            {
                user.Username = txtUser.Text.Trim();
                user.Password = txtPass.Text.Trim();
                if(user.Login() == true)
                {
                    frmMDI form = new frmMDI(user);
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sai tai khoan hoac mat khau");
                }
            }
        }
    }
}
