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
    public partial class PosTitleManage : Form
    {
        private PosTitleBll pBll = new PosTitleBll();

        public PosTitleManage()
        {
            InitializeComponent();
        }

        private void PosTitleManage_Load(object sender, EventArgs e)
        {
            BindPosTitleTable();
        }

        /// <summary>
        /// 绑定职务表
        /// </summary>
        private void BindPosTitleTable()
        {
            IList<PosTitle> list = pBll.GetAllPosTitle();

            dgvPosTitle.AutoGenerateColumns = false;
            dgvPosTitle.DataSource = list;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddPosTitle().ShowDialog() == DialogResult.OK)
            {
                BindPosTitleTable();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvPosTitle.SelectedRows;

            if (rows.Count > 0)
            {
                int id = (int)rows[0].Cells["PTId"].Value;

                if (new UpdatePosTitle(id).ShowDialog() == DialogResult.OK)
                {
                    BindPosTitleTable();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvPosTitle.SelectedRows;

            if (rows.Count > 0)
            {
                if (MessageBox.Show("确定删除选中项？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        int id = (int)row.Cells["PTId"].Value;
                        pBll.Delete(id);
                    }

                    BindPosTitleTable();
                }
            }
        }

    }
}
