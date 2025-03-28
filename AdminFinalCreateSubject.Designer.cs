namespace Classroom_Management_System
{
    partial class AdminFinalCreateSubject
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
            panel1 = new Panel();
            createSubject1 = new CreateSubject();
            addSubjectButton = new Custom.FinalCustomButton();
            doneButton = new ClassroomManagementSystem.Custom.CustomButton();
            searchResultPanel = new Panel();
            exitButton = new Button();
            createSubjectLabel = new Label();
            subjectLabel = new Label();
            searchButton = new Button();
            searchtextBox = new TextBox();
            panelDesign1 = new Custom.PanelDesign();
            subjectList1 = new SubjectList();
            panel1.SuspendLayout();
            panelDesign1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(subjectList1);
            panel1.Controls.Add(createSubject1);
            panel1.Location = new Point(10, 82);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 388);
            panel1.TabIndex = 0;
            // 
            // createSubject1
            // 
            createSubject1.BackColor = Color.FromArgb(141, 142, 196);
            createSubject1.Location = new Point(4, 2);
            createSubject1.Margin = new Padding(3, 2, 3, 2);
            createSubject1.Name = "createSubject1";
            createSubject1.Size = new Size(454, 380);
            createSubject1.TabIndex = 0;
            createSubject1.Load += createSubject1_Load;
            // 
            // addSubjectButton
            // 
            addSubjectButton.BackColor = Color.Ivory;
            addSubjectButton.BackgroundColor = Color.Ivory;
            addSubjectButton.BorderColor = Color.FromArgb(93, 49, 156);
            addSubjectButton.BorderRadius = 20;
            addSubjectButton.BorderSize = 2;
            addSubjectButton.FlatAppearance.BorderSize = 0;
            addSubjectButton.FlatStyle = FlatStyle.Flat;
            addSubjectButton.ForeColor = Color.Black;
            addSubjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            addSubjectButton.Location = new Point(42, 482);
            addSubjectButton.Margin = new Padding(3, 2, 3, 2);
            addSubjectButton.Name = "addSubjectButton";
            addSubjectButton.Size = new Size(150, 31);
            addSubjectButton.TabIndex = 18;
            addSubjectButton.Text = "+  Add Subject";
            addSubjectButton.TextColor = Color.Black;
            addSubjectButton.UseVisualStyleBackColor = false;
            addSubjectButton.Click += addSubjectButton_Click;
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.FromArgb(198, 68, 70);
            doneButton.BorderRadius = 25;
            doneButton.BorderSize = 0;
            doneButton.FlatAppearance.BorderColor = Color.White;
            doneButton.FlatAppearance.BorderSize = 0;
            doneButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 68, 70);
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.ForeColor = Color.White;
            doneButton.ImageAlign = ContentAlignment.MiddleLeft;
            doneButton.Location = new Point(320, 482);
            doneButton.Margin = new Padding(3, 2, 3, 2);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(149, 29);
            doneButton.TabIndex = 20;
            doneButton.Text = "DONE";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // searchResultPanel
            // 
            searchResultPanel.BackColor = Color.WhiteSmoke;
            searchResultPanel.Location = new Point(130, 70);
            searchResultPanel.Margin = new Padding(0);
            searchResultPanel.Name = "searchResultPanel";
            searchResultPanel.Size = new Size(270, 10);
            searchResultPanel.TabIndex = 27;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(141, 142, 196);
            exitButton.BackgroundImage = Properties.Resources.Cross;
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(487, 0);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(29, 22);
            exitButton.TabIndex = 28;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // createSubjectLabel
            // 
            createSubjectLabel.AutoSize = true;
            createSubjectLabel.BackColor = Color.Transparent;
            createSubjectLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createSubjectLabel.Location = new Point(210, 5);
            createSubjectLabel.Name = "createSubjectLabel";
            createSubjectLabel.Size = new Size(105, 20);
            createSubjectLabel.TabIndex = 23;
            createSubjectLabel.Text = "Create Subject";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.BackColor = Color.Transparent;
            subjectLabel.ForeColor = SystemColors.ControlLightLight;
            subjectLabel.Location = new Point(82, 32);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(49, 15);
            subjectLabel.TabIndex = 24;
            subjectLabel.Text = "Subject:";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = Properties.Resources.blueSendIcon;
            searchButton.Location = new Point(405, 49);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(24, 21);
            searchButton.TabIndex = 25;
            searchButton.UseVisualStyleBackColor = false;
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(130, 50);
            searchtextBox.Margin = new Padding(3, 2, 3, 2);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(271, 23);
            searchtextBox.TabIndex = 26;
            // 
            // panelDesign1
            // 
            panelDesign1.BackColor = Color.White;
            panelDesign1.BorderColor = Color.MidnightBlue;
            panelDesign1.BorderRadius = 3;
            panelDesign1.BorderSize = 3;
            panelDesign1.BottomGradient = Color.FromArgb(141, 142, 196);
            panelDesign1.Controls.Add(searchButton);
            panelDesign1.Controls.Add(searchResultPanel);
            panelDesign1.Controls.Add(exitButton);
            panelDesign1.Controls.Add(searchtextBox);
            panelDesign1.Controls.Add(createSubjectLabel);
            panelDesign1.Controls.Add(subjectLabel);
            panelDesign1.ForeColor = Color.White;
            panelDesign1.GradientAngle = 90F;
            panelDesign1.Location = new Point(1, 2);
            panelDesign1.Margin = new Padding(3, 2, 3, 2);
            panelDesign1.Name = "panelDesign1";
            panelDesign1.Size = new Size(516, 518);
            panelDesign1.TabIndex = 29;
            panelDesign1.TopGradient = Color.FromArgb(141, 142, 196);
            panelDesign1.Paint += panelDesign1_Paint;
            // 
            // subjectList1
            // 
            subjectList1.Location = new Point(83, 172);
            subjectList1.Name = "subjectList1";
            subjectList1.Size = new Size(365, 133);
            subjectList1.TabIndex = 30;
            // 
            // AdminFinalCreateSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            ClientSize = new Size(518, 522);
            Controls.Add(doneButton);
            Controls.Add(addSubjectButton);
            Controls.Add(panel1);
            Controls.Add(panelDesign1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminFinalCreateSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFinalCreateSubject";
            panel1.ResumeLayout(false);
            panelDesign1.ResumeLayout(false);
            panelDesign1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Classroom_Management_System.CreateSubject createSubject1;
        private Custom.FinalCustomButton addSubjectButton;
        private ClassroomManagementSystem.Custom.CustomButton doneButton;
        private System.Windows.Forms.Panel searchResultPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label createSubjectLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchtextBox;
        private Custom.PanelDesign panelDesign1;
        private Classroom_Management_System.SubjectList subjectList1;
    }
}