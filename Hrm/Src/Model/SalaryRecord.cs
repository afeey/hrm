using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class SalaryRecord
    {
        private int m_Id;
        private int m_EId;
        private DateTime m_Date;
        private double m_Salary;

        public SalaryRecord()
        {
            m_Id = 0;
            m_EId = 0;
            m_Date = DateTime.Now;
            m_Salary = 0;
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
        /// 工资
        /// </summary>
        public double Salary
        {
            get { return m_Salary; }
            set { m_Salary = value; }
        }
    }
}
