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
    public partial class ManagersForm : MaterialForm
    {
        private TicketsConsertSystemContext context = new TicketsConsertSystemContext();

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
            WriteSingersList();
            WriteConsertsList(Repository<Consert>.GetRepo(context).GetAll());
            WriteInfoAbouMe();
        }

        private void WriteSingersList()
        {
            SingersList.Rows.Clear();
            foreach(var singer in Repository<Singer>.GetRepo(context).GetAll())
            {
                SingersList.Rows.Add(singer.ID, singer.FullName, singer.Email);
            }
        }

        private void WriteConsertsList(IEnumerable<Consert> list)
        {
            ConsertsList.Rows.Clear();
            foreach(var consert in list)
            {
                if(manager.GetSinger() != null && consert.SingerID == manager.SingerID)
                {
                    ConsertsList.Rows.Add(consert.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.GetSinger().FullName, consert.TicketPrice);
                }
            }
        }

        private void WriteInfoAbouMe()
        {
            MyLogin.Text = "Login: " + manager.Login;
            MyName.Text = "Full Name: " + manager.FullName;
            MyEmail.Text = "Email: " + manager.Email;
            if(manager.GetSinger() != null)
            {
                MySingersName.Text = "The name of the singer I represent: " + manager.GetSinger().FullName;
                MySingersEmail.Text = "The Email of the singer I represent: " + manager.GetSinger().Email;
            }
            else
            {
                MySingersName.Text = "The name of the singer I represent: none";
                MySingersEmail.Text = "The Email of the singer I represent: none";
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) // Choose singer
        {
            if (SingersList.CurrentRow.Cells[0].Value == null)
                return;

            var Proposal = new ContractProposal()
            {
                ManagerID = manager.ID,
                SingerID = Guid.Parse(SingersList.CurrentRow.Cells[0].Value.ToString())
            };
            Repository<ContractProposal>
                .GetRepo(context)
                .Create(Proposal);

            MessageBox.Show("Success!");
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            if (manager.GetSinger() == null)
            {
                MessageBox.Show("Representative singer is not exists");
                return;
            }
                
            var creating = new CreatingConsert(manager.SingerID);
            this.Hide();
            creating.FormClosed += (s, args) =>
            {
                this.Show();
                WriteConsertsList(Repository<Consert>.GetRepo(context).GetAll());
            };
            creating.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (ConsertsList.CurrentRow.Cells[0].Value == null)
                return;

            Guid consertID = Guid.Parse(ConsertsList.CurrentRow.Cells[0].Value.ToString());
            Repository<Consert>
                .GetRepo(context)
                .Delete(consertID);

            WriteConsertsList(Repository<Consert>.GetRepo(context).GetAll());
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            WriteConsertsList(Repository<Consert>.GetRepo(context).GetAll());
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var settingsPage = new FilterSettings();

            this.Hide();
            settingsPage.FormClosed += (s, args) =>
            {
                this.Show();
                WriteConsertsList(settingsPage.filteredInfo);
            };
            settingsPage.Show();
        }
    }
}
