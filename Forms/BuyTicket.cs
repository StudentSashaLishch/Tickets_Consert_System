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
    public partial class BuyTicket : MaterialForm
    {
        public Client Client {  get; set; }
        public Consert Consert { get; set; }
        public BuyTicket()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public BuyTicket(Consert consert, Client client) : this()
        {
            this.Consert = consert;
            this.Client = client;

        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(NumberOfRow.Text, out int variableR) || !int.TryParse(NumberOfPlace.Text, out int variableP) || variableR > Consert.NumberRows || variableP > Consert.NumberPlacesInRow)
            {
                MessageBox.Show("Invalid data!");
            }
            else if (HandleContracts.IsSealedTicket(Consert.ID, variableP, variableP))
            {
                MessageBox.Show("This ticket has already sealed!");
            }
            else if (Client.Ballanse < Consert.TicketPrice)
            {
                MessageBox.Show("Not enough money!");
            }
            else
            {
                HandleContracts.NewTicketSell(Client.ID, Consert.ID, variableR, variableP);
                Client.Ballanse -= Consert.TicketPrice;
                HandleUsersInfo.WriteClientsInfoIntoFiles();
                MessageBox.Show("Success");
            }
        }
    }
}
