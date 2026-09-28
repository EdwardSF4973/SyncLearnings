using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public interface IBankInfo
    {
        public string BankName { get; set; }

        public int IFSC { get; set; }

        public string Branch { get; set; }
        
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