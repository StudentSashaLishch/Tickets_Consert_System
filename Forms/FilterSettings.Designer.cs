namespace Tickets_Consert_System.Forms
{
    partial class FilterSettings
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
            this.MinPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minDateOfConsert = new System.Windows.Forms.DateTimePicker();
            this.maxDateOfConsert = new System.Windows.Forms.DateTimePicker();
            this.Filter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // MinPrice
            // 
            this.MinPrice.Depth = 0;
            this.MinPrice.Hint = "";
            this.MinPrice.Location = new System.Drawing.Point(162, 171);
            this.MinPrice.MaxLength = 32767;
            this.MinPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.PasswordChar = '\0';
            this.MinPrice.SelectedText = "";
            this.MinPrice.SelectionLength = 0;
            this.MinPrice.SelectionStart = 0;
            this.MinPrice.Size = new System.Drawing.Size(286, 28);
            this.MinPrice.TabIndex = 0;
            this.MinPrice.TabStop = false;
            this.MinPrice.UseSystemPasswordChar = false;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text1.Location = new System.Drawing.Point(12, 171);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(138, 25);
            this.Text1.TabIndex = 1;
            this.Text1.Text = "Minimum price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maximum price";
            // 
            // MaxPrice
            // 
            this.MaxPrice.Depth = 0;
            this.MaxPrice.Hint = "";
            this.MaxPrice.Location = new System.Drawing.Point(162, 215);
            this.MaxPrice.MaxLength = 32767;
            this.MaxPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.PasswordChar = '\0';
            this.MaxPrice.SelectedText = "";
            this.MaxPrice.SelectionLength = 0;
            this.MaxPrice.SelectionStart = 0;
            this.MaxPrice.Size = new System.Drawing.Size(286, 28);
            this.MaxPrice.TabIndex = 2;
            this.MaxPrice.TabStop = false;
            this.MaxPrice.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maximum date";
            // 
            // minDateOfConsert
            // 
            this.minDateOfConsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minDateOfConsert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.minDateOfConsert.Location = new System.Drawing.Point(162, 81);
            this.minDateOfConsert.Name = "minDateOfConsert";
            this.minDateOfConsert.Size = new System.Drawing.Size(286, 28);
            this.minDateOfConsert.TabIndex = 6;
            // 
            // maxDateOfConsert
            // 
            this.maxDateOfConsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxDateOfConsert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.maxDateOfConsert.Location = new System.Drawing.Point(162, 127);
            this.maxDateOfConsert.Name = "maxDateOfConsert";
            this.maxDateOfConsert.Size = new System.Drawing.Size(286, 28);
            this.maxDateOfConsert.TabIndex = 7;
            // 
            // Filter
            // 
            this.Filter.AutoSize = true;
            this.Filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Filter.Depth = 0;
            this.Filter.Icon = null;
            this.Filter.Location = new System.Drawing.Point(196, 280);
            this.Filter.MouseState = MaterialSkin.MouseState.HOVER;
            this.Filter.Name = "Filter";
            this.Filter.Primary = true;
            this.Filter.Size = new System.Drawing.Size(76, 36);
            this.Filter.TabIndex = 8;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // FilterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 328);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.maxDateOfConsert);
            this.Controls.Add(this.minDateOfConsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxPrice);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.MinPrice);
            this.Name = "FilterSettings";
            this.Text = "FilterSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField MinPrice;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField MaxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker minDateOfConsert;
        private System.Windows.Forms.DateTimePicker maxDateOfConsert;
        private MaterialSkin.Controls.MaterialRaisedButton Filter;
    }
}