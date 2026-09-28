using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class PersonalInfo
    {
        private static int s_userID = 1000;
        public int UserID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string MobileNumber { get; set; }

        public string MailID { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public PersonalInfo(){}

        public PersonalInfo(string name, string fatherName, string mobileNumber, string mailID, DateTime dob, string gender)
        {
            UserID = ++s_userID;
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            MailID = mailID;
            DOB = dob;
            Gender = gender;
        }
        public PersonalInfo(int userID, string name, string fatherName, string mobileNumber, string mailID, DateTime dob, string gender)
        {
            UserID = userID;
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            MailID = mailID;
            DOB = dob;
            Gender = gender;
        }
        public string DisplayPersonalInfo()
        {
            return $"UserID: {UserID}, Name: {Name}, FatherName: {FatherName}, MobileNumber: {MobileNumber}, MailID: {MailID}, Date Of Birth: {DOB}, Gender: {Gender}";
        }
        
    }
}
/*
1.	Program for getting showing student details:

Class PersonalInfo:
Properties: UserID, Name, FatherName,Phone,Mail, dob,Gender
Constructor to assign values

Class StudentInfo: inherits PersonalInfo
Propeties: RegistrationID, Standard, Branch, AcadamicYear


Class HSCDetails: Inherits StudentInfo
Properties: HSCMarksheetID, Physics, Chemistry, Maths, Total, Percentage marks
Methods:  Calculate – Total and percentage.
Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details and have to calculate total and percentage and have to display the details.

*/