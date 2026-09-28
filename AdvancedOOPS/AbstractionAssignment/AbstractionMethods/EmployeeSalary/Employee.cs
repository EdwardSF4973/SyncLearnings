using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public abstract class Employee
    {
        public int EmployeeID { get; set; }

        public abstract string EmployeeName { get; set; }

        public string Gender { get; set; }

        public int NumberOfDaysWorked { get; set; }

        public Employee(int employeeID,string gender,int now)
        {
            EmployeeID=employeeID;
            
            Gender=gender;
            NumberOfDaysWorked=now;

        }

        public abstract void UpdateInfo(string a);

        public abstract void DisplaySalary();
    }
}