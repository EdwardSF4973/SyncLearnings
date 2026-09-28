using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Draw
{
    public class Star : Draw
    {
        public override void Drawing()
        {
           int n = 5;
           for(int i=1;i<=n;i++)
           {
                for(int j=1;j<n-1;j++)
                {
                    System.Console.Write("");
                }
                for(int k =1;k<=(2*i-1);k++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
           }
        }
    }
}