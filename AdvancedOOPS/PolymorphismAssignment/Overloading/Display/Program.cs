using System;

namespace Display;

class Program
{
    public static void Main(string[] args)
    {
        Display("Edward");
        Display("Edward","David");
        Display("Edward","David","Chennai");
        Display("Edward",55);
        Display("Edward",50000);
    }
    //one arugument
    public static void Display(string name)
    {
        System.Console.WriteLine($"Name : {name}\n" );
    }

    //two arugument
    public static void Display(string name,string lastName)
    {
        System.Console.WriteLine($"\nName : {name}, Last Name : {lastName} \n");
    }

    //three arugument
    public static void Display(string name,string lastName,string location)
    {
        System.Console.WriteLine($"\nName : {name}, Last Name : {lastName}, Location : {location} \n");
    }
    //two types
    public static void Display(string name,int height)
    {
        System.Console.WriteLine($"\nName : {name}, Height : {height}\n" );
    }
     //three types
    public static void Display(string name,int height,double salary)
    {
        System.Console.WriteLine($"\nName : {name}, Height : {height} , Salary : {salary}\n" );
    }

}

/*
2.	Create a set of display methods inside Program.cs and main method and display the given values.
a.	Method with one argument and display the value.
b.	Method with 2 arguments with same argument type and display result.
c.	Method with 3 arguments with same argument type and display the result. 
d.	Method with 2 arguments with different argument type and display result.
e.	Method with 3 arguments with different argument type and display the result. 
*/