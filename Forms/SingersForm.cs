using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.Data.Models;
using Tickets_Consert_System.Data.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class SingersForm : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        UIManager.initOldForm funcs {  get; set; }

        private Singer singer { get; set; }

        public SingersForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //context = new TicketsConsertSystemContext();
        }

        public SingersForm(Singer singer) : this()
        {
            this.singer = singer;
            funcs = WriteContractProps;
            funcs += WriteInfoAboutMe;
            funcs += WriteInfoAboutManagers;
            funcs += () => WriteConsetrsList(Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(c => c.SingerID == singer.ID));

            funcs();
        }

        public void WriteContractProps()
        {
            IEnumerable<ContractProposal> contracts = Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(contract => contract.SingerID == singer.ID && contract.IsForSinger);
            OfferedContracts.Rows.Clear();
            foreach (var contract in contracts)
            {
                OfferedContracts.Rows.Add(contract.ID, Extractor.GetManager(contract.ManagerID).FullName, Extractor.GetManager(contract.ManagerID).Email);
            }
        }

        public void WriteConsetrsList(IEnumerable<Consert> list)
        {
            ConsertsList.Rows.Clear();
            var context = new TicketsConsertSystemContext();
            var query = from ticketSell in context.Tickets
                        join consert in context.Conserts on ticketSell.ConsertID equals consert.ID
                        join singer in context.Singers on consert.SingerID equals singer.ID
                        group new { ticketSell, consert, singer } by new
                        {
                            ticketSell.ConsertID,
                            consert.SingerID
                        } into g
                        select new
                        {
                            ConsertID = g.Key.ConsertID,
                            SingerID = g.Key.SingerID,
                            DateOfConsert = Extractor.GetConsert(g.Key.ConsertID).DateOfConsert,
                            SingersName = Extractor.GetSinger(g.Key.SingerID).FullName,
                            Price = Extractor.GetConsert(g.Key.ConsertID).TicketPrice,
                            CountTickets = g.Count()
                        };

            foreach (var consert in query.ToList())
            {
                if (consert.SingerID == singer.ID && list.FirstOrDefault(c => c.ID == consert.ConsertID) != null)
                {
                    ConsertsList.Rows.Add(consert.ConsertID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.SingersName, consert.Price, consert.CountTickets);
                }
            }
            context.Dispose();
        }

        public void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + singer.Login;
            MyName.Text = "Full name: " + singer.FullName;
            MyEmail.Text = "Email: " + singer.Email;

            var myManager = Repository<Manager>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(manager => Extractor.GetSinger(manager.SingerID) != null && manager.SingerID == singer.ID);
            if (myManager != null)
            {
                MyManagersName.Text = "The name of my manager: " + myManager.FullName;
                MyManagersEmail.Text = "The Email of my manager: " + myManager.Email;
            }
        }

        public void WriteInfoAboutManagers()
        {
            ManagersList.Rows.Clear();
            foreach(var manager in Repository<Manager>.GetRepo(new TicketsConsertSystemContext()).GetAll())
            {
                ManagersList.Rows.Add(manager.ID, manager.FullName, manager.Email);
            }
        }

        private void WriteMessages()
        {
            var messages = Repository<StatusMessage>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(m => m.receiver == singer.ID);
            MessagesList.Rows.Clear();
            foreach (var message in messages)
            {
                MessagesList.Rows.Add(message.ID, message.TimeReceiving.ToString("dd.MM HH:mm"), message.text);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            ContractProposal contract = Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(Contract => Contract.ID == ContractID);

            var proposals = Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(Contract => Contract.SingerID == singer.ID || Contract.ManagerID == contract.ManagerID);
            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .DeleteRange(proposals.ToList());

            var manager = Extractor.GetManager(contract.SingerID);
            manager.SingerID = singer.ID;
            Repository<Manager>
                .GetRepo(new TicketsConsertSystemContext())
                .Update(manager);

            var NewMessage = new StatusMessage(manager.ID, $"Singer {singer.FullName} has accepted your contract offer");
            Repository<StatusMessage>
                .GetRepo(new TicketsConsertSystemContext())
                .Create(NewMessage);

            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .Delete(ContractID);

            WriteContractProps();
            WriteInfoAboutMe();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());

            var contract = Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(Contract => Contract.ID == ContractID);
            var NewMessage = new StatusMessage(contract.ManagerID, $"Singer {singer.FullName} rejected your contract offer");
            Repository<StatusMessage>
                .GetRepo(new TicketsConsertSystemContext())
                .Create(NewMessage);

            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .Delete(ContractID);
            WriteContractProps();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings(singer.ID);

            funcs -= () => WriteConsetrsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll(c => c.SingerID == singer.ID));
            funcs += () => WriteConsetrsList(settingsPage.filteredInfo);
            UIManager.SwitchForm(this, settingsPage, funcs);
            funcs -= () => WriteConsetrsList(settingsPage.filteredInfo);
            funcs += () => WriteConsetrsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll(c => c.SingerID == singer.ID));
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            WriteConsetrsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll(c => c.SingerID == singer.ID));
        }

        private void SeeStatictics_Click(object sender, EventArgs e)
        {
            var consert = Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(Consert => Consert.ID == Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString()));
            if (consert == null)
            {
                MessageBox.Show("This consert doesn't exist");
                return;
            }

            UIManager.SwitchForm(this, new ConsertStatystic(consert), funcs);
        }

        private void ChooseManager_Click(object sender, EventArgs e)
        {
            var managerID = Guid.Parse(ManagersList.CurrentRow.Cells[0].Value.ToString());
            if (ManagersList.CurrentRow.Cells[0].Value == null)
                return;

            var proposal = Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(c => c.SingerID == singer.ID && c.ManagerID == managerID);
            if (proposal != null) 
                return;

            var Proposal = new ContractProposal()
            {
                ManagerID = managerID,
                SingerID = singer.ID,
                IsForSinger = false
            };
            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .Create(Proposal);

            MessageBox.Show("Success!");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var messageID = Guid.Parse(MessagesList.CurrentRow.Cells[0].Value.ToString());
            Repository<StatusMessage>
                .GetRepo(new TicketsConsertSystemContext())
                .Delete(messageID);

            WriteMessages();
        }

        private void RemoveAll_Click(object sender, EventArgs e)
        {
            List<Guid> MessageIDs = new List<Guid>();
            foreach (DataGridViewRow row in MessagesList.Rows)
            {
                if (row.Cells[0].Value != null)
                    MessageIDs.Add(Guid.Parse(row.Cells[0].Value.ToString()));
            }

            foreach (var id in MessageIDs)
            {
                Repository<StatusMessage>
                    .GetRepo(new TicketsConsertSystemContext())
                    .DeleteRange(MessageIDs);
            }

            WriteMessages();
        }

        private void TerminateContract_Click(object sender, EventArgs e)
        {
            if (!AreThereMyManager())
            {
                MessageBox.Show("You dont have manager");
                return;
            }

            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
                TerminateContractFunc();
        }

        private void TerminateContractFunc()
        {
            var manager = Repository<Manager>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(m => m.SingerID == singer.ID);
            var conserts = Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(c => c.SingerID == singer.ID);
            Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .DeleteRange(conserts.ToList());
            manager.SingerID = default(Guid);
            Repository<Manager>
                .GetRepo(new TicketsConsertSystemContext())
                .Update(manager);

            ConsertsList.Rows.Clear();
            WriteInfoAboutMe();
        }

        private bool AreThereMyManager()
        {
            var manager = Repository<Manager>
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(m => m.SingerID == singer.ID);
            if (manager == null)
                return false;
            else
                return true;
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                Repository<Singer>
                    .GetRepo(new TicketsConsertSystemContext())
                    .Delete(singer.ID);
                this.Close();
            }
        }
    }
}
