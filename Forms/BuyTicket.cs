using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.Data.Models;

namespace Tickets_Consert_System.Forms
{
    public partial class BuyTicket : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        private Client Client {  get; set; }
        private  Consert Consert { get; set; }
        private List<TicketSell> tickets {  get; set; }
        private Venue Venue { get; set; }
        public BuyTicket()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            InitializeVenue();
            //context = new TicketsConsertSystemContext();
        }

        public async void InitializeVenue()
        {
            Venue = await Repository<Venue>
                .GetRepo()
                .GetComponent(Consert.VenueID);
        }

        public BuyTicket(Consert consert, Client client) : this()
        {
            this.Consert = consert;
            this.Client = client;
        }

        private async void BuyButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(NumberOfRow.Text, out int variableR) || !int.TryParse(NumberOfPlace.Text, out int variableP) || variableR > Venue.NumberOfRows || variableP > Venue.NumberOfPlacesInRow || variableP <= 0 || variableR <= 0)
            {
                MessageBox.Show("Invalid data!");
            }
            else if ( await Repository<TicketSell>.GetRepo().GetFirst(tick => Consert.ID == tick.ConsertID && variableR == tick.NumberRow && variableP == tick.NumberOfPlace) != null)
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
                    .GetRepo()
                    .Create(ticketSell);

                Client.Ballanse -= Consert.TicketPrice;
                Repository<Client>
                    .GetRepo()
                    .Update(Client);

                Consert.CountSoldTickets++;
                Repository<Consert>
                    .GetRepo()
                    .Update(Consert);

                MessageBox.Show("Success!");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Size = new Size(250, 250);
            float SizeRectangle = 250;
            float widthCell = SizeRectangle / Venue.NumberOfPlacesInRow;
            float heightCell = SizeRectangle / Venue.NumberOfRows;

            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.Gray);
            Pen pen = new Pen(Color.Black, 1);

            //drawing info about taked places
            GetTickets();
            if (tickets != null)
            {
                foreach (var ticketSell in tickets)
                {
                    if (ticketSell.ClientID == Client.ID)
                        brush = new SolidBrush(Color.Blue);
                    else
                        brush = new SolidBrush(Color.Red);

                    graphics.FillRectangle(brush, (ticketSell.NumberOfPlace - 1) * widthCell, (ticketSell.NumberRow - 1) * heightCell, widthCell, heightCell);
                }
            }
            brush = new SolidBrush(Color.Green);
            if (int.TryParse(NumberOfPlace.Text, out int place) && int.TryParse(NumberOfRow.Text, out int row) && (0 < place && place <= Venue.NumberOfPlacesInRow) && (0 < row && row <= Venue.NumberOfRows))
                graphics.FillRectangle(brush, (place - 1) * widthCell, (row - 1) * heightCell, widthCell, heightCell);

            for (int i = 1; i <= Venue.NumberOfPlacesInRow; i++) //drawing of vertical lines
                graphics.DrawLine(pen, i * widthCell, 0, i * widthCell, SizeRectangle);
            for (int i = 1; i <= Venue.NumberOfRows; i++) //drawing of horizontal lines
                graphics.DrawLine(pen, 0, i * heightCell, SizeRectangle, i * heightCell);
            graphics.DrawRectangle(pen, 0, 0, SizeRectangle, SizeRectangle);
        }

        private void NumberOfRow_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void NumberOfPlace_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private async void GetTickets()
        {
            tickets = await Repository<TicketSell>.GetRepo()
                .GetAll(t => t.ConsertID == Consert.ID);
        }
    }
}
