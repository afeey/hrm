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
    public class EmployeePosTitleBll
    {

        private EmployeePosTitleDal _dal = null;

        public EmployeePosTitleBll()
        {
            _dal = new EmployeePosTitleDal(App.ConnectString);
        }

        /// <summary>
        /// 添加职称评定
        /// </summary>
        /// <param name="record">职称评定对象</param>
        /// <returns>ID</returns>
        public int Insert(EmployeePosTitle record)
        {
            return _dal.Insert(record);
        }

        /// <summary>
        /// 删除职称评定
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改职称评定
        /// </summary>
        /// <param name="record">职称评定对象</param>
        /// <returns>影响行数</returns>
        public int Update(EmployeePosTitle record)
        {
            return _dal.Update(record);
        }

        /// <summary>
        /// 获取职称评定对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>职称评定对象</returns>
        public EmployeePosTitle GetEmployeePosTitle(int id)
        {
            return _dal.GetEmployeePosTitle(id);
        }

        /// <summary>
        /// 获取所有职称评定列表
        /// </summary>
        /// <returns>职称评定集合</returns>
        public IList<EmployeePosTitle> GetAllEmployeePosTitle()
        {
            return _dal.GetAllEmployeePosTitle();
        }

        /// <summary>
        /// 获取员工职称评定集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <returns>职称评定集合</returns>
        public IList<EmployeePosTitle> GetEmployeePosTitleByEId(int eId)
        {
            return _dal.GetEmployeePosTitleByEId(eId);
        }

    }
}
