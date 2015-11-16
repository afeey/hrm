using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class EmployeePosTitle
    {
        private int m_ID;
        private int m_EId;
        private int m_PTId;
        private DateTime m_ObtainDate;
        private string m_ObtainWay;
        private string m_EmployCompany;
        private int m_PId;
        private DateTime m_StartDate;
        private DateTime m_EndDate;

        private string m_Code;
        private string m_EName;
        private string m_PostionName;
        private string m_PosName;

        public EmployeePosTitle()
        {
            m_ID = 0;
            m_EId = 0;
            m_PTId = 0;
            m_ObtainDate = DateTime.Now;
            m_ObtainWay = "";
            m_EmployCompany = "";
            m_PId = 0;
            m_StartDate = DateTime.Now;
            m_EndDate = DateTime.Now;

            m_Code = "";
            m_EName = "";
            m_PostionName = "";
            m_PosName = "";
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
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
        /// 职称ID
        /// </summary>
        public int PTId
        {
            get { return m_PTId; }
            set { m_PTId = value; }
        }

        /// <summary>
        /// 取得日期
        /// </summary>
        public DateTime ObtainDate
        {
            get { return m_ObtainDate; }
            set { m_ObtainDate = value; }
        }

        /// <summary>
        /// 取得方式
        /// </summary>
        public string ObtainWay
        {
            get { return m_ObtainWay; }
            set { m_ObtainWay = value; }
        }

        /// <summary>
        /// 聘用单位
        /// </summary>
        public string EmployCompany
        {
            get { return m_EmployCompany; }
            set { m_EmployCompany = value; }
        }

        /// <summary>
        /// 聘用职务
        /// </summary>
        public int PId
        {
            get { return m_PId; }
            set { m_PId = value; }
        }

        /// <summary>
        /// 聘用起始日期
        /// </summary>
        public DateTime StartDate
        {
            get { return m_StartDate; }
            set { m_StartDate = value; }
        }

        /// <summary>
        /// 聘用结束日期
        /// </summary>
        public DateTime EndDate
        {
            get { return m_EndDate; }
            set { m_EndDate = value; }
        }

        /// <summary>
        /// 员工编号
        /// </summary>
        public string Code
        {
            get { return m_Code; }
            set { m_Code = value; }
        }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EName
        {
            get { return m_EName; }
            set { m_EName = value; }
        }


        /// <summary>
        /// 职务名称
        /// </summary>
        public string PositionName
        {
            get { return m_PostionName; }
            set { m_PostionName = value; }
        }

        /// <summary>
        /// 职称名称
        /// </summary>
        public string PosName
        {
            get { return m_PosName; }
            set { m_PosName = value; }
        }

       
    }
}
