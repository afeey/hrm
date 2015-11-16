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
    public partial class AddOrganization : Form
    {
        private int _parentId=1;
        private OrganizationBll oBll = new OrganizationBll();

        public AddOrganization(int parentId)
        {
            _parentId = parentId;
            InitializeComponent();
        }

        private void AddOrg_Load(object sender, EventArgs e)
        {
            lblParentName.Text = oBll.GetOrganization(_parentId).OName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string comment = txtComment.Text.Trim();

            if (name.Length == 0)
            {
                MessageBox.Show("名称不能为空");
                return;
            }

            Organization org = new Organization();
            org.ParentId = _parentId;
            org.OName = name;
            org.Comment = comment;

            oBll.Insert(org);
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
