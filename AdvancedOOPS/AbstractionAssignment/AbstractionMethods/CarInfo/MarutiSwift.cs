using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public class MarutiSwift : Car
    {
        public string CarName { get; set; }

        public MarutiSwift(string carName,string enginetype,double price,string cartype):base(enginetype,price,cartype)
        {
            CarName = carName;
        }
        
        public override void GetEngineType()
        {
            System.Console.WriteLine($"Car Type: {CarType}");
        }
        public override void GetNoOfSeats()
        {
            System.Console.WriteLine($"NOOFSEARTS : {NoOfSeats}");
        }
        public override void GetPrice()
        {
            System.Console.WriteLine($"Price : {Price}");
        }
        public override void GetCarType()
        {
            System.Console.WriteLine($"CarType : {CarType}");
        }
    }
}
/*
1.	Create an application for Car Information 

Abstract Class Car:
Field: No. of wheels=4, No.Of.Doors = 4, 
Properties: Engine type -Petrol,diesel,cng, No.Of.Seats, Price, CarType -hatchback, sedan,  suv
Abstract methods: get engine type, get no. of seats, get price, get car type

Class MaruthiSwift : inherit Cars
override methods: get engine type, get no. of seats, get price, get car type

class SuzukiCiaz: inherit Cars
override methods: get engine type, get no. of seats, get price, get car type

Requirement: Create objects for maruthi swift and Suzuki ciaz and call abstract methods to get information and display the details.

*/