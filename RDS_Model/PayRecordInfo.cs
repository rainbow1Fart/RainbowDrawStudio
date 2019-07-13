using System;
using System.Collections.Generic;
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
            string sql = string.Format("insert into PayRecord values(NULL,{0},'{1},'{2},'{3}',{4},'{5}','{6}',{7},{8},{9},{10},{11})", payRecord.StudentID,
                payRecord.StudentName, payRecord.LastDateTime.ToString("yyyy-MM-dd"), payRecord.OperationID,
                payRecord.OperationPerson, payRecord.Remark, payRecord.Tuition, payRecord.Remaining,
                payRecord.ClassHours, payRecord.Pay ? 1 : 0, payRecord.NotPay);
            return SQLiteControl.ExecuteNonQuery(sql);
        }
    }
}
