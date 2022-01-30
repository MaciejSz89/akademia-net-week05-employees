using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Employees
{
    public partial class MainForm : Form
    {
        private ICollection<Employee> _employees;
        private ISerializer<ICollection<Employee>> _serializer;
        private readonly string _filePath = Path.Combine($@"{Environment.CurrentDirectory}", "employees.json");
        private AddEditEmployeeForm _addEditEmployeeForm;
        private DismissEmployeeForm _dismissEmployeeForm;


        public MainForm()
        {
            InitializeComponent();
            _serializer = new Serializer<ICollection<Employee>>(_filePath);
            _employees = _serializer.Deserialize() ?? new List<Employee>();
            cmbFilter.SelectedIndex = 0;
            RefreshTable();

        }
        public void HireEmployee()
        {
            _addEditEmployeeForm = new AddEditEmployeeForm(_employees);
            _addEditEmployeeForm.FormClosed += ChildForm_FormClosed;
            _addEditEmployeeForm.ShowDialog();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveDataToFile();
            RefreshTable();
        }

        public void EditEmployee(int id)
        {
            _addEditEmployeeForm = new AddEditEmployeeForm(_employees, _employees.Where(x => x.Id == id).FirstOrDefault());
            _addEditEmployeeForm.FormClosed += ChildForm_FormClosed;
            _addEditEmployeeForm.ShowDialog();
        }

        public void DismissEmployee(int id)
        {
            Employee employee = _employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee.IsHired)
            {
                _dismissEmployeeForm = new DismissEmployeeForm(_employees, employee);
                _dismissEmployeeForm.FormClosed += ChildForm_FormClosed;
                _dismissEmployeeForm.ShowDialog();
            }
            else
                MessageBox.Show("Pracownik jest już zwolniony", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _addEditEmployeeForm = new AddEditEmployeeForm(_employees, _employees.Where(x => x.Id == id).FirstOrDefault());

        }

        private void hireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HireEmployee();
        }

        private void cmsHireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HireEmployee();
        }

        private void cmsEditEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 0)
                EditEmployee(Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["Id"].Value));
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 0)
                EditEmployee(Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["Id"].Value));
        }

        private void dismissEmployeeStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 0)
                DismissEmployee(Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["Id"].Value));
        }

        private void cmsDismissEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 0)
                DismissEmployee(Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells["Id"].Value));
        }



        private void RefreshTable()
        {
            dgvEmployees.DataSource = null;
            var notFilteredDataSource = _employees.Select(x => new { Id = x.Id, FirstName = x.FirstName, LastName = x.LastName, Salary = x.Salary.ToString("C", CultureInfo.CreateSpecificCulture(Program.CultureName)), Comments = x.Comments, HireDate = x.HireDate.ToShortDateString(), IsHired = x.IsHired, DismissalDate = !x.IsHired ? x.DismissalDate.Value.ToShortDateString() : "" }).ToList();

            switch (cmbFilter.SelectedIndex)
            {
                case 1:
                    dgvEmployees.DataSource = notFilteredDataSource.Where(x => x.IsHired).ToList();
                    break;
                case 2:
                    dgvEmployees.DataSource = notFilteredDataSource.Where(x => !x.IsHired).ToList();
                    break;
                case 0:
                default:
                    dgvEmployees.DataSource = notFilteredDataSource;
                    break;
            }


            SetTableHeaders();

        }
        private void SaveDataToFile()
        {
            _serializer.Serialize(_employees);
        }

        private void SetTableHeaders()
        {
            dgvEmployees.Columns["Id"].HeaderText = "Numer";
            dgvEmployees.Columns["FirstName"].HeaderText = "Imię";
            dgvEmployees.Columns["LastName"].HeaderText = "Nazwisko";
            dgvEmployees.Columns["Salary"].HeaderText = "Pensja";
            dgvEmployees.Columns["Comments"].HeaderText = "Uwagi";
            dgvEmployees.Columns["HireDate"].HeaderText = "Data zatrudnienia";
            dgvEmployees.Columns["IsHired"].HeaderText = "Zatrudniony";
            dgvEmployees.Columns["DismissalDate"].HeaderText = "Data zwolnienia";
        }


        private void dgvEmployees_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsEmployees.Show(dgvEmployees.PointToScreen(e.Location));
        }


        private void cmbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
