using System;

namespace BankAccount;

class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount person1 = new(111,AccounType.Current,"Edward","Edward","19/11/2002",74126,52);
        System.Console.WriteLine(person1.Deposit(1000));
        System.Console.WriteLine(person1.Details());
        System.Console.WriteLine(person1.Withdraw(250));
        System.Console.WriteLine();
        System.Console.WriteLine(person1.Details());
        
    }
}


/*
1.	Create bank account application to handle bank account manipulation create 2 accounts in each 
    savings and recurring deposit classes. And manipulate credit, debit, show balance operations. 

Class PersonalInfo:
Properties: Name, Gender, DOB, phone, mobile, PAN number
Method: Get Details

Interface ICalculate:
Methods: Deposit, Withdraw, Balance check

Class SavingAccount: Inherit PersonalInfo, ICalculate
Properties: AccountID, AccountType->Savings, Balance 
Methods: Deposit, Withdraw, Balance check

Class RecurringDeposit: Inherit PersonalInfo, ICalculate
Properties: AccounID, AccountType->Savings, Balance
Methods: Deposit, Withdraw, Balance check

Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details and have to perform deposit. Withdraw and have to show balances.

*/