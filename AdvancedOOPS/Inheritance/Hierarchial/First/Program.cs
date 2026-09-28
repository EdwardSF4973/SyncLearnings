using System;
using System.Data;

namespace First;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo persona = new("Edward","George",new DateTime(2002,11,19),"7300541054","Male","edward@123");
        System.Console.WriteLine(persona.DisplayPersonal());

        Teacher teacher1 = new(123,"cse","Data","Mphil",5,new DateTime(2000,02,04),"Jessi","Jackie",new DateTime(2020,05,14),"7456396521","Female","jessi@123");
        System.Console.WriteLine(teacher1.DisplayTeacher());

        StudentInfo student = new(456,"BE","ECE",5,"Dayalan","Loganathan",new DateTime(2002,08,15),"78632145863214","Male","dayalan@123");
        System.Console.WriteLine(student.DisplayStudent());

        Principal princi = new(789,"ME",8,new DateTime(2005,08,25),"charu","panner",new DateTime(2002,10,27),"8652145862","Female","Charu@123");
        System.Console.WriteLine(princi.DisplayPrincipal());


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