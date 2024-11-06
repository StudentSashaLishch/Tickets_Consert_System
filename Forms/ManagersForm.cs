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
        private Manager manager { get; set; }
        public ManagersForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public ManagersForm(Manager manager) : this()
        {
            this.manager = manager;
            DataInitialization();
        }

        private async void DataInitialization()
        {
            var contract = await Repository<Contract>
                .GetRepo()
                .GetFirst(c => c.ID == manager.ContractID);

            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == contract.singer);
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
            if (await Repository<Contract>.GetRepo().GetComponent(manager.ContractID) != null)
            {
                var contract = await Repository<Contract>
                .GetRepo()
                .GetFirst(c => c.ID == manager.ContractID);

                var singer = await Repository<Singer>.GetRepo().GetComponent(contract.singer);
                MySingersName.Text = "The name of the singer I represent: " + singer.FullName;
                MySingersEmail.Text = "The Email of the singer I represent: " + singer.Email;
                costOfServices.Text = "The cost of my services: " + contract.ManagersPrice;
            }
            else
            {
                MySingersName.Text = "The name of the singer I represent: none";
                MySingersEmail.Text = "The Email of the singer I represent: none";
                costOfServices.Text = "The cost of my services: none";
            }
        }

        private async void WriteMessages()
        {
            var messages = await Repository<Data.Models.Message>.GetRepo().GetAll(m => m.receiver == manager.ID);
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
                OfferedContracts.Rows.Add(contract.ID, contract.SingerID, singer.FullName, singer.Email, contract.ManagersPrice);
            }
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e) // Choose singer
        {
            if (manager.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            var singerID = Guid.Parse(SingersList.CurrentRow.Cells[0].Value.ToString());
            if (SingersList.CurrentRow.Cells[0].Value == null)
                return;

            var proposal = await Repository<ContractProposal>.GetRepo().GetFirst(c => c.SingerID == singerID && c.ManagerID == manager.ID);
            if (proposal != null)
                return;

            double managersPrice;
            if (!double.TryParse(ManagersPrice.Text, out managersPrice))
            {
                MessageBox.Show("Enter the cost of your services");
                return;
            }
            

            var Proposal = new ContractProposal()
            {
                ManagerID = manager.ID,
                SingerID = singerID,
                ManagersPrice = managersPrice,
                IsForSinger = true
            };
            Repository<ContractProposal>
                .GetRepo()
                .Create(Proposal);

            MessageBox.Show("Success!");
        }

        private async void materialRaisedButton1_Click_1(object sender, EventArgs e) //Creating Consert
        {
            if(manager.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            if (await Repository<Contract>.GetRepo().GetComponent(manager.ContractID) == null)
            {
                MessageBox.Show("Contract is not exists");
                return;
            }

            var contract = await Repository<Contract>
                .GetRepo()
                .GetComponent(manager.ContractID);

            UIManager.SwitchForm(this, new CreatingConsert(contract.singer, manager.ID), () => DataInitialization());
        }

        private async void materialRaisedButton2_Click(object sender, EventArgs e) // Delete consert
        {
            if (manager.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            if (ConsertsList.CurrentRow.Cells[0].Value == null)
                return;

            Guid consertID = Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString());
            DeletingInfo.DeleteConsert(consertID, true);

            var contract = await Repository<Contract>
                .GetRepo()
                .GetComponent(manager.ContractID);
            OutputInformation.WriteConsertsInfo(ConsertsList, await Repository<Consert>.GetRepo().GetAll(c => c.SingerID == contract.singer));
        }

        private async void ShowAll_Click(object sender, EventArgs e)
        {
            var contract = await Repository<Contract>
                .GetRepo()
                .GetComponent(manager.ContractID);
            OutputInformation.WriteConsertsInfo(ConsertsList, await Repository<Consert>.GetRepo().GetAll(c => c.SingerID == contract.singer));
        }

        private async void materialRaisedButton3_Click(object sender, EventArgs e) //Filter
        {
            var contract = await Repository<Contract>
                .GetRepo()
                .GetComponent(manager.ContractID);
            var settingsPage = new FilterSettings(contract.singer);
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

            UIManager.SwitchForm(this, new ConsertStatystic(consert), () => DataInitialization());
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var messageID = Guid.Parse(MessagesList.CurrentRow.Cells[0].Value.ToString());
            Repository<Data.Models.Message>.GetRepo().Delete(messageID);

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
                Repository<Data.Models.Message>.GetRepo().DeleteRange(MessageIDs);
            }

            WriteMessages();
        }

        private async void materialRaisedButton5_Click(object sender, EventArgs e) //Accept proposal button
        {
            // var singerID = Guid.Parse(OfferedContracts.CurrentRow.Cells[1].Value.ToString());
            if (manager.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            var proposalID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            var proposal = await Repository<ContractProposal>
                .GetRepo()
                .GetComponent(proposalID);

            var contract = new Contract()
            {
                singer = proposal.SingerID,
                manager = proposal.ManagerID,
                ManagersPrice = proposal.ManagersPrice
            };
            Repository<Contract>
                .GetRepo()
                .Create(contract);

            manager.ContractID = contract.ID;
            Repository<Manager>
                .GetRepo()
                .Update(manager);

            var proposals = await Repository<ContractProposal>
                .GetRepo()
                .GetAll(p => p.SingerID == contract.singer || p.ManagerID == manager.ID);
            Repository<ContractProposal>
                .GetRepo()
                .DeleteRange(proposals.ToList());

            var NewMessage = new Data.Models.Message(manager.ID, contract.singer, $"Manager {manager.FullName} has accepted your contract offer");
            Repository<Data.Models.Message>.GetRepo().Create(NewMessage);

            Repository<ContractProposal>
                .GetRepo()
                .Delete(proposalID);

            WriteContractProps();
            WriteInfoAboutMe();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e) //Reject proposal button
        {
            if (manager.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            var singerID = Guid.Parse(OfferedContracts.CurrentRow.Cells[1].Value.ToString());
            var NewMessage = new Data.Models.Message(manager.ID, singerID, $"Manager {manager.FullName} rejected your contract offer");
            Repository<Data.Models.Message>.GetRepo().Create(NewMessage);

            var proposalID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            Repository<ContractProposal>
                .GetRepo()
                .Delete(proposalID);

            WriteContractProps();
            WriteInfoAboutMe();
        }

        private void TerminateContract_Click(object sender, EventArgs e)
        {
            if (manager.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            if (manager.ContractID == default(Guid))
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
            var contract = await Repository<Contract>
                .GetRepo()
                .GetFirst(c => c.manager == manager.ID);
            var singer = await Repository<Singer>
                .GetRepo()
                .GetComponent(contract.singer);
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == singer.ID);

            Repository<Contract>
                .GetRepo()
                .Delete(contract.ID);
            foreach(var consert in conserts)
            {
                DeletingInfo.DeleteConsert(consert.ID, true);
            }

            singer.ContractID = default(Guid);
            Repository<Singer>
                .GetRepo()
                .Update(singer);
            manager.ContractID = default(Guid);
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
                DeletingInfo.DeleteManager(manager.ID);
                this.Close();
            }
        }
    }
}
