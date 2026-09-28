using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public abstract class Car
    {
        private static int _wheels = 4;
        private static int _doors = 4;

        public string EngineType { get; set; }

        public int NoOfSeats { get; set; }

        public double Price { get; set; }

        public string CarType { get; set; }


        public Car(){}

        public Car(string enginetype,double price,string cartype)
        {
            NoOfSeats = _wheels;
            EngineType = enginetype;
            Price=price;
            CarType=cartype;


        }
        public abstract void GetEngineType();
        public abstract void GetNoOfSeats();
        public abstract void GetPrice();
        public abstract void GetCarType();


    }
}
