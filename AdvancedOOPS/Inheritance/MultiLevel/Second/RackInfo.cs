using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Second
{
    public class RackInfo : DepartmentDetails
    {
        private static int s_rackID  = 0;
        public int RackID { get; set; }

        public int ColumnNumber { get; set; }

        public RackInfo(){}

        public RackInfo(int departmentID, int columnNumber, string departmentName,string degree) : base(departmentID,departmentName,degree)
        {
            RackID = ++s_rackID;
            ColumnNumber = columnNumber;
        }

        public RackInfo(int rackID,int departmentID, int columnNumber, string departmentName,string degree) : base(departmentID,departmentName,degree)
        {
            RackID = rackID;
            ColumnNumber = columnNumber;
        }

        public string DisplayRack()
        {
            return $"RackID : {RackID}, {DisplayDepartMent()}, ColumnNumber : {ColumnNumber}";
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