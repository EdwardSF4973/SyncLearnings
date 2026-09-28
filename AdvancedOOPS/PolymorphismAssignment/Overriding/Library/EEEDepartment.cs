using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class EEEDepartment:Libraryc
    {
        public override string AuthorName { get; set; }

        public override string BookName { get; set; }

        public override string PublisherName { get; set; }

        public override int Year { get; set; }
        public EEEDepartment(){}

        public EEEDepartment(string serialNumber,string authorName,string bookName,string publisherName,int year):base(serialNumber)
        {
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }
        public override void UpdatebookInfo(string a)
        {
            PublisherName =a;

        }
        
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