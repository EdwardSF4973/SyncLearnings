using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication
{
    public class PersonalInfo : IFamilyInfo
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string DOB { get; set; }

        public string Mobile { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string PermanantAddress { get; set; }

        public PersonalInfo(string name,string gender,string dob,string mobile,string fatherName,string motherName,string permanentAddress)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile =mobile;
            FatherName = fatherName;
            MotherName= motherName;
            PermanantAddress = permanentAddress;
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
