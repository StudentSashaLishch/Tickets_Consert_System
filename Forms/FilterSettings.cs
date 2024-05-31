using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore.Internal;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class FilterSettings : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        private Guid singerID { get; set; }
        public List<Consert> filteredInfo { get; set; }

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
            //context = new TicketsConsertSystemContext();
        }

        public FilterSettings(Guid singerID) : this()
        {
            this.singerID = singerID;
        }

        private async void Filter_Click(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(MinPrice.Text, out decimal minPrice) && decimal.TryParse(MaxPrice.Text, out decimal maxPrice) && maxPrice >= minPrice && maxDateOfConsert.Value >= minDateOfConsert.Value))
            {
                MessageBox.Show("Invalid data");
                return;
            }
            Func<Consert, bool> predicate = (consert) => consert.DateOfConsert >= minDateOfConsert.Value &&
                    consert.DateOfConsert <= maxDateOfConsert.Value &&
                    consert.TicketPrice >= minPrice &&
                    consert.TicketPrice <= maxPrice &&
                    (singerID == default(Guid) || consert.SingerID == singerID);
            filteredInfo = await Repository<Consert>
                .GetRepo()
                .GetAll(predicate);
            this.Close();
        }
    }
}
