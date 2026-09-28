using System;
using MathLib;

namespace CalculatorApp;

class Program
{
    public static void Main(string[] args)
    {
        CircleArea a = new(10,5.5);
        System.Console.WriteLine(a.CalculateCircleArea());
        
    }
}