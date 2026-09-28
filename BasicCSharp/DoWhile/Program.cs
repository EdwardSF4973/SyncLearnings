//Action to be repeated
//termination statement
//condition checking

using System;

namespace DoWhile;
class Project
{
    public static void Main(string[] args)
    {
        //assigning empty
        string repeat = "";

        //asking values from the user
        //declaring the var
        int num ;

        do
        {
            //getting number from user
            System.Console.WriteLine("Enter a number");
            
            num = Convert.ToInt32(System.Console.ReadLine());
            //checking the condition
            if(num%2==0)
            {
                System.Console.WriteLine("Even");
            }
            else
            {
                System.Console.WriteLine("Odd");
            }
            //checking for the repeation
            System.Console.WriteLine("Do you need to enter another number:");
            repeat = System.Console.ReadLine();
            
            

        }while(repeat=="yes");
        //display the thank you
        System.Console.WriteLine("Thank you");
    }
}