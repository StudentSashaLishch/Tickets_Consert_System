using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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

        public override void DeserializeString(string line)
        {
            base.DeserializeString(line);
            string[] strings = line.Split(',');
            ClientID = Guid.Parse(strings[1]);
            ConsertID = Guid.Parse(strings[2]);
            NumberRow = int.Parse(strings[3]);
            NumberOfPlace = int.Parse(strings[4]);
        }

        public override void SerializeString(StreamWriter writer)
        {
            base.SerializeString(writer);
            writer.WriteLine($",{ClientID},{ConsertID},{NumberRow},{NumberOfPlace}");
        }
    }
}
