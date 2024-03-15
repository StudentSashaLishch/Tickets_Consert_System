using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.MainClasses
{
    public sealed class Consert : Entity
    {
        public DateTime DateOfConsert { get; set; }
        public Singer Singer { get; set; }
        public int NumberRows { get; set; }
        public int NumberPlacesInRow { get; set; }
        public float TicketPrice { get; set; }

        public Consert() : base()
        {

        }

        public override void DeserializeString(string line)
        {
            base.DeserializeString(line);
            string[] strings = line.Split(',');
            DateOfConsert = DateTime.ParseExact(strings[1], "HH dd.MM.yyyy", CultureInfo.InvariantCulture);
            Singer = HandleUsersInfo.singers.FirstOrDefault(singer => singer.ID == Guid.Parse(strings[2]));
            NumberRows = int.Parse(strings[3]);
            NumberPlacesInRow = int.Parse(strings[4]);
            TicketPrice = float.Parse(strings[5]);
        }

        public override void SerializeString(StreamWriter writer)
        {
            base.SerializeString(writer);
            writer.WriteLine($",{DateOfConsert.ToString("HH dd.MM.yyyy")},{Singer.ID},{NumberRows},{NumberPlacesInRow},{TicketPrice}");
        }
    }
}
