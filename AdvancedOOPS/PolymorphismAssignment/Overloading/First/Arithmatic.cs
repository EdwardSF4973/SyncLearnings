using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class Arithmatic
    {
        public Arithmatic(){}
        //square
        public double Multiple(double a)
        {
            return a*a;
        }
        //two arugu
        public double Multiple(double a, double b)
        {
            return a*b;
        }
        //three arugu
        public double Multiple(double a, double b,double c)
        {
            return a*b*c;
        }
        //two arugu
        public int Multiple(int a, int b)
        {
            return a*b;
        }
        //three arugu
        public int Multiple(int a, int b,int c)
        {
            return a*b*c;
        }
    }
}
/*
1.	Create class Arithmatic

a.	Create a set of Multiply method inside a class
b.	Method with one argument and display the Square value of a given number.
c.	Method with 2 arguments with same argument type and return result.
d.	Method with 3 arguments with same argument type and return the result. 
e.	Method with 2 arguments with different argument type and return result.
f.	Method with 3 arguments with different argument type and return the result. 
*/