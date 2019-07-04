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

        /// <summary>
        /// 根据ID去修改指定表名里列的值
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="colIDNames">ID列名</param>
        /// <param name="IDValues">ID值</param>
        /// <param name="changedColNames">需要修改的列名</param>
        /// <param name="changedValues">需要修改的值</param>
        /// <returns></returns>
        public static int SQLiteUpDate(string tableName, string colIDNames, 
            int[] IDValues, string[] changedColNames, string [] changedValues)
        {
            if (changedValues.Length != changedColNames.Length)
                return -1;

            string sql = string.Format("update {0} set {1} = '{2}'", tableName, changedColNames[0], changedValues[0]);
            for (int i = 1; i < changedValues.Length; i++)
            {
                sql += string.Format(", {0} = '{1}'", changedColNames[i], changedValues[i]);
            }

            sql += string.Format("where {0} in ({1}", colIDNames, IDValues[0]);
            for (int i = 1; i < IDValues.Length; i++)
            {
                sql += string.Format(", {0}", IDValues[i]);
            }

            sql += ")";

            return ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 按指定的表名去修改指定Id列里IsDelete的值
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="idColName">ID列名</param>
        /// <param name="deleteColName">Delete列名</param>
        /// <param name="vales">ID列值</param>
        /// <returns></returns>
        public static int FalseDelete(string tableName, string idColName, string deleteColName, int[] vales)
        {
            int length = vales.Length;
            if (length == 0)
                return 0;
            string sql = string.Format("update {0} set {1} = 1 where {2} in ({3}", tableName, deleteColName, idColName,
                vales[0]);
            for (int i = 1; i < length; i++)
            {
                sql += string.Format(",{0}", vales[i]);
            }

            sql += ")";
            return SQLiteControl.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 按指定的表名去修改指定Id列里IsDelete的值
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="idColName">ID列名</param>
        /// <param name="deleteColName">Delete列名</param>
        /// <param name="vales">ID列值</param>
        /// <returns></returns>
        public static int Restore(string tableName, string idColName, string deleteColName, int[] vales)
        {
            int length = vales.Length;
            if (length == 0)
                return 0;
            string sql = string.Format("update {0} set {1} = 0 where {2} in ({3}", tableName, deleteColName, idColName,
                vales[0]);
            for (int i = 1; i < length; i++)
            {
                sql += string.Format(",{0}", vales[i]);
            }

            sql += ")";
            return SQLiteControl.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 从数据库彻底删除指定数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="idColName">ID列名</param>
        /// <param name="vales">ID列值</param>
        /// <returns></returns>
        public static int RealyDelete(string tableName, string idColName, int[] vales)
        {
            int length = vales.Length;
            if (length == 0)
                return 0;
            string sql = string.Format("delete from {0} where {1} in ({2}", tableName, idColName,
                vales[0]);
            for (int i = 1; i < length; i++)
            {
                sql += string.Format(",{0}", vales[i]);
            }

            sql += ")";
            return SQLiteControl.ExecuteNonQuery(sql);
        }

    }
}
