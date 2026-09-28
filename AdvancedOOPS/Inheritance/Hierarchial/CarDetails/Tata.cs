using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDetails
{
    public class Tata : CarInfo
    {
        private static int s_carModelnumber = 5000;

        public int CarModelNumber { get; set; }

        public string CarModelName { get; set; }

        public Tata(){}

        public Tata(string carModelName,int rcBookNumber,int engineNumber, int chasisNumber,  int tankCapacity, int noOfSeats,int noOfKmsDriven,string dop):base(rcBookNumber,engineNumber,chasisNumber,tankCapacity,noOfSeats,noOfKmsDriven,dop)
        {
            CarModelNumber = ++s_carModelnumber;
            CarModelName = carModelName;
        }
    }
}
/*
3.	Create application for car details and create 2 objects each for tata and suzuki:

Class CarInfo:
Properties: RCBookNumber, EngineNumber, ChasisNumber, Milage, Tank Capacity, NumberOfSeats, NumberOfKmDriven, DateOfPurchase.
Method:  1.	CalculateMilage – Ask tank quantity of petrol filled and km driven. Based on that calculate milage

Class Tata inherit CarInfo
Property: CarModelNumber, CarModelName

Class Suzuki inherit carinfo
Property: CarModelNumber, CarModelName

Requirement: Need to create 2 objects each for the above classes (ID’s are auto incremented) and must display the details, calculate milage of each cars are display milages in Program.cs

*/