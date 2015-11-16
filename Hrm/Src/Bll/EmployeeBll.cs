using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Hrm.Common;
using Hrm.Model;
using Hrm.Dal;

namespace Hrm.Bll
{
    public class EmployeeBll
    {

        private EmployeeDal _dal = null;

        public EmployeeBll()
        {
            _dal = new EmployeeDal(App.ConnectString);
        }

        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="employee">员工对象</param>
        /// <param name="orgId">部门ID</param>
        /// <returns>ID</returns>
        public int Insert(Employee employee,int orgId)
        {
            return _dal.Insert(employee,orgId);
        }

        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int eId)
        {
            return _dal.Delete(eId);
        }

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="employee">员工对象</param>
        /// <param name="orgId">部门ID</param>
        /// <returns>影响行数</returns>
        public int Update(Employee employee, int orgId)
        {
            return _dal.Update(employee, orgId);
        }

        /// <summary>
        /// 获取员工对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>员工对象</returns>
        public Employee GetEmployee(int eId)
        {
            return _dal.GetEmployee(eId);
        }

         /// <summary>
        /// 根据编号获取员工对象
        /// </summary>
        /// <param name="code">编号</param>
        /// <returns>员工对象</returns>
        public Employee GetEmployee(string code)
        {
            return _dal.GetEmployee(code);
        }

        /// <summary>
        /// 获取所有员工列表
        /// </summary>
        /// <returns>员工集合</returns>
        public IList<Employee> GetAllEmployee()
        {
            return _dal.GetAllEmployee();
        }

        /// <summary>
        /// 根据部门获取员工集合
        /// </summary>
        /// <param name="orgId">部门Id</param>
        /// <returns>员工集合</returns>
        public IList<Employee> GetEmployeeByOrgId(int orgId)
        {
            return _dal.GetEmployeeByOrgId(orgId);
        }

         /// <summary>
        /// 根据条件获取员工集合
        /// </summary>
        /// <param name="condition">条件集合</param>
        /// <returns>员工集合</returns>
        public IList<Employee> GetEmployeeList(Hashtable condition)
        {
            return _dal.GetEmployeeList(condition);
        }
    }
}
