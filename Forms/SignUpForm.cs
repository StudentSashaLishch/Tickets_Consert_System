using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.Data.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class SignUpForm : MaterialForm
    {
        //private TicketsConsertSystemContext context { get; set; }

        public SignUpForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //context = new TicketsConsertSystemContext();
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e) // RegisterButton
        {
            if (LoginField.Text == null || PasswordField.Text == null || FullNameField.Text == null || EmailField.Text == null || (!ManagerRole.Checked && !SingerRole.Checked && !ClientRole.Checked) || !CheckPassword())
            {
                MessageBox.Show("Not all information has entered correctly!");
                return;
            }

            if (ManagerRole.Checked)
            {
                if (await Validator.ValidateLogin(LoginField.Text, User.Role.Manager) && Validator.ValidateEmail(EmailField.Text))
                {
                    var newManager = new Manager(LoginField.Text, PasswordField.Text, FullNameField.Text, EmailField.Text);
                    Repository<Manager>
                        .GetRepo()
                        .Create(newManager);
                    MessageBox.Show("Succsses!");

                    UIManager.SwitchForm(this, new ManagersForm(newManager), () => this.Close());
                }
                else
                {
                    MessageBox.Show("Invalid login or e-mail");
                }
            }
            else if (SingerRole.Checked)
            {
                if (await Validator.ValidateLogin(LoginField.Text, User.Role.Singer) && Validator.ValidateEmail(EmailField.Text))
                {
                    var newSinger = new Singer(LoginField.Text, PasswordField.Text, FullNameField.Text, EmailField.Text);
                    Repository<Singer>
                        .GetRepo()
                        .Create(newSinger);
                    MessageBox.Show("Succsses!");

                    UIManager.SwitchForm(this, new SingersForm(newSinger), () => this.Close());
                }
                else
                {
                    MessageBox.Show("Invalid login or e-mail");
                }
            }
            else if (ClientRole.Checked)
            {
                if(await Validator.ValidateLogin(LoginField.Text, User.Role.Client) &&  Validator.ValidateEmail(EmailField.Text))
                {
                    var newClient = new Client(LoginField.Text, PasswordField.Text, FullNameField.Text, EmailField.Text);
                    Repository<Client>
                        .GetRepo()
                        .Create(newClient);
                    MessageBox.Show("Succsses!");

                    UIManager.SwitchForm(this, new ClientForm(newClient), () => this.Close());
                }
                else
                {
                    MessageBox.Show("Invalid login or e-mail");
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) // Cansel button
        {
            this.Close();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e) // View password checkbox
        {
            if (materialCheckBox1.Checked)
            {
                PasswordField.PasswordChar = '*';
                RepeatPasswordField.PasswordChar = '*';
            }
            else
            {
                PasswordField.PasswordChar = '\0';
                RepeatPasswordField.PasswordChar = '\0';
            }
        }

        private bool CheckPassword()
        {
            if(PasswordField.Text == RepeatPasswordField.Text)
                return true;
            else
                return false;
        }
    }
}
