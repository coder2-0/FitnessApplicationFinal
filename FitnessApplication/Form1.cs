using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-QGT2VC1\\SQLEXPRESS;Initial Catalog=FitnessAppDB;Integrated Security=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Query to retrieve the UserID for the given username and password
                string query = "SELECT UserID FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result != null)
                    {
                        int userID = Convert.ToInt32(result); // Retrieve UserID
                        MessageBox.Show("Login successful!");

                        // Pass username and userID to MainForm
                        var mainForm = new MainForm(username, userID);
                        mainForm.Show();
                        this.Hide(); // Hide LoginForm
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open the RegistrationForm as a dialog
            var registrationForm = new RegistrationForm(connectionString);
            registrationForm.ShowDialog();
        }
    }
}
