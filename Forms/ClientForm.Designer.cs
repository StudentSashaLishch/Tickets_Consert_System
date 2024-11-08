﻿namespace Tickets_Consert_System.Forms
{
    partial class ClientForm
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Conserts = new System.Windows.Forms.TabPage();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ShowAll = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ConsertsList = new System.Windows.Forms.DataGridView();
            this.ConsertID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfTIckets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasedTicks = new System.Windows.Forms.TabPage();
            this.TicketsList = new System.Windows.Forms.DataGridView();
            this.PurchasedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConsertPurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfSingerPurchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyInfo = new System.Windows.Forms.TabPage();
            this.DeleteAccount = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MyBalance = new System.Windows.Forms.Label();
            this.MyEmail = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.MyLogin = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.Conserts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).BeginInit();
            this.PurchasedTicks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsList)).BeginInit();
            this.MyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Conserts);
            this.materialTabControl1.Controls.Add(this.PurchasedTicks);
            this.materialTabControl1.Controls.Add(this.MyInfo);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 124);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(938, 332);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Conserts
            // 
            this.Conserts.Controls.Add(this.materialRaisedButton3);
            this.Conserts.Controls.Add(this.ShowAll);
            this.Conserts.Controls.Add(this.materialRaisedButton2);
            this.Conserts.Controls.Add(this.materialRaisedButton1);
            this.Conserts.Controls.Add(this.ConsertsList);
            this.Conserts.Location = new System.Drawing.Point(4, 25);
            this.Conserts.Name = "Conserts";
            this.Conserts.Padding = new System.Windows.Forms.Padding(3);
            this.Conserts.Size = new System.Drawing.Size(930, 303);
            this.Conserts.TabIndex = 1;
            this.Conserts.Text = "Conserts";
            this.Conserts.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(762, 134);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(163, 36);
            this.materialRaisedButton3.TabIndex = 6;
            this.materialRaisedButton3.Text = "Review a singer";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.AutoSize = true;
            this.ShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowAll.Depth = 0;
            this.ShowAll.Icon = null;
            this.ShowAll.Location = new System.Drawing.Point(763, 92);
            this.ShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Primary = true;
            this.ShowAll.Size = new System.Drawing.Size(106, 36);
            this.ShowAll.TabIndex = 5;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(763, 49);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(76, 36);
            this.materialRaisedButton2.TabIndex = 4;
            this.materialRaisedButton2.Text = "Filter";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(762, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(116, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Buy ticket";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // ConsertsList
            // 
            this.ConsertsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.ColumnHeadersHeight = 29;
            this.ConsertsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsertID,
            this.DateOfConsert,
            this.SingersName,
            this.AddressVenue,
            this.TicketsPrice,
            this.CountOfTIckets});
            this.ConsertsList.GridColor = System.Drawing.SystemColors.Window;
            this.ConsertsList.Location = new System.Drawing.Point(6, 6);
            this.ConsertsList.Name = "ConsertsList";
            this.ConsertsList.RowHeadersVisible = false;
            this.ConsertsList.RowHeadersWidth = 51;
            this.ConsertsList.RowTemplate.Height = 24;
            this.ConsertsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsertsList.Size = new System.Drawing.Size(750, 292);
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
            // AddressVenue
            // 
            this.AddressVenue.HeaderText = "Address of venue";
            this.AddressVenue.MinimumWidth = 6;
            this.AddressVenue.Name = "AddressVenue";
            this.AddressVenue.Width = 125;
            // 
            // TicketsPrice
            // 
            this.TicketsPrice.HeaderText = "Ticket Price";
            this.TicketsPrice.MinimumWidth = 6;
            this.TicketsPrice.Name = "TicketsPrice";
            this.TicketsPrice.Width = 125;
            // 
            // CountOfTIckets
            // 
            this.CountOfTIckets.HeaderText = "Count of tickets";
            this.CountOfTIckets.MinimumWidth = 6;
            this.CountOfTIckets.Name = "CountOfTIckets";
            this.CountOfTIckets.Width = 125;
            // 
            // PurchasedTicks
            // 
            this.PurchasedTicks.Controls.Add(this.TicketsList);
            this.PurchasedTicks.Location = new System.Drawing.Point(4, 25);
            this.PurchasedTicks.Name = "PurchasedTicks";
            this.PurchasedTicks.Padding = new System.Windows.Forms.Padding(3);
            this.PurchasedTicks.Size = new System.Drawing.Size(930, 303);
            this.PurchasedTicks.TabIndex = 2;
            this.PurchasedTicks.Text = "Purchased tickets";
            this.PurchasedTicks.UseVisualStyleBackColor = true;
            // 
            // TicketsList
            // 
            this.TicketsList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TicketsList.ColumnHeadersHeight = 29;
            this.TicketsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchasedID,
            this.DateOfConsertPurchased,
            this.NameOfSingerPurchased,
            this.Address,
            this.NumberRow,
            this.NumberPlace});
            this.TicketsList.GridColor = System.Drawing.SystemColors.Window;
            this.TicketsList.Location = new System.Drawing.Point(6, 5);
            this.TicketsList.Name = "TicketsList";
            this.TicketsList.RowHeadersVisible = false;
            this.TicketsList.RowHeadersWidth = 51;
            this.TicketsList.RowTemplate.Height = 24;
            this.TicketsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TicketsList.Size = new System.Drawing.Size(759, 292);
            this.TicketsList.TabIndex = 3;
            // 
            // PurchasedID
            // 
            this.PurchasedID.HeaderText = "ConsertID";
            this.PurchasedID.MinimumWidth = 6;
            this.PurchasedID.Name = "PurchasedID";
            this.PurchasedID.Visible = false;
            this.PurchasedID.Width = 125;
            // 
            // DateOfConsertPurchased
            // 
            this.DateOfConsertPurchased.HeaderText = "Date Of Consert";
            this.DateOfConsertPurchased.MinimumWidth = 6;
            this.DateOfConsertPurchased.Name = "DateOfConsertPurchased";
            this.DateOfConsertPurchased.Width = 125;
            // 
            // NameOfSingerPurchased
            // 
            this.NameOfSingerPurchased.HeaderText = "Name of Singer";
            this.NameOfSingerPurchased.MinimumWidth = 6;
            this.NameOfSingerPurchased.Name = "NameOfSingerPurchased";
            this.NameOfSingerPurchased.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address of venue";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // NumberRow
            // 
            this.NumberRow.HeaderText = "Number of Row";
            this.NumberRow.MinimumWidth = 6;
            this.NumberRow.Name = "NumberRow";
            this.NumberRow.Width = 125;
            // 
            // NumberPlace
            // 
            this.NumberPlace.HeaderText = "Number of Place";
            this.NumberPlace.MinimumWidth = 6;
            this.NumberPlace.Name = "NumberPlace";
            this.NumberPlace.Width = 125;
            // 
            // MyInfo
            // 
            this.MyInfo.Controls.Add(this.DeleteAccount);
            this.MyInfo.Controls.Add(this.MyBalance);
            this.MyInfo.Controls.Add(this.MyEmail);
            this.MyInfo.Controls.Add(this.MyName);
            this.MyInfo.Controls.Add(this.MyLogin);
            this.MyInfo.Location = new System.Drawing.Point(4, 25);
            this.MyInfo.Name = "MyInfo";
            this.MyInfo.Size = new System.Drawing.Size(930, 303);
            this.MyInfo.TabIndex = 3;
            this.MyInfo.Text = "Information about me";
            this.MyInfo.UseVisualStyleBackColor = true;
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.AutoSize = true;
            this.DeleteAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteAccount.Depth = 0;
            this.DeleteAccount.Icon = null;
            this.DeleteAccount.Location = new System.Drawing.Point(15, 254);
            this.DeleteAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Primary = true;
            this.DeleteAccount.Size = new System.Drawing.Size(166, 36);
            this.DeleteAccount.TabIndex = 14;
            this.DeleteAccount.Text = "Delete Account";
            this.DeleteAccount.UseVisualStyleBackColor = true;
            this.DeleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // MyBalance
            // 
            this.MyBalance.AutoSize = true;
            this.MyBalance.Location = new System.Drawing.Point(12, 58);
            this.MyBalance.Name = "MyBalance";
            this.MyBalance.Size = new System.Drawing.Size(63, 16);
            this.MyBalance.TabIndex = 13;
            this.MyBalance.Text = "Balance: ";
            // 
            // MyEmail
            // 
            this.MyEmail.AutoSize = true;
            this.MyEmail.Location = new System.Drawing.Point(12, 42);
            this.MyEmail.Name = "MyEmail";
            this.MyEmail.Size = new System.Drawing.Size(47, 16);
            this.MyEmail.TabIndex = 12;
            this.MyEmail.Text = "Email: ";
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Location = new System.Drawing.Point(12, 26);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(71, 16);
            this.MyName.TabIndex = 11;
            this.MyName.Text = "Full name: ";
            // 
            // MyLogin
            // 
            this.MyLogin.AutoSize = true;
            this.MyLogin.Location = new System.Drawing.Point(12, 10);
            this.MyLogin.Name = "MyLogin";
            this.MyLogin.Size = new System.Drawing.Size(46, 16);
            this.MyLogin.TabIndex = 10;
            this.MyLogin.Text = "Login: ";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(18, 95);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(766, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 473);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.materialTabControl1.ResumeLayout(false);
            this.Conserts.ResumeLayout(false);
            this.Conserts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertsList)).EndInit();
            this.PurchasedTicks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsList)).EndInit();
            this.MyInfo.ResumeLayout(false);
            this.MyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Conserts;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DataGridView ConsertsList;
        private System.Windows.Forms.TabPage PurchasedTicks;
        private System.Windows.Forms.TabPage MyInfo;
        private System.Windows.Forms.DataGridView TicketsList;
        private System.Windows.Forms.Label MyEmail;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.Label MyLogin;
        private System.Windows.Forms.Label MyBalance;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton ShowAll;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsertID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressVenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfTIckets;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConsertPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfSingerPurchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPlace;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}