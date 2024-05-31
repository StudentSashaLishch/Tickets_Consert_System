using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets_Consert_System.Data.Models;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.UtilityClasses
{
    public static class OutputInformation
    {
        public static async void WriteConsertsInfo(DataGridView ConsertsList, List<Consert> conserts)
        {
            ConsertsList.Rows.Clear();
            foreach(var consert in conserts)
            {
                var singer = await Repository<Singer>
                    .GetRepo()
                    .GetComponent(consert.SingerID);
                ConsertsList.Rows.Add(consert.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), singer.FullName, consert.TicketPrice.ToString("#.##"), consert.CountSoldTickets);
            }
        }
        public static async void WriteContractProps(DataGridView ContractsList, List<ContractProposal> contracts)
        {
            ContractsList.Rows.Clear();
            foreach (var contract in contracts)
            {
                if(contract.IsForSinger)
                {
                    var singer = await Repository<Singer>
                        .GetRepo()
                        .GetComponent(contract.SingerID);
                    ContractsList.Rows.Add(contract.ID, contract.SingerID, singer.FullName, singer.Email);
                }
                else
                {
                    var manager = await Repository<Manager>
                        .GetRepo()
                        .GetComponent(contract.ManagerID);
                    ContractsList.Rows.Add(contract.ID, contract.ManagerID, manager.FullName, manager.Email);
                }
            }
        }
        public static void WritePotentialPartnersInfo<T>(DataGridView InfoList, List<T> users) where T : User
        {
            if (typeof(T) == typeof(Client))
                return;

            InfoList.Rows.Clear();
            foreach (var user in users)
            {
                InfoList.Rows.Add(user.ID, user.FullName, user.Email);
            }
        }
        public static async void WriteMessages(DataGridView MessagesList, Guid userID)
        {
            var messages = await Repository<StatusMessage>.GetRepo().GetAll(m => m.receiver == userID);
            MessagesList.Rows.Clear();
            foreach (var message in messages)
            {
                MessagesList.Rows.Add(message.ID, message.TimeReceiving.ToString("dd.MM HH:mm"), message.text);
            }
        }
    }
}
