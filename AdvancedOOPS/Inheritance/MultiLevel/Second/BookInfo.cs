using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second
{
    public class BookInfo : RackInfo
    {
        private static int s_bookID = 2500;
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public int Price { get; set; }

        public BookInfo(){}

        public BookInfo(string bookName, string authorName, int price, int rackID,int departmentID, int columnNumber, string departmentName,string degree) : base(rackID,departmentID,columnNumber,departmentName,degree)
        {
            BookID = ++s_bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public string DisplayBooks()
        {
            return $"BookID : {BookID}, BookName : {BookName} , AuthorName : {AuthorName}, Price : {Price}, {DisplayRack()}";
        }
    }
}
/*
2.	Online Library

Class DepartmentDetails:
Properties: DepartmentID, DepartmentName, Degree

Class RackInfo: DepartmentDetails
Properties: RackID, ColumnNumber 

Class BookInfo: Inherit RackInfo
Properties: BookID, BookName, AuthorName, Price

Requirement : Have to create two objects for each above classes (ID’s are auto incremented) in Program.cs and have to display the details
*/