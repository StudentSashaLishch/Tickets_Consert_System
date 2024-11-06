namespace Tickets_Consert_System.Forms
{
    partial class SingersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SingersTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.Managers = new System.Windows.Forms.TabPage();
            this.ManagersPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ChooseManager = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManagersList = new System.Windows.Forms.DataGridView();
            this.ManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameOfManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailOfManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractProposals = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OfferedContracts = new System.Windows.Forms.DataGridView();
            this.ProposalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsertsInfo = new System.Windows.Forms.TabPage();
            this.SeeStatictics = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ShowAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ConsertsList = new System.Windows.Forms.DataGridView();
            this.ConsertID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenueAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Messages = new System.Windows.Forms.TabPage();
            this.RemoveAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Remove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MessagesList = new System.Windows.Forms.DataGridView();
            this.MyInfo = new System.Windows.Forms.TabPage();
            this.TerminateContract = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteAccount = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MyManagersEmail = new System.Windows.Forms.Label();
            this.MyManagersName = new System.Windows.Forms.Label();
            this.MyEmail = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.MyLogin = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfReceiving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersTabs.SuspendLayout();
            this.Managers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersList)).BeginInit();
            this.ContractProposals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfferedContracts)).BeginInit();
            this.ConsertsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).BeginInit();
            this.Messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesList)).BeginInit();
            this.MyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SingersTabs
            // 
            this.SingersTabs.Controls.Add(this.Managers);
            this.SingersTabs.Controls.Add(this.ContractProposals);
            this.SingersTabs.Controls.Add(this.ConsertsInfo);
            this.SingersTabs.Controls.Add(this.Messages);
            this.SingersTabs.Controls.Add(this.MyInfo);
            this.SingersTabs.Depth = 0;
            this.SingersTabs.Location = new System.Drawing.Point(11, 123);
            this.SingersTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.SingersTabs.Name = "SingersTabs";
            this.SingersTabs.SelectedIndex = 0;
            this.SingersTabs.Size = new System.Drawing.Size(937, 334);
            this.SingersTabs.TabIndex = 0;
            // 
            // Managers
            // 
            this.Managers.Controls.Add(this.ManagersPrice);
            this.Managers.Controls.Add(this.ChooseManager);
            this.Managers.Controls.Add(this.ManagersList);
            this.Managers.Location = new System.Drawing.Point(4, 25);
            this.Managers.Name = "Managers";
            this.Managers.Size = new System.Drawing.Size(929, 305);
            this.Managers.TabIndex = 3;
            this.Managers.Text = "Managers";
            // 
            // ManagersPrice
            // 
            this.ManagersPrice.Depth = 0;
            this.ManagersPrice.Hint = "";
            this.ManagersPrice.Location = new System.Drawing.Point(705, 267);
            this.ManagersPrice.MaxLength = 32767;
            this.ManagersPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManagersPrice.Name = "ManagersPrice";
            this.ManagersPrice.PasswordChar = '\0';
            this.ManagersPrice.SelectedText = "";
            this.ManagersPrice.SelectionLength = 0;
            this.ManagersPrice.SelectionStart = 0;
            this.ManagersPrice.Size = new System.Drawing.Size(176, 28);
            this.ManagersPrice.TabIndex = 3;
            this.ManagersPrice.TabStop = false;
            this.ManagersPrice.Text = "Enter the sum";
            this.ManagersPrice.UseSystemPasswordChar = false;
            // 
            // ChooseManager
            // 
            this.ChooseManager.AutoSize = true;
            this.ChooseManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChooseManager.Depth = 0;
            this.ChooseManager.Icon = null;
            this.ChooseManager.Location = new System.Drawing.Point(705, 3);
            this.ChooseManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChooseManager.Name = "ChooseManager";
            this.ChooseManager.Primary = true;
            this.ChooseManager.Size = new System.Drawing.Size(176, 36);
            this.ChooseManager.TabIndex = 2;
            this.ChooseManager.Text = "Choose Manager";
            this.ChooseManager.UseVisualStyleBackColor = true;
            this.ChooseManager.Click += new System.EventHandler(this.ChooseManager_Click);
            // 
            // ManagersList
            // 
            this.ManagersList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ManagersList.ColumnHeadersHeight = 29;
            this.ManagersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManagerID,
            this.FullNameOfManager,
            this.EmailOfManager});
            this.ManagersList.GridColor = System.Drawing.SystemColors.Window;
            this.ManagersList.Location = new System.Drawing.Point(3, 3);
            this.ManagersList.Name = "ManagersList";
            this.ManagersList.RowHeadersVisible = false;
            this.ManagersList.RowHeadersWidth = 51;
            this.ManagersList.RowTemplate.Height = 24;
            this.ManagersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManagersList.Size = new System.Drawing.Size(696, 292);
            this.ManagersList.TabIndex = 1;
            // 
            // ManagerID
            // 
            this.ManagerID.HeaderText = "Manager ID";
            this.ManagerID.MinimumWidth = 6;
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.Visible = false;
            this.ManagerID.Width = 125;
            // 
            // FullNameOfManager
            // 
            this.FullNameOfManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FullNameOfManager.HeaderText = "Full Name of Manager";
            this.FullNameOfManager.MinimumWidth = 6;
            this.FullNameOfManager.Name = "FullNameOfManager";
            this.FullNameOfManager.Width = 168;
            // 
            // EmailOfManager
            // 
            this.EmailOfManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EmailOfManager.HeaderText = "Email of Manager";
            this.EmailOfManager.MinimumWidth = 6;
            this.EmailOfManager.Name = "EmailOfManager";
            this.EmailOfManager.Width = 141;
            // 
            // ContractProposals
            // 
            this.ContractProposals.Controls.Add(this.materialRaisedButton2);
            this.ContractProposals.Controls.Add(this.materialRaisedButton1);
            this.ContractProposals.Controls.Add(this.OfferedContracts);
            this.ContractProposals.Location = new System.Drawing.Point(4, 25);
            this.ContractProposals.Name = "ContractProposals";
            this.ContractProposals.Padding = new System.Windows.Forms.Padding(3);
            this.ContractProposals.Size = new System.Drawing.Size(929, 305);
            this.ContractProposals.TabIndex = 0;
            this.ContractProposals.Text = "Contract Proposals";
            this.ContractProposals.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(708, 61);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Reject";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(708, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(87, 36);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Accept";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // OfferedContracts
            // 
            this.OfferedContracts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OfferedContracts.ColumnHeadersHeight = 29;
            this.OfferedContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProposalID,
            this.FullName,
            this.Email,
            this.CostServices});
            this.OfferedContracts.GridColor = System.Drawing.SystemColors.Window;
            this.OfferedContracts.Location = new System.Drawing.Point(6, 6);
            this.OfferedContracts.Name = "OfferedContracts";
            this.OfferedContracts.RowHeadersVisible = false;
            this.OfferedContracts.RowHeadersWidth = 51;
            this.OfferedContracts.RowTemplate.Height = 24;
            this.OfferedContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OfferedContracts.Size = new System.Drawing.Size(696, 293);
            this.OfferedContracts.TabIndex = 1;
            // 
            // ProposalID
            // 
            this.ProposalID.HeaderText = "Proposal ID";
            this.ProposalID.MinimumWidth = 6;
            this.ProposalID.Name = "ProposalID";
            this.ProposalID.Visible = false;
            this.ProposalID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FullName.HeaderText = "Full Name of Manager";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 168;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Email.HeaderText = "Email of Manager";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 141;
            // 
            // CostServices
            // 
            this.CostServices.HeaderText = "Cost of services";
            this.CostServices.MinimumWidth = 6;
            this.CostServices.Name = "CostServices";
            this.CostServices.Width = 125;
            // 
            // ConsertsInfo
            // 
            this.ConsertsInfo.Controls.Add(this.SeeStatictics);
            this.ConsertsInfo.Controls.Add(this.ShowAll);
            this.ConsertsInfo.Controls.Add(this.materialRaisedButton3);
            this.ConsertsInfo.Controls.Add(this.ConsertsList);
            this.ConsertsInfo.Location = new System.Drawing.Point(4, 25);
            this.ConsertsInfo.Name = "ConsertsInfo";
            this.ConsertsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ConsertsInfo.Size = new System.Drawing.Size(929, 305);
            this.ConsertsInfo.TabIndex = 2;
            this.ConsertsInfo.Text = "Information About Conserts";
            this.ConsertsInfo.UseVisualStyleBackColor = true;
            // 
            // SeeStatictics
            // 
            this.SeeStatictics.AutoSize = true;
            this.SeeStatictics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeeStatictics.Depth = 0;
            this.SeeStatictics.Icon = null;
            this.SeeStatictics.Location = new System.Drawing.Point(689, 91);
            this.SeeStatictics.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeeStatictics.Name = "SeeStatictics";
            this.SeeStatictics.Primary = true;
            this.SeeStatictics.Size = new System.Drawing.Size(151, 36);
            this.SeeStatictics.TabIndex = 8;
            this.SeeStatictics.Text = "See statistics";
            this.SeeStatictics.UseVisualStyleBackColor = true;
            this.SeeStatictics.Click += new System.EventHandler(this.SeeStatictics_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.AutoSize = true;
            this.ShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowAll.Depth = 0;
            this.ShowAll.Icon = null;
            this.ShowAll.Location = new System.Drawing.Point(689, 49);
            this.ShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Primary = true;
            this.ShowAll.Size = new System.Drawing.Size(106, 36);
            this.ShowAll.TabIndex = 7;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(689, 6);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(76, 36);
            this.materialRaisedButton3.TabIndex = 6;
            this.materialRaisedButton3.Text = "Filter";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // ConsertsList
            // 
            this.ConsertsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.ColumnHeadersHeight = 29;
            this.ConsertsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsertID,
            this.DateOfConsert,
            this.SingersName,
            this.VenueAddress,
            this.TicketsPrice,
            this.CountTickets});
            this.ConsertsList.GridColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.Location = new System.Drawing.Point(6, 6);
            this.ConsertsList.Name = "ConsertsList";
            this.ConsertsList.RowHeadersVisible = false;
            this.ConsertsList.RowHeadersWidth = 51;
            this.ConsertsList.RowTemplate.Height = 24;
            this.ConsertsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsertsList.Size = new System.Drawing.Size(677, 292);
            this.ConsertsList.TabIndex = 2;
            // 
            // ConsertID
            // 
            this.ConsertID.HeaderText = "ConsertID";
            this.ConsertID.MinimumWidth = 6;
            this.ConsertID.Name = "ConsertID";
            this.ConsertID.Visible = false;
            this.ConsertID.Width = 125;
            // 
            // DateOfConsert
            // 
            this.DateOfConsert.HeaderText = "Date Of Consert";
            this.DateOfConsert.MinimumWidth = 6;
            this.DateOfConsert.Name = "DateOfConsert";
            this.DateOfConsert.Width = 125;
            // 
            // SingersName
            // 
            this.SingersName.HeaderText = "Name of Singer";
            this.SingersName.MinimumWidth = 6;
            this.SingersName.Name = "SingersName";
            this.SingersName.Width = 125;
            // 
            // VenueAddress
            // 
            this.VenueAddress.HeaderText = "Address of venue";
            this.VenueAddress.MinimumWidth = 6;
            this.VenueAddress.Name = "VenueAddress";
            this.VenueAddress.Width = 125;
            // 
            // TicketsPrice
            // 
            this.TicketsPrice.HeaderText = "Ticket Price";
            this.TicketsPrice.MinimumWidth = 6;
            this.TicketsPrice.Name = "TicketsPrice";
            this.TicketsPrice.Width = 125;
            // 
            // CountTickets
            // 
            this.CountTickets.HeaderText = "Count of tickets";
            this.CountTickets.MinimumWidth = 6;
            this.CountTickets.Name = "CountTickets";
            this.CountTickets.Width = 125;
            // 
            // Messages
            // 
            this.Messages.Controls.Add(this.RemoveAll);
            this.Messages.Controls.Add(this.Remove);
            this.Messages.Controls.Add(this.MessagesList);
            this.Messages.Location = new System.Drawing.Point(4, 25);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(929, 305);
            this.Messages.TabIndex = 4;
            this.Messages.Text = "Messages";
            this.Messages.UseVisualStyleBackColor = true;
            // 
            // RemoveAll
            // 
            this.RemoveAll.AutoSize = true;
            this.RemoveAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveAll.Depth = 0;
            this.RemoveAll.Icon = null;
            this.RemoveAll.Location = new System.Drawing.Point(705, 45);
            this.RemoveAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Primary = true;
            this.RemoveAll.Size = new System.Drawing.Size(124, 36);
            this.RemoveAll.TabIndex = 7;
            this.RemoveAll.Text = "Remove all";
            this.RemoveAll.UseVisualStyleBackColor = true;
            this.RemoveAll.Click += new System.EventHandler(this.RemoveAll_Click);
            // 
            // Remove
            // 
            this.Remove.AutoSize = true;
            this.Remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Remove.Depth = 0;
            this.Remove.Icon = null;
            this.Remove.Location = new System.Drawing.Point(705, 3);
            this.Remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.Remove.Name = "Remove";
            this.Remove.Primary = true;
            this.Remove.Size = new System.Drawing.Size(90, 36);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // MessagesList
            // 
            this.MessagesList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MessagesList.ColumnHeadersHeight = 29;
            this.MessagesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DateOfReceiving,
            this.dataGridViewTextBoxColumn2});
            this.MessagesList.GridColor = System.Drawing.SystemColors.Window;
            this.MessagesList.Location = new System.Drawing.Point(3, 3);
            this.MessagesList.Name = "MessagesList";
            this.MessagesList.RowHeadersVisible = false;
            this.MessagesList.RowHeadersWidth = 51;
            this.MessagesList.RowTemplate.Height = 24;
            this.MessagesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MessagesList.Size = new System.Drawing.Size(696, 292);
            this.MessagesList.TabIndex = 5;
            // 
            // MyInfo
            // 
            this.MyInfo.Controls.Add(this.TerminateContract);
            this.MyInfo.Controls.Add(this.DeleteAccount);
            this.MyInfo.Controls.Add(this.MyManagersEmail);
            this.MyInfo.Controls.Add(this.MyManagersName);
            this.MyInfo.Controls.Add(this.MyEmail);
            this.MyInfo.Controls.Add(this.MyName);
            this.MyInfo.Controls.Add(this.MyLogin);
            this.MyInfo.Location = new System.Drawing.Point(4, 25);
            this.MyInfo.Name = "MyInfo";
            this.MyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.MyInfo.Size = new System.Drawing.Size(929, 305);
            this.MyInfo.TabIndex = 1;
            this.MyInfo.Text = "Information About Me";
            this.MyInfo.UseVisualStyleBackColor = true;
            // 
            // TerminateContract
            // 
            this.TerminateContract.AutoSize = true;
            this.TerminateContract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TerminateContract.Depth = 0;
            this.TerminateContract.Icon = null;
            this.TerminateContract.Location = new System.Drawing.Point(9, 220);
            this.TerminateContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.TerminateContract.Name = "TerminateContract";
            this.TerminateContract.Primary = true;
            this.TerminateContract.Size = new System.Drawing.Size(247, 36);
            this.TerminateContract.TabIndex = 11;
            this.TerminateContract.Text = "Terminate the Contract";
            this.TerminateContract.UseVisualStyleBackColor = true;
            this.TerminateContract.Click += new System.EventHandler(this.TerminateContract_Click);
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.AutoSize = true;
            this.DeleteAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAccount.Depth = 0;
            this.DeleteAccount.Icon = null;
            this.DeleteAccount.Location = new System.Drawing.Point(9, 262);
            this.DeleteAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Primary = true;
            this.DeleteAccount.Size = new System.Drawing.Size(166, 36);
            this.DeleteAccount.TabIndex = 10;
            this.DeleteAccount.Text = "Delete Account";
            this.DeleteAccount.UseVisualStyleBackColor = true;
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // MyManagersEmail
            // 
            this.MyManagersEmail.AutoSize = true;
            this.MyManagersEmail.Location = new System.Drawing.Point(6, 78);
            this.MyManagersEmail.Name = "MyManagersEmail";
            this.MyManagersEmail.Size = new System.Drawing.Size(169, 16);
            this.MyManagersEmail.TabIndex = 9;
            this.MyManagersEmail.Text = "The Email of  my manager: ";
            // 
            // MyManagersName
            // 
            this.MyManagersName.AutoSize = true;
            this.MyManagersName.Location = new System.Drawing.Point(6, 62);
            this.MyManagersName.Name = "MyManagersName";
            this.MyManagersName.Size = new System.Drawing.Size(166, 16);
            this.MyManagersName.TabIndex = 8;
            this.MyManagersName.Text = "The name of my manager: ";
            // 
            // MyEmail
            // 
            this.MyEmail.AutoSize = true;
            this.MyEmail.Location = new System.Drawing.Point(6, 35);
            this.MyEmail.Name = "MyEmail";
            this.MyEmail.Size = new System.Drawing.Size(47, 16);
            this.MyEmail.TabIndex = 7;
            this.MyEmail.Text = "Email: ";
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Location = new System.Drawing.Point(6, 19);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(71, 16);
            this.MyName.TabIndex = 6;
            this.MyName.Text = "Full name: ";
            // 
            // MyLogin
            // 
            this.MyLogin.AutoSize = true;
            this.MyLogin.Location = new System.Drawing.Point(6, 3);
            this.MyLogin.Name = "MyLogin";
            this.MyLogin.Size = new System.Drawing.Size(46, 16);
            this.MyLogin.TabIndex = 5;
            this.MyLogin.Text = "Login: ";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.SingersTabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 94);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1157, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "MessageID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // DateOfReceiving
            // 
            this.DateOfReceiving.HeaderText = "Date";
            this.DateOfReceiving.MinimumWidth = 6;
            this.DateOfReceiving.Name = "DateOfReceiving";
            this.DateOfReceiving.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Text";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // SingersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 471);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.SingersTabs);
            this.Name = "SingersForm";
            this.Text = "SingersForm";
            this.SingersTabs.ResumeLayout(false);
            this.Managers.ResumeLayout(false);
            this.Managers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersList)).EndInit();
            this.ContractProposals.ResumeLayout(false);
            this.ContractProposals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfferedContracts)).EndInit();
            this.ConsertsInfo.ResumeLayout(false);
            this.ConsertsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).EndInit();
            this.Messages.ResumeLayout(false);
            this.Messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesList)).EndInit();
            this.MyInfo.ResumeLayout(false);
            this.MyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl SingersTabs;
        private System.Windows.Forms.TabPage ContractProposals;
        private System.Windows.Forms.TabPage MyInfo;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage ConsertsInfo;
        private System.Windows.Forms.DataGridView OfferedContracts;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.DataGridView ConsertsList;
        private System.Windows.Forms.Label MyManagersEmail;
        private System.Windows.Forms.Label MyManagersName;
        private System.Windows.Forms.Label MyEmail;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.Label MyLogin;
        private MaterialSkin.Controls.MaterialRaisedButton ShowAll;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton SeeStatictics;
        private System.Windows.Forms.TabPage Managers;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.DataGridView ManagersList;
        private MaterialSkin.Controls.MaterialRaisedButton ChooseManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameOfManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailOfManager;
        private MaterialSkin.Controls.MaterialRaisedButton RemoveAll;
        private MaterialSkin.Controls.MaterialRaisedButton Remove;
        private System.Windows.Forms.DataGridView MessagesList;
        private MaterialSkin.Controls.MaterialRaisedButton TerminateContract;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteAccount;
        private MaterialSkin.Controls.MaterialSingleLineTextField ManagersPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProposalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsertID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfReceiving;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}