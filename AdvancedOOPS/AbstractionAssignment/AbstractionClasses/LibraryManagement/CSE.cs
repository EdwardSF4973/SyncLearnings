using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class CSE:Library
    {
        public override string AuthorName { get ; set ; }

        public override string BookName { get ; set ; }

        public override string PublisherName { get; set; }

        public override int Year { get; set; }

        public CSE(string authorName,string bookName, string publisherName, int year)
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