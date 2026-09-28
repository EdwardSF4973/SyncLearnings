using System;

namespace SalaryCalculation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Attendance month1 = new(30,5,3);
            Attendance month2 = new(31,6,5);

            Attendance two = month1+month2;
            Attendance month3 = new(31,4,2);
            Attendance result = two + month3;

            System.Console.WriteLine(result.Display());

            System.Console.WriteLine(result.calculate());

        }
    }
}
/*
1.	Salary Calculation application
a.	Create a class named Attendance
b.	 Properties: TotalWorkingDaysInMonth, NumberOfLeavesTaken, NumberOfPermissionsTaken.
c.	Method : CalculateSalary
d.	Create objects month1, month 2, month3
e.	Calculate the three months total working days, number of leaves taken, and number of permissions taken using operator overloading method
f.	calculate the total salary by number of days worked * 500 Rs.  


*/