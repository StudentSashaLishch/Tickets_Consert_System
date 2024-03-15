using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.UtilityClasses
{
    public static class HandleContracts
    {
        public static readonly string _OffersContractsNameFile = "OffersContracts.txt";
        public static readonly string _ConsertsInfoNameFile = "ConsertsInfo.txt";
        public static readonly string _SealedTicketsNameFile = "SealedTickets.txt";
        public static List<ContractProposal> contractsProp { get; set; }
        public static List<Consert> conserts { get; set; }
        public static List<TicketSell> ticketSells { get; set; }

        static HandleContracts()
        {
            if(!File.Exists(_OffersContractsNameFile))
            {
                File.Create(_OffersContractsNameFile).Close();
            }
            if(!File.Exists(_ConsertsInfoNameFile))
            {
                File.Create(_ConsertsInfoNameFile).Close();
            }
            if(!File.Exists(_SealedTicketsNameFile))
            {
                File.Create(_SealedTicketsNameFile).Close();
            }

            ReadInfoFromFiles();
        }

        public static void ReadInfoFromFiles()
        {
            contractsProp = new List<ContractProposal>();
            string[] strings = File.ReadAllLines(_OffersContractsNameFile);
            foreach (var line in strings)
            {
                var Contract = new ContractProposal();
                Contract.DeserializeString(line);
                contractsProp.Add(Contract);
            }

            conserts = new List<Consert>();
            strings = File.ReadAllLines(_ConsertsInfoNameFile);
            foreach(var line in strings)
            {
                var Consert = new Consert();
                Consert.DeserializeString(line);
                conserts.Add(Consert);
            }

            ticketSells = new List<TicketSell>();
            strings = File.ReadAllLines(_SealedTicketsNameFile);
            foreach(var line in strings)
            {
                var Ticket = new TicketSell();
                Ticket.DeserializeString(line);
                ticketSells.Add(Ticket);
            }
        }

        public static void NewContractProposal(Manager manager, Singer singer)
        {
            var contract = new ContractProposal()
            {
                OfferManager = manager,
                Singer = singer
            };
            contractsProp.Add(contract);
            WriteContractProposalsIntoFile();
        }

        public static void NewContractProposal(Guid managerID, Guid singerID)
        {
            var manager = HandleUsersInfo.managers.FirstOrDefault(LookedManager => LookedManager.ID == managerID);
            var singer = HandleUsersInfo.singers.FirstOrDefault(LookedSinger => LookedSinger.ID == singerID);
            var Contract = new ContractProposal()
            {
                OfferManager = manager,
                Singer = singer,
            };
            contractsProp.Add(Contract);
            WriteContractProposalsIntoFile();
        }

        public static void NewConsert(DateTime date, Guid singerID, int NumRows, int NumPlaces, float price)
        {
            var Singer = HandleUsersInfo.singers.FirstOrDefault(singer => singer.ID == singerID);
            var Consert = new Consert()
            {
                DateOfConsert = date,
                Singer = Singer,
                NumberRows = NumRows,
                NumberPlacesInRow = NumPlaces,
                TicketPrice = price
            };
            conserts.Add(Consert);
            WriteConsertsIntoFile();
        }

        public static void NewTicketSell(Guid ClientID, Guid ConsertID, int NumRow, int NumPlace)
        {
            var TickedSell = new TicketSell()
            {
                ClientID = ClientID,
                ConsertID = ConsertID,
                NumberRow = NumRow,
                NumberOfPlace = NumPlace
            };
            ticketSells.Add(TickedSell);
            WriteTicketSeelsIntoFile();
        }

        public static void DeleteContractProposal(Guid contractID)
        {
            var LookedContract = contractsProp.FirstOrDefault(contract => contract.ID == contractID);
            if(LookedContract != null)
            {
                int index = contractsProp.IndexOf(LookedContract);
                contractsProp.RemoveAt(index);
            }
            WriteContractProposalsIntoFile();
        }

        public static void DeleteConsert(Guid consertID)
        {
            var LookedConsert = conserts.FirstOrDefault(consert => consert.ID == consertID);
            if (LookedConsert != null)
            {
                int index = conserts.IndexOf(LookedConsert);
                conserts.RemoveAt(index);
            }
            WriteContractProposalsIntoFile();
        }

        public static void WriteContractProposalsIntoFile()
        {
            using(var writer = new StreamWriter(_OffersContractsNameFile, false))
            {
                foreach(var contract in contractsProp)
                {
                    contract.SerializeString(writer);
                }
            }
        }
        public static void WriteConsertsIntoFile()
        {
            using(var writer = new StreamWriter(_ConsertsInfoNameFile, false))
            {
                foreach(var consert in conserts)
                {
                    consert.SerializeString(writer);
                }
            }
        }

        public static void WriteTicketSeelsIntoFile()
        {
            using (var writer = new StreamWriter(_SealedTicketsNameFile, false))
            {
                foreach(var ticket in ticketSells)
                {
                    ticket.SerializeString(writer);
                }
            }
        }



        public static bool IsSealedTicket(Guid ConsertID, int NumRow, int NumPlace)
        {
            foreach(var ticket in ticketSells)
            {
                if(ConsertID == ticket.ConsertID && NumRow == ticket.NumberRow && NumPlace == ticket.NumberOfPlace)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
