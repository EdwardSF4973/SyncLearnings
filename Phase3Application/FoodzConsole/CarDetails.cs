using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodzConsole
{
    public class CarDetails
    {
        private static int s_cartID = 4000;

        private string _cartID;

        public string CartID { get{return _cartID;} set{_cartID=value;s_cartID=int.Parse(value.Remove(0,4));} }


        public string CustomerID { get; set; }

        public string FoodID { get; set; }

        public int PurchaseCount { get; set; }

        public double PriceOfCart { get; set; }

        public CarDetails(){}

        public CarDetails(string cusID,string foodID,int pC,double pOC)
        {
            CartID = $"CRID{++s_cartID}";
            CustomerID=cusID;
            FoodID = foodID;
            PurchaseCount=pC;
            PriceOfCart=pOC;

        }
    }
}
