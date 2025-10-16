// In travel-bookingform.cs
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace travel_booking
{
    public partial class travel_bookingform : Form
    {
        private List<Package> availablePackages = new List<Package>();

        public travel_bookingform()
        {
            InitializeComponent();
        }

        // This is the ONLY Load event handler the form will use.
        private void travel_bookingform_Load(object sender, EventArgs e)
        {
            LoadPackagesIntoComboBox();
            SetDatePickerMinimumDate();
        }

        private void LoadPackagesIntoComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    string query = "SELECT PackageId, Name, BasePrice FROM Packages ORDER BY Name;";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                availablePackages.Add(new Package
                                {
                                    PackageId = Convert.ToInt32(reader["PackageId"]),
                                    PackageName = reader["Name"].ToString(),
                                    PricePerPerson = reader["BasePrice"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["BasePrice"])
                                });
                            }
                        }
                    }
                }

                // --- Bind the ComboBox to our list of packages ---
                comboBox1.DataSource = availablePackages;
                // ✅ This string MUST match the property in your Package.cs class
                comboBox1.DisplayMember = "PackageName";
                comboBox1.ValueMember = "PackageId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load packages: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDatePickerMinimumDate()
        {
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
        }

        private void UpdateTotalCost(object sender, EventArgs e)
        {
            // The selected item is now a 'Package' object, so we cast it.
            if (comboBox1.SelectedItem is Package selectedPackage)
            {
                int numberOfPeople = (int)numericUpDown1.Value;
                decimal totalCost = selectedPackage.PricePerPerson * numberOfPeople;
                label4.Text = $"Total Cost : ₹ {totalCost:N2}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser == null)
            {
                MessageBox.Show("You must be logged in to make a booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure an item is selected before proceeding
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a package.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = UserSession.CurrentUser.UserId;
            int packageId = (int)comboBox1.SelectedValue;
            DateTime startDate = dateTimePicker1.Value;
            int numberOfPeople = (int)numericUpDown1.Value;
            decimal totalPrice = ((Package)comboBox1.SelectedItem).PricePerPerson * numberOfPeople;

            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    string query = "INSERT INTO Bookings (UserId, PackageId, StartDate, NumberOfPeople, TotalPrice, BookingDate, Status) VALUES (@UserId, @PackageId, @StartDate, @NumPeople, @TotalPrice, GETDATE(), 'Confirmed')";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@PackageId", packageId);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@NumPeople", numberOfPeople);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while booking: " + ex.Message, "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}