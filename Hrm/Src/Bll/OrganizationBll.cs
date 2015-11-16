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
    public class OrganizationBll
    {

        private OrganizationDal _dal = null;

        public OrganizationBll()
        {
            _dal = new OrganizationDal(App.ConnectString);
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="org">部门对象</param>
        /// <returns>ID</returns>
        public int Insert(Organization org)
        {
            return _dal.Insert(org);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="org">部门对象</param>
        /// <returns>影响行数</returns>
        public int Update(Organization org)
        {
            return _dal.Update(org);
        }

        /// <summary>
        /// 获取部门对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>部门对象</returns>
        public Organization GetOrganization(int id)
        {
            return _dal.GetOrganization(id);
        }

        /// <summary>
        /// 根据员工ID获取部门对象
        /// </summary>
        /// <param name="eId">员工ID</param>
        /// <returns>部门对象</returns>
        public Organization GetOrganizationByEId(int eId)
        {
            return _dal.GetOrganizationByEId(eId);
        }

        /// <summary>
        /// 获取所有部门列表
        /// </summary>
        /// <returns>部门集合</returns>
        public IList<Organization> GetAllOrganization()
        {
            return _dal.GetAllOrganization();
        }

        /// <summary>
        /// 获取下级部门列表
        /// </summary>
        /// <param name="id">部门Id</param>
        /// <returns>部门集合</returns>
        public IList<Organization> GetChildOrganization(int id)
        {
            return _dal.GetChildOrganization(id);
        }
    }
}
