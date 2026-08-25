using System;
using System.Windows.Forms;

namespace Ignacio_LabAct3
{
    public partial class Form1 : Form
    {
        // One shared queue counter for all patient types
        private int queueCounter = 1;

        public Form1()
        {
            InitializeComponent();

            // Initially clear the results
            lblQueueNumber.Text = "Queue Number: ";
            lblPatientType.Text = "Patient Type: ";
            lblPriority.Text = "Priority: ";
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtPatientName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtReason.Text) ||
                cmbPatientType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please complete all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate age
            if (!int.TryParse(txtAge.Text, out int age) || age < 0)
            {
                MessageBox.Show(
                    "Please enter a valid age.",
                    "Invalid Age",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAge.Focus();
                return;
            }

            string patientType = cmbPatientType.SelectedItem.ToString();
            string priority;

            // Determine priority
            if (patientType == "Emergency")
            {
                priority = "EMERGENCY";
            }
            else if (patientType == "Senior")
            {
                priority = "SENIOR PRIORITY";
            }
            else if (patientType == "Pregnant")
            {
                priority = "PRIORITY";
            }
            else
            {
                priority = "REGULAR";
            }

            // Generate shared queue number
            string queueNumber = "Q" + queueCounter.ToString("D3");

            // Display results
            lblQueueNumber.Text = "Queue Number: " + queueNumber;
            lblPatientType.Text = "Patient Type: " + patientType;
            lblPriority.Text = "Priority: " + priority;

            // Increase queue counter
            queueCounter++;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear input fields
            txtPatientName.Clear();
            txtAge.Clear();
            txtReason.Clear();
            cmbPatientType.SelectedIndex = -1;

            // Clear output
            lblQueueNumber.Text = "Queue Number: ";
            lblPatientType.Text = "Patient Type: ";
            lblPriority.Text = "Priority: ";

            txtPatientName.Focus();
        }
    }
}
