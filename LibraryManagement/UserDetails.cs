using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    /// <summary>
    /// Class UserDetails <see cref="UserDetails"/> <see href="www.syncfusion.com"/>  used for creating user 
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// Field s_userID used for auto incrementing and providing common ID scheme for all users
        /// </summary>
        public static int s_userID = 3000;
        /// <summary>
        /// Property UserID used to provide user id for an instance of <see cref="UserDetails"/> 
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// Property UserName used to provide name for an instance of <see cref="UserDeatils"/> 
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// Property Gender  used to provide gender for an instance of <see cref="UserDeatils"/> 
        /// </summary>
        /// <value></value>
        public GenderClassification Gender { get; set; }
        /// <summary>
        /// Property Department  used to provide department for an instance of <see cref="UserDeatils"/> 
        /// </summary>
        /// <value></value>
        public DepartmentClassification Department { get; set; }
        /// <summary>
        /// Property MobileNumber  used to provide mobilenumber for an instance of <see cref="UserDeatils"/> 
        /// </summary>
        /// <value></value>
        public long MobileNumber { get; set; }
        /// <summary>
        /// Property MailID  used to provide mailID for an instance of <see cref="UserDeatils"/> 
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        /// <summary>
        /// field s_balance used to provide WalletBalance for an instance of <see cref="UserDeatils"/> 
        /// </summary>
        /// <value></value>
        public static double s_balance;
        /// <summary>
        /// Property WalletBalance used to provide walletBalance for an instance of <see cref="UserDeatils"/> 
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }
        //Parameterized
        /// <summary>
        /// Used to initialize properties using parameter values for an instance of <see cref="UserDeatils"/>
        /// <use href = "www.syncfusion.com"/>
        /// </summary>
        /// <param name="username">Parameter Name is a string, It used to assign values to property UserName</param>
        /// <param name="gender">Parameter gender is a string, It is a enum GenderClassification<see cref="GenderClassification"/>,
        /// It used to assign values to property </param>
        /// <param name="department">Parameter department is a string, It is a enum DepartmentClasssification<see cref="DepartmentClassification"/>,
        /// It used to assign values to property </param> 
        /// <param name="phonenumber">Parameter phonenumber is a long, It used to assign values to property MobileNumber</param>
        /// <param name="mailID">Parameter mailID is a string, It used to assign values to property MailID</param>
        /// <param name="walletBalance">Parameter walletBalance is a integer, It used to assign values to field s_balance</param>
        public UserDetails(string username, GenderClassification gender, DepartmentClassification department, long phonenumber, string mailID, double walletBalance)
        {
            UserID = $"SF{++s_userID}";
            UserName = username;
            Gender = gender;
            Department = department;
            MobileNumber = phonenumber;
            MailID = mailID;
            s_balance = walletBalance;
        }
        //This method is used for wallet recharge which takes amount as input
        public void WalletRecharge(double amount)
        {
            WalletBalance += amount;
        }
        //This method is used for wallet recharge
        public void DeductBalance(double amount)
        {
            WalletBalance -= amount;
        }
    }
}