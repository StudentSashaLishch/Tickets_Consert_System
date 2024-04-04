using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class FilterSettings : MaterialForm
    {
        public FilterSettings()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            minDateOfConsert.CustomFormat = "HH dd.MM.yyyy";
            minDateOfConsert.MinDate = DateTime.Now;
            maxDateOfConsert.CustomFormat = "HH dd.MM.yyyy";
            maxDateOfConsert.MinDate = DateTime.Now.AddDays(1);
        }

        private void FilterSettings_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (!(float.TryParse(MinPrice.Text, out float minPrice) && float.TryParse(MaxPrice.Text, out float maxPrice) && maxPrice >= minPrice && maxDateOfConsert.Value >= minDateOfConsert.Value))
            {
                MessageBox.Show("Invalid data");
                return;
            }
            HandleContracts.PredicateInfo newInfo = delegate (Consert consert)
            {
                if (consert.DateOfConsert >= minDateOfConsert.Value && consert.DateOfConsert <= maxDateOfConsert.Value && consert.TicketPrice >= minPrice && consert.TicketPrice <= maxPrice)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            HandleContracts.FilterByPredicate(newInfo);
        }

        private void MinPrice_Click(object sender, EventArgs e)
        {
           
        }

        private void minDateOfConsert_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
