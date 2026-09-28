using System;
using System.Numerics;

namespace ComplexArithmatic;

class Program
{
    public static void Main(string[] args)
    {
        ComplexNumbers a = new(3,2);
        System.Console.WriteLine(a.Dissplay());

        ComplexNumbers b = new(5,2);
        System.Console.WriteLine(b.Dissplay());

        ComplexNumbers result = a+b;
        System.Console.WriteLine(result.Dissplay());
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