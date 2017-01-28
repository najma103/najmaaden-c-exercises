using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.annualSalary = salary;

        }
        public int employeeId;
        public string firstName;
        public string lastName;
        public string department;
        public double annualSalary;

        public string FullName
        {
            get { return lastName + ", " + firstName; }
        }
        public int EmployeeId
        {
            get { return employeeId; }
        }
        public string FirstName
        {
            get { return firstName; }
            
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double AnnualSalary
        {
            get { return annualSalary; }
        }

        public void RaiseSalary(double percent)
        {
            annualSalary += (annualSalary * (percent / 100));
        }
    }
}
