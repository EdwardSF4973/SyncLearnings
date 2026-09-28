using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class MarkSheet :TheoryExamMarks,ICalculate
    {
        public int MarksheetNumber { get; set; }

        public string DOI { get; set; }

        public int Total { get; set; }

        public int Percentage { get; set; }

        public int ProjectMark { get; set; }

        public MarkSheet(int markNumber,string doi,int pm,int[] sem1,int[] sem2,int[] sem3,int[] sem4,int reg,string name,string fatherName,string phone,string dob,string gender):base(sem1,sem2,sem3,sem4,reg,name,fatherName,phone,dob,gender)
        {
            MarksheetNumber = markNumber;
            DOI =doi;
            ProjectMark = pm;
        }

        public double CalculateTotal(int[] a)
        {
            double total = 0;
            foreach(int n in a)
            {
                total+=n;
            }
            total+=ProjectMark;
            return total;
        }
        public double CalculatePercentage()
        {
            double sum = CalculateTotal(Sem1)+CalculateTotal(Sem2)+CalculateTotal(Sem3)+CalculateTotal(Sem4);
            double result = sum/1200;
            return result*100;
        }

        public string Display()
        {
            return $"Name : {Name}, MarkNumber : {MarksheetNumber}\nFatherName : {FatherName},\nSem1 : {CalculateTotal(Sem1)}\nSem2 : {CalculateTotal(Sem2)}\nSem3 : {CalculateTotal(Sem3)}\nSem4 : {CalculateTotal(Sem4)}\nOverALL Percentage : {CalculatePercentage()}";
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