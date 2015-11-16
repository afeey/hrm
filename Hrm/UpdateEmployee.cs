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
    public partial class UpdateEmployee : Form
    {
        private int _eId;
        private Employee _employee = null;
        private EmployeeBll eBll = new EmployeeBll();
        private PositionBll pBll = new PositionBll();
        private OrganizationBll oBll = new OrganizationBll();
        private int _orgId;

        public UpdateEmployee(int id)
        {
            _eId = id;
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            BindPostion();
            BindEmployeeInfo();
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

        private void BindEmployeeInfo()
        {
            _employee = eBll.GetEmployee(_eId);
            txtCode.Text = _employee.Code;
            txtName.Text = _employee.EName;
            txtIcCode.Text = _employee.IdCode;
            if (_employee.Sex == 0)
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
            txtCountry.Text = _employee.Country;
            dtpBirthDay.Value = _employee.BirthDay;
            if (_employee.Married == 0)
            {
                rbtnNotMarried.Checked = true;
            }
            else
            {
                rbtnMarried.Checked = true;
            }
            cbPosition.SelectedValue = _employee.PId;
            Organization org = oBll.GetOrganizationByEId(_eId);
            _orgId = org.OId;
            txtOrgName.Text = org.OName;

            for (int i = 0; i < cbEducation.Items.Count;i++)
            {
                if (cbEducation.Items[i].ToString() == _employee.Education)
                {
                    cbEducation.SelectedIndex = i;
                    break;
                }
            }
               
            txtSchool.Text = _employee.School;
            txtEmail.Text = _employee.Email;
            txtPhone.Text = _employee.Phone;
            txtCellPhone.Text = _employee.CellPhone;

            for (int i = 0; i < cbStatus.Items.Count; i++)
            {
                if (cbStatus.Items[i].ToString() == _employee.Status)
                {
                    cbStatus.SelectedIndex = i;
                    break;
                }
            }
            txtAddress.Text = _employee.Address;
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
            if (employee != null&&employee.EId!=_employee.EId)
            {
                MessageBox.Show("编号已经存在");
                return;
            }

            _employee.Code = code;
            _employee.EName = name;
            _employee.IdCode = idCode;
            if (rbtnMale.Checked)
            {
                _employee.Sex = 0;
            }
            else
            {
                _employee.Sex = 1;
            }
            _employee.Country = country;
            _employee.BirthDay = Convert.ToDateTime(dtpBirthDay.Text);
            if (rbtnNotMarried.Checked)
            {
                _employee.Married = 0;
            }
            else
            {
                _employee.Married = 1;
            }
            _employee.PId = Convert.ToInt32(cbPosition.SelectedValue);
            _employee.Education = cbEducation.SelectedItem.ToString();
            _employee.School = school;
            _employee.Email = email;
            _employee.Phone = phone;
            _employee.CellPhone = cellphone;
            _employee.Status = cbStatus.SelectedItem.ToString();
            _employee.Address = txtAddress.Text;

            eBll.Update(_employee,_orgId);

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
