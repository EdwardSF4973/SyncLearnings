using System;


namespace QuickSorting;

class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {45,33,12,55,77,22,33,14,67,12,35};
        QuickSort(numbers,0,numbers.Length-1);
        foreach(int n in numbers)
        {
            System.Console.WriteLine(n);
        }

        System.Console.WriteLine();

        string[] ids = {"SF3023","SF3021","SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF309"};
        QuickSort(ids,0,ids.Length-1);
        foreach(string n in ids)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();

        char[] characters = {'c','a','f','b','k','h','z','t','m','p','l','d'};
        QuickSort(characters,0,characters.Length-1);
        foreach(char n in characters)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();




        double[] digits = {1.1,65.3,93.9,55.5,3.5,6.9};
        QuickSort(digits,0,digits.Length-1);
        foreach(double n in digits)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();
    }

    public static void QuickSort<T>(T[] array, int start, int end)  where T : IComparable<T>
    {
        if (start < end)
        {
            
    
        int pivot = Partition(array, start, end);
        QuickSort(array, start, pivot - 1);
        QuickSort(array, pivot + 1, end);
        }
    }

    public static int Partition<T>(T[] array, int start, int end) where T : IComparable<T>
    {
        T pivot = array[end];
        int i = start - 1;
        for (int j = start; j < end; j++)
        {
            if (array[j].CompareTo(pivot)>0)
            {
                i++;
                T te = array[i];
                array[i] = array[j];
                array[j] = te;

            }
        }
        i++;
        T temp = array[i];
        array[i] = array[end];
        array[end] = temp;


        return i;

    }
}