using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class PartTime:Employee
    {
        public override string EmployeeName { get; set ; }
        public PartTime(int employeeID,string name,string gender,int now):base(employeeID,gender,now)
        {
            EmployeeName=name;
        }

        public override void UpdateInfo(string a)
        {
            EmployeeName=a;
        }

        public override void DisplaySalary()
        {
            System.Console.WriteLine("Salary : "+NumberOfDaysWorked*400);
        }
    }
}