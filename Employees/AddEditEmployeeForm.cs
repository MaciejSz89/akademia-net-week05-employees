using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class AddEditEmployeeForm : Form
    {

        public AddEditEmployeeForm(ICollection<Employee> employees)
        {
            InitializeComponent();
            Text = "Zatrudnienie nowego pracownika";
            _addingNewEmployee = true;
            Employees = employees;
            var newEmployeeId = Employees.Count > 0 ? Employees.Select(x => x.Id).Max() + 1 : 1;
            Employee = new Employee(newEmployeeId, "", "", 0.0M, DateTime.Now);
            InitializeControls();
        }



        public AddEditEmployeeForm(ICollection<Employee> employees, Employee employee)
        {
            InitializeComponent();
            _addingNewEmployee = false;
            Employees = employees;
            Employee = employee;
            InitializeControls();
        }

        private bool _addingNewEmployee;


        private ICollection<Employee> Employees { get; set; }
        private Employee Employee { get; set; }
        
        private void InitializeControls()
        {
            tbId.Text = Employee.Id.ToString();
            tbFirstName.Text = Employee.FirstName;
            tbLastName.Text = Employee.LastName;
            dtpHireDate.Value = Employee.HireDate;
            ctbSalary.Value = Employee.Salary;
            ctbSalary.CultureName = Program.CultureName;
            tbComments.Text = Employee.Comments;
            chbIsHired.Checked = Employee.IsHired;
            chbIsHired.Enabled = Employee.IsHired;
            dtpDismissalDate.Value = Employee.DismissalDate != null ? (DateTime)Employee.DismissalDate : new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            

        }
        private void UpdateEmployeeData()
        {
            Employee.FirstName = tbFirstName.Text;
            Employee.LastName = tbLastName.Text;
            Employee.HireDate = dtpHireDate.Value;
            Employee.Salary = ctbSalary.Value;
            Employee.Comments = tbComments.Text;
            Employee.IsHired = chbIsHired.Checked;
            Employee.DismissalDate = !Employee.IsHired ? (DateTime?)dtpDismissalDate.Value : null;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UpdateEmployeeData();
            try
            {
                if (_addingNewEmployee)
                    Employees.Add(Employee);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbIsHired_CheckedChanged(object sender, EventArgs e)
        {
            dtpDismissalDate.Visible = !chbIsHired.Checked;
            lbDismissalDate.Visible = !chbIsHired.Checked;
            chbIsHired.Enabled = chbIsHired.Checked;
        }



    }
}
