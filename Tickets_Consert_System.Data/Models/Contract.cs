using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets_Consert_System.Data.Models
{
    public class Contract : Entity
    {
        [ForeignKey("SingerID")]
        public Guid singer { get; set; }

        [ForeignKey("ManagerID")]
        public Guid manager { get; set; }
        public double ManagersPrice { get; set; }

        public Contract() : base()
        {
        }
    }
}
