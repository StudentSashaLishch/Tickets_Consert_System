using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.MainClasses
{
    public sealed class ContractProposal : Entity
    {
        [ForeignKey("ManagerID")]
        public Guid ManagerID { get; set; }
        [ForeignKey("SingerID")]
        public Guid SingerID { get; set; }

        public ContractProposal() : base()
        {

        }

        public Manager GetManager()
        {
            TicketsConsertSystemContext db = new TicketsConsertSystemContext();
            Manager result = db.Managers.FirstOrDefault(m => m.ID == ManagerID);

            return result;
        }

        public Singer GetSinger()
        {
            TicketsConsertSystemContext db = new TicketsConsertSystemContext();
            Singer result = db.Singers.FirstOrDefault(s => s.ID == SingerID);

            return result;
        }
    }
}
