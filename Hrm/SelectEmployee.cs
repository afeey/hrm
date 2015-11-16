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
    public partial class SelectEmployee : Form
    {
        private OrganizationBll oBll = new OrganizationBll();
        private EmployeeBll eBll = new EmployeeBll();
        public string text = "";
        public int value = 0;

        public SelectEmployee()
        {
            InitializeComponent();
        }

        private void SelectOrganization_Load(object sender, EventArgs e)
        {
            imageList.Images.Add("folder", Properties.Resources.folder);
            imageList.Images.Add("person", Properties.Resources.person);

            BindEmployeeTree();
        }

        //绑定员工树
        private void BindEmployeeTree()
        {
            tvEmployee.Nodes.Clear();
            Organization rootOrg = oBll.GetOrganization(1);
            TreeNode root = new TreeNode();
            root.Text = rootOrg.OName;
            root.Tag = rootOrg.OId;
            root.ImageKey = "folder";
            root.SelectedImageKey = "folder";

            IList<Employee> lstEmployee = eBll.GetEmployeeByOrgId(rootOrg.OId);
            foreach (Employee e in lstEmployee)
            {
                TreeNode eNode = new TreeNode();
                eNode.Text = e.EName + "(" + e.Code + ")";
                eNode.Tag = "E_" + e.EId;
                eNode.ImageKey = "person";
                eNode.SelectedImageKey = "person";

                root.Nodes.Add(eNode);
            }

            root.Expand();
            CreateChildNode(ref root, rootOrg.OId);

            tvEmployee.Nodes.Add(root);
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

                IList<Employee> lstEmployee = eBll.GetEmployeeByOrgId(org.OId);
                foreach (Employee e in lstEmployee)
                {
                    TreeNode eNode = new TreeNode();
                    eNode.Text = e.EName + "(" + e.Code + ")";
                    eNode.Tag = "E_" + e.EId;
                    eNode.ImageKey = "person";
                    eNode.SelectedImageKey = "person";

                    node.Nodes.Add(eNode);
                }

                CreateChildNode(ref node, org.OId);

                treeNode.Nodes.Add(node);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tvEmployee.SelectedNode == null)
            {
                MessageBox.Show("请选择员工");
                return;
            }
            else
            {
                string tag = tvEmployee.SelectedNode.Tag.ToString();
                if (!tag.StartsWith("E_"))
                {
                    MessageBox.Show("请选择员工");
                    return;
                }

                int id = Convert.ToInt32(tvEmployee.SelectedNode.Tag.ToString().Replace("E_",""));
                this.value = id;
                this.text = tvEmployee.SelectedNode.Text;

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
