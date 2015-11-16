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
    public partial class InsureManage : Form
    {
        private OrganizationBll oBll = new OrganizationBll();
        private EmployeeBll eBll = new EmployeeBll();
        private InsureBll sBll = new InsureBll();
        private int currentId = 0;//当前员工ID

        public InsureManage()
        {
            InitializeComponent();
        }

        private void InsureManage_Load(object sender, EventArgs e)
        {
            imageList.Images.Add("folder",Properties.Resources.folder);
            imageList.Images.Add("person", Properties.Resources.person);

            cbType.SelectedIndex = 0;

            BindEmployeeTree();
        }

        //绑定员工树
        private void BindEmployeeTree()
        {
            tvEmployee.Nodes.Clear();
            Organization rootOrg = oBll.GetOrganization(1);
            TreeNode root=new TreeNode();
            root.Text=rootOrg.OName;
            root.Tag=rootOrg.OId;
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

        /// <summary>
        /// 绑定社保记录列表
        /// </summary>
        /// <param name="id"></param>
        private void BindInsureList(int id,string type)
        {
            dgvRecord.AutoGenerateColumns = false;
            dgvRecord.DataSource = sBll.GetInsureByEId(id,type);

            Employee e= eBll.GetEmployee(id);
            groupRecord.Text = e.EName + "(" + e.Code+ ")社保记录";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentId == 0)
            {
                MessageBox.Show("请选择员工");
                return;
            }
            if (new AddInsure(currentId,cbType.SelectedItem.ToString()).ShowDialog() == DialogResult.OK)
            {
                BindInsureList(currentId, cbType.SelectedItem.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             DataGridViewSelectedRowCollection rows = dgvRecord.SelectedRows;

             if (rows.Count > 0)
             {
                 int id = (int)rows[0].Cells["ID"].Value;

                 if (new UpdateInsure(id).ShowDialog() == DialogResult.OK)
                 {
                     BindInsureList(currentId,cbType.SelectedItem.ToString());
                 }
             }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvRecord.SelectedRows;

            if (rows.Count > 0)
            {
                if (MessageBox.Show("确定删除选中项？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        int id = (int)row.Cells["ID"].Value;
                        sBll.Delete(id);
                    }

                    BindInsureList(currentId,cbType.SelectedItem.ToString());
                }
            }
        }

        private void tvOrg_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvEmployee.SelectedNode != null)
            {
                string tag=tvEmployee.SelectedNode.Tag.ToString();
                if(tag.StartsWith("E_"))
                {
                    currentId=Convert.ToInt32(tag.Replace("E_",""));
                    BindInsureList(currentId, cbType.SelectedItem.ToString());
                }
            }
             
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentId != 0)
            {
                BindInsureList(currentId, cbType.SelectedItem.ToString());
            }
        }

    }
}
