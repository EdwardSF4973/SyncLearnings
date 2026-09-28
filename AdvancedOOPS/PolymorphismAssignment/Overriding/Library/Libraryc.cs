using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Libraryc
    {
        private static int s_serialNumber = 1000;

        public string SeiralNumber { get; set; }

        public abstract string AuthorName { get; set; }

        public abstract string BookName { get; set; }

        public abstract string PublisherName { get; set; }

        public abstract int Year { get; set; }

        public Libraryc(){}

        public Libraryc(string author,string book,string publisher,int year)
        {
            SeiralNumber = $"LIB{++s_serialNumber}";
            AuthorName = author;
            BookName = book;
            PublisherName = publisher;
            Year = year;
        }
        public Libraryc(string serialNumber)
        {

            SeiralNumber = serialNumber;
        }

        public abstract void UpdatebookInfo(string a);
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