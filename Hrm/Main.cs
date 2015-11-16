using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hrm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            if (new Login().ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        //员工档案
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            new EmployeeManage().ShowDialog();
        }

        //部门管理
        private void btnOrganization_Click(object sender, EventArgs e)
        {
            new OrganizationManage().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出系统？", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            new UserManage().ShowDialog();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            new PositionManage().ShowDialog();
        }

        private void btnPosTitle_Click(object sender, EventArgs e)
        {
            new PosTitleManage().ShowDialog();
        }

        private void btnLeaveRecord_Click(object sender, EventArgs e)
        {
            new LeaveRecordManage().ShowDialog();
        }

        private void btnSalaryRecord_Click(object sender, EventArgs e)
        {
            new SalaryRecordManage().ShowDialog();
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            new InsureManage().ShowDialog();
        }

        private void btnPosTitleAssess_Click(object sender, EventArgs e)
        {
            new EmployeePosTitleManage().ShowDialog();
        }


    }
}
