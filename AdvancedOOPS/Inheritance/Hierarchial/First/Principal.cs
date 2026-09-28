using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class Principal : PersonalInfo
    {
        private static int s_principalID = 2000;

        public int PrincipalID { get; set; }

        public string Qualification { get; set; }

        public int YearOfExperience { get; set; }

        public DateTime DateOFJoining { get; set; }

        public Principal(){}

        public Principal(int userID,string qualification,int yoe,DateTime doj,string name,string fatherName,DateTime dob,string phoneNumber,string gender, string mailID):base(userID,name,fatherName,dob,phoneNumber,gender,mailID)
        {
            PrincipalID = ++s_principalID;
            Qualification = qualification;
            YearOfExperience = yoe;
            DateOFJoining = doj;
        }

        public string DisplayPrincipal()
        {
            return $"PrincipalID : {PrincipalID}, {DisplayPersonal()}, Qualification : {Qualification}, YearsOf Experience : {YearOfExperience}, DateOfJoining : {DateOFJoining}";
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