using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodzConsole
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private double _balance;

        private static int s_customerID= 1000;

        private string _customerID;

        public string CustomerID { get{return _customerID;} set{_customerID=value;s_customerID=int.Parse(value.Remove(0,3));} }

        public double WalletBalance { get{return _balance;} set{_balance=value;} }

        public CustomerDetails(){}

        public CustomerDetails(double balance,string cusName,string faName,GenderDetails gender,string mobileNumber,string dob,string mailID):base(cusName,faName,gender,mobileNumber,dob,mailID)
        {
            CustomerID = $"CID{++s_customerID}";
            _balance = balance;
        }

        public CustomerDetails(string customerID,double balance,string cusName,string faName,GenderDetails gender,string mobileNumber,string dob,string mailID):base(cusName,faName,gender,mobileNumber,dob,mailID)
        {
            CustomerID = customerID;
            _balance = balance;
        }

        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }
    }
}
/*
CustomerDetails Class: Inherits PersonalDetails, IBalance: 

Field: 
a.	_balance (Private field) 

Properties: 
a.	CustomerID (Auto Increment – CID1000) 
b.	WalletBalance

Methods: 
a.	WalletRecharge: Get the recharge amount through parameters and update wallet balance of the current user. 
b.	DeductBalance: Get the deducted amount through parameters and update wallet balance of the current user. 

*/