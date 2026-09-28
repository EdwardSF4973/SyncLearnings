using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class ScientificCalculator
    {
        partial void Addition()
        {
            System.Console.WriteLine(FirstValue+SecondValue);
        }
        
        partial void Subtraction()
        {
            System.Console.WriteLine(FirstValue-SecondValue);
            
        }

        public partial void Add()
        {
            Addition();
        }

        public partial void Sub()
        {
            Subtraction();
        }
    }
}