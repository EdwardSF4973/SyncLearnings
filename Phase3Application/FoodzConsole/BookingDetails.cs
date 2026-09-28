using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodzConsole
{
    public class BookingDetails
    {
        private static int s_bookingID=3000;

        private string _bookingID;

        public string BookingID { get{return _bookingID;} set{_bookingID=value;s_bookingID=int.Parse(value.Remove(0,3));} }

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
