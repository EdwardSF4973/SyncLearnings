using System;

namespace Students;

class Program
{
    public static void Main(string[] args)
    {
        StudentInfo stud = new(112,"Edward","Male","19/11/2002","7305541054",65,82,86);
        stud.Total();
        stud.TotalPercentage();
        System.Console.WriteLine(stud.MobileNumber);
        stud.DisUpdate("9444058804");
        System.Console.WriteLine(stud.MobileNumber);
    }
}

