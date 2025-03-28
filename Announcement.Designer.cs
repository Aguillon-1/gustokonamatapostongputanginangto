namespace Classroom_Management_System
{
    partial class Announcement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcement));
            userAnnouncementPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            announcementDescription = new Label();
            profilePicture = new PictureBox();
            usernameLabel = new Label();
            announcementLabel = new Label();
            announcementContainerPanel = new Panel();
            button1 = new Button();
            userAnnouncementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            announcementContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userAnnouncementPanel
            // 
            userAnnouncementPanel.BackColor = Color.White;
            userAnnouncementPanel.Controls.Add(announcementDescription);
            userAnnouncementPanel.Controls.Add(profilePicture);
            userAnnouncementPanel.Controls.Add(usernameLabel);
            userAnnouncementPanel.Location = new Point(29, 22);
            userAnnouncementPanel.Margin = new Padding(2, 1, 2, 1);
            userAnnouncementPanel.Name = "userAnnouncementPanel";
            userAnnouncementPanel.Size = new Size(820, 146);
            userAnnouncementPanel.TabIndex = 2;
            userAnnouncementPanel.Paint += userAnnouncementPanel_Paint;
            // 
            // announcementDescription
            // 
            announcementDescription.AutoSize = true;
            announcementDescription.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcementDescription.Location = new Point(71, 71);
            announcementDescription.Margin = new Padding(2, 0, 2, 0);
            announcementDescription.Name = "announcementDescription";
            announcementDescription.Size = new Size(677, 60);
            announcementDescription.TabIndex = 4;
            announcementDescription.Text = resources.GetString("announcementDescription.Text");
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.Transparent;
            profilePicture.BackgroundImage = (Image)resources.GetObject("profilePicture.BackgroundImage");
            profilePicture.BackgroundImageLayout = ImageLayout.Center;
            profilePicture.Location = new Point(28, 9);
            profilePicture.Margin = new Padding(2, 1, 2, 1);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(74, 52);
            profilePicture.TabIndex = 3;
            profilePicture.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(106, 31);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(97, 24);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // announcementLabel
            // 
            announcementLabel.AutoSize = true;
            announcementLabel.BackColor = Color.Transparent;
            announcementLabel.Font = new Font("Microsoft Sans Serif", 13.8749981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcementLabel.Location = new Point(21, 21);
            announcementLabel.Margin = new Padding(2, 0, 2, 0);
            announcementLabel.Name = "announcementLabel";
            announcementLabel.Size = new Size(174, 24);
            announcementLabel.TabIndex = 4;
            announcementLabel.Text = "ANNOUNCEMENT";
            announcementLabel.Click += label5_Click;
            // 
            // announcementContainerPanel
            // 
            announcementContainerPanel.BackgroundImage = Properties.Resources.gradientplaceholder;
            announcementContainerPanel.Controls.Add(button1);
            announcementContainerPanel.Controls.Add(userAnnouncementPanel);
            announcementContainerPanel.Location = new Point(40, 59);
            announcementContainerPanel.Margin = new Padding(2, 1, 2, 1);
            announcementContainerPanel.Name = "announcementContainerPanel";
            announcementContainerPanel.Size = new Size(875, 403);
            announcementContainerPanel.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(14, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Announcement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.container;
            Controls.Add(announcementContainerPanel);
            Controls.Add(announcementLabel);
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(969, 484);
            MinimumSize = new Size(969, 484);
            Name = "Announcement";
            Size = new Size(969, 484);
            Load += Announcement_Load;
            userAnnouncementPanel.ResumeLayout(false);
            userAnnouncementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            announcementContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ClassroomManagementSystem.Custom.GreyTransparentPanel userAnnouncementPanel;
        private Label usernameLabel;
        private Label announcementLabel;
        private Panel announcementContainerPanel;
        private Label announcementDescription;
        private PictureBox profilePicture;
        private Button button1;
    }
}
