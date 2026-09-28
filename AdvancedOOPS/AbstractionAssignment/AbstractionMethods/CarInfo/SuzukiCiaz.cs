using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public class SuzukiCiaz:Car
    {
        public string CarName { get; set; }

        public SuzukiCiaz(string carName,string enginetype,double price,string cartype):base(enginetype,price,cartype)
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