using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace travel_booking
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        // This event will run automatically when the Homepage opens
        private void Homepage_Load(object sender, EventArgs e)
        {
            PersonalizeHomepage();
            LoadFeaturedPackages();
        }

        private void PersonalizeHomepage()
        {
            // Set the welcome message using the logged-in user's data
            if (UserSession.CurrentUser != null)
            {
                // Assuming your welcome label is named 'label1'
                label1.Text = $"Welcome, {UserSession.CurrentUser.FullName}!";
            }
        }

        private void LoadFeaturedPackages()
        {
            // 1. Fetch a list of packages from the database
            List<Package> packages = GetPackagesFromDb(3); // Get top 3 packages for the homepage

            // 2. Update the GroupBox controls with the package data
            if (packages.Count > 0)
            {
                // Update the first package box (groupBox1)
                groupBox1.Text = packages[0].PackageName;
                label2.Text = $"Duration: {packages[0].DurationDays} days";
                label3.Text = $"Price: ₹{packages[0].PricePerPerson:N2} /person";
            }

            if (packages.Count > 1)
            {
                // Update the second package box (groupBox2)
                groupBox2.Text = packages[1].PackageName;
                label7.Text = $"Duration: {packages[1].DurationDays} days";
                label5.Text = $"Price: ₹{packages[1].PricePerPerson:N2} /person";
            }

            if (packages.Count > 2)
            {
                // Update the third package box (groupBox3)
                groupBox3.Text = packages[2].PackageName;
                label9.Text = $"Duration: {packages[2].DurationDays} days"; // label9 is in groupBox3
                label8.Text = $"Price: ₹{packages[2].PricePerPerson:N2} /person"; // label8 is in groupBox3
            }
        }

        /// <summary>
        /// Retrieves a specified number of packages from the database.
        /// </summary>
        /// <param name="numberOfPackages">The number of packages to fetch.</param>
        /// <returns>A list of Package objects.</returns>
        private List<Package> GetPackagesFromDb(int numberOfPackages)
        {
            var packageList = new List<Package>();

            try
            {
                using (var con = new SqlConnection(DbConnection.ConnectionString))
                {
                    // Using TOP to limit the results
                    string query = $"SELECT TOP {numberOfPackages} PackageId, PackageName, Description, PricePerPerson, DurationDays FROM Packages ORDER BY PackageId";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var package = new Package
                                {
                                    PackageId = reader.GetInt32(reader.GetOrdinal("PackageId")),
                                    PackageName = reader.GetString(reader.GetOrdinal("PackageName")),
                                    Description = reader.GetString(reader.GetOrdinal("Description")),
                                    PricePerPerson = reader.GetDecimal(reader.GetOrdinal("PricePerPerson")),
                                    DurationDays = reader.GetInt32(reader.GetOrdinal("DurationDays"))
                                };
                                packageList.Add(package);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load packages from the database. \nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return packageList;
        }

        // --- Your Button Click Events ---

        // Rename button1 to 'explorePackagesButton' in the designer for clarity
        private void explorePackagesButton_Click(object sender, EventArgs e)
        {
            travel_explorepackage exploreForm = new travel_explorepackage();
            exploreForm.Show();
        }

        // Rename button2 to 'logoutButton' in the designer
        private void logoutButton_Click(object sender, EventArgs e)
        {
            UserSession.EndSession();
            this.Hide();
            travel_login loginForm = new travel_login();
            loginForm.ShowDialog();
            this.Close();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            travel_explorepackage travelexpl = new travel_explorepackage();
            travelexpl.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mybook = new travel_mybooking();
            mybook.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            UserSession.EndSession();            
            this.Hide();            
            travel_login loginForm = new travel_login();
            loginForm.ShowDialog();            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profile = new travel_userprofile();
            profile.ShowDialog();
            this.Close();
        }
    }
}