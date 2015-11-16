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
    public class InsureDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public InsureDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加保险记录
        /// </summary>
        /// <param name="insure">保险记录对象</param>
        /// <returns>ID</returns>
        public int Insert(Insure insure)
        {
            string sql = "insert into TB_Insure(EId,[Date],Type,BaseNumber,Company,Person) ";
            sql += "values(@EId,@Date,@Type,@BaseNumber,@Company,@Person)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EId",insure.EId),
                new OleDbParameter("@Date",insure.Date),
                new OleDbParameter("@Type",insure.Type),
                new OleDbParameter("@BaseNumber",insure.BaseNumber),
                new OleDbParameter("@Company",insure.Company),
                new OleDbParameter("@Person",insure.Person)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除保险记录
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_Insure where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@ID",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改保险记录
        /// </summary>
        /// <param name="insure">保险记录对象</param>
        /// <returns>影响行数</returns>
        public int Update(Insure insure)
        {
            string sql = "update TB_Insure set EId=@EId,[Date]=@Date,Type=@Type,BaseNumber=@BaseNumber,Company=@Company,Person=@Person where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                 new OleDbParameter("@EId",insure.EId),
                new OleDbParameter("@Date",insure.Date),
                new OleDbParameter("@Type",insure.Type),
                new OleDbParameter("@BaseNumber",insure.BaseNumber),
                new OleDbParameter("@Company",insure.Company),
                new OleDbParameter("@Person",insure.Person),
                new OleDbParameter("@ID",insure.Id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取保险记录对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>保险记录对象</returns>
        public Insure GetInsure(int id)
        {
            Insure insure = null;
            string sql = "select * from TB_Insure where ID=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                insure = new Insure();
                insure.Id = (int)row["ID"];
                insure.EId = (int)row["EId"];
                insure.Date = (DateTime)row["Date"];
                insure.Type = (string)row["Type"];
                insure.BaseNumber = (double)row["BaseNumber"];
                insure.Company = (double)row["Company"];
                insure.Person = (double)row["Person"];
            }
            return insure;
        }

        /// <summary>
        /// 获取所有保险记录列表
        /// </summary>
        /// <returns>保险记录集合</returns>
        public IList<Insure> GetAllInsure()
        {
            IList<Insure> list = new List<Insure>();

            string sql = "select * from TB_Insure order by Date desc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Insure insure = new Insure();
                    insure.Id = (int)row["ID"];
                    insure.EId = (int)row["EId"];
                    insure.Date = (DateTime)row["Date"];
                    insure.Type = (string)row["Type"];
                    insure.BaseNumber = (double)row["BaseNumber"];
                    insure.Company = (double)row["Company"];
                    insure.Person = (double)row["Person"];

                    list.Add(insure);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取员工保险记录集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <param name="type">保险类型</param>
        /// <returns>保险记录集合</returns>
        public IList<Insure> GetInsureByEId(int eId,string type)
        {
            IList<Insure> list = new List<Insure>();

            string sql = "select * from TB_Insure where EId=" + eId + " and Type='" + type + "' order by Date desc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Insure insure = new Insure();
                    insure.Id = (int)row["ID"];
                    insure.EId = (int)row["EId"];
                    insure.Date = (DateTime)row["Date"];
                    insure.Type = (string)row["Type"];
                    insure.BaseNumber = (double)row["BaseNumber"];
                    insure.Company = (double)row["Company"];
                    insure.Person = (double)row["Person"];

                    list.Add(insure);
                }
            }

            return list;
        }

    }
}
