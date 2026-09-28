using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorManipulation
{
    public abstract class Calculator
    {
        public abstract double Radius { get; set; }

        public Calculator(){}

        public Calculator(double radius)
        {
            Radius = radius;
        }

        public abstract double Area();

        public abstract double Volume();
        
    }
}
