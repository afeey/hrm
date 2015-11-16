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
    public partial class UpdateLeaveRecord : Form
    {
        private LeaveRecordBll rBll = new LeaveRecordBll();
        private EmployeeBll eBll = new EmployeeBll();
        private int _id = 0;
        private LeaveRecord record;

        public UpdateLeaveRecord(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateLeaveRecord_Load(object sender, EventArgs e)
        {
            BindLeaveRecordInfo();
        }

        /// <summary>
        /// 绑定休假记录信息
        /// </summary>
        private void BindLeaveRecordInfo()
        {
            record = rBll.GetLeaveRecord(_id);

            lblEmployeeName.Text = eBll.GetEmployee(record.EId).EName;
            dtpStartDate.Text = record.StartDate.ToString("yyyy年MM月dd日");
            dtpEndDate.Text = record.EndDate.ToString("yyyy年MM月dd日");
            txtApprover.Text = record.Approver;
            txtComment.Text = record.Comment;
            for (int i = 0; i < cbType.Items.Count; i++)
            {
                if (cbType.Items[i].ToString() == record.Type)
                {
                    cbType.SelectedIndex = i;
                    break;
                }
            }
            
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

            record.Type = cbType.SelectedItem.ToString();
            record.StartDate =Convert.ToDateTime(dtpStartDate.Text);
            record.EndDate = Convert.ToDateTime(dtpEndDate.Text);
            record.Approver = approver;
            record.Comment = comment;

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
