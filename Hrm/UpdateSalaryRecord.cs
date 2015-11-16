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
    public partial class UpdateSalaryRecord : Form
    {
        private SalaryRecordBll rBll = new SalaryRecordBll();
        private EmployeeBll eBll = new EmployeeBll();
        private int _id = 0;
        private SalaryRecord record;

        public UpdateSalaryRecord(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateSalaryRecord_Load(object sender, EventArgs e)
        {
            BindSalaryRecordInfo();
        }

        /// <summary>
        /// 绑定工资记录信息
        /// </summary>
        private void BindSalaryRecordInfo()
        {
            record = rBll.GetSalaryRecord(_id);

            lblEmployeeName.Text = eBll.GetEmployee(record.EId).EName;
            dtpDate.Text = record.Date.ToString("yyyy年MM月dd日");
            numSalary.Value = (decimal)record.Salary;
            
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            string salary = numSalary.Text.Trim();

            if (salary.Length == 0)
            {
                MessageBox.Show("工资不能为空");
                return;
            }

            record.Date = Convert.ToDateTime(dtpDate.Text);
            record.Salary = Convert.ToDouble(salary);

            rBll.Update(record);
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
