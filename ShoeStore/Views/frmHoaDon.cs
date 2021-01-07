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
    public partial class frmHoaDon : Form
    {
        Status status = new Status();
        HoaDon hoaDon = new HoaDon();
        NhanVien nhanVien = new NhanVien();
        KhachHang khachHang = new KhachHang();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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
            DataTable dt = hoaDon.HoaDon_tb;
            DataRow[] foundRows;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["idHoaDon"].ToString();
                lvi.SubItems.Add(str);


                str = dt.Rows[i]["idNV"].ToString();
                foundRows = nhanVien.Nhanvien_tb.Select("idNV='" + str + "'");
                str = foundRows[0]["tenNV"].ToString();
                lvi.SubItems.Add(str);


                str = dt.Rows[i]["idKH"].ToString();
                foundRows = khachHang.KhachHang_tb.Select("idKH='" + str + "'");
                str = foundRows[0]["tenKH"].ToString();
                lvi.SubItems.Add(str);


                str = DateTime.Parse(dt.Rows[i]["ngayInHoaDon"].ToString()).ToString("dd/MM/yyyy");
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["soLuong"].ToString();
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["thanhTien"].ToString();
                lvi.SubItems.Add(str);
            }
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (lv.SelectedIndices.Count > 0)
            {
                string idHoaDon = lv.Items[lv.SelectedIndices[0]].SubItems[1].Text;
                frmChiTietHoaDon formChiTietHoaDon = new frmChiTietHoaDon(idHoaDon);
                formChiTietHoaDon.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hoá đơn trước", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
