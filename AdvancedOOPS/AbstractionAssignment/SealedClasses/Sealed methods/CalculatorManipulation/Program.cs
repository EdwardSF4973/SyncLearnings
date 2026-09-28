
using System;

namespace CalculatorManipulation;

class Program 
{
    public static void Main(string [] args)
    {

    }
}
/*
2.	Create a application for calculator manipulation

Class Calculator:
Property: Radius
Method: Abstract Area, Volume

Class CircleCalculator inherit Calculator
Property: Radius
Methods: sealed override void Area - 3.14 * r 2

Class CylinderCalculator: inherit  CircleCalculator
Property : Hight, Radius
Method: override Area, Volume that used circle Area for 3.14 ( r 2 )h

Requirement : Have to create objects for the CircleCalculator and CylinderCalculator class and have to call the methods Area and Volume and see what is happening.



*/