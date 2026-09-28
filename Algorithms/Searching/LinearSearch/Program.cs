using System;

namespace LinearSearch;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine("Numbers");
            bool flag = true;
            int[] arr = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
            int element = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    System.Console.WriteLine(i);
                    flag = false;
                }
                
                
            }
            if(flag)
            {
                System.Console.WriteLine(-1);
            }
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        

        try
        {
            System.Console.WriteLine("\n\nChars");
            bool flag1 = true;
            char[] arr1 = {'a','f','b','k','h','j','I','i','z','t','m','p','l','d','c' };
            char ch = char.Parse(Console.ReadLine());
            for(int i =0;i<arr1.Length;i++)
            {
                if(arr1[i]==ch)
                {
                    System.Console.WriteLine(i);
                    flag1 = false;
                }
                
            }
            if(flag1)
            {
                System.Console.WriteLine(-1);
            }

        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

        try
        {
            System.Console.WriteLine("\n\nDouble");
            bool flag2 = true;
            double[] arr2 = {1.1,65.3,93.9,55.5,3.5,6.9 };
            double value = float.Parse(Console.ReadLine());
            for(int i =0;i<arr2.Length;i++)
            {
                if(arr2[i]==value)
                {
                    System.Console.WriteLine(i);
                    flag2 = false;
                }
                
            }
            if(flag2)
            {
                System.Console.WriteLine(-1);
            }

        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }


        
        
        try
        {
            System.Console.WriteLine("\n\nString");
            bool flag3 = true;
            string[] arr3 = {"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
            string str = Console.ReadLine().ToUpper();
            for(int i =0;i<arr3.Length;i++)
            {
                if(arr3[i]==str)
                {
                    System.Console.WriteLine(i);
                    flag3 = false;
                }
                
            }
            if(flag3)
            {
                System.Console.WriteLine(-1);
            }

        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

    }
}


/*
1.	Implement a program to find an presence of an element and location of element using linear searching algorithm.
a.	45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77  -> Find 66
b.	"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032, "SF3063", "SF3089", "SF3062", "SF3092" -> Find - SF3067
c.	,a,f,b,k,h,j,I,i,z,t,m,p,l,d c-> Find m
d.	1.1,65.3,93.9,55.5,3.5,6.9 -> find 3.5
*/