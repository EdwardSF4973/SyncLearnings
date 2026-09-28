using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Draw
{
    public class Pyramid : Draw
    {
        public override void Drawing()
        {
            System.Console.WriteLine("*");           
            System.Console.WriteLine("**");
            System.Console.WriteLine("***");
            System.Console.WriteLine("****");
            System.Console.WriteLine("*****");
        }

    }
}