namespace Classroom_Management_System
{
    partial class Subjects
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
            label5 = new Label();
            subjectsPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            oneSubjectPanel2 = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            pictureBox2 = new PictureBox();
            subject2ProfName = new Label();
            subject2Time = new Label();
            subjectName2 = new Label();
            oneSubjectPanel1 = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            pictureBox1 = new PictureBox();
            subject1profname = new Label();
            subject1Time = new Label();
            subjectName1 = new Label();
            subjectsPanel.SuspendLayout();
            oneSubjectPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            oneSubjectPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 28);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 36);
            label5.TabIndex = 5;
            label5.Text = "SUBJECTS";
            // 
            // subjectsPanel
            // 
            subjectsPanel.AccessibleRole = AccessibleRole.ScrollBar;
            subjectsPanel.BackColor = Color.FromArgb(28, 189, 158);
            subjectsPanel.Controls.Add(oneSubjectPanel2);
            subjectsPanel.Controls.Add(oneSubjectPanel1);
            subjectsPanel.Location = new Point(68, 99);
            subjectsPanel.Margin = new Padding(2, 1, 2, 1);
            subjectsPanel.Name = "subjectsPanel";
            subjectsPanel.Size = new Size(1020, 519);
            subjectsPanel.TabIndex = 6;
            // 
            // oneSubjectPanel2
            // 
            oneSubjectPanel2.BackColor = Color.White;
            oneSubjectPanel2.Controls.Add(pictureBox2);
            oneSubjectPanel2.Controls.Add(subject2ProfName);
            oneSubjectPanel2.Controls.Add(subject2Time);
            oneSubjectPanel2.Controls.Add(subjectName2);
            oneSubjectPanel2.Location = new Point(538, 36);
            oneSubjectPanel2.Margin = new Padding(2, 1, 2, 1);
            oneSubjectPanel2.Name = "oneSubjectPanel2";
            oneSubjectPanel2.Size = new Size(414, 126);
            oneSubjectPanel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.Square;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(19, 16);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 99);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // subject2ProfName
            // 
            subject2ProfName.AutoSize = true;
            subject2ProfName.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject2ProfName.Location = new Point(129, 62);
            subject2ProfName.Margin = new Padding(2, 0, 2, 0);
            subject2ProfName.Name = "subject2ProfName";
            subject2ProfName.Size = new Size(109, 25);
            subject2ProfName.TabIndex = 1;
            subject2ProfName.Text = "Prof. Name";
            // 
            // subject2Time
            // 
            subject2Time.AutoSize = true;
            subject2Time.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject2Time.Location = new Point(129, 91);
            subject2Time.Margin = new Padding(2, 0, 2, 0);
            subject2Time.Name = "subject2Time";
            subject2Time.Size = new Size(53, 24);
            subject2Time.TabIndex = 2;
            subject2Time.Text = "Time";
            // 
            // subjectName2
            // 
            subjectName2.AutoSize = true;
            subjectName2.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectName2.Location = new Point(104, 16);
            subjectName2.Margin = new Padding(2, 0, 2, 0);
            subjectName2.Name = "subjectName2";
            subjectName2.Size = new Size(184, 31);
            subjectName2.TabIndex = 0;
            subjectName2.Text = "Subject Name";
            // 
            // oneSubjectPanel1
            // 
            oneSubjectPanel1.BackColor = Color.White;
            oneSubjectPanel1.Controls.Add(pictureBox1);
            oneSubjectPanel1.Controls.Add(subject1profname);
            oneSubjectPanel1.Controls.Add(subject1Time);
            oneSubjectPanel1.Controls.Add(subjectName1);
            oneSubjectPanel1.Location = new Point(75, 36);
            oneSubjectPanel1.Margin = new Padding(2, 1, 2, 1);
            oneSubjectPanel1.Name = "oneSubjectPanel1";
            oneSubjectPanel1.Size = new Size(400, 126);
            oneSubjectPanel1.TabIndex = 0;
            oneSubjectPanel1.Paint += oneSubjectPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Square;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(19, 16);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 99);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // subject1profname
            // 
            subject1profname.AutoSize = true;
            subject1profname.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject1profname.Location = new Point(129, 62);
            subject1profname.Margin = new Padding(2, 0, 2, 0);
            subject1profname.Name = "subject1profname";
            subject1profname.Size = new Size(109, 25);
            subject1profname.TabIndex = 1;
            subject1profname.Text = "Prof. Name";
            subject1profname.Click += subject1profname_Click;
            // 
            // subject1Time
            // 
            subject1Time.AutoSize = true;
            subject1Time.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject1Time.Location = new Point(129, 91);
            subject1Time.Margin = new Padding(2, 0, 2, 0);
            subject1Time.Name = "subject1Time";
            subject1Time.Size = new Size(53, 24);
            subject1Time.TabIndex = 2;
            subject1Time.Text = "Time";
            // 
            // subjectName1
            // 
            subjectName1.AutoSize = true;
            subjectName1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectName1.Location = new Point(104, 16);
            subjectName1.Margin = new Padding(2, 0, 2, 0);
            subjectName1.Name = "subjectName1";
            subjectName1.Size = new Size(184, 31);
            subjectName1.TabIndex = 0;
            subjectName1.Text = "Subject Name";
            // 
            // Subjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.container1;
            Controls.Add(subjectsPanel);
            Controls.Add(label5);
            Margin = new Padding(2, 1, 2, 1);
            MaximumSize = new Size(1107, 645);
            MinimumSize = new Size(1107, 645);
            Name = "Subjects";
            Size = new Size(1107, 645);
            subjectsPanel.ResumeLayout(false);
            oneSubjectPanel2.ResumeLayout(false);
            oneSubjectPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            oneSubjectPanel1.ResumeLayout(false);
            oneSubjectPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel subjectsPanel;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel oneSubjectPanel1;
        private Label subjectName1;
        private PictureBox pictureBox1;
        private Label subject1Time;
        private Label subject1profname;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel oneSubjectPanel2;
        private PictureBox pictureBox2;
        private Label subject2ProfName;
        private Label subject2Time;
        private Label subjectName2;
    }
}
