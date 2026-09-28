using System;

namespace Bank;

class Program
{
    public static void Main(string[] args)
    {

        SavingsAccount save1 = new(123, AccountType.Current, "edwe", 852, "chen", 874, 54, 541, "Edwa", "male", "19112002", "7896214");
        System.Console.WriteLine(save1.BalanceCheck());
        System.Console.WriteLine("Enter the amount to be deposited");
        double amount = double.Parse(Console.ReadLine());
        System.Console.WriteLine(save1.Deposit(amount));
        System.Console.WriteLine("\n\nBalance");
        System.Console.WriteLine(save1.BalanceCheck());
        System.Console.WriteLine("Enter the amount to be Withdraw");
        amount = double.Parse(Console.ReadLine());
        System.Console.WriteLine(save1.Withdraw(amount));
        System.Console.WriteLine("\n\nBalance");
        System.Console.WriteLine(save1.BalanceCheck());
    }
}
/*
2.	Create an application for banking application manipulation create 2 object for saving account and using 
deposite withdraw and check balance method.

Class PersonalInfo:
Properties: Name, Gender, DOB, phone, mobile

Class IDInfo: inherit PersonalInfo
Properties: VoterID, AadharID, PAN number

Interface ICalculate:
Methods: Deposit, Withdraw, Balance check

Interface IBankInfo:
Properties: BankName, IFSC, Branch

Class SavingAccount: Inherit IDInfo, ICalculate, IBankInfo
Properties: AccountNumber, AccountType->Savings, Balance 
Methods: Deposit, Withdraw, BalanceCheck

*/