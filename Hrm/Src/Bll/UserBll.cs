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
    public class UserBll
    {

        private UserDal _dal = null;

        public UserBll()
        {
            _dal = new UserDal(App.ConnectString);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>ID</returns>
        public int Insert(User user)
        {
            return _dal.Insert(user);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            return _dal.Delete(id);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>影响行数</returns>
        public int Update(User user)
        {
            return _dal.Update(user);
        }

        /// <summary>
        /// 获取用户对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>用户对象</returns>
        public User GetUser(int id)
        {
            return _dal.GetUser(id);
        }

         /// <summary>
        /// 根据用户名获取用户
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <returns>用户对象</returns>
        public User GetUser(string loginName)
        {
            return _dal.GetUser(loginName);
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns>用户集合</returns>
        public IList<User> GetAllUser()
        {
            return _dal.GetAllUser();
        }

    }
}
