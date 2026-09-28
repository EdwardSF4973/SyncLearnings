using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : Dimension
    {
        public double Radius{get; set;}

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            double area = Radius*Radius;
            return area*3.14*4;
        }
    }
}