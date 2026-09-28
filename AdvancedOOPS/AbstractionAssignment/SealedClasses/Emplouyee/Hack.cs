using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emplouyee
{
    public class Hack : EmployeeInfo
    {
        public string StoreUSerID { get; set; }

        public string StorePassword { get; set; }

        public Hack(){}

        public Hack(string storeUserID,string storePassword)
        {
            StorePassword=storePassword;
            StoreUSerID=storeUserID;
        }
        
        public void UpdateStorePassword(string a)
        {
            StorePassword=a;
        }
    }
}
