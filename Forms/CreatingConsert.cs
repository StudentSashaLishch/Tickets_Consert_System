using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class CreatingConsert : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }

        public Guid singerID {  get; set; }

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

        public CreatingConsert(Guid singerID) : this()
        {
            this.singerID = singerID;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(NumberOfRows.Text, out int variableR) && int.TryParse(NumberOfPlaces.Text, out int variablePl) && decimal.TryParse(PriceTicket.Text, out decimal variablePr) && variableR > 0 && variablePl > 0 && variablePr > 0 && variablePl <= 200 && variablePr <= 200)
            {
                var consert = new Consert()
                {
                    DateOfConsert = dateOfConsert.Value,
                    SingerID = singerID,
                    NumberPlacesInRow = variablePl,
                    NumberRows = variableR,
                    TicketPrice = variablePr
                };
                Repository<Consert>
                    .GetRepo()
                    .Create(consert);

                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Invalid data!");
            }
        }
    }
}
