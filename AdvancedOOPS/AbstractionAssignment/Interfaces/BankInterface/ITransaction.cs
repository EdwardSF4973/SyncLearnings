using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankInterface
{
    public interface ITransaction
    {
        public double TotalAmount { get; set; }   

        public double CalculateTotalAmount();

        public string DisplayBill();
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