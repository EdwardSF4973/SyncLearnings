using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Personal
{
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Mobile { get; set; }

        public string Mail { get; set; }

        public string Gender { get; set; }
        public PersonalInfo(){}

        public PersonalInfo(string name,string fatherName,string mobile,string mail,string gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }

        public virtual void Update(string a)
        {
            Mobile = a;
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