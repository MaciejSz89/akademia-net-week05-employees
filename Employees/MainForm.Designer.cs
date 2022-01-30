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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.cmsEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsHireEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDismissEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
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
            this.hireEmployeeToolStripMenuItem.Click += new System.EventHandler(this.hireEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edycja danych pracownika";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
            // 
            // dismissEmployeeStripMenuItem1
            // 
            this.dismissEmployeeStripMenuItem1.Name = "dismissEmployeeStripMenuItem1";
            this.dismissEmployeeStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.dismissEmployeeStripMenuItem1.Text = "Zwolnienie pracownika";
            this.dismissEmployeeStripMenuItem1.Click += new System.EventHandler(this.dismissEmployeeStripMenuItem1_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 54);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(899, 428);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvEmployees_MouseUp);
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
            this.cmsHireEmployeeToolStripMenuItem.Click += new System.EventHandler(this.cmsHireEmployeeToolStripMenuItem_Click);
            // 
            // cmsEditEmployeeToolStripMenuItem
            // 
            this.cmsEditEmployeeToolStripMenuItem.Name = "cmsEditEmployeeToolStripMenuItem";
            this.cmsEditEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cmsEditEmployeeToolStripMenuItem.Text = "Edycja danych pracownika";
            this.cmsEditEmployeeToolStripMenuItem.Click += new System.EventHandler(this.cmsEditEmployeeToolStripMenuItem_Click);
            // 
            // cmsDismissEmployeeToolStripMenuItem
            // 
            this.cmsDismissEmployeeToolStripMenuItem.Name = "cmsDismissEmployeeToolStripMenuItem";
            this.cmsDismissEmployeeToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cmsDismissEmployeeToolStripMenuItem.Text = "Zwolnienie pracownika";
            this.cmsDismissEmployeeToolStripMenuItem.Click += new System.EventHandler(this.cmsDismissEmployeeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtr:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Wszyscy",
            "Zatrudnieni",
            "Zwolnieni"});
            this.cmbFilter.Location = new System.Drawing.Point(57, 27);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 3;
            this.cmbFilter.SelectedValueChanged += new System.EventHandler(this.cmbFilter_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 494);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(668, 147);
            this.Name = "MainForm";
            this.Text = "Pracownicy";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.cmsEmployees.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ContextMenuStrip cmsEmployees;
        private System.Windows.Forms.ToolStripMenuItem cmsHireEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsEditEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsDismissEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dismissEmployeeStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}

