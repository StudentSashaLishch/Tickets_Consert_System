using System;

namespace Tickets_Consert_System.MainClasses
{
    public class TicketSell : Entity
    {
        public Guid ClientID { get; set; }
        public Guid ConsertID { get; set; }
        public int NumberRow { get; set; }
        public int NumberOfPlace { get; set; }

        public TicketSell() : base()
        {

        }
    }
}
