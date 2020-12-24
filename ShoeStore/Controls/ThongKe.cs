using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
    class ThongKe
    {
        Status status = new Status();
        Database database = new Database();
        DataTable dt = new DataTable();
        string str;
        public ThongKe()
        {
            LoadThonKeTongDoanThu();
        }

        public DataTable Dt { get => dt; }

        public DataTable LoadThonKeTongDoanThu()
        {
            str = "execute pr_thongKeTongDoanhThu";
            this.dt = database.Execute(str);
            return this.dt;
        }
    }
}
