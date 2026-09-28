using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculate
{
    public class AreaCalculator
    {
        public double Radius { get; set; }

        public AreaCalculator(){}
        public AreaCalculator(double radius)
        {
            Radius = radius;
        }
        
        public virtual void Calculate()
        {
            double Area =  3.14*Radius*Radius;
            System.Console.WriteLine(Area);
        }
    }
}
/*
1.	Create an application that calculate area and volume

Class AreaCalculator
Property: Radius
Method: virtual Calculate – 3.14 *r*r

Class VolumeCalculator inherit AreaCalculator
Property: Height
Method: override Calculate - 3.14 *r*r*h

Requirements : Create two objects for volume and area calculator based on provided values display the output

*/