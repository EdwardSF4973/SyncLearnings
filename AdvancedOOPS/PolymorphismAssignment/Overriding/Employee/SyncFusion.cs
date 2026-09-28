using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace Employee
{
    public class SyncFusion:FreeLancer
    {
        private static int s_employeeId = 1000;
        public string EmployeeID { get; set; }

        public string WorkLocation { get; set; }

        public SyncFusion(string pID,string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays,string worklocation):base(pID,name,fatherName,gender,qualification,role,noOfWorkingDays)
        {
            EmployeeID = $"EID{++s_employeeId}";
            WorkLocation = worklocation;
        }

        public override void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
            System.Console.WriteLine($"Your Salary as Employee {SalaryAmount}");
        }

    }
}