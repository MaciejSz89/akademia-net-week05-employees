namespace Employees
{
    partial class DismissEmployeeForm
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
            this.lbDismissalDate = new System.Windows.Forms.Label();
            this.dtpDismissalDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDismissalDate
            // 
            this.lbDismissalDate.AutoSize = true;
            this.lbDismissalDate.Location = new System.Drawing.Point(8, 16);
            this.lbDismissalDate.Name = "lbDismissalDate";
            this.lbDismissalDate.Size = new System.Drawing.Size(85, 13);
            this.lbDismissalDate.TabIndex = 15;
            this.lbDismissalDate.Text = "Data zwolnienia:";
            // 
            // dtpDismissalDate
            // 
            this.dtpDismissalDate.CustomFormat = "ddMMMMyyyy";
            this.dtpDismissalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDismissalDate.Location = new System.Drawing.Point(126, 12);
            this.dtpDismissalDate.Name = "dtpDismissalDate";
            this.dtpDismissalDate.Size = new System.Drawing.Size(140, 20);
            this.dtpDismissalDate.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(157, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(16, 48);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 23);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // DismissEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 85);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbDismissalDate);
            this.Controls.Add(this.dtpDismissalDate);
            this.Name = "DismissEmployeeForm";
            this.Text = "Zwolnienie pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDismissalDate;
        private System.Windows.Forms.DateTimePicker dtpDismissalDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}