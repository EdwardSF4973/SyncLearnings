using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInfo
{
    public class PersonInfo
    {
        
        public int UserID { get; set; }

        public string Name { get; set; }

        public string DOB { get; set; }

        public int Phone { get; set; }

        public string Marital { get; set; }

        public PersonInfo(){}

        public PersonInfo(int userID,string name, string dob,int phone,string marital)
        {
            UserID = userID;
            Name = name;
            DOB = dob;
            Phone = phone;
            Marital = marital;
        }


    }
}
/*
1.	Create application for getting, storing  person’s details create two objects for register person

Class Personalnfo
Properties: UserID, Name, Gender, DOB, phone, Marital details – Married/single

Interface IFamilyInfo
Properties: FatherName, MotherName, HouseAddress, No.Of.Siblings   

Class RegisterPerson inherits Personalinfo, IFamilyInfo 
Properties: RegistrationID, DateOfRegistration

Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details.
*/