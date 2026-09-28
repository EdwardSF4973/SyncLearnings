using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculate
{
    public class VolumeCalculator : AreaCalculator
    {
        public double Height { get; set; }

        public VolumeCalculator(double height,double radius):base(radius)
        {
            Height=height;
        }
        public override void Calculate()
        {
            double area = 3.14*Radius*Radius*Height;
            System.Console.WriteLine(area);
        }
    }
}