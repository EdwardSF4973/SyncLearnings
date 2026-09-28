using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace Animals
{
    public class Duck : IAnimals
    {
        
        public string Name { get; set; }

        public string Habitat { get; set; }

        public string EatingHabitat { get; set; }

        public Duck(){}

        public Duck(string name,string habitat,string eating)
        {
            Name = name;
            Habitat = habitat;
            EatingHabitat = eating;
        }

        public string Display()
        {
            return $"Name : {Name}, Habitat : {Habitat}, EatingHabitat : {EatingHabitat}";
        }
    }
}