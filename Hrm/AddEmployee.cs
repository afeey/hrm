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
    public partial class AddEmployee : Form
    {
        private OrganizationBll oBll = new OrganizationBll();
        private PositionBll pBll = new PositionBll();
        private EmployeeBll eBll = new EmployeeBll();
        private int _orgId = 0;
        public AddEmployee(int orgId)
        {
            _orgId = orgId;
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            if (_orgId != 0)
            {
                txtOrgName.Text = oBll.GetOrganization(_orgId).OName;
            }
            BindPostion();
            if (cbPosition.Items.Count > 0)
            {
                cbPosition.SelectedIndex = 0;
            }
            cbEducation.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
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
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string idCode = txtIcCode.Text.Trim();
            string country = txtCountry.Text.Trim();
            string school = txtSchool.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string cellphone = txtCellPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (code.Length == 0)
            {
                MessageBox.Show("编号不能为空");
                return;
            }
            if (name.Length == 0)
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (_orgId == 0)
            {
                MessageBox.Show("部门不能为空");
                return;
            }

            Employee employee = eBll.GetEmployee(code);
            if (employee != null)
            {
                MessageBox.Show("编号已经存在");
                return;
            }

            employee = new Employee();
            employee.Code =code;
            employee.EName = name;
            employee.IdCode = idCode;
            if (rbtnMale.Checked)
            {
                employee.Sex = 0;
            }
            else
            {
                employee.Sex = 1;
            }
            employee.Country = country;
            employee.BirthDay = Convert.ToDateTime(dtpBirthDay.Text);
            if (rbtnNotMarried.Checked)
            {
                employee.Married = 0;
            }
            else
            {
                employee.Married = 1;
            }
            employee.PId = Convert.ToInt32(cbPosition.SelectedValue);
            employee.Education = cbEducation.SelectedItem.ToString();
            employee.School = school;
            employee.Email = email;
            employee.Phone = phone;
            employee.CellPhone = cellphone;
            employee.Status = cbStatus.SelectedItem.ToString();
            employee.Address = txtAddress.Text;

            eBll.Insert(employee,_orgId);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSelectOrg_Click(object sender, EventArgs e)
        {
            SelectOrganization select = new SelectOrganization();
            if (select.ShowDialog() == DialogResult.OK)
            {
                txtOrgName.Text = select.text;
                _orgId = select.value;
            }
        }

    }
}
