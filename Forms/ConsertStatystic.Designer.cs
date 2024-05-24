namespace Tickets_Consert_System.Forms
{
    partial class ConsertStatystic
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ConsertHall = new System.Windows.Forms.PictureBox();
            this.SoldTickets = new System.Windows.Forms.Label();
            this.CashCollection = new System.Windows.Forms.Label();
            this.RefreshButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertHall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Image = global::Tickets_Consert_System.Properties.Resources.Scene_image;
            this.pictureBox2.Location = new System.Drawing.Point(126, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // ConsertHall
            // 
            this.ConsertHall.BackColor = System.Drawing.Color.Gray;
            this.ConsertHall.Location = new System.Drawing.Point(126, 152);
            this.ConsertHall.Name = "ConsertHall";
            this.ConsertHall.Size = new System.Drawing.Size(335, 300);
            this.ConsertHall.TabIndex = 12;
            this.ConsertHall.TabStop = false;
            this.ConsertHall.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // SoldTickets
            // 
            this.SoldTickets.AutoSize = true;
            this.SoldTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoldTickets.Location = new System.Drawing.Point(12, 476);
            this.SoldTickets.Name = "SoldTickets";
            this.SoldTickets.Size = new System.Drawing.Size(271, 25);
            this.SoldTickets.TabIndex = 14;
            this.SoldTickets.Text = "Total number of tickets sold: 0";
            // 
            // CashCollection
            // 
            this.CashCollection.AutoSize = true;
            this.CashCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashCollection.Location = new System.Drawing.Point(12, 513);
            this.CashCollection.Name = "CashCollection";
            this.CashCollection.Size = new System.Drawing.Size(167, 25);
            this.CashCollection.TabIndex = 15;
            this.CashCollection.Text = "Cash collection: 0";
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshButton.Depth = 0;
            this.RefreshButton.Icon = null;
            this.RefreshButton.Location = new System.Drawing.Point(493, 476);
            this.RefreshButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Primary = true;
            this.RefreshButton.Size = new System.Drawing.Size(95, 36);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ConsertStatystic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 620);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CashCollection);
            this.Controls.Add(this.SoldTickets);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ConsertHall);
            this.Name = "ConsertStatystic";
            this.Text = "ConsertStatystic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsertHall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ConsertHall;
        private System.Windows.Forms.Label SoldTickets;
        private System.Windows.Forms.Label CashCollection;
        private MaterialSkin.Controls.MaterialRaisedButton RefreshButton;
    }
}