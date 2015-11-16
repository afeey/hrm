namespace Hrm
{
    partial class EmployeeManage
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.EId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarriedStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Education = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.tvOrg = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(280, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EId,
            this.Code,
            this.EName,
            this.SexStr,
            this.BirthDay,
            this.Country,
            this.MarriedStr,
            this.Education,
            this.IdCode,
            this.Position,
            this.Cellphone,
            this.Phone,
            this.Email});
            this.dgvEmployee.Location = new System.Drawing.Point(199, 42);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowTemplate.Height = 23;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(668, 509);
            this.dgvEmployee.TabIndex = 3;
            // 
            // EId
            // 
            this.EId.DataPropertyName = "EId";
            this.EId.HeaderText = "ID";
            this.EId.Name = "EId";
            this.EId.ReadOnly = true;
            this.EId.Visible = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "编号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 51;
            // 
            // EName
            // 
            this.EName.DataPropertyName = "EName";
            this.EName.HeaderText = "姓名";
            this.EName.Name = "EName";
            this.EName.ReadOnly = true;
            this.EName.Width = 51;
            // 
            // SexStr
            // 
            this.SexStr.DataPropertyName = "SexStr";
            this.SexStr.HeaderText = "性别";
            this.SexStr.Name = "SexStr";
            this.SexStr.ReadOnly = true;
            this.SexStr.Width = 51;
            // 
            // BirthDay
            // 
            this.BirthDay.DataPropertyName = "BirthDay";
            this.BirthDay.HeaderText = "出生日期";
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            this.BirthDay.Width = 61;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "国籍";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 51;
            // 
            // MarriedStr
            // 
            this.MarriedStr.DataPropertyName = "MarriedStr";
            this.MarriedStr.HeaderText = "婚姻状况";
            this.MarriedStr.Name = "MarriedStr";
            this.MarriedStr.ReadOnly = true;
            this.MarriedStr.Width = 61;
            // 
            // Education
            // 
            this.Education.DataPropertyName = "Education";
            this.Education.HeaderText = "学历";
            this.Education.Name = "Education";
            this.Education.ReadOnly = true;
            this.Education.Width = 51;
            // 
            // IdCode
            // 
            this.IdCode.DataPropertyName = "IdCode";
            this.IdCode.HeaderText = "身份证号";
            this.IdCode.Name = "IdCode";
            this.IdCode.ReadOnly = true;
            this.IdCode.Width = 61;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "职务";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 51;
            // 
            // Cellphone
            // 
            this.Cellphone.DataPropertyName = "Cellphone";
            this.Cellphone.HeaderText = "手机";
            this.Cellphone.Name = "Cellphone";
            this.Cellphone.ReadOnly = true;
            this.Cellphone.Width = 51;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 51;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "电子邮件";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 61;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(813, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(54, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(707, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(673, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "姓名";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(529, 19);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 12);
            this.lblCode.TabIndex = 7;
            this.lblCode.Text = "编号";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(564, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 21);
            this.txtCode.TabIndex = 8;
            // 
            // tvOrg
            // 
            this.tvOrg.ImageIndex = 0;
            this.tvOrg.ImageList = this.imageList;
            this.tvOrg.Location = new System.Drawing.Point(12, 12);
            this.tvOrg.Name = "tvOrg";
            this.tvOrg.SelectedImageIndex = 0;
            this.tvOrg.Size = new System.Drawing.Size(181, 537);
            this.tvOrg.TabIndex = 9;
            this.tvOrg.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOrg_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EmployeeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 562);
            this.Controls.Add(this.tvOrg);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "员工档案";
            this.Load += new System.EventHandler(this.EmployeeManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TreeView tvOrg;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarriedStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Education;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}