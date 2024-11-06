using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tickets_Consert_System.Data.Models;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Forms
{
    public partial class ReviewOfSinger : MaterialForm
    {
        private Singer singer { get; set; }
        private Client client { get; set; }
        public List<Review> reviews { get; set; }
        public int CurrentReview { get; set; }

        public ReviewOfSinger()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public ReviewOfSinger(Singer singer, Client client) : this()
        {
            this.singer = singer;
            this.client = client;
            CurrentReview = 0;
            SearchReviews();
            OutputReview();
        }

        private async void SearchReviews()
        {
            reviews = await Repository<Review>
                .GetRepo()
                .GetAll(r => r.SingerID == singer.ID);
        }

        private async void OutputReview()
        {
            if (CurrentReview < 0)
                CurrentReview += reviews.Count - 1;
            else if (CurrentReview > reviews.Count)
                CurrentReview = 0;

            var ClientOne = await Repository<Client>
                .GetRepo()
                .GetComponent(reviews[CurrentReview].ClientID);
            var manager = await Repository<Manager>
                .GetRepo()
                .GetFirst(m => m.ContractID == singer.ContractID);

            SingerName.Text = "Singer name: " + singer.FullName;
            ManagerName.Text = "Name of manager which represents: " + manager.FullName;
            AverageRating.Text = "Average rating: " + CalculateAverageRating().ToString();

            string result = "Login: " + ClientOne.Login +
                "\nDate: " + reviews[CurrentReview].DateOfSending.ToString("mm:HH dd.MM.yyyy") +
                "\n" + reviews[CurrentReview].Text +
                "\nRating: " + reviews[CurrentReview].Rating;
        }

        private double CalculateAverageRating()
        {
            int sum = 0;

            foreach (var review in reviews)
            {
                sum += review.Rating;
            }

            return sum / reviews.Count;
        }

        private void ChangeReviewEdit(bool isEnable)
        {
            myReview.Enabled = isEnable;
            myReview.Visible = isEnable;
            Done.Enabled = isEnable;
            Done.Visible = isEnable;
            Cancel.Enabled = isEnable;
            Cancel.Visible = isEnable;
            Rating.Enabled = isEnable;
            Rating.Visible = isEnable;
            label3.Enabled = isEnable;
            label3.Visible = isEnable;
        }

        private void ChangeReviewSee(bool isEnable)
        {
            label2.Enabled = isEnable;
            label2.Visible = isEnable;
        }

        private void LeaveReview_Click(object sender, EventArgs e)
        {
            if(client.IsBanned)
            {
                MessageBox.Show("You are banned");
                return;
            }

            ChangeReviewEdit(true);
            ChangeReviewSee(false);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Rating.Text, out int rating) && rating >= 1 && rating <= 10)
            {
                MessageBox.Show("Rating value is invalid (this is must be an integer number between 1 and 10 )");
                return;
            }

            var newReview = new Review()
            {
                ClientID = client.ID,
                SingerID = singer.ID,
                Text = label2.Text,
                Rating = rating,
                DateOfSending = DateTime.Now
            };

            Repository<Review>
                .GetRepo()
                .Create(newReview);

            MessageBox.Show("Success");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ChangeReviewEdit(false);
            ChangeReviewSee(true);
            SearchReviews();
            OutputReview();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            CurrentReview--;
            OutputReview();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            CurrentReview++;
            OutputReview();
        }
    }
}
