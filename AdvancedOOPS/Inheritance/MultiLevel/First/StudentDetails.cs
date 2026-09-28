using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class StudentDetails : PersonalInfo
    {
        public static int s_registrationID = 0;

        public int RegistrationID { get; set; }

        public string Standard { get; set; }

        public string Branch { get; set; }

        public int AcadamicYear { get; set; }

        public StudentDetails(){}

        public StudentDetails(int userID,string standard,string branch, int acadamicYear, string name, string fatherName, string mobileNumber, string mailID, DateTime dob, string gender):base(userID,name,fatherName,mobileNumber,mailID,dob,gender)
        {
            RegistrationID = ++s_registrationID;
            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;
        }
        public StudentDetails(int registrationID,int userID,string standard,string branch, int acadamicYear, string name, string fatherName, string mobileNumber, string mailID, DateTime dob, string gender):base(userID,name,fatherName,mobileNumber,mailID,dob,gender)
        {
            RegistrationID = registrationID;
            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;    
        }

        public string DispalyStudent()
        {
            return $"RegistrationID : {RegistrationID}, {DisplayPersonalInfo()} ,Standard : {Standard}. Branch : {Branch}, AcadamicYear : {AcadamicYear} ";
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