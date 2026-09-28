using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesVolume
{
    public abstract class Shape
    {
        public abstract double Area { get; set; }

        public abstract double Volume { get; set; }

        public double Radius { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public double A { get; set; }

        public Shape(){}
        public Shape (double radius,double height)
        {
            Radius = radius;
            Height = height;
        }
        public Shape (double a)
        {
            A=a;
        }
        public  abstract double CaclculateArea();

        public abstract double CalculateVolume();
    }
}
