using System;

namespace Employee;

class Program
{
    public static void Main(string[] args)
    {
        PersonDetails person = new ("Edward","George","Male","BE CSE");


        FreeLancer free = new("PID1002","Subin","Mano","Male","BE MECH","Scietist",23);
        System.Console.WriteLine(free.SalaryAmount);
        free.CalculateSalary();
        System.Console.WriteLine();

        SyncFusion sync1 = new ("PID10050","Unni","Krishnan","Male","BE MECH","Student",19,"Chennai");
        System.Console.WriteLine(sync1.SalaryAmount);
        sync1.CalculateSalary();
    }
}
/*
2.	Create application for a employee salary calculation,

Class PersonDetails
Property: Name, FatherName,Gender,Qualification

Class FreeLancer inherits PersonDetails
Property: ProfileID, Role, SalaryAmount, NoOfWorkingDays
Method : Virtual CalculateSalary method that calculate salary by NoOfWorkingDays*500 

Class Syncfusion inherits FreeLancer
Field : EmployeeID
Property: EmployeeID, Worklocation
Method: Overridden CalculateSalary method that calculate salary by NoOfWorkingDays*500 

Requirement : Create objects for the personal details, freelancer, Syncfusion classes, assign values and using calculate method calculate salary of employee and display the details in each object.


*/