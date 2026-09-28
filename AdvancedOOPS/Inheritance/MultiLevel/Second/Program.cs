using System;

namespace Second;

class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails depart = new("ECE","BE");
        System.Console.WriteLine(depart.DisplayDepartMent());

        RackInfo rack = new (123,3,"CSE","B.TEch");
        System.Console.WriteLine(rack.DisplayRack());

        BookInfo book = new("Anbuden","Dhoni",50,123,753,5,"Mech","BE");
        System.Console.WriteLine(book.DisplayBooks());
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