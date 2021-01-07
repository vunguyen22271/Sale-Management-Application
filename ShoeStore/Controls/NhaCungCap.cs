using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeStore.Models;
using System.Data;

namespace ShoeStore.Controls
{
    class NhaCungCap
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable nhaCungCap_tb;
        private string str;
        public DataTable NhaCungCap_tb { get => nhaCungCap_tb; }
        public NhaCungCap()
        {
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            str = "select * from NHACUNGCAP where status=1"; // View Load nhà cung cấp
            this.nhaCungCap_tb = database.Execute(str);
        }
        public void TimKiem(string ten)
        {
            str = "select * from NHACUNGCAP where status=1 and tenNCC like '" + ten + "%'"; //Produce Tìm kiếm nhà cung cấp
            this.nhaCungCap_tb = database.Execute(str);
        }
        public string Them(string ten, string sdt, string email, string diachi)
        {
            //Function Thêm nhà cung cấp. Nếu NCC tồn tại => return fail.
            if (KiemTraTonTai(ten) == status.Exist)
            {
                return status.Failure;
            }
            else
            {
                string str = "insert into NHACUNGCAP(tenNCC, sdt, email, diachi) " +
                    "values(N'" + ten + "', '" + sdt + "', '" + email + "', N'" + diachi + "')"; 
                database.ExecuteNonQuery(str);
                LoadDanhSach();
                return status.Success;
            }
        }
        public string CapNhat(int index, string ten, string sdt, string email, string diachi)
        {
            string str = "update NHACUNGCAP set tenNCC=N'" + ten + "', sdt='"+sdt+"', email='"+email+"', diachi=N'"+diachi+"' " +
                    "where status = 1 and idNCC = " + NhaCungCap_tb.Rows[index]["idNCC"].ToString();
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        public string Xoa(int index)
        {
            str = "update NHACUNGCAP set status=0 where idNCC = '" + NhaCungCap_tb.Rows[index]["idNCC"].ToString() + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        private string KiemTraTonTai(string ten)
        {
            str = "select * from NHACUNGCAP where status=1 and tenNCC=N'" + ten + "'";
            this.nhaCungCap_tb = database.Execute(str);
            if (nhaCungCap_tb.Rows.Count >= 1)
            {
                return status.Exist;
            }
            else
            {
                return status.Nonexistence;
            }
        }
    }
}
