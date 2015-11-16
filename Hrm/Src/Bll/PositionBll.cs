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
    public class PosTitleBll
    {

        private PosTitleDal _dal = null;

        public PosTitleBll()
        {
            _dal = new PosTitleDal(App.ConnectString);
        }

        /// <summary>
        /// 添加职称
        /// </summary>
        /// <param name="posTitle">职称对象</param>
        /// <returns>ID</returns>
        public int Insert(PosTitle posTitle)
        {
            return _dal.Insert(posTitle);
        }

        /// <summary>
        /// 删除职称
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改职称
        /// </summary>
        /// <param name="posTitle">职称对象</param>
        /// <returns>影响行数</returns>
        public int Update(PosTitle posTitle)
        {
            return _dal.Update(posTitle);
        }

        /// <summary>
        /// 获取职称对象
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>职称对象</returns>
        public PosTitle GetPosTitle(int id)
        {
            return _dal.GetPosTitle(id);
        }

        /// <summary>
        /// 获取所有职称列表
        /// </summary>
        /// <returns>职称集合</returns>
        public IList<PosTitle> GetAllPosTitle()
        {
            return _dal.GetAllPosTitle();
        }

    }
}
