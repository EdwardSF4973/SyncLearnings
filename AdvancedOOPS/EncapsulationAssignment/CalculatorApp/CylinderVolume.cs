using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private double _height;

        public double Height { get { return _height; } }

        internal double _volume;

        public CylinderVolume(double height, double volume, double radios, double area) : base(radios, area)
        {
            _height = height;
            _volume = volume;
        }

        public double CalculateVolume()
        {
            double Cv = CalculateCircleArea() * Height;
            return Cv;
        }

    }
}