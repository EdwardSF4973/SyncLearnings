using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class Car 
    {
        public string FuelType { get; set; }  

        public int NumberOfSeats { get; set; }

        public string Color { get; set; }

        public int TankCapacity { get; set; }

        public int NumberOfKmDriven { get; set; }


        public Car(){}

        public Car(string fuelType,int numberOfSeats,string color,int tankCapacity,int numberofKm)
        {
            FuelType = fuelType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberofKm;

        }

        public double CalculateMilage()
        {
            return NumberOfKmDriven/TankCapacity;
        }

        public string DisplayCar()
        {
            return $"FuelType : {FuelType}, Number Of Seats : {NumberOfSeats}, Color : {Color}, TankCapacity : {TankCapacity}\nNumber of Kms Driven : {NumberOfKmDriven}\n";
        }
    }
}

