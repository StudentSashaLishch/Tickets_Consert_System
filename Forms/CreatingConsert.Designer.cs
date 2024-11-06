namespace Tickets_Consert_System.Forms
{
    partial class CreatingConsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateOfConsert = new System.Windows.Forms.DateTimePicker();
            this.PriceTicket = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.VenueInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date of Consert:";
            // 
            // dateOfConsert
            // 
            this.dateOfConsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfConsert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfConsert.Location = new System.Drawing.Point(274, 97);
            this.dateOfConsert.Name = "dateOfConsert";
            this.dateOfConsert.Size = new System.Drawing.Size(413, 28);
            this.dateOfConsert.TabIndex = 2;
            // 
            // PriceTicket
            // 
            this.PriceTicket.BackColor = System.Drawing.SystemColors.Control;
            this.PriceTicket.Depth = 0;
            this.PriceTicket.Hint = "";
            this.PriceTicket.Location = new System.Drawing.Point(274, 188);
            this.PriceTicket.MaxLength = 32767;
            this.PriceTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceTicket.Name = "PriceTicket";
            this.PriceTicket.PasswordChar = '\0';
            this.PriceTicket.SelectedText = "";
            this.PriceTicket.SelectionLength = 0;
            this.PriceTicket.SelectionStart = 0;
            this.PriceTicket.Size = new System.Drawing.Size(413, 28);
            this.PriceTicket.TabIndex = 8;
            this.PriceTicket.TabStop = false;
            this.PriceTicket.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ticket Price:";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(308, 247);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(85, 36);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "Create";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // VenueInfo
            // 
            this.VenueInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VenueInfo.FormattingEnabled = true;
            this.VenueInfo.Items.AddRange(new object[] {
            "Name: Philarmonia; Address: Gagarin str., 3; Number of rows: 100; Number of place" +
                "s in row : 100"});
            this.VenueInfo.Location = new System.Drawing.Point(12, 141);
            this.VenueInfo.Name = "VenueInfo";
            this.VenueInfo.Size = new System.Drawing.Size(675, 33);
            this.VenueInfo.TabIndex = 10;
            // 
            // CreatingConsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 299);
            this.Controls.Add(this.VenueInfo);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.PriceTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateOfConsert);
            this.Controls.Add(this.label1);
            this.Name = "CreatingConsert";
            this.Text = "CreatingConsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOfConsert;
        private MaterialSkin.Controls.MaterialSingleLineTextField PriceTicket;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ComboBox VenueInfo;
    }
}