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
    public partial class EmployeePosTitleManage : Form
    {
        private EmployeePosTitleBll epBll = new EmployeePosTitleBll();
        private EmployeeBll eBll = new EmployeeBll();
        private PosTitleBll ptBll = new PosTitleBll();
        private PositionBll pBll = new PositionBll();

        public EmployeePosTitleManage()
        {
            InitializeComponent();
        }

        private void EmployeePosTitleManage_Load(object sender, EventArgs e)
        {
            BindEmployeePosTitleTable();
        }

        /// <summary>
        /// 绑定职务表
        /// </summary>
        private void BindEmployeePosTitleTable()
        {
            IList<EmployeePosTitle> list = epBll.GetAllEmployeePosTitle();
            foreach (EmployeePosTitle ep in list)
            {
                Employee e=eBll.GetEmployee(ep.EId);
                ep.Code = e.Code;
                ep.EName = e.EName;

                PosTitle pt=ptBll.GetPosTitle(ep.PTId);
                if(pt!=null){
                    ep.PosName = pt.PName;
                }
                Position position = pBll.GetPosition(ep.PId);
                if (position != null)
                {
                    ep.PositionName = position.PName;
                }
            }

            dgvEmployeePosTitle.AutoGenerateColumns = false;
            dgvEmployeePosTitle.DataSource = list;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddEmployeePosTitle().ShowDialog() == DialogResult.OK)
            {
                BindEmployeePosTitleTable();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvEmployeePosTitle.SelectedRows;

            if (rows.Count > 0)
            {
                int id = (int)rows[0].Cells["ID"].Value;

                if (new UpdateEmployeePosTitle(id).ShowDialog() == DialogResult.OK)
                {
                    BindEmployeePosTitleTable();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvEmployeePosTitle.SelectedRows;

            if (rows.Count > 0)
            {
                if (MessageBox.Show("确定删除选中项？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        int id = (int)row.Cells["ID"].Value;
                        epBll.Delete(id);
                    }

                    BindEmployeePosTitleTable();
                }
            }
        }

    }
}
