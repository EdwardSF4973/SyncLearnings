using System;
using System.Collections.Concurrent;

namespace Phase;

class Program
{
    public static void Main(string [] args)
    {
        /*int basenum = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());

        int result =1;

        for(int i=0;i<power;i++)
        {
            result = result * basenum;
        }
        Console.WriteLine(result);*/

        /*DateTime input = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);

        int day = input.Day;
        

        string dayname = day.DayOfWeek;

        Console.WriteLine($"The day of the week for {input} is {day}");*/

        /*int n = Convert.ToInt32(Console.ReadLine());

        for(int i =1;i<=n;i++)
        {
            for(int j=1;j<=n;j++)
            {
                Console.Write(j);

            }
            Console.WriteLine();
        }*/

        /*int n = DateTime.DaysInMonth(2013,8);
        Console.Write(n);*/

        /*int columns = Convert.ToInt32(Console.ReadLine());
        int rows = Convert.ToInt32(Console.ReadLine());

        for(int i=0;i<columns;i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for(int i =2;i<rows;i++)
        {
            
            Console.Write("*");
            Console.WriteLine();
            
        }
        for(int i =2;i<rows;i++)
        {
            for(int j =0;j<rows;j++)
            {
                Console.Write("*");
                Console.WriteLine();
            }
        }

        for(int i=0;i<columns;i++)
        {
            Console.Write("*");
        }*/

        //date time
        /*DateTime day = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        //array size
        int n = Convert.ToInt32(Console.ReadLine());
        //Creating and array
        DateTime [] dts = new DateTime[n];
        //bool isdate = false;

        for(int i=0;i<n;i++)
        {
            dts[i]=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        }
        

        if(day.ToLongDateString().Contains("Sunday")||day.ToLongDateString().Contains("Saturday"))
        {
            Console.WriteLine("Holiday:-)");
        }
        else{
            for(int i=0;i<n;i++)
            {
                if(dts[i].ToLongDateString().Contains("Sunday")||day.ToLongDateString().Contains("Saturday"))
                {
                    Console.WriteLine("Holiday:-)");
                }
                else{
                    Console.WriteLine("Not an Holiday:-(" );
                }
            }
        }*/

        //getting the length of the ground
        /*double size = Convert.ToDouble(Console.ReadLine());

        double groundSize = size * size;

        //size of the tile
        double tilew = Convert.ToDouble(Console.ReadLine());
        double tilel = Convert.ToDouble(Console.ReadLine());
        double tilesize = tilew * tilel;

        //size of chair
        double sizem = Convert.ToDouble(Console.ReadLine());
        double sizel = Convert.ToDouble(Console.ReadLine());
        double chairsize = sizem*sizel;

        double numberoftile = groundSize - chairsize;
        double totaltile = numberoftile/tilesize;
        //round the tile req
        double t  = Math.Round(totaltile,1);

        //calculating the time
        double timereq = Math.Round(t*0.2);

        //printing the line
        Console.WriteLine(t);
        Console.WriteLine(timereq);*/
        /*

        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=m;j++)
            {
                if(i==1 || i==n || j==1||j==m)
                {
                    Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine();
        }*/
        
        
        
        /*
        
        //date time
        DateTime day = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        //array size
        int n = Convert.ToInt32(Console.ReadLine());
        //Creating and array
        DateTime [] dts = new DateTime[n];
        bool isdate = false;

        for(int i=0;i<n;i++)
        {
            dts[i]=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        }
        

        if(day.ToLongDateString().Contains("Sunday")||day.ToLongDateString().Contains("Saturday"))
        {
            Console.WriteLine("Holiday:-)");
        }
        else
        {
            for(int i=0;i<n;i++)
            {
                if(dts[i].ToLongDateString().Contains("Sunday")||dts[i].ToLongDateString().Contains("Saturday"))
                {
                    isdate=true;
                    break;
                }
                else
                {
                   isdate=false; 
                }
            
            }
            if(isdate)
            {
                Console.WriteLine("Holiday:-)");
            }
            else{
                Console.WriteLine("Not an Holiday:-(" );
            }
        }
        */


        ///Complex 5th sum
        ///

        /*DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        DateTime now = DateTime.Now;

        TimeSpan diff = now - dob;

        int days = (int)diff.TotalDays;

        int hours = (int)diff.TotalHours;

        int minutes  = (int)diff.TotalMinutes;

        int years = (int) now.Year-dob.Year; 

        Console.WriteLine($"{days}\n{hours}\n{minutes}\n{years}\n{dob.DayOfWeek}");*/
        /*double basenum = Convert.ToDouble(Console.ReadLine());
        
        int nterm = Convert.ToInt32(Console.ReadLine());

        //sum
        double sum = 0;

        for(int i=0;i<nterm;i++)
        {
            double v1 = Power(basenum,i);
            double v2 = Fact(basenum,i);

            double div = (double)v1/v2;
            sum = sum+div;
        }

        Console.WriteLine(sum);*/

        //int basenum = Convert.ToInt32(Console.ReadLine);
        //int n = Convert.ToInt32(Console.ReadLine);

























    int basenum = Convert.ToInt32(Console.ReadLine());
    int nterms = Convert.ToInt32(Console.ReadLine());

    double sum =0;

    for(int i =0;i<nterms;i++)
    {
        int v = Fact(i);
        double p = Math.Pow(basenum,i);
        double fg = (double)p/v;
        sum = sum+fg;
        
    }
    Console.WriteLine(Math.Round(sum,2));























    }
    public static int Fact(int n)
    {
        int fat = 1;
        while(n>0)
        {
            fat = fat*n;
            n = n-1;
        }
        return fat;
    }
    /*public static int Fact(int number)
    {
        int result = 1; 
        for(int i=1;i<=number;i++)
        {

        }
        return 0;
    }*/
    /*static double Power(double basenum,int n)
    {
        if(n==0)
        {
            return 1;
        }
        else if(n==1)
        {
            return basenum;
        }
        else
        {
            double m =basenum;
            
            for(int i=0;i<m;i++)
            {
                m = m * basenum;

            }
            return m;
        }
    }
    //method for factorial
    static double Fact(double basenum,int n)
    {
        if(n==0&&n==1)
        {
            return 1;
        }
        else
        {
            double m = 1;

            for(int i=1;i<=n;i++)
            {
                m= m*i;
            }
            return m;
        }
    }*/
}
/*
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //getting the sizes
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        //creating the matrix
        int [,] firstAr = new int[n,m];
        int [,] secondAr = new int[m,n];

        //getting elements for first array
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                firstAr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        //getting the elements for second array
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                secondAr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }

        //creating result array
        
    }
}*/
            