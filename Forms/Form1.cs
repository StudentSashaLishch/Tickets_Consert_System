using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using Tickets_Consert_System.Forms;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.UtilityClasses;
using Tickets_Consert_System.MainClasses;
using System.Linq;
using Tickets_Consert_System.Data.Models;

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

            DeletePastConserts();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            UIManager.SwitchForm(this, new SignUpForm());
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            UIManager.SwitchForm(this, new LogIn());
        }
        
        private void DeletePastConserts()
        {
            var pastConserts = Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .GetAll(consert => consert.DateOfConsert < DateTime.Now);

            Repository<Consert>
                .GetRepo(new TicketsConsertSystemContext())
                .DeleteRange(pastConserts.ToList());
        }
    }
}
