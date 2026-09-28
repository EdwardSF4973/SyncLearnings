using System;

namespace WhileLoop;

class Program
{
    public static void Main(string[] args)
    {
        //assigning i = 0
        int i = 0;
        //while loop
        while(i<=25)
        {
            // to print for the even numbers
            System.Console.WriteLine(i);
            //increment and termination line for loop
            i+=2;
        }

        //Exercise 2

        System.Console.WriteLine("Exercise 2");

        //getting the input from user
        System.Console.WriteLine("Enter a number");
        bool isNum = int.TryParse(System.Console.ReadLine(),out int num);
        
        //while loop
        while(!isNum)
        {
            System.Console.Write("Invalid");
            isNum = int.TryParse(Console.ReadLine(), out num);
        }
        System.Console.WriteLine($"\n{num}");
    }
}