// In travel-userprofile.cs
using System;
using System.Windows.Forms;

namespace travel_booking
{
    public partial class travel_userprofile : Form
    {
        public travel_userprofile()
        {
            InitializeComponent();
        }

        private void travel_userprofile_Load(object sender, EventArgs e)
        {
            LoadUserProfileData();
        }

        // 👤 Loads data from the session into the labels
        private void LoadUserProfileData()
        {
            if (UserSession.CurrentUser == null)
            {
                MessageBox.Show("You are not logged in.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            nameLabel.Text = $"Name: {UserSession.CurrentUser.FullName}";
            emailLabel.Text = $"Email: {UserSession.CurrentUser.UserEmail}"; // Using Username as Email
            usernameLabel.Text = $"Username: {UserSession.CurrentUser.Username}";
        }

        // ✏️ Opens the form to edit the user's profile
        private void editProfileButton_Click(object sender, EventArgs e)
        {
            // Open the new edit form as a dialog
            travel_editprofile editForm = new travel_editprofile();
            editForm.ShowDialog();

            // After the edit form is closed, refresh the data on this form
            LoadUserProfileData();
        }

        // 🏠 Closes this form to go back to the previous one (Homepage)
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Homepage();
            home.ShowDialog();
            this.Close();

        }        
        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserSession.EndSession();
            var loginform = new travel_login();
            loginform.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}