using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using Hrm.Bll;
using Hrm.Model;

namespace Hrm
{
    public partial class UserManage : Form
    {
        private UserBll uBll = new UserBll();

        public UserManage()
        {
            InitializeComponent();
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {
            BindUserTable();
        }

        /// <summary>
        /// 绑定用户表
        /// </summary>
        private void BindUserTable()
        {
            IList<User> list = uBll.GetAllUser();

            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = list;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddUser().ShowDialog() == DialogResult.OK)
            {
                BindUserTable();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvUser.SelectedRows;

            if (rows.Count > 0)
            {
                int id = (int)rows[0].Cells["UId"].Value;

                if (new UpdateUser(id).ShowDialog() == DialogResult.OK)
                {
                    BindUserTable();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvUser.SelectedRows;

            if (rows.Count > 0)
            {
                if (MessageBox.Show("确定删除选中项？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        int id = (int)row.Cells["UId"].Value;
                        if (id == GlobalClass.USERID)
                        {
                            MessageBox.Show("不能删除当前登录用户");
                            return;
                        }
                        uBll.Delete(id);
                    }

                    BindUserTable();
                }
            }
        }

    }
}
