using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class Insure
    {
        private int m_Id;
        private int m_EId;
        private DateTime m_Date;
        private string m_Type;
        private double m_BaseNumber;
        private double m_Company;
        private double m_Person;

        public Insure()
        {
            m_Id = 0;
            m_EId = 0;
            m_Date = DateTime.Now;
            m_Type = "";
            m_BaseNumber=0;
            m_Company = 0;
            m_Person=0;
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
        /// 员工Id
        /// </summary>
        public int EId
        {
            get { return m_EId; }
            set { m_EId = value; }
        }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date
        {
            get { return m_Date; }
            set { m_Date = value; }
        }

        /// <summary>
        /// 保险类型
        /// </summary>
        public string Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        /// <summary>
        /// 缴费基数
        /// </summary>
        public double BaseNumber
        {
            get { return m_BaseNumber; }
            set { m_BaseNumber = value; }
        }

        /// <summary>
        /// 公司缴纳
        /// </summary>
        public double Company
        {
            get { return m_Company; }
            set { m_Company = value; }
        }

        /// <summary>
        /// 个人缴纳
        /// </summary>
        public double Person
        {
            get { return m_Person; }
            set { m_Person = value; }
        }
    }
}
