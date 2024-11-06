namespace Tickets_Consert_System.Forms
{
    partial class EditVenue
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
            this.NameOfVenue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressOfVenue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberRows = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberPlaces = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DoneEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CancelEditing = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // NameOfVenue
            // 
            this.NameOfVenue.Depth = 0;
            this.NameOfVenue.Hint = "";
            this.NameOfVenue.Location = new System.Drawing.Point(127, 71);
            this.NameOfVenue.MaxLength = 32767;
            this.NameOfVenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameOfVenue.Name = "NameOfVenue";
            this.NameOfVenue.PasswordChar = '\0';
            this.NameOfVenue.SelectedText = "";
            this.NameOfVenue.SelectionLength = 0;
            this.NameOfVenue.SelectionStart = 0;
            this.NameOfVenue.Size = new System.Drawing.Size(359, 28);
            this.NameOfVenue.TabIndex = 1;
            this.NameOfVenue.TabStop = false;
            this.NameOfVenue.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // AddressOfVenue
            // 
            this.AddressOfVenue.Depth = 0;
            this.AddressOfVenue.Hint = "";
            this.AddressOfVenue.Location = new System.Drawing.Point(127, 105);
            this.AddressOfVenue.MaxLength = 32767;
            this.AddressOfVenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddressOfVenue.Name = "AddressOfVenue";
            this.AddressOfVenue.PasswordChar = '\0';
            this.AddressOfVenue.SelectedText = "";
            this.AddressOfVenue.SelectionLength = 0;
            this.AddressOfVenue.SelectionStart = 0;
            this.AddressOfVenue.Size = new System.Drawing.Size(359, 28);
            this.AddressOfVenue.TabIndex = 3;
            this.AddressOfVenue.TabStop = false;
            this.AddressOfVenue.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of rows";
            // 
            // NumberRows
            // 
            this.NumberRows.Depth = 0;
            this.NumberRows.Hint = "";
            this.NumberRows.Location = new System.Drawing.Point(216, 139);
            this.NumberRows.MaxLength = 32767;
            this.NumberRows.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberRows.Name = "NumberRows";
            this.NumberRows.PasswordChar = '\0';
            this.NumberRows.SelectedText = "";
            this.NumberRows.SelectionLength = 0;
            this.NumberRows.SelectionStart = 0;
            this.NumberRows.Size = new System.Drawing.Size(270, 28);
            this.NumberRows.TabIndex = 5;
            this.NumberRows.TabStop = false;
            this.NumberRows.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of places in row";
            // 
            // NumberPlaces
            // 
            this.NumberPlaces.Depth = 0;
            this.NumberPlaces.Hint = "";
            this.NumberPlaces.Location = new System.Drawing.Point(315, 173);
            this.NumberPlaces.MaxLength = 32767;
            this.NumberPlaces.MouseState = MaterialSkin.MouseState.HOVER;
            this.NumberPlaces.Name = "NumberPlaces";
            this.NumberPlaces.PasswordChar = '\0';
            this.NumberPlaces.SelectedText = "";
            this.NumberPlaces.SelectionLength = 0;
            this.NumberPlaces.SelectionStart = 0;
            this.NumberPlaces.Size = new System.Drawing.Size(171, 28);
            this.NumberPlaces.TabIndex = 7;
            this.NumberPlaces.TabStop = false;
            this.NumberPlaces.UseSystemPasswordChar = false;
            // 
            // DoneEdit
            // 
            this.DoneEdit.AutoSize = true;
            this.DoneEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DoneEdit.Depth = 0;
            this.DoneEdit.Icon = null;
            this.DoneEdit.Location = new System.Drawing.Point(12, 264);
            this.DoneEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.DoneEdit.Name = "DoneEdit";
            this.DoneEdit.Primary = true;
            this.DoneEdit.Size = new System.Drawing.Size(67, 36);
            this.DoneEdit.TabIndex = 9;
            this.DoneEdit.Text = "Done";
            this.DoneEdit.UseVisualStyleBackColor = true;
            this.DoneEdit.Click += new System.EventHandler(this.DoneEdit_Click);
            // 
            // CancelEditing
            // 
            this.CancelEditing.AutoSize = true;
            this.CancelEditing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelEditing.Depth = 0;
            this.CancelEditing.Icon = null;
            this.CancelEditing.Location = new System.Drawing.Point(400, 264);
            this.CancelEditing.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelEditing.Name = "CancelEditing";
            this.CancelEditing.Primary = true;
            this.CancelEditing.Size = new System.Drawing.Size(86, 36);
            this.CancelEditing.TabIndex = 10;
            this.CancelEditing.Text = "Cansel";
            this.CancelEditing.UseVisualStyleBackColor = true;
            this.CancelEditing.Click += new System.EventHandler(this.CancelEditing_Click);
            // 
            // EditVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 306);
            this.Controls.Add(this.CancelEditing);
            this.Controls.Add(this.DoneEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberPlaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressOfVenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfVenue);
            this.Name = "EditVenue";
            this.Text = "EditVenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField NameOfVenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddressOfVenue;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField NumberRows;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField NumberPlaces;
        private MaterialSkin.Controls.MaterialRaisedButton DoneEdit;
        private MaterialSkin.Controls.MaterialRaisedButton CancelEditing;
    }
}