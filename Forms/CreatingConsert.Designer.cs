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
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfRows = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NumberOfPlaces = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTicket = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.dateOfConsert.Size = new System.Drawing.Size(301, 28);
            this.dateOfConsert.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Rows:";
            // 
            // NumberOfRows
            // 
            this.NumberOfRows.Depth = 0;
            this.NumberOfRows.Hint = "";
            this.NumberOfRows.Location = new System.Drawing.Point(274, 138);
            this.NumberOfRows.MaxLength = 32767;
            this.NumberOfRows.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberOfRows.Name = "NumberOfRows";
            this.NumberOfRows.PasswordChar = '\0';
            this.NumberOfRows.SelectedText = "";
            this.NumberOfRows.SelectionLength = 0;
            this.NumberOfRows.SelectionStart = 0;
            this.NumberOfRows.Size = new System.Drawing.Size(301, 28);
            this.NumberOfRows.TabIndex = 4;
            this.NumberOfRows.TabStop = false;
            this.NumberOfRows.UseSystemPasswordChar = false;
            // 
            // NumberOfPlaces
            // 
            this.NumberOfPlaces.Depth = 0;
            this.NumberOfPlaces.Hint = "";
            this.NumberOfPlaces.Location = new System.Drawing.Point(274, 174);
            this.NumberOfPlaces.MaxLength = 32767;
            this.NumberOfPlaces.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberOfPlaces.Name = "NumberOfPlaces";
            this.NumberOfPlaces.PasswordChar = '\0';
            this.NumberOfPlaces.SelectedText = "";
            this.NumberOfPlaces.SelectionLength = 0;
            this.NumberOfPlaces.SelectionStart = 0;
            this.NumberOfPlaces.Size = new System.Drawing.Size(301, 28);
            this.NumberOfPlaces.TabIndex = 6;
            this.NumberOfPlaces.TabStop = false;
            this.NumberOfPlaces.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Places in a Row:";
            // 
            // PriceTicket
            // 
            this.PriceTicket.BackColor = System.Drawing.SystemColors.Control;
            this.PriceTicket.Depth = 0;
            this.PriceTicket.Hint = "";
            this.PriceTicket.Location = new System.Drawing.Point(274, 211);
            this.PriceTicket.MaxLength = 32767;
            this.PriceTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.PriceTicket.Name = "PriceTicket";
            this.PriceTicket.PasswordChar = '\0';
            this.PriceTicket.SelectedText = "";
            this.PriceTicket.SelectionLength = 0;
            this.PriceTicket.SelectionStart = 0;
            this.PriceTicket.Size = new System.Drawing.Size(301, 28);
            this.PriceTicket.TabIndex = 8;
            this.PriceTicket.TabStop = false;
            this.PriceTicket.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 211);
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
            this.materialRaisedButton1.Location = new System.Drawing.Point(274, 268);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(85, 36);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "Create";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // CreatingConsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 316);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.PriceTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfPlaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberOfRows);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField NumberOfRows;
        private MaterialSkin.Controls.MaterialSingleLineTextField NumberOfPlaces;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField PriceTicket;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}