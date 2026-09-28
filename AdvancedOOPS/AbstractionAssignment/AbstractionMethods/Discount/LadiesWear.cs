using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount
{
    public class LadiesWear : Dress
    {
        public override int DressID { get; set; }
        public override int Price { get; set; }

        public override string DressType{get; set;}
        public override string DressName{get; set;}

        public LadiesWear(int dressID,int price,string dressType,string dressName)
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
/*
2.	Create an application that calculate discount in shop

Abstract Class Dress:
Abstract Properties: DressID, DressType -> (Ladieswear, menswear, childrenswear), DressName, Price
Abstract Methods: UpdateDressInfo, DisplayBill

Class Ladieswear:
Overridden Methods: UpdateDressInfo, DisplayBill -> calculate 20% discount and display the bil

Class Menswear:
Overridden Methods: UpdateDressInfo, DisplayBill -> calculate 30% discount and display the bill

Requirement: Create objects for ladies wear and mens wear, use getdress info to get dress details and displayinfo to display the bill.

*/