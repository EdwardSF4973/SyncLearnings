using System;
using System.Runtime.InteropServices;

namespace ForLoop;

class Program
{
    public static void Main(string[] args)
    {
        //output variable declaration

        int result = 0;

        //asking for the limit from user
        int k = Convert.ToInt32(Console.ReadLine());
        int j = Convert.ToInt32(Console.ReadLine());

        //for loop assigning i = 1-10

        for( int i =  k;i<=j;i++)
        {
            int temp = i*i;
            //add the square of each number to result
            result += temp;
        }
        //printing the values
        Console.WriteLine(result);
    }
}