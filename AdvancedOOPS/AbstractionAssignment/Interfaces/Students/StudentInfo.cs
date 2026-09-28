using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students
{
    public class StudentInfo : IUpdateInfo
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Mobile { get; set; }

        public StudentInfo(){}

        public StudentInfo(int sID,string name,string fatherName,string mobile)
        {
            StudentID=sID;
            Name = name;
            FatherName = fatherName;
            Mobile=mobile;
        }

        public void Update(string a)
        {
            Mobile=a;
        }
        public string Display()
        {
            return $"StudentID : {StudentID}, Name : {Name}, FatherName : {FatherName}, Mobile : {Mobile}";
        }
        
    }
}
/*
2.	Create application for student application

Interface IUpdateInfo
Methods: Dispay

Class StudentInfo inherit IDisplayInfo
Properties: StudentID, Name, FatherName, Mobile
Methods: Update

Class EmployeeInfo inherit IDisplayInfo
Properties: EmployeeID, Name, FatherName
Methods: Update

Requirement : Create one object each for student and employee info, update that using update method and display their properties.

*/