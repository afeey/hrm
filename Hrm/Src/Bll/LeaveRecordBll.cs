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
    public class LeaveRecordBll
    {

        private LeaveRecordDal _dal = null;

        public LeaveRecordBll()
        {
            _dal = new LeaveRecordDal(App.ConnectString);
        }

        /// <summary>
        /// 添加休假记录
        /// </summary>
        /// <param name="record">休假记录对象</param>
        /// <returns>ID</returns>
        public int Insert(LeaveRecord record)
        {
            return _dal.Insert(record);
        }

        /// <summary>
        /// 删除休假记录
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改休假记录
        /// </summary>
        /// <param name="record">休假记录对象</param>
        /// <returns>影响行数</returns>
        public int Update(LeaveRecord record)
        {
            return _dal.Update(record);
        }

        /// <summary>
        /// 获取休假记录对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>休假记录对象</returns>
        public LeaveRecord GetLeaveRecord(int id)
        {
            return _dal.GetLeaveRecord(id);
        }

        /// <summary>
        /// 获取所有休假记录列表
        /// </summary>
        /// <returns>休假记录集合</returns>
        public IList<LeaveRecord> GetAllLeaveRecord()
        {
            return _dal.GetAllLeaveRecord();
        }

        /// <summary>
        /// 获取员工休假记录集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <returns>休假记录集合</returns>
        public IList<LeaveRecord> GetLeaveRecordByEId(int eId)
        {
            return _dal.GetLeaveRecordByEId(eId);
        }
    }
}
