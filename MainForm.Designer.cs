namespace Classroom_Management_System
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label3 = new Label();
            logopicture = new PictureBox();
            button1 = new Button();
            designBackgroundPic = new PictureBox();
            sideMenuBar = new Panel();
            helpButton = new Button();
            subjectsButton = new Button();
            announcementButton = new Button();
            calendarButton = new Button();
            classHeadPanel = new Panel();
            classButton = new Button();
            menuBarHeaderPanel = new Panel();
            MenuButton = new Button();
            systemLogoPictureBox = new PictureBox();
            MenuBarTimer = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            listBox2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)logopicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)designBackgroundPic).BeginInit();
            sideMenuBar.SuspendLayout();
            menuBarHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)systemLogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(284, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(600, 37);
            label3.TabIndex = 3;
            label3.Text = "CLASSROOM MANAGEMENT SYSTEM";
            // 
            // logopicture
            // 
            logopicture.BackgroundImage = (Image)resources.GetObject("logopicture.BackgroundImage");
            logopicture.BackgroundImageLayout = ImageLayout.Center;
            logopicture.Location = new Point(159, 12);
            logopicture.Name = "logopicture";
            logopicture.Size = new Size(61, 62);
            logopicture.TabIndex = 0;
            logopicture.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(29, 22);
            button1.Name = "button1";
            button1.Size = new Size(40, 43);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // designBackgroundPic
            // 
            designBackgroundPic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            designBackgroundPic.BackColor = Color.Transparent;
            designBackgroundPic.BackgroundImage = (Image)resources.GetObject("designBackgroundPic.BackgroundImage");
            designBackgroundPic.BackgroundImageLayout = ImageLayout.Zoom;
            designBackgroundPic.Location = new Point(856, 71);
            designBackgroundPic.Name = "designBackgroundPic";
            designBackgroundPic.Size = new Size(473, 522);
            designBackgroundPic.TabIndex = 4;
            designBackgroundPic.TabStop = false;
            // 
            // sideMenuBar
            // 
            sideMenuBar.BackColor = Color.FromArgb(30, 38, 51);
            sideMenuBar.Controls.Add(helpButton);
            sideMenuBar.Controls.Add(subjectsButton);
            sideMenuBar.Controls.Add(announcementButton);
            sideMenuBar.Controls.Add(calendarButton);
            sideMenuBar.Controls.Add(classHeadPanel);
            sideMenuBar.Controls.Add(classButton);
            sideMenuBar.Controls.Add(menuBarHeaderPanel);
            sideMenuBar.Location = new Point(0, 3);
            sideMenuBar.MaximumSize = new Size(260, 825);
            sideMenuBar.MinimumSize = new Size(102, 825);
            sideMenuBar.Name = "sideMenuBar";
            sideMenuBar.Size = new Size(260, 825);
            sideMenuBar.TabIndex = 9;
            // 
            // helpButton
            // 
            helpButton.Dock = DockStyle.Top;
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpButton.ForeColor = SystemColors.ButtonHighlight;
            helpButton.Image = (Image)resources.GetObject("helpButton.Image");
            helpButton.ImageAlign = ContentAlignment.MiddleLeft;
            helpButton.Location = new Point(0, 367);
            helpButton.Name = "helpButton";
            helpButton.Padding = new Padding(25, 0, 114, 0);
            helpButton.Size = new Size(260, 67);
            helpButton.TabIndex = 5;
            helpButton.Text = "Help";
            helpButton.TextAlign = ContentAlignment.MiddleRight;
            helpButton.UseVisualStyleBackColor = true;
            helpButton.MouseLeave += LeaveHoverButton;
            helpButton.MouseHover += HoverHelpButton;
            // 
            // subjectsButton
            // 
            subjectsButton.Dock = DockStyle.Top;
            subjectsButton.FlatAppearance.BorderSize = 0;
            subjectsButton.FlatStyle = FlatStyle.Flat;
            subjectsButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectsButton.ForeColor = SystemColors.ButtonHighlight;
            subjectsButton.Image = (Image)resources.GetObject("subjectsButton.Image");
            subjectsButton.ImageAlign = ContentAlignment.MiddleLeft;
            subjectsButton.Location = new Point(0, 300);
            subjectsButton.Name = "subjectsButton";
            subjectsButton.Padding = new Padding(18, 0, 80, 0);
            subjectsButton.Size = new Size(260, 67);
            subjectsButton.TabIndex = 4;
            subjectsButton.Text = "Subjects";
            subjectsButton.TextAlign = ContentAlignment.MiddleRight;
            subjectsButton.UseVisualStyleBackColor = true;
            subjectsButton.Click += subjectsButton_Click;
            subjectsButton.MouseLeave += LeaveHoverButton;
            subjectsButton.MouseHover += HoverSubjectsButton;
            // 
            // announcementButton
            // 
            announcementButton.Dock = DockStyle.Top;
            announcementButton.FlatAppearance.BorderSize = 0;
            announcementButton.FlatStyle = FlatStyle.Flat;
            announcementButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcementButton.ForeColor = SystemColors.ButtonHighlight;
            announcementButton.Image = (Image)resources.GetObject("announcementButton.Image");
            announcementButton.ImageAlign = ContentAlignment.MiddleLeft;
            announcementButton.Location = new Point(0, 233);
            announcementButton.Name = "announcementButton";
            announcementButton.Padding = new Padding(20, 0, 22, 0);
            announcementButton.Size = new Size(260, 67);
            announcementButton.TabIndex = 3;
            announcementButton.Text = "Announcement";
            announcementButton.TextAlign = ContentAlignment.MiddleRight;
            announcementButton.UseVisualStyleBackColor = true;
            announcementButton.Click += announcementButton_Click;
            announcementButton.MouseLeave += LeaveHoverButton;
            announcementButton.MouseHover += HoverAnnouncementButton;
            // 
            // calendarButton
            // 
            calendarButton.Dock = DockStyle.Top;
            calendarButton.FlatAppearance.BorderSize = 0;
            calendarButton.FlatStyle = FlatStyle.Flat;
            calendarButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calendarButton.ForeColor = SystemColors.ButtonHighlight;
            calendarButton.Image = (Image)resources.GetObject("calendarButton.Image");
            calendarButton.ImageAlign = ContentAlignment.MiddleLeft;
            calendarButton.Location = new Point(0, 166);
            calendarButton.Name = "calendarButton";
            calendarButton.Padding = new Padding(20, 0, 75, 0);
            calendarButton.Size = new Size(260, 67);
            calendarButton.TabIndex = 2;
            calendarButton.Text = "Calendar";
            calendarButton.TextAlign = ContentAlignment.MiddleRight;
            calendarButton.UseVisualStyleBackColor = true;
            calendarButton.MouseLeave += LeaveHoverButton;
            calendarButton.MouseHover += HoverCalendarButton;
            // 
            // classHeadPanel
            // 
            classHeadPanel.AutoScroll = true;
            classHeadPanel.BackColor = Color.FromArgb(59, 73, 97);
            classHeadPanel.Dock = DockStyle.Top;
            classHeadPanel.Location = new Point(0, 156);
            classHeadPanel.Name = "classHeadPanel";
            classHeadPanel.Size = new Size(260, 10);
            classHeadPanel.TabIndex = 1;
            // 
            // classButton
            // 
            classButton.Dock = DockStyle.Top;
            classButton.FlatAppearance.BorderSize = 0;
            classButton.FlatStyle = FlatStyle.Flat;
            classButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classButton.ForeColor = SystemColors.ButtonHighlight;
            classButton.Image = (Image)resources.GetObject("classButton.Image");
            classButton.ImageAlign = ContentAlignment.MiddleLeft;
            classButton.Location = new Point(0, 89);
            classButton.Name = "classButton";
            classButton.Padding = new Padding(25, 0, 40, 0);
            classButton.Size = new Size(260, 67);
            classButton.TabIndex = 1;
            classButton.Text = "SectionName";
            classButton.TextAlign = ContentAlignment.MiddleRight;
            classButton.UseVisualStyleBackColor = true;
            // 
            // menuBarHeaderPanel
            // 
            menuBarHeaderPanel.Controls.Add(MenuButton);
            menuBarHeaderPanel.Controls.Add(systemLogoPictureBox);
            menuBarHeaderPanel.Dock = DockStyle.Top;
            menuBarHeaderPanel.Location = new Point(0, 0);
            menuBarHeaderPanel.MaximumSize = new Size(260, 89);
            menuBarHeaderPanel.MinimumSize = new Size(260, 89);
            menuBarHeaderPanel.Name = "menuBarHeaderPanel";
            menuBarHeaderPanel.Size = new Size(260, 89);
            menuBarHeaderPanel.TabIndex = 0;
            // 
            // MenuButton
            // 
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Image = (Image)resources.GetObject("MenuButton.Image");
            MenuButton.Location = new Point(27, 25);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(49, 38);
            MenuButton.TabIndex = 2;
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // systemLogoPictureBox
            // 
            systemLogoPictureBox.BackgroundImage = (Image)resources.GetObject("systemLogoPictureBox.BackgroundImage");
            systemLogoPictureBox.BackgroundImageLayout = ImageLayout.Center;
            systemLogoPictureBox.Location = new Point(148, 15);
            systemLogoPictureBox.Name = "systemLogoPictureBox";
            systemLogoPictureBox.Size = new Size(97, 65);
            systemLogoPictureBox.TabIndex = 0;
            systemLogoPictureBox.TabStop = false;
            // 
            // MenuBarTimer
            // 
            MenuBarTimer.Tick += MenuBarTimer_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // button2
            // 
            button2.Location = new Point(1108, 24);
            button2.Name = "button2";
            button2.Size = new Size(89, 79);
            button2.TabIndex = 10;
            button2.Text = "testing add notif";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1352, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 144);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(565, 0);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 10;
            button3.Text = "add notif";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(989, 55);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(92, 34);
            listBox2.TabIndex = 11;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InsideBackground;
            ClientSize = new Size(738, 351);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(sideMenuBar);
            Controls.Add(designBackgroundPic);
            Controls.Add(label3);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MaximumSize = new Size(1343, 649);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CMS";
            ((System.ComponentModel.ISupportInitialize)logopicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)designBackgroundPic).EndInit();
            sideMenuBar.ResumeLayout(false);
            menuBarHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)systemLogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ClassroomManagementSystem.Custom.CustomButton customButton1;
        private Label label3;
        private PictureBox logopicture;
        private Button button1;
        private PictureBox designBackgroundPic;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel topIconPanel;
        private ClassroomManagementSystem.Custom.CustomButton notifButton;
        private ClassroomManagementSystem.Custom.CustomButton homeButton;
        private ClassroomManagementSystem.Custom.CustomButton userButton;
        private ClassroomManagementSystem.Custom.CustomButton logOutButton;
        private Panel sideMenuBar;
        private Panel menuBarHeaderPanel;
        private Panel classHeadPanel;
        private PictureBox systemLogoPictureBox;
        private Button classButton;
        private Button calendarButton;
        private Button helpButton;
        private Button subjectsButton;
        private Button announcementButton;
        private Button MenuButton;
        private System.Windows.Forms.Timer MenuBarTimer;
        private NotifyIcon notifyIcon1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private ListBox listBox2;
        private Announcement announcement;
        private Subjects subjects;
        private Section section;
    }
}