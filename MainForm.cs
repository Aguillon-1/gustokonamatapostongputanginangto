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
    public partial class MainForm : Form
    {

        private List<Notification> notifications;
        private int unseenCount;
        private NotifyIcon notifyIcon;

        public MainForm()
        {
            InitializeComponent();
            classButton.BackColor = Color.FromArgb(50, 210, 210, 210);
            classHeadPanel.Hide();
            notifications = new List<Notification>();
            unseenCount = 0;
            listBox2.Hide();
            InitializeNotifyIcon();
            section.BringToFront();

        }


        bool notiflist = false;
        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };


        }


        bool shortenMenuBar = true;

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
        private void HoverCalendarButton(object sender, EventArgs e)
        {
            calendarButton.BackColor = Color.FromArgb(44, 56, 75);
        }
        private void HoverAnnouncementButton(object sender, EventArgs e)
        {
            announcementButton.BackColor = Color.FromArgb(44, 56, 75);
        }
        private void HoverSubjectsButton(object sender, EventArgs e)
        {
            subjectsButton.BackColor = Color.FromArgb(44, 56, 75);
        }
        private void HoverHelpButton(object sender, EventArgs e)
        {
            helpButton.BackColor = Color.FromArgb(44, 56, 75);
        }

        private void LeaveHoverButton(object sender, EventArgs e)
        {

            if (notifButton.BackColor == Color.FromArgb(44, 56, 75) || (userButton.BackColor == Color.FromArgb(44, 56, 75) ||
                (logOutButton.BackColor == Color.FromArgb(44, 56, 75) || (homeButton.BackColor == Color.FromArgb(44, 56, 75)))))
            {
                notifButton.BackColor = Color.Transparent;
                userButton.BackColor = Color.Transparent;
                logOutButton.BackColor = Color.Transparent;
                homeButton.BackColor = Color.Transparent;
            }

            if (calendarButton.BackColor == Color.FromArgb(44, 56, 75) || (announcementButton.BackColor == Color.FromArgb(44, 56, 75) ||
                (subjectsButton.BackColor == Color.FromArgb(44, 56, 75) || (helpButton.BackColor == Color.FromArgb(44, 56, 75)))))
            {
                calendarButton.BackColor = Color.FromArgb(30, 38, 51);
                announcementButton.BackColor = Color.FromArgb(30, 38, 51);
                subjectsButton.BackColor = Color.FromArgb(30, 38, 51);
                helpButton.BackColor = Color.FromArgb(30, 38, 51);
            }
        }

        private void MenuBarTimer_Tick(object sender, EventArgs e)
        {
            if (shortenMenuBar == false)
            {
                sideMenuBar.Width += 30;
                if (sideMenuBar.Width >= sideMenuBar.MaximumSize.Width)
                {
                    ButtonText();
                    MenuBarTimer.Stop();
                    shortenMenuBar = true;
                }
            }
            else
            {

                ClearButtonText();
                sideMenuBar.Width -= 30;
                if (sideMenuBar.Width <= sideMenuBar.MinimumSize.Width)
                {
                    MenuBarTimer.Stop();
                    shortenMenuBar = false;
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuBarTimer.Start();
        }

        private void ButtonText()
        {
            calendarButton.Text = "Calendar";
            announcementButton.Text = "Announcement";
            subjectsButton.Text = "Subjects";
            helpButton.Text = "Help";
        }
        private void ClearButtonText()
        {
            calendarButton.Text = string.Empty;
            announcementButton.Text = string.Empty;
            subjectsButton.Text = string.Empty;
            helpButton.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)


        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void notifButton_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            foreach (var notification in notifications)
            {
                listBox2.Items.Add(notification);
            }

            unseenCount = 0;
            notifButton.Text = string.Empty;


            if (notiflist == false)
            {
                listBox2.BringToFront();
                listBox2.Show();
                notiflist = true;

            }

            else
            {
                listBox2.Hide();
                notiflist = false;

            }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            string message = "New notification at " + DateTime.Now.ToString("HH:mm:ss");
            notifications.Add(new Notification { Title = "New Notification", Message = message });
            unseenCount++;

            notifyIcon.BalloonTipTitle = "New Notification";
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(3000);

            notifButton.Text = $"({unseenCount})";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class Notification
        {
            public string Title { get; set; }
            public string Message { get; set; }

            public override string ToString()
            {
                return Title;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "New notification at " + DateTime.Now.ToString("t");
            notifications.Add(new Notification { Title = "New Notification", Message = message });
            unseenCount++;
            notifButton.Text = $"{unseenCount}";

            notifyIcon.BalloonTipTitle = "New Notification";
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(3000);

            


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void announcementButton_Click(object sender, EventArgs e)
        {
            announcementButton.BackColor = Color.FromArgb(44, 56, 75);
            announcement.BringToFront();
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            subjectsButton.BackColor = Color.FromArgb(44, 56, 75);
            subjects.BringToFront();
        }
    }
}
