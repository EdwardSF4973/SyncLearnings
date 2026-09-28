using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_registrationID = 0;
       public string RegistrationID { get; set; } 

       public string Standard { get; set; }

       public string Branch { get; set; }

       public int AcadamicYear { get; set; }

        public StudentInfo(){}

        public StudentInfo(string standard, string branch, int acadamicYear,string userID,string name, string fatherName ,string phoneNumber, string mailID,DateTime dob,string gender) : base(userID,name,fatherName,phoneNumber,mailID,dob,gender)
        {
            RegistrationID = $"RID{++s_registrationID}";
            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;
        }

        public string DisplayStudent()
        {
            return $"RegistartionID : {RegistrationID}, {DisplayPersonalInfo()}, Standard: {Standard}, Branch: {Branch}, AcadamicYear: {AcadamicYear}";
        }


    }
}

/*
1.	Program for getting and showing student details:  
Class PersonalInfo:
Properties: Name, UserID, FatherName, Phone ,Mail, DOB, Gender
Constructor to assign values

Class StudentInfo: inherits PersonalInfo
Propeties: RegistrationID, Standard, Branch, AcadamicYear
	
	Requirement: Need to create inherited class (ID’s are auto incremented) and have to create two objects for the each above two classes and have to display the details in Program.cs

*/