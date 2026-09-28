using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Dimension
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }
        public Dimension(){}
        public Dimension(double value1,double value2)
        {
            Value1 = value1;
            Value2= value2;
        }

        public virtual double CalculateArea()
        {
            Area = Value1*Value2;
            return Area;
        }
    }
}
