using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafteriaConsole
{
    public class BookingDetails
    {
        private static int s_bookingID=3000;

        public string BookingID { get; set; }

        public string CustomerID { get; set; }

        public double TotalPrice { get; set; }

        public string DateOfBooking { get; set; }

        public BookingInfo BookingStatus { get; set; }

        public BookingDetails(){}

        public BookingDetails(string customerID,double totalPrice,string dob,BookingInfo bookingStatus)
        {
            BookingID = $"BID{++s_bookingID}";
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dob;
            BookingStatus = bookingStatus;
        }

        
    }
}
