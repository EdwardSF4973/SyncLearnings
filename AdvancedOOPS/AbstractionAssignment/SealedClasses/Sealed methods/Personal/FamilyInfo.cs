using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personal
{
    public class FamilyInfo:PersonalInfo
    {
        
        public string MotherName { get; set; }

        public int NoOfSiblings { get; set; }

      

        public FamilyInfo(){}

        public FamilyInfo(string name,string fatherName,string mobile,string mail,string gender,string motherName,int noOfSibilings):base(name,fatherName,mobile,mail,gender)
        {
            
            MotherName = motherName;
            NoOfSiblings = noOfSibilings;
           
        }

        public sealed override void Update(string a)
        {
            base.Update(a);
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