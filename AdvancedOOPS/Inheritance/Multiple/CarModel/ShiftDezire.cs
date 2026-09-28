using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class ShiftDezire : Car,IBrand
    {
        public int MakingID { get; set; }

        public int EngineNumber { get; set; }

        public int ChasisNumber { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public ShiftDezire(int makingID,int engineNumber, int chasisNumber,string brandName, string modelName,string fuelType,int numberOfSeats,string color,int tankCapacity,int numberofKm) : base(fuelType,numberOfSeats,color,tankCapacity,numberofKm)
        {
            MakingID = makingID;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            BrandName = brandName;
            ModelName= modelName;
        }
        public string Display()
        {
            return $"MakingID : {MakingID}, EngineNumber : {EngineNumber}, ChasisNumber : {ChasisNumber}\nBrandName : {BrandName}, ModelName : {ModelName}\n{DisplayCar()}\nMilage : {CalculateMilage()}";
        }
    }
}

