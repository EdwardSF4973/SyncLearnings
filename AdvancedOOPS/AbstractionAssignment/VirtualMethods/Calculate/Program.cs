using System;

namespace Calculate;

class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator area1 = new(5);
        area1.Calculate();

        VolumeCalculator volume1 = new(5,3);
        volume1.Calculate();
    }
}
