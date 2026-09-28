using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public class SavingsAccount :IDInfo,IBankInfo,ICalculate
    {
        public int AccountNumber { get; set; }

        public AccountType AccType { get; set; }

        public string BankName { get; set; }

        public int IFSC { get; set; }

        private double _balance = 0;

        public double Balance { get{return _balance;} }

        public string Branch { get; set; }

        public SavingsAccount(int accountNumber,AccountType type,string bankName,int ifsc,string branch,int voterID,int aadharID,int panNumber,string name,string gender,string dob,string phone):base(voterID,aadharID,panNumber,name,gender,dob,phone)
        {
            AccountNumber = accountNumber;
            AccType = type;
            BankName = bankName;
            IFSC = ifsc;
            Branch = branch;
        }
        public double Deposit(double amount)
        {
            _balance+=amount;
            return _balance;
        }
        public double Withdraw(double amount)
        {
            _balance-=amount;
            return _balance;
        }
        public double BalanceCheck()
        {
            return _balance;
        }



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