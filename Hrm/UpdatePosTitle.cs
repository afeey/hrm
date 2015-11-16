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
    public partial class UpdatePosTitle : Form
    {
        private PosTitleBll pBll = new PosTitleBll();
        private PosTitle posTitle = null;
        private int _id;

        public UpdatePosTitle(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdatePosTitle_Load(object sender, EventArgs e)
        {
            BindPosTitleInfo();
        }

        /// <summary>
        /// 绑定职称信息
        /// </summary>
        private void BindPosTitleInfo()
        {
            posTitle = pBll.GetPosTitle(_id);
            txtPName.Text = posTitle.PName;
            txtComment.Text = posTitle.Comment;
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

            posTitle.PName = name;
            posTitle.Comment = comment;

            pBll.Update(posTitle);
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
