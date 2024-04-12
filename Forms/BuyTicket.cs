using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class BuyTicket : MaterialForm
    {
        public Client Client {  get; set; }
        public Consert Consert { get; set; }
        public BuyTicket()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public BuyTicket(Consert consert, Client client) : this()
        {
            this.Consert = consert;
            this.Client = client;

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(NumberOfRow.Text, out int variableR) || !int.TryParse(NumberOfPlace.Text, out int variableP) || variableR > Consert.NumberRows || variableP > Consert.NumberPlacesInRow || variableP <= 0 || variableR <= 0)
            {
                MessageBox.Show("Invalid data!");
            }
            else if (Repository<TicketSell>.GetRepo(PathesOfFiles._SealedTicketsNameFile).GetFirst(tick => Consert.ID == tick.ConsertID && variableR == tick.NumberRow && variableP == tick.NumberOfPlace) != null)
            {
                MessageBox.Show("This ticket has already sealed!");
            }
            else if (Client.Ballanse < Consert.TicketPrice)
            {
                MessageBox.Show("Not enough money!");
            }
            else
            {
                TicketSell ticketSell = new TicketSell()
                {
                    ClientID = Client.ID,
                    ConsertID = Consert.ID,
                    NumberOfPlace = variableP,
                    NumberRow = variableR
                };

                Repository<TicketSell>
                    .GetRepo(PathesOfFiles._SealedTicketsNameFile)
                    .Create(ticketSell);

                Client.Ballanse -= Consert.TicketPrice;
                Repository<Client>
                    .GetRepo(PathesOfFiles._ClientsFileName)
                    .Update(Client);

                MessageBox.Show("Success!");
            }
        }
    }
}
