using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace exercis1;

class Program{
    public static void Main(string[] args){
        List<string> cities = new List<string>(){
            "ABU DHABI",
            "AMSTERDAM",
            "ROME",
            "MADURAI",
            "LONDON",
            "NEW DELHI",
            "MUMBAI",
            "NAIROBI"
        };

        System.Console.WriteLine("Enter the Starting Character:");
        char startChar = char.ToUpper(System.Console.ReadLine()[0]);

    
        System.Console.WriteLine("Enter the Ending Character:");
        char endChar = char.ToUpper(System.Console.ReadLine()[0]);


        var result = cities.Where(city => city.StartsWith(startChar.ToString(),StringComparison.OrdinalIgnoreCase) && city.EndsWith(endChar.ToString(),StringComparison.OrdinalIgnoreCase)).ToList();

        if(result.Count!=0)
        {
            System.Console.WriteLine($"Cities with start {startChar} and ends with {endChar}  -- {string.Join(",",result)}");
        }

        
    }

}