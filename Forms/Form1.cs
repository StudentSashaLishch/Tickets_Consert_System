using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using Tickets_Consert_System.Forms;

namespace Tickets_Consert_System
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void SwitchForm(Form newForm)
        {
            Hide();
            newForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            newForm.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SwitchForm(new SignUpForm());
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            SwitchForm(new LogIn());
        }  
    }
}
