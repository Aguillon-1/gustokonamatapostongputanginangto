using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CustomFontItim();
            CustomFontInter();
            HideFirst();
        }

        bool sideMenuCollapse = true;
        bool classDropDown = true;
        string[] labels = { "Calendar", "Announcements", "Subjects", "Upload", "Log Out" };

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            sideMenuTimer.Start();
        }

        private void sideMenuTimer_Tick_1(object sender, EventArgs e)
        {
            if (sideMenuCollapse == true)
            {
                sideMenuBar.Width -= 30;
                ClearButtonLabels();
                if (sideMenuBar.Width <= sideMenuBar.MinimumSize.Width)
                {
                    sideMenuTimer.Stop();
                    sideMenuCollapse = false;
                    hiddenClassListPanel.Show();
                    hiddenClassListPanel.BringToFront();
                }
            }
            else
            {
                sideMenuBar.Width += 30;
                FixButtonLabels();
                hiddenClassListPanel.Hide();
                if (sideMenuBar.Width >= sideMenuBar.MaximumSize.Width)
                {
                    sideMenuTimer.Stop();
                    sideMenuCollapse = true;
                }
            }
        }

        private void BSCS2Bbutton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.FromArgb(139, 46, 171);
            notifButton.BackColor = Color.FromArgb(93, 49, 156);
            userButton.BackColor = Color.FromArgb(93, 49, 156);
            finalAnnouncement1.Hide();
            finalSubjects1.Hide();
            finalUpload1.Hide();
        }

        private void notifButton_Click(object sender, EventArgs e)
        {
            notifButton.BackColor = Color.FromArgb(139, 46, 171);
            userButton.BackColor = Color.FromArgb(93, 49, 156);
            homeButton.BackColor = Color.FromArgb(93, 49, 156);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            userButton.BackColor = Color.FromArgb(139, 46, 171);
            homeButton.BackColor = Color.FromArgb(93, 49, 156);
            notifButton.BackColor = Color.FromArgb(93, 49, 156);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitPopup exit = new ExitPopup();
            exit.Show();
        }

        private void homeButton_MouseHover(object sender, EventArgs e)
        {

        }

        private void CustomFontItim()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            int fontLength = Properties.Resources.Itim_Regular.Length;

            byte[] fontdata = Properties.Resources.Itim_Regular;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontdata, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);

            classListLabel.Font = new Font(pfc.Families[0], classListLabel.Font.Size);
            welcomeLabel.Font = new Font(pfc.Families[0], welcomeLabel.Font.Size);
            accessLabel.Font = new Font(pfc.Families[0], accessLabel.Font.Size);
            accessListLabel.Font = new Font(pfc.Families[0], accessListLabel.Font.Size);

            joinClassTitleLabel.Font = new Font(pfc.Families[0], joinClassTitleLabel.Font.Size);
            joinClassDescLabel.Font = new Font(pfc.Families[0], joinClassDescLabel.Font.Size);
            joinSubmitButton.Font = new Font(pfc.Families[0], joinSubmitButton.Font.Size);

            infoTitleLabel.Font = new Font(pfc.Families[0], infoTitleLabel.Font.Size);
            nameLabel.Font = new Font(pfc.Families[0], nameLabel.Font.Size);
            infoaccessLabel.Font = new Font(pfc.Families[0], infoaccessLabel.Font.Size);
            studentNoLabel.Font = new Font(pfc.Families[0], studentNoLabel.Font.Size);
            courseYrLabel.Font = new Font(pfc.Families[0], courseYrLabel.Font.Size);
            birthDateLabel.Font = new Font(pfc.Families[0], birthDateLabel.Font.Size);

            requestTitleLabel.Font = new Font(pfc.Families[0], requestTitleLabel.Font.Size);
            requestDescLabel.Font = new Font(pfc.Families[0], requestDescLabel.Font.Size);
            currentEmailLabel.Font = new Font(pfc.Families[0], currentEmailLabel.Font.Size);
            newEmailLabel.Font = new Font(pfc.Families[0], newEmailLabel.Font.Size);
            passwordLabel.Font = new Font(pfc.Families[0], passwordLabel.Font.Size);
            requestSubmitButton.Font = new Font(pfc.Families[0], requestSubmitButton.Font.Size);

            menubarAccessLabel.Font = new Font(pfc.Families[0], menubarAccessLabel.Font.Size);
            usernameLabel.Font = new Font(pfc.Families[0], usernameLabel.Font.Size);
            emailLabel.Font = new Font(pfc.Families[0], emailLabel.Font.Size);

            calendarButton.Font = new Font(pfc.Families[0], calendarButton.Font.Size);
            finalcalendarButton.Font = new Font(pfc.Families[0], calendarButton.Font.Size);
            announcementButton.Font = new Font(pfc.Families[0], announcementButton.Font.Size);
            subjectsButton.Font = new Font(pfc.Families[0], subjectsButton.Font.Size);
            uploadButton.Font = new Font(pfc.Families[0], uploadButton.Font.Size);
            logOutButton.Font = new Font(pfc.Families[0], logOutButton.Font.Size);
            sidemenuClassLabel.Font = new Font(pfc.Families[0], sidemenuClassLabel.Font.Size);
        }

        private void CustomFontInter()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            int fontLength = Properties.Resources.Inter_VariableFont_opsz_wght.Length;

            byte[] fontdata = Properties.Resources.Inter_VariableFont_opsz_wght;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontdata, 0, data, fontLength);

            pfc.AddMemoryFont(data, fontLength);

            selectClassButton.Font = new Font(pfc.Families[1], selectClassButton.Font.Size);
            BSCSButton.Font = new Font(pfc.Families[1], BSCSButton.Font.Size);
        }

        private void accessLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            announcementNavPanel.BackColor = Color.FromArgb(214, 113, 114);
            announcementNavPanel.Show();
            calendarNavPanel.Hide();
            subjectsNavPanel.Hide();
            uploadNavPanel.Hide();
            logOutNavPanel.Hide();
            selectClassNavPanel.Hide();

            // Update the announcements before showing
            FinalUpload finalUpload = Controls.OfType<FinalUpload>().FirstOrDefault();
            if (finalUpload != null)
            {
                finalAnnouncement1.SetAnnouncementMessages(finalUpload.Announcements);
            }

            finalAnnouncement1.BringToFront();
            finalAnnouncement1.Show();
        }

        private void calendarButton_Click_1(object sender, EventArgs e)
        {
            calendarNavPanel.BackColor = Color.FromArgb(214, 113, 114);
            announcementNavPanel.BackColor = Color.Transparent;
            subjectsNavPanel.BackColor = Color.Transparent;
            uploadNavPanel.BackColor = Color.Transparent;
            logOutNavPanel.BackColor = Color.Transparent;
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            subjectsNavPanel.BackColor = Color.FromArgb(214, 113, 114);
            subjectsNavPanel.Show();
            calendarNavPanel.Hide();
            announcementNavPanel.Hide();
            uploadNavPanel.Hide();
            logOutNavPanel.Hide();
            selectClassNavPanel.Hide();

            finalSubjects1.BringToFront();
            finalSubjects1.Show();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            uploadNavPanel.BackColor = Color.FromArgb(214, 113, 114);
            uploadNavPanel.Show();
            calendarNavPanel.Hide();
            announcementNavPanel.Hide();
            subjectsNavPanel.Hide();
            logOutNavPanel.Hide();
            selectClassNavPanel.Hide();

            finalUpload1.BringToFront();
            finalUpload1.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            logOutNavPanel.BackColor = Color.FromArgb(214, 113, 114);
            logOutNavPanel.Show();
            calendarNavPanel.Hide();
            announcementNavPanel.Hide();
            subjectsNavPanel.Hide();
            uploadNavPanel.Hide();
            selectClassNavPanel.Hide();

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FinalLoginForm loginForm = new FinalLoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void ClearButtonLabels()
        {
            calendarButton.Text = string.Empty;
            finalcalendarButton.Text = string.Empty;
            announcementButton.Text = string.Empty;
            subjectsButton.Text = string.Empty;
            uploadButton.Text = string.Empty;
            logOutButton.Text = string.Empty;
        }

        private void FixButtonLabels()
        {
            calendarButton.Text = labels[0];
            finalcalendarButton.Text = labels[0];
            announcementButton.Text = labels[1];
            subjectsButton.Text = labels[2];
            uploadButton.Text = labels[3];
            logOutButton.Text = labels[4];
        }

        private void finalcalendarButton_Click(object sender, EventArgs e)
        {
            calendarNavPanel.BackColor = Color.FromArgb(214, 113, 114);
            calendarNavPanel.Show();
            announcementNavPanel.Hide();
            subjectsNavPanel.Hide();
            uploadNavPanel.Hide();
            logOutNavPanel.Hide();
            selectClassNavPanel.Hide();
        }

        private void selectClassButton_Click(object sender, EventArgs e)
        {
            selectClassNavPanel.BackColor = Color.FromArgb(214, 113, 114);
            selectClassNavPanel.Show();
            calendarNavPanel.Hide();
            announcementNavPanel.Hide();
            subjectsNavPanel.Hide();
            uploadNavPanel.Hide();
            logOutNavPanel.Hide();
            selectClassTimer.Start();
        }

        private void selectClassTimer_Tick(object sender, EventArgs e)
        {
            if (classDropDown == true)
            {
                classesbuttonsPanel.Height += 30;
                if (classesbuttonsPanel.Height >= classesbuttonsPanel.MaximumSize.Height)
                {
                    selectClassTimer.Stop();
                    classDropDown = false;
                }
            }
            else
            {
                classesbuttonsPanel.Height -= 30;
                if (classesbuttonsPanel.Height <= classesbuttonsPanel.MinimumSize.Height)
                {
                    selectClassTimer.Stop();
                    classDropDown = true;
                }
            }
        }

        private void BSCSButton_Click(object sender, EventArgs e)
        {
            selectClassButton.Text = BSCSButton.Text;
            selectClassButton.Image = BSCSButton.Image;
            selectClassButton.ImageAlign = BSCSButton.ImageAlign;
            classDropDown = false;
            selectClassTimer.Start();
        }

        private void HideFirst()
        {
            hiddenClassListPanel.Hide();
            announcementNavPanel.Hide();
            calendarNavPanel.Hide();
            subjectsNavPanel.Hide();
            uploadNavPanel.Hide();
            logOutNavPanel.Hide();
            selectClassNavPanel.Hide();
            finalAnnouncement1.Hide();
            finalSubjects1.Hide();
            finalUpload1.Hide();
        }

        private void classesbuttonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateFinalAnnouncement(List<string> announcements)
        {
            finalAnnouncement1.SetAnnouncementMessages(announcements);
        }
    }
}