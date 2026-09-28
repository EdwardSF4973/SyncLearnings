using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Third
{
    public class Attendance
    {
        public string Date { get; set; }

        public int NumberOfHoursWorked { get; set; }

        public Attendance() { }

        public Attendance(string date, int noh)
        {
            Date = date;
            NumberOfHoursWorked = noh;
        }
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