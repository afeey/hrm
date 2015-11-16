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
    public partial class AddLeaveRecord : Form
    {
        private LeaveRecordBll rBll = new LeaveRecordBll();
        private EmployeeBll eBll = new EmployeeBll();
        private int _eId = 0;

        public AddLeaveRecord(int eId)
        {
            _eId = eId;
            InitializeComponent();
        }

        private void AddLeaveRecord_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = eBll.GetEmployee(_eId).EName;
            dtpStartDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            dtpEndDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            cbType.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string approver = txtApprover.Text.Trim();
            string comment = txtComment.Text.Trim();

            if (approver.Length == 0)
            {
                MessageBox.Show("批准人不能为空");
                return;
            }

            LeaveRecord record = new LeaveRecord();
            record.EId = _eId;
            record.Type = cbType.SelectedItem.ToString();
            record.StartDate =Convert.ToDateTime(dtpStartDate.Text);
            record.EndDate = Convert.ToDateTime(dtpEndDate.Text);
            record.Approver = approver;
            record.Comment = comment;

            rBll.Insert(record);
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
