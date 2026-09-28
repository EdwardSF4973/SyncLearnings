using System;

namespace InsertionSort;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {45,33,12,55,77,22,33,14,67,12,35};
        InsertionSorting(numbers);
        foreach(int n in numbers)
        {
            System.Console.WriteLine(n);
        }

        System.Console.WriteLine();

        string[] ids = {"SF3023","SF3021","SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF309"};
        InsertionSorting(ids);
        foreach(string n in ids)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();

        char[] characters = {'c','a','f','b','k','h','z','t','m','p','l','d'};
        InsertionSorting(characters);
        foreach(char n in characters)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();




        double[] digits = {1.1,65.3,93.9,55.5,3.5,6.9};
        InsertionSorting(digits);
        foreach(double n in digits)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();


    }
    public static void InsertionSorting<T>(T[] elements) where T:IComparable
    {
        int n=elements.Length;
        int iteration =0;
        for(int i=0;i<n;i++)
        {
            T key=elements[i];

            int j=i-1;
            while(j>=0 && elements[j].CompareTo(key)>0)
            {
                iteration++;
                elements[j+1]=elements[j];
                j--;
            }
            elements[j+1]=key;

        }
        System.Console.WriteLine();
    }
}