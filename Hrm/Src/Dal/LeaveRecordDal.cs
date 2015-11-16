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
    public class LeaveRecordDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public LeaveRecordDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加休假记录
        /// </summary>
        /// <param name="record">休假记录对象</param>
        /// <returns>ID</returns>
        public int Insert(LeaveRecord record)
        {
            string sql = "insert into TB_LeaveRecord(EId,Type,Approver,StartDate,EndDate,Comment) ";
            sql += "values(@EId,@Type,@Approver,@StartDate,@EndDate,@Comment)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EId",record.EId),
                new OleDbParameter("@Type",record.Type),
                new OleDbParameter("@Approver",record.Approver),
                new OleDbParameter("@StartDate",record.StartDate),
                new OleDbParameter("@EndDate",record.EndDate),
                new OleDbParameter("@Approver",record.Comment)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除休假记录
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_LeaveRecord where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@ID",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改休假记录
        /// </summary>
        /// <param name="record">休假记录对象</param>
        /// <returns>影响行数</returns>
        public int Update(LeaveRecord record)
        {
            string sql = "update TB_LeaveRecord set EId=@EId,Type=@Type,Approver=@Approver,StartDate=@StartDate,EndDate=@EndDate,Comment=@Comment where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EId",record.EId),
                new OleDbParameter("@Type",record.Type),
                new OleDbParameter("@Approver",record.Approver),
                new OleDbParameter("@StartDate",record.StartDate),
                new OleDbParameter("@EndDate",record.EndDate),
                new OleDbParameter("@Approver",record.Comment),
                new OleDbParameter("@ID",record.Id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取休假记录对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>休假记录对象</returns>
        public LeaveRecord GetLeaveRecord(int id)
        {
            LeaveRecord record = null;
            string sql = "select * from TB_LeaveRecord where ID=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                record = new LeaveRecord();
                record.Id = (int)row["ID"];
                record.EId = (int)row["EId"];
                record.Type = (string)row["Type"];
                record.Approver = (string)row["Approver"];
                record.StartDate = (DateTime)row["StartDate"];
                record.EndDate = (DateTime)row["EndDate"];
                if (!Convert.IsDBNull(row["Comment"]))
                {
                    record.Comment = (string)row["Comment"];
                }
            }
            return record;
        }

        /// <summary>
        /// 获取所有休假记录列表
        /// </summary>
        /// <returns>休假记录集合</returns>
        public IList<LeaveRecord> GetAllLeaveRecord()
        {
            IList<LeaveRecord> list = new List<LeaveRecord>();

            string sql = "select * from TB_LeaveRecord order by StartDate desc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    LeaveRecord record = new LeaveRecord();
                    record.Id = (int)row["ID"];
                    record.EId = (int)row["EId"];
                    record.Type = (string)row["Type"];
                    record.Approver = (string)row["Approver"];
                    record.StartDate = (DateTime)row["StartDate"];
                    record.EndDate = (DateTime)row["EndDate"];
                    if (!Convert.IsDBNull(row["Comment"]))
                    {
                        record.Comment = (string)row["Comment"];
                    }

                    list.Add(record);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取员工休假记录集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <returns>休假记录集合</returns>
        public IList<LeaveRecord> GetLeaveRecordByEId(int eId)
        {
            IList<LeaveRecord> list = new List<LeaveRecord>();

            string sql = "select * from TB_LeaveRecord where EId=" + eId + " order by StartDate desc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    LeaveRecord record = new LeaveRecord();
                    record.Id = (int)row["ID"];
                    record.EId = (int)row["EId"];
                    record.Type = (string)row["Type"];
                    record.Approver = (string)row["Approver"];
                    record.StartDate = (DateTime)row["StartDate"];
                    record.EndDate = (DateTime)row["EndDate"];
                    if (!Convert.IsDBNull(row["Comment"]))
                    {
                        record.Comment = (string)row["Comment"];
                    }

                    list.Add(record);
                }
            }

            return list;
        }

    }
}
