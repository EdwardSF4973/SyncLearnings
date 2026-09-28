using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class MathMethods
    {
        //Method OverLoading by Number of Arguments
        public int Add(int a,int b)
        {
            return a+b;
        }
        public int Add(int a,int b,int c)
        {
            return a+b+c;
        }
        //Method Overloading by Type of arguments
        public double Add(double a, double b)
        {
            return a+b;
        }

    }
}