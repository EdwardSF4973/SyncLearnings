using System;
using System.Collections.Generic;

namespace Third;

class Program
{
    public static void Main(string[] args)
    {
        
        EmployeeInfo emp = new("CSE",5,123,50000,5,852,"Edward","George","Male","75245214",new DateTime(2002,11,19));

        Attendance attendance=new ("new DateTime(2025,01,27)",8);
        Attendance attendance1=new ("new DateTime(2025,01,28)",7);
        Attendance attendance2=new ("new DateTime(2025,01,30)",9);
        Attendance attendance3=new ("new DateTime(2025,01,31)",8);
        Attendance attendance4=new ("new DateTime(2025,02,04)",10);

        emp.attendances.AddRange(new List<Attendance>(){attendance,attendance1,attendance2,attendance3,attendance4});

        double tottal = 0;
        foreach(Attendance record in emp.attendances)
        {
            tottal+=record.NumberOfHoursWorked;
        }
        System.Console.WriteLine(emp.CalculateSalary(tottal));
    }
}
/*   
3.	Create application for Employee Portal create two employee details object, log attendance, calculate salary of given month 300 / day. Show details, display details.


Class PersonalInfo:
Properties: UserID, Name,FatherName,Gender,Mobile,DOB

Class Attendance:
Properties: Date, NumberOfHoursWorked.

Class SalaryInfo inherits PersonalInfo
Properties: SalaryID, SalaryOfTheMonth, Month,  List<Attendance>, 
Method: Log Attendance, Calculate Salary-> for given month  

Class EmployeeInfo: Inherits SalaryInfo
Properties: EmployeeID, Branch, floor.

 Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details. Use LogAttendance for adding attendance and calculate salary method for calculating salary and display the salary.

*/