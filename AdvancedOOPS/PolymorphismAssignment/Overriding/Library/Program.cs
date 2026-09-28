using System;

namespace Library;

class Program
{
    public static void Main(string[] args)
    {
        CSEDepartment cse1 = new("LIB1001","Edward","BatMan","Subin",2025);
        System.Console.WriteLine(cse1.PublisherName);
        cse1.UpdatebookInfo("Unni");
        System.Console.WriteLine(cse1.PublisherName);

        EEEDepartment eee1 = new("LIB1099","Yogesh","Shinchan","Shyam",2025);
        System.Console.WriteLine(eee1.PublisherName);
        eee1.UpdatebookInfo("Rohit");
        System.Console.WriteLine(eee1.PublisherName);
        
    }
}
/*
1.	Create an application for library management application for method overriding

Abstract class Library
Field : serialNumber 
Property : SerialNumber - LIB1000
Abstract properties: AuthorName, BookName, PublisherName, Year
Abstract methods: UpdatebookInfo

Class EEEDepartment  inherit Library
Overridden methods: UpdatebookInfo

Class CSEDepartment inherit Library
Overridden methods: UpdatebookInfo

Requirement : Create objects for eee, cse and call the overridden method UpdatebookInfo to update values to properties and display information in the objects. 


*/