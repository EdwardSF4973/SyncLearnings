using System;

namespace Theater;

class Program
{
    public static void Main(string[] args)
    {
        OnlineTicket ti1 = new(65,"Online","Rohini",500);
        ti1.UpdateTicketInfo();

        OfflineTicket ti2 = new(55,"OffLine","Udhyam",555);
        ti2.UpdateTicketInfo();
    }
}
