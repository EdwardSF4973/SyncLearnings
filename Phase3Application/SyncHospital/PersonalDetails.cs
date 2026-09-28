
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHospital
{
    public class PersonalDetails
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Genders Gender { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public string BloodGroup { get; set; }

        public PersonalDetails(string name,string fatherName,Genders gender,string phone,int age,string bloodGroup)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Phone = phone;
            Age = age;
            BloodGroup = bloodGroup;

        }
        
    }
}
