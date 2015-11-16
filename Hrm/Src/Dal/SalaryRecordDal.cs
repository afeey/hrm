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
    public class SalaryRecordDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public SalaryRecordDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加工资记录
        /// </summary>
        /// <param name="record">工资记录对象</param>
        /// <returns>ID</returns>
        public int Insert(SalaryRecord record)
        {
            string sql = "insert into TB_SalaryRecord(EId,[Date],Salary) ";
            sql += "values(@EId,@Date,@Salary)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EId",record.EId),
                new OleDbParameter("@Date",record.Date),
                new OleDbParameter("@Salary",record.Salary)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除工资记录
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_SalaryRecord where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@ID",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改工资记录
        /// </summary>
        /// <param name="record">工资记录对象</param>
        /// <returns>影响行数</returns>
        public int Update(SalaryRecord record)
        {
            string sql = "update TB_SalaryRecord set EId=@EId,[Date]=@Date,Salary=@Salary where ID=@ID";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@EId",record.EId),
                new OleDbParameter("@Date",record.Date),
                new OleDbParameter("@Salary",record.Salary),
                new OleDbParameter("@ID",record.Id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取工资记录对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>工资记录对象</returns>
        public SalaryRecord GetSalaryRecord(int id)
        {
            SalaryRecord record = null;
            string sql = "select * from TB_SalaryRecord where ID=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                record = new SalaryRecord();
                record.Id = (int)row["ID"];
                record.EId = (int)row["EId"];
                record.Date = (DateTime)row["Date"];
                record.Salary = (double)row["Salary"];
            }
            return record;
        }

        /// <summary>
        /// 获取所有工资记录列表
        /// </summary>
        /// <returns>工资记录集合</returns>
        public IList<SalaryRecord> GetAllSalaryRecord()
        {
            IList<SalaryRecord> list = new List<SalaryRecord>();

            string sql = "select * from TB_SalaryRecord order by Date desc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    SalaryRecord record = new SalaryRecord();
                    record.Id = (int)row["ID"];
                    record.EId = (int)row["EId"];
                    record.Date = (DateTime)row["Date"];
                    record.Salary = (double)row["Salary"];

                    list.Add(record);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取员工工资记录集合
        /// </summary>
        /// <param name="eId">员工Id</param>
        /// <returns>工资记录集合</returns>
        public IList<SalaryRecord> GetSalaryRecordByEId(int eId)
        {
            IList<SalaryRecord> list = new List<SalaryRecord>();

            string sql = "select * from TB_SalaryRecord where EId=" + eId + " order by Date desc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    SalaryRecord record = new SalaryRecord();
                    record.Id = (int)row["ID"];
                    record.EId = (int)row["EId"];
                    record.Date = (DateTime)row["Date"];
                    record.Salary = (double)row["Salary"];

                    list.Add(record);
                }
            }

            return list;
        }

    }
}
