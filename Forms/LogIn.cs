using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Linq;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.Forms
{
    public partial class LogIn : MaterialForm
    {
        private TicketsConsertSystemContext context = new TicketsConsertSystemContext();
        public LogIn()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) //Close button
        {
            var mainPage = new Form1();
            mainPage.Show();
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (LoginField.Text == null || PasswordField.Text == null || (!ManagerRole.Checked && !SingerRole.Checked && !ClientRole.Checked))
            {
                MessageBox.Show("Not all information has entered!");
                return;
            }

            if (ManagerRole.Checked)
            {
                var existedManager = Repository<Manager>
                    .GetRepo(context)
                    .GetFirst(manager => manager.Login == LoginField.Text);
                
                if (existedManager != null && existedManager.Password == PasswordField.Text)
                {
                    MessageBox.Show("Success!");

                    var workPage = new ManagersForm(existedManager);

                    this.Hide();
                    workPage.FormClosed += (s, args) =>
                    {
                        this.Close();
                    };
                    workPage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
            else if (SingerRole.Checked)
            {
                var existedSinger = Repository<Singer>
                    .GetRepo(context)
                    .GetFirst(Singer => Singer.Login == LoginField.Text);
                if (existedSinger != null && existedSinger.Password == PasswordField.Text)
                {
                    MessageBox.Show("Success!");

                    var workPage = new SingersForm(existedSinger);
                    this.Hide();
                    workPage.FormClosed += (s, args) =>
                    {
                        this.Close();
                    };
                    workPage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
            else if (ClientRole.Checked)
            {
                var existedClient = Repository<Client>
                    .GetRepo(context)
                    .GetFirst(client => client.Login == LoginField.Text);
                if (existedClient != null && existedClient.Password == PasswordField.Text)
                {
                    MessageBox.Show("Success!");

                    var workPage = new ClientForm(existedClient);
                    this.Hide();
                    workPage.FormClosed += (s, args) =>
                    {
                        this.Close();
                    };
                    workPage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
        }
    }
}
