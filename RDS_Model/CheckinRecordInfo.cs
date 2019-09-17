using RDS_Controller;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace RDS_Model
{
    public class CheckinRecordInfo: CSbase
    {
        public int OperationerID { get; set; }

        public string Operation { get; set; }

        public DateTime OperationDate { get; set; }

        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public static int AddRecord(StudentInfo stu)
        {
            string sql = string.Format("insert into CheckRecordTable values(NULL, {0},'{1}', '{2}', {3}, '{4}')", 
                AccountInfo.AccountSession.ID, AccountInfo.AccountSession.Person, DateTime.Now.ToString("yyyy-MM-dd"), stu.ID, stu.Name);

            return SQLiteControl.ExecuteNonQuery(sql);
        }

        public static List<CheckinRecordInfo> SimpleQuery(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = string.Format("select * from CheckRecordTable");
            System.Data.SQLite.SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            total = Looper(reader).Count;

            sql = string.Format(
                "select * from CheckRecordTable  where (Operation like '%{0}%' " +
                "or StudentName like '%{0}%')" +
                "limit {1} offset {2}",
                key, pageSize, (pageIndex - 1) * pageSize);
            reader = SQLiteControl.ExecuteReader(sql);
            List<CheckinRecordInfo> results = Looper(reader);
            reader.Close();
            return results;
        }

        private static List<CheckinRecordInfo> Looper(SQLiteDataReader reader)
        {
            if (reader == null)
            {
                return null;
            }

            List<CheckinRecordInfo> temps = new List<CheckinRecordInfo>();
            while (reader.Read())
            {
                CheckinRecordInfo tmp = new CheckinRecordInfo();
                tmp.ID = string.IsNullOrEmpty(reader["ID"].ToString()) ? 0 : int.Parse(reader["ID"].ToString());
                tmp.OperationerID = string.IsNullOrEmpty(reader["OperationerID"].ToString()) ? 0 : int.Parse(reader["OperationerID"].ToString());
                tmp.Operation = reader["Operation"].ToString();
                tmp.StudentID = string.IsNullOrEmpty(reader["StudentID"].ToString()) ? 0 : int.Parse(reader["StudentID"].ToString());
                tmp.StudentName = reader["StudentName"].ToString();

                if (string.IsNullOrEmpty(reader["OperationDate"].ToString()))
                    tmp.OperationDate = new DateTime(1970, 1, 1);
                else
                    tmp.OperationDate = DateTime.Parse(reader["OperationDate"].ToString());
                temps.Add(tmp);
            }
            reader.Close();
            return temps;
        }
    }
}
