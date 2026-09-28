using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class CSEDepartment : Libraryc
    {
        
        public override string AuthorName { get; set; }

        public override string BookName { get; set; }

        public override string PublisherName { get; set; }

        public override int Year { get; set; }
        public CSEDepartment(){}

        public CSEDepartment(string serialNumber,string authorName,string bookName,string publisherName,int year):base(serialNumber)
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