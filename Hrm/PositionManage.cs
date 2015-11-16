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
    public partial class PositionManage : Form
    {
        private PositionBll pBll = new PositionBll();

        public PositionManage()
        {
            InitializeComponent();
        }

        private void PositionManage_Load(object sender, EventArgs e)
        {
            BindPositionTable();
        }

        /// <summary>
        /// 绑定职务表
        /// </summary>
        private void BindPositionTable()
        {
            IList<Position> list = pBll.GetAllPosition();

            dgvPosition.AutoGenerateColumns = false;
            dgvPosition.DataSource = list;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddPosition().ShowDialog() == DialogResult.OK)
            {
                BindPositionTable();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvPosition.SelectedRows;

            if (rows.Count > 0)
            {
                int id = (int)rows[0].Cells["PId"].Value;

                if (new UpdatePosition(id).ShowDialog() == DialogResult.OK)
                {
                    BindPositionTable();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvPosition.SelectedRows;

            if (rows.Count > 0)
            {
                if (MessageBox.Show("确定删除选中项？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        int id = (int)row.Cells["PId"].Value;
                        pBll.Delete(id);
                    }

                    BindPositionTable();
                }
            }
        }

    }
}
