namespace Hrm
{
    partial class AddInsure
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
            this.lblEName = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblBaseNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numBaseNumber = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.numCompany = new System.Windows.Forms.NumericUpDown();
            this.lblCompany = new System.Windows.Forms.Label();
            this.numPerson = new System.Windows.Forms.NumericUpDown();
            this.lblPerson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerson)).BeginInit();
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
            this.btnCancel.Location = new System.Drawing.Point(145, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEName
            // 
            this.lblEName.AutoSize = true;
            this.lblEName.Location = new System.Drawing.Point(50, 22);
            this.lblEName.Name = "lblEName";
            this.lblEName.Size = new System.Drawing.Size(41, 12);
            this.lblEName.TabIndex = 6;
            this.lblEName.Text = "员工：";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(97, 22);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 12);
            this.lblEmployeeName.TabIndex = 7;
            // 
            // lblBaseNumber
            // 
            this.lblBaseNumber.AutoSize = true;
            this.lblBaseNumber.Location = new System.Drawing.Point(26, 101);
            this.lblBaseNumber.Name = "lblBaseNumber";
            this.lblBaseNumber.Size = new System.Drawing.Size(65, 12);
            this.lblBaseNumber.TabIndex = 8;
            this.lblBaseNumber.Text = "缴纳基数：";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(50, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 12);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "日期：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(97, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 21);
            this.dtpDate.TabIndex = 11;
            // 
            // numBaseNumber
            // 
            this.numBaseNumber.DecimalPlaces = 2;
            this.numBaseNumber.Location = new System.Drawing.Point(97, 99);
            this.numBaseNumber.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numBaseNumber.Name = "numBaseNumber";
            this.numBaseNumber.Size = new System.Drawing.Size(120, 21);
            this.numBaseNumber.TabIndex = 12;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(26, 76);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "保险种类：";
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
            this.cbType.Location = new System.Drawing.Point(97, 71);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 20);
            this.cbType.TabIndex = 14;
            // 
            // numCompany
            // 
            this.numCompany.DecimalPlaces = 2;
            this.numCompany.Location = new System.Drawing.Point(97, 126);
            this.numCompany.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numCompany.Name = "numCompany";
            this.numCompany.Size = new System.Drawing.Size(120, 21);
            this.numCompany.TabIndex = 16;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(26, 128);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(65, 12);
            this.lblCompany.TabIndex = 15;
            this.lblCompany.Text = "单位缴纳：";
            // 
            // numPerson
            // 
            this.numPerson.DecimalPlaces = 2;
            this.numPerson.Location = new System.Drawing.Point(97, 153);
            this.numPerson.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPerson.Name = "numPerson";
            this.numPerson.Size = new System.Drawing.Size(120, 21);
            this.numPerson.TabIndex = 18;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(26, 155);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(65, 12);
            this.lblPerson.TabIndex = 17;
            this.lblPerson.Text = "个人缴纳：";
            // 
            // AddInsure
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
            this.Name = "AddInsure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加社保记录";
            this.Load += new System.EventHandler(this.AddInsure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBaseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblBaseNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown numBaseNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown numCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.NumericUpDown numPerson;
        private System.Windows.Forms.Label lblPerson;
    }
}