using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class OperOver
    {
        private int _real;

        private int _imaginary;

        public OperOver(int real, int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public static OperOver operator +(OperOver a,OperOver b)
        {
            OperOver result = new OperOver(0,0);
            result._real = a._real+b._real;
            result._imaginary=a._imaginary+b._imaginary;
            return result;
        }

        public string Dissplay()
        {
            return $"{_real} + j{_imaginary}";
        }
    }
}