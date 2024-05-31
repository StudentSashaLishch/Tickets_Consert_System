using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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
        private Singer singer { get; set; }

        public SingersForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public SingersForm(Singer singer) : this()
        {
            this.singer = singer;
            InitializeData();
        }

        public async void InitializeData()
        {
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == singer.ID);
            var managers = await Repository<Manager>
                .GetRepo()
                .GetAll();
            var contracts = await Repository<ContractProposal>
                .GetRepo()
                .GetAll(c => c.SingerID == singer.ID && c.IsForSinger);

            OutputInformation.WriteContractProps(OfferedContracts, contracts);
            WriteInfoAboutMe();
            OutputInformation.WritePotentialPartnersInfo<Manager>(ManagersList, managers);
            OutputInformation.WriteConsertsInfo(ConsertsList, conserts);
        }

        public async void WriteContractProps()
        {
            List<ContractProposal> contracts = await Repository<ContractProposal>
                .GetRepo()
                .GetAll(contract => contract.SingerID == singer.ID && contract.IsForSinger);
            OfferedContracts.Rows.Clear();
            foreach (var contract in contracts)
            {
                var manager = await Repository<Manager>.GetRepo().GetComponent(contract.ManagerID);
                OfferedContracts.Rows.Add(contract.ID, manager.FullName, manager.Email);
            }
        }

        public async void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + singer.Login;
            MyName.Text = "Full name: " + singer.FullName;
            MyEmail.Text = "Email: " + singer.Email;

            var myManager = await Repository<Manager>
                .GetRepo()
                .GetFirst(manager => manager.SingerID == singer.ID);
            if (myManager != null)
            {
                MyManagersName.Text = "The name of my manager: " + myManager.FullName;
                MyManagersEmail.Text = "The Email of my manager: " + myManager.Email;
            }
        }

        public async void WriteInfoAboutManagers()
        {
            ManagersList.Rows.Clear();
            foreach(var manager in await Repository<Manager>.GetRepo().GetAll())
            {
                ManagersList.Rows.Add(manager.ID, manager.FullName, manager.Email);
            }
        }

        private async void WriteMessages()
        {
            var messages = await Repository<StatusMessage>
                .GetRepo()
                .GetAll(m => m.receiver == singer.ID);
            MessagesList.Rows.Clear();
            foreach (var message in messages)
            {
                MessagesList.Rows.Add(message.ID, message.TimeReceiving.ToString("dd.MM HH:mm"), message.text);
            }
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            ContractProposal contract = await Repository<ContractProposal>
                .GetRepo()
                .GetFirst(Contract => Contract.ID == ContractID);

            var proposals = await Repository<ContractProposal>
                .GetRepo()
                .GetAll(Contract => Contract.SingerID == singer.ID || Contract.ManagerID == contract.ManagerID);
            Repository<ContractProposal>
                .GetRepo()
                .DeleteRange(proposals.ToList());

            var manager = await Repository<Manager>.GetRepo().GetComponent(contract.ManagerID);
            manager.SingerID = singer.ID;
            Repository<Manager>
                .GetRepo()
                .Update(manager);

            var NewMessage = new StatusMessage(manager.ID, $"Singer {singer.FullName} has accepted your contract offer");
            Repository<StatusMessage>
                .GetRepo()
                .Create(NewMessage);

            Repository<ContractProposal>
                .GetRepo()
                .Delete(ContractID);

            WriteContractProps();
            WriteInfoAboutMe();
        }

        private async void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());

            var contract = await Repository<ContractProposal>
                .GetRepo()
                .GetFirst(Contract => Contract.ID == ContractID);
            var NewMessage = new StatusMessage(contract.ManagerID, $"Singer {singer.FullName} rejected your contract offer");
            Repository<StatusMessage>
                .GetRepo()
                .Create(NewMessage);

            Repository<ContractProposal>
                .GetRepo()
                .Delete(ContractID);
            WriteContractProps();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings(singer.ID);

            UIManager.SwitchForm(this, settingsPage, () => OutputInformation.WriteConsertsInfo(ConsertsList, settingsPage.filteredInfo));
        }

        private async void ShowAll_Click(object sender, EventArgs e)
        {
            OutputInformation.WriteConsertsInfo(ConsertsList, await Repository<Consert>.GetRepo().GetAll(c => c.SingerID == singer.ID));
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

            UIManager.SwitchForm(this, new ConsertStatystic(consert), () => InitializeData());
        }

        private async void ChooseManager_Click(object sender, EventArgs e)
        {
            var managerID = Guid.Parse(ManagersList.CurrentRow.Cells[0].Value.ToString());
            if (ManagersList.CurrentRow.Cells[0].Value == null)
                return;

            var proposal = await Repository<ContractProposal>
                .GetRepo()
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
                .GetRepo()
                .Create(Proposal);

            MessageBox.Show("Success!");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var messageID = Guid.Parse(MessagesList.CurrentRow.Cells[0].Value.ToString());
            Repository<StatusMessage>
                .GetRepo()
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
                    .GetRepo()
                    .DeleteRange(MessageIDs);
            }

            WriteMessages();
        }

        private async void TerminateContract_Click(object sender, EventArgs e)
        {
            if (!await AreThereMyManager())
            {
                MessageBox.Show("You dont have manager");
                return;
            }

            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
                TerminateContractFunc();
        }

        private async void TerminateContractFunc()
        {
            var manager = await Repository<Manager>
                .GetRepo()
                .GetFirst(m => m.SingerID == singer.ID);
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll(c => c.SingerID == singer.ID);
            Repository<Consert>
                .GetRepo()
                .DeleteRange(conserts.ToList());
            manager.SingerID = default(Guid);
            Repository<Manager>
                .GetRepo()
                .Update(manager);

            ConsertsList.Rows.Clear();
            WriteInfoAboutMe();
        }

        private async Task<bool> AreThereMyManager()
        {
            var manager = await Repository<Manager>
                .GetRepo()
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
                    .GetRepo()
                    .Delete(singer.ID);
                this.Close();
            }
        }
    }
}
