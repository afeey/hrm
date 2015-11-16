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
    public class PosTitleDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public PosTitleDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加职称
        /// </summary>
        /// <param name="posTitle">职称对象</param>
        /// <returns>ID</returns>
        public int Insert(PosTitle posTitle)
        {
            string sql = "insert into TB_PosTitle(PName,Comment) ";
            sql += "values(@PName,@Comment)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@PName",posTitle.PName),
                new OleDbParameter("@Comment",posTitle.Comment)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除职称
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_PosTitle where PTId=@PTId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@PTId",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改职称
        /// </summary>
        /// <param name="posTitle">职称对象</param>
        /// <returns>影响行数</returns>
        public int Update(PosTitle posTitle)
        {
            string sql = "update TB_PosTitle set PName=@PName,Comment=@Comment where PTId=@PTId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@PName",posTitle.PName),
                new OleDbParameter("@Comment",posTitle.Comment),
                new OleDbParameter("@PTId",posTitle.PTId)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取职称对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>职称对象</returns>
        public PosTitle GetPosTitle(int id)
        {
            PosTitle posTitle = null;
            string sql = "select * from TB_PosTitle where PTId=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                posTitle = new PosTitle();
                posTitle.PTId = (int)row["PTId"];
                posTitle.PName = (string)row["PName"];
                if (!Convert.IsDBNull(row["Comment"]))
                {
                    posTitle.Comment = (string)row["Comment"];
                }
            }
            return posTitle;
        }

        /// <summary>
        /// 获取所有职称列表
        /// </summary>
        /// <returns>职称集合</returns>
        public IList<PosTitle> GetAllPosTitle()
        {
            IList<PosTitle> list = new List<PosTitle>();

            string sql = "select * from TB_PosTitle order by PName asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    PosTitle posTitle = new PosTitle();
                    posTitle.PTId = (int)row["PTId"];
                    posTitle.PName = (string)row["PName"];
                    if (!Convert.IsDBNull(row["Comment"]))
                    {
                        posTitle.Comment = (string)row["Comment"];
                    }

                    list.Add(posTitle);
                }
            }

            return list;
        }

    }
}
