using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class ManagersForm : MaterialForm
    {
        public Manager manager {  get; set; }
        public ManagersForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public ManagersForm(Manager manager) : this()
        {
            this.manager = manager;
            //MessageBox.Show($"{manager.RepresentativeSinger.ID}");
            WriteSingersList();
            WriteConsertsList();
            WriteInfoAbouMe();
        }

        private void WriteSingersList()
        {
            SingersList.Rows.Clear();
            foreach(var singer in HandleUsersInfo.singers)
            {
                SingersList.Rows.Add(singer.ID, singer.FullName, singer.Email);
            }
        }

        private void WriteConsertsList()
        {
            ConsertsList.Rows.Clear();
            foreach(var consert in HandleContracts.conserts)
            {
                if(manager.RepresentativeSinger != null && consert.Singer.ID == manager.RepresentativeSinger.ID)
                {
                    ConsertsList.Rows.Add(consert.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.Singer.FullName, consert.TicketPrice);
                }
            }
        }

        private void WriteInfoAbouMe()
        {
            MyLogin.Text = "Login: " + manager.Login;
            MyName.Text = "Full Name: " + manager.FullName;
            MyEmail.Text = "Email: " + manager.Email;
            if(manager.RepresentativeSinger != null)
            {
                MySingersName.Text = "The name of the singer I represent: " + manager.RepresentativeSinger.FullName;
                MySingersEmail.Text = "The Email of the singer I represent: " + manager.RepresentativeSinger.Email;
            }
            else
            {
                MySingersName.Text = "The name of the singer I represent: none";
                MySingersEmail.Text = "The Email of the singer I represent: none";
            }
        }

        private void ManagersForm_Load(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SingersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) // Choose singer
        {
            //int row = SingersList.SelectedCells[0].RowIndex;
            Guid SingerID = Guid.Parse(SingersList.CurrentRow.Cells[0].Value.ToString());
            HandleContracts.NewContractProposal(manager.ID, SingerID);
            MessageBox.Show("Success!");
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            var creating = new CreatingConsert(manager.RepresentativeSinger.ID);
            this.Hide();
            creating.FormClosed += (s, args) =>
            {
                this.Show();
                WriteConsertsList();
            };
            creating.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Guid consertID = Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString());
            HandleContracts.DeleteConsert(consertID);
            WriteConsertsList();
        }
    }
}
