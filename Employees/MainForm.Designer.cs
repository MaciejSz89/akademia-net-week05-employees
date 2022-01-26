namespace Employees
{
    partial class MainForm
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dismissEmployeeStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDismissEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(923, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hireEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem,
            this.dismissEmployeeStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // hireEmployeeToolStripMenuItem
            // 
            this.hireEmployeeToolStripMenuItem.Name = "hireEmployeeToolStripMenuItem";
            this.hireEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.hireEmployeeToolStripMenuItem.Text = "Zatrudnienie nowego pracownika";
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edycja danych pracownika";
            // 
            // dismissEmployeeStripMenuItem1
            // 
            this.dismissEmployeeStripMenuItem1.Name = "dismissEmployeeStripMenuItem1";
            this.dismissEmployeeStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.dismissEmployeeStripMenuItem1.Text = "Zwolnienie pracownika";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(899, 455);
            this.dataGridView1.TabIndex = 1;
            // 
            // cmsEmployees
            // 
            this.cmsEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsHireEmployeeToolStripMenuItem,
            this.cmsEditEmployeeToolStripMenuItem,
            this.cmsDismissEmployeeToolStripMenuItem});
            this.cmsEmployees.Name = "cmsEmployers";
            this.cmsEmployees.Size = new System.Drawing.Size(252, 70);
            // 
            // cmsHireEmployeeToolStripMenuItem
            // 
            this.cmsHireEmployeeToolStripMenuItem.Name = "cmsHireEmployeeToolStripMenuItem";
            this.cmsHireEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cmsHireEmployeeToolStripMenuItem.Text = "Zatrudnienie nowego pracownika";
            // 
            // cmsEditEmployeeToolStripMenuItem
            // 
            this.cmsEditEmployeeToolStripMenuItem.Name = "cmsEditEmployeeToolStripMenuItem";
            this.cmsEditEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cmsEditEmployeeToolStripMenuItem.Text = "Edycja danych pracownika";
            // 
            // cmsDismissEmployeeToolStripMenuItem
            // 
            this.cmsDismissEmployeeToolStripMenuItem.Name = "cmsDismissEmployeeToolStripMenuItem";
            this.cmsDismissEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cmsDismissEmployeeToolStripMenuItem.Text = "Zwolnienie pracownika";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(668, 147);
            this.Name = "MainForm";
            this.Text = "Pracownicy";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsEmployees.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip cmsEmployees;
        private System.Windows.Forms.ToolStripMenuItem cmsHireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsEditEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsDismissEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dismissEmployeeStripMenuItem1;
    }
}

