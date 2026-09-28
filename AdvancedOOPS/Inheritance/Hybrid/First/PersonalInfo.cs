using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace First
{
    public class PersonalInfo
    {
        public int RegistrationNumber { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Phone { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public PersonalInfo(int reg,string name,string fatherName,string phone,string dob,string gender)
        {
            RegistrationNumber = reg;
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }
        
    }
}
/*
1.	Class to create application for Hybrid Inheritance using Student Marksheet generation 
    application create two objects for marksheet details object, Calculate total marks of each sem and 
    calculate % mark and show U.G marksheet for it:


Class PersonalInfo:
Properties: RegistationNumber, Name, FatherName, Phone, DOB, Gender

Class TheoryExamMarks : Inhertis PersonalInfo
Properties: Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.

Interface: ICalculate
Properties: ProjectMark
Methods: CalculateUG -> Total, Percentage.

Class Marksheet: inherit TheoryExammarks, ICalculate
Properties: MarksheetNumber, DateOfIssue, Total, Percentage
Methods : SHowUGMarkSHeet

*/