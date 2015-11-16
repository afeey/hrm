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
    public partial class UpdateUser : Form
    {
        private UserBll uBll = new UserBll();
        private User user = null;
        private int _id;

        public UpdateUser(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            BindUserInfo();
        }

        /// <summary>
        /// 绑定用户信息
        /// </summary>
        private void BindUserInfo()
        {
            user = uBll.GetUser(_id);
            txtUserName.Text = user.UName;
            txtLoginName.Text = user.LoginName;
            txtPassword.Text = user.Password;
            txtConfirmPwd.Text = user.Password;
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

            user.UName = userName;
            user.LoginName = loginName;
            user.Password = pwd;

            uBll.Update(user);
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
