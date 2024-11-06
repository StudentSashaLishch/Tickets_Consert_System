using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.Data.Models;

namespace Tickets_Consert_System.Forms
{
    public partial class CreatingConsert : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }

        public Guid singerID {  get; set; }
        public Guid managerID { get; set; }
        private Venue venue { get; set; }

        public CreatingConsert()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            dateOfConsert.CustomFormat = "HH dd.MM.yyyy";
            dateOfConsert.MinDate = DateTime.Now.AddDays(1);
            //context = new TicketsConsertSystemContext();

            
        }

        private async void LoadVenues()
        {
            var venues = await Repository<Venue>
                .GetRepo()
                .GetAll();

            foreach (var venue in venues)
            {
                VenueInfo.Items.Add(venue);
            }
        }

        public CreatingConsert(Guid singerID, Guid managerID) : this()
        {
            this.singerID = singerID;
            this.managerID = managerID;
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e) // create concert button
        {
            if (VenueInfo.SelectedItem is Venue selectedVenue && decimal.TryParse(PriceTicket.Text, out decimal variablePr))
            {
                var existedConcert = await Repository<Consert>
                    .GetRepo()
                    .GetFirst(c => c.VenueID == selectedVenue.ID && c.DateOfConsert == dateOfConsert.Value);
                if (existedConcert != null)
                {
                    MessageBox.Show("At the entered time, a concert is already planned at this place");
                    return;
                }

                var consert = new Consert()
                {
                    SingerID = singerID,
                    DateOfConsert = dateOfConsert.Value,
                    VenueID = selectedVenue.ID,
                    TicketPrice = variablePr
                };
                Repository<Consert>
                    .GetRepo()
                    .Create(consert);

                var message = new Data.Models.Message(managerID, singerID, $"New consert has created, date of the consert is {dateOfConsert.Value}");
                Repository<Data.Models.Message>
                    .GetRepo()
                    .Create(message);

                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Invalid data!");
            }
        }
    }
}
