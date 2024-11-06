using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.MainClasses
{
    public class Consert : Entity
    {
        public DateTime DateOfConsert { get; set; }
        [ForeignKey("SingerID")]
        public Guid SingerID { get; set; }
        [ForeignKey("VenueID")]
        public Guid VenueID { get; set; }
        public decimal TicketPrice { get; set; }
        public int CountSoldTickets { get; set; }

        public Consert() : base()
        {

        }
    }
}
