using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class CredentialsForm : Form
    {
        public CredentialsForm()
        {
            InitializeComponent();
            personalInfoPanel1.BringToFront();
            backButton.Hide();
        }

        private int verifno = 1;

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (verifno == 1 && !VerifyPersonalInformation())
            {
                return;
            }

            verifno++;
            backButton.Show();

            if (verifno == 2)
            {
                personalInfoPanel1.Hide();
                credentials1.BringToFront();
                CredentialTwo();
            }

            else if (verifno == 3)
            {
                credentials1.Hide();
                verificationCredentials1.BringToFront();
                nextButton.Text = "Submit";
                CredentialThree();
            }

            else if (verifno == 4)
            {
                ExtraInformation extraInformation1 = new ExtraInformation();
                extraInformation1.SubmitInformation();
            }

            else if (verifno == 5)
            {
                Form2 form2 = new Form2(); // Create an instance of Form2
                form2.Show();              // Show Form2
                this.Hide();               // Hide the current form (CredentialsForm)
            }
        }

        private bool VerifyPersonalInformation()
        {
            // Example verification for personal information fields
            if (string.IsNullOrWhiteSpace(personalInfoPanel1.FirstNameTextBox.Text))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.FirstNameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(personalInfoPanel1.MiddleNameTextBox.Text))
            {
                MessageBox.Show("Middle name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.MiddleNameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(personalInfoPanel1.LastNameTextBox.Text))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.LastNameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(personalInfoPanel1.EmailAddressTextBox.Text) || !IsValidEmail(personalInfoPanel1.EmailAddressTextBox.Text))
            {
                MessageBox.Show("A valid email address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.EmailAddressTextBox.Focus();
                return false;
            }

            if (personalInfoPanel1.BirthdayInput.Value == null || personalInfoPanel1.BirthdayInput.Value > DateTime.Now)
            {
                MessageBox.Show("A valid birthday is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.BirthdayInput.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(personalInfoPanel1.AddressNoTextBox.Text))
            {
                MessageBox.Show("Address number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.AddressNoTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(personalInfoPanel1.StreetNameTextBox.Text))
            {
                MessageBox.Show("Street name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.StreetNameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(personalInfoPanel1.BarangayTextBox.Text))
            {
                MessageBox.Show("Barangay is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.BarangayTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(personalInfoPanel1.CityTextBox.Text))
            {
                MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personalInfoPanel1.CityTextBox.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CredentialOne()
        {
            personalInformationLabel.ForeColor = Color.Black;
            no1Label.ForeColor = Color.DarkSlateGray;
            roleConfirmationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            no2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void CredentialTwo()
        {
            personalInformationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            no1Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            roleConfirmationLabel.ForeColor = Color.Black;
            no2Label.ForeColor = Color.DarkSlateGray;
        }

        private void CredentialThree()
        {
            roleConfirmationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            no2Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            verificationLabel.ForeColor = Color.Black;
            no3Label.ForeColor = Color.DarkSlateGray;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            verifno--;

            if (verifno == 3)
            {
                verificationCredentials1.BringToFront();
            }
            if (verifno == 2)
            {
                credentials1.BringToFront();
                CredentialTwo();
                verificationCredentials1.Hide();
            }

            if (verifno == 1)
            {
                backButton.Hide();
                personalInfoPanel1.BringToFront();
                CredentialOne();
                credentials1.Hide();
            }
        }

        private void CredentialsForm_Load(object sender, EventArgs e)
        {
        }
    }
}