using System;
using PartialClasses;

namespace PartialClass;

class Program
{
    public static void Main(string[] args)
    {
        StudentDetails student = new StudentDetails("Edward",22,"7305541054");
        student.ShowStudentDetails();
    }

}

