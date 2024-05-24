using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Data.UtilityClasses
{
    public static class Extractor
    {
        public static Singer GetSinger (Guid SingerID)
        {
            return Repository<Singer>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(s => s.ID == SingerID);
        }

        public static Manager GetManager (Guid ManagerID)
        {
            return Repository<Manager>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(s => s.ID == ManagerID);
        }

        public static Client GetClient (Guid ClientID)
        {
            return Repository<Client>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(s => s.ID == ClientID);
        }

        public static Consert GetConsert (Guid ConsertID)
        {
            return Repository<Consert>
                .GetRepo (new TicketsConsertSystemContext())
                .GetFirst(c => c.ID == ConsertID);
        }
    }
}
