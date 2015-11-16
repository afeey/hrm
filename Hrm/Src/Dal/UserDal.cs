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
    public class UserDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public UserDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>ID</returns>
        public int Insert(User user)
        {
            string sql = "insert into TB_User(UName,LoginName,[Password]) ";
            sql += "values(@UName,@LoginName,@Password) ";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@UName",user.UName),
                new OleDbParameter("@LoginName",user.LoginName),
                new OleDbParameter("@Password",user.Password)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_User where UId=@UId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@UId",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>影响行数</returns>
        public int Update(User user)
        {
            string sql = "update TB_User set UName=@UName,LoginName=@LoginName,[Password]=@Password where UId=@UId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@UName",user.UName),
                new OleDbParameter("@LoginName",user.LoginName),
                new OleDbParameter("@Password",user.Password),
                new OleDbParameter("@UId",user.UId)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取用户对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>用户对象</returns>
        public User GetUser(int id)
        {
            User user = null;
            string sql = "select * from TB_User where UId=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                user = new User();
                user.UId = (int)row["UId"];
                user.UName = (string)row["UName"];
                user.LoginName = (string)row["LoginName"];
                user.Password = (string)row["Password"];
            }
            return user;
        }

        /// <summary>
        /// 根据用户名获取用户
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <returns>用户对象</returns>
        public User GetUser(string loginName)
        {
            User user = null;
            string sql = "select * from TB_User where LoginName=@LoginName";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@LoginName",loginName)
            };

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql, param);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                user = new User();
                user.UId = (int)row["UId"];
                user.UName = (string)row["UName"];
                user.LoginName = (string)row["LoginName"];
                user.Password = (string)row["Password"];
            }
            return user;
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns>用户集合</returns>
        public IList<User> GetAllUser()
        {
            IList<User> list = new List<User>();

            string sql = "select * from TB_User order by UName asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    User user = new User();
                    user.UId = (int)row["UId"];
                    user.UName = (string)row["UName"];
                    user.LoginName = (string)row["LoginName"];
                    user.Password = (string)row["Password"];

                    list.Add(user);
                }
            }

            return list;
        }

    }
}
