
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
        private string svrName = "DESKTOP-GNULQ63";
        /// <summary>
        /// Tên database
        /// </summary>
        private string dbName = "ShoeStore";
        private string usrName = "ShoeStore";
        private string pwd = "ShoeStore";
        private bool intergratedMode = false;

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
        public DataTable Execute(string strQuery)
        {
            SqlDataAdapter da = new SqlDataAdapter(strQuery, sqlconn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strquery)
        {
            SqlCommand sqlcom = new SqlCommand(strquery, sqlconn);
            sqlconn.Open();
            sqlcom.ExecuteNonQuery();
            sqlconn.Close();
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