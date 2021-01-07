using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
    class HoaDon
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable hoaDon_tb;
        private string str;

        public DataTable HoaDon_tb { get => hoaDon_tb; }

        public HoaDon()
        {
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            //Proc load danh sách
            str = "select * from HOADON, NHANVIEN, KHACHHANG " +
                "where HOADON.status=1 and HOADON.idNV = NHANVIEN.idNV and HOADON.idKH = KHACHHANG.idKH";
            this.hoaDon_tb = database.Execute(str);
        }
        public void LoadHoaDon(string idHoaDon)
        {
            //Proc select * giống LoadDanhSach()
            str = "select * from HOADON " +
                "where HOADON.status=1 and HOADON.idHoaDon = '" + idHoaDon + "'";
            this.hoaDon_tb = database.Execute(str);
        }
        public string ThemHoaDon(string idNV, string idKH, string ngayInHoaDon)
        {
            //Proc insert HOADON và lấy ra idHoaDon
            //str = "insert into HOADON(idNV, idKH, ngayInHoaDon) values('" + idNV + "', '" + idKH + "', '" + ngayInHoaDon + "')";
            str = "execute pr_ThemHoaDon '" + idNV + "', '" + idKH + "', '" + ngayInHoaDon + "'";
            database.ExecuteNonQuery(str);
            str = "select idHoaDon from HOADON where idNV='" + idNV + "' and idKH='" + idKH + "'";
            DataTable dt = database.Execute(str);

            if (dt.Rows.Count >= 1)
            {
                return dt.Rows[dt.Rows.Count - 1]["idHoaDon"].ToString();
            }
            else
            {
                return status.Nonexistence;
            }
        }
        public string XoaByToanBoHoaDon(string idHoaDon)
        {
            //Proc xoá hoá đơn và chi tiết hoá đơn
            //Note: XoaByID của ChiTietHoaDon sẽ không cần
            //str = "update HOADON set status=0 where idHoaDon = '" + idHoaDon + "'";
            str = "execute pr_XoaToanBoHoaDon '" + idHoaDon + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
    }
}
