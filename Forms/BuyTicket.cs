using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Drawing;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.Forms
{
    public partial class BuyTicket : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        public Client Client {  get; set; }
        public  Consert Consert{ get; set; }
        public BuyTicket()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //context = new TicketsConsertSystemContext();
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
            else if (Repository<TicketSell>.GetRepo(new TicketsConsertSystemContext()).GetFirst(tick => Consert.ID == tick.ConsertID && variableR == tick.NumberRow && variableP == tick.NumberOfPlace) != null)
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
                    .GetRepo(new TicketsConsertSystemContext())
                    .Create(ticketSell);

                Client.Ballanse -= Consert.TicketPrice;
                Repository<Client>
                    .GetRepo(new TicketsConsertSystemContext())
                    .Update(Client);

                MessageBox.Show("Success!");
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Size = new Size(250, 250);
            float SizeRectangle = 250;
            float widthCell = SizeRectangle / Consert.NumberPlacesInRow;
            float heightCell = SizeRectangle / Consert.NumberRows;

            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.Gray);
            Pen pen = new Pen(Color.Black, 1);

            //drawing info about taked places
            var ticketSells = Repository<TicketSell>.GetRepo(new TicketsConsertSystemContext())
                .GetAll(t => t.ConsertID == Consert.ID);
            foreach(var ticketSell in ticketSells)
            {
                if(ticketSell.ClientID == Client.ID)
                    brush = new SolidBrush(Color.Blue);
                else
                    brush = new SolidBrush(Color.Red);

                graphics.FillRectangle(brush, (ticketSell.NumberOfPlace - 1) * widthCell, (ticketSell.NumberRow - 1) * heightCell, widthCell, heightCell);
            }
            brush = new SolidBrush(Color.Green);
            if (int.TryParse(NumberOfPlace.Text, out int place) && int.TryParse(NumberOfRow.Text, out int row) && (0 < place && place <= Consert.NumberPlacesInRow) && (0 < row && row <= Consert.NumberRows))
                graphics.FillRectangle(brush, (place - 1) * widthCell, (row - 1) * heightCell, widthCell, heightCell);

            for (int i = 1; i <= Consert.NumberPlacesInRow; i++) //drawing of vertical lines
                graphics.DrawLine(pen, i * widthCell, 0, i * widthCell, SizeRectangle);
            for (int i = 1; i <= Consert.NumberRows; i++) //drawing of horizontal lines
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
    }
}
