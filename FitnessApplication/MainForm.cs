using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class MainForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-QGT2VC1\\SQLEXPRESS;Initial Catalog=FitnessAppDB;Integrated Security=True;";
        private string loggedInUser;
        private int loggedInUserID;
        private List<FitnessClass> classes;

        public MainForm(string username, int userID)
        {
            InitializeComponent();
            loggedInUser = username;
            loggedInUserID = userID;
            lblWelcome.Text = $"Welcome, {loggedInUser}";
            InitializeClasses();
            LoadClasses();
            LoadRecommendations();
        }

        private void InitializeClasses()
        {
            classes = new List<FitnessClass>
            {
                new FitnessClass { ClassID = 1, ClassName = "Yoga", Instructor = "Alice", Schedule = DateTime.Now.AddHours(2), Capacity = 10 },
                new FitnessClass { ClassID = 2, ClassName = "Zumba", Instructor = "Bob", Schedule = DateTime.Now.AddDays(1), Capacity = 15 }
            };
        }

        private void LoadClasses()
        {
            dgvClasses.DataSource = null;
            dgvClasses.DataSource = classes.Select(c => new
            {
                c.ClassID,
                c.ClassName,
                c.Instructor,
                c.Schedule,
                c.Capacity
            }).ToList();
        }

        private void LoadRecommendations()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT DISTINCT Classes.ClassID, Classes.ClassName, Classes.Instructor, Classes.Schedule, Classes.Capacity
                        FROM Classes
                        JOIN Bookings ON Classes.ClassID = Bookings.ClassID
                        WHERE Bookings.UserID != @UserID 
                        AND Classes.ClassID IN (SELECT ClassID FROM Bookings WHERE UserID = @UserID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", loggedInUserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable recommendations = new DataTable();
                    adapter.Fill(recommendations);
                    dgvRecommendations.DataSource = recommendations;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recommendations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            var filteredClasses = classes.Where(c =>
                c.ClassName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                c.Instructor.Contains(keyword, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dgvClasses.DataSource = null;
            dgvClasses.DataSource = filteredClasses.Select(c => new
            {
                c.ClassID,
                c.ClassName,
                c.Instructor,
                c.Schedule,
                c.Capacity
            }).ToList();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvClasses.SelectedRows.Count > 0)
            {
                int classID = (int)dgvClasses.SelectedRows[0].Cells["ClassID"].Value;
                var selectedClass = classes.FirstOrDefault(c => c.ClassID == classID);

                if (selectedClass != null)
                {
                    // Book the class (logic for adding to database or class list)
                    MessageBox.Show($"Successfully booked the class: {selectedClass.ClassName}!");
                }
                else
                {
                    MessageBox.Show("Class not found or already booked.");
                }
            }
            else
            {
                MessageBox.Show("Please select a class to book.");
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvClasses.SelectedRows.Count > 0)
            {
                int classID = (int)dgvClasses.SelectedRows[0].Cells["ClassID"].Value;
                var selectedClass = classes.FirstOrDefault(c => c.ClassID == classID);
                if (selectedClass != null)
                {
                    // Pass the required arguments: FitnessClass, loggedInUser, and loggedInUserID
                    var detailsForm = new ClassDetailsForm(selectedClass, loggedInUser, loggedInUserID);
                    detailsForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a class to view details.");
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(loggedInUserID);
            historyForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
