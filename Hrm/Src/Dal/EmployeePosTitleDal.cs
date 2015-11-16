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
    public class EmployeePosTitleDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public EmployeePosTitleDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加职称评定
        /// </summary>
        /// <param name="record">职称评定对象</param>
        /// <returns>ID</returns>
        public int Insert(EmployeePosTitle record)
        {
            string sql = "insert into TB_EmployeePosTitle(EId,PTId,ObtainDate,ObtainWay,EmployCompany,PId,StartDate,EndDate) ";
            sql += "values(@EId,@PTId,@ObtainDate,@ObtainWay,@EmployCompany,@PId,@StartDate,@EndDate)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EId",record.EId),
                new OleDbParameter("@PTId",record.PTId),
                new OleDbParameter("@ObtainDate",record.ObtainDate),
                new OleDbParameter("@ObtainWay",record.ObtainWay),
                new OleDbParameter("@EmployCompany",record.EmployCompany),
                new OleDbParameter("@PId",record.PId),
                new OleDbParameter("@StartDate",record.StartDate),
                new OleDbParameter("@EndDate",record.EndDate)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除职称评定
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_EmployeePosTitle where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@ID",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改职称评定
        /// </summary>
        /// <param name="record">职称评定对象</param>
        /// <returns>影响行数</returns>
        public int Update(EmployeePosTitle record)
        {
            string sql = "update TB_EmployeePosTitle set EId=@EId,PTId=@PTId,ObtainDate=@ObtainDate,ObtainWay=@ObtainWay,EmployCompany=@EmployCompany,PId=@PId,StartDate=@StartDate,EndDate=@EndDate where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EId",record.EId),
                new OleDbParameter("@PTId",record.PTId),
                new OleDbParameter("@ObtainDate",record.ObtainDate),
                new OleDbParameter("@ObtainWay",record.ObtainWay),
                new OleDbParameter("@EmployCompany",record.EmployCompany),
                new OleDbParameter("@PId",record.PId),
                new OleDbParameter("@StartDate",record.StartDate),
                new OleDbParameter("@EndDate",record.EndDate),
                new OleDbParameter("@ID",record.ID)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取职称评定对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>职称评定对象</returns>
        public EmployeePosTitle GetEmployeePosTitle(int id)
        {
            EmployeePosTitle record = null;
            string sql = "select * from TB_EmployeePosTitle where ID=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                record = new EmployeePosTitle();
                record.ID = (int)row["ID"];
                record.EId = (int)row["EId"];
                record.PTId = (int)row["PTId"];
                record.ObtainDate = (DateTime)row["ObtainDate"];
                record.ObtainWay = (string)row["ObtainWay"];
                if (!Convert.IsDBNull(row["EmployCompany"]))
                {
                    record.EmployCompany = (string)row["EmployCompany"];
                }
                record.PId = (int)row["PId"];
                record.StartDate = (DateTime)row["StartDate"];
                record.EndDate = (DateTime)row["EndDate"];

            }
            return record;
        }

        /// <summary>
        /// 获取所有职称评定列表
        /// </summary>
        /// <returns>职称评定集合</returns>
        public IList<EmployeePosTitle> GetAllEmployeePosTitle()
        {
            IList<EmployeePosTitle> list = new List<EmployeePosTitle>();

            string sql = "select * from TB_EmployeePosTitle order by ObtainDate asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EmployeePosTitle record = new EmployeePosTitle();
                    record.ID = (int)row["ID"];
                    record.EId = (int)row["EId"];
                    record.PTId = (int)row["PTId"];
                    record.ObtainDate = (DateTime)row["ObtainDate"];
                    record.ObtainWay = (string)row["ObtainWay"];
                    if (!Convert.IsDBNull(row["EmployCompany"]))
                    {
                        record.EmployCompany = (string)row["EmployCompany"];
                    }
                    record.PId = (int)row["PId"];
                    record.StartDate = (DateTime)row["StartDate"];
                    record.EndDate = (DateTime)row["EndDate"];

                    list.Add(record);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取员工职称评定集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <returns>职称评定集合</returns>
        public IList<EmployeePosTitle> GetEmployeePosTitleByEId(int eId)
        {
            IList<EmployeePosTitle> list = new List<EmployeePosTitle>();

            string sql = "select * from TB_EmployeePosTitle where EId=" + eId + " order by ObtainDate desc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    EmployeePosTitle record = new EmployeePosTitle();
                    record.ID = (int)row["ID"];
                    record.EId = (int)row["EId"];
                    record.PTId = (int)row["PTId"];
                    record.ObtainDate = (DateTime)row["ObtainDate"];
                    record.ObtainWay = (string)row["ObtainWay"];
                    if (!Convert.IsDBNull(row["EmployCompany"]))
                    {
                        record.EmployCompany = (string)row["EmployCompany"];
                    }
                    record.PId = (int)row["PId"];
                    record.StartDate = (DateTime)row["StartDate"];
                    record.EndDate = (DateTime)row["EndDate"];

                    list.Add(record);
                }
            }

            return list;
        }

    }
}
