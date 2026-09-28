using System;

namespace Second;

class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee pemp1 = new(EmployeeType.PermanentEmployee,321,5000,5);
        System.Console.WriteLine(pemp1.TotalSalary);
        System.Console.WriteLine(pemp1.HRA);
        System.Console.WriteLine(pemp1.DA);

        TempEmployees temp1 = new(EmployeeType.TemporaryEmployee,852,10000,5);
        System.Console.WriteLine(temp1.TotalSalary);
        System.Console.WriteLine(temp1.HRA);
        System.Console.WriteLine(temp1.DA);

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