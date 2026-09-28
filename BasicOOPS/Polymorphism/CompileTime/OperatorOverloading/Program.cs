using System;
using System.Runtime.ConstrainedExecution;

namespace OperatorOverloading;

class Program
{
    public static void Main(string[] args)
    {
        OperOver a = new(3,2);
        System.Console.WriteLine(a.Dissplay());
        OperOver b = new(1,2);
        System.Console.WriteLine(b.Dissplay());
        OperOver result1 = a+b;
        System.Console.WriteLine(result1.Dissplay());
    }
}