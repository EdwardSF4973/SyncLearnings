using System;

namespace ShapesVolume;

class Program
{
    public static void Main(string[] args)
    {
        Cylinders cyl = new(25.5,65);
        System.Console.WriteLine(cyl.CaclculateArea());
        System.Console.WriteLine(cyl.CalculateVolume());

        Cubes c1 = new(5);
        System.Console.WriteLine(c1.CaclculateArea());
        System.Console.WriteLine(c1.CalculateVolume());
        
    }
}
