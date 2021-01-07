using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
    class NhanVien
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable nhanvien_tb;
        private string str;

        public DataTable Nhanvien_tb { get => nhanvien_tb; }
        public NhanVien() 
        {
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            str = "select * from NHANVIEN where status=1";
            this.nhanvien_tb = database.Execute(str);
        }
        public string Xoa(int index)
        {
            str = "update NHANVIEN set status=0 where idNV = '" + nhanvien_tb.Rows[index]["idNV"].ToString() + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        public string Them(string ten, string username, string password, string sdt, string email, string phanquyen)
        {
            string str = "insert into NHANVIEN (tenNV, username, password, sdt, email, phanQuyen) " +
                    "values(N'" + ten + "', '" + username + "', '" + password + "', '" + sdt + "', '" + email + "', N'" + phanquyen + "')";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        public string CapNhat(int index, string ten, string username, string password, string sdt, string email, string phanquyen)
        {
            string str = "update NHANVIEN set tenNV=N'" + ten + "', username='" + username + "', password='" + password + "', sdt='" + sdt + "', email='" + email + "', phanQuyen='" + phanquyen + "' " +
                    "where status = 1 and idNV = " + nhanvien_tb.Rows[index]["idNV"].ToString();
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
    }
}
