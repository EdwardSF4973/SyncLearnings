using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Students
{
    public class EmployeeInfo:IUpdateInfo
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Mobile { get; set; }

        public EmployeeInfo(){}

        public EmployeeInfo(int sID,string name,string fatherName,string mobile)
        {
            EmployeeID=sID;
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            
        }

        public void Update(string a)
        {
            Mobile =a;
        }
        public string Display()
        {
            return $"StudentID : {EmployeeID}, Name : {Name}, FatherName : {FatherName}, Mobile : {Mobile}";
        }
    }
}