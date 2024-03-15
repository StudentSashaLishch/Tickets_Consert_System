using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class CreatingConsert : MaterialForm
    {
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

        private void CreatingConsert_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(NumberOfRows.Text, out int variableR) && int.TryParse(NumberOfPlaces.Text, out int variablePl) && float.TryParse(PriceTicket.Text, out float variablePr) && variableR > 0 && variablePl > 0 && variablePr > 0)
            {
                HandleContracts.NewConsert(dateOfConsert.Value, singerID, variableR, variablePl, variablePr);
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Invalid data!");
            }
        }
    }
}
