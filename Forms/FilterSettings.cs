using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class FilterSettings : MaterialForm
    {
        private TicketsConsertSystemContext context = new TicketsConsertSystemContext();
        public IEnumerable<Consert> filteredInfo { get; set; }

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

        private void Filter_Click(object sender, EventArgs e)
        {
            if (!(float.TryParse(MinPrice.Text, out float minPrice) && float.TryParse(MaxPrice.Text, out float maxPrice) && maxPrice >= minPrice && maxDateOfConsert.Value >= minDateOfConsert.Value))
            {
                MessageBox.Show("Invalid data");
                return;
            }
            Func<Consert, bool> newInfo = delegate (Consert consert)
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

             filteredInfo = Repository<Consert>
                            .GetRepo(context)
                            .GetAll(newInfo);
        }
    }
}
