using System;

namespace PersonalInfo;

class Program
{
    public static void Main(string[] args)
    {
        RegisterPerson person = new(123,852,"19/11/2002","George","Hepsiba","chennai",5,"Edward","19/11/2002",73055,"Single");
        System.Console.WriteLine(person.Display());
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