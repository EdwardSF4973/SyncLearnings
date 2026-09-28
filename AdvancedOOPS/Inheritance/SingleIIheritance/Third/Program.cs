using System;

namespace Third;

class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails depart = new(1234,"CSE","BE");
        System.Console.WriteLine(depart.DisplayDepartment());

        BookInfo book = new("HArry prtter","Jk rowling",850,1234,"ECE","Btech");
        System.Console.WriteLine();
        System.Console.WriteLine(book.DisplayBookDetils());
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