using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BinarySearch;

class Program
{
    public static void Main(string[] args)
    {

        int [] a = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        System.Console.WriteLine(BinarySearch(a,66));
        System.Console.WriteLine();
        
        string [] str = {"SF3023","SF3021","SF3067","SF3043","SF3053","SF3032","SF3063", "SF3089", "SF3062", "SF3092"};
        System.Console.WriteLine(BinarySearch(str,"SF3067"));
        System.Console.WriteLine();

        char[] characters = {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        System.Console.WriteLine(BinarySearch(characters,'m'));
        System.Console.WriteLine();


        double[] digits = {1.1,65.3,93.9,55.5,3.5,6.9};
        System.Console.WriteLine(BinarySearch(digits,3.5));
        System.Console.WriteLine();

        

 
    }
    public static string BinarySearch<T>(T[] elements, T searchElement) where T : IComparable<T>
    {
        Array.Sort(elements);

        int left = 0;
        int right = elements.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (elements[mid].Equals(searchElement))
            {
                return $"{mid}";
            }
            else if (elements[mid].CompareTo(searchElement) < 0)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }


        }
        return $"-1";
    }
}