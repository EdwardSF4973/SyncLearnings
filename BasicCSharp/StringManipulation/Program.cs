/*using System;

namespace StringManipulation;


class Project
{
    public static void Main(string[] args)
    {
        //getting maininput from the user

        System.Console.WriteLine("Enter a main String");
        string mainString = System.Console.ReadLine();

        //getting string to be searched

        System.Console.WriteLine("Enterstring to be searched");
        string searchString = System.Console.ReadLine();

        //declaring a count for increment

        int count = 0;
        //splitting the string

        string[] splitString = mainString.Split(searchString );

        //assigning count
        count = splitString.Length-1;
        System.Console.WriteLine("Count of the string Searched  :"+count);
        */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Declaring post int
        int pos = 0;
        //Get the main string
        string mainString = Console.ReadLine();
        //Get the string to be inserted
        string insertString = Console.ReadLine();
        //insert string position
        string posString = Console.ReadLine();
        
        //insert string
        pos = mainString.IndexOf(insertString);

        string new = mainString.PadRight(1,posString);
        //inserting the string
        string result = mainString.Insert(pos-1,posString);

        //displayig the result
        Console.WriteLine(result);
    }
}
            

    /*}
}*/
