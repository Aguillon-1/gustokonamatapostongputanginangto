namespace Classroom_Management_System
{
    partial class Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section));
            OfficersPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            singleofficerPanel = new Panel();
            officerPositionLabel = new Label();
            officerMoreButton = new Button();
            officerNameLabel = new Label();
            profilepic = new PictureBox();
            classOfficersHeader = new Panel();
            classOfficersLabel = new Label();
            classMembersPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            singleClassMemberPanel = new Panel();
            classMemberMoreButton = new Button();
            classMemberNameLabel = new Label();
            classMemberProfile = new PictureBox();
            classMembersHeaderPanel = new Panel();
            classMembersLabel = new Label();
            reminderPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            panel1 = new Panel();
            reminderLabel = new Label();
            customButton1 = new ClassroomManagementSystem.Custom.CustomButton();
            classNameHeader = new Label();
            sectionName = new Label();
            OfficersPanel.SuspendLayout();
            singleofficerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilepic).BeginInit();
            classOfficersHeader.SuspendLayout();
            classMembersPanel.SuspendLayout();
            singleClassMemberPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)classMemberProfile).BeginInit();
            classMembersHeaderPanel.SuspendLayout();
            reminderPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OfficersPanel
            // 
            OfficersPanel.BackColor = Color.White;
            OfficersPanel.Controls.Add(singleofficerPanel);
            OfficersPanel.Controls.Add(classOfficersHeader);
            OfficersPanel.Location = new Point(34, 153);
            OfficersPanel.Margin = new Padding(2, 1, 2, 1);
            OfficersPanel.Name = "OfficersPanel";
            OfficersPanel.Size = new Size(283, 469);
            OfficersPanel.TabIndex = 0;
            // 
            // singleofficerPanel
            // 
            singleofficerPanel.BackColor = Color.Transparent;
            singleofficerPanel.Controls.Add(officerPositionLabel);
            singleofficerPanel.Controls.Add(officerMoreButton);
            singleofficerPanel.Controls.Add(officerNameLabel);
            singleofficerPanel.Controls.Add(profilepic);
            singleofficerPanel.Dock = DockStyle.Top;
            singleofficerPanel.Location = new Point(0, 79);
            singleofficerPanel.Margin = new Padding(0);
            singleofficerPanel.Name = "singleofficerPanel";
            singleofficerPanel.Size = new Size(283, 75);
            singleofficerPanel.TabIndex = 3;
            // 
            // officerPositionLabel
            // 
            officerPositionLabel.AutoSize = true;
            officerPositionLabel.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            officerPositionLabel.Location = new Point(93, 41);
            officerPositionLabel.Name = "officerPositionLabel";
            officerPositionLabel.Size = new Size(108, 25);
            officerPositionLabel.TabIndex = 4;
            officerPositionLabel.Text = "POSITION";
            // 
            // officerMoreButton
            // 
            officerMoreButton.FlatAppearance.BorderSize = 0;
            officerMoreButton.FlatStyle = FlatStyle.Flat;
            officerMoreButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            officerMoreButton.Location = new Point(227, 12);
            officerMoreButton.Margin = new Padding(3, 4, 3, 4);
            officerMoreButton.Name = "officerMoreButton";
            officerMoreButton.Size = new Size(45, 48);
            officerMoreButton.TabIndex = 3;
            officerMoreButton.Text = "...";
            officerMoreButton.UseVisualStyleBackColor = true;
            // 
            // officerNameLabel
            // 
            officerNameLabel.AutoSize = true;
            officerNameLabel.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            officerNameLabel.Location = new Point(93, 12);
            officerNameLabel.Name = "officerNameLabel";
            officerNameLabel.Size = new Size(70, 25);
            officerNameLabel.TabIndex = 2;
            officerNameLabel.Text = "NAME";
            // 
            // profilepic
            // 
            profilepic.BackgroundImage = (Image)resources.GetObject("profilepic.BackgroundImage");
            profilepic.BackgroundImageLayout = ImageLayout.Center;
            profilepic.Location = new Point(33, 11);
            profilepic.Margin = new Padding(3, 4, 3, 4);
            profilepic.Name = "profilepic";
            profilepic.Size = new Size(53, 56);
            profilepic.TabIndex = 1;
            profilepic.TabStop = false;
            // 
            // classOfficersHeader
            // 
            classOfficersHeader.BackColor = Color.Transparent;
            classOfficersHeader.Controls.Add(classOfficersLabel);
            classOfficersHeader.Dock = DockStyle.Top;
            classOfficersHeader.Location = new Point(0, 0);
            classOfficersHeader.Margin = new Padding(3, 4, 3, 4);
            classOfficersHeader.Name = "classOfficersHeader";
            classOfficersHeader.Size = new Size(283, 79);
            classOfficersHeader.TabIndex = 2;
            // 
            // classOfficersLabel
            // 
            classOfficersLabel.AutoSize = true;
            classOfficersLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classOfficersLabel.Location = new Point(55, 24);
            classOfficersLabel.Margin = new Padding(2, 27, 2, 0);
            classOfficersLabel.Name = "classOfficersLabel";
            classOfficersLabel.Size = new Size(193, 31);
            classOfficersLabel.TabIndex = 0;
            classOfficersLabel.Text = "Class Officers:";
            // 
            // classMembersPanel
            // 
            classMembersPanel.BackColor = Color.White;
            classMembersPanel.Controls.Add(singleClassMemberPanel);
            classMembersPanel.Controls.Add(classMembersHeaderPanel);
            classMembersPanel.Location = new Point(343, 153);
            classMembersPanel.Margin = new Padding(2, 1, 2, 1);
            classMembersPanel.Name = "classMembersPanel";
            classMembersPanel.Size = new Size(283, 469);
            classMembersPanel.TabIndex = 1;
            // 
            // singleClassMemberPanel
            // 
            singleClassMemberPanel.BackColor = Color.Transparent;
            singleClassMemberPanel.Controls.Add(classMemberMoreButton);
            singleClassMemberPanel.Controls.Add(classMemberNameLabel);
            singleClassMemberPanel.Controls.Add(classMemberProfile);
            singleClassMemberPanel.Dock = DockStyle.Top;
            singleClassMemberPanel.Location = new Point(0, 85);
            singleClassMemberPanel.Margin = new Padding(0);
            singleClassMemberPanel.Name = "singleClassMemberPanel";
            singleClassMemberPanel.Size = new Size(283, 68);
            singleClassMemberPanel.TabIndex = 4;
            // 
            // classMemberMoreButton
            // 
            classMemberMoreButton.FlatAppearance.BorderSize = 0;
            classMemberMoreButton.FlatStyle = FlatStyle.Flat;
            classMemberMoreButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            classMemberMoreButton.Location = new Point(228, 6);
            classMemberMoreButton.Margin = new Padding(3, 4, 3, 4);
            classMemberMoreButton.Name = "classMemberMoreButton";
            classMemberMoreButton.Size = new Size(45, 48);
            classMemberMoreButton.TabIndex = 3;
            classMemberMoreButton.Text = "...";
            classMemberMoreButton.UseVisualStyleBackColor = true;
            // 
            // classMemberNameLabel
            // 
            classMemberNameLabel.AutoSize = true;
            classMemberNameLabel.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classMemberNameLabel.Location = new Point(93, 23);
            classMemberNameLabel.Name = "classMemberNameLabel";
            classMemberNameLabel.Size = new Size(70, 25);
            classMemberNameLabel.TabIndex = 2;
            classMemberNameLabel.Text = "NAME";
            // 
            // classMemberProfile
            // 
            classMemberProfile.BackgroundImage = (Image)resources.GetObject("classMemberProfile.BackgroundImage");
            classMemberProfile.BackgroundImageLayout = ImageLayout.Center;
            classMemberProfile.Location = new Point(33, 4);
            classMemberProfile.Margin = new Padding(3, 4, 3, 4);
            classMemberProfile.Name = "classMemberProfile";
            classMemberProfile.Size = new Size(53, 56);
            classMemberProfile.TabIndex = 1;
            classMemberProfile.TabStop = false;
            // 
            // classMembersHeaderPanel
            // 
            classMembersHeaderPanel.BackColor = Color.Transparent;
            classMembersHeaderPanel.Controls.Add(classMembersLabel);
            classMembersHeaderPanel.Dock = DockStyle.Top;
            classMembersHeaderPanel.Location = new Point(0, 0);
            classMembersHeaderPanel.Margin = new Padding(0);
            classMembersHeaderPanel.Name = "classMembersHeaderPanel";
            classMembersHeaderPanel.Size = new Size(283, 85);
            classMembersHeaderPanel.TabIndex = 2;
            // 
            // classMembersLabel
            // 
            classMembersLabel.AutoSize = true;
            classMembersLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classMembersLabel.Location = new Point(44, 24);
            classMembersLabel.Margin = new Padding(2, 0, 2, 0);
            classMembersLabel.Name = "classMembersLabel";
            classMembersLabel.Size = new Size(210, 31);
            classMembersLabel.TabIndex = 1;
            classMembersLabel.Text = "Class Members:";
            // 
            // reminderPanel
            // 
            reminderPanel.BackColor = Color.White;
            reminderPanel.Controls.Add(panel1);
            reminderPanel.Location = new Point(655, 153);
            reminderPanel.Margin = new Padding(2, 1, 2, 1);
            reminderPanel.Name = "reminderPanel";
            reminderPanel.Size = new Size(421, 469);
            reminderPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(reminderLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 87);
            panel1.TabIndex = 3;
            // 
            // reminderLabel
            // 
            reminderLabel.AutoSize = true;
            reminderLabel.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reminderLabel.Location = new Point(130, 24);
            reminderLabel.Margin = new Padding(2, 0, 2, 0);
            reminderLabel.Name = "reminderLabel";
            reminderLabel.Size = new Size(161, 31);
            reminderLabel.TabIndex = 2;
            reminderLabel.Text = "Reminder/s:";
            reminderLabel.Click += reminderLabel_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(30, 38, 51);
            customButton1.FlatAppearance.BorderColor = Color.White;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(618, 808);
            customButton1.Margin = new Padding(2, 1, 2, 1);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(189, 47);
            customButton1.TabIndex = 3;
            customButton1.Text = "Leave Class";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // classNameHeader
            // 
            classNameHeader.AutoSize = true;
            classNameHeader.BackColor = Color.Transparent;
            classNameHeader.Font = new Font("Microsoft Sans Serif", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classNameHeader.Location = new Point(448, 18);
            classNameHeader.Margin = new Padding(2, 0, 2, 0);
            classNameHeader.Name = "classNameHeader";
            classNameHeader.Size = new Size(279, 46);
            classNameHeader.TabIndex = 1;
            classNameHeader.Text = "CLASS NAME";
            // 
            // sectionName
            // 
            sectionName.AutoSize = true;
            sectionName.BackColor = Color.Transparent;
            sectionName.Font = new Font("Microsoft Sans Serif", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sectionName.Location = new Point(519, 76);
            sectionName.Margin = new Padding(2, 0, 2, 0);
            sectionName.Name = "sectionName";
            sectionName.Size = new Size(131, 39);
            sectionName.TabIndex = 4;
            sectionName.Text = "Section";
            sectionName.Click += label5_Click;
            // 
            // Section
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SectionBackground;
            Controls.Add(sectionName);
            Controls.Add(classNameHeader);
            Controls.Add(customButton1);
            Controls.Add(reminderPanel);
            Controls.Add(classMembersPanel);
            Controls.Add(OfficersPanel);
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(1107, 645);
            MinimumSize = new Size(1107, 645);
            Name = "Section";
            Size = new Size(1107, 645);
            OfficersPanel.ResumeLayout(false);
            singleofficerPanel.ResumeLayout(false);
            singleofficerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilepic).EndInit();
            classOfficersHeader.ResumeLayout(false);
            classOfficersHeader.PerformLayout();
            classMembersPanel.ResumeLayout(false);
            singleClassMemberPanel.ResumeLayout(false);
            singleClassMemberPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)classMemberProfile).EndInit();
            classMembersHeaderPanel.ResumeLayout(false);
            classMembersHeaderPanel.PerformLayout();
            reminderPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ClassroomManagementSystem.Custom.GreyTransparentPanel OfficersPanel;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel classMembersPanel;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel reminderPanel;
        private Label classOfficersLabel;
        private Label classMembersLabel;
        private Label reminderLabel;
        private ClassroomManagementSystem.Custom.CustomButton customButton1;
        private Label classNameHeader;
        private Label sectionName;
        private PictureBox profilepic;
        private Panel singleofficerPanel;
        private Panel classOfficersHeader;
        private Label officerPositionLabel;
        private Button officerMoreButton;
        private Label officerNameLabel;
        private Panel singleClassMemberPanel;
        private Button classMemberMoreButton;
        private Label classMemberNameLabel;
        private PictureBox classMemberProfile;
        private Panel classMembersHeaderPanel;
        private Panel panel1;
    }
}
