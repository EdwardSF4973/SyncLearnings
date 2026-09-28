using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second
{
    public class TempEmployees : SalaryInfo
    {
        private static int s_employyeID = 4500;

        public int EmployeeID { get; set; }

        public EmployeeType Type { get; set; }

        public double DA { get; set; }

        public double Basic { get; set; }

        public double HRA { get; set; }

        public double PF { get; set; }

        public double TotalSalary { get{return Total();} }

        public TempEmployees() { }

        public TempEmployees(EmployeeType type, int salaryID, double basicSalary, int month) : base(salaryID, basicSalary, month)
        {
            Type = type;
            Basic = basicSalary;
            HRA = Basic * 0.13;
            DA = Basic * 0.15;
            PF = 0;
        }
        
        public double Total()
        {
            return Basic + DA + HRA - PF;
            
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
