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
    public class PositionBll
    {

        private PositionDal _dal = null;

        public PositionBll()
        {
            _dal = new PositionDal(App.ConnectString);
        }

        /// <summary>
        /// 添加职位
        /// </summary>
        /// <param name="position">职位对象</param>
        /// <returns>ID</returns>
        public int Insert(Position position)
        {
            return _dal.Insert(position);
        }

        /// <summary>
        /// 删除职位
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改职位
        /// </summary>
        /// <param name="position">职位对象</param>
        /// <returns>影响行数</returns>
        public int Update(Position position)
        {
            return _dal.Update(position);
        }

        /// <summary>
        /// 获取职位对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>职位对象</returns>
        public Position GetPosition(int id)
        {
            return _dal.GetPosition(id);
        }

        /// <summary>
        /// 获取所有职位列表
        /// </summary>
        /// <returns>职位集合</returns>
        public IList<Position> GetAllPosition()
        {
            return _dal.GetAllPosition();
        }

    }
}
