namespace EmployeesControls
{
    partial class CurrencyTextBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tbInternalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _tbInternalTextBox
            // 
            this._tbInternalTextBox.Location = new System.Drawing.Point(0, 0);
            this._tbInternalTextBox.Name = "_tbInternalTextBox";
            this._tbInternalTextBox.Size = new System.Drawing.Size(100, 20);
            this._tbInternalTextBox.TabIndex = 0;
            this._tbInternalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._tbInternalTextBox.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // CurrencyTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tbInternalTextBox);
            this.Name = "CurrencyTextBox";
            this.Size = new System.Drawing.Size(100, 20);
            this.SizeChanged += new System.EventHandler(this.CurrencyTextBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbInternalTextBox;
    }
}
