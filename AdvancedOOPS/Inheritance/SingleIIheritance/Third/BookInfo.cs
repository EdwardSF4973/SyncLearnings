using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Third
{
    public class BookInfo : DepartmentDetails
    {
        private static int s_bookID =1000;
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public int Price { get; set; }

        public BookInfo(){}

        public BookInfo(string bookName,string authorName, int price,int departmentID, string departName,string degree):base(departmentID,departName,degree)
        {
            BookID = ++s_bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public string DisplayBookDetils()
        {
            return $"BookID : {BookID}, BookName : {BookName}, AuthorName : {AuthorName}, {DisplayDepartment()},Price : {Price}";
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