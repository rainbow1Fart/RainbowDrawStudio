using RDS_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDS_Model
{
    public class CheckinRecordInfo
    {
        public int ID { get; set; }

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
    }
}
