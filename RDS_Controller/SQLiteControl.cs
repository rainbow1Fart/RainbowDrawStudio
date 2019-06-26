using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDS_Controller
{
    public class SQLiteControl
    {
        //数据库连接
        private static SQLiteConnection m_dbConnection;
        public SQLiteControl()
        {
        }

        ~SQLiteControl()
        {

        }

        /// <summary>
        /// 创建一个连接到指定数据库
        /// </summary>
        public static bool ConnectToDatabase(string dataPath)
        {
            m_dbConnection = new SQLiteConnection("Data Source="+ dataPath);
            if (m_dbConnection == null)
                return false;
            m_dbConnection.Open();
            return true;
        }

        /// <summary>
        /// 关闭数据库链接
        /// </summary>
        /// <param name="dataPath"></param>
        public static void CloseToDatabase(string dataPath)
        {
            m_dbConnection.Close();
        }

        /// <summary>
        /// 执行sql语句，并返回操作结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LogsHelper.WriteLog("ExecuteNonQuery()", LogsEnum.Error, ex);
                return -1;
            }
        }

        /// <summary>
        /// 执行Sql语句并返回 SQLiteDataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string sql)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    return command.ExecuteReader();
                }
            }
            catch (System.Exception ex)
            {
                LogsHelper.WriteLog("ExecuteNonQuery()", LogsEnum.Error, ex);
                return null;
            }
        }


    }
}
