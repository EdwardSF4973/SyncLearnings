using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal
{
    public class EmployeeInfo : FamilyInfo
    {
        public string EmployeeID { get; set; }

        public string DateOfJoining { get; set; }

        public EmployeeInfo(string empID , string doj ,string name,string fatherName,string motherName,string mail,string mobile,string gender,int noOfSibilings):base(name,fatherName,mobile,mail,gender,mobile,noOfSibilings)
        {

            EmployeeID = empID;
            DateOfJoining = doj;
        }

        public override void Update(string a )
        {
            Mobile =a;

        }
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