using System;

namespace Employee;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo emp = new("edward","george","7458","male","kilpauk");
        emp.Display();
        emp.Update("anna nagar");
        emp.Display();


        SalaryInfo emp2 = new ("5445","chichu","george","75854","male","mathura",50);
        System.Console.WriteLine(emp2.CalculatedSalary());
        System.Console.WriteLine(emp2.OfficeLocation);
        emp2.Update("kenya");
        System.Console.WriteLine(emp2.OfficeLocation);
    }
}
