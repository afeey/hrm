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
    public partial class UpdateOrganization : Form
    {
        private int _id;
        private Organization _org = null;
        private OrganizationBll _oBll = new OrganizationBll();

        public UpdateOrganization(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateOrganization_Load(object sender, EventArgs e)
        {
            BindOrganizationInfo();
        }

        private void BindOrganizationInfo()
        {
            _org = _oBll.GetOrganization(_id);
            lblParentName.Text = _oBll.GetOrganization(_org.OId).OName;
            txtName.Text = _org.OName;
            txtComment.Text = _org.Comment;
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

            _org.OName = name;
            _org.Comment = comment;

            _oBll.Update(_org);
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
