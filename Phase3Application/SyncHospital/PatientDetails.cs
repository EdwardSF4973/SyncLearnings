using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class PatientDetails :PersonalDetails,ITransaction
    {
        private  double _walletBalance;

        private static int s_PatientID = 1000;

        public string PatientID{ get; set; }

        public double WalletBalance { get{return _walletBalance;} set{_walletBalance=value;} }


        public PatientDetails(string name,string fatherName,string phone,int age,Genders gender,string bloodGroup,double walletBalance):base(name,fatherName,gender,phone,age,bloodGroup)
        {
            PatientID = $"PID{++s_PatientID}";
            _walletBalance=walletBalance;

        }

        public void Recharge(double amount)
        {
            _walletBalance+=amount;
        }

        public void DeductBalance(double amount)
        {
            _walletBalance-=amount;
        }
    }
}