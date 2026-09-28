using System;

namespace Personal;

class Program
{
    public static void Main(string[] args)
    {

    }
}
/*
Sealed Methods:
1.	Create an application that get user info
Class PersonalInfo:
Properties: Name, FatherName, Mobile, Mail, Gender 
Method: virtual Update

Class FamilyInfo: Inherit PersonalInfo 
Properties: FatherName, MotherName, NoOfSiblings, NativePlace
Method: Sealed override Update

Class EmployeeInfo: Inherit FamilyInfo
Properties: EmployeeID, DateOfJoining
Method: override Update

Requirement : Create object for the Employee info and find the issue.

*/