/*using System;

namespace PracticeAssignments;

class Program
{
    public static void Main(string[] args)
    {
        //getting the user input in double
        double speed = Convert.ToDouble(Console.ReadLine());
        double sec = Convert.ToDouble(Console.ReadLine());
        //perform calculation
        double convert = (double)5 / 18;
        double result = speed * sec * convert;
        //printing the values
        Console.WriteLine(result);
    }
}*/
/*
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Getting the student's marks
        int physics = Convert.ToInt32(Console.ReadLine());
        int chemistry = Convert.ToInt32(Console.ReadLine());
        int math = Convert.ToInt32(Console.ReadLine());

        //getting sum and percentage

        int sum = physics + chemistry + math;
        double percentage;

        percentage = (double)sum/300*100;

        //printing the marks

        //Console.WriteLine($"Sum:{sum}");
        Console.WriteLine($"Percentage:{percentage}");
    }
}*/
/*
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //getting the input 
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        //while loop

        while(num >0)
        {
            int n=num % 10;
            num = num-n;
            num = num/10;
            sum = sum + n;
        }
        //printing the values
        Console.WriteLine(sum);
        
    }
}*/
/*
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //getting the n
        int number = Convert.ToInt32(Console.ReadLine());

        //declaring 2* vaiable
        int result=2;

        while(result<number)
        {
            result = result*2;
        }
        //printing the answer
        Console.WriteLine(result);

    }
}*/

/// <summary>
/// array 8 one-------------
/// -----------------------------------------
/// 
/// </summary>
        
using System;

public class Program
{
    public static void Main(string[] args)
    {
         //get the array size from the usser
         int n = Convert.ToInt32(Console.ReadLine());

         //assigning two arrays and result arraty
         int[,] firstAr = new int[n,n];
         int[,] secondAr = new int[n,n];
         int[,] resultAr = new int[n,n];

         //for loop for first array
         for(int i=0;i<n;i++)
         {
            for(int j=0;j<n;j++)
            {
               firstAr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
         } 
         //for loop for second array
         for(int i=0;i<n;i++)
         {
            for(int j=0;j<n;j++)
            {
               secondAr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
         }
         //for loop for adding the two mat
         for(int i=0;i<n;i++)
         {
            for(int j=0;j<n;j++)
            {
               resultAr[i,j]=firstAr[i,j]*secondAr[i,j];
            }
         } 
         //printitngg the elements
         for(int i=0;i<n;i++)
         {
            for(int j=0;j<n;j++)
            {
               Console.Write(resultAr[i,j]+" ");
            }
            Console.WriteLine();
         }
    }
}


                     