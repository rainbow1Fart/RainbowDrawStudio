using RDS_Controller;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RDS_Model
{
    public class StudentInfo: CSbase
    {
        public StudentInfo()
        {

        }

        ~StudentInfo()
        {

        }

        /// <summary>
        /// 学生编号
        /// </summary>
        public string SerialNum { get; set; }

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
        /// 已缴学费
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

        /// <summary>
        /// 最后一次缴费日期
        /// </summary>
        public DateTime LastPayDate { get; set; }

        public bool Checkin { get; set; }

        public static List<StudentInfo> Looper(SQLiteDataReader reader)
        {
            if (reader == null)
            {
                return null;
            }

            List<StudentInfo> students = new List<StudentInfo>();
            while (reader.Read())
            {
                StudentInfo stu = new StudentInfo();
                stu.ID = string.IsNullOrEmpty(reader["ID"].ToString()) ? 0 : int.Parse(reader["ID"].ToString());
                stu.SerialNum = reader["SerialNum"].ToString();
                stu.Name = reader["Name"].ToString();
                stu.Sex = reader["Sex"].ToString();
                stu.Parents = reader["Parents"].ToString();
                stu.Contacts = reader["Contacts"].ToString();
                stu.Address = reader["Address"].ToString();
                stu.Tuition = string.IsNullOrEmpty(reader["Tuition"].ToString())
                    ? 0
                    : decimal.Parse(reader["Tuition"].ToString());
                stu.Remaining = string.IsNullOrEmpty(reader["Remaining"].ToString())
                    ? 0
                    : Int32.Parse(reader["Remaining"].ToString());
                stu.ClassHours = string.IsNullOrEmpty(reader["ClassHours"].ToString())
                    ? 0
                    : Int32.Parse(reader["ClassHours"].ToString());
                stu.Pay = (bool) reader["Pay"];
                stu.NotPay = string.IsNullOrEmpty(reader["NotPay"].ToString())
                    ? 0
                    : decimal.Parse(reader["NotPay"].ToString());
                if (string.IsNullOrEmpty(reader["LastPayDate"].ToString()))
                    stu.LastPayDate = new DateTime(1970,1,1);
                else
                    stu.LastPayDate = DateTime.Parse(reader["LastPayDate"].ToString());
                students.Add(stu);
            }
            reader.Close();
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
        public static List<StudentInfo> SimpleQuery(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = string.Format("select * from StudentsTable where IsDelete is NULL or IsDelete = 0");
            SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            total = Looper(reader).Count;

            sql = string.Format(
                "select * from StudentsTable where (SerialNum like '%{0}%' " +
                "or Name like '%{0}%' or Parents like '%{0}%' " +
                "or Address like '%{0}%') " +
                "and (IsDelete is NULL or IsDelete = 0) " +
                "limit {1} offset {2}",
                key, pageSize, (pageIndex - 1) * pageSize);
            reader = SQLiteControl.ExecuteReader(sql);
            var result = Looper(reader);
            reader.Close();
            return result;
        }

        /// <summary>
        /// 根据ID去查询学生信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static StudentInfo QueryFromID(int ID)
        {
            return Looper((SQLiteControl.QueryFromID("StudentsTable", "ID", ID)))[0];
        }

        /// <summary>
        /// 查询被删除的学生信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="key"></param>
        /// <param name="total"></param>
        /// <returns></returns>

        public static List<StudentInfo> RealyQuerry(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = string.Format("select * from StudentsTable where IsDelete = 1");
            SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            total = Looper(reader).Count;
            reader.Close();

            sql = string.Format(
                "select * from StudentsTable where (SerialNum like '%{0}%' " +
                "or Name like '%{0}%' or Parents like '%{0}%' " +
                "or Address like '%{0}%') " +
                "and IsDelete = 1 " +
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

        /// <summary>
        /// 恢复选中的数据
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public static int Restore(int[] IDs)
        {
            return SQLiteControl.Restore("StudentsTable", "ID", "IsDelete", IDs);
        }

        /// <summary>
        /// 创建学生
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public static int CreateStudentInfo(StudentInfo stu)
        {
            string sql = string.Format("insert into StudentsTable values(NULL,'{0}','{1}','{2}','{3}','{4}','{5}',{6},{7},{8},{9},'{10}',{11}, {12})", stu.SerialNum,
                stu.Name, stu.Sex, stu.Parents, stu.Contacts, stu.Address, stu.Tuition, stu.Remaining, stu.ClassHours,
                stu.Pay ? 1 : 0, stu.LastPayDate.ToString("yyyy-MM-dd"), stu.NotPay, 0);
            return SQLiteControl.ExecuteNonQuery(sql);
        }

        public static int Updata(StudentInfo stu)
        {
            string sql = string.Format("update StudentsTable set Name='{0}', Sex='{1}',Parents='{2}',Contacts='{3}',Address='{4}',Tuition={5},Remaining={6},ClassHours={7},Pay={8},LastPayDate='{9}',NotPay={10} where ID={11}",
                stu.Name, stu.Sex, stu.Parents, stu.Contacts, stu.Address, stu.Tuition, stu.Remaining, stu.ClassHours,
                stu.Pay ? 1 : 0, stu.LastPayDate.ToString("yyyy-MM-dd"), stu.NotPay,stu.ID);
            return SQLiteControl.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 重写Equals，判断当ID相等时就认为是相同的
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            StudentInfo m = obj as StudentInfo;
            if (this.ID == m.ID)
            {
                return true;
            }
            return false;
        }
    }
}
