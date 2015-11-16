using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class User
    {
        private int m_UId;
        private string m_UName;
        private string m_LoginName;
        private string m_Password;

        public User()
        {
            m_UId = 0;
            m_UName = "";
            m_LoginName = "";
            m_Password = "";
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UId
        {
            get { return m_UId; }
            set { m_UId = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string UName
        {
            get { return m_UName; }
            set { m_UName = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string LoginName
        {
            get { return m_LoginName; }
            set { m_LoginName = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }
       
    }
}
