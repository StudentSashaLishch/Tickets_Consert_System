using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using Tickets_Consert_System.Data.Models;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class AdminsForm : MaterialForm
    {
        private static string password = "12345";
        private Func<User, bool> predicate = null;

        public AdminsForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            ChangeAdminsInterface(false);
            ChangePasswordInterface(true);
        }

        public void InitializeData()
        {
            OutputVenues();
            OutputClients();
            OutputManagers();
            OutputSingers();
        }

        public async void OutputClients()
        {
            ClientsInfo.Rows.Clear();
            var clients = await Repository<Client>
                .GetRepo()
                .GetAll(predicate);

            foreach (var client in clients)
            {
                ClientsInfo.Rows.Add(client.ID, client.FullName, client.Login, client.Ballanse, client.IsBanned);
            }
        }

        public async void OutputManagers()
        {
            ManagersInfo.Rows.Clear();
            var managers = await Repository<Manager>
               .GetRepo()
               .GetAll(predicate);

            foreach (var manager in managers)
            {
                var singer = await Repository<Singer>
                    .GetRepo()
                    .GetFirst(s => s.ContractID == manager.ContractID);
                ManagersInfo.Rows.Add(manager.ID, manager.FullName, manager.Login, singer.FullName, manager.IsBanned);
            }
        }

        public async void OutputSingers()
        {
            SingersInfo.Rows.Clear();
            var singers = await Repository<Singer>
               .GetRepo()
               .GetAll(predicate);

            foreach (var singer in singers)
            {
                var manager = await Repository<Manager>
                    .GetRepo()
                    .GetFirst(m => m.ContractID == singer.ContractID);
                SingersInfo.Rows.Add(singer.ID, singer.FullName, singer.Login, manager.FullName, singer.IsBanned);
            }
        }

        public async void OutputVenues()
        {
            VenuesInfo.Rows.Clear();
            var venues = await Repository<Venue>
                .GetRepo()
                .GetAll();

            foreach (var venue in venues)
            {
                VenuesInfo.Rows.Add(venue.ID, venue.Name, venue.Address, venue.NumberOfRows, venue.NumberOfPlacesInRow);
            }
        }

        private void HidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (HidePassword.Checked == true)
                PasswordField.UseSystemPasswordChar = true;
            else
                PasswordField.UseSystemPasswordChar = false;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (PasswordField.Text == password)
            {
                ChangePasswordInterface(false);
                ChangeAdminsInterface(true);
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }

        private void ChangePasswordInterface(bool isEnable) // disables or enables components of interface which responces for entering password
        {
            HidePassword.Enabled = isEnable;
            HidePassword.Visible = isEnable;
            PasswordField.Enabled = isEnable;
            PasswordField.Visible = isEnable;
            EnterButton.Enabled = isEnable;
            EnterButton.Visible = isEnable;

        }

        private void ChangeAdminsInterface(bool isEnable) // dasables or enables components of interface for admin's work
        {
            AdminsInterface.Enabled = isEnable;
            AdminsInterface.Visible = isEnable;
            materialTabSelector1.Enabled = isEnable;
            materialTabSelector1.Visible = isEnable;
        }

        private void BanUser_Click(object sender, EventArgs e)
        {
            var ClientID = Guid.Parse(ClientsInfo.CurrentRow.Cells[0].Value.ToString());
            AdminActions.ChangeBanStatuc(ClientID, User.Role.Client, true);
            OutputClients();
        }

        private void ForgiveTheUser_Click(object sender, EventArgs e)
        {
            var ClientID = Guid.Parse(ClientsInfo.CurrentRow.Cells[0].Value.ToString());
            AdminActions.ChangeBanStatuc(ClientID, User.Role.Client, false);
            OutputClients();
        }

        private void BanManager_Click(object sender, EventArgs e)
        {
            var ManagerID = Guid.Parse(ManagersInfo.CurrentRow.Cells[0].Value.ToString());
            AdminActions.ChangeBanStatuc(ManagerID, User.Role.Manager, true);
            OutputManagers();
        }

        private void ForgiveManager_Click(object sender, EventArgs e)
        {
            var ManagerID = Guid.Parse(ManagersInfo.CurrentRow.Cells[0].Value.ToString());
            AdminActions.ChangeBanStatuc(ManagerID, User.Role.Manager, false);
            OutputManagers();
        }

        private void BanSinger_Click(object sender, EventArgs e)
        {
            var SingerID = Guid.Parse(SingersInfo.CurrentRow.Cells[0].Value.ToString());
            AdminActions.ChangeBanStatuc(SingerID, User.Role.Singer, true);
            OutputSingers();
        }

        private void ForgiveSinger_Click(object sender, EventArgs e)
        {
            var SingerID = Guid.Parse(SingersInfo.CurrentRow.Cells[0].Value.ToString());
            AdminActions.ChangeBanStatuc(SingerID, User.Role.Singer, false);
            OutputSingers();
        }

        private void CreateVenue_Click(object sender, EventArgs e)
        {
            UIManager.SwitchForm(this, new EditVenue(), () => InitializeData());
        }

        private async void AlterVenue_Click(object sender, EventArgs e)
        {
            var VenueID = Guid.Parse(VenuesInfo.CurrentRow.Cells[0].Value.ToString());
            var venue = await Repository<Venue>
                .GetRepo()
                .GetComponent(VenueID);

            if (venue == null)
            {
                MessageBox.Show("This venue does not exist");
                OutputVenues();
                return;
            }

            UIManager.SwitchForm(this,
                new EditVenue(venue.ID, venue.Name, venue.Address, venue.NumberOfRows, venue.NumberOfPlacesInRow),
                () => InitializeData());
        }

        private void DeleteVenue_Click(object sender, EventArgs e)
        {
            var VenueID = Guid.Parse(VenuesInfo.CurrentRow.Cells[0].Value.ToString());
            Repository<Venue>
                .GetRepo()
                .Delete(VenueID);

            MessageBox.Show("Success");
            OutputVenues();
        }

        private void ShowBanned_Click(object sender, EventArgs e)
        {
            predicate = u => u.IsBanned == true;
        }

        private void ShowNotBanned_Click(object sender, EventArgs e)
        {
            predicate = u => u.IsBanned == true;
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            predicate = null;
        }
    }
}
