using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDetails
{
    public class CarInfo
    {
        private static int s_rcBookNumber = 1000;
        public int RCBookNumber { get; set; }

        public int EngineNumber { get; set; }

        public int ChasisNumber { get; set; }

        public double Milage { get; set; }

        public int TankCapacity { get; set; }

        public int NumberOfSeats { get; set; }

        public int NumberOfKmDriven { get; set; }

        public string DateOfPurchase { get; set; }

        public CarInfo() {}

        public CarInfo(int engineNumber, int chasisNumber, int tankCapacity, int noOfSeats,int noOfKmsDriven,string dop)
        {
            RCBookNumber = ++s_rcBookNumber;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            TankCapacity = tankCapacity;
            NumberOfSeats = noOfSeats;
            NumberOfKmDriven = noOfKmsDriven;
            DateOfPurchase = dop;
        }
        public CarInfo(int rcBookNumber,int engineNumber, int chasisNumber, int tankCapacity, int noOfSeats,int noOfKmsDriven,string dop)
        {
            RCBookNumber = rcBookNumber;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            TankCapacity = tankCapacity;
            NumberOfSeats = noOfSeats;
            NumberOfKmDriven = noOfKmsDriven;
            DateOfPurchase = dop;
        }

        public double CalculateMilage()
        {
            Milage = (double)NumberOfKmDriven/TankCapacity;
            return Milage;

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