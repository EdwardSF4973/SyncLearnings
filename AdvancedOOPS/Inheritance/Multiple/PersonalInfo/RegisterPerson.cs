using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInfo
{
    public class RegisterPerson : PersonInfo,IFamilyInfo
    {
        public int RegistrationID { get; set; }

        public string DateOfRegistration { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        public string HouseAddress { get; set; }

        public int NoOfSibilings { get; set; }

        public RegisterPerson(int registrationID,int userID, string dateOfRegistration,string fatherName,string motherName, string houseAddress,int noOfSibilings,string name, string dob,int phone,string marital):base(userID,name,dob,phone,marital)
        {
            RegistrationID=registrationID;
            DateOfRegistration = dateOfRegistration;
            FatherName = fatherName;
            MotherName = motherName;
            HouseAddress = houseAddress;
            NoOfSibilings = noOfSibilings;

        }

        public string Display()
        {
            return $"RegistrationID : {RegistrationID}, USerID : {UserID}\nName : {Name} , DateOfBirth : {DOB}\nFatherName : {FatherName} , MotherName : {MotherName}, NoOFSibilings : {NoOfSibilings}\nDateOfRegistration {DateOfRegistration}\n";
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

Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and 
have to display the details.
*/