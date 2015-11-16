using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class Position
    {
        private int m_PId;
        private string m_PName;
        private string m_Comment;

        public Position()
        {
            m_PId = 0;
            m_PName = "";
            m_Comment = "";
        }

        /// <summary>
        /// 职位ID
        /// </summary>
        public int PId
        {
            get { return m_PId; }
            set { m_PId = value; }
        }

        /// <summary>
        /// 职位名称
        /// </summary>
        public string PName
        {
            get { return m_PName; }
            set { m_PName = value; }
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
