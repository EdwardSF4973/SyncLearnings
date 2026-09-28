using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Calculator
{
    public partial class ScientificCalculator
    {
        public int FirstValue { get; set; }

        public int SecondValue { get; set; }

        public ScientificCalculator(int a,int b)
        {
            FirstValue = a;
            SecondValue = b;
        }

        partial void Addition();
        

        partial void Subtraction();

        public partial void Add();

        public partial void Sub();

        partial void Sin();
        partial void Cos();
        partial void Tan();

        public partial void Tann();
        public partial void sinn();
        public partial void Cosn();



        
    }
}
/*
3.	Create a class application for Scientific Calculator

a.	Create a file ArithmaticCalculator.
b.	Inside that create partial class Calculator
c.	Create Properties - > FirstValue, SecondValue
d.	Add methods Addition, Subtraction t
e.	Create a file TrignometryCalculator.
f.	Inside that create partial class Calculator and provide methods Sin, Cos, Tan
Requirement : Create object for the class and pass values to method as arguments and display the results.

*/