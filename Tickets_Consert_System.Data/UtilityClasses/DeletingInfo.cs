using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Data.UtilityClasses
{
    public static class DeletingInfo
    {
        public static async void DeleteConsert(Guid consertID, bool returnMoney)
        {
            var tickets = await Repository<TicketSell>
                .GetRepo()
                .GetAll(t => t.ConsertID == consertID);

            if (returnMoney)
            {
                foreach (var ticket in tickets)
                {
                    DeleteTicketReturnMoney(ticket);
                }
            }
            else
                Repository<TicketSell>
                    .GetRepo()
                    .DeleteRange(tickets);

            Repository<Consert>
                .GetRepo()
                .Delete(consertID);


        }

        public static async void DeleteClient(Guid clientID)
        {
            var tickets = await Repository<TicketSell>
                .GetRepo()
                .GetAll(t => t.ClientID == clientID);

            Repository<Client>
                .GetRepo()
                .Delete(clientID);
            Repository<TicketSell>
                .GetRepo()
                .DeleteRange(tickets);
        }

        public static async void DeleteSinger(Guid singerID)
        {
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == singerID);
            var manager = await Repository<Manager>
                .GetRepo()
                .GetFirst(m => m.SingerID == singerID);
            manager.SingerID = default(Guid);

            Repository<Singer>
                .GetRepo()
                .Delete(singerID);
            Repository<Manager>
                .GetRepo()
                .Update(manager);

            foreach(var consert in conserts)
            {
                DeleteConsert(consert.ID, true);
            }
        }

        public static async void DeleteManager(Guid managerID)
        {
            var manager = await Repository<Manager>
                .GetRepo()
                .GetFirst(m => m.ID == managerID);
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == manager.SingerID);

            Repository<Manager>
                .GetRepo()
                .Delete(managerID);
            foreach(var consert in conserts)
            {
                DeleteConsert(consert.ID, true);
            }
        }

        public static async void DeleteTicketReturnMoney(TicketSell ticket)
        {
            var client = await Repository<Client>
                .GetRepo()
                .GetComponent(ticket.ClientID);
            var consert = await Repository<Consert>
                .GetRepo()
                .GetComponent(ticket.ConsertID);

            client.Ballanse += consert.TicketPrice;
            Repository<Client>
                .GetRepo()
                .Update(client);
            Repository<TicketSell>
                .GetRepo()
                .Delete(ticket.ID);
        }

        //------------
        public static async void DeleteOldConserts()
        {
            var oldConserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.DateOfConsert < DateTime.Now);

            foreach(var consert in oldConserts)
            {
                DeleteConsert(consert.ID, false);
            }
        }
    }
}
