using System.Data;
using System.Data.SqlClient;

namespace TaskManager.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DatabaseIf
    {
        #region 

        /// <summary>
        /// コネクション
        /// </summary>
        private SqlConnection sqlConnection;

        #endregion

        /// <summary>
        /// サーバ名
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// ユーザ名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// データベース名称
        /// </summary>
        public string DatabaseName { get; set; }

        #region メソッド

        /// <summary>
        /// 接続
        /// </summary>
        /// <returns></returns>
        public void Connect()
        {
            SqlConnectionStringBuilder scsb= new SqlConnectionStringBuilder();

            scsb.DataSource = ServerName;
            scsb.UserID = UserName;
            scsb.Password = Password;
            scsb.InitialCatalog = DatabaseName;

            if (sqlConnection != null) Disconnect();

            sqlConnection = new SqlConnection(scsb.ConnectionString);

            sqlConnection.Open();
        }

        /// <summary>
        /// 切断
        /// </summary>
        public void Disconnect()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
        }

        /// <summary>
        /// SQL実行
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public DataTable ExecuteSql(string sql)
        {
            using (SqlCommand sc = new SqlCommand(sql, sqlConnection))
            {
                using (SqlDataReader sdr = sc.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    return dt;
                }
            }

        }

        /// <summary>
        /// SQL実行
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int ExecuteSqlNonQuery(string sql)
        {
            using (SqlCommand sc = new SqlCommand(sql, sqlConnection))
            {
                return sc.ExecuteNonQuery();
            }
        }

        #endregion

    }
}
