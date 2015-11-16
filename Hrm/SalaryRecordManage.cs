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
    public partial class SalaryRecordManage : Form
    {
        private OrganizationBll oBll = new OrganizationBll();
        private EmployeeBll eBll = new EmployeeBll();
        private SalaryRecordBll sBll = new SalaryRecordBll();
        private int currentId = 0;//当前员工ID

        public SalaryRecordManage()
        {
            InitializeComponent();
        }

        private void SalaryRecordManage_Load(object sender, EventArgs e)
        {
            imageList.Images.Add("folder",Properties.Resources.folder);
            imageList.Images.Add("person", Properties.Resources.person);

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
        /// 绑定工资记录列表
        /// </summary>
        /// <param name="id"></param>
        private void BindSalaryRecordList(int id)
        {
            dgvRecord.AutoGenerateColumns = false;
            dgvRecord.DataSource = sBll.GetSalaryRecordByEId(id);

            Employee e= eBll.GetEmployee(id);
            groupRecord.Text = e.EName + "(" + e.Code+ ")工资记录";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentId == 0)
            {
                MessageBox.Show("请选择员工");
                return;
            }
            if (new AddSalaryRecord(currentId).ShowDialog() == DialogResult.OK)
            {
                BindSalaryRecordList(currentId);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             DataGridViewSelectedRowCollection rows = dgvRecord.SelectedRows;

             if (rows.Count > 0)
             {
                 int id = (int)rows[0].Cells["ID"].Value;

                 if (new UpdateSalaryRecord(id).ShowDialog() == DialogResult.OK)
                 {
                     BindSalaryRecordList(currentId);
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

                    BindSalaryRecordList(currentId);
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
                    BindSalaryRecordList(currentId);
                }
            }
             
        }

    }
}
