namespace Tickets_Consert_System.Forms
{
    partial class ManagersForm
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
            this.ManagersMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Singers = new System.Windows.Forms.TabPage();
            this.ChooseSinger = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SingersList = new System.Windows.Forms.DataGridView();
            this.SingerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractProposals = new System.Windows.Forms.TabPage();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OfferedContracts = new System.Windows.Forms.DataGridView();
            this.ProposalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsertsManager = new System.Windows.Forms.TabPage();
            this.SeeStatictics = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ShowAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ConsertsList = new System.Windows.Forms.DataGridView();
            this.Messages = new System.Windows.Forms.TabPage();
            this.RemoveAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Remove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MessagesList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfReceiving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyInfo = new System.Windows.Forms.TabPage();
            this.TerminateContract = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteAccount = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MySingersEmail = new System.Windows.Forms.Label();
            this.MySingersName = new System.Windows.Forms.Label();
            this.MyEmail = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.MyLogin = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.ConsertID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagersMenu.SuspendLayout();
            this.Singers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingersList)).BeginInit();
            this.ContractProposals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfferedContracts)).BeginInit();
            this.ConsertsManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).BeginInit();
            this.Messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesList)).BeginInit();
            this.MyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagersMenu
            // 
            this.ManagersMenu.Controls.Add(this.Singers);
            this.ManagersMenu.Controls.Add(this.ContractProposals);
            this.ManagersMenu.Controls.Add(this.ConsertsManager);
            this.ManagersMenu.Controls.Add(this.Messages);
            this.ManagersMenu.Controls.Add(this.MyInfo);
            this.ManagersMenu.Depth = 0;
            this.ManagersMenu.Location = new System.Drawing.Point(12, 111);
            this.ManagersMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManagersMenu.Name = "ManagersMenu";
            this.ManagersMenu.SelectedIndex = 0;
            this.ManagersMenu.Size = new System.Drawing.Size(884, 327);
            this.ManagersMenu.TabIndex = 0;
            // 
            // Singers
            // 
            this.Singers.Controls.Add(this.ChooseSinger);
            this.Singers.Controls.Add(this.SingersList);
            this.Singers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Singers.Location = new System.Drawing.Point(4, 25);
            this.Singers.Name = "Singers";
            this.Singers.Padding = new System.Windows.Forms.Padding(3);
            this.Singers.Size = new System.Drawing.Size(876, 298);
            this.Singers.TabIndex = 1;
            this.Singers.Text = "Singers";
            this.Singers.UseVisualStyleBackColor = true;
            // 
            // ChooseSinger
            // 
            this.ChooseSinger.AutoSize = true;
            this.ChooseSinger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChooseSinger.Depth = 0;
            this.ChooseSinger.Icon = null;
            this.ChooseSinger.Location = new System.Drawing.Point(705, 3);
            this.ChooseSinger.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChooseSinger.Name = "ChooseSinger";
            this.ChooseSinger.Primary = true;
            this.ChooseSinger.Size = new System.Drawing.Size(153, 36);
            this.ChooseSinger.TabIndex = 1;
            this.ChooseSinger.Text = "Choose Singer";
            this.ChooseSinger.UseVisualStyleBackColor = true;
            this.ChooseSinger.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // SingersList
            // 
            this.SingersList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SingersList.ColumnHeadersHeight = 29;
            this.SingersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerID,
            this.FullName,
            this.Email});
            this.SingersList.GridColor = System.Drawing.SystemColors.Window;
            this.SingersList.Location = new System.Drawing.Point(3, 3);
            this.SingersList.Name = "SingersList";
            this.SingersList.RowHeadersVisible = false;
            this.SingersList.RowHeadersWidth = 51;
            this.SingersList.RowTemplate.Height = 24;
            this.SingersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SingersList.Size = new System.Drawing.Size(696, 292);
            this.SingersList.TabIndex = 0;
            // 
            // SingerID
            // 
            this.SingerID.HeaderText = "SingerID";
            this.SingerID.MinimumWidth = 6;
            this.SingerID.Name = "SingerID";
            this.SingerID.Visible = false;
            this.SingerID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FullName.HeaderText = "Full Name of Singer";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 212;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Email.HeaderText = "Email of Singer";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 172;
            // 
            // ContractProposals
            // 
            this.ContractProposals.Controls.Add(this.materialRaisedButton4);
            this.ContractProposals.Controls.Add(this.materialRaisedButton5);
            this.ContractProposals.Controls.Add(this.OfferedContracts);
            this.ContractProposals.Location = new System.Drawing.Point(4, 25);
            this.ContractProposals.Name = "ContractProposals";
            this.ContractProposals.Size = new System.Drawing.Size(876, 298);
            this.ContractProposals.TabIndex = 5;
            this.ContractProposals.Text = "Contract Proposals";
            this.ContractProposals.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(705, 45);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(83, 36);
            this.materialRaisedButton4.TabIndex = 5;
            this.materialRaisedButton4.Text = "Reject";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = null;
            this.materialRaisedButton5.Location = new System.Drawing.Point(705, 3);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(87, 36);
            this.materialRaisedButton5.TabIndex = 4;
            this.materialRaisedButton5.Text = "Accept";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // OfferedContracts
            // 
            this.OfferedContracts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OfferedContracts.ColumnHeadersHeight = 29;
            this.OfferedContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProposalID,
            this.ManagerID,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.OfferedContracts.GridColor = System.Drawing.SystemColors.Window;
            this.OfferedContracts.Location = new System.Drawing.Point(3, 3);
            this.OfferedContracts.Name = "OfferedContracts";
            this.OfferedContracts.RowHeadersVisible = false;
            this.OfferedContracts.RowHeadersWidth = 51;
            this.OfferedContracts.RowTemplate.Height = 24;
            this.OfferedContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OfferedContracts.Size = new System.Drawing.Size(696, 292);
            this.OfferedContracts.TabIndex = 2;
            // 
            // ProposalID
            // 
            this.ProposalID.HeaderText = "Proposal ID";
            this.ProposalID.MinimumWidth = 6;
            this.ProposalID.Name = "ProposalID";
            this.ProposalID.Visible = false;
            this.ProposalID.Width = 125;
            // 
            // ManagerID
            // 
            this.ManagerID.HeaderText = "SingerID";
            this.ManagerID.MinimumWidth = 6;
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.Visible = false;
            this.ManagerID.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Full Name of Singer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 153;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "Email of Singer";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 126;
            // 
            // ConsertsManager
            // 
            this.ConsertsManager.Controls.Add(this.SeeStatictics);
            this.ConsertsManager.Controls.Add(this.ShowAll);
            this.ConsertsManager.Controls.Add(this.materialRaisedButton3);
            this.ConsertsManager.Controls.Add(this.materialRaisedButton2);
            this.ConsertsManager.Controls.Add(this.materialRaisedButton1);
            this.ConsertsManager.Controls.Add(this.ConsertsList);
            this.ConsertsManager.Location = new System.Drawing.Point(4, 25);
            this.ConsertsManager.Name = "ConsertsManager";
            this.ConsertsManager.Padding = new System.Windows.Forms.Padding(3);
            this.ConsertsManager.Size = new System.Drawing.Size(876, 298);
            this.ConsertsManager.TabIndex = 3;
            this.ConsertsManager.Text = "Information about Conserts";
            this.ConsertsManager.UseVisualStyleBackColor = true;
            // 
            // SeeStatictics
            // 
            this.SeeStatictics.AutoSize = true;
            this.SeeStatictics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeeStatictics.Depth = 0;
            this.SeeStatictics.Icon = null;
            this.SeeStatictics.Location = new System.Drawing.Point(705, 175);
            this.SeeStatictics.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeeStatictics.Name = "SeeStatictics";
            this.SeeStatictics.Primary = true;
            this.SeeStatictics.Size = new System.Drawing.Size(151, 36);
            this.SeeStatictics.TabIndex = 10;
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
            this.ShowAll.Location = new System.Drawing.Point(705, 133);
            this.ShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Primary = true;
            this.ShowAll.Size = new System.Drawing.Size(106, 36);
            this.ShowAll.TabIndex = 9;
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
            this.materialRaisedButton3.Location = new System.Drawing.Point(705, 90);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(76, 36);
            this.materialRaisedButton3.TabIndex = 8;
            this.materialRaisedButton3.Text = "Filter";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(705, 48);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(163, 36);
            this.materialRaisedButton2.TabIndex = 3;
            this.materialRaisedButton2.Text = "Delete Consert";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(705, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(166, 36);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Create Consert";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // ConsertsList
            // 
            this.ConsertsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.ColumnHeadersHeight = 29;
            this.ConsertsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsertID,
            this.DateOfConsert,
            this.SingersName,
            this.TicketsPrice,
            this.CountTickets});
            this.ConsertsList.GridColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.Location = new System.Drawing.Point(3, 3);
            this.ConsertsList.Name = "ConsertsList";
            this.ConsertsList.RowHeadersVisible = false;
            this.ConsertsList.RowHeadersWidth = 51;
            this.ConsertsList.RowTemplate.Height = 24;
            this.ConsertsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsertsList.Size = new System.Drawing.Size(696, 292);
            this.ConsertsList.TabIndex = 1;
            // 
            // Messages
            // 
            this.Messages.Controls.Add(this.RemoveAll);
            this.Messages.Controls.Add(this.Remove);
            this.Messages.Controls.Add(this.MessagesList);
            this.Messages.Location = new System.Drawing.Point(4, 25);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(876, 298);
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
            this.RemoveAll.Location = new System.Drawing.Point(708, 45);
            this.RemoveAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveAll.Name = "RemoveAll";
            this.RemoveAll.Primary = true;
            this.RemoveAll.Size = new System.Drawing.Size(124, 36);
            this.RemoveAll.TabIndex = 4;
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
            this.Remove.Location = new System.Drawing.Point(708, 3);
            this.Remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.Remove.Name = "Remove";
            this.Remove.Primary = true;
            this.Remove.Size = new System.Drawing.Size(90, 36);
            this.Remove.TabIndex = 3;
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
            this.MessagesList.Location = new System.Drawing.Point(6, 3);
            this.MessagesList.Name = "MessagesList";
            this.MessagesList.RowHeadersVisible = false;
            this.MessagesList.RowHeadersWidth = 51;
            this.MessagesList.RowTemplate.Height = 24;
            this.MessagesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MessagesList.Size = new System.Drawing.Size(696, 292);
            this.MessagesList.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Text";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // MyInfo
            // 
            this.MyInfo.Controls.Add(this.TerminateContract);
            this.MyInfo.Controls.Add(this.DeleteAccount);
            this.MyInfo.Controls.Add(this.MySingersEmail);
            this.MyInfo.Controls.Add(this.MySingersName);
            this.MyInfo.Controls.Add(this.MyEmail);
            this.MyInfo.Controls.Add(this.MyName);
            this.MyInfo.Controls.Add(this.MyLogin);
            this.MyInfo.Location = new System.Drawing.Point(4, 25);
            this.MyInfo.Name = "MyInfo";
            this.MyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.MyInfo.Size = new System.Drawing.Size(876, 298);
            this.MyInfo.TabIndex = 2;
            this.MyInfo.Text = "Info About Me";
            this.MyInfo.UseVisualStyleBackColor = true;
            // 
            // TerminateContract
            // 
            this.TerminateContract.AutoSize = true;
            this.TerminateContract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TerminateContract.Depth = 0;
            this.TerminateContract.Icon = null;
            this.TerminateContract.Location = new System.Drawing.Point(9, 214);
            this.TerminateContract.MouseState = MaterialSkin.MouseState.HOVER;
            this.TerminateContract.Name = "TerminateContract";
            this.TerminateContract.Primary = true;
            this.TerminateContract.Size = new System.Drawing.Size(247, 36);
            this.TerminateContract.TabIndex = 6;
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
            this.DeleteAccount.Location = new System.Drawing.Point(9, 256);
            this.DeleteAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Primary = true;
            this.DeleteAccount.Size = new System.Drawing.Size(166, 36);
            this.DeleteAccount.TabIndex = 5;
            this.DeleteAccount.Text = "Delete Account";
            this.DeleteAccount.UseVisualStyleBackColor = true;
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // MySingersEmail
            // 
            this.MySingersEmail.AutoSize = true;
            this.MySingersEmail.Location = new System.Drawing.Point(6, 78);
            this.MySingersEmail.Name = "MySingersEmail";
            this.MySingersEmail.Size = new System.Drawing.Size(215, 16);
            this.MySingersEmail.TabIndex = 4;
            this.MySingersEmail.Text = "The Email of the singer I represent: ";
            // 
            // MySingersName
            // 
            this.MySingersName.AutoSize = true;
            this.MySingersName.Location = new System.Drawing.Point(6, 62);
            this.MySingersName.Name = "MySingersName";
            this.MySingersName.Size = new System.Drawing.Size(215, 16);
            this.MySingersName.TabIndex = 3;
            this.MySingersName.Text = "The name of the singer I represent: ";
            // 
            // MyEmail
            // 
            this.MyEmail.AutoSize = true;
            this.MyEmail.Location = new System.Drawing.Point(6, 35);
            this.MyEmail.Name = "MyEmail";
            this.MyEmail.Size = new System.Drawing.Size(47, 16);
            this.MyEmail.TabIndex = 2;
            this.MyEmail.Text = "Email: ";
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Location = new System.Drawing.Point(6, 19);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(71, 16);
            this.MyName.TabIndex = 1;
            this.MyName.Text = "Full name: ";
            // 
            // MyLogin
            // 
            this.MyLogin.AutoSize = true;
            this.MyLogin.Location = new System.Drawing.Point(6, 3);
            this.MyLogin.Name = "MyLogin";
            this.MyLogin.Size = new System.Drawing.Size(46, 16);
            this.MyLogin.TabIndex = 0;
            this.MyLogin.Text = "Login: ";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.ManagersMenu;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 82);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1046, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
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
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.ManagersMenu);
            this.Name = "ManagersForm";
            this.Text = "Manager page";
            this.ManagersMenu.ResumeLayout(false);
            this.Singers.ResumeLayout(false);
            this.Singers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingersList)).EndInit();
            this.ContractProposals.ResumeLayout(false);
            this.ContractProposals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfferedContracts)).EndInit();
            this.ConsertsManager.ResumeLayout(false);
            this.ConsertsManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).EndInit();
            this.Messages.ResumeLayout(false);
            this.Messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesList)).EndInit();
            this.MyInfo.ResumeLayout(false);
            this.MyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl ManagersMenu;
        private System.Windows.Forms.TabPage Singers;
        private MaterialSkin.Controls.MaterialRaisedButton ChooseSinger;
        private System.Windows.Forms.DataGridView SingersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TabPage MyInfo;
        private System.Windows.Forms.Label MyLogin;
        private System.Windows.Forms.Label MySingersEmail;
        private System.Windows.Forms.Label MySingersName;
        private System.Windows.Forms.Label MyEmail;
        private System.Windows.Forms.Label MyName;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage ConsertsManager;
        private System.Windows.Forms.DataGridView ConsertsList;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton ShowAll;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton SeeStatictics;
        private System.Windows.Forms.TabPage Messages;
        private MaterialSkin.Controls.MaterialRaisedButton RemoveAll;
        private MaterialSkin.Controls.MaterialRaisedButton Remove;
        private System.Windows.Forms.DataGridView MessagesList;
        private System.Windows.Forms.TabPage ContractProposals;
        private System.Windows.Forms.DataGridView OfferedContracts;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProposalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfReceiving;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MaterialSkin.Controls.MaterialRaisedButton TerminateContract;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsertID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountTickets;
    }
}