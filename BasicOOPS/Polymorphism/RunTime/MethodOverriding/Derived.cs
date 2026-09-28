using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Derived : Base
    {
        public int val=10;
        
        public double Multiply(double n1,double n2)
        {
            return n1*n2;
        }
    }
}