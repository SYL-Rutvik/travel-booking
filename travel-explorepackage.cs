using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace travel_booking
{
    public partial class travel_explorepackage : Form
    {
        private List<Package> allPackages = new List<Package>();

        public travel_explorepackage()
        {
            InitializeComponent();
            LoadAllPackages();
        }

        private void LoadAllPackages()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    // Query to get all packages, you can limit this with TOP if you want
                    string query = "SELECT PackageId,Name, Description, BasePrice, duration FROM Packages ORDER BY PackageId;";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                allPackages.Add(new Package
                                {
                                    PackageId = Convert.ToInt32(reader["PackageId"]),
                                    PackageName = reader["Name"].ToString(),
                                    PricePerPerson = Convert.ToDecimal(reader["BasePrice"]),
                                    DurationDays = Convert.ToInt32(reader["duration"])
                                });
                            }
                        }
                    }
                }

                // Update the UI with the data
                PopulateAllPackageViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load package data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateAllPackageViews()
        {
            // A list of all GroupBoxes on the form for easy access
            var groupBoxes = new List<GroupBox> { groupBox1, groupBox2, groupBox3, groupBox6, groupBox5, groupBox4 };

            // Hide all group boxes initially
            foreach (var gb in groupBoxes)
            {
                gb.Visible = false;
            }

            // Loop through the packages and make the corresponding groupbox visible and update its text
            for (int i = 0; i < allPackages.Count; i++)
            {
                if (i < groupBoxes.Count) // Make sure we don't go out of bounds
                {
                    var currentPackage = allPackages[i];
                    var currentGroupBox = groupBoxes[i];

                    currentGroupBox.Visible = true;
                    currentGroupBox.Text = currentPackage.PackageName;

                    // Find labels by their names within the current GroupBox
                    // This assumes the label names are consistent but different for each box (e.g., label2, label7, etc.)
                    // It's better to name them consistently like 'lblName', 'lblDuration', 'lblPrice' inside each groupbox.
                    // For now, we manually map them based on your designer file.
                    UpdateGroupBoxLabels(currentGroupBox, currentPackage);
                }
            }
        }

        // Helper method to update labels based on which GroupBox it is
        private void UpdateGroupBoxLabels(GroupBox gb, Package package)
        {
            string destLabelName = "", durLabelName = "", priceLabelName = "";

            if (gb.Name == "groupBox1") { destLabelName = "label2"; durLabelName = "label3"; priceLabelName = "label4"; }
            if (gb.Name == "groupBox2") { destLabelName = "label7"; durLabelName = "label6"; priceLabelName = "label5"; }
            if (gb.Name == "groupBox3") { destLabelName = "label10"; durLabelName = "label9"; priceLabelName = "label8"; }
            if (gb.Name == "groupBox6") { destLabelName = "label18"; durLabelName = "label17"; priceLabelName = "label16"; } // Corresponds to bottom-left
            if (gb.Name == "groupBox5") { destLabelName = "label15"; durLabelName = "label14"; priceLabelName = "label13"; } // Corresponds to bottom-middle
            if (gb.Name == "groupBox4") { destLabelName = "label12"; durLabelName = "label11"; priceLabelName = "label1"; }  // Corresponds to bottom-right

            if (!string.IsNullOrEmpty(destLabelName))
            {
                (gb.Controls[destLabelName] as Label).Text = $"Destination: {package.PackageName}";
                (gb.Controls[durLabelName] as Label).Text = $"Duration: {package.DurationDays} Days";
                (gb.Controls[priceLabelName] as Label).Text = $"Price: ₹{package.PricePerPerson:N2}";
            }
        }

        // Event for your "Book Package" button (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            travel_bookingform bookingForm = new travel_bookingform();
            bookingForm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new Homepage();
            dashboard.ShowDialog();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            
            UserSession.EndSession();


            this.Hide();
            travel_login loginForm = new travel_login();
            loginForm.ShowDialog(); 
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new travel_userprofile();
            dashboard.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserSession.EndSession();
            this.Hide();
            travel_login loginForm = new travel_login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}