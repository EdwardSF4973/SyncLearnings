using System;
using System.Collections.Generic;

namespace Fourth;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo emp1 = new(123,"Edward","George","male","745636521","19/11/2002","Chennai");

        Attendance entry1 = new("03/02/2025",9);
        Attendance entry2 = new("04/02/2025",10);
        Attendance entry3 = new("05/02/2025",11);
        Attendance entry4 = new("06/02/2025",9);
        Attendance entry5 = new("07/02/2025",8);

        emp1.attendances.AddRange(new List<Attendance>(){entry1,entry2,entry3,entry4,entry5});
        double totalHours = 0;
        foreach(Attendance record in emp1.attendances)
        {
            totalHours+=record.NumberOfHoursWorked;
        }
        System.Console.WriteLine(emp1.Salary(totalHours));
    }
}
/*
4.	Program to manipulate employee worklog details:
Class Attendance:
Properties: DayID, Date, NumberOfHoursWorked.

Class SalaryInfo  
Properties: SalaryID, SalaryOfTheMonth, Month
Method: CalculateSalary-> for given month  

Class EmployeeInfo: Inherits SalaryInfo
Properties: EmployeeID, Name,FatherName,Gender,Mobile,DOB, Branch, List<Attendance>,
Method: LogAttendance - > Add the attendance details objects in List<Attendance>, CalculateSalary.

Requirement : Need to create inherited class and have to create objects (ID’s are auto incremented) for the each above SalaryInfo, EmployeeInfo classes
Create 5 attendance details objects and have to add the objects to the EmployeeInfo List<Attendance> with LogAttendance method and have to display the details and have to calculate salary CalculateSalary method with attendance details and have to calculate based on 500 per 8hr using attendance for the given user in Program.cs

*/