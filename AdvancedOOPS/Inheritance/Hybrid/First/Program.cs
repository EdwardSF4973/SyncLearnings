using System;

namespace First;

class Program
{
    public static void Main(string[] args)
    {
        MarkSheet stud = new(231,"ds",85,[88,22,99,66,33,47],[45,68,92,78,51,57],[03,56,86,63,80,72],[05,85,26,96,75,65],97456,"Edward","George","7852145624","19112002","male");
        System.Console.WriteLine(stud.Display());   
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