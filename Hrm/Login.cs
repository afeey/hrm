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
    public partial class Login : Form
    {
        private UserBll uBll = new UserBll();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginName = txtLoginName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (loginName.Length == 0)
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (password.Length == 0)
            {
                MessageBox.Show("密码不能为空");
                return;
            }

            User user = uBll.GetUser(loginName);
            if (user.Password == password)
            {
                GlobalClass.USERID = user.UId;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
                return;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
