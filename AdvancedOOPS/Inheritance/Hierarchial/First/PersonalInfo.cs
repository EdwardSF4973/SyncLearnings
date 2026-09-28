using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class PersonalInfo
    {
        private static int s_userID = 100;
        public int UserID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string MailID { get; set; }

        public PersonalInfo(){}

        public PersonalInfo(string name,string fatherName,DateTime dob,string phoneNumber,string gender, string mailID)
        {
            UserID = ++s_userID;
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            PhoneNumber = phoneNumber;
            Gender = gender;
            MailID = mailID;
        }
        public PersonalInfo(int userID,string name,string fatherName,DateTime dob,string phoneNumber,string gender, string mailID)
        {
            UserID = userID;
            Name = name;
            FatherName = fatherName;
            DOB = dob;
            PhoneNumber = phoneNumber;
            Gender = gender;
            MailID = mailID;
        }
        public string DisplayPersonal()
        {
            return $"UserID : {UserID}, Name : {Name}, FatherName : {FatherName}, DateOfBirth : {DOB}, Phone : {PhoneNumber}, Gender : {Gender}, Mail : {MailID}";
        }
    }
}
/*
1.	Create an application for a College Administration, create two objects for teacher, student and principal and show their info.

Class PersonalInfo:
Properties: UserID, Name, FatherName, DOB, Phone, Gender, Mail

Class Teacher Inherit PersonalInfo
Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining

Class StudentInfo inherit PersonalInfo
Properties: StudentID, Degree, Department, semester 

Class PrincipalInfo inherit PersonalInfo
Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining

Requirement: Need to create 2 objects each for the above classes (ID’s are auto incremented) and must display the details in Program.cs


*/