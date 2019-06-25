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
        public static void ConnectToDatabase(string dataPath)
        {
            m_dbConnection = new SQLiteConnection("Data Source="+ dataPath);
            m_dbConnection.Open();
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
            using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
            {
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 执行Sql语句并返回 SQLiteDataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SQLiteDataReader ExecuteReader(string sql)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
            {
                return command.ExecuteReader();
            }
        }


    }
}
