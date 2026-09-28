using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace First
{
    public class PersonalInfo
    {
        private static int s_userID = 1000;
        public string Name { get; set; }

        public string FatherName { get; set; }

        public string UserID { get; set; }

        public string PhoneNumber { get; set; }

        public string MailID { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public PersonalInfo(){

        }
        public PersonalInfo(string name,string fatherName,string phoneNumber, string mailID,DateTime dob,string gender)
        {
            UserID = $"UID{++s_userID}";
            Name = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            DOB = dob;
            Gender = gender;
        }

        public PersonalInfo(string userID,string name,string fatherName,string phoneNumber, string mailID,DateTime dob,string gender)
        {
            UserID = userID;
            Name = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            DOB = dob;
            Gender = gender;
        }

        public string DisplayPersonalInfo()
        {
            return $"UserID : {UserID}, Name: {Name}, FatheName: {FatherName}, PhoneNumber: {PhoneNumber}, MailID: {MailID}, DOB: {DOB}, Gender: {Gender} ";
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
	
	Requirement: Need to create inherited class (ID’s are auto incremented) 
    and have to create two objects for the each above two classes and have 
    to display the details in Program.cs

*/