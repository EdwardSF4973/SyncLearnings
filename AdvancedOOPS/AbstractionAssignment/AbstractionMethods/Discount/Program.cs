using System;

namespace Discount;

class Program
{
    public static void Main(string[] args)
    {
        LadiesWear n = new(555,15,"Top","Dress");
        n.DisplayBill();
        n.UpdateDressInfo("Jeans");
        n.DisplayBill();

        MensWear m = new(455,500,"Shirt","US POLo");
        m.DisplayBill();
        m.UpdateDressInfo("Denim");
        m.DisplayBill();
    }
}
