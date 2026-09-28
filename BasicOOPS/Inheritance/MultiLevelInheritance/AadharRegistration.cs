using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class AadharRegistration : BirthRegistration
    {
        //name
        //father nameprivate 
        private static int s_aadharRegistrationID =0;

        public int AadharRegistrationID { get; }

        public string Address { get; set; }

        public AadharRegistration(){}

        public AadharRegistration(int birthRegistrationID, string name,string fatherName, string registrationDate, string birthDate, string gender, string address): base(birthRegistrationID,name,fatherName,registrationDate,birthDate,gender)
        {
            s_aadharRegistrationID++;
            AadharRegistrationID=s_aadharRegistrationID;
            Address = address;
        }

        public AadharRegistration(int birthRegistrationID,int aadharID,string name, string fatherName, string registrationDate,string birthDate,string gender,string address) : base(birthRegistrationID,name,fatherName,registrationDate,birthDate,gender)
        {
            AadharRegistrationID = aadharID;
            Address = address;
            
        }
        
        public string DisplayAadharRegistration()
        {
            return $"Aadhar Registration ID: {AadharRegistrationID},{DisplayBirthRegistration()},Address: {Address}";
        }
    }
}