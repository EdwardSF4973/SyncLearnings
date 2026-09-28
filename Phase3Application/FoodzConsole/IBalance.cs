using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodzConsole
{
    public interface IBalance
    {
        

        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);


    }
}
