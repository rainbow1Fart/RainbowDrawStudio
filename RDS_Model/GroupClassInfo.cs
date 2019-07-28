using System;
using System.Collections.Generic;
using System.Data.SQLite;
using RDS_Controller;

namespace RDS_Model
{
    public class GroupClassInfo
    {
        public int ID { get; set; }

        /// <summary>
        /// 小组名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreatePerson { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// 班主任
        /// </summary>
        public string ClassTeacher { get; set; }

        public bool IsDelete { get; set; }


        public static List<GroupClassInfo> Looper(SQLiteDataReader reader)
        {
            if (reader == null)
                return null;
            List<GroupClassInfo> gcList = new List<GroupClassInfo>();
            while (reader.Read())
            {
                gcList.Add(new GroupClassInfo()
                {
                    ID = int.Parse(reader["ID"].ToString()),
                    GroupName = reader["GroupName"].ToString(),
                    CreateDate = string.IsNullOrEmpty(reader["CreateDate"].ToString()) 
                        ? new DateTime(1970, 1, 1) 
                        : DateTime.Parse(reader["CreateDate"].ToString()),
                    CreatePerson = reader["CreatePerson"].ToString(),
                    PersonID = int.Parse(reader["PersonID"].ToString()),
                    ClassTeacher = reader["ClassTeacher"].ToString(),
                    IsDelete = string.IsNullOrEmpty(reader["IsDelete"].ToString()) 
                        ?  false 
                        : (bool)reader["IsDelete"],
                });
            }

            return gcList;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="key"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static List<GroupClassInfo> SimpleQuery(int pageIndex, int pageSize, string key, out int total)
        {
            string sql = string.Format("select * from GroupClassTable where IsDelete is NULL or IsDelete = 0");
            SQLiteDataReader reader = SQLiteControl.ExecuteReader(sql);
            total = Looper(reader).Count;

            sql = string.Format(
                "select * from GroupClassTable where (GroupName like '%{0}%' " +
                "and (IsDelete is NULL or IsDelete = 0) " +
                "limit {1} offset {2}",
                key, pageSize, (pageIndex - 1) * pageSize);
            reader = SQLiteControl.ExecuteReader(sql);
            var result = Looper(reader);
            reader.Close();
            return result;
        }

        /// <summary>
        /// 创建班级
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static int CreateGroup(GroupClassInfo arg)
        {
            string sql =
                string.Format("insert into GroupClassTable values(NULL, '{0}', '{1}','{2}','{3}',{4},'{5}', 0)",
                    arg.GroupName, arg.CreatePerson, arg.CreateDate.ToString("yyyy-MM-dd"), arg.PersonID,
                    arg.ClassTeacher);
            return SQLiteControl.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static int ModifyGroup(GroupClassInfo arg)
        {
            string sql =
                string.Format(
                    "update GroupClassTable set GroupName = '{0}', ClassTeacher = '{1}') where ID ={2}",
                    arg.GroupName, arg.ClassTeacher, arg.ID);
            return SQLiteControl.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 虚假删除组
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public static int Delete(int[] IDs)
        {
            return SQLiteControl.FalseDelete("GroupClassTable", "ID", "IsDelete", IDs);
        }

        /// <summary>
        /// 恢复被删除的组
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public static int Restore(int[] IDs)
        {
            return SQLiteControl.Restore("GroupClassTable", "ID", "IsDelete", IDs);
        }

        /// <summary>
        /// 真正的删除
        /// </summary>
        /// <param name="IDs"></param>
        /// <returns></returns>
        public static int RealyDelete(int[] IDs)
        {
            //删除GroupClassTable的内容
            int result = SQLiteControl.RealyDelete("GroupClassTable", "ID", IDs);
            //删除关联的StudentsCheckinTable内容
            if (result > 0)
                result = SQLiteControl.RealyDelete("StudentsCheckinTable", "GroupID", IDs);
            return result;
        }

        /// <summary>
        /// 为小组添加成员
        /// </summary>
        /// <returns></returns>
        public static int AddMembers(int GroupID, int[] StudentsID)
        {
            if (StudentsID.Length <= 0)
                return -1;
            string sql = string.Format("insert into StudentCheckinTable values(NULL, {0}, {1}", GroupID, StudentsID[0]);
            for (int i = 1; i < StudentsID.Length; i++)
            {
                sql += string.Format("),(NULL, {0}, {1}", GroupID, StudentsID[i]);
            }

            sql += ")";

            return SQLiteControl.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 变更小组成员
        /// </summary>
        /// <param name="GroupID"></param>
        /// <param name="StudentsID"></param>
        /// <returns></returns>
        public static int ModifyMembers(int ID, int[] StudentsID)
        {
            if (StudentsID.Length <= 0)
                return -1;
            string sql = string.Format("update StudentsCheckinTable set StudentID={0} where ID={1}", StudentsID[0], ID);

            sql += ")";

            return SQLiteControl.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 签到
        /// </summary>
        /// <returns></returns>
        public static int Checkin(int[] studentsID)
        {
            return 0;
        }
    }
}
