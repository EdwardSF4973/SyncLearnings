using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankInterface;

namespace  BankingInterface
{
    public class OfflineTransaction : ITransaction
    {
         public int TransactionID { get; set; }

        public string DateOfPurchase { get; set; }

        public double TotalAmount { get; set; }

        public List<Purchase> offlineTransactions = new List<Purchase>();

        public  double CalculateTotalAmount()
        {
            double total = 0;
            foreach(Purchase record in offlineTransactions)
            {
                total += record.Amount;
            }
            TotalAmount = total;
            return TotalAmount;
            
            
        }

        public string DisplayBill()
        {
            return $"Your Total Bill is {TotalAmount}";
        }
    }
}