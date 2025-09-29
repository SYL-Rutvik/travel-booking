using System;
using System.Data.SqlClient;
using System.Web.SessionState;
using System.Windows.Forms;
using travel_booking;
using TravelBookingSystem.Helpers;
using TravelBookingSystem.Models;

namespace TravelBookingSystem
{
    public partial class LoginForm : Form
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TravelBookingDb.mdf;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    var query = "SELECT UserId, FullName, Email, PasswordHash FROM Users WHERE Email = @Email";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var storedHash = reader["PasswordHash"].ToString();
                                if (PasswordHelper.VerifyPassword(txtPassword.Text, storedHash))
                                {
                                    var user = new User
                                    {
                                        UserId = (int)reader["UserId"],
                                        FullName = reader["FullName"].ToString(),
                                        Email = reader["Email"].ToString()
                                    };
                                    SessionManager.Login(user);

                                    var dashboard = new DashboardForm();
                                    dashboard.FormClosed += (s, args) => this.Close();
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void linkLabelSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

