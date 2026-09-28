using System;

namespace CarDetails;

class Program
{
    public static void Main(string[] args)
    {
        Tata car1 = new("hht5",529,4562,854125,15,5,5000,",196545");
        System.Console.WriteLine(car1.CalculateMilage());

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