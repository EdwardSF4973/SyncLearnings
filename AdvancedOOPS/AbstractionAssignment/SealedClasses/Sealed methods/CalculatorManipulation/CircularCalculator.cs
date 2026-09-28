using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorManipulation
{
    public class CircularCalculator : Calculator
    {
        public override double Radius { get; set; }

        public CircularCalculator(){}

        public CircularCalculator(double radius)
        {
            Radius = radius;
        }

        public sealed override double Area()
        {
            return 3.14*(Radius*Radius);
        }

        public override double Volume()
        {
            throw new NotImplementedException();
        }

    }
}
