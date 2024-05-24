using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Linq;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class LogIn : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }
        public LogIn()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //context = new TicketsConsertSystemContext();
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
                    .GetRepo(new TicketsConsertSystemContext())
                    .GetFirst(manager => manager.Login == LoginField.Text);
                
                if (existedManager != null && existedManager.Password == PasswordField.Text)
                {
                    MessageBox.Show("Success!");
                    UIManager.SwitchForm(this, new ManagersForm(existedManager), () => this.Close());
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
            else if (SingerRole.Checked)
            {
                var existedSinger = Repository<Singer>
                    .GetRepo(new TicketsConsertSystemContext())
                    .GetFirst(Singer => Singer.Login == LoginField.Text);
                if (existedSinger != null && existedSinger.Password == PasswordField.Text)
                {
                    MessageBox.Show("Success!");
                    UIManager.SwitchForm(this, new SingersForm(existedSinger), () => this.Close());
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
            else if (ClientRole.Checked)
            {
                var existedClient = Repository<Client>
                    .GetRepo(new TicketsConsertSystemContext())
                    .GetFirst(client => client.Login == LoginField.Text);
                if (existedClient != null && existedClient.Password == PasswordField.Text)
                {
                    MessageBox.Show("Success!");
                    UIManager.SwitchForm(this, new ClientForm(existedClient), () => this.Close());
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e) // View password checkbox
        {
            if (materialCheckBox1.Checked)
                PasswordField.PasswordChar = '*';
            else
                PasswordField.PasswordChar = '\0';
        }
    }
}
