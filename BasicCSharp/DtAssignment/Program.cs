using System;

namespace Dtassignment;

class Program
{
    public static void Main(string [] args)
    {
        //first one
        System.Console.WriteLine("First question");

        //datetime variable
        DateTime first = new DateTime(2021,8,10,10,40,32);

        //displaying each value or individually

        System.Console.WriteLine(first.Year);
        System.Console.WriteLine(first.Month);
        System.Console.WriteLine(first.Day);
        System.Console.WriteLine(first.Hour);     
        System.Console.WriteLine(first.Minute);        
        System.Console.WriteLine(first.Second);



        /*-----
        */

        //second question

        System.Console.WriteLine("\nSecond quesution");

        //getting input from user

        System.Console.WriteLine(" Enter your date in yyyy/MM//dd HH:mm:ss tt");

        DateTime second = DateTime.ParseExact(System.Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
        
        //System.Console.WriteLine(dob.ToString("dd/MM/yyyy HH:mm:ss tt");//HH - 24hourss format
        //convert to string 
        string str1= second.ToString("yyyy/MM/dd hh:mm:ss tt");

        System.Console.WriteLine(second);
        System.Console.WriteLine(str1);

        
        string[] splitChar = str1.Split(new char[] {':','/',' '});
        
        for(int i=splitChar.Length-1;i>=0;i--)
        {
            System.Console.Write($"{splitChar[i]} ");
        }

        /*------
        */


        //Third question
        System.Console.WriteLine("Third quesution");

        //getting input
        DateTime third = DateTime.ParseExact(System.Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);

        //printing the date's year month and day
        System.Console.WriteLine(third.Year);
        System.Console.WriteLine(third.Month);
        System.Console.WriteLine(third.Day);








    }
}

