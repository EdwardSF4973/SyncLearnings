using System;

namespace First;

class Program
{
    public static void Main(string[] args)
    {
       PersonalInfo per1 = new("edward","george","7305541054","edward@123",new DateTime(2002,11,19),"Male");
       System.Console.WriteLine(per1.DisplayPersonalInfo());

       StudentInfo stud1 = new("Eight","CSE",2024,"CID1004","Edward","George","7305541054","edward@123",new DateTime(2002,10,27),"Male");
       System.Console.WriteLine(stud1.DisplayStudent());
    }
}