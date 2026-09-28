using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Third
{
    public class DepartmentDetails
    {
        private static int s_departmentID = 100;
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public string Degree { get; set; }
        
        public DepartmentDetails(){}

        public DepartmentDetails(string departName, string degree)
        {
            DepartmentID=++s_departmentID;
            DepartmentName= departName;
            Degree = degree;
        }

        public DepartmentDetails(int departmentID, string departName,string degree)
        {
            DepartmentID=departmentID;
            DepartmentName= departName;
            Degree = degree;
        }

        public string DisplayDepartment()
        {
            return $"DepartmentID : {DepartmentID}, DepartmentName: {DepartmentName}, Degree: {Degree}";
        }
    }
}
/*
3.	Online Library : 
Class DepartmentDetails:
Properties: DepartmentID, DepartmentName, Degree

Class BookInfo: Inherit DepartmentDetails
Properties: BookID, BookName, AuthorName, Price
Requirement: Need to create inherited class (ID’s are auto incremented) and have to create objects for the each above two classes and have to display the details in Program.cs

*/