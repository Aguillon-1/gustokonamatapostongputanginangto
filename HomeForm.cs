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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            homeButton.BackColor = Color.FromArgb(50, 210, 210, 210);
        }
        bool dropDownExpand = false;


        private void HoverHomeButton(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.FromArgb(44, 56, 75);
        }
        private void HoverNotifButton(object sender, EventArgs e)
        {
            notifButton.BackColor = Color.FromArgb(44, 56, 75);
        }
        private void HoverUserButton(object sender, EventArgs e)
        {
            userButton.BackColor = Color.FromArgb(44, 56, 75);
        }
        private void HoverLogOutButton(object sender, EventArgs e)
        {
            logOutButton.BackColor = Color.FromArgb(44, 56, 75);
        }
        private void LeaveHoverButton(object sender, EventArgs e)
        {
            if (homeButton.BackColor == Color.FromArgb(44, 56, 75))
            {
                homeButton.BackColor = Color.FromArgb(50, 210, 210, 210);
            }

            if (notifButton.BackColor == Color.FromArgb(44, 56, 75) || (userButton.BackColor == Color.FromArgb(44, 56, 75) ||
                (logOutButton.BackColor == Color.FromArgb(44, 56, 75))))
            {
                notifButton.BackColor = Color.Transparent;
                userButton.BackColor = Color.Transparent;
                logOutButton.BackColor = Color.Transparent;
            }

            if (submitButton.BackColor == Color.FromArgb(44, 56, 75) || (requestButton.BackColor == Color.FromArgb(44, 56, 75)))
            {
                submitButton.BackColor = Color.FromArgb(30, 38, 51);
                requestButton.BackColor = Color.FromArgb(30, 38, 51);
            }
        }

        private void HoverSubmitButton(object sender, EventArgs e)
        {
            submitButton.BackColor = Color.FromArgb(44, 56, 75);

        }

        private void HoverRequestButton(object sender, EventArgs e)
        {
            requestButton.BackColor = Color.FromArgb(44, 56, 75);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dropDownExpand == false)
            {
                approvalDropDownPanel.Height += 30;
                if (approvalDropDownPanel.Height >= approvalDropDownPanel.MaximumSize.Height)
                {
                    approvalDropDownTimer.Stop();
                    dropDownExpand = true;
                }
            }
            else
            {
                approvalDropDownPanel.Height -= 30;
                if (approvalDropDownPanel.Height <= approvalDropDownPanel.MinimumSize.Height)
                {
                    approvalDropDownTimer.Stop();
                    dropDownExpand = false;
                }
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            approvalDropDownTimer.Start();
        }

        private void changeEmailOption_Click(object sender, EventArgs e)
        {
            selectButton.Text = changeEmailOption.Text;
        }

        private void changeProfileButton_Click(object sender, EventArgs e)
        {
            selectButton.Text = changeProfileButton.Text;
        }

        private void approvePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm trial = new MainForm();
            trial.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            ExitPopup exitform = new ExitPopup();
            exitform.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
