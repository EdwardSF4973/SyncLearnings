using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Third
{
    public class PersonalInfo
    {
        private static int s_userID = 100;
        public int UserID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Gender { get; set; }

        public string MobileNumber { get; set; }

        public DateTime DOB { get; set; }

        public PersonalInfo(){}

        public PersonalInfo(string name, string fatherName, string gender, string mobileNumber , DateTime dob)
        {
            UserID = ++s_userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            MobileNumber = mobileNumber;
            DOB = dob;
        }

        public PersonalInfo(int userID,string name, string fatherName, string gender, string mobileNumber , DateTime dob)
        {
            UserID = userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            MobileNumber = mobileNumber;
            DOB = dob;
        }

        public string DisplayPersonal()
        {
            return $"UserID : {UserID}, Name : {Name}, FatherName : {FatherName}, Gender : {Gender}, MobileNumber : {MobileNumber}, Date of Birth : {DOB}";
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