using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorManipulation
{
    public class CylinderCalculator : CircularCalculator
    {
        public double Height { get; set; }

        public override double Radius { get; set; }

        public CylinderCalculator(double height,double radius)
        {
            Height = height;
            Radius = radius;
        }

       

        public override double Volume()
        {
            return 3.14*(Radius*Radius)*Height;
        }
    }
}
