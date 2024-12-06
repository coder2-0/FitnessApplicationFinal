using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class HistoryForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-QGT2VC1\\SQLEXPRESS;Initial Catalog=FitnessAppDB;Integrated Security=True;";
        private int loggedInUserID;

        public HistoryForm(int userID)
        {
            InitializeComponent();
            loggedInUserID = userID;
            LoadHistory();
            CustomizeGridView();
        }

        private void LoadHistory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT Classes.ClassName, Classes.Instructor, Classes.Schedule, Bookings.BookingID
                        FROM Bookings
                        JOIN Classes ON Bookings.ClassID = Classes.ClassID
                        WHERE Bookings.UserID = @UserID AND Classes.Schedule < GETDATE()
                        ORDER BY Classes.Schedule DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", loggedInUserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable historyTable = new DataTable();
                    adapter.Fill(historyTable);

                    if (historyTable.Rows.Count > 0)
                    {
                        dgvHistory.DataSource = historyTable;
                    }
                    else
                    {
                        dgvHistory.DataSource = null;
                        MessageBox.Show("No past classes found.", "History");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Error");
            }
        }

        private void CustomizeGridView()
        {
            if (dgvHistory.Columns.Count > 0)
            {
                dgvHistory.Columns["BookingID"].Visible = false; // Hide internal IDs
                dgvHistory.Columns["ClassName"].HeaderText = "Class Name";
                dgvHistory.Columns["Instructor"].HeaderText = "Instructor";
                dgvHistory.Columns["Schedule"].HeaderText = "Date & Time";
                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close HistoryForm and return to MainForm
        }
    }
}
