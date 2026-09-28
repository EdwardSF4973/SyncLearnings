using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication
{
    public interface IFamilyInfo
    {
        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string PermanantAddress { get; set; }

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