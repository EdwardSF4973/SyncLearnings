
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesVolume
{
    public class Cylinders : Shape
    {
        public override double Area{get;set;}

        public override double Volume { get; set; }

        private static double Pi = 3.14;

        public double Radius { get; set; }

        public double Height { get; set; }
        
       
        public Cylinders(double radius, double height ):base(radius,height)
        {
            Radius=radius;
            Height=height;
        }

        public override double CaclculateArea()
        {
            double area = 2*Pi*Radius*(Radius+Height);
            Area = area;
            return area;

        }

        public override double CalculateVolume()
        {
            double volume = Pi*(2*Radius)*Height;
            Volume = volume;
            return volume;
        }
    }
}
