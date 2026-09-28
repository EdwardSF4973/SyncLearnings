using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fourth
{
    public class SalaryInfo
    {
        public int SalaryID { get; set; }

        public int SalaryOfTheMonth { get; set; }

        public int Month { get; set; }

        
        
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