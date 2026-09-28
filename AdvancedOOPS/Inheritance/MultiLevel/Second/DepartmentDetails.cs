using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second
{
    public class DepartmentDetails
    {
        private static int s_departmentID = 100;
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public string Degree { get; set; }

        public DepartmentDetails(){}

        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentID = ++s_departmentID;
            DepartmentName = departmentName;
            Degree = degree;
        }

        public DepartmentDetails(int departmentID, string departmentName,string degree)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
            Degree = degree;
        }

        public string DisplayDepartMent()
        {
            return $"DepartmentID : {DepartmentID}, DepartmentName : {DepartmentName}, Degree : {Degree}";
        }
    }
}
/*
2.	Online Library

Class DepartmentDetails:
Properties: DepartmentID, DepartmentName, Degree

Class RackInfo: DepartmentDetails
Properties: RackID, ColumnNumber 

Class BookInfo: Inherit DepartmentDetails
Properties: BookID, BookName, AuthorName, Price

Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details
*/