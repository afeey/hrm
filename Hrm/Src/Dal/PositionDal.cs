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
    public class PositionDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public PositionDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加职位
        /// </summary>
        /// <param name="position">职位对象</param>
        /// <returns>ID</returns>
        public int Insert(Position position)
        {
            string sql = "insert into TB_Position(PName,Comment) ";
            sql += "values(@PName,@Comment)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@PName",position.PName),
                new OleDbParameter("@Comment",position.Comment)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除职位
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_Position where PId=@PId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@PId",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改职位
        /// </summary>
        /// <param name="position">职位对象</param>
        /// <returns>影响行数</returns>
        public int Update(Position position)
        {
            string sql = "update TB_Position set PName=@PName,Comment=@Comment where PId=@PId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@PName",position.PName),
                new OleDbParameter("@Comment",position.Comment),
                new OleDbParameter("@PId",position.PId)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取职位对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>职位对象</returns>
        public Position GetPosition(int id)
        {
            Position position = null;
            string sql = "select * from TB_Position where PId=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                position = new Position();
                position.PId = (int)row["PId"];
                position.PName = (string)row["PName"];
                if (!Convert.IsDBNull(row["Comment"]))
                {
                    position.Comment = (string)row["Comment"];
                }
            }
            return position;
        }

        /// <summary>
        /// 获取所有职位列表
        /// </summary>
        /// <returns>职位集合</returns>
        public IList<Position> GetAllPosition()
        {
            IList<Position> list = new List<Position>();

            string sql = "select * from TB_Position order by PName asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Position position = new Position();
                    position.PId = (int)row["PId"];
                    position.PName = (string)row["PName"];
                    if (!Convert.IsDBNull(row["Comment"]))
                    {
                        position.Comment = (string)row["Comment"];
                    }

                    list.Add(position);
                }
            }

            return list;
        }

    }
}
