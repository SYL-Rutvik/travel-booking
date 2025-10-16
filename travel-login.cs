using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using travel_booking;

namespace travel_booking
{

    public partial class travel_login : Form
    {
        public travel_login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = PasswordHelper.HashPassword(password);

            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    // We use 'Email' column to find the user
                    string query = "SELECT UserId, Username, FullName,Email FROM Users WHERE Email = @Email AND PasswordHash = @PasswordHash";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a match is found
                            {
                                var user = new LoggedInUser
                                {
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    FullName = reader["FullName"].ToString(),
                                    Username = reader["Username"].ToString(),
                                    UserEmail = reader["Email"].ToString()
                                };

                                // Start the session!
                                UserSession.StartSession(user);

                                // Open the homepage
                                this.Hide();
                                Homepage homepage = new Homepage();
                                homepage.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            travel_signup signupForm = new travel_signup();
            signupForm.ShowDialog();
            this.Close();
        }
    }
}