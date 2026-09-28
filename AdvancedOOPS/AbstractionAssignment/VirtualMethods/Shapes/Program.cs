using System;

namespace Shapes;

class Program
{
    public static void Main(string[] args)
    {
        Dimension shape1 = new(55,2.5);
        System.Console.WriteLine(shape1.CalculateArea());

        Dimension shape2 = new Rectangle(22,5.5);
        System.Console.WriteLine(shape2.CalculateArea());

        Dimension shape3 = new Sphere(2.2);
        System.Console.WriteLine(shape3.CalculateArea());
    }
}
