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
    public partial class AddPosTitle : Form
    {
        private PosTitleBll pBll = new PosTitleBll();

        public AddPosTitle()
        {
            InitializeComponent();
        }

        private void AddPosTitle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtPName.Text.Trim();
            string comment = txtComment.Text.Trim();

            if (name.Length == 0)
            {
                MessageBox.Show("名称不能为空");
                return;
            }

            PosTitle posTitle = new PosTitle();
            posTitle.PName = name;
            posTitle.Comment = comment;

            pBll.Insert(posTitle);
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
