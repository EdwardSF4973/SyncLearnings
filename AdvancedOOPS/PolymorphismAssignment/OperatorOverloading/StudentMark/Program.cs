using System;

namespace StudentMark;

class Program
{
    public static void Main(string[] args)
    {
        Semester sem1 = new(10,10,10,10,10,10);
        Semester sem2 = new(10,10,10,10,10,10);
        Semester sem3 = new(10,10,10,10,10,10);
        Semester sem4 = new(10,10,10,10,10,10);
        
        Semester first = sem1+sem2;
        Semester second = sem3+sem4;

        Semester result = first + second;
        System.Console.WriteLine(result.Display());
        System.Console.WriteLine(result.Percentage());
        System.Console.WriteLine(result.Total());



    }
}

/*
2.	Students mark calculation application

a.	Create a class Semester 

b.	Properties : SubjectMark1, SubjectMark2, SubjectMark3, SubjectMark4, SubjectMark5, SubjectMark6, TotalMark, Percentage.

c.	Method: Calcuate -> Calculate total and percentage

d.	Create four objects named Sem1, Sem 2, Sem 3, Sem 4 using calculate method that will calculate the total mark, percentage of 6 subject.

a.	Create a operator overloaded method that will calculate the total mark of 4 semesters and display the total marks and percentage.  

*/