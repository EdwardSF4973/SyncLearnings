using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CafteriaConsole
{
    public class FoodDetails
    {
        private static int s_foodID=2000;

        public string FoodID { get; set; }

        public string FoodName { get; set; }

        public int QuantityAvailable { get; set; }

        public double PricePerQuantity { get; set; }

        public FoodDetails(){}

        public FoodDetails(string foodName,int qunA,double ppq)
        {
            FoodID = $"PID{--s_foodID}";
            FoodName = foodName;
            QuantityAvailable=qunA;
            PricePerQuantity=ppq;
        }
    }
}
