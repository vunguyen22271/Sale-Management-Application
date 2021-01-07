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
        /// <summary>
        /// Hỗ trợ xác định trạng thái thực thi thành công hay thất bại
        /// </summary>
        private Status status = new Status();
        private Database database = new Database();
        /// <summary>
        /// DataTable lưu trữ thông tin danh sách khách hàng
        /// </summary>
        private DataTable khachHang_tb;
        /// <summary>
        /// Gán code sql để thực thi truy vấn database
        /// </summary>
        private string str;

        public DataTable KhachHang_tb { get => khachHang_tb; }

        /// <summary>
        /// Khởi tạo đối tượng khách hàng
        /// </summary>
        public KhachHang()
        {
            LoadDanhSach();
        }
        /// <summary>
        /// Load danh sách khách hàng vào khachhang_tb
        /// </summary>
        public void LoadDanhSach()
        {
            str = "select * from KHACHHANG where status=1";
            this.khachHang_tb = database.Execute(str);
        }
        /// <summary>
        /// Load top 5 khách hàng mua nhiều nhất khachhang_tb
        /// </summary>
        public void LoadTop5()
        {
            str = "select * from KHACHHANG where status=1 ORDER BY tongTien ASC";
            this.khachHang_tb = database.Execute(str);
        }
        /// <summary>
        /// Hàm thực thi thêm 1 khách hàng mới
        /// </summary>
            public string Them(string ten, string sdt)
        {
            string str = "insert into KHACHHANG(tenKH, sdt) " +
                    "values(N'" + ten + "', '" + sdt + "')";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        /// <summary>
        /// Hàm thực thi cập nhật thông tin khách hàng
        /// </summary>
        public string CapNhat(int index, string ten, string sdt)
        {
            string str = "update KHACHHANG set tenKH=N'" + ten + "', sdt='" + sdt + "' " +
                    "where status = 1 and idKH = " + khachHang_tb.Rows[index]["idKH"].ToString();
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        /// <summary>
        /// Hàm tìm ID khách hàng theo số điện thoại
        /// </summary>
        public string TimIDKhachHang(string sdt)
        {
            string str = "select * from KHACHHANG where status=1 and sdt = '" + sdt + "'";
            DataTable dt = new DataTable();
            dt = database.Execute(str);
            if (dt.Rows.Count >= 1)
            {
                this.khachHang_tb = dt;
                return dt.Rows[0]["idKH"].ToString();
            }
            else
            {
                return status.Nonexistence;
            }
        }
    }
}
