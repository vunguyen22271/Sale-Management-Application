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

        private void btnThemChiTietNhapKho_Click_1(object sender, EventArgs e)
        {
            string idGiay = (cbTenGiay.SelectedItem as ComboboxItem).Value.ToString();
            string soluong = txtSoLuong.Text;
            string giaGoc = txtGiaGoc.Text;

            if (idGiay != "" || giaGoc != "" || soluong != "")
            {
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
        }
    }
}
