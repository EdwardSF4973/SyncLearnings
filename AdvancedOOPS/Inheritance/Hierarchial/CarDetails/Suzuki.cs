using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDetails
{
    public class Suzuki : CarInfo
    {
        private static int s_carModelnumber = 21000;

        public int CarModelNumber { get; set; }

        public string CarModelName { get; set; }

        public Suzuki() { }

        public Suzuki(string carModelName, int rcBookNumber, int engineNumber, int chasisNumber, int tankCapacity, int noOfSeats, int noOfKmsDriven, string dop) : base(rcBookNumber, engineNumber,chasisNumber, tankCapacity, noOfSeats, noOfKmsDriven, dop)
        {
            CarModelNumber = ++s_carModelnumber;
            CarModelName = carModelName;
        }
    }
}