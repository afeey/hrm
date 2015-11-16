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
    public partial class AddSalaryRecord : Form
    {
        private SalaryRecordBll sBll = new SalaryRecordBll();
        private EmployeeBll eBll = new EmployeeBll();
        private int _eId = 0;

        public AddSalaryRecord(int eId)
        {
            _eId = eId;
            InitializeComponent();
        }

        private void AddSalaryRecord_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = eBll.GetEmployee(_eId).EName;
            dtpDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string salary = numSalary.Text.Trim();

            if (salary.Length == 0)
            {
                MessageBox.Show("工资不能为空");
                return;
            }

            SalaryRecord record = new SalaryRecord();
            record.EId = _eId;
            record.Date = Convert.ToDateTime(dtpDate.Text);
            record.Salary = Convert.ToDouble(salary);

            sBll.Insert(record);
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
