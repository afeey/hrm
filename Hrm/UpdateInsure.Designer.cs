namespace Hrm
{
    partial class UpdateInsure
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
            this.numPerson = new System.Windows.Forms.NumericUpDown();
            this.lblPerson = new System.Windows.Forms.Label();
            this.numCompany = new System.Windows.Forms.NumericUpDown();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.numBaseNumber = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBaseNumber = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(64, 199);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "保存";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numPerson
            // 
            this.numPerson.DecimalPlaces = 2;
            this.numPerson.Location = new System.Drawing.Point(97, 152);
            this.numPerson.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPerson.Name = "numPerson";
            this.numPerson.Size = new System.Drawing.Size(120, 21);
            this.numPerson.TabIndex = 30;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(26, 154);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(65, 12);
            this.lblPerson.TabIndex = 29;
            this.lblPerson.Text = "个人缴纳：";
            // 
            // numCompany
            // 
            this.numCompany.DecimalPlaces = 2;
            this.numCompany.Location = new System.Drawing.Point(97, 125);
            this.numCompany.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numCompany.Name = "numCompany";
            this.numCompany.Size = new System.Drawing.Size(120, 21);
            this.numCompany.TabIndex = 28;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(26, 127);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(65, 12);
            this.lblCompany.TabIndex = 27;
            this.lblCompany.Text = "单位缴纳：";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "养老保险",
            "医疗保险",
            "失业保险",
            "生育保险",
            "工伤保险"});
            this.cbType.Location = new System.Drawing.Point(97, 70);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 20);
            this.cbType.TabIndex = 26;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(26, 75);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 25;
            this.lblType.Text = "保险种类：";
            // 
            // numBaseNumber
            // 
            this.numBaseNumber.DecimalPlaces = 2;
            this.numBaseNumber.Location = new System.Drawing.Point(97, 98);
            this.numBaseNumber.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numBaseNumber.Name = "numBaseNumber";
            this.numBaseNumber.Size = new System.Drawing.Size(120, 21);
            this.numBaseNumber.TabIndex = 24;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(97, 42);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 21);
            this.dtpDate.TabIndex = 23;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(50, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 12);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "日期：";
            // 
            // lblBaseNumber
            // 
            this.lblBaseNumber.AutoSize = true;
            this.lblBaseNumber.Location = new System.Drawing.Point(26, 100);
            this.lblBaseNumber.Name = "lblBaseNumber";
            this.lblBaseNumber.Size = new System.Drawing.Size(65, 12);
            this.lblBaseNumber.TabIndex = 21;
            this.lblBaseNumber.Text = "缴纳基数：";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(97, 22);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 12);
            this.lblEmployeeName.TabIndex = 20;
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Location = new System.Drawing.Point(50, 22);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(41, 12);
            this.lblEName.TabIndex = 19;
            this.lblEName.Text = "员工：";
            // 
            // UpdateInsure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 244);
            this.Controls.Add(this.numPerson);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.numCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.numBaseNumber);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBaseNumber);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateInsure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改社保记录";
            this.Load += new System.EventHandler(this.UpdateInsure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numPerson;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.NumericUpDown numCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown numBaseNumber;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBaseNumber;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEName;
    }
}