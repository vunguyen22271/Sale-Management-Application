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
    public partial class frmKhachHang : Form
    {
        Status status = new Status();
        KhachHang khachhang = new KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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
            DataTable dt = khachhang.KhachHang_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["tenKH"].ToString();
                lvi.SubItems.Add(str); 
                 str = dt.Rows[i]["sdt"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["tongTien"].ToString();
                lvi.SubItems.Add(str);
            }
        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                txtTen.Text = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                txtSdt.Text = lv.Items[lv.SelectedIndices[0]].SubItems[2].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            if (ten != "" && sdt != "")
            {
                if (IsPhoneNumber(sdt) == false || sdt.Length < 10)
                {
                    MessageBox.Show("Số điện thoại không được chứa ký tự đặc biệt và độ dài từ 10 số trở lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (khachhang.Them(ten, sdt) == status.Success)
                {
                    MessageBox.Show("Khách khàng đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnSoanLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Khách khàng bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên Khách khàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string ten = txtTen.Text.Trim();
                string sdt = txtSdt.Text.Trim();
                if (ten != "" || sdt != "")
                {
                    if (IsPhoneNumber(sdt) == false || sdt.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không được chứa ký tự đặc biệt và độ dài từ 10 số trở lên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (khachhang.CapNhat(lv.SelectedIndices[0], ten, sdt) == status.Success)
                    {
                        MessageBox.Show("Khách hàng đã được cập nhật thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnSoanLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng bị trùng", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 Khách hàng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSdt.Text = "";
        }
    }
}
