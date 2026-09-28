using System;

namespace SwitchStatement;

class Project{
    public static void Main(string[] args)
    {
        //geting tow numbers from users

        Console.Write("Enter  first Number ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter  second Number ");
        int num2 = int.Parse(Console.ReadLine());

        //Getting sign
        Console.Write("Enter Operation to be done");
        Console.Write("press the number for specific operation");
        Console.Write("\n1 +\n2 -\n3 *\n4 /\n5 %\n");
        int oper = int.Parse(Console.ReadLine());

        //Switch statemnts for each every cases

        switch(oper)
        {
            case 1 :
            {
                Console.WriteLine(num1+num2);
                break;
            }
            case 2:
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case 3 :
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case 4 :
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case 5:
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default :
            {
               Console.WriteLine("Invalid"); 
               break;
            }




        }




    }
}