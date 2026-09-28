using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace MethodClassroom;

class Program
{
    public static void Main(string[] args)
    {
        string need="";
        do
        {
            //Getting inputs from user 

            System.Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter num1");
            int num2 = Convert.ToInt32(System.Console.ReadLine());


            //showing option
            System.Console.WriteLine("Enter an operation need to be done");
            System.Console.WriteLine("Enter 1 for Addition ");
            System.Console.WriteLine("Enter 2 for Subtraction ");
            System.Console.WriteLine("Enter 3 for Multiplication ");
            System.Console.WriteLine("Enter 4 for Division ");

            //asking option
            //operation
            int oper = Convert.ToInt32(System.Console.ReadLine());

            //switch case

            switch (oper)
            {
                //addition
                case 1:
                    {
                        int resu = Add(num1, num2);
                        System.Console.WriteLine(resu);
                        break;
                    }
                //subtraction
                case 2:
                    {
                        int res = Sub(num1, num2);
                        System.Console.WriteLine(res);
                        break;
                    }
                //multiplication
                case 3:
                    {
                        int re = Mul(num1, num2);
                        System.Console.WriteLine(re);
                        break;
                    }
                //division
                case 4:
                    {
                        int r = Div(num1, num2);
                        System.Console.WriteLine(r);
                        break;
                    }
                //default
                default:
                    {
                        System.Console.WriteLine("Invalid");
                        break;
                    }
            }
            System.Console.WriteLine("Do you need to continue\nSay yes or no");
            need = System.Console.ReadLine();



        }while(need=="yes");





    }
    //Method for addition
    public static int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }
    //Method for subtraction
    public static int Sub(int a, int b)
    {
        int result = a - b;
        return result;
    }
    //Method for multiplication
    public static int Mul(int a, int b)
    {
        int result = a * b;
        return result;
    }
    //Method for division
    public static int Div(int a, int b)
    {
        int result = a / b;
        return result;
    }
}