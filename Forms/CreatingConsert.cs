using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.Forms
{
    public partial class CreatingConsert : MaterialForm
    {
        private TicketsConsertSystemContext context = new TicketsConsertSystemContext();

        public Guid singerID {  get; set; }

        public CreatingConsert()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            dateOfConsert.CustomFormat = "HH dd.MM.yyyy";
            dateOfConsert.MinDate = DateTime.Now.AddDays(1);
        }

        public CreatingConsert(Guid singerID) : this()
        {
            this.singerID = singerID;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(NumberOfRows.Text, out int variableR) && int.TryParse(NumberOfPlaces.Text, out int variablePl) && float.TryParse(PriceTicket.Text, out float variablePr) && variableR > 0 && variablePl > 0 && variablePr > 0)
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
                    .GetRepo(context)
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
