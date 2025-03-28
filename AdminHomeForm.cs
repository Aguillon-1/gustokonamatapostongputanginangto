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
    public partial class AdminHomeForm : Form
    {

        private bool menuBarFolding = true;
        public AdminHomeForm()
        {
            InitializeComponent();
            homeButton.BackColor = Color.FromArgb(50, 210, 210, 210);
        }

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

            if (userButton.BackColor == Color.FromArgb(44, 56, 75) || (notifButton.BackColor == Color.FromArgb(44, 56, 75) ||
                (logOutButton.BackColor == Color.FromArgb(44, 56, 75))))
            {
                userButton.BackColor = Color.Transparent;
                notifButton.BackColor = Color.Transparent;
                logOutButton.BackColor = Color.Transparent;
            }

        }

       

        private void MenuButton_Click(object sender, EventArgs e)
        {
            foldMenuBarTimer.Start();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AdmitCreateForm createForm = new AdmitCreateForm();
            createForm.Show();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
