namespace Tickets_Consert_System.Forms
{
    partial class AdminsForm
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
            this.PasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EnterButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.HidePassword = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AdminsInterface = new MaterialSkin.Controls.MaterialTabControl();
            this.Venues = new System.Windows.Forms.TabPage();
            this.DeleteVenue = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AlterVenue = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CreateVenue = new MaterialSkin.Controls.MaterialRaisedButton();
            this.VenuesInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfPlacesInRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clients = new System.Windows.Forms.TabPage();
            this.ShowAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ShowNotBanned = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ShowBanned = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ForgiveTheUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BanUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ClientsInfo = new System.Windows.Forms.DataGridView();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ballance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBanned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Managers = new System.Windows.Forms.TabPage();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ForgiveManager = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BanManager = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManagersInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagersLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepresentativeSinger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBannedManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singers = new System.Windows.Forms.TabPage();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ForgiveSinger = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BanSinger = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SingersInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBannedSinger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.AdminsInterface.SuspendLayout();
            this.Venues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenuesInfo)).BeginInit();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsInfo)).BeginInit();
            this.Managers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersInfo)).BeginInit();
            this.Singers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingersInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordField
            // 
            this.PasswordField.Depth = 0;
            this.PasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Hint = "";
            this.PasswordField.Location = new System.Drawing.Point(274, 188);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '\0';
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.Size = new System.Drawing.Size(406, 28);
            this.PasswordField.TabIndex = 0;
            this.PasswordField.TabStop = false;
            this.PasswordField.Text = "Enter the password";
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // EnterButton
            // 
            this.EnterButton.AutoSize = true;
            this.EnterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterButton.Depth = 0;
            this.EnterButton.Icon = null;
            this.EnterButton.Location = new System.Drawing.Point(367, 277);
            this.EnterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Primary = true;
            this.EnterButton.Size = new System.Drawing.Size(75, 36);
            this.EnterButton.TabIndex = 1;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // HidePassword
            // 
            this.HidePassword.AutoSize = true;
            this.HidePassword.Checked = true;
            this.HidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HidePassword.Depth = 0;
            this.HidePassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.HidePassword.Location = new System.Drawing.Point(329, 219);
            this.HidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.HidePassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.HidePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Ripple = true;
            this.HidePassword.Size = new System.Drawing.Size(146, 30);
            this.HidePassword.TabIndex = 2;
            this.HidePassword.Text = "Hide password";
            this.HidePassword.UseVisualStyleBackColor = true;
            this.HidePassword.CheckedChanged += new System.EventHandler(this.HidePassword_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(164, 188);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Password: ";
            // 
            // AdminsInterface
            // 
            this.AdminsInterface.Controls.Add(this.Venues);
            this.AdminsInterface.Controls.Add(this.Clients);
            this.AdminsInterface.Controls.Add(this.Managers);
            this.AdminsInterface.Controls.Add(this.Singers);
            this.AdminsInterface.Depth = 0;
            this.AdminsInterface.Enabled = false;
            this.AdminsInterface.Location = new System.Drawing.Point(19, 138);
            this.AdminsInterface.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminsInterface.Name = "AdminsInterface";
            this.AdminsInterface.SelectedIndex = 0;
            this.AdminsInterface.Size = new System.Drawing.Size(1312, 331);
            this.AdminsInterface.TabIndex = 4;
            // 
            // Venues
            // 
            this.Venues.Controls.Add(this.DeleteVenue);
            this.Venues.Controls.Add(this.AlterVenue);
            this.Venues.Controls.Add(this.CreateVenue);
            this.Venues.Controls.Add(this.VenuesInfo);
            this.Venues.Location = new System.Drawing.Point(4, 25);
            this.Venues.Name = "Venues";
            this.Venues.Padding = new System.Windows.Forms.Padding(3);
            this.Venues.Size = new System.Drawing.Size(1304, 302);
            this.Venues.TabIndex = 1;
            this.Venues.Text = "Venues";
            this.Venues.UseVisualStyleBackColor = true;
            // 
            // DeleteVenue
            // 
            this.DeleteVenue.AutoSize = true;
            this.DeleteVenue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteVenue.Depth = 0;
            this.DeleteVenue.Icon = null;
            this.DeleteVenue.Location = new System.Drawing.Point(1144, 92);
            this.DeleteVenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteVenue.Name = "DeleteVenue";
            this.DeleteVenue.Primary = true;
            this.DeleteVenue.Size = new System.Drawing.Size(140, 36);
            this.DeleteVenue.TabIndex = 9;
            this.DeleteVenue.Text = "Delete venue";
            this.DeleteVenue.UseVisualStyleBackColor = true;
            this.DeleteVenue.Click += new System.EventHandler(this.DeleteVenue_Click);
            // 
            // AlterVenue
            // 
            this.AlterVenue.AutoSize = true;
            this.AlterVenue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AlterVenue.Depth = 0;
            this.AlterVenue.Icon = null;
            this.AlterVenue.Location = new System.Drawing.Point(1144, 50);
            this.AlterVenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.AlterVenue.Name = "AlterVenue";
            this.AlterVenue.Primary = true;
            this.AlterVenue.Size = new System.Drawing.Size(132, 36);
            this.AlterVenue.TabIndex = 8;
            this.AlterVenue.Text = "Alter venue";
            this.AlterVenue.UseVisualStyleBackColor = true;
            this.AlterVenue.Click += new System.EventHandler(this.AlterVenue_Click);
            // 
            // CreateVenue
            // 
            this.CreateVenue.AutoSize = true;
            this.CreateVenue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateVenue.Depth = 0;
            this.CreateVenue.Icon = null;
            this.CreateVenue.Location = new System.Drawing.Point(1144, 6);
            this.CreateVenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateVenue.Name = "CreateVenue";
            this.CreateVenue.Primary = true;
            this.CreateVenue.Size = new System.Drawing.Size(143, 36);
            this.CreateVenue.TabIndex = 7;
            this.CreateVenue.Text = "Create venue";
            this.CreateVenue.UseVisualStyleBackColor = true;
            this.CreateVenue.Click += new System.EventHandler(this.CreateVenue_Click);
            // 
            // VenuesInfo
            // 
            this.VenuesInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.VenuesInfo.ColumnHeadersHeight = 29;
            this.VenuesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.VenueName,
            this.Address,
            this.NumberOfPlaces,
            this.NumberOfPlacesInRow});
            this.VenuesInfo.GridColor = System.Drawing.SystemColors.Window;
            this.VenuesInfo.Location = new System.Drawing.Point(3, 6);
            this.VenuesInfo.Name = "VenuesInfo";
            this.VenuesInfo.RowHeadersVisible = false;
            this.VenuesInfo.RowHeadersWidth = 51;
            this.VenuesInfo.RowTemplate.Height = 24;
            this.VenuesInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VenuesInfo.Size = new System.Drawing.Size(1135, 292);
            this.VenuesInfo.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "VenueID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // VenueName
            // 
            this.VenueName.HeaderText = "Name of venue";
            this.VenueName.MinimumWidth = 6;
            this.VenueName.Name = "VenueName";
            this.VenueName.Width = 125;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Address.FillWeight = 300F;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 87;
            // 
            // NumberOfPlaces
            // 
            this.NumberOfPlaces.HeaderText = "Number of rows";
            this.NumberOfPlaces.MinimumWidth = 6;
            this.NumberOfPlaces.Name = "NumberOfPlaces";
            this.NumberOfPlaces.Width = 125;
            // 
            // NumberOfPlacesInRow
            // 
            this.NumberOfPlacesInRow.HeaderText = "Number of places in row";
            this.NumberOfPlacesInRow.MinimumWidth = 6;
            this.NumberOfPlacesInRow.Name = "NumberOfPlacesInRow";
            this.NumberOfPlacesInRow.Width = 125;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.ShowAll);
            this.Clients.Controls.Add(this.ShowNotBanned);
            this.Clients.Controls.Add(this.ShowBanned);
            this.Clients.Controls.Add(this.ForgiveTheUser);
            this.Clients.Controls.Add(this.BanUser);
            this.Clients.Controls.Add(this.ClientsInfo);
            this.Clients.Location = new System.Drawing.Point(4, 25);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(1304, 302);
            this.Clients.TabIndex = 2;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // ShowAll
            // 
            this.ShowAll.AutoSize = true;
            this.ShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowAll.Depth = 0;
            this.ShowAll.Icon = null;
            this.ShowAll.Location = new System.Drawing.Point(1106, 171);
            this.ShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Primary = true;
            this.ShowAll.Size = new System.Drawing.Size(106, 36);
            this.ShowAll.TabIndex = 12;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // ShowNotBanned
            // 
            this.ShowNotBanned.AutoSize = true;
            this.ShowNotBanned.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowNotBanned.Depth = 0;
            this.ShowNotBanned.Icon = null;
            this.ShowNotBanned.Location = new System.Drawing.Point(1106, 129);
            this.ShowNotBanned.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowNotBanned.Name = "ShowNotBanned";
            this.ShowNotBanned.Primary = true;
            this.ShowNotBanned.Size = new System.Drawing.Size(182, 36);
            this.ShowNotBanned.TabIndex = 11;
            this.ShowNotBanned.Text = "Show not banned";
            this.ShowNotBanned.UseVisualStyleBackColor = true;
            this.ShowNotBanned.Click += new System.EventHandler(this.ShowNotBanned_Click);
            // 
            // ShowBanned
            // 
            this.ShowBanned.AutoSize = true;
            this.ShowBanned.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowBanned.Depth = 0;
            this.ShowBanned.Icon = null;
            this.ShowBanned.Location = new System.Drawing.Point(1106, 87);
            this.ShowBanned.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowBanned.Name = "ShowBanned";
            this.ShowBanned.Primary = true;
            this.ShowBanned.Size = new System.Drawing.Size(143, 36);
            this.ShowBanned.TabIndex = 10;
            this.ShowBanned.Text = "Show banned";
            this.ShowBanned.UseVisualStyleBackColor = true;
            this.ShowBanned.Click += new System.EventHandler(this.ShowBanned_Click);
            // 
            // ForgiveTheUser
            // 
            this.ForgiveTheUser.AutoSize = true;
            this.ForgiveTheUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ForgiveTheUser.Depth = 0;
            this.ForgiveTheUser.Icon = null;
            this.ForgiveTheUser.Location = new System.Drawing.Point(1106, 45);
            this.ForgiveTheUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForgiveTheUser.Name = "ForgiveTheUser";
            this.ForgiveTheUser.Primary = true;
            this.ForgiveTheUser.Size = new System.Drawing.Size(174, 36);
            this.ForgiveTheUser.TabIndex = 9;
            this.ForgiveTheUser.Text = "Forgive the user";
            this.ForgiveTheUser.UseVisualStyleBackColor = true;
            this.ForgiveTheUser.Click += new System.EventHandler(this.ForgiveTheUser_Click);
            // 
            // BanUser
            // 
            this.BanUser.AutoSize = true;
            this.BanUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BanUser.Depth = 0;
            this.BanUser.Icon = null;
            this.BanUser.Location = new System.Drawing.Point(1106, 3);
            this.BanUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.BanUser.Name = "BanUser";
            this.BanUser.Primary = true;
            this.BanUser.Size = new System.Drawing.Size(103, 36);
            this.BanUser.TabIndex = 8;
            this.BanUser.Text = "Ban user";
            this.BanUser.UseVisualStyleBackColor = true;
            this.BanUser.Click += new System.EventHandler(this.BanUser_Click);
            // 
            // ClientsInfo
            // 
            this.ClientsInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ClientsInfo.ColumnHeadersHeight = 29;
            this.ClientsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.FullName,
            this.ClientsLogin,
            this.Ballance,
            this.IsBanned});
            this.ClientsInfo.GridColor = System.Drawing.SystemColors.Window;
            this.ClientsInfo.Location = new System.Drawing.Point(3, 3);
            this.ClientsInfo.Name = "ClientsInfo";
            this.ClientsInfo.RowHeadersVisible = false;
            this.ClientsInfo.RowHeadersWidth = 51;
            this.ClientsInfo.RowTemplate.Height = 24;
            this.ClientsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsInfo.Size = new System.Drawing.Size(1097, 292);
            this.ClientsInfo.TabIndex = 7;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "ClientID";
            this.ClientID.MinimumWidth = 6;
            this.ClientID.Name = "ClientID";
            this.ClientID.Visible = false;
            this.ClientID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // ClientsLogin
            // 
            this.ClientsLogin.HeaderText = "Login";
            this.ClientsLogin.MinimumWidth = 6;
            this.ClientsLogin.Name = "ClientsLogin";
            this.ClientsLogin.Width = 125;
            // 
            // Ballance
            // 
            this.Ballance.HeaderText = "Ballance";
            this.Ballance.MinimumWidth = 6;
            this.Ballance.Name = "Ballance";
            this.Ballance.Width = 125;
            // 
            // IsBanned
            // 
            this.IsBanned.HeaderText = "Is banned";
            this.IsBanned.MinimumWidth = 6;
            this.IsBanned.Name = "IsBanned";
            this.IsBanned.Width = 125;
            // 
            // Managers
            // 
            this.Managers.Controls.Add(this.materialRaisedButton5);
            this.Managers.Controls.Add(this.materialRaisedButton1);
            this.Managers.Controls.Add(this.materialRaisedButton2);
            this.Managers.Controls.Add(this.ForgiveManager);
            this.Managers.Controls.Add(this.BanManager);
            this.Managers.Controls.Add(this.ManagersInfo);
            this.Managers.Location = new System.Drawing.Point(4, 25);
            this.Managers.Name = "Managers";
            this.Managers.Size = new System.Drawing.Size(1304, 302);
            this.Managers.TabIndex = 3;
            this.Managers.Text = "Managers";
            this.Managers.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = null;
            this.materialRaisedButton5.Location = new System.Drawing.Point(1114, 171);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(106, 36);
            this.materialRaisedButton5.TabIndex = 15;
            this.materialRaisedButton5.Text = "Show all";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(1114, 129);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(182, 36);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Show not banned";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.ShowNotBanned_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(1114, 87);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(143, 36);
            this.materialRaisedButton2.TabIndex = 13;
            this.materialRaisedButton2.Text = "Show banned";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.ShowBanned_Click);
            // 
            // ForgiveManager
            // 
            this.ForgiveManager.AutoSize = true;
            this.ForgiveManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ForgiveManager.Depth = 0;
            this.ForgiveManager.Icon = null;
            this.ForgiveManager.Location = new System.Drawing.Point(1114, 45);
            this.ForgiveManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForgiveManager.Name = "ForgiveManager";
            this.ForgiveManager.Primary = true;
            this.ForgiveManager.Size = new System.Drawing.Size(174, 36);
            this.ForgiveManager.TabIndex = 12;
            this.ForgiveManager.Text = "Forgive the user";
            this.ForgiveManager.UseVisualStyleBackColor = true;
            this.ForgiveManager.Click += new System.EventHandler(this.ForgiveManager_Click);
            // 
            // BanManager
            // 
            this.BanManager.AutoSize = true;
            this.BanManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BanManager.Depth = 0;
            this.BanManager.Icon = null;
            this.BanManager.Location = new System.Drawing.Point(1114, 3);
            this.BanManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.BanManager.Name = "BanManager";
            this.BanManager.Primary = true;
            this.BanManager.Size = new System.Drawing.Size(103, 36);
            this.BanManager.TabIndex = 11;
            this.BanManager.Text = "Ban user";
            this.BanManager.UseVisualStyleBackColor = true;
            this.BanManager.Click += new System.EventHandler(this.BanManager_Click);
            // 
            // ManagersInfo
            // 
            this.ManagersInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ManagersInfo.ColumnHeadersHeight = 29;
            this.ManagersInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ManagersName,
            this.ManagersLogin,
            this.RepresentativeSinger,
            this.IsBannedManager});
            this.ManagersInfo.GridColor = System.Drawing.SystemColors.Window;
            this.ManagersInfo.Location = new System.Drawing.Point(3, 3);
            this.ManagersInfo.Name = "ManagersInfo";
            this.ManagersInfo.RowHeadersVisible = false;
            this.ManagersInfo.RowHeadersWidth = 51;
            this.ManagersInfo.RowTemplate.Height = 24;
            this.ManagersInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManagersInfo.Size = new System.Drawing.Size(1105, 292);
            this.ManagersInfo.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // ManagersName
            // 
            this.ManagersName.HeaderText = "Full name";
            this.ManagersName.MinimumWidth = 6;
            this.ManagersName.Name = "ManagersName";
            this.ManagersName.Width = 125;
            // 
            // ManagersLogin
            // 
            this.ManagersLogin.HeaderText = "Login";
            this.ManagersLogin.MinimumWidth = 6;
            this.ManagersLogin.Name = "ManagersLogin";
            this.ManagersLogin.Width = 125;
            // 
            // RepresentativeSinger
            // 
            this.RepresentativeSinger.HeaderText = "Singer which he represent";
            this.RepresentativeSinger.MinimumWidth = 6;
            this.RepresentativeSinger.Name = "RepresentativeSinger";
            this.RepresentativeSinger.Width = 200;
            // 
            // IsBannedManager
            // 
            this.IsBannedManager.HeaderText = "Is banned";
            this.IsBannedManager.MinimumWidth = 6;
            this.IsBannedManager.Name = "IsBannedManager";
            this.IsBannedManager.Width = 125;
            // 
            // Singers
            // 
            this.Singers.Controls.Add(this.materialRaisedButton6);
            this.Singers.Controls.Add(this.materialRaisedButton3);
            this.Singers.Controls.Add(this.materialRaisedButton4);
            this.Singers.Controls.Add(this.ForgiveSinger);
            this.Singers.Controls.Add(this.BanSinger);
            this.Singers.Controls.Add(this.SingersInfo);
            this.Singers.Location = new System.Drawing.Point(4, 25);
            this.Singers.Name = "Singers";
            this.Singers.Size = new System.Drawing.Size(1304, 302);
            this.Singers.TabIndex = 4;
            this.Singers.Text = "Singers";
            this.Singers.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSize = true;
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Icon = null;
            this.materialRaisedButton6.Location = new System.Drawing.Point(1115, 171);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(106, 36);
            this.materialRaisedButton6.TabIndex = 18;
            this.materialRaisedButton6.Text = "Show all";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(1115, 129);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(182, 36);
            this.materialRaisedButton3.TabIndex = 17;
            this.materialRaisedButton3.Text = "Show not banned";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.ShowNotBanned_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(1115, 87);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(143, 36);
            this.materialRaisedButton4.TabIndex = 16;
            this.materialRaisedButton4.Text = "Show banned";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.ShowBanned_Click);
            // 
            // ForgiveSinger
            // 
            this.ForgiveSinger.AutoSize = true;
            this.ForgiveSinger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ForgiveSinger.Depth = 0;
            this.ForgiveSinger.Icon = null;
            this.ForgiveSinger.Location = new System.Drawing.Point(1115, 45);
            this.ForgiveSinger.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForgiveSinger.Name = "ForgiveSinger";
            this.ForgiveSinger.Primary = true;
            this.ForgiveSinger.Size = new System.Drawing.Size(174, 36);
            this.ForgiveSinger.TabIndex = 15;
            this.ForgiveSinger.Text = "Forgive the user";
            this.ForgiveSinger.UseVisualStyleBackColor = true;
            this.ForgiveSinger.Click += new System.EventHandler(this.ForgiveSinger_Click);
            // 
            // BanSinger
            // 
            this.BanSinger.AutoSize = true;
            this.BanSinger.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BanSinger.Depth = 0;
            this.BanSinger.Icon = null;
            this.BanSinger.Location = new System.Drawing.Point(1115, 3);
            this.BanSinger.MouseState = MaterialSkin.MouseState.HOVER;
            this.BanSinger.Name = "BanSinger";
            this.BanSinger.Primary = true;
            this.BanSinger.Size = new System.Drawing.Size(103, 36);
            this.BanSinger.TabIndex = 14;
            this.BanSinger.Text = "Ban user";
            this.BanSinger.UseVisualStyleBackColor = true;
            this.BanSinger.Click += new System.EventHandler(this.BanSinger_Click);
            // 
            // SingersInfo
            // 
            this.SingersInfo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SingersInfo.ColumnHeadersHeight = 29;
            this.SingersInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.SingersName,
            this.SingersLogin,
            this.Manager,
            this.IsBannedSinger});
            this.SingersInfo.GridColor = System.Drawing.SystemColors.Window;
            this.SingersInfo.Location = new System.Drawing.Point(3, 3);
            this.SingersInfo.Name = "SingersInfo";
            this.SingersInfo.RowHeadersVisible = false;
            this.SingersInfo.RowHeadersWidth = 51;
            this.SingersInfo.RowTemplate.Height = 24;
            this.SingersInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SingersInfo.Size = new System.Drawing.Size(1106, 292);
            this.SingersInfo.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ClientID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // SingersName
            // 
            this.SingersName.HeaderText = "Full name";
            this.SingersName.MinimumWidth = 6;
            this.SingersName.Name = "SingersName";
            this.SingersName.Width = 125;
            // 
            // SingersLogin
            // 
            this.SingersLogin.HeaderText = "Login";
            this.SingersLogin.MinimumWidth = 6;
            this.SingersLogin.Name = "SingersLogin";
            this.SingersLogin.Width = 125;
            // 
            // Manager
            // 
            this.Manager.HeaderText = "Manager who represents";
            this.Manager.MinimumWidth = 6;
            this.Manager.Name = "Manager";
            this.Manager.Width = 200;
            // 
            // IsBannedSinger
            // 
            this.IsBannedSinger.HeaderText = "Is banned";
            this.IsBannedSinger.MinimumWidth = 6;
            this.IsBannedSinger.Name = "IsBannedSinger";
            this.IsBannedSinger.Width = 125;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.AdminsInterface;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(19, 98);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1301, 23);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "AdimnsInterfaceSelector";
            // 
            // AdminsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 482);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.AdminsInterface);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PasswordField);
            this.Name = "AdminsForm";
            this.Text = "AdminsForm";
            this.AdminsInterface.ResumeLayout(false);
            this.Venues.ResumeLayout(false);
            this.Venues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenuesInfo)).EndInit();
            this.Clients.ResumeLayout(false);
            this.Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsInfo)).EndInit();
            this.Managers.ResumeLayout(false);
            this.Managers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersInfo)).EndInit();
            this.Singers.ResumeLayout(false);
            this.Singers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingersInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordField;
        private MaterialSkin.Controls.MaterialRaisedButton EnterButton;
        private MaterialSkin.Controls.MaterialCheckBox HidePassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabControl AdminsInterface;
        private System.Windows.Forms.TabPage Venues;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.TabPage Managers;
        private System.Windows.Forms.TabPage Singers;
        private System.Windows.Forms.DataGridView VenuesInfo;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteVenue;
        private MaterialSkin.Controls.MaterialRaisedButton AlterVenue;
        private MaterialSkin.Controls.MaterialRaisedButton CreateVenue;
        private System.Windows.Forms.DataGridView ClientsInfo;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton ForgiveTheUser;
        private MaterialSkin.Controls.MaterialRaisedButton BanUser;
        private MaterialSkin.Controls.MaterialRaisedButton ForgiveManager;
        private MaterialSkin.Controls.MaterialRaisedButton BanManager;
        private System.Windows.Forms.DataGridView ManagersInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ballance;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBanned;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagersLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepresentativeSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBannedManager;
        private MaterialSkin.Controls.MaterialRaisedButton ForgiveSinger;
        private MaterialSkin.Controls.MaterialRaisedButton BanSinger;
        private System.Windows.Forms.DataGridView SingersInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingersLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBannedSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfPlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfPlacesInRow;
        private MaterialSkin.Controls.MaterialRaisedButton ShowNotBanned;
        private MaterialSkin.Controls.MaterialRaisedButton ShowBanned;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton ShowAll;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
    }
}