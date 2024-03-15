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
            this.ContractProposals = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.OfferedContracts = new System.Windows.Forms.DataGridView();
            this.ManagerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsertsInfo = new System.Windows.Forms.TabPage();
            this.ConsertsList = new System.Windows.Forms.DataGridView();
            this.ConsertID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyInfo = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.MyManagersEmail = new System.Windows.Forms.Label();
            this.MyManagersName = new System.Windows.Forms.Label();
            this.MyEmail = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.MyLogin = new System.Windows.Forms.Label();
            this.SingersTabs.SuspendLayout();
            this.ContractProposals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfferedContracts)).BeginInit();
            this.ConsertsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).BeginInit();
            this.MyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // SingersTabs
            // 
            this.SingersTabs.Controls.Add(this.ContractProposals);
            this.SingersTabs.Controls.Add(this.ConsertsInfo);
            this.SingersTabs.Controls.Add(this.MyInfo);
            this.SingersTabs.Depth = 0;
            this.SingersTabs.Location = new System.Drawing.Point(11, 123);
            this.SingersTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.SingersTabs.Name = "SingersTabs";
            this.SingersTabs.SelectedIndex = 0;
            this.SingersTabs.Size = new System.Drawing.Size(937, 334);
            this.SingersTabs.TabIndex = 0;
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
            this.ManagerID,
            this.FullName,
            this.Email});
            this.OfferedContracts.GridColor = System.Drawing.SystemColors.Window;
            this.OfferedContracts.Location = new System.Drawing.Point(6, 6);
            this.OfferedContracts.Name = "OfferedContracts";
            this.OfferedContracts.RowHeadersVisible = false;
            this.OfferedContracts.RowHeadersWidth = 51;
            this.OfferedContracts.RowTemplate.Height = 24;
            this.OfferedContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OfferedContracts.Size = new System.Drawing.Size(696, 308);
            this.OfferedContracts.TabIndex = 1;
            // 
            // ManagerID
            // 
            this.ManagerID.HeaderText = "SingerID";
            this.ManagerID.MinimumWidth = 6;
            this.ManagerID.Name = "ManagerID";
            this.ManagerID.Visible = false;
            this.ManagerID.Width = 125;
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
            // ConsertsInfo
            // 
            this.ConsertsInfo.Controls.Add(this.ConsertsList);
            this.ConsertsInfo.Location = new System.Drawing.Point(4, 25);
            this.ConsertsInfo.Name = "ConsertsInfo";
            this.ConsertsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ConsertsInfo.Size = new System.Drawing.Size(929, 305);
            this.ConsertsInfo.TabIndex = 2;
            this.ConsertsInfo.Text = "Information About Conserts";
            this.ConsertsInfo.UseVisualStyleBackColor = true;
            // 
            // ConsertsList
            // 
            this.ConsertsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.ColumnHeadersHeight = 29;
            this.ConsertsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsertID,
            this.DateOfConsert,
            this.SingersName,
            this.TicketsPrice});
            this.ConsertsList.GridColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.Location = new System.Drawing.Point(6, 6);
            this.ConsertsList.Name = "ConsertsList";
            this.ConsertsList.RowHeadersVisible = false;
            this.ConsertsList.RowHeadersWidth = 51;
            this.ConsertsList.RowTemplate.Height = 24;
            this.ConsertsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsertsList.Size = new System.Drawing.Size(917, 292);
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
            // TicketsPrice
            // 
            this.TicketsPrice.HeaderText = "Ticket Price";
            this.TicketsPrice.MinimumWidth = 6;
            this.TicketsPrice.Name = "TicketsPrice";
            this.TicketsPrice.Width = 125;
            // 
            // MyInfo
            // 
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
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.SingersTabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 94);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(932, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
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
            // SingersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 471);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.SingersTabs);
            this.Name = "SingersForm";
            this.Text = "SingersForm";
            this.Load += new System.EventHandler(this.SingersForm_Load);
            this.SingersTabs.ResumeLayout(false);
            this.ContractProposals.ResumeLayout(false);
            this.ContractProposals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfferedContracts)).EndInit();
            this.ConsertsInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.DataGridView ConsertsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsertID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsPrice;
        private System.Windows.Forms.Label MyManagersEmail;
        private System.Windows.Forms.Label MyManagersName;
        private System.Windows.Forms.Label MyEmail;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.Label MyLogin;
    }
}