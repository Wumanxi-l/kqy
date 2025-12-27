using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MyUtility
{
    public class SqlHelper
    {
        private static readonly string connString = ConfigurationManager.ConnectionStrings["MyContact"].ConnectionString;
        /// <summary>
        /// 设置数据库连接字符串
        /// </summary>
        public static SqlConnection conn = new SqlConnection(connString);
        public static DataTable GetDataTable(string sql)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }
        public static bool Getresult(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
    }
}
