using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class DismissEmployeeForm : Form
    {

        private ICollection<Employee> Employees { get; set; }
        private Employee Employee { get; set; }

        public DismissEmployeeForm(ICollection<Employee> employees, Employee employee)
        {
            InitializeComponent();
            Employees = employees;
            Employee = employee;
            InitializeControls();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UpdateEmployeeData();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeControls()
        {
            Employee.IsHired = false;   
            dtpDismissalDate.Value = Employee.DismissalDate != null ? (DateTime)Employee.DismissalDate : new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void UpdateEmployeeData()
        {
            Employee.DismissalDate = !Employee.IsHired ? (DateTime?)dtpDismissalDate.Value : null;
        }
    }
}
