using System;

namespace MethodAssignment;

class Program
{
    static int number1=10;

    static int number2=25;

    public static void Main(string []args)
    {
        Add();
    }
    //method without argumen without return type
    static void Add()
    {
        int result = number1+number2;
        Console.WriteLine(result);
    }

    //method without argument with return type

    static int Subraction()
    {
        int result = number1-number2;
    }
}