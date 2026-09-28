using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMark
{
    public class Semester
    {
        private int _subject1;
        private int _subject2;
        private int _subject3;
        private int _subject4;
        private int _subject5;
        private int _subject6;

        public Semester(int sub1, int sub2, int sub3, int sub4, int sub5, int sub6)
        {
            _subject1 = sub1;
            _subject2 = sub2;
            _subject3 = sub3;
            _subject4 = sub4;
            _subject5 = sub5;
            _subject6 = sub6;
        }

        public static Semester operator +(Semester sem1,Semester sem2)
        {
            Semester result = new(0,0,0,0,0,0);
            result._subject1 = sem1._subject1+sem2._subject1;
            result._subject2 = sem1._subject2+sem2._subject2;
            result._subject3 = sem1._subject3+sem2._subject3;
            result._subject4 = sem1._subject4+sem2._subject4;
            result._subject5 = sem1._subject5+sem2._subject5;
            result._subject6 = sem1._subject6+sem2._subject6;
            return result;

        }

        public string Display()
        {
            return $"subject1 : {_subject1}, subject2 : {_subject2},    subject3 : {_subject3}, subject4 : {_subject4}. subject5 : {_subject5},     subject6 : {_subject6}";
        }
        public string Percentage()
        {
            return $"{_subject1+_subject2+_subject3+_subject4+_subject5+_subject6/600}";
        }
        public string Total()
        {
             return $"{_subject1+_subject2+_subject3+_subject4+_subject5+_subject6}";

        }


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