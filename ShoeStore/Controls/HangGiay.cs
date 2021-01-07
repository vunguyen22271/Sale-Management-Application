using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
    class HangGiay
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable hangGiay_tb;
        private string str;
        public DataTable HangGiay_tb { get => hangGiay_tb; }

        public HangGiay()
        {
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            str = "select * from HANGGIAY where status=1";
            this.hangGiay_tb = database.Execute(str);
        }
        public DataTable LayDanhSach()
        {
            return hangGiay_tb;
        }
        public void TimKiem(string ten)
        {
            str = "select * from HANGGIAY where status=1 and tenHangGiay like '" + ten + "%'";
            this.hangGiay_tb = database.Execute(str);
        }
        public string Them(string ten) 
        {
            if (KiemTraTonTai(ten) == status.Exist)
            {
                return status.Failure;
            }
            else
            {
                string str = "insert into HANGGIAY(tenHangGiay) values(N'"+ten+"')"; 
                database.ExecuteNonQuery(str);
                LoadDanhSach();
                return status.Success;
            }
        }
        public string CapNhat(int index, string ten)
        {
            if(KiemTraTonTai(ten) == status.Exist)
            {
                #region Test chức năng try catch exception
                //throw new Exception("Hãng giày bị trùng");
                #endregion
                return status.Failure;
            }
            else
            {
                string idHangGiay = hangGiay_tb.Rows[index]["idHangGiay"].ToString();
                string str = "update HANGGIAY set tenHangGiay = N'" + ten + "' where status = 1 and idHangGiay = " + idHangGiay;
                database.ExecuteNonQuery(str);
                LoadDanhSach();
                return status.Success;
            }
        }
        public string Xoa(int index)
        {
            str = "update HANGGIAY set status=0 where idHangGiay = '" + hangGiay_tb.Rows[index]["idHangGiay"].ToString() + "'";
            database.ExecuteNonQuery(str);
            LoadDanhSach();
            return status.Success;
        }
        private string KiemTraTonTai(string ten)
        {
            str = "select * from HANGGIAY where status=1 and tenHangGiay=N'" + ten + "'";
            DataTable dt = database.Execute(str);
            if(dt.Rows.Count >= 1)
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
