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
    public partial class UpdateEmployeePosTitle : Form
    {
        private PositionBll pBll = new PositionBll();
        private PosTitleBll ptBll = new PosTitleBll();
        private EmployeePosTitleBll epBll = new EmployeePosTitleBll();
        private EmployeeBll eBll = new EmployeeBll();

        private EmployeePosTitle _ep;
        private int _id = 0;
        private int _eId = 0;

        public UpdateEmployeePosTitle(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateEmployeePosTitle_Load(object sender, EventArgs e)
        {
            cbObtainWay.SelectedIndex = 0;
            BindPosTitleList();
            BindPostion();

            BindEmployeePosTitleInfo();
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

        private void BindEmployeePosTitleInfo()
        {
            _ep = epBll.GetEmployeePosTitle(_id);
            _eId = _ep.EId;
            Employee employee = eBll.GetEmployee(_ep.EId);

            txtEmployee.Text = employee.EName + "(" + employee.Code + ")";
            cbPosTitle.SelectedValue = _ep.PTId;
            dtpObtainDate.Value = _ep.ObtainDate;
            for (int i = 0; i < cbObtainWay.Items.Count; i++)
            {
                if (cbObtainWay.Items[i].ToString() == _ep.ObtainWay)
                {
                    cbObtainWay.SelectedIndex = i;
                    break;
                }
            }
            txtEmployCompany.Text = _ep.EmployCompany;
            cbPosition.SelectedValue = _ep.PId;
            dtpStartDate.Value = _ep.StartDate;
            dtpEndDate.Value = _ep.EndDate;

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

            _ep.EId = _eId;
            _ep.PTId = Convert.ToInt32(cbPosTitle.SelectedValue);
            _ep.ObtainDate = Convert.ToDateTime(dtpObtainDate.Text);
            _ep.ObtainWay = cbObtainWay.SelectedItem.ToString();
            _ep.EmployCompany = employCompany;
            _ep.PId = Convert.ToInt32(cbPosition.SelectedValue);
            _ep.StartDate = Convert.ToDateTime(dtpStartDate.Text);
            _ep.EndDate = Convert.ToDateTime(dtpEndDate.Text);

            epBll.Update(_ep);
            MessageBox.Show("修改成功！");
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
