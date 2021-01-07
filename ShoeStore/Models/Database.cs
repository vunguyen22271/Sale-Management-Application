
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; 
using System.Data;

namespace ShoeStore.Models
{
    class Database
    {
        /// <summary>
        /// Tên server
        /// </summary>
        private string svrName = "DESKTOP-GNULQ63";
        /// <summary>
        /// Tên database
        /// </summary>
        private string dbName = "ShoeStore";
        /// <summary>
        /// Username đăng nhập server
        /// </summary>
        private string usrName = "ShoeStore";
        /// <summary>
        /// Password đăng nhập server
        /// </summary>
        private string pwd = "ShoeStore";
        /// <summary>
        /// 1: Cho phép truy cập bằng Windows, 0: Truy cập bằng SQL Login
        /// </summary>
        private bool intergratedMode = false;

        /// <summary>
        /// Đối tượng connection chịu trách nhiệm thiết lập kết nối đến database
        /// </summary>
        SqlConnection sqlconn;
        /// <summary>
        /// Constructor tạo đối tượng database
        /// </summary>
        public Database()
        {
            //string connStr = "server=" + this.svrName + "; uid=" + this.usrName + "; pwd=" + this.pwd + " ;database=" + this.dbName;
            //sqlconn = new SqlConnection(connStr);
            string connStr;
            if (intergratedMode == true)
            {
                connStr = "server=" + svrName + "; database=" + dbName + "; Integrated Security = True";
            }
            else
            {
                connStr = "server=" + svrName + "; uid=" + usrName + "; pwd=" + pwd + " ;database=" + dbName;
            }
            sqlconn = new SqlConnection(connStr);
        }
        /// <summary>
        /// Thực thi và trả ra kết quả (Select)
        /// </summary>
        public DataTable Execute(string strQuery)
        {
            SqlDataAdapter da = new SqlDataAdapter(strQuery, sqlconn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        /// <summary>
        /// Thực thi và không cần trả ra kết quả (Update)
        /// </summary>
        public bool ExecuteNonQuery(string strquery)
        {
            SqlCommand sqlcom = new SqlCommand(strquery, sqlconn);
            sqlconn.Open();
            try
            {
                sqlcom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                sqlconn.Close();
                return false;
            }
            sqlconn.Close();
            return true;
        }
        //public void ExecuteNonQueryAdapter(DataTable dt, string strQuery)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter(strQuery, sqlconn);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
        //    da.UpdateCommand = builder.GetUpdateCommand();
        //    da.Update(dt);
        //}
    }
}