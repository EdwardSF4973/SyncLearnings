using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Dimension
    {
        public double Length { get; set; }
        public double Height { get; set; }

        //public Rectangle(){}
        public Rectangle(double value1,double value2)
        {
            Length = value1;
            Height = value2;
        }
        public override double CalculateArea()
        {
            return Length*Height;
        }

    }
}
