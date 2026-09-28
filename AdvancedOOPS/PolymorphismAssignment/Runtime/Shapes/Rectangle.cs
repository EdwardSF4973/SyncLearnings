using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes 
{
    public class Rectangle : Shape
    {
        public override void DrawShape()
        {
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("|             |");
            System.Console.WriteLine("---------------");
        }

    }
}