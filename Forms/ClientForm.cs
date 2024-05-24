using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.Data.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class ClientForm : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        private UIManager.initOldForm funcs { get; set; }

        public Client client { get; set; }

        public ClientForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //context = new TicketsConsertSystemContext();
        }

        public ClientForm(Client client) : this()
        {
            var conserts = Repository<Consert>
                                .GetRepo(new TicketsConsertSystemContext())
                                .GetAll();

            this.client = client;
            funcs = WriteInfoAboutMe;
            funcs += WritePurchasedTickets;
            funcs += () => WriteConsertsInfo(conserts);

            funcs();
        }

        public void WriteConsertsInfo(IEnumerable<Consert> list)
        {
            ConsertsList.Rows.Clear();
            if (list == null)
                return;

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
                if(list.FirstOrDefault(c => c.ID == consert.ConsertID) != null)
                    ConsertsList.Rows.Add(consert.ConsertID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.SingersName, consert.Price, consert.CountTickets);
            }
        }

        public void WritePurchasedTickets()
        {
            TicketsList.Rows.Clear();
            var context = new TicketsConsertSystemContext();
            var query = from ticketSell in context.Tickets
                        join consert in context.Conserts on ticketSell.ConsertID equals consert.ID
                        join singer in context.Singers on consert.SingerID equals singer.ID
                        select new
                        {
                            TicketSellID = ticketSell.ID,
                            DateOfConsert = consert.DateOfConsert,
                            SingerFullName = singer.FullName,
                            NumberRow = ticketSell.NumberRow,
                            NumberOfPlace = ticketSell.NumberOfPlace
                        };
            foreach (var ticket in query.ToList())
            {
                TicketsList.Rows.Add(ticket.TicketSellID, ticket.DateOfConsert.ToString("HH dd.MM.yyyy"), ticket.SingerFullName, ticket.NumberRow, ticket.NumberOfPlace);
            }
            context.Dispose();
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
                .GetRepo(new TicketsConsertSystemContext())
                .GetFirst(Consert => Consert.ID == Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString()));
            if (consert == null)
            {
                MessageBox.Show("This consert doesn't exist");
                return;
            }

            UIManager.SwitchForm(this, new BuyTicket(consert, client), funcs);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings();
            UIManager.SwitchForm(this, settingsPage, () => WriteConsertsInfo(settingsPage.filteredInfo));
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            WriteConsertsInfo(Repository<Consert>.GetRepo(new TicketsConsertSystemContext()).GetAll());
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you shure?", "Terminating Contract", MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                Repository<Client>.GetRepo(new TicketsConsertSystemContext()).Delete(client.ID);
                this.Close();
            }
        }
    }
}
