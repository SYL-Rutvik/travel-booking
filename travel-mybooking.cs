using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using travel_booking;

namespace travel_booking
{
    public partial class travel_mybooking : Form
    {
        public travel_mybooking()
        {
            InitializeComponent();
        }

        private void travel_mybooking_Load(object sender, EventArgs e)
        {
            LoadUserBookings();
        }

        private void LoadUserBookings()
        {
            // 1. Check for logged-in user
            if (UserSession.CurrentUser == null)
            {
                MessageBox.Show("You must be logged in to view your bookings.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            // 2. Get UserId from the session
            int currentUserId = UserSession.CurrentUser.UserId;
            titleLabel.Text = $"Bookings for {UserSession.CurrentUser.FullName}";

            try
            {
                using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                {
                    string query = @"
                    SELECT b.BookingId, p.Name, b.StartDate, b.NumberOfPeople, b.TotalPrice, b.Status
                    FROM Bookings b
                    JOIN Packages p ON b.PackageId = p.PackageId
                    WHERE b.UserId = @UserId AND b.Status <> 'Cancelled'";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@UserId", currentUserId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bookingsDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load bookings. Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (bookingsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int bookingId = Convert.ToInt32(bookingsDataGridView.SelectedRows[0].Cells["BookingId"].Value);

                    using (SqlConnection con = new SqlConnection(DbConnection.ConnectionString))
                    {
                        string query = "UPDATE Bookings SET Status = 'Cancelled' WHERE BookingId = @BookingId";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@BookingId", bookingId);
                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Booking cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserBookings(); // Refresh the list
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cancelling booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bookingsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage();
            homepage.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSession.EndSession();
            var login=new travel_login();
            login.ShowDialog();
            this.Close();
        }
    }
}