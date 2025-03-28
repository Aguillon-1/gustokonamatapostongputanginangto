namespace Classroom_Management_System
{
    partial class FinalLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalLoginForm));
            panel1 = new Panel();
            exitButton = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            adminButton = new Custom.FinalCustomButton();
            profButton = new Custom.FinalCustomButton();
            classOfficerButton = new Custom.FinalCustomButton();
            studentButton = new Custom.FinalCustomButton();
            panel3 = new Panel();
            label4 = new Label();
            googleButton = new Custom.FinalCustomButton();
            loginButton = new Custom.FinalCustomButton();
            passwordTxtBox = new TextBox();
            usernameTxtBox = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            studentPanel = new Panel();
            studentAccessLists = new Label();
            studentAccessRolesLabel = new Label();
            studentPictureBox = new PictureBox();
            classOfficerPanel = new Panel();
            classOfficerAccessList = new Label();
            classOfficerAccessRolesLabel = new Label();
            classOfficerPictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            studentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).BeginInit();
            classOfficerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classOfficerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 60, 76);
            panel1.Controls.Add(exitButton);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 72);
            panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(198, 68, 70);
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(1457, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(78, 72);
            exitButton.TabIndex = 10;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(adminButton);
            panel2.Controls.Add(profButton);
            panel2.Controls.Add(classOfficerButton);
            panel2.Controls.Add(studentButton);
            panel2.Location = new Point(42, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 412);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(300, 170);
            label2.Name = "label2";
            label2.Size = new Size(485, 84);
            label2.TabIndex = 6;
            label2.Text = "       A helping hand in managing a class for reminders, \r\nannouncements, events, and easier sharing of lesson \r\nnotes for the whole class to review.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(303, 46);
            label1.Name = "label1";
            label1.Size = new Size(458, 92);
            label1.TabIndex = 5;
            label1.Text = "CLASSROOM MANAGEMENT\r\nSYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logowithshadowicon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 254);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.FromArgb(223, 215, 223);
            adminButton.BackgroundColor = Color.FromArgb(223, 215, 223);
            adminButton.BorderColor = Color.FromArgb(198, 68, 70);
            adminButton.BorderRadius = 20;
            adminButton.BorderSize = 0;
            adminButton.FlatAppearance.BorderSize = 0;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.ForeColor = Color.Black;
            adminButton.Location = new Point(601, 328);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(144, 41);
            adminButton.TabIndex = 3;
            adminButton.Text = "Admin";
            adminButton.TextColor = Color.Black;
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            // 
            // profButton
            // 
            profButton.BackColor = Color.FromArgb(223, 215, 223);
            profButton.BackgroundColor = Color.FromArgb(223, 215, 223);
            profButton.BorderColor = Color.FromArgb(198, 68, 70);
            profButton.BorderRadius = 20;
            profButton.BorderSize = 0;
            profButton.FlatAppearance.BorderSize = 0;
            profButton.FlatStyle = FlatStyle.Flat;
            profButton.ForeColor = Color.Black;
            profButton.Location = new Point(410, 327);
            profButton.Name = "profButton";
            profButton.Size = new Size(144, 41);
            profButton.TabIndex = 2;
            profButton.Text = "Professor";
            profButton.TextColor = Color.Black;
            profButton.UseVisualStyleBackColor = false;
            profButton.Click += finalCustomButton3_Click;
            // 
            // classOfficerButton
            // 
            classOfficerButton.BackColor = Color.FromArgb(223, 215, 223);
            classOfficerButton.BackgroundColor = Color.FromArgb(223, 215, 223);
            classOfficerButton.BorderColor = Color.FromArgb(198, 68, 70);
            classOfficerButton.BorderRadius = 20;
            classOfficerButton.BorderSize = 0;
            classOfficerButton.FlatAppearance.BorderSize = 0;
            classOfficerButton.FlatStyle = FlatStyle.Flat;
            classOfficerButton.ForeColor = Color.Black;
            classOfficerButton.Location = new Point(217, 327);
            classOfficerButton.Name = "classOfficerButton";
            classOfficerButton.Size = new Size(144, 41);
            classOfficerButton.TabIndex = 1;
            classOfficerButton.Text = "Class Officer";
            classOfficerButton.TextColor = Color.Black;
            classOfficerButton.UseVisualStyleBackColor = false;
            classOfficerButton.Click += classOfficerButton_Click;
            // 
            // studentButton
            // 
            studentButton.BackColor = Color.FromArgb(198, 68, 70);
            studentButton.BackgroundColor = Color.FromArgb(198, 68, 70);
            studentButton.BorderColor = Color.FromArgb(198, 68, 70);
            studentButton.BorderRadius = 20;
            studentButton.BorderSize = 0;
            studentButton.FlatAppearance.BorderSize = 0;
            studentButton.FlatStyle = FlatStyle.Flat;
            studentButton.ForeColor = Color.Transparent;
            studentButton.Location = new Point(37, 325);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(144, 41);
            studentButton.TabIndex = 0;
            studentButton.Text = "Student";
            studentButton.TextColor = Color.Transparent;
            studentButton.UseVisualStyleBackColor = false;
            studentButton.Click += finalCustomButton1_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(googleButton);
            panel3.Controls.Add(loginButton);
            panel3.Controls.Add(passwordTxtBox);
            panel3.Controls.Add(usernameTxtBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(891, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(595, 718);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(292, 506);
            label4.Name = "label4";
            label4.Size = new Size(45, 31);
            label4.TabIndex = 7;
            label4.Text = "OR";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // googleButton
            // 
            googleButton.BackColor = Color.White;
            googleButton.BackgroundColor = Color.White;
            googleButton.BorderColor = Color.FromArgb(93, 49, 156);
            googleButton.BorderRadius = 20;
            googleButton.BorderSize = 1;
            googleButton.FlatAppearance.BorderSize = 0;
            googleButton.FlatStyle = FlatStyle.Flat;
            googleButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            googleButton.ForeColor = Color.Black;
            googleButton.Image = Properties.Resources.googlesearchIcon;
            googleButton.ImageAlign = ContentAlignment.MiddleLeft;
            googleButton.Location = new Point(179, 579);
            googleButton.Name = "googleButton";
            googleButton.Padding = new Padding(25, 0, 40, 0);
            googleButton.Size = new Size(283, 62);
            googleButton.TabIndex = 10;
            googleButton.Text = "CONTINUE WITH\r\nGOOGLE      \r\n";
            googleButton.TextAlign = ContentAlignment.MiddleRight;
            googleButton.TextColor = Color.Black;
            googleButton.UseVisualStyleBackColor = false;
            googleButton.Click += googleButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.BackgroundColor = Color.White;
            loginButton.BorderColor = Color.FromArgb(93, 49, 156);
            loginButton.BorderRadius = 20;
            loginButton.BorderSize = 1;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(241, 435);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(148, 44);
            loginButton.TabIndex = 7;
            loginButton.Text = "LOGIN";
            loginButton.TextColor = Color.Black;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += finalCustomButton1_Click_1;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxtBox.Location = new Point(108, 336);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.PlaceholderText = "Password";
            passwordTxtBox.Size = new Size(400, 30);
            passwordTxtBox.TabIndex = 9;
            // 
            // usernameTxtBox
            // 
            usernameTxtBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxtBox.Location = new Point(108, 226);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.PlaceholderText = "Username";
            usernameTxtBox.Size = new Size(400, 30);
            usernameTxtBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(255, 58);
            label3.Name = "label3";
            label3.Size = new Size(237, 82);
            label3.TabIndex = 7;
            label3.Text = "LOGIN TO YOUR\r\nACCOUNT";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.LoginIconStart;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(108, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 100);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // studentPanel
            // 
            studentPanel.BackgroundImage = (Image)resources.GetObject("studentPanel.BackgroundImage");
            studentPanel.BackgroundImageLayout = ImageLayout.Stretch;
            studentPanel.Controls.Add(studentAccessLists);
            studentPanel.Controls.Add(studentAccessRolesLabel);
            studentPanel.Controls.Add(studentPictureBox);
            studentPanel.Location = new Point(42, 556);
            studentPanel.Name = "studentPanel";
            studentPanel.Size = new Size(806, 273);
            studentPanel.TabIndex = 3;
            // 
            // studentAccessLists
            // 
            studentAccessLists.AutoSize = true;
            studentAccessLists.BackColor = Color.Transparent;
            studentAccessLists.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentAccessLists.ForeColor = Color.White;
            studentAccessLists.Location = new Point(48, 72);
            studentAccessLists.Name = "studentAccessLists";
            studentAccessLists.Size = new Size(360, 115);
            studentAccessLists.TabIndex = 9;
            studentAccessLists.Text = "• Join and leave class or section\r\n• Add and share their notes to the entire class\r\n• Edit their own profile\r\n• View calendar events\r\n• Make a comment on the notes section";
            studentAccessLists.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // studentAccessRolesLabel
            // 
            studentAccessRolesLabel.AutoSize = true;
            studentAccessRolesLabel.BackColor = Color.Transparent;
            studentAccessRolesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentAccessRolesLabel.ForeColor = Color.White;
            studentAccessRolesLabel.Location = new Point(19, 30);
            studentAccessRolesLabel.Name = "studentAccessRolesLabel";
            studentAccessRolesLabel.Size = new Size(146, 28);
            studentAccessRolesLabel.TabIndex = 7;
            studentAccessRolesLabel.Text = "ACCESS ROLES:";
            studentAccessRolesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // studentPictureBox
            // 
            studentPictureBox.BackColor = Color.Transparent;
            studentPictureBox.BackgroundImage = (Image)resources.GetObject("studentPictureBox.BackgroundImage");
            studentPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            studentPictureBox.Location = new Point(425, 30);
            studentPictureBox.Name = "studentPictureBox";
            studentPictureBox.Size = new Size(375, 206);
            studentPictureBox.TabIndex = 8;
            studentPictureBox.TabStop = false;
            // 
            // classOfficerPanel
            // 
            classOfficerPanel.BackgroundImage = (Image)resources.GetObject("classOfficerPanel.BackgroundImage");
            classOfficerPanel.BackgroundImageLayout = ImageLayout.Stretch;
            classOfficerPanel.Controls.Add(classOfficerAccessList);
            classOfficerPanel.Controls.Add(classOfficerAccessRolesLabel);
            classOfficerPanel.Controls.Add(classOfficerPictureBox);
            classOfficerPanel.Location = new Point(42, 556);
            classOfficerPanel.Name = "classOfficerPanel";
            classOfficerPanel.Size = new Size(806, 273);
            classOfficerPanel.TabIndex = 10;
            // 
            // classOfficerAccessList
            // 
            classOfficerAccessList.AutoSize = true;
            classOfficerAccessList.BackColor = Color.Transparent;
            classOfficerAccessList.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classOfficerAccessList.ForeColor = Color.White;
            classOfficerAccessList.Location = new Point(48, 72);
            classOfficerAccessList.Name = "classOfficerAccessList";
            classOfficerAccessList.Size = new Size(360, 138);
            classOfficerAccessList.TabIndex = 9;
            classOfficerAccessList.Text = "• Join and leave class or section\r\n• Add and share their notes to the entire class\r\n• Edit their own profile\r\n• View calendar events\r\n• Make a comment on the notes section\r\n• Post announcements";
            classOfficerAccessList.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // classOfficerAccessRolesLabel
            // 
            classOfficerAccessRolesLabel.AutoSize = true;
            classOfficerAccessRolesLabel.BackColor = Color.Transparent;
            classOfficerAccessRolesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classOfficerAccessRolesLabel.ForeColor = Color.White;
            classOfficerAccessRolesLabel.Location = new Point(19, 30);
            classOfficerAccessRolesLabel.Name = "classOfficerAccessRolesLabel";
            classOfficerAccessRolesLabel.Size = new Size(146, 28);
            classOfficerAccessRolesLabel.TabIndex = 7;
            classOfficerAccessRolesLabel.Text = "ACCESS ROLES:";
            classOfficerAccessRolesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // classOfficerPictureBox
            // 
            classOfficerPictureBox.BackColor = Color.Transparent;
            classOfficerPictureBox.BackgroundImage = Properties.Resources.classOfficerIconLogo;
            classOfficerPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            classOfficerPictureBox.Location = new Point(414, 30);
            classOfficerPictureBox.Name = "classOfficerPictureBox";
            classOfficerPictureBox.Size = new Size(375, 206);
            classOfficerPictureBox.TabIndex = 8;
            classOfficerPictureBox.TabStop = false;
            // 
            // FinalLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 215, 223);
            ClientSize = new Size(1536, 864);
            Controls.Add(studentPanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(classOfficerPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1536, 864);
            MinimizeBox = false;
            MinimumSize = new Size(1536, 864);
            Name = "FinalLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinalLoginForm";
            Load += FinalLoginForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            studentPanel.ResumeLayout(false);
            studentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).EndInit();
            classOfficerPanel.ResumeLayout(false);
            classOfficerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classOfficerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel studentPanel;
        private Custom.FinalCustomButton adminButton;
        private Custom.FinalCustomButton profButton;
        private Custom.FinalCustomButton classOfficerButton;
        private Custom.FinalCustomButton studentButton;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label studentAccessLists;
        private Label studentAccessRolesLabel;
        private PictureBox studentPictureBox;
        private Panel classOfficerPanel;
        private Label classOfficerAccessList;
        private Label classOfficerAccessRolesLabel;
        private PictureBox classOfficerPictureBox;
        private Button exitButton;
        private Custom.FinalCustomButton loginButton;
        private TextBox passwordTxtBox;
        private TextBox usernameTxtBox;
        private Custom.FinalCustomButton googleButton;
        private Label label4;
    }
}