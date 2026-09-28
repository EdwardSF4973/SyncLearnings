using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emplouyee
{
    public sealed class EmployeeInfo
    {
        public string UserID { get; set; }

        public string Password { get; set; }

        private static int _keyInfo = 100;

        public string KeyInfo { get; set; }


        public EmployeeInfo(){}

        public EmployeeInfo(string userID,string password)
        {
            KeyInfo = $"KID{++_keyInfo}";
            UserID = userID;;
            Password = password;
        }

        public void UpdateKey(string key)
        {
            KeyInfo=key;
        }
        public void UpdateInfo(string a)
        {
            Password=a;
        }
    }
}