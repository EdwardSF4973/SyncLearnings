using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second
{
    public class SalaryInfo
    {
        private static int s_salaryID = 0;

        public int SalaryID { get; set; }

        public double BasicSalary { get; set; }

        public int Month { get; set; }

        public SalaryInfo(){}

        public SalaryInfo(double basicSalary,int month)
        {
            SalaryID = ++s_salaryID;
            BasicSalary = basicSalary;
            Month = month;
        }

        public SalaryInfo(int salaryID,double basicSalary,int month)
        {
            SalaryID = salaryID;
            BasicSalary = basicSalary;
            Month = month;
        }
    }
}
/*
2.	Create a employee Salary calculation method.  Create two temporary and two permanent employees, calculate their salary and show their salary.

Class SalaryInfo
Properties: SalaryID, BasicSalary, Month

Class PermanentEmployee: inherit SalaryInfo
Properties: EmployeeID, EmployeeType (Enum), DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary
Method: CalculateTotalSalary – Basic +DA+HRA-PF

Class TemporaryEmployee: inherit SalaryInfo
Properties: EmployeeID, EmployeeType (Enum), DA=0.15% of basic, HRA= 0.13% of basic, Total Salary
Method: CalculateTotalSalary – Basic +DA+HRA-PF

Requirement: Need to create 2 objects each for the above classes (ID’s are auto incremented) and must display the details in Program.cs

*/