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
    public partial class AddPosition : Form
    {
        private PositionBll pBll = new PositionBll();

        public AddPosition()
        {
            InitializeComponent();
        }

        private void AddPosition_Load(object sender, EventArgs e)
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

            Position position = new Position();
            position.PName = name;
            position.Comment = comment;

            pBll.Insert(position);
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
