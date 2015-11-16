using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class PosTitle
    {
        private int m_PTId;
        private string m_PName;
        private string m_Comment;

        public PosTitle()
        {
            m_PTId = 0;
            m_PName = "";
            m_Comment = "";
        }

        /// <summary>
        /// 职称ID
        /// </summary>
        public int PTId
        {
            get { return m_PTId; }
            set { m_PTId = value; }
        }

        /// <summary>
        /// 职称名称
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
