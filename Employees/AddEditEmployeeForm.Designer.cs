namespace Employees
{
    partial class AddEditEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditEmployeeForm));
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDismissalDate = new System.Windows.Forms.Label();
            this.dtpDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.chbIsHired = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.ctbSalary = new EmployeesControls.CurrencyTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CustomFormat = "ddMMMMyyyy";
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(130, 173);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(140, 20);
            this.dtpHireDate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data zatrudnienia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imię:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(130, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(140, 20);
            this.tbFirstName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(130, 66);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(140, 20);
            this.tbLastName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(130, 12);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(140, 20);
            this.tbId.TabIndex = 9;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zarobki:";
            // 
            // lbDismissalDate
            // 
            this.lbDismissalDate.AutoSize = true;
            this.lbDismissalDate.Location = new System.Drawing.Point(12, 207);
            this.lbDismissalDate.Name = "lbDismissalDate";
            this.lbDismissalDate.Size = new System.Drawing.Size(85, 13);
            this.lbDismissalDate.TabIndex = 13;
            this.lbDismissalDate.Text = "Data zwolnienia:";
            // 
            // dtpDismissalDate
            // 
            this.dtpDismissalDate.CustomFormat = "ddMMMMyyyy";
            this.dtpDismissalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDismissalDate.Location = new System.Drawing.Point(130, 203);
            this.dtpDismissalDate.Name = "dtpDismissalDate";
            this.dtpDismissalDate.Size = new System.Drawing.Size(140, 20);
            this.dtpDismissalDate.TabIndex = 14;
            // 
            // chbIsHired
            // 
            this.chbIsHired.AutoSize = true;
            this.chbIsHired.Location = new System.Drawing.Point(130, 230);
            this.chbIsHired.Name = "chbIsHired";
            this.chbIsHired.Size = new System.Drawing.Size(82, 17);
            this.chbIsHired.TabIndex = 17;
            this.chbIsHired.Text = "Zatrudniony";
            this.chbIsHired.UseVisualStyleBackColor = true;
            this.chbIsHired.CheckedChanged += new System.EventHandler(this.chbIsHired_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Uwagi:";
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(130, 119);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(140, 48);
            this.tbComments.TabIndex = 19;
            // 
            // ctbSalary
            // 
            this.ctbSalary.CultureName = "pl-PL";
            this.ctbSalary.Location = new System.Drawing.Point(130, 93);
            this.ctbSalary.Name = "ctbSalary";
            this.ctbSalary.Size = new System.Drawing.Size(140, 20);
            this.ctbSalary.TabIndex = 12;
            this.ctbSalary.Value = new decimal(new int[] {
            0,
            0,
            0,
            65536});
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 256);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 23);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 298);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctbSalary);
            this.Controls.Add(this.chbIsHired);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbDismissalDate);
            this.Controls.Add(this.dtpDismissalDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHireDate);
            this.Name = "AddEditEmployeeForm";
            this.Text = "Edycja danych pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDismissalDate;
        private System.Windows.Forms.DateTimePicker dtpDismissalDate;
        private System.Windows.Forms.CheckBox chbIsHired;
        private EmployeesControls.CurrencyTextBox ctbSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}