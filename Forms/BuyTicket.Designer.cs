namespace Tickets_Consert_System.Forms
{
    partial class BuyTicket
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
            this.NumberOfRow = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfPlace = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.BuyButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfRow
            // 
            this.NumberOfRow.Depth = 0;
            this.NumberOfRow.Hint = "";
            this.NumberOfRow.Location = new System.Drawing.Point(283, 496);
            this.NumberOfRow.MaxLength = 32767;
            this.NumberOfRow.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberOfRow.Name = "NumberOfRow";
            this.NumberOfRow.PasswordChar = '\0';
            this.NumberOfRow.SelectedText = "";
            this.NumberOfRow.SelectionLength = 0;
            this.NumberOfRow.SelectionStart = 0;
            this.NumberOfRow.Size = new System.Drawing.Size(301, 28);
            this.NumberOfRow.TabIndex = 6;
            this.NumberOfRow.TabStop = false;
            this.NumberOfRow.UseSystemPasswordChar = false;
            this.NumberOfRow.TextChanged += new System.EventHandler(this.NumberOfRow_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Row:";
            // 
            // NumberOfPlace
            // 
            this.NumberOfPlace.Depth = 0;
            this.NumberOfPlace.Hint = "";
            this.NumberOfPlace.Location = new System.Drawing.Point(283, 536);
            this.NumberOfPlace.MaxLength = 32767;
            this.NumberOfPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberOfPlace.Name = "NumberOfPlace";
            this.NumberOfPlace.PasswordChar = '\0';
            this.NumberOfPlace.SelectedText = "";
            this.NumberOfPlace.SelectionLength = 0;
            this.NumberOfPlace.SelectionStart = 0;
            this.NumberOfPlace.Size = new System.Drawing.Size(301, 28);
            this.NumberOfPlace.TabIndex = 8;
            this.NumberOfPlace.TabStop = false;
            this.NumberOfPlace.UseSystemPasswordChar = false;
            this.NumberOfPlace.TextChanged += new System.EventHandler(this.NumberOfPlace_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Place in a Row:";
            // 
            // BuyButton
            // 
            this.BuyButton.AutoSize = true;
            this.BuyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BuyButton.Depth = 0;
            this.BuyButton.Icon = null;
            this.BuyButton.Location = new System.Drawing.Point(283, 570);
            this.BuyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Primary = true;
            this.BuyButton.Size = new System.Drawing.Size(55, 36);
            this.BuyButton.TabIndex = 9;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Image = global::Tickets_Consert_System.Properties.Resources.Scene_image;
            this.pictureBox2.Location = new System.Drawing.Point(147, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(147, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 300);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 620);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.NumberOfPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberOfRow);
            this.Controls.Add(this.label2);
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField NumberOfRow;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField NumberOfPlace;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRaisedButton BuyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}