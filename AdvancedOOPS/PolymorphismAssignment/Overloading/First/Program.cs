using System;

namespace First;

class Program
{
    public static void Main(string[] args)
    {
        Arithmatic mat = new();
        //a
        double a =5;
        System.Console.WriteLine(mat.Multiple(a));

        //b
        a = 3;
        double b = 4;
        
        System.Console.WriteLine(mat.Multiple(a,b));

        //c
        a = 3;
        b = 4;
        double c = 5;
        System.Console.WriteLine(mat.Multiple(a,b,c));

        //d
        int ab =2;
        int bc = 3;
        System.Console.WriteLine(mat.Multiple(ab,bc));

         //d
        ab =2;
        bc = 3;
        int cd = 4;
        System.Console.WriteLine(mat.Multiple(ab,bc,cd));



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