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
    public partial class SelectOrganization : Form
    {
        private OrganizationBll oBll = new OrganizationBll();
        public string text = "";
        public int value = 0;

        public SelectOrganization()
        {
            InitializeComponent();
        }

        private void SelectOrganization_Load(object sender, EventArgs e)
        {
            imageList.Images.Add("folder", Properties.Resources.folder);
            imageList.Images.Add("person", Properties.Resources.person);

            BindOrgTree();
        }

        //绑定部门树
        private void BindOrgTree()
        {
            tvOrg.Nodes.Clear();
            Organization rootOrg = oBll.GetOrganization(1);
            TreeNode root = new TreeNode();
            root.Text = rootOrg.OName;
            root.Tag = rootOrg.OId;
            root.ImageKey = "folder";
            root.SelectedImageKey = "folder";

            CreateChildNode(ref root, rootOrg.OId);

            tvOrg.Nodes.Add(root);
            tvOrg.ExpandAll();
        }

        private void CreateChildNode(ref TreeNode treeNode, int oId)
        {
            IList<Organization> lstOrg = oBll.GetChildOrganization(oId);
            foreach (Organization org in lstOrg)
            {
                TreeNode node = new TreeNode();
                node.Text = org.OName;
                node.Tag = org.OId;
                node.ImageKey = "folder";
                node.SelectedImageKey = "folder";

                CreateChildNode(ref node, org.OId);

                treeNode.Nodes.Add(node);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tvOrg.SelectedNode == null)
            {
                MessageBox.Show("请选择部门");
                return;
            }
            else
            {
                int id = Convert.ToInt32(tvOrg.SelectedNode.Tag);
                this.value = id;
                this.text = tvOrg.SelectedNode.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
