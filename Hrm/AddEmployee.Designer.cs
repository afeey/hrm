namespace Hrm
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblMarried = new System.Windows.Forms.Label();
            this.groupSex = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.groupMarried = new System.Windows.Forms.GroupBox();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.rbtnNotMarried = new System.Windows.Forms.RadioButton();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.btnSelectOrg = new System.Windows.Forms.Button();
            this.lblIdCode = new System.Windows.Forms.Label();
            this.txtIcCode = new System.Windows.Forms.TextBox();
            this.lblBirthDaty = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbEducation = new System.Windows.Forms.ComboBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.groupSex.SuspendLayout();
            this.groupMarried.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(243, 275);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "保存";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(11, 18);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(65, 12);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "编    号：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(216, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓    名：";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(80, 14);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(130, 21);
            this.txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(283, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(283, 54);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(130, 21);
            this.txtCountry.TabIndex = 7;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(11, 58);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "性    别：";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(216, 58);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 12);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "国    籍：";
            // 
            // lblMarried
            // 
            this.lblMarried.AutoSize = true;
            this.lblMarried.Location = new System.Drawing.Point(11, 101);
            this.lblMarried.Name = "lblMarried";
            this.lblMarried.Size = new System.Drawing.Size(65, 12);
            this.lblMarried.TabIndex = 10;
            this.lblMarried.Text = "婚姻状况：";
            // 
            // groupSex
            // 
            this.groupSex.Controls.Add(this.rbtnFemale);
            this.groupSex.Controls.Add(this.rbtnMale);
            this.groupSex.Location = new System.Drawing.Point(80, 45);
            this.groupSex.Name = "groupSex";
            this.groupSex.Size = new System.Drawing.Size(99, 32);
            this.groupSex.TabIndex = 11;
            this.groupSex.TabStop = false;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(52, 11);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(35, 16);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(7, 11);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(35, 16);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // groupMarried
            // 
            this.groupMarried.Controls.Add(this.rbtnMarried);
            this.groupMarried.Controls.Add(this.rbtnNotMarried);
            this.groupMarried.Location = new System.Drawing.Point(80, 88);
            this.groupMarried.Name = "groupMarried";
            this.groupMarried.Size = new System.Drawing.Size(117, 32);
            this.groupMarried.TabIndex = 12;
            this.groupMarried.TabStop = false;
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Location = new System.Drawing.Point(60, 11);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(47, 16);
            this.rbtnMarried.TabIndex = 1;
            this.rbtnMarried.Text = "已婚";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // rbtnNotMarried
            // 
            this.rbtnNotMarried.AutoSize = true;
            this.rbtnNotMarried.Checked = true;
            this.rbtnNotMarried.Location = new System.Drawing.Point(7, 11);
            this.rbtnNotMarried.Name = "rbtnNotMarried";
            this.rbtnNotMarried.Size = new System.Drawing.Size(47, 16);
            this.rbtnNotMarried.TabIndex = 0;
            this.rbtnNotMarried.TabStop = true;
            this.rbtnNotMarried.Text = "未婚";
            this.rbtnNotMarried.UseVisualStyleBackColor = true;
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(490, 99);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.ReadOnly = true;
            this.txtOrgName.Size = new System.Drawing.Size(86, 21);
            this.txtOrgName.TabIndex = 13;
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = true;
            this.lblOrgName.Location = new System.Drawing.Point(422, 103);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(65, 12);
            this.lblOrgName.TabIndex = 14;
            this.lblOrgName.Text = "部    门：";
            // 
            // btnSelectOrg
            // 
            this.btnSelectOrg.Location = new System.Drawing.Point(582, 97);
            this.btnSelectOrg.Name = "btnSelectOrg";
            this.btnSelectOrg.Size = new System.Drawing.Size(38, 23);
            this.btnSelectOrg.TabIndex = 15;
            this.btnSelectOrg.Text = "选择";
            this.btnSelectOrg.UseVisualStyleBackColor = true;
            this.btnSelectOrg.Click += new System.EventHandler(this.btnSelectOrg_Click);
            // 
            // lblIdCode
            // 
            this.lblIdCode.AutoSize = true;
            this.lblIdCode.Location = new System.Drawing.Point(422, 18);
            this.lblIdCode.Name = "lblIdCode";
            this.lblIdCode.Size = new System.Drawing.Size(65, 12);
            this.lblIdCode.TabIndex = 16;
            this.lblIdCode.Text = "身份证号：";
            // 
            // txtIcCode
            // 
            this.txtIcCode.Location = new System.Drawing.Point(490, 14);
            this.txtIcCode.Name = "txtIcCode";
            this.txtIcCode.Size = new System.Drawing.Size(130, 21);
            this.txtIcCode.TabIndex = 17;
            // 
            // lblBirthDaty
            // 
            this.lblBirthDaty.AutoSize = true;
            this.lblBirthDaty.Location = new System.Drawing.Point(422, 58);
            this.lblBirthDaty.Name = "lblBirthDaty";
            this.lblBirthDaty.Size = new System.Drawing.Size(65, 12);
            this.lblBirthDaty.TabIndex = 18;
            this.lblBirthDaty.Text = "出生日期：";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(216, 103);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 12);
            this.lblPosition.TabIndex = 19;
            this.lblPosition.Text = "职    务：";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(10, 146);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(65, 12);
            this.lblEducation.TabIndex = 20;
            this.lblEducation.Text = "学    历：";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(215, 145);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(65, 12);
            this.lblSchool.TabIndex = 21;
            this.lblSchool.Text = "毕业学校：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(11, 188);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "联系电话：";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(216, 188);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(65, 12);
            this.lblCellPhone.TabIndex = 23;
            this.lblCellPhone.Text = "手    机：";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(11, 233);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "家庭地址：";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(422, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 12);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "邮    箱：";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(422, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 12);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "员工类别：";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(490, 54);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(130, 21);
            this.dtpBirthDay.TabIndex = 27;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "在职",
            "离职"});
            this.cbStatus.Location = new System.Drawing.Point(490, 186);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(132, 20);
            this.cbStatus.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(490, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 21);
            this.txtEmail.TabIndex = 29;
            // 
            // cbEducation
            // 
            this.cbEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEducation.FormattingEnabled = true;
            this.cbEducation.Items.AddRange(new object[] {
            "博士",
            "硕士",
            "本科",
            "大专",
            "中专",
            "高中",
            "初中",
            "小学",
            "小学以下"});
            this.cbEducation.Location = new System.Drawing.Point(80, 143);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Size = new System.Drawing.Size(121, 20);
            this.cbEducation.TabIndex = 30;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(283, 185);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(130, 21);
            this.txtCellPhone.TabIndex = 31;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(80, 185);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 21);
            this.txtPhone.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(80, 230);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(333, 21);
            this.txtAddress.TabIndex = 33;
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(283, 142);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(130, 21);
            this.txtSchool.TabIndex = 34;
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(283, 99);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(130, 20);
            this.cbPosition.TabIndex = 35;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 312);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.cbEducation);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblBirthDaty);
            this.Controls.Add(this.txtIcCode);
            this.Controls.Add(this.lblIdCode);
            this.Controls.Add(this.btnSelectOrg);
            this.Controls.Add(this.lblOrgName);
            this.Controls.Add(this.txtOrgName);
            this.Controls.Add(this.groupMarried);
            this.Controls.Add(this.groupSex);
            this.Controls.Add(this.lblMarried);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.groupSex.ResumeLayout(false);
            this.groupSex.PerformLayout();
            this.groupMarried.ResumeLayout(false);
            this.groupMarried.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblMarried;
        private System.Windows.Forms.GroupBox groupSex;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.GroupBox groupMarried;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.RadioButton rbtnNotMarried;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.Button btnSelectOrg;
        private System.Windows.Forms.Label lblIdCode;
        private System.Windows.Forms.TextBox txtIcCode;
        private System.Windows.Forms.Label lblBirthDaty;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbEducation;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}