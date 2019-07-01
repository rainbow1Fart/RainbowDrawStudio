using RDS_Controller;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RDS_Model
{
    public class StudentsInfo
    {
        private StudentsInfo()
        {

        }

        ~StudentsInfo()
        {

        }

        public int ID { get; set; }

        /// <summary>
        /// 学生编号
        /// </summary>
        public string SeriaNum { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 家属姓名
        /// </summary>
        public string Parents { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string Contacts { get; set; }

        /// <summary>
        /// 家庭地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 总学费
        /// </summary>
        public decimal Tuition { get; set; }

        /// <summary>
        /// 剩余课时
        /// </summary>
        public int Remaining { get; set; }

        /// <summary>
        /// 总课时
        /// </summary>
        public int ClassHours { get; set; }

        /// <summary>
        /// 是否缴清
        /// </summary>
        public bool Pay { get; set; }

        /// <summary>
        /// 未缴额度
        /// </summary>
        public decimal NotPay { get; set; }

        public static List<StudentsInfo> Looper(SQLiteDataReader reader)
        {
            if (reader == null)
            {
                return null;
            }

            List<StudentsInfo> students = new List<StudentsInfo>();
            while (reader.Read())
            {
                students.Add(new StudentsInfo()
                {
                    ID = string.IsNullOrEmpty(reader["ID"].ToString()) ? 0 : Int32.Parse(reader["ID"].ToString()),
                    SeriaNum = reader["SeriaNum"].ToString(),
                    Name = reader["Name"].ToString(),
                    Sex = reader["Sex"].ToString(),
                    Parents = reader["Parents"].ToString(),
                    Contacts = reader["Contacts"].ToString(),
                    Address = reader["Address"].ToString(),
                    Tuition = string.IsNullOrEmpty(reader["Tuition"].ToString())
                        ? 0
                        : decimal.Parse(reader["Tution"].ToString()),
                    Remaining = string.IsNullOrEmpty(reader["Remaining"].ToString())
                        ? 0
                        : Int32.Parse(reader["Remaining"].ToString()),
                    ClassHours = string.IsNullOrEmpty(reader["ClassHours"].ToString())
                        ? 0
                        : Int32.Parse(reader["ClassHours"].ToString()),
                    Pay = (bool) reader["Pay"],
                    NotPay = string.IsNullOrEmpty(reader["NotPay"].ToString())
                        ? 0
                        : decimal.Parse(reader["NotPay"].ToString()),
                });
            }

            reader.Dispose();
            return students;
        }

        /// <summary>
        /// 查询没有被删除的学生信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="key"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static List<StudentsInfo> SimpleQuerry(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = string.Format("select * from StudentsTable where IsDelete is NULL or IsDelete = 0");
            SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            total = Looper(reader).Count;
            reader.Close();

            sql = string.Format(
                "select * from StudentsTable where (SeriaNum like '%{0}%' " +
                "or Name like '%{0}%' or Parents like '%{0}%' " +
                "or Address like '%{0}%') " +
                "and (IsDelete is NULL or IsDelete = 0) " +
                "limit {1} offset {2}",
                key, pageSize, (pageIndex - 1) * pageSize);
            reader = SQLiteControl.ExecuteReader(sql);
            return Looper(reader);
        }

        /// <summary>
        /// 查询被删除的学生信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="key"></param>
        /// <param name="total"></param>
        /// <returns></returns>

        public static List<StudentsInfo> RealyQuerry(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = string.Format("select * from StudentsTable where IsDelete = 1");
            SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            total = Looper(reader).Count;
            reader.Close();

            sql = string.Format(
                "select * from StudentsTable where (SeriaNum like '%{0}%' " +
                "or Name like '%{0}%' or Parents like '%{0}%' " +
                "or Address like '%{0}%') " +
                "and (IsDelete is not NULL or IsDelete = 0) " +
                "limit {1} offset {2}",
                key, pageSize, (pageIndex - 1) * pageSize);
            reader = SQLiteControl.ExecuteReader(sql);
            return Looper(reader);
        }

        /// <summary>
        /// 批量删除(虚假删除)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int FalseDelete(int[] IDs)
        {
            return SQLiteControl.FalseDelete("StudentsTable", "ID", "IsDelete", IDs);
        }

        /// <summary>
        /// 批量删除（彻底从数据库移除）
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RealyDelete(int[] IDs)
        {
            return SQLiteControl.RealyDelete("StudentsTable", "ID", IDs);
        }


    }
}
