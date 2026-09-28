using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public interface ITransaction
    {
        

        public void Recharge(double amount);
        public void DeductBalance(double amount);
    }
}