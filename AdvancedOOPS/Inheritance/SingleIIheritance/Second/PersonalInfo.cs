using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Second
{
    public class PersonalInfo
    {
        private static int s_userID = 100;
        public string UserID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string PhoneNumber { get; set; }

        public string MailID { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public PersonalInfo(){}

        public PersonalInfo(string name, string fatherName, string phoneNumber, string mailID,DateTime dob, string gender)
        {
            UserID = $"UID{++s_userID}";
            Name = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            MailID= mailID;
            DOB = dob;
            Gender = gender;

        }

        public PersonalInfo(string userID,string name, string fatherName, string phoneNumber, string mailID,DateTime dob, string gender)
        {
            UserID = userID;
            Name = name;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            MailID= mailID;
            DOB = dob;
            Gender = gender;
        }
        public string DisplayPersonal()
        {
            return $"UserID : {UserID}, Name: {Name}, FahterName : {FatherName}, PhoneNumber : {PhoneNumber}, MailID : {MailID}, Date Of Birth{DOB},Gender : {Gender}";
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