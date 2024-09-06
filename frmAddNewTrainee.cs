using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace gymsystemProject
{
    public partial class frmAddNewTrainee : Form
    {
        // Path to the file where trainee information is stored
        public string filePath = Path.Combine(Application.StartupPath, "info.txt");

        public frmAddNewTrainee()
        {
            InitializeComponent();
        }

        // Set the end date based on the selected plan
        void SetEndDate()
        {
            switch (cbPlan.SelectedIndex)
            {
                case 0: // 1-month plan
                    tbEndAt.Text = DateTime.Now.AddMonths(1).ToString("MM/dd/yyyy");
                    break;
                case 1: // 3-month plan
                    tbEndAt.Text = DateTime.Now.AddMonths(3).ToString("MM/dd/yyyy");
                    break;
                case 2: // 6-month plan
                    tbEndAt.Text = DateTime.Now.AddMonths(6).ToString("MM/dd/yyyy");
                    break;
                case 3: // 9-month plan
                    tbEndAt.Text = DateTime.Now.AddMonths(9).ToString("MM/dd/yyyy");
                    break;
            }
        }

        // Reset all form fields to their default state
        void ResetAll()
        {
            tbFirstName.Text = string.Empty;
            tbMidName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbAge.Text = string.Empty;
            cbPlan.Text = string.Empty;
            cbTime.Text = string.Empty;
            tbEndAt.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        // Display a notification when a trainee is added
        private void ShowNotification(NotifyIcon notification)
        {
            notification.Icon = SystemIcons.Application;
            notification.BalloonTipIcon = ToolTipIcon.Warning;
            notification.BalloonTipTitle = "Added";
            notification.BalloonTipText = "The Trainer is Added.";
            notification.ShowBalloonTip(1000);
        }

        // Display an error notification
        private void ShowErrorNotification()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "Error";
            notifyIcon1.BalloonTipText = "Please enter full data.";
            notifyIcon1.ShowBalloonTip(1000);
        }

        // Record the trainee information into a formatted string
        private string RecordInfo()
        {
            string record = string.Empty;

            frmListTrainenees Frm=new frmListTrainenees();
            int ClientsNumber = Frm.GetNumberOfTrainee();
  
             record += (++ClientsNumber).ToString() + ",";
            // Concatenate trainee's full name
            record += $"{tbFirstName.Text},{tbMidName.Text},{tbLastName.Text},";

            // Add phone number, age, and gender
            record += $"{tbPhoneNumber.Text},{tbAge.Text},";
            record += rbMale.Checked ? "M," : "F,";

            // Add subscription plan, time, start, and end dates
            record += $"{cbPlan.Text},{cbTime.Text},";
            record += $"{tbStartFrom.Text},{tbEndAt.Text},";

            return record;
        }

        // Save trainee data to the file system
        bool SaveDataToFileSystem(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
                return false;

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(record);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        // Validate a text box
        private void ValidateTextBox(Guna2TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Should have a value");
                textBox.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        // Validate a combo box
        private void ValidateComboBox(ComboBox comboBox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBox, "Should have a value");
                comboBox.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox, "");
            }
        }

        // Event handlers for validating input fields
        private void tbFirstName_Validating(object sender, CancelEventArgs e) => ValidateTextBox(tbFirstName, e);
        private void tbMidName_Validating(object sender, CancelEventArgs e) => ValidateTextBox(tbMidName, e);
        private void tbLastName_Validating(object sender, CancelEventArgs e) => ValidateTextBox(tbLastName, e);
        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e) => ValidateTextBox(tbPhoneNumber, e);
        private void cbPlan_Validating(object sender, CancelEventArgs e) => ValidateComboBox(cbPlan, e);

        // Event handler for the submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save data to file?", "Confirm",
                                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (SaveDataToFileSystem(RecordInfo()))
                {
                    ResetAll();
                    ShowNotification(notifyIcon1);
                }
                else
                {
                    ShowErrorNotification();
                }
            }
        }

        // Event handler to reset the form
        private void btnReset_Click(object sender, EventArgs e) => ResetAll();

        // Event handler for form load
        private void frmAddNewTrainee_Load(object sender, EventArgs e)
        {
            tbStartFrom.Text = DateTime.Now.ToString("MM/dd/yyyy");
            SetEndDate();
        }

        // Update end date when plan is changed
        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e) => SetEndDate();

        // Display a message on double-clicking the notification icon
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello, this is confirming the addition.");
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }
    }
}
