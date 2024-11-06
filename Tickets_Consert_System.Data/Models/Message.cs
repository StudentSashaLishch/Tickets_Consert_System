using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tickets_Consert_System.Data.Models
{
    public class Message : Entity
    {
        [ForeignKey("SenderID")]
        public Guid sender { get; set; }

        [ForeignKey("ReceiverID")]
        public Guid receiver { get; set; }
        public DateTime TimeReceiving { get; set; }
        public string text { get; set; }

        public Message() : base()
        { 
        }

        public Message(Guid sender, Guid receiver, string text) : this()
        {
            TimeReceiving = DateTime.Now;
            this.receiver = receiver;
            this.text = text;
        }
    }
}
