using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace CafteriaConsole
{
    public class PersonalDetails
    {
        /// <summary>
        /// This Property is store the customers Name.<see cref="PersonalDetails"/>
        /// </summary>
        /// <value>String</value>
        public string CustomerName { get; set; }

        public string FatherName { get; set; }

        public GenderDetails Gender { get; set; }

        public string MobileNumber { get; set; }

        public string DateOfBirth { get; set; }

        public string MailID { get; set; }

        public PersonalDetails(){}

        public PersonalDetails(string cusName,string faName,GenderDetails gender,string mobileNumber,string dob,string mailID)
        {
            CustomerName = cusName;
            FatherName = faName;
            Gender= gender;
            MobileNumber = mobileNumber;
            DateOfBirth=dob;
            MailID = mailID;
        }
        
    }
}
