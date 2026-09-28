using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankInterface
{
    public class Purchase
    {
        public int MaterialID { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public double Amount { get; set; }

        public Purchase(){}

        public Purchase(int matID,string name,int quan,int amo)
        {
            MaterialID=matID;
            Name=name;
            Quantity=quan;
            Amount=amo;
        }
    }
}
