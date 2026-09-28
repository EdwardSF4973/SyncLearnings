using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class BirthRegistration
    {
        private static int s_birthRegistrationID =0;

        public int BirthRegistrationID { get;  }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string RegistrationDate { get; set; }

        public string BirthDate { get; set; }
        public string Gender { get; set; }


        public BirthRegistration()
        {
            

        }

        public BirthRegistration(string name, string fatherName, string registrationDate, string birthDate, string gender)
        {
            s_birthRegistrationID++;
            BirthRegistrationID = s_birthRegistrationID;
            Name = name;
            FatherName = fatherName;
            RegistrationDate = registrationDate;
            BirthDate = birthDate;
            Gender = gender;
        }

        public BirthRegistration(int birthRegistrationID,string name, string fatherName, string registrationDate, string birthDate, string gender)
        {
            
            BirthRegistrationID = birthRegistrationID;
            Name = name;
            FatherName = fatherName;
            RegistrationDate = registrationDate;
            BirthDate = birthDate;
            Gender = gender;
        }

        public string DisplayBirthRegistration()
        {
            return $"Birth Registration ID: {BirthRegistrationID}, Name: {Name}, FatherName: {FatherName}, RegistrationID: {RegistrationDate}, BirthDate: {BirthDate}, Gender: {Gender}";
        }
    }
}