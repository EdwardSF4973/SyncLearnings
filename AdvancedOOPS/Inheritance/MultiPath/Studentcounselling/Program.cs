using System;
using Studentcounselling;

namespace StudentCounselling;

class Program
{
    public static void Main(string[] args)
    {
       PGCouncelling student1 = new(11,"4550",4651,59,96,85,7458548,"74874","sdfsdf","752145","sdvsdv5","Male",986451,85,96,52,75);
       System.Console.WriteLine(student1.HSCMarkTotal()); 
       System.Console.WriteLine(student1.HSCMarkPercentage()); 
       System.Console.WriteLine(student1.Total()); 
       System.Console.WriteLine(student1.Percentage()); 
       System.Console.WriteLine(student1.AadharNumber); 
       System.Console.WriteLine(student1.Gender); 
    }
}

