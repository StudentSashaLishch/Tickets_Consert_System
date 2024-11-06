using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_Consert_System.Data.Models
{
    public class Review : Entity
    {
        [ForeignKey("ClientID")]
        public Guid ClientID {  get; set; }

        [ForeignKey("SingerID")]
        public Guid SingerID { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public DateTime DateOfSending { get; set; }
    }
}
