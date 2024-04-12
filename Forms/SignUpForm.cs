using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class SignUpForm : MaterialForm
    {
        public SignUpForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) // RegisterButton
        {
            if (LoginField.Text == null || PasswordField.Text == null || FullNameField.Text == null || EmailField.Text == null || (!ManagerRole.Checked && !SingerRole.Checked && !ClientRole.Checked))
            {
                MessageBox.Show("Not all information has entered!");
                return;
            }
            
            if (ManagerRole.Checked)
            {
                var newManager = new Manager(LoginField.Text, PasswordField.Text, FullNameField.Text, EmailField.Text);
                var existedManager = Repository<Manager>
                    .GetRepo(PathesOfFiles._ManagersFileName)
                    .GetFirst(manager => manager.Login == newManager.Login);
                if (existedManager != null)
                {
                    MessageBox.Show("Account with entered login has already exist");
                }
                else
                {
                    Repository<Manager>
                        .GetRepo(PathesOfFiles._ManagersFileName)
                        .Create(newManager);
                    MessageBox.Show("Succsses!");

                    var workPage = new ManagersForm(newManager);
                    this.Hide();
                    workPage.FormClosed += (s, args) =>
                    {
                        this.Close();
                    };
                    workPage.Show();
                }
            }
            else if (SingerRole.Checked)
            {
                var newSinger = new Singer(LoginField.Text, PasswordField.Text, FullNameField.Text, EmailField.Text);
                var existedSinger = Repository<Singer>
                    .GetRepo(PathesOfFiles._SingersFileName)
                    .GetFirst(singer => singer.Login == newSinger.Login);
                if (existedSinger != null)
                {
                    MessageBox.Show("Account with entered login has already exist");
                }
                else
                {
                    Repository<Singer>
                        .GetRepo(PathesOfFiles._SingersFileName)
                        .Create(newSinger);
                    MessageBox.Show("Succsses!");

                    var workPage = new SingersForm(newSinger);
                    this.Hide();
                    workPage.FormClosed += (s, args) =>
                    {
                        this.Close();
                    };
                    workPage.Show();
                }
            }
            else if (ClientRole.Checked)
            {
                var newClient = new Client(LoginField.Text, PasswordField.Text, FullNameField.Text, EmailField.Text);
                var existedClient = Repository<Client>
                    .GetRepo(PathesOfFiles._ClientsFileName)
                    .GetFirst(Client => Client.Login == newClient.Login);
                if (existedClient != null)
                {
                    MessageBox.Show("The account with the entered login already exists");
                }
                else
                {
                    Repository<Client>
                        .GetRepo(PathesOfFiles._ClientsFileName)
                        .Create(newClient);
                    MessageBox.Show("Succsses!");

                    var workPage = new ClientForm(newClient);
                    this.Hide();
                    workPage.FormClosed += (s, args) =>
                    {
                        this.Close();
                    };
                    workPage.Show();
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) // Cansel button
        {
            this.Close();
        }
    }
}
