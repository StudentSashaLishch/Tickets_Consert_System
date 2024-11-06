namespace Tickets_Consert_System
{
    partial class Form1
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
            this.SignUp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LogIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome";
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignUp.Depth = 0;
            this.SignUp.Icon = null;
            this.SignUp.Location = new System.Drawing.Point(34, 172);
            this.SignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.SignUp.Name = "SignUp";
            this.SignUp.Primary = true;
            this.SignUp.Size = new System.Drawing.Size(88, 36);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Sign up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // LogIn
            // 
            this.LogIn.AutoSize = true;
            this.LogIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogIn.Depth = 0;
            this.LogIn.Icon = null;
            this.LogIn.Location = new System.Drawing.Point(34, 249);
            this.LogIn.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.LogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogIn.Name = "LogIn";
            this.LogIn.Primary = true;
            this.LogIn.Size = new System.Drawing.Size(76, 36);
            this.LogIn.TabIndex = 2;
            this.LogIn.Text = "Log in ";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To create a new account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "To log in to already existing account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tickets_Consert_System.Properties.Resources.Ticket_pikture_1;
            this.pictureBox1.Location = new System.Drawing.Point(329, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 379);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(34, 397);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(241, 36);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Enter as administrator";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter into the system as aministrator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main_Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton SignUp;
        private MaterialSkin.Controls.MaterialRaisedButton LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Label label4;
    }
}

