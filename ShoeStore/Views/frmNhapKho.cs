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
    public partial class frmNhapKho : Form
    {
        Status status = new Status();
        NhapKho nhapkho = new NhapKho();
        User user;
        public frmNhapKho(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            LoadCBNhaCungCap();
            LoadListView();

            lblNguoiNhap.Text = user.Name;
            lblNgayNhap.Text = (DateTime.Now).ToString("dd/MM/yyyy");
            lblTongSoLuong.Text = "0";
            lblTongThanhTien.Text = "0";
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
            DataTable dt = nhapkho.Nhapkho_tb;
            DataRow[] foundRows;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["idNhapKho"].ToString();
                lvi.SubItems.Add(str);


                str = dt.Rows[i]["idNV"].ToString();
                foundRows = nhapkho.Nhanvien_tb.Select("idNV='"+str+"'");
                str = foundRows[0]["tenNV"].ToString();
                lvi.SubItems.Add(str);


                str = dt.Rows[i]["idNCC"].ToString();
                foundRows = nhapkho.Nhacungcap_tb.Select("idNCC='" + str + "'");
                str = foundRows[0]["tenNCC"].ToString();
                lvi.SubItems.Add(str);

                
                str = DateTime.Parse(dt.Rows[i]["ngayNhapKho"].ToString()).ToString("dd/MM/yyyy");
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["soLuong"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["thanhTien"].ToString();
                lvi.SubItems.Add(str);
            }
        }
        private void LoadCBNhaCungCap()
        {
            DataTable dt = nhapkho.Nhacungcap_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dt.Rows[i]["tenNCC"].ToString();
                item.Value = dt.Rows[i]["idNCC"].ToString();
                cbNhaCungCap.Items.Add(item);
            }
            if (cbNhaCungCap.Items.Count > 0)
            {
                cbNhaCungCap.SelectedIndex = 0;
            }
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            string idNV = user.IdUser;
            string idNCC = (cbNhaCungCap.SelectedItem as ComboboxItem).Value.ToString();
            string ngayNhapKho = (DateTime.Now).ToString("MM/dd/yyyy");
            if(idNV != "" || idNCC != "" || ngayNhapKho != "")
            {
                if (nhapkho.Them(idNV, idNCC, ngayNhapKho) == status.Success)
                {
                    MessageBox.Show("Phiếu nhập kho đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                }
                else
                {
                    MessageBox.Show("Phiếu nhập kho bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string idNhapKho = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                frmChiTietNhapKho formChiTietNhapKho = new frmChiTietNhapKho(idNhapKho);
                formChiTietNhapKho.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 phiếu nhập kho trước", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
