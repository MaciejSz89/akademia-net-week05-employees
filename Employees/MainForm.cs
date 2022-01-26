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

namespace Employees
{
    public partial class MainForm : Form
    {
        private ICollection<Employee> _employees;
        private ISerializer<ICollection<Employee>> _serializer;
        private readonly string _filePath = Path.Combine($@"{Environment.CurrentDirectory}", "employers.json");
        
        public MainForm()
        {
            InitializeComponent();
            _serializer = new Serializer<ICollection<Employee>>(_filePath);
            _employees = new List<Employee>();
            _employees.Add(new Employee { Id=1, FirstName = "Adam" });
            _serializer.Serialize(_employees);
     //       _employees = _serializer.Deserialize() ?? new List<Employee>();
        }
        public void HireEmployee(Employee employer)
        { 

        }

        public void DismissEmployee(int Id)
        {

        }

        public void EditEmployee()
        {

        }


    }
}
