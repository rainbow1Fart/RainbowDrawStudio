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

        public string StrPower
        {
            get
            {
                switch (Power)
                {
                    case -1: return "超级管理员";
                    case 0: return "普通用户";
                    default: return string.Empty;
                }
            }
        }



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
                {
                    return false;
                }

                int result = 0;
                while (reader.Read())
                {
                    ++result;
                }

                if (result == 1)
                {
                    return true;
                }
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
                {
                    return false;
                }

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
                {
                    return true;
                }
            }
            return false;
        }

        public static AccountInfo FindBackChecked(string account, string key)
        {
            string sql = string.Format("select * from UsersTable where Account ='{0}' and Key='{1}'", account,
                Encryption.EncryptBase64(key));
            using (SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql))
            {
                if (reader == null)
                {
                    return null;
                }

                int result = 0;
                while (reader.Read() && result < 1)
                {
                    result++;
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

                if (result != 1)
                    return null;
            }
            return _account;
        }

        /// <summary>
        /// 简单的查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static List<AccountInfo> SimpleQuery(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = "select * from UsersTable where Power >= 0";
            SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            List<AccountInfo> accounts = Looper(reader);
            total = accounts == null ? 0 : accounts.Count;

            sql =
                string.Format(
                    "select * from UsersTable where (Person like '%{0}%' or Account like '%{0}%') and Power >= 0 limit {1} offset {2}",
                    key, pageSize, (pageIndex - 1) * pageSize);
            reader = SQLiteControl.ExecuteReader(sql);
            accounts.Clear();
            accounts = Looper(reader);
            reader.Dispose();
            return accounts;
        }
        public static List<AccountInfo> GetAll()
        {
            string sql = "select * from UsersTable where Power >= 0";
            using (SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql))
            {
                List<AccountInfo> accounts = Looper(reader);
                return accounts;
            }
        }

        public static bool SimpleDelete(int[] id)
        {
            string sql = string.Format("delete from UsersTable where ID in ({0}", id[0]);
            for (int i = 1; i < id.Length; i++)
            {
                sql += string.Format(", {0}", id[i]);
            }
            sql += ")";
            int result = SQLiteControl.ExecuteNonQuery(sql);
            if(result > 0)
                return true;
            return false;
        }

        /// <summary>
        /// 循环查询后的结果
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static List<AccountInfo> Looper(SQLiteDataReader reader)
        {
            if (reader == null)
            {
                return null;
            }
            _accounts.Clear();
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

            reader.Dispose();
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
            {
                return false;
            }

            return true;
        }

        public static int Modify(AccountInfo account)
        {
            return SQLiteControl.SQLiteUpDate("UsersTable", "ID", new int[] {account.ID},
                new string[] {"Person", "Account", "Password", "Key"},
                new string[]
                {
                    account.Person, account.Account, Encryption.EncryptBase64(account.Password),
                    Encryption.EncryptBase64(account.Key)
                });
        }
    }


}
