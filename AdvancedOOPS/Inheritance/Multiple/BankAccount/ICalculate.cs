using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public interface ICalculate
    {
        public double Deposit(double amount);
        public double Withdraw(double amount);
        public double BalanceCheck();


    }
}
