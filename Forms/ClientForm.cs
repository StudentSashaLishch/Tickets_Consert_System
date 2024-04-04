using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.client = client;
            WriteConsertsInfo(HandleContracts.conserts);
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
                ConsertsList.Rows.Add(consert.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.Singer.FullName, consert.TicketPrice);
            }
        }

        public void WritePurchasedTickets()
        {
            TicketsList.Rows.Clear();
            foreach(var ticket in HandleContracts.ticketSells)
            {
                if(ticket.ClientID == client.ID)
                {
                    var consert = HandleContracts.conserts.FirstOrDefault(Consert => Consert.ID == ticket.ConsertID);
                    TicketsList.Rows.Add(ticket.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.Singer.FullName, ticket.NumberRow, ticket.NumberOfPlace);
                }
            }
        }

        public void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + client.Login;
            MyName.Text = "Full name: " + client.FullName;
            MyEmail.Text = "Email: " + client.Email;
            MyBalance.Text = "Balance: " + client.Ballanse.ToString();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) // Buy ticket
        {
            var consert = HandleContracts.conserts.FirstOrDefault(Consert => Consert.ID == Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString()));
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
                WriteConsertsInfo(HandleContracts.conserts);
            };
            BuyTick.Show();
        }

        private void PurchasedTicks_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings();

            this.Hide();
            settingsPage.FormClosed += (s, args) =>
            {
                this.Show();
                WriteConsertsInfo(HandleContracts.filteredConserts);
            };
            settingsPage.Show();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            WriteConsertsInfo(HandleContracts.conserts);
        }
    }
}
