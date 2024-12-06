using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class ClassDetailsForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-QGT2VC1\\SQLEXPRESS;Initial Catalog=FitnessAppDB;Integrated Security=True;";
        private FitnessClass fitnessClass;
        private string loggedInUser;
        private int loggedInUserID;

        public ClassDetailsForm(FitnessClass fitnessClass, string username, int userID)
        {
            InitializeComponent();
            this.fitnessClass = fitnessClass;
            loggedInUser = username;
            loggedInUserID = userID;

            PopulateInstructors();
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            lblClassName.Text = fitnessClass.ClassName;
            lblInstructor.Text = fitnessClass.Instructor;
            lblSchedule.Text = fitnessClass.Schedule.ToString();
        }

        private void PopulateInstructors()
        {
            // Predefined list of instructors
            cmbInstructors.Items.AddRange(new[] { "John Smith", "Jane Doe", "Emily Davis", "Michael Brown" });
            cmbInstructors.SelectedIndex = 0; // Set default selection
        }

        private void btnChangeInstructor_Click(object sender, EventArgs e)
        {
            string newInstructor = cmbInstructors.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newInstructor))
            {
                MessageBox.Show("Please select an instructor.");
                return;
            }

            fitnessClass.Instructor = newInstructor;
            lblInstructor.Text = fitnessClass.Instructor;
            MessageBox.Show("Instructor updated successfully!");
        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            DateTime newSchedule = dtpNewSchedule.Value;

            if (newSchedule <= DateTime.Now)
            {
                MessageBox.Show("The new schedule must be in the future.");
                return;
            }

            RescheduleBooking(newSchedule);
        }

        private void btnRateReview_Click(object sender, EventArgs e)
        {
            int rating = (int)nudRating.Value;
            string review = txtReview.Text.Trim();

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Please provide a rating between 1 and 5.");
                return;
            }

            if (string.IsNullOrEmpty(review))
            {
                MessageBox.Show("Please provide a review comment.");
                return;
            }

            SubmitReview(rating, review);
        }

        private void SubmitReview(int rating, string comment)
        {
            try
            {
                string selectedInstructor = cmbInstructors.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedInstructor))
                {
                    MessageBox.Show("Please select an instructor.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO Reviews (UserID, ClassID, Rating, Comment, InstructorName)
                VALUES (@UserID, @ClassID, @Rating, @Comment, @InstructorName)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", loggedInUserID);
                    cmd.Parameters.AddWithValue("@ClassID", fitnessClass.ClassID);
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Comment", comment);
                    cmd.Parameters.AddWithValue("@InstructorName", selectedInstructor); // Add selected instructor's name
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Review submitted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RescheduleBooking(DateTime newSchedule)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Bookings SET Schedule = @NewSchedule WHERE BookingID = @BookingID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NewSchedule", newSchedule);
                    cmd.Parameters.AddWithValue("@BookingID", GetBookingID());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    lblSchedule.Text = newSchedule.ToString();
                    MessageBox.Show("Booking rescheduled successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error rescheduling booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetBookingID()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID FROM Bookings WHERE UserID = @UserID AND ClassID = @ClassID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", loggedInUserID);
                cmd.Parameters.AddWithValue("@ClassID", fitnessClass.ClassID);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return (int)result;
                }
                else
                {
                    MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidOperationException("Booking ID not found.");
                }
            }
        }
    }
}
