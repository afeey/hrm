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
    public partial class UpdatePosition : Form
    {
        private PositionBll pBll = new PositionBll();
        private Position position = null;
        private int _id;

        public UpdatePosition(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdatePosition_Load(object sender, EventArgs e)
        {
            BindPositionInfo();
        }

        /// <summary>
        /// 绑定职务信息
        /// </summary>
        private void BindPositionInfo()
        {
            position = pBll.GetPosition(_id);
            txtPName.Text = position.PName;
            txtComment.Text = position.Comment;
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

            position.PName = name;
            position.Comment = comment;

            pBll.Update(position);
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
