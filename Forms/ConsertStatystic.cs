﻿using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class ConsertStatystic : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        private Consert Consert { get; set; }

        public ConsertStatystic()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //context = new TicketsConsertSystemContext();
        }

        public ConsertStatystic(Consert consert) : this()
        {
            this.Consert = consert;
            ViewStatystic();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ConsertHall.Size = new Size(250, 250);
            float SizeRectangle = 250;
            float widthCell = SizeRectangle / Consert.NumberPlacesInRow;
            float heightCell = SizeRectangle / Consert.NumberRows;

            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.Gray);
            Pen pen = new Pen(Color.Black, 1);

            //drawing info about taked places
            var ticketSells = Repository<TicketSell>.GetRepo(new TicketsConsertSystemContext())
                .GetAll(t => t.ConsertID == Consert.ID);
            foreach (var ticketSell in ticketSells)
            {
                brush = new SolidBrush(Color.Red);

                graphics.FillRectangle(brush, (ticketSell.NumberOfPlace - 1) * widthCell, (ticketSell.NumberRow - 1) * heightCell, widthCell, heightCell);
            }

            for (int i = 1; i <= Consert.NumberPlacesInRow; i++) //drawing of vertical lines
                graphics.DrawLine(pen, i * widthCell, 0, i * widthCell, SizeRectangle);
            for (int i = 1; i <= Consert.NumberRows; i++) //drawing of horizontal lines
                graphics.DrawLine(pen, 0, i * heightCell, SizeRectangle, i * heightCell);
            graphics.DrawRectangle(pen, 0, 0, SizeRectangle, SizeRectangle);
        }

        private void BuyButton_Click(object sender, System.EventArgs e)
        {
            ConsertHall.Invalidate();
            ViewStatystic();
        }

        private void ViewStatystic()
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
            int CountTickets = Repository<TicketSell>.GetRepo(new TicketsConsertSystemContext()).GetAll(t => t.ConsertID == Consert.ID).Count();
            decimal Cash = CountTickets * Consert.TicketPrice;

            SoldTickets.Text = $"Total number of tickets sold: {CountTickets}";
            CashCollection.Text = $"Cash collection: {Cash}";
        }
    }
}
