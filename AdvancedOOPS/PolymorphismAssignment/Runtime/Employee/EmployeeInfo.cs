using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeInfo : PersonalInfo
    {
        private static int s_employeeID = 1000;

        public string EmployeeID { get; set; }

        public string OfficeLocation { get; set; }
        public EmployeeInfo(){}
        public EmployeeInfo(string name,string fatherName,string mobileNumber,string gender,string officeLocation):base(name,fatherName,mobileNumber,gender)
        {
            EmployeeID = $"{++s_employeeID}";
            OfficeLocation=officeLocation;
        }

        public EmployeeInfo(string empID,string name,string fatherName,string mobileNumber,string gender,string officeLocation):base(name,fatherName,mobileNumber,gender)
        {
            EmployeeID = empID;
            OfficeLocation=officeLocation;
        }

        public override void Update(string a)
        {
            OfficeLocation=a;
        }

        public void Display()
        {
            System.Console.WriteLine($"EmployeeID = {EmployeeID}, Name : {Name}, FatherName : {FatherName}, Mobile : {MobileNumber}, Gender : {Gender}, OfficeLocation : {OfficeLocation}");
        }
    }
}