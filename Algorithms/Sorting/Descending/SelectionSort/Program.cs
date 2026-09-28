using System;
using System.Globalization;

namespace SelectionSort;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {45,33,12,55,77,22,33,14,67,12,35};
        SelectionSorting(numbers);
        foreach(int n in numbers)
        {
            System.Console.WriteLine(n);
        }

        System.Console.WriteLine();

        string[] ids = {"SF3023","SF3021","SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF309"};
        SelectionSorting(ids);
        foreach(string n in ids)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();

        char[] characters = {'c','a','f','b','k','h','z','t','m','p','l','d'};
        SelectionSorting(characters);
        foreach(char n in characters)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();




        double[] digits = {1.1,65.3,93.9,55.5,3.5,6.9};
        SelectionSorting(digits);
        foreach(double n in digits)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();
    }
    public static void SelectionSorting<T>(T[] elements) where T : IComparable
    {
        int n = elements.Length;
        int flag = 0;
        for (int i = 0; i < n; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++)
            {
                flag++;
                if (elements[j].CompareTo(elements[min]) > 0)
                {
                    min = j;
                }
            }
            (elements[i], elements[min]) = (elements[min], elements[i]);

        }
        System.Console.WriteLine("Insertion Sort:" + flag
        );
    }
}