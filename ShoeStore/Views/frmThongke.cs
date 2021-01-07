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
        KhachHang khachhang = new KhachHang();
        public frmThongke()
        {
            InitializeComponent();
            //LoadListViewThongKeTongDoanhThu();
            LoadTop5(); 
            LoadListView();
        }
        public void LoadTop5()
        {
            khachhang.LoadTop5();
            string ten;
            string tongTien;
            DataTable dt = khachhang.KhachHang_tb;

            for (int i = 0; i < 5; i++)
            {
                ten = dt.Rows[i]["tenKH"].ToString();
                tongTien = dt.Rows[i]["tongTien"].ToString();
                chart1.Series["Tổng số tiền"].Points.AddXY(ten, tongTien);
            }
        }
        public void LoadListView()
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.Items.Clear();
            lv.Columns[1].Width = 133;

            string str;
            DataTable dt = khachhang.KhachHang_tb;
            for (int i = 0; i < 5; i++)
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
