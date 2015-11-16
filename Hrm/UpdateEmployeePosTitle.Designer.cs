namespace Hrm
{
    partial class UpdateEmployeePosTitle
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
            this.lblObtainDate = new System.Windows.Forms.Label();
            this.lblObtainWay = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosTitle = new System.Windows.Forms.ComboBox();
            this.lblEmployCompany = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpObtainDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtEmployCompany = new System.Windows.Forms.TextBox();
            this.cbObtainWay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(122, 272);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "保存";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblObtainDate
            // 
            this.lblObtainDate.AutoSize = true;
            this.lblObtainDate.Location = new System.Drawing.Point(43, 86);
            this.lblObtainDate.Name = "lblObtainDate";
            this.lblObtainDate.Size = new System.Drawing.Size(65, 12);
            this.lblObtainDate.TabIndex = 2;
            this.lblObtainDate.Text = "获取日期：";
            // 
            // lblObtainWay
            // 
            this.lblObtainWay.AutoSize = true;
            this.lblObtainWay.Location = new System.Drawing.Point(43, 116);
            this.lblObtainWay.Name = "lblObtainWay";
            this.lblObtainWay.Size = new System.Drawing.Size(65, 12);
            this.lblObtainWay.TabIndex = 3;
            this.lblObtainWay.Text = "获取方式：";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(67, 26);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(41, 12);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "员工：";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(112, 22);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(172, 21);
            this.txtEmployee.TabIndex = 7;
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Location = new System.Drawing.Point(290, 21);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(45, 23);
            this.btnSelectEmployee.TabIndex = 8;
            this.btnSelectEmployee.Text = "选择";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            this.btnSelectEmployee.Click += new System.EventHandler(this.btnSelectEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "职称：";
            // 
            // cbPosTitle
            // 
            this.cbPosTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosTitle.FormattingEnabled = true;
            this.cbPosTitle.Location = new System.Drawing.Point(112, 52);
            this.cbPosTitle.Name = "cbPosTitle";
            this.cbPosTitle.Size = new System.Drawing.Size(172, 20);
            this.cbPosTitle.TabIndex = 10;
            // 
            // lblEmployCompany
            // 
            this.lblEmployCompany.AutoSize = true;
            this.lblEmployCompany.Location = new System.Drawing.Point(43, 146);
            this.lblEmployCompany.Name = "lblEmployCompany";
            this.lblEmployCompany.Size = new System.Drawing.Size(65, 12);
            this.lblEmployCompany.TabIndex = 11;
            this.lblEmployCompany.Text = "聘用单位：";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(43, 176);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 12);
            this.lblPosition.TabIndex = 12;
            this.lblPosition.Text = "聘用职务：";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(19, 206);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 12);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "聘用起始日期：";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(19, 236);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(89, 12);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "聘用结束日期：";
            // 
            // dtpObtainDate
            // 
            this.dtpObtainDate.Location = new System.Drawing.Point(112, 86);
            this.dtpObtainDate.Name = "dtpObtainDate";
            this.dtpObtainDate.Size = new System.Drawing.Size(113, 21);
            this.dtpObtainDate.TabIndex = 15;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(112, 202);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(113, 21);
            this.dtpStartDate.TabIndex = 16;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(112, 231);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(113, 21);
            this.dtpEndDate.TabIndex = 17;
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(112, 170);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(172, 20);
            this.cbPosition.TabIndex = 18;
            // 
            // txtEmployCompany
            // 
            this.txtEmployCompany.Location = new System.Drawing.Point(112, 141);
            this.txtEmployCompany.Name = "txtEmployCompany";
            this.txtEmployCompany.Size = new System.Drawing.Size(172, 21);
            this.txtEmployCompany.TabIndex = 19;
            // 
            // cbObtainWay
            // 
            this.cbObtainWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObtainWay.FormattingEnabled = true;
            this.cbObtainWay.Items.AddRange(new object[] {
            "评定",
            "考试"});
            this.cbObtainWay.Location = new System.Drawing.Point(112, 113);
            this.cbObtainWay.Name = "cbObtainWay";
            this.cbObtainWay.Size = new System.Drawing.Size(172, 20);
            this.cbObtainWay.TabIndex = 20;
            // 
            // UpdateEmployeePosTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 315);
            this.Controls.Add(this.cbObtainWay);
            this.Controls.Add(this.txtEmployCompany);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpObtainDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblEmployCompany);
            this.Controls.Add(this.cbPosTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectEmployee);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblObtainWay);
            this.Controls.Add(this.lblObtainDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateEmployeePosTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改职称评定";
            this.Load += new System.EventHandler(this.UpdateEmployeePosTitle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblObtainDate;
        private System.Windows.Forms.Label lblObtainWay;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPosTitle;
        private System.Windows.Forms.Label lblEmployCompany;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpObtainDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtEmployCompany;
        private System.Windows.Forms.ComboBox cbObtainWay;
    }
}