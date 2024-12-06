namespace FitnessApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            dgvClasses = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnBook = new Button();
            btnViewDetails = new Button();
            btnLogout = new Button();
            btnViewHistory = new Button();
            dgvRecommendations = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecommendations).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(0, 122, 204);
            lblWelcome.Location = new Point(98, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(265, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [Username]";
            // 
            // dgvClasses
            // 
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.BorderStyle = BorderStyle.None;
            dgvClasses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.Location = new Point(54, 100);
            dgvClasses.Name = "dgvClasses";
            dgvClasses.RowHeadersWidth = 51;
            dgvClasses.Size = new Size(483, 188);
            dgvClasses.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(552, 54);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 30);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 122, 204);
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(752, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 39);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(0, 122, 204);
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(752, 143);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(94, 35);
            btnBook.TabIndex = 4;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(42, 187, 155);
            btnViewDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(739, 218);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(119, 39);
            btnViewDetails.TabIndex = 5;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 87, 34);
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 38);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.BackColor = Color.FromArgb(42, 187, 155);
            btnViewHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewHistory.ForeColor = Color.White;
            btnViewHistory.Location = new Point(682, 422);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(164, 41);
            btnViewHistory.TabIndex = 7;
            btnViewHistory.Text = "View Past Classes";
            btnViewHistory.UseVisualStyleBackColor = false;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // dgvRecommendations
            // 
            dgvRecommendations.BackgroundColor = Color.White;
            dgvRecommendations.BorderStyle = BorderStyle.None;
            dgvRecommendations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecommendations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecommendations.Location = new Point(54, 328);
            dgvRecommendations.Name = "dgvRecommendations";
            dgvRecommendations.RowHeadersWidth = 51;
            dgvRecommendations.Size = new Size(426, 188);
            dgvRecommendations.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 288);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 9;
            label1.Text = "Recommended Classes";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 528);
            Controls.Add(label1);
            Controls.Add(dgvRecommendations);
            Controls.Add(btnViewHistory);
            Controls.Add(btnLogout);
            Controls.Add(btnViewDetails);
            Controls.Add(btnBook);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvClasses);
            Controls.Add(lblWelcome);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecommendations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private DataGridView dgvClasses;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnBook;
        private Button btnViewDetails;
        private Button btnLogout;
        private Button btnViewHistory;
        private DataGridView dgvRecommendations;
        private Label label1;
    }
}
