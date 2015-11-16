using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class LeaveRecord
    {
        private int m_Id;
        private int m_EId;
        private string m_Type;
        private string m_Approver;
        private DateTime m_StartDate;
        private DateTime m_EndDate;
        private string m_Comment;

        public LeaveRecord()
        {
            m_Id = 0;
            m_EId = 0;
            m_Type = "";
            m_Approver = "";
            m_StartDate = DateTime.Now;
            m_EndDate = DateTime.Now;
            m_Comment = "";
        }

        /// <summary>
        /// Id
        /// </summary>
        public int Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        /// <summary>
        /// 员工ID
        /// </summary>
        public int EId
        {
            get { return m_EId; }
            set { m_EId = value; }
        }

        /// <summary>
        /// 休假类型
        /// </summary>
        public string Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        /// <summary>
        /// 批准人
        /// </summary>
        public string Approver
        {
            get { return m_Approver; }
            set { m_Approver = value; }
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartDate
        {
            get { return m_StartDate; }
            set { m_StartDate = value; }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndDate
        {
            get { return m_EndDate; }
            set { m_EndDate = value; }
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
