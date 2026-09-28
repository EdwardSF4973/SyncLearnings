using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class TheoryExamMarks : PersonalInfo
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }

        

        public TheoryExamMarks(int[] sem1,int[] sem2,int[] sem3,int[] sem4,int reg,string name,string fatherName,string phone,string dob,string gender):base(reg,name,fatherName,phone,dob,gender)
        {
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
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