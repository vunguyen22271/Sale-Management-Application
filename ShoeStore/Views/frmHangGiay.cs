using System;
using System.Data;
using System.Windows.Forms;
using ShoeStore.Controls;

namespace ShoeStore.Views
{
    public partial class frmHangGiay : Form
    {
        Status status = new Status();
        HangGiay hangiay = new HangGiay();
        public frmHangGiay()
        {
            InitializeComponent();
        }

        private void frmHangGiay_Load(object sender, EventArgs e)
        {
            LoadListView();
            //this.btnXoa.Hide();
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 273;
            
            string str;
            DataTable dt = hangiay.HangGiay_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["tenHangGiay"].ToString();
                lvi.SubItems.Add(str);
            }
        }
        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Trim() != "")
            {
                hangiay.TimKiem(txtTimKiem.Text.Trim());
                LoadListView();
            }
            else
            {
                hangiay = new HangGiay();
                LoadListView();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "")
            {
                if (hangiay.Them(txtTen.Text.Trim()) == status.Success)
                {
                    MessageBox.Show("Hãng giày đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                    btnSoanLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Hãng giày bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên hãng giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                btnSoanLai_Click(sender, e);
                txtTen.Text = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                if (txtTen.Text.Trim() != "")
                {
                    #region Test chức năng try catch exception

                    //try
                    //{
                    //    hangiay.CapNhat(lv.SelectedIndices[0], txtTen.Text);
                    //    MessageBox.Show("Hãng giày đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    LoadListView();
                    //    txtTen.Text = "";
                    //}
                    //catch(Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString());
                    //}
                    #endregion 

                    if (hangiay.CapNhat(lv.SelectedIndices[0], txtTen.Text.Trim()) == status.Success)
                    {
                        MessageBox.Show("Hãng giày đã được cập nhật thành công", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
                        btnSoanLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Hãng giày bị trùng", "Lỗi",
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
                MessageBox.Show("Chọn 1 hãng giày trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string str = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa hãng giày ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lv.SelectedIndices[0];
                    if(hangiay.Xoa(deleteIndex) == status.Success)
                    {
                        MessageBox.Show("Hãng giày đã được xoá thành công", "Thông báo",
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
                //Nếu không có item nào được chọn thì hiển thị thông báo
                MessageBox.Show("Bạn phải chọn 1 hãng giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
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
