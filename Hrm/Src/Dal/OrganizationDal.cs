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
    public class OrganizationDal
    {

        private string _connectionString;//数据库连接字符串

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filePath">数据库路径</param>
        /// <param name="password">数据库密码</param>
        public OrganizationDal(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="org">部门对象</param>
        /// <returns>ID</returns>
        public int Insert(Organization org)
        {
            string sql = "insert into TB_Organization(ParentId,OName,Comment) ";
            sql += "values(@ParentId,@OName,@Comment)";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@ParentId",org.ParentId),
                new OleDbParameter("@OName",org.OName),
                new OleDbParameter("@Comment",org.Comment)
            };

            AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            object id = AccessHelper.ExecuteScalar(_connectionString, "select @@identity");

            return Convert.ToInt32(id);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>影响行数</returns>
        public int Delete(int id)
        {
            string sql = "delete from TB_Organization where OId=@OId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@OId",id)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="org">部门对象</param>
        /// <returns>影响行数</returns>
        public int Update(Organization org)
        {
            string sql = "update TB_Organization set ParentId=@ParentId,OName=@OName,Comment=@Comment where OId=@OId";

            OleDbParameter[] param = new OleDbParameter[] { 
                new OleDbParameter("@ParentId",org.ParentId),
                new OleDbParameter("@OName",org.OName),
                new OleDbParameter("@Comment",org.Comment),
                new OleDbParameter("@OId",org.OId)
            };

            int count = AccessHelper.ExecuteNonQuery(_connectionString, sql, param);
            return count;
        }

        /// <summary>
        /// 获取部门对象
        /// </summary>
        /// <param name="eId">Id</param>
        /// <returns>部门对象</returns>
        public Organization GetOrganization(int id)
        {
            Organization org = null;
            string sql = "select * from TB_Organization where OId=" + id;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                org = new Organization();
                org.OId = (int)row["OId"];
                org.ParentId = (int)row["ParentId"];
                org.OName = (string)row["OName"];
                if (!Convert.IsDBNull(row["Comment"]))
                {
                    org.Comment = (string)row["Comment"];
                }
            }
            return org;
        }

        /// <summary>
        /// 根据员工ID获取部门对象
        /// </summary>
        /// <param name="eId">员工ID</param>
        /// <returns>部门对象</returns>
        public Organization GetOrganizationByEId(int eId)
        {
            Organization org = null;
            string sql = "select O.* from TB_Organization O,TB_EmployeeOrg EO where O.OId=EO.OId and EO.EId=" + eId;

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];

                org = new Organization();
                org.OId = (int)row["OId"];
                org.ParentId = (int)row["ParentId"];
                org.OName = (string)row["OName"];
                if (!Convert.IsDBNull(row["Comment"]))
                {
                    org.Comment = (string)row["Comment"];
                }
            }
            return org;
        }

        /// <summary>
        /// 获取所有部门列表
        /// </summary>
        /// <returns>部门集合</returns>
        public IList<Organization> GetAllOrganization()
        {
            IList<Organization> list = new List<Organization>();

            string sql = "select * from TB_Organization order by ParentId asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Organization org = new Organization();
                    org.OId = (int)row["OId"];
                    org.ParentId = (int)row["ParentId"];
                    org.OName = (string)row["OName"];
                    if (!Convert.IsDBNull(row["Comment"]))
                    {
                        org.Comment = (string)row["Comment"];
                    }

                    list.Add(org);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取下级部门列表
        /// </summary>
        /// <param name="id">部门Id</param>
        /// <returns>部门集合</returns>
        public IList<Organization> GetChildOrganization(int id)
        {
            IList<Organization> list = new List<Organization>();

            string sql = "select * from TB_Organization where ParentId=" + id + " order by OName asc";

            DataSet ds = AccessHelper.ExecuteDataSet(_connectionString, sql);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Organization org = new Organization();
                    org.OId = (int)row["OId"];
                    org.ParentId = (int)row["ParentId"];
                    org.OName = (string)row["OName"];
                    if (!Convert.IsDBNull(row["Comment"]))
                    {
                        org.Comment = (string)row["Comment"];
                    }

                    list.Add(org);
                }
            }

            return list;
        }

    }
}
