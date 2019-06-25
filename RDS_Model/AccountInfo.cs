using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDS_Model
{
    public class AccountInfo
    {
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
    }
}
