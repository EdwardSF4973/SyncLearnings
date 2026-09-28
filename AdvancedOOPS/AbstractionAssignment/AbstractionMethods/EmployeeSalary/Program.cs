using System;
using EmployeeSalary;

namespace EmployeesSalary;

class Program
{
    public static void Main(string[] args)
    {
        FullTime emp1 = new(455,"Edward","Male",5);
        emp1.DisplaySalary();
        emp1.UpdateInfo("Daya");
        System.Console.WriteLine(emp1.EmployeeName);

        PartTime emp2 = new(556,"Subin","Male",4);
        emp2.DisplaySalary();
        emp2.UpdateInfo("Edward");
        System.Console.WriteLine(emp2.EmployeeName);
    }
}
