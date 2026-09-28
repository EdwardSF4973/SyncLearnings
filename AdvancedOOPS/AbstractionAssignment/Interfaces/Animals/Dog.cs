using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : IAnimals
    {
        public string Name { get; set; }

        public string Habitat { get; set; }

        public string EatingHabitat { get; set; }

        public Dog(){}

        public Dog(string name,string habitat,string eating)
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