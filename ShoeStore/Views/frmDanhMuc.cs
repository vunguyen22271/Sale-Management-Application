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
    public partial class frmDanhMuc : Form
    {
        Status status = new Status();
        DanhMuc danhmuc = new DanhMuc();
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadCBHangGiay();
            LoadListView();
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
            DataTable dt = danhmuc.DanhMuc_tb;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["tenLoaiGiay"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["tenHangGiay"].ToString();
                lvi.SubItems.Add(str);

            }
        }
        private void LoadCBHangGiay()
        {
            DataTable dt = danhmuc.HangGiay_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dt.Rows[i]["tenHangGiay"].ToString();
                item.Value = dt.Rows[i]["idHangGiay"].ToString();
                cbHangGiay.Items.Add(item);

                // MessageBox.Show((cbHangGiay.SelectedItem as ComboboxItem).Value.ToString());
            }
            if (cbHangGiay.Items.Count > 0)
            {
                cbHangGiay.SelectedIndex = 0;
            }
        }
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                txtTen.Text = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                string str = lv.Items[lv.SelectedIndices[0]].SubItems[2].Text;
                cbHangGiay.SelectedIndex = cbHangGiay.FindStringExact(str);
            }
        }

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() != "")
            {
                danhmuc.TimKiem(txtTimKiem.Text.Trim());
                LoadListView();
            }
            else
            {
                danhmuc = new DanhMuc();
                LoadListView();
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            cbHangGiay.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string idHangGiay = (cbHangGiay.SelectedItem as ComboboxItem).Value.ToString();
            if (ten != "" && idHangGiay != "")
            {
                if (danhmuc.Them(ten, idHangGiay) == status.Success)
                {
                    MessageBox.Show("Danh mục đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnSoanLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Danh mục bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên Danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string ten = txtTen.Text.Trim();
                string idHangGiay = (cbHangGiay.SelectedItem as ComboboxItem).Value.ToString();
                if (ten != "" && idHangGiay != "")
                {
                    if (danhmuc.CapNhat(lv.SelectedIndices[0], ten, int.Parse(idHangGiay)) == status.Success)
                    {
                        MessageBox.Show("Danh mục đã được cập nhật thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnSoanLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Danh mục bị trùng", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 danh mục trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string str = "";
                str = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa danh mục ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lv.SelectedIndices[0];
                    if (danhmuc.Xoa(deleteIndex) == status.Success)
                    {
                        MessageBox.Show("Danh mục đã được xoá thành công", "Thông báo",
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
                MessageBox.Show("Bạn phải chọn 1 danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string idLoaiGiay = danhmuc.DanhMuc_tb.Rows[lv.SelectedIndices[0]]["idLoaiGiay"].ToString();
                frmGiay formGiay = new frmGiay(idLoaiGiay);
                formGiay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 loại giày trước", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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