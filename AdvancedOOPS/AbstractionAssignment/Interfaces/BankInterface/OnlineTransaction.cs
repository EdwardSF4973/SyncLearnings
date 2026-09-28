using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BankInterface
{
    public class OnlineTransaction:ITransaction
    {
        public int TransactionID { get; set; }

        public string DateOfPurchase { get; set; }

        public double TotalAmount { get; set; }

        public List<Purchase> onlineTransactions = new List<Purchase>();

        public  double CalculateTotalAmount()
        {
            double total = 0;
            foreach(Purchase record in onlineTransactions)
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
/*
Create an application for transaction manipulation

Interface ITransaction
Property :  TotalAmount
Method: CalculateAmount, DisplayBill

Class Purchase
Property: Material ID, Name, Quantity, Amount

Class OnlineTransaction inherit ITransaction
Property:  TransactionID, List<Purchase>, DateOfPurchase
Method: CalculateTotalAmount

Class OfflineTransaction inherit ITransaction
Property:  TransactionID, List<Purchase>, DateOfPurchase
Method: CalculateTotalAmount

Requirement : Create one online transaction object, and one offline transaction object and provide values for purchase list. 
Calculate total amount by manipulating purchase list. Display the bill.


*/