using System;

namespace Calculator;

class Program
{
    public static void Main(string[] args)
    {
        ScientificCalculator cal1 = new(50,6);
        cal1.Add();
        System.Console.WriteLine();
        cal1.Sub();
        System.Console.WriteLine();
        cal1.sinn();
        System.Console.WriteLine();
        cal1.Tann();
        System.Console.WriteLine();
        cal1.Cosn();
    }
}
