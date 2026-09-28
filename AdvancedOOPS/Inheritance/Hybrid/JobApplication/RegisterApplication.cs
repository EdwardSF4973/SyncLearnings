using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication
{
    public class RegisterApplication :UGInfo
    {
        public int RegisterNumber { get; set; }

        public int ExperienceInMonths { get; set; }

        public string FieldOfIntrest { get; set; }

        public RegisterApplication(int registerNumber, int experienceInMonths,string foi,int ugMarkNumber,string degree,string branch,string name,string gender,string dob,string mobile,string fatherName,string motherName,string permanentAddress,int[] sem1,int[] sem2,int[] sem3,int[]sem4):base(ugMarkNumber,degree,branch,name,gender,dob,mobile,fatherName,motherName,permanentAddress,sem1,sem2,sem3,sem4)
        {
            RegisterNumber = registerNumber;
            ExperienceInMonths = experienceInMonths;
            FieldOfIntrest = foi;
        }

        public string DispalyDetails()
        {
            return $"Registernumber : {RegisterNumber}\n {GetUGMarksheetData()}\nExperienceinMonths : {ExperienceInMonths} , FieldOfintrest : {FieldOfIntrest}";
        }
    }
}
/*3.	Create a program to implement Job Application Portal Create 2 registration for this application.

Interface IFamilyInfo:
Properties: FatherName,MotherName, PermanantAddress

Class: PersonalInfo : IFamilyInfo
Properties: Name, Gender, DOB, phone, mobile

Interface IMarkDetails
Properties: Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.

Class UGInfo: Inhertis PersonalInfo, IMarkDetails
Properties: UGMarksheet Num, Degree, Branch, Sem1[], Sem2[], Sem3[], Sem4[] Marks
Method: GetUGMarksheetData, CheckEligiblity ->75% and above in all semester

Class RegisterApplication inherits UGInfo
Properties: RegisterNumber, Experience in Months, FieldOfIntrest
Methods: Show Details
*/