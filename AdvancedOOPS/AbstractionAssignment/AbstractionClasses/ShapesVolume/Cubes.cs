
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesVolume
{
    public class Cubes : Shape
    {
        public override double Area{get;set;}

        public override double Volume { get; set; }

        public double A { get; set; }

        public Cubes(double a):base(a)
        {
            A=a;
        }
        public override double CaclculateArea()
        {
            Area = 6*(A*A);
            return Area;
        }

        public override double CalculateVolume()
        {
            Volume = A*A*A;
            return Volume;
        }

    }
}

