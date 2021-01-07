using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
    class ChiTietHoaDon
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable chiTietHoaDon_tb;
        private string str;
        private string idHoaDon = "0";

        public DataTable ChiTietHoaDon_tb { get => chiTietHoaDon_tb; }

        public ChiTietHoaDon()
        {

        }
        public void LoadDanhSachChiTiet(string idHoaDon)
        {
            //Proc select * giống LoadDanhSach()
            str = "select * from CHITIETHOADON, GIAY " +
                "where CHITIETHOADON.status=1 and CHITIETHOADON.idGiay = GIAY.idGiay" +
                " and CHITIETHOADON.idHoaDon = '" + idHoaDon + "'";
            this.chiTietHoaDon_tb = database.Execute(str);
        }
        public string ThemChiTiet(string idHoaDon, string idGiay, string donGia, string soLuong)
        {
            //Proc insert chi tiết hoá đơn, thực hiện tính thanhTien = soLuong * giaGoc
            //Trigger after insert chi tiết hoá đơn, tự động trừ số lượng vào bảng GIAY theo idGiay.
            //Trigger after insert chi tiết hoá đơn, tự động cộng số lượng và thành tiền vào bảng HOADON theo idHoaDon
            string thanhTien = (float.Parse(soLuong) * float.Parse(donGia)).ToString();
            //str = "insert into CHITIETHOADON (idHoaDon, idGiay, soLuong, donGia, thanhTien) " +
            //    "values('" + idHoaDon + "', '" + idGiay + "', '" + soLuong + "', '" + donGia + "', '" + thanhTien + "')";
            str = "execute pr_ThemChiTietHoaDon '" + idHoaDon + "', '" + idGiay + "', '" + soLuong + "', '" + donGia + "', '" + thanhTien + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSachChiTiet(idHoaDon);
            return status.Success;
        }
        public string XoaChiTiet(string idHoaDon, int index)
        {
            //Proc Xoá (set status = 0) chi tiết hoá đơn
            //Trigger khi xoa (set status = 0) 1 chi tiết hoá đơn, số lượng sẽ cộng lại cho kho GIAY
            //Trigger khi xoá (set status = 0) 1 chi tiết hoá đơn, dòng có idHoaDon của bảng HOADON sẽ giảm tổng số lượng và tổng Thành tiền
            string idChiTietHoaDon = chiTietHoaDon_tb.Rows[index]["idChiTietHoaDon"].ToString();
            //str = "update CHITIETHOADON set status=0 where idChiTietHoaDon = '" + idChiTietHoaDon + "'";
            str = "pr_XoaChiTietHoaDon '" + idChiTietHoaDon + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSachChiTiet(idHoaDon);
            return status.Success;
        }
        public string XoaByID(string idHoaDon)
        {
            //Không cần ghi
            str = "update CHITIETHOADON set status=0 where idHoaDon = '" + idHoaDon + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSachChiTiet(idHoaDon);
            return status.Success;
        }
    }
}