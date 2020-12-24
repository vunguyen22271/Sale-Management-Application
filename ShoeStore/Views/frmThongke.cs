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
    public partial class frmThongke : Form
    {
        Status status = new Status();
        ThongKe thongke = new ThongKe();
        public frmThongke()
        {
            InitializeComponent();
            LoadListViewThongKeTongDoanhThu();
        }
        public void LoadListViewThongKeTongDoanhThu()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
            DataTable dt = thongke.Dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lv.Items.Add((i + 1).ToString());
                str = DateTime.Parse(dt.Rows[i]["ngayInHoaDon"].ToString()).ToString("dd/MM/yyyy");
                lvi.SubItems.Add(str);


                str = dt.Rows[i]["TongSoLuong"].ToString();
                lvi.SubItems.Add(str);


                str = dt.Rows[i]["TongThanhTien"].ToString();
                lvi.SubItems.Add(str);
            }
        }
    }
}
