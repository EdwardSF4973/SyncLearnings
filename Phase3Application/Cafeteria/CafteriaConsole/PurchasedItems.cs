using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafteriaConsole
{
    public class PurchasedItems
    {   
        private static int s_purchaseID = 5000;
        public string PurchaseID { get; set; }

        public string CartID { get; set; }
        public string BookingID { get; set; }
        public string FoodID { get; set; }

        public int PurchaseCount { get; set; }

        public double PriceOfCart { get; set; }

        public PurchasedItems(){}

        public PurchasedItems(string cartID,string bookinID,string foodID,int pC,double pOC)
        {
            PurchaseID = $"PRID{++s_purchaseID}";
            CartID=cartID;
            FoodID = foodID;
            BookingID = bookinID;
            PurchaseCount=pC;
            PriceOfCart=pOC;

        }
        
    }
}
