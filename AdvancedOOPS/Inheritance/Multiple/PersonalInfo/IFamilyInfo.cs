using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInfo
{
    public interface IFamilyInfo
    {
        public string FatherName { get; set; }  

        public string MotherName { get; set; }

        public string HouseAddress { get; set; }

        public int NoOfSibilings { get; set; }
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