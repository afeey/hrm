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
    public class SalaryRecordBll
    {

        private SalaryRecordDal _dal = null;

        public SalaryRecordBll()
        {
            _dal = new SalaryRecordDal(App.ConnectString);
        }

        /// <summary>
        /// 添加工资记录
        /// </summary>
        /// <param name="record">工资记录对象</param>
        /// <returns>ID</returns>
        public int Insert(SalaryRecord record)
        {
            return _dal.Insert(record);
        }

        /// <summary>
        /// 删除工资记录
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改工资记录
        /// </summary>
        /// <param name="record">工资记录对象</param>
        /// <returns>影响行数</returns>
        public int Update(SalaryRecord record)
        {
            return _dal.Update(record);
        }

        /// <summary>
        /// 获取工资记录对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>工资记录对象</returns>
        public SalaryRecord GetSalaryRecord(int id)
        {
            return _dal.GetSalaryRecord(id);
        }

        /// <summary>
        /// 获取所有工资记录列表
        /// </summary>
        /// <returns>工资记录集合</returns>
        public IList<SalaryRecord> GetAllSalaryRecord()
        {
            return _dal.GetAllSalaryRecord();
        }

        /// <summary>
        /// 获取员工工资记录集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <returns>工资记录集合</returns>
        public IList<SalaryRecord> GetSalaryRecordByEId(int eId)
        {
            return _dal.GetSalaryRecordByEId(eId);
        }

    }
}
