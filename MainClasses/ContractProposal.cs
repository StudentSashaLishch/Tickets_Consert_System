using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.MainClasses
{
    public sealed class ContractProposal : Entity
    {
        public Manager OfferManager { get; set; }
        public Singer Singer { get; set; }

        public ContractProposal() : base()
        {

        }

        public override void DeserializeString(string line)
        {
            base.DeserializeString(line);
            string[] strings = line.Split(',');
            OfferManager = HandleUsersInfo.managers.FirstOrDefault(manager => manager.ID == Guid.Parse(strings[1]));
            Singer = HandleUsersInfo.singers.FirstOrDefault(singer => singer.ID == Guid.Parse(strings[2]));
        }

        public override void SerializeString(StreamWriter writer)
        {
            base.SerializeString(writer);
            writer.WriteLine($",{OfferManager.ID},{Singer.ID}");
        }
    }
}
