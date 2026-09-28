using System;

namespace MethodOverloading;

class Program
{
    public static void Main(string[] args)
    {
        MathMethods math = new MathMethods();
        System.Console.WriteLine(math.Add(10,20));
        System.Console.WriteLine(math.Add(10,20,30));
        System.Console.WriteLine(math.Add(10.5,9.5));

    }
}