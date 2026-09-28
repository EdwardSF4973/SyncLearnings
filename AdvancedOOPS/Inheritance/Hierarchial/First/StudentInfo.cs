using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID = 900;

        public int StudentID { get; set; }

        public string Degree { get; set; }

        public string Department { get; set; }

        public int Semester { get; set; }

        public StudentInfo(){}

        public StudentInfo(int userID,string degree, string department, int semester, string name,string fatherName,DateTime dob,string phoneNumber,string gender, string mailID) : base(userID,name,fatherName,dob,phoneNumber,gender,mailID)
        {
            StudentID = ++s_studentID;
            Degree = degree;
            Department = department;
            Semester = semester;
        }
        public string DisplayStudent()
        {
            return $"StudentID : {StudentID}, {DisplayPersonal()}, Degree : {Degree}, Department : {Department}, Semester : {Semester}";
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