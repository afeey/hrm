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
    public class InsureBll
    {

        private InsureDal _dal = null;

        public InsureBll()
        {
            _dal = new InsureDal(App.ConnectString);
        }

        /// <summary>
        /// 添加保险记录
        /// </summary>
        /// <param name="insure">保险记录对象</param>
        /// <returns>ID</returns>
        public int Insert(Insure insure)
        {
            return _dal.Insert(insure);
        }

        /// <summary>
        /// 删除保险记录
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改保险记录
        /// </summary>
        /// <param name="insure">保险记录对象</param>
        /// <returns>影响行数</returns>
        public int Update(Insure insure)
        {
            return _dal.Update(insure);
        }

        /// <summary>
        /// 获取保险记录对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>保险记录对象</returns>
        public Insure GetInsure(int id)
        {
            return _dal.GetInsure(id);
        }

        /// <summary>
        /// 获取所有保险记录列表
        /// </summary>
        /// <returns>保险记录集合</returns>
        public IList<Insure> GetAllInsure()
        {
            return _dal.GetAllInsure();
        }

        /// <summary>
        /// 获取员工保险记录集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <param name="type">保险类型</param>
        /// <returns>保险记录集合</returns>
        public IList<Insure> GetInsureByEId(int eId, string type)
        {
            return _dal.GetInsureByEId(eId, type);
        }

    }
}
