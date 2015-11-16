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
    public partial class AddUser : Form
    {
        private UserBll uBll = new UserBll();

        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string loginName = txtLoginName.Text.Trim();
            string pwd = txtPassword.Text.Trim();
            string confirmPwd = txtConfirmPwd.Text.Trim();

            if (userName.Length == 0)
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if (loginName.Length == 0)
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (pwd.Length == 0)
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (confirmPwd.Length == 0)
            {
                MessageBox.Show("确认密码不能为空");
                return;
            }
            if (pwd != confirmPwd)
            {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }

            User user = new User();
            user.UName = userName;
            user.LoginName = loginName;
            user.Password = pwd;

            uBll.Insert(user);
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
