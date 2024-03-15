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
    public partial class SingersForm : MaterialForm
    {
        private Singer singer { get; set; }

        public SingersForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public SingersForm(Singer singer) : this()
        {
            this.singer = singer;
            WriteContractProps();
            WriteConsetrsList();
            WriteInfoAboutMe();
        }

        public void WriteContractProps()
        {
            OfferedContracts.Rows.Clear();
            foreach(var contract in HandleContracts.contractsProp)
            {
                if(contract.Singer.ID == singer.ID)
                {
                    OfferedContracts.Rows.Add(contract.ID, contract.OfferManager.FullName, contract.OfferManager.Email);
                }
            }
        }

        public void WriteConsetrsList()
        {
            ConsertsList.Rows.Clear();
            foreach (var consert in HandleContracts.conserts)
            {
                if (consert.Singer.ID == singer.ID)
                {
                    ConsertsList.Rows.Add(consert.ID, consert.DateOfConsert.ToString("HH dd.MM.yyyy"), consert.Singer.FullName, consert.TicketPrice);
                }
            }
        }

        public void WriteInfoAboutMe()
        {
            MyLogin.Text = "Login: " + singer.Login;
            MyName.Text = "Full name: " + singer.FullName;
            MyEmail.Text = "Email: " + singer.Email;

            var myManager = HandleUsersInfo.managers.FirstOrDefault(manager => manager.RepresentativeSinger != null && manager.RepresentativeSinger.ID == singer.ID);
            if(myManager != null)
            {
                MyManagersName.Text = "The name of my manager: " + myManager.FullName;
                MyManagersEmail.Text = "The Email of my manager: " + myManager.Email;
            }
        }

        private void SingersForm_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            ContractProposal contract = HandleContracts.contractsProp.FirstOrDefault(Contract => Contract.ID == ContractID);

            contract.OfferManager.RepresentativeSinger = singer;
            HandleUsersInfo.WriteManagersInfoIntoFile();

            HandleContracts.DeleteContractProposal(ContractID);
            WriteContractProps();
            //MessageBox.Show("Success!");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Guid ContractID = Guid.Parse(OfferedContracts.CurrentRow.Cells[0].Value.ToString());
            HandleContracts.DeleteContractProposal(ContractID);
            WriteContractProps();
            //MessageBox.Show("Success!");
        }
    }
}
