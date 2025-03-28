using System.Diagnostics;

namespace Classroom_Management_System
{
    public partial class LoginHome : Form
    {
        public LoginHome()
        {
            InitializeComponent();
            LoginPanel.BackColor = Color.FromArgb(50, Color.Black);
            this.Load += LoginHome_Load;
        }

        private void LoginHome_Load(object sender, EventArgs e)
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

        private void HoverAboutUsButton(object sender, EventArgs e)
        {
            AboutUsButton.BackColor = Color.FromArgb(44, 56, 75);
        }

        private void LeaveHoverAboutUsButton(object sender, EventArgs e)
        {
            AboutUsButton.BackColor = Color.Transparent;
        }

        private void HoverContactUsButton(object sender, EventArgs e)
        {
            ContactUsButton.BackColor = Color.FromArgb(44, 56, 75);
        }

        private void LeaveHoverContactUsButton(object sender, EventArgs e)
        {
            ContactUsButton.BackColor = Color.Transparent;
        }

        private void HoverHomeButton(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(44, 56, 75);
        }

        private void LeaveHoverHomeButton(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(30, 38, 51);
        }

        private void HoverLogInButton(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.FromArgb(44, 56, 75);
        }

        private void LeaveHoverLogInButton(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.FromArgb(30, 38, 51);
        }

        private void HoverSignUpButton(object sender, EventArgs e)
        {
            SignUpButton.BackColor = Color.FromArgb(44, 56, 75);
        }

        private void LeaveHoverSignUpButton(object sender, EventArgs e)
        {
            SignUpButton.BackColor = Color.FromArgb(30, 38, 51);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            CredentialsForm cred = new CredentialsForm();
            cred.Show();
            this.Hide();
            
            //HomeForm home = new HomeForm();
            //home.Show();
            //DatabaseConn.GetConnection();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void SignUpButton_Click_1(object sender, EventArgs e)
        {
            GAuthclass gauthclass = new GAuthclass();
            await gauthclass.callGAuthAsync();

        }

        private void continueLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
