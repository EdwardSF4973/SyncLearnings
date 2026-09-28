using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BookDetails
    {
        /// <summary>
        /// This Field is used To increment the book id <see cref="BookDetails"/>
        /// </summary> 
        public static int s_bookID = 1000;
        /// <summary>
        /// The Property is used to store the string of BookID<see cref="BookDetails"/>
        /// </summary>
        /// <value>BID1000-BID9999</value>
        public string BookID { get; set; }
        /// <summary>
        /// This Property is used to store the Book Name<see cref="BookDetails"/>
        /// </summary>
        /// <value>string BookName</value>
        public string BookName { get; set; }
        /// <summary>
        /// This Property is used to store the author name<see cref="BookDetails"/>
        /// </summary>
        /// <value>string authorname</value>
        public string AuthorName { get; set; }
        /// <summary>
        /// This property is to show the status of the book availablity<see cref="BookDetails"/>
        /// </summary>
        /// <value></value>
        public  BookAvailabilityStatus BookStatus { get; set; }
        /// <summary>
        /// Tis is a Parameter constructor for creating the instance for the BookDetails<see cref="BookDetails"/>
        /// </summary>
        /// <param name="bookname"></param>
        /// <param name="author"></param>
        /// <param name="bookstatus"></param> 
        public BookDetails(string bookname,string author,BookAvailabilityStatus bookstatus){
            BookID=$"BID{++s_bookID}";
            BookName=bookname;
            AuthorName=author;
            BookStatus=bookstatus;
        }
    }
}