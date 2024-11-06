using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets_Consert_System.Data.Models;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class EditVenue : MaterialForm
    {
        private Guid VenueID { get; set; }

        public EditVenue()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public EditVenue(Guid VenueID, string NameVenue, string Address, int Rows, int PlacesInRow) : this() 
        {
            this.VenueID = VenueID;
            NameOfVenue.Text = NameVenue;
            AddressOfVenue.Text = Address;
            NumberRows.Text = Rows.ToString();
            NumberPlaces.Text = PlacesInRow.ToString();
        }

        private void DoneEdit_Click(object sender, EventArgs e)
        {
            if(int.TryParse(NumberRows.Text, out int rows) && int.TryParse(NumberPlaces.Text, out int places))
            {
                var newVenue = new Venue()
                {
                    Name = NameOfVenue.Text,
                    Address = AddressOfVenue.Text,
                    NumberOfRows = rows,
                    NumberOfPlacesInRow = places
                };

                if (VenueID != null)
                {
                    Repository<Venue>
                        .GetRepo()
                        .Delete(VenueID);

                    newVenue.ID = VenueID;
                }

                Repository<Venue>
                    .GetRepo()
                    .Create(newVenue);

                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Entered data is invalid");
            }
        }

        private void CancelEditing_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
