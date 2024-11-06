namespace Tickets_Consert_System.Forms
{
    partial class ReviewOfSinger
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
            this.SingerName = new System.Windows.Forms.Label();
            this.ManagerName = new System.Windows.Forms.Label();
            this.AverageRating = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeaveReview = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Next = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.myReview = new System.Windows.Forms.TextBox();
            this.Done = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Rating = new System.Windows.Forms.TextBox();
            this.Cancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SingerName
            // 
            this.SingerName.AutoSize = true;
            this.SingerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingerName.Location = new System.Drawing.Point(12, 83);
            this.SingerName.Name = "SingerName";
            this.SingerName.Size = new System.Drawing.Size(161, 26);
            this.SingerName.TabIndex = 0;
            this.SingerName.Text = "Singer name: ";
            // 
            // ManagerName
            // 
            this.ManagerName.AutoSize = true;
            this.ManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagerName.Location = new System.Drawing.Point(12, 121);
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.Size = new System.Drawing.Size(402, 26);
            this.ManagerName.TabIndex = 1;
            this.ManagerName.Text = "Name of manager which recresents: ";
            // 
            // AverageRating
            // 
            this.AverageRating.AutoSize = true;
            this.AverageRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageRating.Location = new System.Drawing.Point(12, 160);
            this.AverageRating.Name = "AverageRating";
            this.AverageRating.Size = new System.Drawing.Size(181, 26);
            this.AverageRating.TabIndex = 2;
            this.AverageRating.Text = "Average rating: ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Rating);
            this.panel1.Controls.Add(this.Done);
            this.panel1.Controls.Add(this.myReview);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(82, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 196);
            this.panel1.TabIndex = 3;
            // 
            // LeaveReview
            // 
            this.LeaveReview.AutoSize = true;
            this.LeaveReview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LeaveReview.Depth = 0;
            this.LeaveReview.Icon = null;
            this.LeaveReview.Location = new System.Drawing.Point(319, 402);
            this.LeaveReview.MouseState = MaterialSkin.MouseState.HOVER;
            this.LeaveReview.Name = "LeaveReview";
            this.LeaveReview.Primary = true;
            this.LeaveReview.Size = new System.Drawing.Size(154, 36);
            this.LeaveReview.TabIndex = 4;
            this.LeaveReview.Text = "Leave a review";
            this.LeaveReview.UseVisualStyleBackColor = true;
            this.LeaveReview.Click += new System.EventHandler(this.LeaveReview_Click);
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Next.Depth = 0;
            this.Next.Icon = null;
            this.Next.Location = new System.Drawing.Point(724, 272);
            this.Next.MouseState = MaterialSkin.MouseState.HOVER;
            this.Next.Name = "Next";
            this.Next.Primary = true;
            this.Next.Size = new System.Drawing.Size(31, 36);
            this.Next.TabIndex = 5;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Back.Depth = 0;
            this.Back.Icon = null;
            this.Back.Location = new System.Drawing.Point(45, 272);
            this.Back.MouseState = MaterialSkin.MouseState.HOVER;
            this.Back.Name = "Back";
            this.Back.Primary = true;
            this.Back.Size = new System.Drawing.Size(31, 36);
            this.Back.TabIndex = 6;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "There are no reviews";
            // 
            // myReview
            // 
            this.myReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myReview.Location = new System.Drawing.Point(3, 3);
            this.myReview.Multiline = true;
            this.myReview.Name = "myReview";
            this.myReview.Size = new System.Drawing.Size(630, 151);
            this.myReview.TabIndex = 1;
            // 
            // Done
            // 
            this.Done.AutoSize = true;
            this.Done.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Done.Depth = 0;
            this.Done.Icon = null;
            this.Done.Location = new System.Drawing.Point(460, 157);
            this.Done.MouseState = MaterialSkin.MouseState.HOVER;
            this.Done.Name = "Done";
            this.Done.Primary = true;
            this.Done.Size = new System.Drawing.Size(67, 36);
            this.Done.TabIndex = 7;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Rating
            // 
            this.Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rating.Location = new System.Drawing.Point(87, 157);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(100, 30);
            this.Rating.TabIndex = 8;
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.Depth = 0;
            this.Cancel.Icon = null;
            this.Cancel.Location = new System.Drawing.Point(546, 157);
            this.Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancel.Name = "Cancel";
            this.Cancel.Primary = true;
            this.Cancel.Size = new System.Drawing.Size(87, 36);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rating: ";
            // 
            // ReviewOfSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.LeaveReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AverageRating);
            this.Controls.Add(this.ManagerName);
            this.Controls.Add(this.SingerName);
            this.Name = "ReviewOfSinger";
            this.Text = "ReviewOfSinger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SingerName;
        private System.Windows.Forms.Label ManagerName;
        private System.Windows.Forms.Label AverageRating;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton LeaveReview;
        private MaterialSkin.Controls.MaterialRaisedButton Next;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton Back;
        private MaterialSkin.Controls.MaterialRaisedButton Done;
        private System.Windows.Forms.TextBox myReview;
        private MaterialSkin.Controls.MaterialRaisedButton Cancel;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.Label label3;
    }
}