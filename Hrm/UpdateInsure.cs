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
    public partial class UpdateInsure : Form
    {
        private InsureBll iBll = new InsureBll();
        private EmployeeBll eBll = new EmployeeBll();
        private int _id = 0;
        private Insure record;

        public UpdateInsure(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateInsure_Load(object sender, EventArgs e)
        {
            BindInsureInfo();
        }

        /// <summary>
        /// 绑定社保记录信息
        /// </summary>
        private void BindInsureInfo()
        {
            record = iBll.GetInsure(_id);

            lblEmployeeName.Text = eBll.GetEmployee(record.EId).EName;
            dtpDate.Text = record.Date.ToString("yyyy年MM月dd日");
            for (int i = 0; i < cbType.Items.Count; i++)
            {
                if (cbType.Items[i].ToString() == record.Type)
                {
                    cbType.SelectedIndex = i;
                    break;
                }
            }
            numBaseNumber.Value = (decimal)record.BaseNumber;
            numCompany.Value = (decimal)record.BaseNumber;
            numCompany.Value = (decimal)record.BaseNumber;
            
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            string baseNumber = numBaseNumber.Text.Trim();
            string company = numCompany.Text.Trim();
            string person = numPerson.Text.Trim();

            if (baseNumber.Length == 0)
            {
                MessageBox.Show("缴纳基数不能为空");
                return;
            }
            if (company.Length == 0)
            {
                MessageBox.Show("个人缴纳不能为空");
                return;
            }
            if (person.Length == 0)
            {
                MessageBox.Show("单位缴纳不能为空");
                return;
            }

            record.Date = Convert.ToDateTime(dtpDate.Text);
            record.Type = cbType.SelectedItem.ToString();
            record.BaseNumber = Convert.ToDouble(baseNumber);
            record.Company = Convert.ToDouble(company);
            record.Person = Convert.ToDouble(person);

            iBll.Update(record);
            MessageBox.Show("修改成功！");
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
