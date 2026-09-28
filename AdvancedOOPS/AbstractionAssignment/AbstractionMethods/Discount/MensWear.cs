using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount
{
    public class MensWear : Dress
    {
        public override int DressID { get; set; }
        public override int Price { get; set; }

        public override string DressType{get; set;}
        public override string DressName{get; set;}

        public MensWear(int dressID,int price,string dressType,string dressName)
        {
            DressID = dressID;
            DressType = dressType;
            DressName = dressName;
            Price = price;
        }

        public override void UpdateDressInfo(string a)
        {
           DressName = a;
        }
        public override void DisplayBill()
        {
            System.Console.WriteLine($"DressName : {DressName}, Price : {Price}, DressType : {DressType}");
        }
    }
    
}