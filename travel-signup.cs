using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using travel_booking;

namespace travel_booking
{
    public partial class travel_signup : Form
    {
        public travel_signup()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // 1. Validate Input
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hash the password
            string hashedPassword = PasswordHelper.HashPassword(passwordTextBox.Text);

            // 3. Insert into Database
            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    // Note: The Username column should store the email address
                    string query = "INSERT INTO Users (FullName, Email, Username, PasswordHash) VALUES (@FullName, @Email, @Username, @PasswordHash)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Username", emailTextBox.Text); // Storing email as username
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account created successfully! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Go to the login form
                        this.Hide();
                        travel_login loginForm = new travel_login();
                        loginForm.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627) // Unique constraint violation
            {
                MessageBox.Show("An account with this email already exists.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            travel_login loginForm = new travel_login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}