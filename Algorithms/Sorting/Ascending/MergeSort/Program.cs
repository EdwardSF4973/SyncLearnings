using System;
using System.Security.Cryptography;

namespace MergeSort;

class Program
{
    public static void Main(string[] args)
    {
        
        int[] numbers = {45,33,12,55,77,22,33,14,67,12,35};
        MergeSort(numbers);
        foreach(int n in numbers)
        {
            System.Console.WriteLine(n);
        }

        System.Console.WriteLine();

        string[] ids = {"SF3023","SF3021","SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062"};
        MergeSort(ids);
        foreach(string n in ids)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();

        char[] characters = {'c','a','f','b','k','h','z','t','m','p','l','d'};
        MergeSort(characters);
        foreach(char n in characters)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();




        double[] digits = {1.1,65.3,93.9,55.5,3.5,6.9};
        MergeSort(digits);
        foreach(double n in digits)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine();

    }

    public static int flag =0;

    public static void MergeSort<T>(T[] elements) where T:IComparable<T>
    {
        T[] temp = new T[elements.Length];
        Algorithm(elements,temp,0,elements.Length-1);
        
    }

    public static void Algorithm<T>(T[] elements,T[] temp,int left,int right) where T:IComparable<T>
    {
        if(left<right)
        {
            int mid = (left+right)/2;
            Algorithm(elements,temp,left,mid);
            Algorithm(elements,temp,mid+1,right); 
            MergeSort(elements,temp,left,mid,right);
        }

    }

    public static void MergeSort<T>(T[]elements,T[] temp,int left,int mid,int right) where T:IComparable<T>
    {
        int i=left;
        int j=mid+1;

        int k=left;

        while (i<=mid && j<=right)
        {
            flag++;
            if(elements[i].CompareTo(elements[j])<0)
            {
                temp[k]=elements[i];
                i++;
            }
            else
            {
                temp[k]=elements[j];
                j++;
            }
            k++;
        }
        while(i<=mid)
        {
            flag++;
            temp[k]=elements[i];
            i++;
            k++;
        }
        while(j<=right)
        {
            flag++;
            temp[k]=elements[j];
            j++;
            k++;
        }
        for(i=left;i<=right;i++)
        {
            elements[i] = temp[i];
        }
    }
}