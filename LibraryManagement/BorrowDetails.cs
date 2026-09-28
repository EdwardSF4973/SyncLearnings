using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BorrowDetails
    {
        /// <summary>
        /// This is field used to assign the borrow ID by auto increment <see cref="BorrowDetails"/>
        /// </summary>
        public static int s_borrowID = 2000;
        /// <summary>
        /// This property is to store the BorrowID. It takes string from the constructor <see cref="BorrowDetails"/>
        /// </summary>
        /// <value></value>
        public string BorrowID { get; set; }
        /// <summary>
        /// This property is to store the BookID. It takes string from the constructor <see cref="BorrowDetails"/> 
        /// </summary>
        /// <value></value>
        public string BookID { get; set; }
        /// <summary>
        /// This property is to store the UserID. It takes string from the constructor <see cref="BorrowDetails"/> 
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// This property is to store the BorrowDate. It takes DateTime object from the constructor <see cref="BorrowDetails"/> 
        /// </summary>
        /// <value></value>
        public DateTime BorrowedDate { get; set; }
        /// <summary>
        /// This property is to store the Bookingstatus. It takes BookRetunedStatus(Enum) from the constructor <see cref="BorrowDetails"/> 
        /// </summary>
        /// <value></value>
        public BookReturnedStatus BookReturnedStatus { get; set; }
        /// <summary>
        /// This property is to store the Paidamount. It takes double from the constructor <see cref="BorrowDetails"/> 
        /// </summary>
        /// <value></value>
        public double PaidFineAmount { get; set; }
        /// <summary>
        /// This is parameterized constructor used to assign a parameters to properties of this class <see cref="BorrowDetails"/>
        /// </summary>
        /// <param name="bookID">Parameter bookID is used to store bookID in property BookID</param>
        /// <param name="userID">Parameter userID is used to store userID in property UserID</param>
        /// <param name="borrowDate">Parameter borrowDate is used to store borrow date in property BorrowDate</param>
        /// <param name="bookingstatus">Parameter bookingstatus is used to store bookingstatus in property BookReturnedStatus</param>
        /// <param name="paidamount">Parameter paidamount is used to store paid amount in property PaidFineAmount</param>
        public BorrowDetails(string bookID,string userID,DateTime borrowDate,BookReturnedStatus bookingstatus,double paidamount){
              BorrowID=$"LB{++s_borrowID}";
              BookID=bookID;
              UserID=userID;
              BorrowedDate=borrowDate;
              BookReturnedStatus=bookingstatus;
              PaidFineAmount=paidamount;
        }
    }
}