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
    public partial class frmNhanVien : Form
    {
        Status status = new Status();
        NhanVien nhanvien = new NhanVien();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
            DataTable dt = nhanvien.Nhanvien_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["tenNV"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["username"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["sdt"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["email"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["phanQuyen"].ToString();
                lvi.SubItems.Add(str);
            }
        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                btnSoanLai_Click(sender, e);
                txtTen.Text = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                txtUsername.Text = lv.Items[lv.SelectedIndices[0]].SubItems[2].Text;
                txtSdt.Text = lv.Items[lv.SelectedIndices[0]].SubItems[3].Text;
                txtEmail.Text = lv.Items[lv.SelectedIndices[0]].SubItems[4].Text;
                cbPhanQuyen.SelectedIndex = cbPhanQuyen.FindStringExact(lv.Items[lv.SelectedIndices[0]].SubItems[5].Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string username = txtUsername.Text.Trim();
            string pass = txtPass.Text.Trim();
            string repass = txtRePass.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phanquyen = cbPhanQuyen.SelectedItem.ToString();
            if (ten != "" || sdt != "" || email != "" || phanquyen != "" || username != "" || pass != "" || pass == repass)
            {
                if (nhanvien.Them(ten, username, pass, sdt, email, phanquyen) == status.Success)
                {
                    MessageBox.Show("Nhân viên đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnSoanLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Nhân viên bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string ten = txtTen.Text.Trim();
                string username = txtUsername.Text.Trim();
                string pass = txtPass.Text.Trim();
                string repass = txtRePass.Text.Trim();
                string sdt = txtSdt.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phanquyen = cbPhanQuyen.SelectedItem.ToString();
                if (ten != "" || sdt != "" || email != "" || phanquyen != "" || username != "" || pass != "" || pass == repass)
                {
                    if (nhanvien.CapNhat(lv.SelectedIndices[0], ten, username, pass, sdt, email, phanquyen) == status.Success)
                    {
                        MessageBox.Show("Nhân viên đã được cập nhật thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnSoanLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên bị trùng", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 Khách hàng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string str = "";
                str = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa nhân viên ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lv.SelectedIndices[0];
                    if (nhanvien.Xoa(deleteIndex) == status.Success)
                    {
                        MessageBox.Show("Nhân viên đã được xoá thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnSoanLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công", "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {

            txtTen.Text = "";
            txtUsername.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtRePass.Text = "";
        }
    }
}
