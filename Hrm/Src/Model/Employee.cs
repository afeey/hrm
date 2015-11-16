using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrm.Model
{
    public class Employee
    {
        private int m_EId;
        private string m_Code;
        private string m_EName;
        private int m_Sex;
        private string m_Country;
        private int m_Married;
        private DateTime m_BirthDay;
        private string m_IdCode;
        private int m_PId;
        private string m_Education;
        private string m_School;
        private string m_Phone;
        private string m_CellPhone;
        private string m_Address;
        private string m_Email;
        private string m_Status;
        private string m_Position;
        private string m_SexStr;
        private string m_MarriedStr;

        public Employee()
        {
            m_EId = 0;
            m_Code = "";
            m_EName = "";
            m_Sex = 0;
            m_Country = "";
            m_Married = 0;
            DateTime m_BirthDay;
            m_IdCode = "";
            m_PId = 0;
            m_Education = "";
            m_School = "";
            m_Phone = "";
            m_CellPhone = "";
            m_Address = "";
            m_Email = "";
            m_Status = "";
            m_Position = "";
            m_SexStr = "";
            m_MarriedStr = "";

        }

        /// <summary>
        /// Id
        /// </summary>
        public int EId
        {
            get { return m_EId; }
            set { m_EId = value; }
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
        /// 姓名
        /// </summary>
        public string EName
        {
            get { return m_EName; }
            set { m_EName = value; }
        }

        /// <summary>
        /// 性别 0男 1女
        /// </summary>
        public int Sex
        {
            get { return m_Sex; }
            set { m_Sex = value; }
        }

        /// <summary>
        /// 国籍
        /// </summary>
        public string Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }

        /// <summary>
        /// 婚否 0未婚 1已婚
        /// </summary>
        public int Married
        {
            get { return m_Married; }
            set { m_Married = value; }
        }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDay
        {
            get { return m_BirthDay; }
            set { m_BirthDay = value; }
        }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCode
        {
            get { return m_IdCode; }
            set { m_IdCode = value; }
        }

        /// <summary>
        /// 职务ID
        /// </summary>
        public int PId
        {
            get { return m_PId; }
            set { m_PId = value; }
        }

        /// <summary>
        /// 学历
        /// </summary>
        public string Education
        {
            get { return m_Education; }
            set { m_Education = value; }
        }

        /// <summary>
        /// 毕业学校
        /// </summary>
        public string School
        {
            get { return m_School; }
            set { m_School = value; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone
        {
            get { return m_Phone; }
            set { m_Phone = value; }
        }

        /// <summary>
        /// 手机
        /// </summary>
        public string CellPhone
        {
            get { return m_CellPhone; }
            set { m_CellPhone = value; }
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        /// <summary>
        /// 人员种类
        /// </summary>
        public string Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }

        /// <summary>
        /// 职务
        /// </summary>
        public string Position
        {
            get { return m_Position; }
            set { m_Position = value; }
        }

        /// <summary>
        /// 性别文本
        /// </summary>
        public string SexStr
        {
            get { return m_SexStr; }
            set { m_SexStr = value; }
        }

        /// <summary>
        /// 婚否文本
        /// </summary>
        public string MarriedStr
        {
            get { return m_MarriedStr; }
            set { m_MarriedStr = value; }
        }

    }
}
