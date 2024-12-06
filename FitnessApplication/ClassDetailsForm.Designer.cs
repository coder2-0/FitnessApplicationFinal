namespace FitnessApplication
{
    partial class ClassDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblClassName = new Label();
            lblInstructor = new Label();
            lblSchedule = new Label();
            btnChangeInstructor = new Button();
            dtpNewSchedule = new DateTimePicker();
            btnReschedule = new Button();
            nudRating = new NumericUpDown();
            txtReview = new TextBox();
            btnRateReview = new Button();
            cmbInstructors = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClassName.Location = new Point(30, 20);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(126, 28);
            lblClassName.TabIndex = 0;
            lblClassName.Text = "Class Name:";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInstructor.Location = new Point(30, 70);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(111, 28);
            lblInstructor.TabIndex = 1;
            lblInstructor.Text = "Instructor:";
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSchedule.Location = new Point(30, 120);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(102, 28);
            lblSchedule.TabIndex = 2;
            lblSchedule.Text = "Schedule:";
            // 
            // btnChangeInstructor
            // 
            btnChangeInstructor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChangeInstructor.Location = new Point(636, 52);
            btnChangeInstructor.Name = "btnChangeInstructor";
            btnChangeInstructor.Size = new Size(200, 35);
            btnChangeInstructor.TabIndex = 3;
            btnChangeInstructor.Text = "Change Instructor";
            btnChangeInstructor.UseVisualStyleBackColor = true;
            btnChangeInstructor.Click += btnChangeInstructor_Click;
            // 
            // dtpNewSchedule
            // 
            dtpNewSchedule.Font = new Font("Segoe UI", 10F);
            dtpNewSchedule.Location = new Point(292, 120);
            dtpNewSchedule.Name = "dtpNewSchedule";
            dtpNewSchedule.Size = new Size(200, 30);
            dtpNewSchedule.TabIndex = 4;
            // 
            // btnReschedule
            // 
            btnReschedule.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReschedule.Location = new Point(636, 113);
            btnReschedule.Name = "btnReschedule";
            btnReschedule.Size = new Size(200, 35);
            btnReschedule.TabIndex = 5;
            btnReschedule.Text = "Reschedule";
            btnReschedule.UseVisualStyleBackColor = true;
            btnReschedule.Click += btnReschedule_Click;
            // 
            // nudRating
            // 
            nudRating.Font = new Font("Segoe UI", 10F);
            nudRating.Location = new Point(189, 331);
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(200, 30);
            nudRating.TabIndex = 6;
            // 
            // txtReview
            // 
            txtReview.Font = new Font("Segoe UI", 10F);
            txtReview.Location = new Point(173, 272);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(450, 30);
            txtReview.TabIndex = 7;
            // 
            // btnRateReview
            // 
            btnRateReview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRateReview.Location = new Point(30, 399);
            btnRateReview.Name = "btnRateReview";
            btnRateReview.Size = new Size(200, 35);
            btnRateReview.TabIndex = 8;
            btnRateReview.Text = "Submit Review";
            btnRateReview.UseVisualStyleBackColor = true;
            btnRateReview.Click += btnRateReview_Click;
            // 
            // cmbInstructors
            // 
            cmbInstructors.Font = new Font("Segoe UI", 10F);
            cmbInstructors.Location = new Point(292, 67);
            cmbInstructors.Name = "cmbInstructors";
            cmbInstructors.Size = new Size(200, 31);
            cmbInstructors.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(30, 275);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 10;
            label1.Text = "Review:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(33, 333);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 11;
            label2.Text = "Rating:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(30, 310);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 12;
            // 
            // ClassDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(883, 502);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblClassName);
            Controls.Add(lblInstructor);
            Controls.Add(lblSchedule);
            Controls.Add(btnChangeInstructor);
            Controls.Add(dtpNewSchedule);
            Controls.Add(btnReschedule);
            Controls.Add(nudRating);
            Controls.Add(txtReview);
            Controls.Add(btnRateReview);
            Controls.Add(cmbInstructors);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClassDetailsForm";
            Text = "Class Details";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblClassName;
        private Label lblInstructor;
        private Label lblSchedule;
        private Button btnChangeInstructor;
        private DateTimePicker dtpNewSchedule;
        private Button btnReschedule;
        private NumericUpDown nudRating;
        private TextBox txtReview;
        private Button btnRateReview;
        private ComboBox cmbInstructors;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
