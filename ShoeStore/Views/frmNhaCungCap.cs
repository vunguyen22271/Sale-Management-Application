using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore.Controls;

namespace ShoeStore.Views
{
    public partial class frmNhaCungCap : Form
    {
        Status status = new Status();
        NhaCungCap nhaCungCap = new NhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
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
            DataTable dt = nhaCungCap.NhaCungCap_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["tenNCC"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["sdt"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["email"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["diachi"].ToString();
                lvi.SubItems.Add(str);
            }
        }

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                nhaCungCap.TimKiem(txtTimKiem.Text.Trim());
                LoadListView();
            }
            else
            {
                nhaCungCap = new NhaCungCap();
                LoadListView();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diachi = rtbDiaChi.Text.Trim();
            if (ten != "" && sdt != "" && email != "" && diachi != "")
            {
                if(IsPhoneNumber(sdt) == false || sdt.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không được chứa ký tự đặc biệt và độ dài từ 10 số trở lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (IsValid(email) == false)
                {
                    MessageBox.Show("Email không hợp lệ, vui lòng nhập email không có ký tự đặc biệt trừ @", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (nhaCungCap.Them(ten, sdt, email, diachi) == status.Success)
                {
                    MessageBox.Show("Nhà cung cấp đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnSoanLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Nhà cung cấp bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static bool IsPhoneNumber(string number)
        {
            try
            {
                int sdt = int.Parse(number);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string ten = txtTen.Text.Trim();
                string sdt = txtSdt.Text.Trim();
                string email = txtEmail.Text.Trim();
                string diachi = rtbDiaChi.Text.Trim();
                if (ten != "" && sdt != "" && email != "" && diachi != "")
                {
                    if (IsPhoneNumber(sdt) == false || sdt.Length < 10)
                    {
                        MessageBox.Show(text: "Số điện thoại không được chứa ký tự đặc biệt và độ dài từ 10 số trở lên: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (IsValid(email) == false)
                    {
                        MessageBox.Show("Email không hợp lệ, vui lòng nhập email không có ký tự đặc biệt trừ @", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (nhaCungCap.CapNhat(lv.SelectedIndices[0], ten, sdt, email, diachi) == status.Success)
                    {
                        MessageBox.Show("Nhà cung cấp đã được cập nhật thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnSoanLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp bị trùng", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 nhà cung cấp trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string str = "";
                str = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa nhà cung cấp ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lv.SelectedIndices[0];
                    if (nhaCungCap.Xoa(deleteIndex) == status.Success)
                    {
                        MessageBox.Show("Nhà cung cấp đã được xoá thành công", "Thông báo",
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
                MessageBox.Show("Bạn phải chọn 1 nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            rtbDiaChi.Text = "";
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                btnSoanLai_Click(sender, e);
                txtTen.Text = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                txtSdt.Text = lv.Items[lv.SelectedIndices[0]].SubItems[2].Text;
                txtEmail.Text = lv.Items[lv.SelectedIndices[0]].SubItems[3].Text;
                rtbDiaChi.Text = lv.Items[lv.SelectedIndices[0]].SubItems[4].Text;
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiemTen_Click(sender, e);
            }
        }
    }
}
