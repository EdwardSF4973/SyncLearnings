using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Theater
{
    public abstract class Ticket
    {
        private static int s_ticketID = 100;

        public string TicketID { get; set; }

        public string ThearterName { get; set; }

        public int TicketPrice { get; set; }

        public abstract int SeatNumber { get; set; }

        public abstract string TicketType {get; set;}

        public Ticket(string theaterName , int price)
        {
            TicketID = $"TID{++s_ticketID}";
            ThearterName = theaterName;
            TicketPrice = price;
        }
        public abstract void UpdateTicketInfo();

    }
}
