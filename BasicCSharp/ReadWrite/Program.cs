using System;


namespace ReadWrite;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your father name");
        string fatherName = Console.ReadLine();

        //show full name
        //concatenation
        Console.WriteLine("Your name is :"+ name + " "+ fatherName);

        //placeholde
        Console.WriteLine("Your name is {0} {1}", name, fatherName);

        //interpolation
         Console.WriteLine($"Your name is {name} {fatherName}");
    }
}