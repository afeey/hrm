using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class Organization
    {
        private int m_OId;
        private int m_ParentId;
        private string m_OName;
        private string m_Comment;

        public Organization()
        {
            m_OId = 0;
            m_ParentId = 0;
            m_OName = "";
            m_Comment = "";
        }

        /// <summary>
        /// ID
        /// </summary>
        public int OId
        {
            get { return m_OId; }
            set { m_OId = value; }
        }

        /// <summary>
        /// 上级ID
        /// </summary>
        public int ParentId
        {
            get { return m_ParentId; }
            set { m_ParentId = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string OName
        {
            get { return m_OName; }
            set { m_OName = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comment
        {
            get { return m_Comment; }
            set { m_Comment = value; }
        }

    }
}
