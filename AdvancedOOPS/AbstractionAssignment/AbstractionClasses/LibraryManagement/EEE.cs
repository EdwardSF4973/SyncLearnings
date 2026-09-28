using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class EEE:Library
    {
        public override string AuthorName { get ; set ; }

        public override string BookName { get ; set ; }

        public override string PublisherName { get; set; }

        public override int Year { get; set; }

        public EEE(string authorName,string bookName, string publisherName, int year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;

        }

        public override void SetBookInfo()
        {
            System.Console.WriteLine($"ID : {SerialNumber}, Author : {AuthorName}, BookName : {BookName},Publisher NAme :{PublisherName} . year : {Year}");
        }

       

    }
}
/*
2.	Create an application for library management application

Abstract class Library
Field : serial number 
Property : SerialNumber -LIB1000 (Auto increment)
Abstract properties: AuthorName, BookName, PublisherName, Year
Abstract methods: SetBookInfo

Class EEEdepartment  inherit Library
Overridden methods SetBookinfo, Updateinfo

Class CSEDepartment inherit Library
Overridden methods SetBookInfo, Updateinfo

Requirement : Create objects for EEE, CSE departments using set book info set values to properties the serial number is auto incremented property. 
If any book set serial number might be auto incremented. 

*/