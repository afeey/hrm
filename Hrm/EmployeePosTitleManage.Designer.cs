namespace Hrm
{
    partial class EmployeePosTitleManage
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvEmployeePosTitle = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePosTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEmployeePosTitle
            // 
            this.dgvEmployeePosTitle.AllowUserToAddRows = false;
            this.dgvEmployeePosTitle.AllowUserToDeleteRows = false;
            this.dgvEmployeePosTitle.AllowUserToResizeRows = false;
            this.dgvEmployeePosTitle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeePosTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeePosTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Code,
            this.EName,
            this.PosName,
            this.ObtainDate,
            this.ObtainWay,
            this.EmployCompany,
            this.PositionName,
            this.StartDate,
            this.EndDate});
            this.dgvEmployeePosTitle.Location = new System.Drawing.Point(12, 41);
            this.dgvEmployeePosTitle.Name = "dgvEmployeePosTitle";
            this.dgvEmployeePosTitle.ReadOnly = true;
            this.dgvEmployeePosTitle.RowHeadersVisible = false;
            this.dgvEmployeePosTitle.RowTemplate.Height = 23;
            this.dgvEmployeePosTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeePosTitle.Size = new System.Drawing.Size(855, 509);
            this.dgvEmployeePosTitle.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "编号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // EName
            // 
            this.EName.DataPropertyName = "EName";
            this.EName.HeaderText = "姓名";
            this.EName.Name = "EName";
            this.EName.ReadOnly = true;
            // 
            // PosName
            // 
            this.PosName.DataPropertyName = "PosName";
            this.PosName.HeaderText = "职称";
            this.PosName.Name = "PosName";
            this.PosName.ReadOnly = true;
            // 
            // ObtainDate
            // 
            this.ObtainDate.DataPropertyName = "ObtainDate";
            this.ObtainDate.HeaderText = "获取日期";
            this.ObtainDate.Name = "ObtainDate";
            this.ObtainDate.ReadOnly = true;
            // 
            // ObtainWay
            // 
            this.ObtainWay.DataPropertyName = "ObtainWay";
            this.ObtainWay.HeaderText = "获取方式";
            this.ObtainWay.Name = "ObtainWay";
            this.ObtainWay.ReadOnly = true;
            // 
            // EmployCompany
            // 
            this.EmployCompany.DataPropertyName = "EmployCompany";
            this.EmployCompany.HeaderText = "聘用单位";
            this.EmployCompany.Name = "EmployCompany";
            this.EmployCompany.ReadOnly = true;
            // 
            // PositionName
            // 
            this.PositionName.DataPropertyName = "PositionName";
            this.PositionName.HeaderText = "聘用职务";
            this.PositionName.Name = "PositionName";
            this.PositionName.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "起始日期";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "结束日期";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // EmployeePosTitleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 562);
            this.Controls.Add(this.dgvEmployeePosTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeePosTitleManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "职称评定";
            this.Load += new System.EventHandler(this.EmployeePosTitleManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeePosTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvEmployeePosTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}