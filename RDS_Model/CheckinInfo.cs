using System;
using System.Collections.Generic;
using System.Data.SQLite;
using RDS_Controller;

namespace RDS_Model
{
    public class CheckinInfo: CSbase
    {
        public int GroupID { get; set; }
        public int StudentID { get; set; }


        public static List<CheckinInfo> Query(int GroupID)
        {
            string sql = string.Format("select * from StudentsCheckinTable where GroupID = {0}", GroupID);
            return Looper(SQLiteControl.ExecuteReader(sql));
        }

        private static List<CheckinInfo> Looper(SQLiteDataReader reader)
        {
            if (reader == null)
                return null;
            List<CheckinInfo> resultList = new List<CheckinInfo>();
            while (reader.Read())
            {
                resultList.Add(new CheckinInfo()
                {
                    ID = int.Parse(reader["ID"].ToString()),
                    GroupID = int.Parse(reader["GroupID"].ToString()),
                    StudentID = int.Parse(reader["StudentID"].ToString()),
                });
            }

            return resultList;
        }

        /// <summary>
        /// 为小组添加成员
        /// </summary>
        /// <returns></returns>
        public static int AddMembers(int GroupID, int[] StudentsID)
        {
            if (StudentsID.Length <= 0)
                return -1;
            string sql = string.Format("insert into StudentsCheckinTable values(NULL, {0}, {1}", GroupID, StudentsID[0]);
            for (int i = 1; i < StudentsID.Length; i++)
            {
                sql += string.Format("),(NULL, {0}, {1}", GroupID, StudentsID[i]);
            }

            sql += ")";

            return SQLiteControl.ExecuteNonQuery(sql);
        }

        public static int DeleteMemebers(int GroupID, int StudentsID)
        {
            string sql = string.Format("delete from StudentsCheckinTable where GroupID = {0} and StudentID = {1}", GroupID, StudentsID);
            return SQLiteControl.ExecuteNonQuery(sql);
        }
    }
}
