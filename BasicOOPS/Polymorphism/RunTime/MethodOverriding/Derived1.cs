using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Derived1 :Derived
    {
        public double Multiply(double n1,double n2)
        {
            return n1*n2;
        }
    }
}