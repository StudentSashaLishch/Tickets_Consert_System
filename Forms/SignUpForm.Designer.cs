namespace Tickets_Consert_System.Forms
{
    partial class SignUpForm
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
            this.LoginField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.FullNameField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ClientRole = new MaterialSkin.Controls.MaterialRadioButton();
            this.SingerRole = new MaterialSkin.Controls.MaterialRadioButton();
            this.ManagerRole = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.RepeatPasswordField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create your own account";
            // 
            // LoginField
            // 
            this.LoginField.Depth = 0;
            this.LoginField.Hint = "";
            this.LoginField.Location = new System.Drawing.Point(113, 154);
            this.LoginField.MaxLength = 32767;
            this.LoginField.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginField.Name = "LoginField";
            this.LoginField.PasswordChar = '\0';
            this.LoginField.SelectedText = "";
            this.LoginField.SelectionLength = 0;
            this.LoginField.SelectionStart = 0;
            this.LoginField.Size = new System.Drawing.Size(367, 28);
            this.LoginField.TabIndex = 2;
            this.LoginField.TabStop = false;
            this.LoginField.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // PasswordField
            // 
            this.PasswordField.Depth = 0;
            this.PasswordField.Hint = "";
            this.PasswordField.Location = new System.Drawing.Point(164, 322);
            this.PasswordField.MaxLength = 32767;
            this.PasswordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.SelectedText = "";
            this.PasswordField.SelectionLength = 0;
            this.PasswordField.SelectionStart = 0;
            this.PasswordField.Size = new System.Drawing.Size(316, 28);
            this.PasswordField.TabIndex = 4;
            this.PasswordField.TabStop = false;
            this.PasswordField.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Full name:";
            // 
            // FullNameField
            // 
            this.FullNameField.Depth = 0;
            this.FullNameField.Hint = "";
            this.FullNameField.Location = new System.Drawing.Point(164, 210);
            this.FullNameField.MaxLength = 32767;
            this.FullNameField.MouseState = MaterialSkin.MouseState.HOVER;
            this.FullNameField.Name = "FullNameField";
            this.FullNameField.PasswordChar = '\0';
            this.FullNameField.SelectedText = "";
            this.FullNameField.SelectionLength = 0;
            this.FullNameField.SelectionStart = 0;
            this.FullNameField.Size = new System.Drawing.Size(316, 28);
            this.FullNameField.TabIndex = 6;
            this.FullNameField.TabStop = false;
            this.FullNameField.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // EmailField
            // 
            this.EmailField.Depth = 0;
            this.EmailField.Hint = "";
            this.EmailField.Location = new System.Drawing.Point(113, 265);
            this.EmailField.MaxLength = 32767;
            this.EmailField.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailField.Name = "EmailField";
            this.EmailField.PasswordChar = '\0';
            this.EmailField.SelectedText = "";
            this.EmailField.SelectionLength = 0;
            this.EmailField.SelectionStart = 0;
            this.EmailField.Size = new System.Drawing.Size(367, 28);
            this.EmailField.TabIndex = 8;
            this.EmailField.TabStop = false;
            this.EmailField.UseSystemPasswordChar = false;
            // 
            // ClientRole
            // 
            this.ClientRole.AutoSize = true;
            this.ClientRole.Depth = 0;
            this.ClientRole.Font = new System.Drawing.Font("Roboto", 10F);
            this.ClientRole.Location = new System.Drawing.Point(570, 286);
            this.ClientRole.Margin = new System.Windows.Forms.Padding(0);
            this.ClientRole.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ClientRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClientRole.Name = "ClientRole";
            this.ClientRole.Ripple = true;
            this.ClientRole.Size = new System.Drawing.Size(74, 30);
            this.ClientRole.TabIndex = 10;
            this.ClientRole.TabStop = true;
            this.ClientRole.Text = "Client";
            this.ClientRole.UseVisualStyleBackColor = true;
            // 
            // SingerRole
            // 
            this.SingerRole.AutoSize = true;
            this.SingerRole.Depth = 0;
            this.SingerRole.Font = new System.Drawing.Font("Roboto", 10F);
            this.SingerRole.Location = new System.Drawing.Point(570, 231);
            this.SingerRole.Margin = new System.Windows.Forms.Padding(0);
            this.SingerRole.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SingerRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.SingerRole.Name = "SingerRole";
            this.SingerRole.Ripple = true;
            this.SingerRole.Size = new System.Drawing.Size(79, 30);
            this.SingerRole.TabIndex = 11;
            this.SingerRole.TabStop = true;
            this.SingerRole.Text = "Singer";
            this.SingerRole.UseVisualStyleBackColor = true;
            // 
            // ManagerRole
            // 
            this.ManagerRole.AutoSize = true;
            this.ManagerRole.Depth = 0;
            this.ManagerRole.Font = new System.Drawing.Font("Roboto", 10F);
            this.ManagerRole.Location = new System.Drawing.Point(570, 177);
            this.ManagerRole.Margin = new System.Windows.Forms.Padding(0);
            this.ManagerRole.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ManagerRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManagerRole.Name = "ManagerRole";
            this.ManagerRole.Ripple = true;
            this.ManagerRole.Size = new System.Drawing.Size(98, 30);
            this.ManagerRole.TabIndex = 12;
            this.ManagerRole.TabStop = true;
            this.ManagerRole.Text = "Manager";
            this.ManagerRole.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 435);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(100, 36);
            this.materialRaisedButton1.TabIndex = 13;
            this.materialRaisedButton1.Text = "Register";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(702, 435);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(86, 36);
            this.materialRaisedButton2.TabIndex = 14;
            this.materialRaisedButton2.Text = "Cansel";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Repeat Password:";
            // 
            // RepeatPasswordField
            // 
            this.RepeatPasswordField.Depth = 0;
            this.RepeatPasswordField.Hint = "";
            this.RepeatPasswordField.Location = new System.Drawing.Point(255, 361);
            this.RepeatPasswordField.MaxLength = 32767;
            this.RepeatPasswordField.MouseState = MaterialSkin.MouseState.HOVER;
            this.RepeatPasswordField.Name = "RepeatPasswordField";
            this.RepeatPasswordField.PasswordChar = '*';
            this.RepeatPasswordField.SelectedText = "";
            this.RepeatPasswordField.SelectionLength = 0;
            this.RepeatPasswordField.SelectionStart = 0;
            this.RepeatPasswordField.Size = new System.Drawing.Size(225, 28);
            this.RepeatPasswordField.TabIndex = 15;
            this.RepeatPasswordField.TabStop = false;
            this.RepeatPasswordField.UseSystemPasswordChar = false;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Checked = true;
            this.materialCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(570, 360);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(146, 30);
            this.materialCheckBox1.TabIndex = 17;
            this.materialCheckBox1.Text = "Hide password";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RepeatPasswordField);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.ManagerRole);
            this.Controls.Add(this.SingerRole);
            this.Controls.Add(this.ClientRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FullNameField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordField;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField FullNameField;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmailField;
        private MaterialSkin.Controls.MaterialRadioButton ClientRole;
        private MaterialSkin.Controls.MaterialRadioButton SingerRole;
        private MaterialSkin.Controls.MaterialRadioButton ManagerRole;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField RepeatPasswordField;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
    }
}