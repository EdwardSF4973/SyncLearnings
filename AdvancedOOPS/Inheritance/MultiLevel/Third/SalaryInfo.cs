using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Third
{
    public class SalaryInfo :PersonalInfo
    {
        private static int s_salaryID = 10000;

        public int SalaryID { get; set; }

        public double SalaryOfTheMonth { get; set; }
        public int Month { get; set; }

        public SalaryInfo(){}

        public SalaryInfo(double salaryOfTheMonth,int month,int userID,string name, string fatherName, string gender, string mobileNumber , DateTime dob) : base(userID,name,fatherName,gender,mobileNumber,dob)
        {
            SalaryID = ++s_salaryID;
            SalaryOfTheMonth = salaryOfTheMonth;
            Month = month;

        }

         public SalaryInfo(int salaryID,double salaryOfTheMonth,int month,int userID,string name, string fatherName, string gender, string mobileNumber , DateTime dob) : base(userID,name,fatherName,gender,mobileNumber,dob)
        {
            SalaryID = salaryID;
            SalaryOfTheMonth = salaryOfTheMonth;
            Month = month;

        }
        public List<Attendance>  attendances = new List<Attendance>();
        
        public double CalculateSalary(double how)
        {
            double sa =(double) how/8;
            return sa*500;
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