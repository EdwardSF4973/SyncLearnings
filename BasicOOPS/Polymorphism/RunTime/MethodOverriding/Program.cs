using System;

namespace MethodOverriding;

class Program
{
    public static void Main(string[] args)
    {
        Base baseobj = new Base();
        Console.WriteLine(baseobj.Multiply(10,2));

        Derived derived = new Derived();
        Console.WriteLine(derived.Multiply(10,3));

        Base b1 = new Derived();
        Console.WriteLine(b1.Multiply(5,3));
        b1 = new Derived1();
        Console.WriteLine(b1.Multiply(10,5));

    }
}