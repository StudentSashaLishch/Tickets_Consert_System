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
    public partial class ManagersForm : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        private UIManager.initOldForm funcs { get; set; }

        public Manager manager { get; set; }
        public ManagersForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //context = new TicketsConsertSystemContext();
        }

        public ManagersForm(Manager manager) : this()
        {
            this.manager = manager;

            funcs = WriteSingersList;
            funcs += WriteMessages;
            funcs += WriteInfoAboutMe;
            funcs += WriteContractProps;
            funcs += () => WriteConsertsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll(c => c.SingerID == manager.SingerID));

            funcs();
        }

        private void WriteSingersList()
        {
            SingersList.Rows.Clear();
            foreach (var singer in Repository<Singer>.GetRepo(new TicketsConsertSystemContext()).GetAll())
            {
                SingersList.Rows.Add(singer.ID, singer.FullName, singer.Email);
            }
        }

        private void WriteConsertsList(IEnumerable<Consert> list)
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
                if (Extractor.GetSinger(manager.SingerID) != null && consert.SingerID == manager.SingerID && list.FirstOrDefault(c => c.ID == consert.ConsertID) != null)
                {
                    ConsertsList.Rows.Add(consert.ConsertID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.SingersName, consert.Price, consert.CountTickets);
                }
            }
            context.Dispose();
        }

        private void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + manager.Login;
            MyName.Text = "Full Name: " + manager.FullName;
            MyEmail.Text = "Email: " + manager.Email;
            if (Extractor.GetSinger(manager.SingerID) != null)
            {
                MySingersName.Text = "The name of the singer I represent: " + Extractor.GetSinger(manager.SingerID).FullName;
                MySingersEmail.Text = "The Email of the singer I represent: " + Extractor.GetSinger(manager.SingerID).Email;
            }
            else
            {
                MySingersName.Text = "The name of the singer I represent: none";
                MySingersEmail.Text = "The Email of the singer I represent: none";
            }
        }

        private void WriteMessages()
        {
            var messages = Repository<StatusMessage>.GetRepo(new TicketsConsertSystemContext()).GetAll(m => m.receiver == manager.ID);
            MessagesList.Rows.Clear();
            foreach (var message in messages)
            {
                MessagesList.Rows.Add(message.ID, message.TimeReceiving.ToString("dd.MM HH:mm"), message.text);
            }
        }

        public void WriteContractProps()
        {
            IEnumerable<ContractProposal> contracts = Repository<ContractProposal>
            .GetRepo(new TicketsConsertSystemContext())
                .GetAll(contract => contract.ManagerID == manager.ID && !contract.IsForSinger);
            OfferedContracts.Rows.Clear();
            foreach (var contract in contracts)
            {
                OfferedContracts.Rows.Add(contract.ID, contract.SingerID, Extractor.GetSinger(contract.SingerID).FullName, Extractor.GetSinger(contract.SingerID).Email);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) // Choose singer
        {
            var singerID = Guid.Parse(SingersList.CurrentRow.Cells[0].Value.ToString());
            if (SingersList.CurrentRow.Cells[0].Value == null)
                return;

            var proposal = Repository<ContractProposal>.GetRepo(new TicketsConsertSystemContext()).GetFirst(c => c.SingerID == singerID && c.ManagerID == manager.ID);
            if (proposal != null)
                return;

            var Proposal = new ContractProposal()
            {
                ManagerID = manager.ID,
                SingerID = singerID,
                IsForSinger = true
            };
            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .Create(Proposal);

            MessageBox.Show("Success!");
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e) //Creating Consert
        {
            if (Extractor.GetSinger(manager.SingerID) == null)
            {
                MessageBox.Show("Representative singer is not exists");
                return;
            }

            UIManager.SwitchForm(this, new CreatingConsert(manager.SingerID), funcs);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) // Delete consert
        {
            if (ConsertsList.CurrentRow.Cells[0].Value == null)
                return;

            Guid consertID = Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString());
            Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .Delete(consertID);

            WriteConsertsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll());
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            WriteConsertsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll());
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e) //Filter
        {
            var settingsPage = new FilterSettings(manager.SingerID);
            funcs -= () => WriteConsertsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll(c => c.SingerID == manager.SingerID));
            funcs += () => WriteConsertsList(settingsPage.filteredInfo);
            UIManager.SwitchForm(this, settingsPage, funcs);
            funcs -= () => WriteConsertsList(settingsPage.filteredInfo);
            funcs += () => WriteConsertsList(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll(c => c.SingerID == manager.SingerID));
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

        private void Remove_Click(object sender, EventArgs e)
        {
            var messageID = Guid.Parse(MessagesList.CurrentRow.Cells[0].Value.ToString());
            Repository<StatusMessage>.GetRepo(new TicketsConsertSystemContext()).Delete(messageID);

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
                Repository<StatusMessage>.GetRepo(new TicketsConsertSystemContext()).DeleteRange(MessageIDs);
            }

            WriteMessages();
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            var singerID = Guid.Parse(OfferedContracts.CurrentRow.Cells[1].Value.ToString());
            manager.SingerID = singerID;
            Repository<Manager>
                .GetRepo(new TicketsConsertSystemContext())
                .Update(manager);

            var proposals = Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(contract => contract.SingerID == singerID || contract.ManagerID == manager.ID);
            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .DeleteRange(proposals.ToList());

            var NewMessage = new StatusMessage(singerID, $"Manager {manager.FullName} has accepted your contract offer");
            Repository<StatusMessage>.GetRepo(new TicketsConsertSystemContext()).Create(NewMessage);

            var proposalID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .Delete(proposalID);

            WriteContractProps();
            WriteInfoAboutMe();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            var singerID = Guid.Parse(OfferedContracts.CurrentRow.Cells[1].Value.ToString());
            var NewMessage = new StatusMessage(singerID, $"Manager {manager.FullName} rejected your contract offer");
            Repository<StatusMessage>.GetRepo(new TicketsConsertSystemContext()).Create(NewMessage);

            var proposalID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            Repository<ContractProposal>
                .GetRepo(new TicketsConsertSystemContext())
                .Delete(proposalID);

            WriteContractProps();
            WriteInfoAboutMe();
        }

        private void TerminateContract_Click(object sender, EventArgs e)
        {
            if (manager.SingerID == default(Guid))
            {
                MessageBox.Show("There aren't singer, which you represents");
                return;
            }

            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
                TerminateContractFunc();
        }

        private void TerminateContractFunc()
        {
            var conserts = Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(c => c.SingerID == manager.SingerID);
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

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                Repository<Manager>.GetRepo(new TicketsConsertSystemContext()).Delete(manager.ID);
                this.Close();
            }
        }
    }
}
