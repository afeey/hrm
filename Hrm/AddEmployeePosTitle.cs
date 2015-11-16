using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Hrm.Bll;
using Hrm.Model;

namespace Hrm
{
    public partial class AddEmployeePosTitle : Form
    {
        private PositionBll pBll = new PositionBll();
        private PosTitleBll ptBll = new PosTitleBll();
        private EmployeePosTitleBll epBll = new EmployeePosTitleBll();
        private int _eId = 0;

        public AddEmployeePosTitle()
        {
            InitializeComponent();
        }

        private void AddEmployeePosTitle_Load(object sender, EventArgs e)
        {
            cbObtainWay.SelectedIndex = 0;
            BindPosTitleList();
            BindPostion();
        }

        /// <summary>
        /// 绑定职称下拉
        /// </summary>
        private void BindPosTitleList()
        {
            cbPosTitle.DisplayMember = "PName";
            cbPosTitle.ValueMember = "PTId";
            cbPosTitle.DataSource = ptBll.GetAllPosTitle();
            if (cbPosTitle.Items.Count > 0)
            {
                cbPosTitle.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 绑定职务下拉
        /// </summary>
        private void BindPostion()
        {
            cbPosition.DisplayMember = "PName";
            cbPosition.ValueMember = "PId";
            cbPosition.DataSource = pBll.GetAllPosition();
            if (cbPosition.Items.Count > 0)
            {
                cbPosition.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_eId == 0)
            {
                MessageBox.Show("员工不能为空");
                return;
            }

            if (cbPosTitle.Items.Count == 0)
            {
                MessageBox.Show("请选择职称");
                return;
            }
            if (cbPosition.Items.Count == 0)
            {
                MessageBox.Show("请选择职务");
                return;
            }

            string employCompany = txtEmployCompany.Text.Trim();
            if (employCompany.Length == 0)
            {
                MessageBox.Show("聘用单位不能为空");
                return;
            }

            EmployeePosTitle ep = new EmployeePosTitle();
            ep.EId = _eId;
            ep.PTId = Convert.ToInt32(cbPosTitle.SelectedValue);
            ep.ObtainDate = Convert.ToDateTime(dtpObtainDate.Text);
            ep.ObtainWay = cbObtainWay.SelectedItem.ToString();
            ep.EmployCompany = employCompany;
            ep.PId = Convert.ToInt32(cbPosition.SelectedValue);
            ep.StartDate = Convert.ToDateTime(dtpStartDate.Text);
            ep.EndDate = Convert.ToDateTime(dtpEndDate.Text);

            epBll.Insert(ep);
            MessageBox.Show("添加成功！");
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            SelectEmployee select = new SelectEmployee();
            if (select.ShowDialog() == DialogResult.OK)
            {
                txtEmployee.Text = select.text;
                _eId = select.value;
            }
        }

    }
}
