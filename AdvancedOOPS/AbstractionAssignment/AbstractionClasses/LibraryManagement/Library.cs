using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public abstract class Library
    {
        private  static int s_serialNumber = 1000;

        public string SerialNumber { get; set; }

        public abstract string AuthorName { get; set; }

        public abstract string BookName { get; set; }

        public abstract string PublisherName { get; set; }

        public abstract int Year { get; set; }

        public Library()
        {
            SerialNumber = $"LIB{++s_serialNumber}";
        }

        public abstract void SetBookInfo();
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