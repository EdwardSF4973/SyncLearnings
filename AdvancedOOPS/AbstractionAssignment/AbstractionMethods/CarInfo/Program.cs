using System;

namespace CarInfo;

class Program
{
    public static void Main(string[] args)
    {
        MarutiSwift car1 = new("Edward","Fast",500000,"Sedan");
        car1.GetCarType();
        car1.GetPrice();
        car1.GetNoOfSeats();
        car1.GetEngineType();

        SuzukiCiaz car2 = new("Subin","HyperFast",502222,"Sedan");
        car2.GetCarType();
        car2.GetPrice();
        car2.GetNoOfSeats();
        car2.GetEngineType();


    }
}
