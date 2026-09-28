using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount
{
    public abstract class Dress
    {
        public abstract int DressID { get; set; }
        public abstract int Price { get; set; }

        public abstract string DressType{get; set;}
        public abstract string DressName{get; set;}

        public Dress(){}

        public abstract void UpdateDressInfo(string a);

        public abstract void DisplayBill();
    }
}
