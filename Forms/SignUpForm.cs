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

        private void SignUpForm_Load(object sender, EventArgs e)
        {

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
                var existedManager = HandleUsersInfo.managers.FirstOrDefault(manager => manager.Login == newManager.Login);
                if (existedManager != null)
                {
                    MessageBox.Show("Account with entered login has already exist");
                }
                else
                {
                    HandleUsersInfo.managers.Add(newManager);
                    HandleUsersInfo.WriteManagersInfoIntoFile();
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
                var existedSinger = HandleUsersInfo.singers.FirstOrDefault(singer => singer.Login == newSinger.Login);
                if (existedSinger != null)
                {
                    MessageBox.Show("Account with entered login has already exist");
                }
                else
                {
                    HandleUsersInfo.singers.Add(newSinger);
                    HandleUsersInfo.WriteSingersInfoIntoFiles();
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
                var existedClient = HandleUsersInfo.clients.FirstOrDefault(Client => Client.Login == newClient.Login);
                if (existedClient != null)
                {
                    MessageBox.Show("The account with the entered login already exists");
                }
                else
                {
                    HandleUsersInfo.clients.Add(newClient);
                    HandleUsersInfo.WriteClientsInfoIntoFiles();
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
