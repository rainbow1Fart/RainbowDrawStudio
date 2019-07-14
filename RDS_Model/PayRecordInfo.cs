using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using RDS_Controller;

namespace RDS_Model
{
    public class PayRecordInfo
    {
        public PayRecordInfo()
        {

        }

        ~PayRecordInfo()
        {

        }

        public int ID { get; set; }

        /// <summary>
        /// 学生ID
        /// </summary>
        public int StudentID { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public  string StudentName { get; set; }
        /// <summary>
        /// 最后一次缴费日期
        /// </summary>
        public DateTime LastDateTime { get; set; }
        /// <summary>
        /// 操作人ID
        /// </summary>
        public int OperationID { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperationPerson { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        public DateTime OperationDate { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public  string Remark { get; set; }

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
        /// 是否缴清(true 已缴清 false 未缴清)
        /// </summary>
        public bool Pay { get; set; }

        /// <summary>
        /// 未缴额度
        /// </summary>
        public decimal NotPay { get; set; }


        public static int CreateRecord(PayRecordInfo payRecord)
        {
            string sql = string.Format("insert into PayRecordTable values(NULL,{0},'{1}','{2}',{3},'{4}','{5}',{6},{7},{8},{9},{10},'{11}')", payRecord.StudentID,
                payRecord.StudentName, payRecord.LastDateTime.ToString("yyyy-MM-dd"), payRecord.OperationID,
                payRecord.OperationPerson, payRecord.Remark, payRecord.Tuition, payRecord.Remaining,
                payRecord.ClassHours, payRecord.Pay ? 1 : 0, payRecord.NotPay, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return SQLiteControl.ExecuteNonQuery(sql);
        }

        public static List<PayRecordInfo> SimpleQuery(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = string.Format("select * from PayRecordTable");
            SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            total = Looper(reader).Count;
            sql = string.Format("select * from PayRecordTable where (StudentName like '%{0}%' " +
                                "or OperationPerson like '%{0}%') "+
                                "limit {1} offset {2}", key, pageSize, (pageIndex - 1) * pageSize);
            reader = SQLiteControl.ExecuteReader(sql);
            var result = Looper(reader);
            reader.Close();
            return result;
        }

        private static List<PayRecordInfo> Looper(SQLiteDataReader reader)
        {
            if (reader == null)
            {
                return null;
            }

            List<PayRecordInfo> records = new List<PayRecordInfo>();
            while (reader.Read())
            {
                records.Add(new PayRecordInfo()
                {
                    ID = string.IsNullOrEmpty(reader["ID"].ToString()) ? 0 : int.Parse(reader["ID"].ToString()),
                    StudentID = string.IsNullOrEmpty(reader["StudentID"].ToString())
                        ? 0
                        : int.Parse(reader["StudentID"].ToString()),
                    StudentName = reader["StudentName"].ToString(),
                    LastDateTime = DateTime.Parse(reader["LastDate"].ToString()),
                    OperationID = string.IsNullOrEmpty(reader["OperationPersonID"].ToString())
                        ? 0
                        : int.Parse(reader["OperationPersonID"].ToString()),
                    OperationPerson = reader["OperationPerson"].ToString(),
                    Remark = reader["Remark"].ToString(),
                    Tuition = string.IsNullOrEmpty(reader["Tuition"].ToString())
                        ? 0
                        : decimal.Parse(reader["Tuition"].ToString()),
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
                    OperationDate = DateTime.Parse(reader["OperationDate"].ToString()),
                });
            }

            return records;
        }
    }
}
