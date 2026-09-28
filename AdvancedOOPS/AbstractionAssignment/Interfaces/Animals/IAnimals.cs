using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animals
{
    public interface IAnimals
    {
        public string Name { get; set; }

        public string Habitat { get; set; }

        public string EatingHabitat { get; set; }
    }
}
