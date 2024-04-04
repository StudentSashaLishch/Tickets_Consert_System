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
            this.ConsertsManager = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ConsertsList = new System.Windows.Forms.DataGridView();
            this.ConsertID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyInfo = new System.Windows.Forms.TabPage();
            this.MySingersEmail = new System.Windows.Forms.Label();
            this.MySingersName = new System.Windows.Forms.Label();
            this.MyEmail = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.MyLogin = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.ShowAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManagersMenu.SuspendLayout();
            this.Singers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingersList)).BeginInit();
            this.ConsertsManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).BeginInit();
            this.MyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagersMenu
            // 
            this.ManagersMenu.Controls.Add(this.Singers);
            this.ManagersMenu.Controls.Add(this.ConsertsManager);
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
            this.SingersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SingersList_CellContentClick);
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
            // ConsertsManager
            // 
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
            this.TicketsPrice});
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
            this.materialTabSelector1.Size = new System.Drawing.Size(880, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
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
            // ManagersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.ManagersMenu);
            this.Name = "ManagersForm";
            this.Text = "Manager page";
            this.Load += new System.EventHandler(this.ManagersForm_Load);
            this.ManagersMenu.ResumeLayout(false);
            this.Singers.ResumeLayout(false);
            this.Singers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingersList)).EndInit();
            this.ConsertsManager.ResumeLayout(false);
            this.ConsertsManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsertID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsPrice;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton ShowAll;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}