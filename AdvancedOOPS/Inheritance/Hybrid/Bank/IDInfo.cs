using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public class IDInfo : PersonalInfo
    {
        public int VoterID { get; set; }

        public int AadharID { get; set; }

        public int PanNumber { get; set; }

        public IDInfo(int voterID,int aadharID,int panNumber,string name,string gender,string dob,string phone):base(name,gender,dob,phone)
        {
            VoterID =voterID;
            AadharID = aadharID;
            PanNumber = panNumber;
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