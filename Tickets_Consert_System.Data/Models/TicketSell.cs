using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.MainClasses
{
    public class TicketSell : Entity
    {
        [ForeignKey("ClientID")]
        public Guid ClientID { get; set; }
        [ForeignKey("ConsertID")]
        public Guid ConsertID { get; set; }
        public int NumberRow { get; set; }
        public int NumberOfPlace { get; set; }

        public TicketSell() : base()
        {

        }

        public Client GetClient()
        {
            TicketsConsertSystemContext db = new TicketsConsertSystemContext();
            Client result = db.Clients.FirstOrDefault(c => c.ID == ClientID);

            return result;
        }
    }
}
