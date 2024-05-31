using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            DataInitialization();
        }

        private async void DataInitialization()
        {
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == manager.SingerID);
            var singers = await Repository<Singer>
                .GetRepo()
                .GetAll();
            var contracts = await Repository<ContractProposal>
                .GetRepo()
                .GetAll(c => c.ManagerID == manager.ID && !c.IsForSinger);

            OutputInformation.WritePotentialPartnersInfo<Singer>(SingersList, singers);
            OutputInformation.WriteMessages(MessagesList, manager.ID);
            WriteInfoAboutMe();
            OutputInformation.WriteContractProps(OfferedContracts, contracts);
            OutputInformation.WriteConsertsInfo(ConsertsList, conserts);
        }

        private async void WriteSingersList()
        {
            SingersList.Rows.Clear();
            foreach (var singer in await Repository<Singer>.GetRepo().GetAll())
            {
                SingersList.Rows.Add(singer.ID, singer.FullName, singer.Email);
            }
        }

        private async void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + manager.Login;
            MyName.Text = "Full Name: " + manager.FullName;
            MyEmail.Text = "Email: " + manager.Email;
            if (await Repository<Singer>.GetRepo().GetComponent(manager.SingerID) != null)
            {
                var singer = await Repository<Singer>.GetRepo().GetComponent(manager.SingerID);
                MySingersName.Text = "The name of the singer I represent: " + singer.FullName;
                MySingersEmail.Text = "The Email of the singer I represent: " + singer.Email;
            }
            else
            {
                MySingersName.Text = "The name of the singer I represent: none";
                MySingersEmail.Text = "The Email of the singer I represent: none";
            }
        }

        private async void WriteMessages()
        {
            var messages = await Repository<StatusMessage>.GetRepo().GetAll(m => m.receiver == manager.ID);
            MessagesList.Rows.Clear();
            foreach (var message in messages)
            {
                MessagesList.Rows.Add(message.ID, message.TimeReceiving.ToString("dd.MM HH:mm"), message.text);
            }
        }

        public async void WriteContractProps()
        {
            List<ContractProposal> contracts = await Repository<ContractProposal>
                .GetRepo()
                .GetAll(contract => contract.ManagerID == manager.ID && !contract.IsForSinger);
            OfferedContracts.Rows.Clear();
            foreach (var contract in contracts)
            {
                var singer = await Repository<Singer>.GetRepo().GetComponent(contract.SingerID);
                OfferedContracts.Rows.Add(contract.ID, contract.SingerID, singer.FullName, singer.Email);
            }
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e) // Choose singer
        {
            var singerID = Guid.Parse(SingersList.CurrentRow.Cells[0].Value.ToString());
            if (SingersList.CurrentRow.Cells[0].Value == null)
                return;

            var proposal = await Repository<ContractProposal>.GetRepo().GetFirst(c => c.SingerID == singerID && c.ManagerID == manager.ID);
            if (proposal != null)
                return;

            var Proposal = new ContractProposal()
            {
                ManagerID = manager.ID,
                SingerID = singerID,
                IsForSinger = true
            };
            Repository<ContractProposal>
                .GetRepo()
                .Create(Proposal);

            MessageBox.Show("Success!");
        }

        private async void materialRaisedButton1_Click_1(object sender, EventArgs e) //Creating Consert
        {
            if (await Repository<Singer>.GetRepo().GetComponent(manager.SingerID) == null)
            {
                MessageBox.Show("Representative singer is not exists");
                return;
            }

            UIManager.SwitchForm(this, new CreatingConsert(manager.SingerID), funcs);
        }

        private async void materialRaisedButton2_Click(object sender, EventArgs e) // Delete consert
        {
            if (ConsertsList.CurrentRow.Cells[0].Value == null)
                return;

            Guid consertID = Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString());
            Repository<Consert>
                .GetRepo()
                .Delete(consertID);

            OutputInformation.WriteConsertsInfo(ConsertsList, await Repository<Consert>.GetRepo().GetAll(c => c.SingerID == manager.SingerID));
        }

        private async void ShowAll_Click(object sender, EventArgs e)
        {
            OutputInformation.WriteConsertsInfo(ConsertsList, await Repository<Consert>.GetRepo().GetAll(c => c.SingerID == manager.SingerID));
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e) //Filter
        {
            var settingsPage = new FilterSettings(manager.SingerID);
            UIManager.SwitchForm(this, settingsPage, () => OutputInformation.WriteConsertsInfo(ConsertsList, settingsPage.filteredInfo));
        }

        private async void SeeStatictics_Click(object sender, EventArgs e)
        {
            var consert = await Repository<Consert>
                .GetRepo()
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
            Repository<StatusMessage>.GetRepo().Delete(messageID);

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
                Repository<StatusMessage>.GetRepo().DeleteRange(MessageIDs);
            }

            WriteMessages();
        }

        private async void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            var singerID = Guid.Parse(OfferedContracts.CurrentRow.Cells[1].Value.ToString());
            manager.SingerID = singerID;
            Repository<Manager>
                .GetRepo()
                .Update(manager);

            var proposals = await Repository<ContractProposal>
                .GetRepo()
                .GetAll(contract => contract.SingerID == singerID || contract.ManagerID == manager.ID);
            Repository<ContractProposal>
                .GetRepo()
                .DeleteRange(proposals.ToList());

            var NewMessage = new StatusMessage(singerID, $"Manager {manager.FullName} has accepted your contract offer");
            Repository<StatusMessage>.GetRepo().Create(NewMessage);

            var proposalID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            Repository<ContractProposal>
                .GetRepo()
                .Delete(proposalID);

            WriteContractProps();
            WriteInfoAboutMe();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            var singerID = Guid.Parse(OfferedContracts.CurrentRow.Cells[1].Value.ToString());
            var NewMessage = new StatusMessage(singerID, $"Manager {manager.FullName} rejected your contract offer");
            Repository<StatusMessage>.GetRepo().Create(NewMessage);

            var proposalID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            Repository<ContractProposal>
                .GetRepo()
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

        private async void TerminateContractFunc()
        {
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == manager.SingerID);
            Repository<Consert>
                .GetRepo()
                .DeleteRange(conserts);
            manager.SingerID = default(Guid);
            Repository<Manager>
                .GetRepo()
                .Update(manager);

            ConsertsList.Rows.Clear();
            WriteInfoAboutMe();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                Repository<Manager>.GetRepo().Delete(manager.ID);
                this.Close();
            }
        }
    }
}
