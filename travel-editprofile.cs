using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace travel_booking
{
    public partial class travel_editprofile : Form
    {
        public travel_editprofile()
        {
            InitializeComponent();
        }

        private void travel_editprofile_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        // Fetches the user's current data from the database.
        private void LoadUserData()
        {
            if (UserSession.CurrentUser == null) return;

            int userId = UserSession.CurrentUser.UserId;

            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    string query = "SELECT Username, Dob, MobileNo FROM Users WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usernameTextBox.Text = reader["Username"].ToString();
                                
                                // Safely read nullable fields to prevent errors
                                mobileTextBox.Text = reader["MobileNo"] == DBNull.Value ? "" : reader["MobileNo"].ToString();

                                if (reader["Dob"] != DBNull.Value)
                                {
                                    dobDateTimePicker.Value = Convert.ToDateTime(reader["Dob"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load your profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Saves the updated data back to the database.
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = UserSession.CurrentUser.UserId;

            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    string query = "UPDATE Users SET Username = @Username, Dob = @Dob, MobileNo = @MobileNo WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("@MobileNo", string.IsNullOrWhiteSpace(mobileTextBox.Text) ? (object)DBNull.Value : mobileTextBox.Text);
                        cmd.Parameters.AddWithValue("@Dob", dobDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        
                        con.Open();
                        cmd.ExecuteNonQuery();

                        // ✅ IMPORTANT: Update the session so the rest of the app sees the new username!
                        UserSession.CurrentUser.Username = usernameTextBox.Text;

                        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Close the form after saving
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving your profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Closes the current form and returns to the previous one.
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}