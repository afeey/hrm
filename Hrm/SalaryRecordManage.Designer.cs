namespace Hrm
{
    partial class SalaryRecordManage
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
            this.tvEmployee = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupRecord = new System.Windows.Forms.GroupBox();
            this.groupEmployee = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupRecord.SuspendLayout();
            this.groupEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvEmployee
            // 
            this.tvEmployee.ImageIndex = 0;
            this.tvEmployee.ImageList = this.imageList;
            this.tvEmployee.Location = new System.Drawing.Point(7, 21);
            this.tvEmployee.Name = "tvEmployee";
            this.tvEmployee.SelectedImageIndex = 0;
            this.tvEmployee.Size = new System.Drawing.Size(175, 519);
            this.tvEmployee.TabIndex = 0;
            this.tvEmployee.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOrg_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.AllowUserToResizeRows = false;
            this.dgvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Salary});
            this.dgvRecord.Location = new System.Drawing.Point(6, 49);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.RowTemplate.Height = 23;
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.Size = new System.Drawing.Size(656, 491);
            this.dgvRecord.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupRecord
            // 
            this.groupRecord.Controls.Add(this.btnAdd);
            this.groupRecord.Controls.Add(this.dgvRecord);
            this.groupRecord.Controls.Add(this.btnDelete);
            this.groupRecord.Controls.Add(this.btnUpdate);
            this.groupRecord.Location = new System.Drawing.Point(199, 4);
            this.groupRecord.Name = "groupRecord";
            this.groupRecord.Size = new System.Drawing.Size(668, 546);
            this.groupRecord.TabIndex = 8;
            this.groupRecord.TabStop = false;
            this.groupRecord.Text = "工资记录";
            // 
            // groupEmployee
            // 
            this.groupEmployee.Controls.Add(this.tvEmployee);
            this.groupEmployee.Location = new System.Drawing.Point(5, 4);
            this.groupEmployee.Name = "groupEmployee";
            this.groupEmployee.Size = new System.Drawing.Size(188, 546);
            this.groupEmployee.TabIndex = 9;
            this.groupEmployee.TabStop = false;
            this.groupEmployee.Text = "员工列表";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "日期";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "工资";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // SalaryRecordManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 562);
            this.Controls.Add(this.groupEmployee);
            this.Controls.Add(this.groupRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalaryRecordManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工资记录";
            this.Load += new System.EventHandler(this.SalaryRecordManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupRecord.ResumeLayout(false);
            this.groupEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvEmployee;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupRecord;
        private System.Windows.Forms.GroupBox groupEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}