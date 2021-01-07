using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
    class ChiTietNhapKho
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable giay_tb;
        private DataTable chiTietNhapKho_tb;
        private DataTable danhMuc_tb;
        private string str;
        private string idNhapKho;
        public DataTable Giay_tb { get => giay_tb; }
        public DataTable ChiTietNhapKho_tb { get => chiTietNhapKho_tb; }
        public DataTable DanhMuc_tb { get => danhMuc_tb; }

        public ChiTietNhapKho(string idNhapKho)
        {
            this.idNhapKho = idNhapKho;
            LoadDanhSach();
            Giay giay_tb = new Giay();
            this.giay_tb = giay_tb.Giay_tb;
            DanhMuc danhMuc_tb = new DanhMuc();
            this.danhMuc_tb = danhMuc_tb.DanhMuc_tb;
        }
        public void LoadDanhSach()
        {
            //Proc Lấy danh sách phiếu nhập kho theo idNhapKho
            //str = "select * from CHITIETNHAPKHO, GIAY " +
            //    "where CHITIETNHAPKHO.status=1 and CHITIETNHAPKHO.idGiay = GIAY.idGiay" +
            //    " and CHITIETNHAPKHO.idNhapKho = '" + this.idNhapKho+"'";
            str = "execute pr_loadCTNK_idNK '" + this.idNhapKho + "'";
            this.chiTietNhapKho_tb = database.Execute(str);
        }
        public string Them(string idGiay, string soLuong, string giaGoc)
        {
            //Proc insert chi tiết phiếu nhập kho, thực hiện tính thanhTien = soLuong * giaGoc
            //Trigger after insert chi tiết phiếu nhập kho, tự động cộng dồn số lượng vào bảng GIAY theo idGiay.
            //Trigger after insert chi tiết phiếu nhập kho, tự động cộng dồn số lượng và thành tiền vào bảng NHAPKHO theo idNhapKho
            //soluong > 0
            string thanhTien = (float.Parse(soLuong) * float.Parse(giaGoc)).ToString();
            //str = "insert into CHITIETNHAPKHO (idNhapKho, idGiay, soLuong, donGia, thanhTien) " +
            //    "values('" + this.idNhapKho + "', '" + idGiay + "', '" + soLuong + "', '" + giaGoc + "', '" + thanhTien + "')";
            str = "execute pr_themChiTietNhapKho '" + this.idNhapKho + "', '" + idGiay + "', '" + soLuong + "', '" + giaGoc + "', '" + thanhTien + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        public string Xoa(int index)
        {
            str = "update CHITIETNHAPKHO set status=0 where idChiTietPNK = '" + chiTietNhapKho_tb.Rows[index]["idChiTietPNK"].ToString() + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
    }
}