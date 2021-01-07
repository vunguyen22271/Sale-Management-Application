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
    public partial class frmChiTietNhapKho : Form
    {
        Status status = new Status();
        ChiTietNhapKho chiTietNhapKho;
        string idNhapKho;
        public frmChiTietNhapKho(string idNhapKho)
        {
            InitializeComponent();
            this.idNhapKho = idNhapKho;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmChiTietNhapKho_Load(object sender, EventArgs e)
        {
            chiTietNhapKho = new ChiTietNhapKho(this.idNhapKho);
            LoadCBTenGiay();
            LoadListView();
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
            DataTable dt = chiTietNhapKho.ChiTietNhapKho_tb;
            DataRow[] foundRows;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());

                str = dt.Rows[i]["idGiay"].ToString();
                lvi.SubItems.Add(str);
                foundRows = chiTietNhapKho.Giay_tb.Select("idGiay='" + str + "'");
                str = foundRows[0]["idLoaiGiay"].ToString();
                foundRows = chiTietNhapKho.DanhMuc_tb.Select("idLoaiGiay='" + str + "'");
                str = foundRows[0]["tenLoaiGiay"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["mauSac"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["size"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["soLuong"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["donGia"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["thanhTien"].ToString();
                lvi.SubItems.Add(str);
            }
        }
        private void LoadCBTenGiay()
        {
            DataTable dt = chiTietNhapKho.Giay_tb;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = dt.Rows[i]["tenLoaiGiay"].ToString() + " - " + dt.Rows[i]["mauSac"].ToString() + " - " + dt.Rows[i]["size"].ToString();
                item.Value = dt.Rows[i]["idGiay"].ToString();
                cbTenGiay.Items.Add(item);
            }
            if (cbTenGiay.Items.Count > 0)
            {
                cbTenGiay.SelectedIndex = 0;
            }
        }

        private void btnThemChiTietNhapKho_Click(object sender, EventArgs e)
        {
            
        }
        public static bool IsPositiveNumber(string number)
        {
            if (IsNumber(number) == false)
            {
                return false;
            }

            int num = int.Parse(number);
            if (num > 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsNumber(string number)
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
        private void btnThemChiTietNhapKho_Click_1(object sender, EventArgs e)
        {
            string idGiay = (cbTenGiay.SelectedItem as ComboboxItem).Value.ToString();
            string soluong = txtSoLuong.Text;
            string giaGoc = txtGiaGoc.Text;

            if (idGiay != "" && giaGoc != "" && soluong != "")
            {
                if (IsPositiveNumber(giaGoc) == false || IsPositiveNumber(soluong) == false)
                {
                    MessageBox.Show("Giá gốc và số lượng chỉ chứa giá trị dương lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chiTietNhapKho.Them(idGiay, soluong, giaGoc) == status.Success)
                {
                    MessageBox.Show("Chi tiết phiếu nhập đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListView();
                }
                else
                {
                    MessageBox.Show("Chi tiết phiếu nhập bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string str = "";
                str = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa chi tiết phiếu nhập kho ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lv.SelectedIndices[0];
                    if (chiTietNhapKho.Xoa(deleteIndex) == status.Success)
                    {
                        MessageBox.Show("Chi tiết phiếu nhập kho đã được xoá thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListView();
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
                MessageBox.Show("Bạn phải chọn giày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
