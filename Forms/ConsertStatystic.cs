using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;
using System.Deployment.Internal;
using Tickets_Consert_System.Data.Models;

namespace Tickets_Consert_System.Forms
{
    public partial class ConsertStatystic : MaterialForm
    {
        private Consert Consert { get; set; }
        private List<TicketSell> tickets { get; set; }
        private Venue Venue { get; set; }
        

        public ConsertStatystic()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            InitializeComponent();

            //context = new TicketsConsertSystemContext();
        }

        private async void InitializeVenue()
        {
            Venue = await Repository<Venue>
                .GetRepo()
                .GetComponent(Consert.VenueID);
        }

        public ConsertStatystic(Consert consert) : this()
        {
            this.Consert = consert;
            ViewStatystic();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ConsertHall.Size = new Size(250, 250);
            int SizeRectangle = 250;
            int widthCell = SizeRectangle / Venue.NumberOfPlacesInRow;
            int heightCell = SizeRectangle / Venue.NumberOfRows;

            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.Gray);
            Pen pen = new Pen(Color.Black, 1);

            //drawing info about taked places
            GetTickets();
            if (tickets != null)
            {
                foreach (var ticketSell in tickets)
                {
                    brush = new SolidBrush(Color.Red);

                    graphics.FillRectangle(brush, (ticketSell.NumberOfPlace - 1) * widthCell, (ticketSell.NumberRow - 1) * heightCell, widthCell, heightCell);
                }
            }
             
            for (int i = 1; i <= Venue.NumberOfPlacesInRow; i++) //drawing of vertical lines
                graphics.DrawLine(pen, i * widthCell, 0, i * widthCell, SizeRectangle);
            for (int i = 1; i <= Venue.NumberOfRows; i++) //drawing of horizontal lines
                graphics.DrawLine(pen, 0, i * heightCell, SizeRectangle, i * heightCell);
            graphics.DrawRectangle(pen, 0, 0, SizeRectangle, SizeRectangle);
        }

        private void BuyButton_Click(object sender, System.EventArgs e)
        {
            ConsertHall.Invalidate();
            ViewStatystic();
        }

        private async void ViewStatystic()
        {
            /*
            var SoldTickets = context.Tickets
                .GroupBy(t => t.ConsertID)
                .Select(s => new
                {
                    ConsetID = s.Key,
                    CountTickets = s.Count()
                });
            */
            var Tickets = await Repository<TicketSell>.GetRepo().GetAll(t => t.ConsertID == Consert.ID);
            var CountTickets = Tickets.Count;

            decimal Cash = CountTickets * Consert.TicketPrice;

            SoldTickets.Text = $"Total number of tickets sold: {CountTickets}";
            CashCollection.Text = $"Cash collection: {Cash}";
        }

        private async void GetTickets()
        {
            tickets = await Repository<TicketSell>.GetRepo()
                .GetAll(t => t.ConsertID == Consert.ID);
        }
    }
}
