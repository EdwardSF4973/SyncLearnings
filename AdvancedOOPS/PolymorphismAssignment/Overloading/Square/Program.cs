using System;
using System.Runtime.ConstrainedExecution;

namespace Square;

class Program
{
    public static void Main(string[] args)
    {
        int a = 5;
        System.Console.WriteLine(Multiple(a));

        float b = 10;
        System.Console.WriteLine(Multiple(b));

        double s = 500;
        System.Console.WriteLine(Multiple(s));

        long n = 10000;
        System.Console.WriteLine(Multiple(n));

    }
    //int
    public static int Multiple(int a)
    {
        return a*a;
    }
    //float
    public static float Multiple(float a)
    {
        return a*a;
    }
    //double
    public static double Multiple(double a)
    {
        return a*a;
    }
    //long
    public static long Multiple(long a)
    {
        return a*a;
    }
}

/*
3.	Create a set of methods in Program.cs that will calculate the square of given type number
a.	Compute square of given integer
b.	Compute square of given float
c.	Compute square of given double
d.	Compute square of given long
Requirement : Call the above 5 methods and print the results.

*/