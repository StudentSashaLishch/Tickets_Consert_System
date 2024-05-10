using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.MainClasses
{
    public sealed class Consert : Entity
    {
        public DateTime DateOfConsert { get; set; }
        [ForeignKey("SingerID")]
        public Guid SingerID { get; set; }
        public int NumberRows { get; set; }
        public int NumberPlacesInRow { get; set; }
        public float TicketPrice { get; set; }

        public Consert() : base()
        {

        }

        public Singer GetSinger()
        {
            TicketsConsertSystemContext db = new TicketsConsertSystemContext();
            Singer result = db.Singers.FirstOrDefault(s => s.ID == SingerID);

            return result;
        }
    }
}
