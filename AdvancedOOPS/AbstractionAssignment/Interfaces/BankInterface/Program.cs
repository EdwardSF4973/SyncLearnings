using System;
using System.Collections.Generic;
using BankingInterface;

namespace BankInterface;

class Program
{
    public static void Main(string[] args)
    {

        OnlineTransaction person1 = new();
        Purchase purchase1 = new(555,"Edward",5,500);
        Purchase purchase2 = new(555,"Edward",5,100);
        person1.onlineTransactions.AddRange( new List<Purchase>(){purchase1,purchase2});
        System.Console.WriteLine(person1.CalculateTotalAmount());
        System.Console.WriteLine(person1.DisplayBill());



        OfflineTransaction person2 = new();
        Purchase purchase3 = new(555,"Edward",5,1000);
        Purchase purchase4 = new(555,"Edward",5,100);
        person2.offlineTransactions.AddRange( new List<Purchase>(){purchase3,purchase4});
        System.Console.WriteLine(person2.CalculateTotalAmount());
        System.Console.WriteLine(person2.DisplayBill());

        
    }
}

