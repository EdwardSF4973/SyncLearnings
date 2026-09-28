using System;

namespace Second 
{
    class Program
    {
        public static void Main(string[] args)
        {
            PersonalInfo person = new("edward","george","7305541054","ewdfgbhnjk","sadffs",new DateTime(2002,11,19),"Male");
            //System.Console.WriteLine(person.DisplayPersonal());

            AccountInfo account = new ("1234","cse",2000,"sda","edward","george","7305541054","ewdfgbhnjk",new DateTime(2002,11,19),"Male");
            //System.Console.WriteLine(account.DisplayAccountInfo());
            AccountInfo account1 = new ("123789","mech",3000,"sdfda","dayalan","logu","7305544gre1054","ewdfgregabhnjk",new DateTime(2002,10,09),"Female");
            AccountInfo account2 = new ("123632","ece",5000,"sdasg","flipkart","amazon","7305regf541054","ewdfgdrebhnjk",new DateTime(2002,12,10),"Male");
            System.Console.WriteLine($"before deposit {account.Balance}");
            System.Console.WriteLine($"during deposit{account.Deposit(250)}");
            System.Console.WriteLine($"after deposit {account.Balance}");

            System.Console.WriteLine($"\n\nbefore deposit {account.Balance}");
            System.Console.WriteLine($"during deposit{account.Withdraw(250)}");
            System.Console.WriteLine($"after deposit {account.Balance}");
        }
    }
}
/*
2.	Program to  Manipulate bank account details: 

Class PersonalInfo:
Properties: UserID, Name, FatherName, Phone, Mail, DOB, Gender

Class AccountInfo : Inherit PersonalInfo
Field : _balance
Properties:  AccountID, BranchName, IFSCCode, Balance
Methods: Deposit , Withdraw.

Requirement: Need to create inherited class and have to create objects (ID’s are auto incremented) for the each above two classes and have to use the deposit withdraw methods to add/ deduct balance and display the details in Program.cs
*/