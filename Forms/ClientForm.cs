using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class ClientForm : MaterialForm
    {
        public Client client { get; set; }

        public ClientForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public ClientForm(Client client) : this()
        {
            var conserts = Repository<Consert>
                                .GetRepo(PathesOfFiles._ConsertsInfoNameFile)
                                .GetAll();
            this.client = client;
            WriteConsertsInfo(conserts);
            WritePurchasedTickets();
            WriteInfoAboutMe();
        }

        public void WriteConsertsInfo(List<Consert> list)
        {
            ConsertsList.Rows.Clear();
            if (list == null)
            {
                return;
            }

            foreach (var consert in list)
            {
                ConsertsList.Rows.Add(consert.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.GetSinger().FullName, consert.TicketPrice);
            }
        }

        public void WritePurchasedTickets()
        {
            var ticketSells = Repository<TicketSell>
                                    .GetRepo(PathesOfFiles._SealedTicketsNameFile)
                                    .GetAll(ticket => ticket.ClientID == client.ID);
            TicketsList.Rows.Clear();
            foreach(var ticket in ticketSells)
            {
                    var consert = Repository<Consert>
                        .GetRepo(PathesOfFiles._ConsertsInfoNameFile)
                        .GetFirst(Consert => Consert.ID == ticket.ConsertID);
                    TicketsList.Rows.Add(ticket.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.GetSinger().FullName, ticket.NumberRow, ticket.NumberOfPlace);
            }
        }

        public void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + client.Login;
            MyName.Text = "Full name: " + client.FullName;
            MyEmail.Text = "Email: " + client.Email;
            MyBalance.Text = "Balance: " + client.Ballanse.ToString();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) // Buy ticket
        {
            var consert = Repository<Consert>
                .GetRepo(PathesOfFiles._ConsertsInfoNameFile)
                .GetFirst(Consert => Consert.ID == Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString()));
            if(consert == null)
            {
                MessageBox.Show("This consert doesn't exist");
                return;
            }
            var BuyTick = new BuyTicket(consert, client);
            this.Hide();
            BuyTick.FormClosed += (s, args) =>
            {
                this.Show();
                WritePurchasedTickets();
                WriteInfoAboutMe();
                WriteConsertsInfo(Repository<Consert>.GetRepo(PathesOfFiles._ConsertsInfoNameFile).GetAll());
            };
            BuyTick.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings();

            this.Hide();
            settingsPage.FormClosed += (s, args) =>
            {
                this.Show();
                WriteConsertsInfo(settingsPage.filteredInfo);
            };
            settingsPage.Show();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            WriteConsertsInfo(Repository<Consert>.GetRepo(PathesOfFiles._ConsertsInfoNameFile).GetAll());
        }
    }
}
