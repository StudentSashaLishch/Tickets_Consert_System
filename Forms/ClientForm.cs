using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.Data.Models;
using Tickets_Consert_System.Data.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class ClientForm : MaterialForm
    {
        private Client client { get; set; }

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
            DataInitialize();
        }

        private async void DataInitialize()
        {
            var conserts = await Repository<Consert>
                .GetRepo()
                .GetAll();

            WriteInfoAboutMe();
            WritePurchasedTickets();
            OutputInformation.WriteConsertsInfo(ConsertsList, conserts);
        }

        public async void WritePurchasedTickets()
        {
            TicketsList.Rows.Clear();
            var context = new TicketsConsertSystemContext();
            var query = from ticketSell in context.Tickets
                        join consert in context.Conserts on ticketSell.ConsertID equals consert.ID
                        join singer in context.Singers on consert.SingerID equals singer.ID
                        select new
                        {
                            Concert = consert,
                            TicketSellID = ticketSell.ID,
                            SingerFullName = singer.FullName,
                            //DateOfConsert = consert.DateOfConsert,
                            NumberRow = ticketSell.NumberRow,
                            NumberOfPlace = ticketSell.NumberOfPlace
                        };
            foreach (var ticket in query.ToList())
            {
                var venue = await Repository<Venue>
                    .GetRepo()
                    .GetComponent(ticket.Concert.VenueID);

                TicketsList.Rows.Add(ticket.TicketSellID,
                         ticket.Concert.DateOfConsert.ToString("HH dd.MM.yyyy"),
                         ticket.SingerFullName,
                         venue.Address,
                         ticket.NumberRow,
                         ticket.NumberOfPlace);
            }
            context.Dispose();
        }

        public void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + client.Login;
            MyName.Text = "Full name: " + client.FullName;
            MyEmail.Text = "Email: " + client.Email;
            MyBalance.Text = "Balance: " + client.Ballanse.ToString("#.##");
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e) // Buy ticket
        {
            if (client.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            var consert = await Repository<Consert>
                .GetRepo()
                .GetFirst(Consert => Consert.ID == Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString()));
            if (consert == null)
            {
                MessageBox.Show("This consert doesn't exist");
                return;
            }

            UIManager.SwitchForm(this, new BuyTicket(consert, client), () => DataInitialize());
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings();
            UIManager.SwitchForm(this, settingsPage, () => OutputInformation.WriteConsertsInfo(ConsertsList, settingsPage.filteredInfo));
        }

        private async void ShowAll_Click(object sender, EventArgs e)
        {
            OutputInformation.WriteConsertsInfo(ConsertsList, await Repository<Consert>.GetRepo().GetAll());
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                DeletingInfo.DeleteClient(client.ID);
                this.Close();
            }
        }

        private async void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var concert = await Repository<Consert>
                .GetRepo()
                .GetFirst(Consert => Consert.ID == Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString()));
            var singer = await Repository<Singer>
                .GetRepo()
                .GetComponent(concert.SingerID);

            UIManager.SwitchForm(this, new ReviewOfSinger(singer, client));
        }
    }
}
