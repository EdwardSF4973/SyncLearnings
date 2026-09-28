using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class ScientificCalculator
    {
        partial void Sin()
        {
            System.Console.WriteLine(Math.Sin(FirstValue));
            System.Console.WriteLine(Math.Sin(SecondValue));
        }
        partial void Tan()
        {
            System.Console.WriteLine(Math.Tan(FirstValue));
            System.Console.WriteLine(Math.Tan(SecondValue));
        }
        partial void Cos()
        {
            System.Console.WriteLine(Math.Cos(FirstValue));
            System.Console.WriteLine(Math.Cos(SecondValue));
        }

        public partial void sinn()
        {
            Sin();
        }
        public partial void Tann()
        {
            Tan();
        }
        public partial void Cosn()
        {
            Cos();
        }

    }
}