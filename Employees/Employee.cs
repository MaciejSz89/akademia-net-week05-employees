using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public Employee(int id, string firstName, string lastName, decimal salary, DateTime hireDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            HireDate = hireDate;
            IsHired = true;
        }
        public void Dismiss(DateTime dismmissalDate)
        {
            this.DismissalDate = dismmissalDate;
            IsHired = false;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public string Comments { get; set; }
        public bool IsHired { get; set; }

        public bool IsDataValid()
        {

            if (!this.IsHired && new DateTime(this.DismissalDate.Value.Year, this.DismissalDate.Value.Month, this.DismissalDate.Value.Day) < new DateTime(this.HireDate.Year, this.HireDate.Month, this.HireDate.Day))
            {
                throw new Exception("Błąd! Data zatrudnienia jest późniejsza niż data zwolnienia");
            }

            if (this.FirstName == "" || this.LastName == "")
            {
                throw new Exception("Błąd. Imię i Nazwisko nie mogą być puste")
            }
            return true;
        }

    }
}
