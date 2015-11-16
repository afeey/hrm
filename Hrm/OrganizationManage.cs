using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Hrm.Common;
using Hrm.Bll;
using Hrm.Model;

namespace Hrm
{
    public partial class OrganizationManage : Form
    {
        private OrganizationBll oBll = new OrganizationBll();
        private int currentId = 1;//当前部门ID

        public OrganizationManage()
        {
            InitializeComponent();
        }

        private void OrgManage_Load(object sender, EventArgs e)
        {
            imageList.Images.Add("folder", Properties.Resources.folder);
            imageList.Images.Add("person", Properties.Resources.person);

            BindOrgTree();
            BindOrgList(currentId);
        }

        //绑定部门树
        private void BindOrgTree()
        {
            tvOrg.Nodes.Clear();
            Organization rootOrg = oBll.GetOrganization(1);
            TreeNode root=new TreeNode();
            root.Text=rootOrg.OName;
            root.Tag=rootOrg.OId;
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


        private void BindOrgList(int id)
        {
            dgvOrg.AutoGenerateColumns = false;
            dgvOrg.DataSource = oBll.GetChildOrganization(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddOrganization(currentId).ShowDialog() == DialogResult.OK)
            {
                BindOrgTree();
                BindOrgList(currentId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             DataGridViewSelectedRowCollection rows = dgvOrg.SelectedRows;

             if (rows.Count > 0)
             {
                 int id = (int)rows[0].Cells["OId"].Value;

                 if (new UpdateOrganization(id).ShowDialog() == DialogResult.OK)
                 {
                     BindOrgTree();
                     BindOrgList(currentId);
                 }
             }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvOrg.SelectedRows;

            if (rows.Count > 0)
            {
                if (MessageBox.Show("确定删除选中项？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        int id = (int)row.Cells["OId"].Value;
                        oBll.Delete(id);
                    }

                    BindOrgTree();
                    BindOrgList(currentId);
                }
            }
        }

        private void tvOrg_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvOrg.SelectedNode != null)
            {
                int id = Convert.ToInt32(tvOrg.SelectedNode.Tag);
                currentId = id;

                BindOrgList(id);
            }
             
        }

    }
}
