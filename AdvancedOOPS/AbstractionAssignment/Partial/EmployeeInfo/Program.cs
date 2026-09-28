using System;

namespace EmployeeInfo;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeDetails emp = new(12233,"Edward","male","19/11/2002","7305541054");
        System.Console.WriteLine(emp.Mobile);
        emp.MobileUpdate("7412369845");
        System.Console.WriteLine(emp.Mobile);
        
    }
}
