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
            IsHired = true;
            HireDate = hireDate;
        }
        public void Dismiss(DateTime dismmissalDate)
        {
            this.DismissalDate = dismmissalDate;
            IsHired = false;
        }
        private DateTime _hireDate;
        private DateTime? _dismissalDate;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate 
        { 
            get 
            { 
                return _hireDate; 
            } 
            set 
            {
                if ((!IsHired && (new DateTime(value.Year, value.Month, value.Day) > new DateTime(_dismissalDate.Value.Year, _dismissalDate.Value.Month, _dismissalDate.Value.Day)))||IsHired)
                    _hireDate = value;
                
            } 
        }
        public DateTime? DismissalDate
        {
            get
            {
                return _dismissalDate;
            }
            set
            {
                if (!IsHired && (new DateTime(value.Value.Year, value.Value.Month, value.Value.Day) > new DateTime(_hireDate.Year, _hireDate.Month, _hireDate.Day))) 
                    _dismissalDate = value;
                else
                    _dismissalDate = _hireDate;
            }
        }
        public string Comments { get; set; }
        public bool IsHired { get; set; }


    }
}
