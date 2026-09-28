using System;

namespace Arrays;

class Program
{
    public static void Main(string[] args)
    {
        //declaring variables and data types
        string [] names = new string[5];
        //bool var to ousiude the loop
        //j for displaying the index of found name

        bool isFind = false;
        bool isFind1 = false;
        int j = 0;
        //for loop
        System.Console.WriteLine("For loop "); 
        for(int i = 0; i<names.Length;i++)
        {
            System.Console.Write("Enter a name"+i);
            names[i] = System.Console.ReadLine();
        }
        for(int i = 0;i<names.Length;i++)
        {
            System.Console.WriteLine(names[i]);
        }
        System.Console.WriteLine("Enter a name to be searched");
        string searchName = System.Console.ReadLine();
        //searchin the looop
        for(int i=0;i<names.Length;i++)
        {
            if(names[i]==searchName )
            {
                isFind = true;
                j = i;
            }
        }
        //to display the final result for loop
        if(isFind)
        {
            System.Console.WriteLine($"This name is present in the array at position {j}");
        }
        else
        {
            System.Console.WriteLine("The name not present");
        }
        //foreach
        System.Console.WriteLine("ForEach"); 
        //for each to print each name in array
        foreach (string nam in names)
        {
            System.Console.WriteLine(nam);  
        }
        //getting name from user to be searched
        System.Console.WriteLine("Enter a name to be searched");
        string searchName1 = System.Console.ReadLine();
        //usinf if inside a for each to find the name

        foreach (string nam in names)
        {
            if(nam==searchName1)
            {
                //convert the false to true
                isFind1 = true;
            }
        }
        //to display the final result
        if(isFind1)
        {
            //dispaly the name if it found
            System.Console.WriteLine("This name is present in the array "); 
        }
        else
        {
            //display no name found
            System.Console.WriteLine("The name not present");
        }  

    }
}