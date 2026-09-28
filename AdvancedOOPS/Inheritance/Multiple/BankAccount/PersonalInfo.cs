using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string DOB { get; set; }

        public int Phone { get; set; }

        public int PanNumber { get; set; }

        public PersonalInfo(){}

        public PersonalInfo(string name,string gender,string dob,int phone,int panNumber)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            PanNumber = panNumber;
        }

        public string GetDetails()
        {
            return $"Name : {Name}, Gender : {Gender}, Date of Birth : {DOB}\nPhone : {Phone}, PanNumber : {PanNumber}";
        }
        
    }
}
