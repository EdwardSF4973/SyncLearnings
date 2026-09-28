using System;

namespace Students;

class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student1 = new(852,"Edward","George","7305541054");
        System.Console.WriteLine(student1.Display());
        student1.Update("098765432345");
        System.Console.WriteLine(student1.Display());

        EmployeeInfo emp = new(798465,"rfsdf","ergqer","4651452");
        System.Console.WriteLine(emp.Display());
        emp.Update("846531");
        System.Console.WriteLine(emp.Display());
    
    }
}

