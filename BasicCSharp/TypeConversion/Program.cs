using System;

namespace TypeConversion;
class Program
{
    static void Main(string[] args)
    {
        //name geeting
        Console.Write("Enter your name");
        string name = Console.ReadLine();
        //father name getting 
        Console.Write("Enter your father name");
        string fatherName = Console.ReadLine();
        //getting gender
        Console.Write("Enter youe gender");
        Console.Write("M/F");
        char gender = Convert.ToChar(Console.ReadLine());
        //getting phone number
        Console.Write("Enter your phone number");
        long phoneNumber = Convert.ToInt64(Console.ReadLine());
        //getting marks
        Console.Write("Enter your Math mark");
        int mathMark = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Physics mark");
        int physicsMark = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Chemistry mark");
        int chemistryMark = Convert.ToInt32(Console.ReadLine());
        // asking grade
        Console.Write("Enter your grade");
        char grade = Convert.ToChar(Console.ReadLine());
        //Printing average

        float average =(float) (mathMark+physicsMark+chemistryMark)/3;

        
        Console.WriteLine($"Your name is {name}\nYour Fathe name is {fatherName}\n Your gender is {gender}\n Your phoneNumber is {phoneNumber} \n your average mark is {average}\n Your grade is {grade} ");
        
    }
}
