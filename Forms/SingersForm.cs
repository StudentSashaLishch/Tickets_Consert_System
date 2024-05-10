using System;
using System.Collections.Generic;
using MaterialSkin;
using MaterialSkin.Controls;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class SingersForm : MaterialForm
    {
        private TicketsConsertSystemContext context = new TicketsConsertSystemContext();

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
            WriteContractProps();
            WriteConsetrsList(Repository<Consert>.GetRepo(context).GetAll());
            WriteInfoAboutMe();
        }

        public void WriteContractProps()
        {
            IEnumerable<ContractProposal> contracts = Repository<ContractProposal>
                .GetRepo(context)
                .GetAll(contract => contract.SingerID == singer.ID);
            OfferedContracts.Rows.Clear();
            foreach(var contract in contracts)
            {
               OfferedContracts.Rows.Add(contract.ID, contract.GetManager().FullName, contract.GetManager().Email);
            }
        }

        public void WriteConsetrsList(IEnumerable<Consert> list)
        {
            ConsertsList.Rows.Clear();
            foreach (var consert in list)
            {
                if (consert.SingerID == singer.ID)
                {
                    ConsertsList.Rows.Add(consert.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.GetSinger().FullName, consert.TicketPrice);
                }
            }
        }

        public void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + singer.Login;
            MyName.Text = "Full name: " + singer.FullName;
            MyEmail.Text = "Email: " + singer.Email;

            var myManager = Repository<Manager>
                .GetRepo(context)
                .GetFirst(manager => manager.GetSinger() != null && manager.SingerID == singer.ID);
            if(myManager != null)
            {
                MyManagersName.Text = "The name of my manager: " + myManager.FullName;
                MyManagersEmail.Text = "The Email of my manager: " + myManager.Email;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            ContractProposal contract = Repository<ContractProposal>
                .GetRepo(context)
                .GetFirst(Contract => Contract.ID == ContractID);

            var manager = contract.GetManager();
            manager.SingerID = singer.ID;
            Repository<Manager>
                .GetRepo(context)
                .Update(manager);

            Repository<ContractProposal>
                .GetRepo(context)
                .Delete(ContractID);
            
            WriteContractProps();
            WriteInfoAboutMe();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            Repository<ContractProposal>
                .GetRepo(context)
                .Delete(ContractID);
            WriteContractProps();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings();

            this.Hide();
            settingsPage.FormClosed += (s, args) =>
            {
                this.Show();
                WriteConsetrsList(settingsPage.filteredInfo);
            };
            settingsPage.Show();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            WriteConsetrsList(Repository<Consert>.GetRepo(context).GetAll());
        }
    }
}
