using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Theater
{
    public class OfflineTicket:Ticket
    {
         public override int SeatNumber { get; set; }

        public override string TicketType {get; set;}

        public OfflineTicket(int seatnumber,string ticketType,string theatername,int price):base(theatername,price)
        {
            SeatNumber = seatnumber;
            TicketType=ticketType;
        }

        public override void UpdateTicketInfo()
        {
            System.Console.WriteLine($"TicketID : {TicketID}, TheaterName : {ThearterName}, TicketType : {TicketType} , Price : {TicketPrice}, SeatNumber : {SeatNumber} ");
        }
    }
}