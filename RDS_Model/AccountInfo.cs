using RDS_Controller;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RDS_Model
{
    public class AccountInfo
    {
        public AccountInfo()
        {

        }
        ~AccountInfo()

        {

        }


        /// <summary>
        /// 全局用户信息
        /// </summary>
        public static AccountInfo AccountSession
        {
            get { return _account; }
        }

        private static AccountInfo _account = new AccountInfo();

        /// <summary>
        /// 全局用户信息
        /// </summary>
        private static List<AccountInfo> _accounts = new List<AccountInfo>();

        public int ID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Person { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 安全码
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public int Power { get; set; }




        /// <summary>
        /// 账号检查
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public static bool AccountChecked(string Account)
        {
            string sql = string.Format("select * from UsersTable where Account='{0}'", Account);
            using (SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql))
            {
                if (reader == null)
                    return false;
                int result = 0;
                while (reader.Read())
                    ++result;

                if (result == 1)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 账号密码完全验证
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public static bool AccountFullChecked(string Account, string Password)
        {
            string sql = string.Format("select * from UsersTable where Account='{0}' and Password='{1}'", Account, Password);
            using (SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql))
            {
                if (reader == null)
                    return false;
                int result = 0;
                while (reader.Read())
                {
                    ++result;
                    _account.ID = string.IsNullOrEmpty(reader["ID"].ToString())
                        ? 0
                        : int.Parse(reader["ID"].ToString());
                    _account.Person = reader["Person"].ToString();
                    _account.Account = reader["Account"].ToString();
                    _account.Password = reader["Password"].ToString();
                    _account.Key = reader["Key"].ToString();
                    _account.Power = string.IsNullOrEmpty(reader["Power"].ToString())
                        ? 0
                        : int.Parse(reader["Power"].ToString());
                }
                if (result == 1)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 循环查询后的结果
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static List<AccountInfo> Looper(SQLiteDataReader reader)
        {
            while (reader.Read())
            {
                _accounts.Add(new AccountInfo()
                {
                    ID = string.IsNullOrEmpty(reader["ID"].ToString()) ? 0 : Int32.Parse(reader["ID"].ToString()),
                    Person = reader["Person"].ToString(),
                    Account = reader["Account"].ToString(),
                    Password = reader["Password"].ToString(),
                    Key = reader["Key"].ToString(),
                    Power = string.IsNullOrEmpty(reader["Power"].ToString()) ? 0 : Int32.Parse(reader["Power"].ToString()),
                });
            }

            reader.Close();
            return _accounts;
        }

        public static bool RegisterAccount(AccountInfo account)
        {
            string sql =
                string.Format(
                    "insert into UsersTable values(NULL, '{0}', '{1}', '{2}', '{3}', {4})",
                    account.Person, account.Account, account.Password, account.Key, account.Power);
            int result = SQLiteControl.ExecuteNonQuery(sql);
            if (result != 1)
                return false;
            return true;
        }
    }


}
