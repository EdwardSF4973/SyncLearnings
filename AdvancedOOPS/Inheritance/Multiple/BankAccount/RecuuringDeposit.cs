using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class RecuuringDeposit : PersonalInfo,ICalculate
    {
        public int AccountID { get; set; }

        public AccounType AccType { get; set; }

        private double _balance = 0;

        public double Balance { get{return _balance;} }

        public RecuuringDeposit(int accountID,AccounType accType,string name,string gender,string dob,int phone,int panNumber) : base(name,gender,dob,phone,panNumber)
        {
            AccountID = accountID;
            AccType = accType;
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
        public string Details()
        {
            return $"AccountID : {AccountID}, AccountType : {AccType} \n {GetDetails()}\nBalance : {Balance} ";
        }
    }
}