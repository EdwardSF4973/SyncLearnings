using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexArithmatic
{
    public class ComplexNumbers
    {
        private int _real;

        private int _imaginary;
        
       public ComplexNumbers(int real, int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public static ComplexNumbers operator +(ComplexNumbers a,ComplexNumbers b)
        {
            ComplexNumbers result = new ComplexNumbers(0,0);
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
/*
3.	Complex arithmetic application 
a.	Create a class ComplexNumbers 
b.	Properties : Real, Imaginary 
c.	Ex : 5+j10
d.	In that create a set of operator overloaded method that
    will be used to add, subtract, check equal, greater, less than 
    comparison of two complex numbers.
e.	Create two objects for getting two complex numbers 
i.	Compute the addition of two numbers.
ii.	Compute the subtract of two numbers.
iii.	Check equality
iv.	Check first one is greater or less

*/