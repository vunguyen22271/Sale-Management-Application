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
    public partial class frmChiTietHoaDon : Form
    {
        Status status = new Status();
        ChiTietHoaDon chiTietHoaDon;
        DanhMuc danhMuc = new DanhMuc();
        Giay giay = new Giay();

        string idHoaDon;
        public frmChiTietHoaDon(string idHoaDon)
        {
            InitializeComponent();
            this.idHoaDon = idHoaDon;
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            chiTietHoaDon = new ChiTietHoaDon();
            chiTietHoaDon.LoadDanhSachChiTiet(this.idHoaDon);
            LoadListView();
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
            DataTable dt = chiTietHoaDon.ChiTietHoaDon_tb;
            DataRow[] foundRows;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());

                str = dt.Rows[i]["idGiay"].ToString();
                lvi.SubItems.Add(str);
                foundRows = giay.Giay_tb.Select("idGiay='" + str + "'");
                str = foundRows[0]["idLoaiGiay"].ToString();
                foundRows = danhMuc.DanhMuc_tb.Select("idLoaiGiay='" + str + "'");
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
    }
}
