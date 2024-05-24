using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets_Consert_System.Data.Models
{
    public class StatusMessage : Entity
    {
        [ForeignKey("ReceiverID")]
        public Guid receiver { get; set; }
        public DateTime TimeReceiving { get; set; }
        public string text { get; set; }

        public StatusMessage() : base()
        { 
        }
        public StatusMessage(Guid receiver, string text) : this()
        {
            TimeReceiving = DateTime.Now;
            this.receiver = receiver;
            this.text = text;
        }
    }
}
