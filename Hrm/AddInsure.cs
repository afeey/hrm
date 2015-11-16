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
    public partial class AddInsure : Form
    {
        private InsureBll iBll = new InsureBll();
        private EmployeeBll eBll = new EmployeeBll();
        private int _eId = 0;
        private string _type = "";

        public AddInsure(int eId,string type)
        {
            _eId = eId;
            _type = type;
            InitializeComponent();
        }

        private void AddInsure_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = eBll.GetEmployee(_eId).EName;
            dtpDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            for (int i = 0; i < cbType.Items.Count; i++)
            {
                if (cbType.Items[i].ToString() == _type)
                {
                    cbType.SelectedIndex = i;
                    break;
                }
            }

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

            Insure record = new Insure();
            record.EId = _eId;
            record.Date = Convert.ToDateTime(dtpDate.Text);
            record.Type = cbType.SelectedItem.ToString();
            record.BaseNumber = Convert.ToDouble(baseNumber);
            record.Company = Convert.ToDouble(company);
            record.Person = Convert.ToDouble(person);

            iBll.Insert(record);
            MessageBox.Show("添加成功！");
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
