using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Second
{
    public class AccountInfo : PersonalInfo
    {
        private  double _balance;

        private static int s_accountID;

        public string AccountID { get; set; }

        public string BranchName { get; set; }

        public string IFSCCode { get; set; }

        public double Balance { get{return _balance;}  }


        public AccountInfo(){}

        public AccountInfo(string branchName,string ifscCode, double balance,string userID, string name, string fatherName, string phoneNumber, string mailID, DateTime dob,string gender):base(name,fatherName,phoneNumber,mailID,dob,gender)
        {
            AccountID = $"AID{++s_accountID}";
            BranchName = branchName;
            IFSCCode = ifscCode;
            _balance = balance;
        }

        public string DisplayAccountInfo()
        {
            return $"AccountID : {AccountID}, BranchName: {BranchName}, IFSCCode: {IFSCCode},Balance: {Balance}, {DisplayPersonal()}";
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