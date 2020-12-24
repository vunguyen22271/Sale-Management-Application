using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
    class KhachHang
    {
        Status status = new Status();
        Database database = new Database();
        DataTable khachHang_tb;
        string str;

        public DataTable KhachHang_tb { get => khachHang_tb; }

        public KhachHang()
        {
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            str = "select * from KHACHHANG where status=1";
            this.khachHang_tb = database.Execute(str);
        }
        public string Them(string ten, string sdt)
        {
            string str = "insert into KHACHHANG(tenKH, sdt) " +
                    "values(N'" + ten + "', '" + sdt + "')";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        public string CapNhat(int index, string ten, string sdt)
        {
            string str = "update KHACHHANG set tenKH=N'" + ten + "', sdt='" + sdt + "' " +
                    "where status = 1 and idKH = " + khachHang_tb.Rows[index]["idKH"].ToString();
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        public string TimIDKhachHang(string sdt)
        {
            string str = "select idKH from KHACHHANG where status=1 and sdt = '"+sdt+"'";
            DataTable dt = new DataTable();
            dt = database.Execute(str);
            if (dt.Rows.Count >= 1)
            {
                return dt.Rows[0]["idKH"].ToString();
            }
            else
            {
                return status.Nonexistence;
            }
        }
    }
}
