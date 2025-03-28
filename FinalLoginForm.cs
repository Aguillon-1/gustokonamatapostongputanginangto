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
    public partial class FinalLoginForm : Form
    {
        public FinalLoginForm()
        {
            InitializeComponent();
            studentPanel.BringToFront();
            this.Load += FinalLoginForm_Load;
        }

        private void finalCustomButton1_Click(object sender, EventArgs e)
        {
            studentPanel.BringToFront();
            studentPanel.Show();

            studentButton.BackColor = Color.FromArgb(198, 68, 70);
            studentButton.ForeColor = Color.White;

            classOfficerButton.BackColor = Color.FromArgb(223, 215, 223);
            classOfficerButton.ForeColor = Color.Black;
            profButton.BackColor = Color.FromArgb(223, 215, 223);
            profButton.ForeColor = Color.Black;
            adminButton.BackColor = Color.FromArgb(223, 215, 223);
            adminButton.ForeColor = Color.Black;
        }

        private void classOfficerButton_Click(object sender, EventArgs e)
        {
            classOfficerPanel.BringToFront();
            classOfficerPanel.Show();
            classOfficerButton.BackColor = Color.FromArgb(198, 68, 70);
            classOfficerButton.ForeColor = Color.White;

            studentButton.BackColor = Color.FromArgb(223, 215, 223);
            studentButton.ForeColor = Color.Black;
            profButton.BackColor = Color.FromArgb(223, 215, 223);
            profButton.ForeColor = Color.Black;
            adminButton.BackColor = Color.FromArgb(223, 215, 223);
            adminButton.ForeColor = Color.Black;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitPopup exit = new ExitPopup();
            exit.Show();
        }

        private void finalCustomButton3_Click(object sender, EventArgs e)
        {
            profButton.BackColor = Color.FromArgb(198, 68, 70);
            profButton.ForeColor = Color.White;

            studentButton.BackColor = Color.FromArgb(223, 215, 223);
            studentButton.ForeColor = Color.Black;
            classOfficerButton.BackColor = Color.FromArgb(223, 215, 223);
            classOfficerButton.ForeColor = Color.Black;
            adminButton.BackColor = Color.FromArgb(223, 215, 223);
            adminButton.ForeColor = Color.Black;
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            adminButton.BackColor = Color.FromArgb(198, 68, 70);
            adminButton.ForeColor = Color.White;

            studentButton.BackColor = Color.FromArgb(223, 215, 223);
            studentButton.ForeColor = Color.Black;
            classOfficerButton.BackColor = Color.FromArgb(223, 215, 223);
            classOfficerButton.ForeColor = Color.Black;
            profButton.BackColor = Color.FromArgb(223, 215, 223);
            profButton.ForeColor = Color.Black;
        }

        private void finalCustomButton1_Click_1(object sender, EventArgs e)
        {
            CredentialsForm cred = new CredentialsForm();
            cred.Show();
            this.Hide();
        }

        private void FinalLoginForm_Load(object sender, EventArgs e)
        {
            if (SessionManager.ValidateAndRefreshSession())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private async void googleButton_Click(object sender, EventArgs e)
        {
            GAuthclass gauthclass = new GAuthclass();
            await gauthclass.callGAuthAsync();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Assuming credential validation is done here
            bool isValid = ValidateCredentials();
            if (isValid)
            {
                Form2 homeForm = new Form2();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }

        private bool ValidateCredentials()
        {
            // Add your credential validation logic here
            return true;
        }
    }
}