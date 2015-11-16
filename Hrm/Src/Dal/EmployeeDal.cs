using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Collections;

using Hrm.Model;

namespace Hrm.Dal
{
    public class EmployeeDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public EmployeeDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="employee">员工对象</param>
        /// <param name="orgId">部门ID</param>
        /// <returns>ID</returns>
        public int Insert(Employee employee,int orgId)
        {
            string sql = "insert into TB_Employee(EName,Code,Sex,Country,Married,BirthDay,IdCode,PId,Education,School,Phone,CellPhone,Address,Email,Status) ";
            sql += "values(@EName,@Code,@Sex,@Country,@Married,@BirthDay,@IdCode,@PId,@Education,@School,@Phone,@CellPhone,@Address,@Email,@Status)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EName",employee.EName),
                new OleDbParameter("@Code",employee.Code),
                new OleDbParameter("@Sex",employee.Sex),
                new OleDbParameter("@Country",employee.Country),
                new OleDbParameter("@Married",employee.Married),
                new OleDbParameter("@BirthDay",employee.BirthDay),
                new OleDbParameter("@IdCode",employee.IdCode),
                new OleDbParameter("@PId",employee.PId),
                new OleDbParameter("@Education",employee.Education),
                new OleDbParameter("@School",employee.School),
                new OleDbParameter("@Phone",employee.Phone),
                new OleDbParameter("@CellPhone",employee.CellPhone),
                new OleDbParameter("@Address",employee.Address),
                new OleDbParameter("@Email",employee.Email),
                new OleDbParameter("@Status",employee.Status)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select max(EId) from TB_Employee");
            int eId=Convert.ToInt32(id);
            string sql1 = "insert into TB_EmployeeOrg(EId,OId) values(" + eId + "," + orgId + ")";
            AccessHelper.ExecuteNonQuery(_connectionString, sql1, param);

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int eId)
        {
            string sql1 = "delete from TB_Employee where EId=" + eId;
            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql1);

            string sql2 = "delete from TB_EmployeeOrg where EId=" + eId;
            AccessHelper.ExecuteNonQuery(_connectionString, sql2);

            string sql3 = "delete from TB_EmployeePosTitle where EId=" + eId;
            AccessHelper.ExecuteNonQuery(_connectionString, sql3);

            string sql4 = "delete from TB_Insure where EId=" + eId;
            AccessHelper.ExecuteNonQuery(_connectionString, sql4);

            string sql5 = "delete from TB_LeaveRecord where EId=" + eId;
            AccessHelper.ExecuteNonQuery(_connectionString, sql5);

            string sql6 = "delete from TB_SalaryRecord where EId=" + eId;
            AccessHelper.ExecuteNonQuery(_connectionString, sql6);
            return count;
        }

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="employee">员工对象</param>
        /// <param name="orgId">部门ID</param>
        /// <returns>影响行数</returns>
        public int Update(Employee employee,int orgId)
        {
            string sql = "update TB_Employee set EName=@EName,Code=@Code,Sex=@Sex,Country=@Country,Married=@Married,BirthDay=@BirthDay,IdCode=@IdCode,PId=@PId,Education=@Education,School=@School,Phone=@Phone,CellPhone=@CellPhone,Address=@Address,Email=@Email,Status=@Status where EId=@EId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EName",employee.EName),
                new OleDbParameter("@Code",employee.Code),
                new OleDbParameter("@Sex",employee.Sex),
                new OleDbParameter("@Country",employee.Country),
                new OleDbParameter("@Married",employee.Married),
                new OleDbParameter("@BirthDay",employee.BirthDay),
                new OleDbParameter("@IdCode",employee.IdCode),
                new OleDbParameter("@PId",employee.PId),
                new OleDbParameter("@Education",employee.Education),
                new OleDbParameter("@School",employee.School),
                new OleDbParameter("@Phone",employee.Phone),
                new OleDbParameter("@CellPhone",employee.CellPhone),
                new OleDbParameter("@Address",employee.Address),
                new OleDbParameter("@Email",employee.Email),
                new OleDbParameter("@Status",employee.Status),
                new OleDbParameter("@EId",employee.EId)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);

            AccessHelper.ExecuteNonQuery(_connectionString, "delete from TB_EmployeeOrg where EId=" + employee.EId);
            string sql1 = "insert into TB_EmployeeOrg(EId,OId) values(" + employee.EId + "," + orgId + ")";
            AccessHelper.ExecuteNonQuery(_connectionString, sql1, param);

            return count;
        }


        /// <summary>
        /// 获取员工对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>员工对象</returns>
        public Employee GetEmployee(int eId)
        {
            Employee employee = null;
            string sql = "select * from TB_Employee where EId=" + eId;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                employee = new Employee();
                employee.EId = (int)row["EId"];
                employee.Code = (string)row["Code"];
                employee.EName = (string)row["EName"];
                employee.Sex = (int)row["Sex"];
                employee.Country = Convert.ToString(row["Country"]);
                employee.Married = (int)row["Married"];
                employee.BirthDay = (DateTime)row["BirthDay"];
                employee.IdCode = Convert.ToString(row["IdCode"]);
                employee.PId = (int)row["PId"];
                employee.Education = Convert.ToString(row["Education"]);
                employee.School = Convert.ToString(row["School"]);
                employee.Phone = Convert.ToString(row["Phone"]);
                employee.CellPhone = Convert.ToString(row["CellPhone"]);
                employee.Address = Convert.ToString(row["Address"]);
                employee.Email = Convert.ToString(row["Email"]);
                employee.Status = (string)row["Status"];

                employee.SexStr = employee.Sex == 0 ? "男" : "女";
                employee.MarriedStr = employee.Married == 0 ? "未婚" : "已婚";
            }
            return employee;
        }

        /// <summary>
        /// 根据编号获取员工对象
        /// </summary>
        /// <param name="code">编号</param>
        /// <returns>员工对象</returns>
        public Employee GetEmployee(string code)
        {
            Employee employee = null;
            string sql = "select * from TB_Employee where code='" + code + "'";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                employee = new Employee();
                employee.EId = (int)row["EId"];
                employee.Code = (string)row["Code"];
                employee.EName = (string)row["EName"];
                employee.Sex = (int)row["Sex"];
                employee.Country = Convert.ToString(row["Country"]);
                employee.Married = (int)row["Married"];
                employee.BirthDay = (DateTime)row["BirthDay"];
                employee.IdCode = Convert.ToString(row["IdCode"]);
                employee.PId = (int)row["PId"];
                employee.Education = Convert.ToString(row["Education"]);
                employee.School = Convert.ToString(row["School"]);
                employee.Phone = Convert.ToString(row["Phone"]);
                employee.CellPhone = Convert.ToString(row["CellPhone"]);
                employee.Address = Convert.ToString(row["Address"]);
                employee.Email = Convert.ToString(row["Email"]);
                employee.Status = (string)row["Status"];

                employee.SexStr = employee.Sex == 0 ? "男" : "女";
                employee.MarriedStr = employee.Married == 0 ? "未婚" : "已婚";
            }
            return employee;
        }

        /// <summary>
        /// 获取所有员工列表
        /// </summary>
        /// <returns>员工集合</returns>
        public IList<Employee> GetAllEmployee()
        {
            IList<Employee> list = new List<Employee>();

            string sql = "select * from TB_Employee order by Code asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Employee employee = new Employee();
                    employee.EId = (int)row["EId"];
                    employee.Code = (string)row["Code"];
                    employee.EName = (string)row["EName"];
                    employee.Sex = (int)row["Sex"];
                    employee.Country = Convert.ToString(row["Country"]);
                    employee.Married = (int)row["Married"];
                    employee.BirthDay = (DateTime)row["BirthDay"];
                    employee.IdCode = Convert.ToString(row["IdCode"]);
                    employee.PId = (int)row["PId"];
                    employee.Education = Convert.ToString(row["Education"]);
                    employee.School = Convert.ToString(row["School"]);
                    employee.Phone = Convert.ToString(row["Phone"]);
                    employee.CellPhone = Convert.ToString(row["CellPhone"]);
                    employee.Address = Convert.ToString(row["Address"]);
                    employee.Email = Convert.ToString(row["Email"]);
                    employee.Status = (string)row["Status"];

                    employee.SexStr = employee.Sex == 0 ? "男" : "女";
                    employee.MarriedStr = employee.Married == 0 ? "未婚" : "已婚";

                    list.Add(employee);
                }
            }

            return list;
        }

        /// <summary>
        /// 根据部门获取员工集合
        /// </summary>
        /// <param name="orgId">部门Id</param>
        /// <returns>员工集合</returns>
        public IList<Employee> GetEmployeeByOrgId(int orgId)
        {
            IList<Employee> list = new List<Employee>();

            string sql = "select E.* from TB_Employee E,TB_EmployeeOrg EO";
            sql+=" where E.EId=EO.Eid";
            sql+=" and EO.OId="+orgId;
            sql += " order by Code asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Employee employee = new Employee();
                    employee.EId = (int)row["EId"];
                    employee.Code = (string)row["Code"];
                    employee.EName = (string)row["EName"];
                    employee.Sex = (int)row["Sex"];
                    employee.Country = Convert.ToString(row["Country"]);
                    employee.Married = (int)row["Married"];
                    employee.BirthDay = (DateTime)row["BirthDay"];
                    employee.IdCode = Convert.ToString(row["IdCode"]);
                    employee.PId = (int)row["PId"];
                    employee.Education = Convert.ToString(row["Education"]);
                    employee.School = Convert.ToString(row["School"]);
                    employee.Phone = Convert.ToString(row["Phone"]);
                    employee.CellPhone = Convert.ToString(row["CellPhone"]);
                    employee.Address = Convert.ToString(row["Address"]);
                    employee.Email = Convert.ToString(row["Email"]);
                    employee.Status = (string)row["Status"];

                    employee.SexStr = employee.Sex == 0 ? "男" : "女";
                    employee.MarriedStr = employee.Married == 0 ? "未婚" : "已婚";

                    list.Add(employee);
                }
            }

            return list;
        }

        /// <summary>
        /// 根据条件获取员工集合
        /// </summary>
        /// <param name="condition">条件集合</param>
        /// <returns>员工集合</returns>
        public IList<Employee> GetEmployeeList(Hashtable condition)
        {
            IList<Employee> list = new List<Employee>();

            string sql = " select * from TB_Employee where 1=1";

            if(condition.Count>0){
                if (condition.ContainsKey("Code") && condition["Code"].ToString().Length>0)
                {
                    sql += " and Code like '%"+condition["Code"]+"%' ";
                }
                if (condition.ContainsKey("EName") && condition["EName"].ToString().Length>0)
                {
                    sql += " and EName like '%" + condition["EName"] + "%' ";
                }
            }
            
            sql+=" order by Code asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Employee employee = new Employee();
                    employee.EId = (int)row["EId"];
                    employee.Code = (string)row["Code"];
                    employee.EName = (string)row["EName"];
                    employee.Sex = (int)row["Sex"];
                    employee.Country = Convert.ToString(row["Country"]);
                    employee.Married = (int)row["Married"];
                    employee.BirthDay = (DateTime)row["BirthDay"];
                    employee.IdCode = Convert.ToString(row["IdCode"]);
                    employee.PId = (int)row["PId"];
                    employee.Education = Convert.ToString(row["Education"]);
                    employee.School = Convert.ToString(row["School"]);
                    employee.Phone = Convert.ToString(row["Phone"]);
                    employee.CellPhone = Convert.ToString(row["CellPhone"]);
                    employee.Address = Convert.ToString(row["Address"]);
                    employee.Email = Convert.ToString(row["Email"]);
                    employee.Status = (string)row["Status"];

                    employee.SexStr = employee.Sex == 0 ? "男" : "女";
                    employee.MarriedStr = employee.Married == 0 ? "未婚" : "已婚";

                    list.Add(employee);
                }
            }

            return list;
        }

    }
}
