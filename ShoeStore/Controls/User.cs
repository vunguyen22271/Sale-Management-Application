using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShoeStore.Models;

namespace ShoeStore.Controls
{
    public class User
    {
        private Status status = new Status();
        private Database database = new Database();
        private DataTable user_tb;
        private string str;
        private string idUser;
        private string username;
        private string password;
        private string name;
        private string phanQuyen;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public string IdUser { get => idUser; set => idUser = value; }

        public User() 
        { 

        }
        public bool Login()
        {
            DataTable dt = this.database.Execute("select * from NHANVIEN where username='" + this.username+ "' and password ='" + this.password + "'");
            if(dt.Rows.Count >= 1)
            {
                this.idUser = dt.Rows[0]["idNV"].ToString();
                this.name = dt.Rows[0]["tenNV"].ToString();
                this.phanQuyen = dt.Rows[0]["phanQuyen"].ToString();
                return true;
            } 
            else 
            { 
                return false; 
            }
        }
    }
}
