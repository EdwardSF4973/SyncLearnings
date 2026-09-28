using System;
using System.Linq;
using System.Collections.Generic;

namespace Sorted;

class Program{
    public static void Main(string[] args){
         List<string> cities = new List<string> (){
            "ABU DHABI",
            "AMSTERDAM",
            "ROME",
            "PARIS",
            "CALIFORNIA",
            "LONDON",
            "NEW DELHI",
            "ZURICH",
            "NAIROBI"
         };

        var sorted = cities.OrderBy(city => city.Length).ThenBy(city => city).ToList();

        if(sorted.Count!=0)
        {
            System.Console.WriteLine($"Cities -- {string.Join(",",sorted)}");
        }

    }
}