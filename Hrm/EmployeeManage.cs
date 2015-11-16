using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using Hrm.Bll;
using Hrm.Model;

namespace Hrm
{
    public partial class EmployeeManage : Form
    {
        private OrganizationBll oBll = new OrganizationBll();
        private PositionBll pBll = new PositionBll();
        private EmployeeBll eBll=new EmployeeBll();
        private int currentId = 1;//当前部门ID

        public EmployeeManage()
        {
            InitializeComponent();
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {
            imageList.Images.Add("folder", Properties.Resources.folder);
            imageList.Images.Add("person", Properties.Resources.person);

            BindOrgTree();
            BindEmployeTable(currentId);
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

        private void BindEmployeTable(int currentId)
        {
            IList<Employee> list = eBll.GetEmployeeByOrgId(currentId);
            foreach (Employee e in list)
            {
                Position p=pBll.GetPosition(e.PId);
                if (p != null)
                    e.Position = p.PName;
            }

            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = list;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new AddEmployee(currentId).ShowDialog() == DialogResult.OK)
            {
                BindEmployeTable(currentId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvEmployee.SelectedRows;

            if(rows.Count>0)
            {
                if (MessageBox.Show("确定删除选中项？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        int id = (int)row.Cells["EId"].Value;
                        eBll.Delete(id);
                    }

                    BindEmployeTable(currentId);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvEmployee.SelectedRows;

            if (rows.Count > 0)
            {
                int id = (int)rows[0].Cells["EId"].Value;

                if (new UpdateEmployee(id).ShowDialog() == DialogResult.OK)
                {
                    BindEmployeTable(currentId);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();

            Hashtable condition = new Hashtable();
            condition["Code"] = code;
            condition["EName"] = name;

            IList<Employee> list = new EmployeeBll().GetEmployeeList(condition);

            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = list;
        }

        private void tvOrg_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvOrg.SelectedNode != null)
            {
                int id = Convert.ToInt32(tvOrg.SelectedNode.Tag);
                currentId = id;

                BindEmployeTable(id);
            }
        }

    }
}
