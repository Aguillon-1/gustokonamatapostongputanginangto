namespace Classroom_Management_System
{
    partial class LoginHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginHome));
            elementOne = new Panel();
            HomeButton = new ClassroomManagementSystem.Custom.CustomButton();
            AboutUsButton = new ClassroomManagementSystem.Custom.CustomButton();
            ContactUsButton = new ClassroomManagementSystem.Custom.CustomButton();
            CirclePanel = new Panel();
            systemlogoPicture = new PictureBox();
            descriptionLabel = new Label();
            titleLabel = new Label();
            LoginPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            SignUpButton = new ClassroomManagementSystem.Custom.CustomButton();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            LogInButton = new ClassroomManagementSystem.Custom.CustomButton();
            continueLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            LoginLabel = new Label();
            userIcon = new PictureBox();
            CirclePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)systemlogoPicture).BeginInit();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // elementOne
            // 
            elementOne.BackgroundImage = Properties.Resources.element1;
            elementOne.BackgroundImageLayout = ImageLayout.Zoom;
            elementOne.Location = new Point(64, 439);
            elementOne.Margin = new Padding(2, 2, 2, 2);
            elementOne.MaximumSize = new Size(600, 540);
            elementOne.Name = "elementOne";
            elementOne.Size = new Size(600, 373);
            elementOne.TabIndex = 0;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.FromArgb(30, 38, 51);
            HomeButton.FlatAppearance.BorderColor = Color.White;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.White;
            HomeButton.Location = new Point(29, 14);
            HomeButton.Margin = new Padding(2, 2, 2, 2);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(127, 50);
            HomeButton.TabIndex = 1;
            HomeButton.Text = "Home\r\n";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.MouseLeave += LeaveHoverHomeButton;
            HomeButton.MouseHover += HoverHomeButton;
            // 
            // AboutUsButton
            // 
            AboutUsButton.BackColor = Color.Transparent;
            AboutUsButton.FlatAppearance.BorderColor = Color.White;
            AboutUsButton.FlatAppearance.BorderSize = 0;
            AboutUsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            AboutUsButton.FlatStyle = FlatStyle.Flat;
            AboutUsButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutUsButton.ForeColor = Color.White;
            AboutUsButton.Location = new Point(240, 14);
            AboutUsButton.Margin = new Padding(2, 2, 2, 2);
            AboutUsButton.Name = "AboutUsButton";
            AboutUsButton.Size = new Size(127, 50);
            AboutUsButton.TabIndex = 2;
            AboutUsButton.Text = "About Us";
            AboutUsButton.UseVisualStyleBackColor = false;
            AboutUsButton.MouseLeave += LeaveHoverAboutUsButton;
            AboutUsButton.MouseHover += HoverAboutUsButton;
            // 
            // ContactUsButton
            // 
            ContactUsButton.BackColor = Color.Transparent;
            ContactUsButton.FlatAppearance.BorderColor = Color.White;
            ContactUsButton.FlatAppearance.BorderSize = 0;
            ContactUsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ContactUsButton.FlatStyle = FlatStyle.Flat;
            ContactUsButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactUsButton.ForeColor = Color.White;
            ContactUsButton.Location = new Point(434, 14);
            ContactUsButton.Margin = new Padding(2, 2, 2, 2);
            ContactUsButton.Name = "ContactUsButton";
            ContactUsButton.Size = new Size(144, 50);
            ContactUsButton.TabIndex = 3;
            ContactUsButton.Text = "Contact Us";
            ContactUsButton.UseVisualStyleBackColor = false;
            ContactUsButton.MouseLeave += LeaveHoverContactUsButton;
            ContactUsButton.MouseHover += HoverContactUsButton;
            // 
            // CirclePanel
            // 
            CirclePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CirclePanel.AutoSize = true;
            CirclePanel.BackColor = Color.Transparent;
            CirclePanel.BackgroundImage = Properties.Resources.ellipse;
            CirclePanel.BackgroundImageLayout = ImageLayout.Stretch;
            CirclePanel.Controls.Add(systemlogoPicture);
            CirclePanel.Controls.Add(descriptionLabel);
            CirclePanel.Controls.Add(titleLabel);
            CirclePanel.Controls.Add(ContactUsButton);
            CirclePanel.Controls.Add(AboutUsButton);
            CirclePanel.Controls.Add(HomeButton);
            CirclePanel.Controls.Add(elementOne);
            CirclePanel.Location = new Point(-5, 2);
            CirclePanel.Margin = new Padding(2, 2, 2, 2);
            CirclePanel.Name = "CirclePanel";
            CirclePanel.Size = new Size(897, 814);
            CirclePanel.TabIndex = 0;
            CirclePanel.Paint += panel1_Paint;
            // 
            // systemlogoPicture
            // 
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(52, 312);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(764, 125);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = SystemColors.ActiveCaptionText;
            titleLabel.Location = new Point(240, 140);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(546, 104);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "CLASSROOM \r\nMANAGEMENT SYSTEM";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LoginPanel.BackColor = Color.Transparent;
            LoginPanel.BackgroundImageLayout = ImageLayout.None;
            LoginPanel.Controls.Add(SignUpButton);
            LoginPanel.Controls.Add(usernameTextBox);
            LoginPanel.Controls.Add(passwordTextBox);
            LoginPanel.Controls.Add(LogInButton);
            LoginPanel.Controls.Add(continueLabel);
            LoginPanel.Controls.Add(passwordLabel);
            LoginPanel.Controls.Add(usernameLabel);
            LoginPanel.Controls.Add(LoginLabel);
            LoginPanel.Controls.Add(userIcon);
            LoginPanel.Location = new Point(955, 116);
            LoginPanel.Margin = new Padding(2, 2, 2, 2);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(497, 593);
            LoginPanel.TabIndex = 1;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.White;
            SignUpButton.FlatAppearance.BorderColor = Color.White;
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatAppearance.MouseOverBackColor = Color.White;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = Color.Black;
            SignUpButton.Image = (Image)resources.GetObject("SignUpButton.Image");
            SignUpButton.ImageAlign = ContentAlignment.MiddleRight;
            SignUpButton.Location = new Point(138, 473);
            SignUpButton.Margin = new Padding(4, 4, 4, 4);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Padding = new Padding(4, 4, 4, 4);
            SignUpButton.Size = new Size(276, 91);
            SignUpButton.TabIndex = 10;
            SignUpButton.Text = "  CONTINUE WITH\r\nGOOGLE";
            SignUpButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click_1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(224, 174);
            usernameTextBox.Margin = new Padding(2, 2, 2, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(190, 27);
            usernameTextBox.TabIndex = 9;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(224, 253);
            passwordTextBox.Margin = new Padding(2, 2, 2, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(190, 27);
            passwordTextBox.TabIndex = 8;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(30, 38, 51);
            LogInButton.FlatAppearance.BorderColor = Color.White;
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Microsoft Sans Serif", 13.8749981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(196, 329);
            LogInButton.Margin = new Padding(2, 2, 2, 2);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(152, 54);
            LogInButton.TabIndex = 6;
            LogInButton.Text = "LOGIN\r\n";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            LogInButton.MouseLeave += LeaveHoverLogInButton;
            LogInButton.MouseHover += HoverLogInButton;
            // 
            // continueLabel
            // 
            continueLabel.AutoSize = true;
            continueLabel.BackColor = Color.Transparent;
            continueLabel.Font = new Font("Microsoft Sans Serif", 13.8749981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            continueLabel.ForeColor = SystemColors.ButtonHighlight;
            continueLabel.Location = new Point(255, 411);
            continueLabel.Margin = new Padding(2, 0, 2, 0);
            continueLabel.Name = "continueLabel";
            continueLabel.Size = new Size(49, 29);
            continueLabel.TabIndex = 5;
            continueLabel.Text = "OR";
            continueLabel.Click += continueLabel_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 13.8749981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = SystemColors.ButtonHighlight;
            passwordLabel.Location = new Point(97, 253);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(126, 29);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 13.8749981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ButtonHighlight;
            usernameLabel.Location = new Point(92, 174);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(130, 29);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Microsoft Sans Serif", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = SystemColors.ButtonHighlight;
            LoginLabel.Location = new Point(196, 49);
            LoginLabel.Margin = new Padding(2, 0, 2, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(237, 62);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "LOGIN TO YOUR \r\nACCOUNT\r\n";
            LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.BackgroundImageLayout = ImageLayout.None;
            userIcon.Image = Properties.Resources.Mask_group;
            userIcon.Location = new Point(97, 22);
            userIcon.Margin = new Padding(2, 2, 2, 2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(89, 111);
            userIcon.TabIndex = 0;
            userIcon.TabStop = false;
            // 
            // LoginHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1518, 817);
            Controls.Add(LoginPanel);
            Controls.Add(CirclePanel);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSM";
            Load += Form1_Load;
            CirclePanel.ResumeLayout(false);
            CirclePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)systemlogoPicture).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel elementOne;
        private ClassroomManagementSystem.Custom.CustomButton HomeButton;
        private ClassroomManagementSystem.Custom.CustomButton AboutUsButton;
        private ClassroomManagementSystem.Custom.CustomButton ContactUsButton;
        private Panel CirclePanel;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel LoginPanel;
        private Label LoginLabel;
        private PictureBox userIcon;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label continueLabel;
        private ClassroomManagementSystem.Custom.CustomButton LogInButton;
        private TextBox passwordTextBox;
        private Label titleLabel;
        private Label descriptionLabel;
        private TextBox usernameTextBox;
        private PictureBox systemlogoPicture;
        private ClassroomManagementSystem.Custom.CustomButton SignUpButton;
    }
}
