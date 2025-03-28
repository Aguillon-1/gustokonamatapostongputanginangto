namespace Classroom_Management_System
{
    partial class FinalSubjects
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
            subjectsLabel = new Label();
            subjectOneButton = new Custom.FinalCustomButton();
            finalSubjectNoteSearch1 = new FinalSubjectNoteSearch();
            SuspendLayout();
            // 
            // subjectsLabel
            // 
            subjectsLabel.AutoSize = true;
            subjectsLabel.Location = new Point(22, 21);
            subjectsLabel.Name = "subjectsLabel";
            subjectsLabel.Size = new Size(74, 20);
            subjectsLabel.TabIndex = 2;
            subjectsLabel.Text = "SUBJECTS";
            // 
            // subjectOneButton
            // 
            subjectOneButton.BackColor = Color.FromArgb(253, 253, 253);
            subjectOneButton.BackgroundColor = Color.FromArgb(253, 253, 253);
            subjectOneButton.BorderColor = Color.FromArgb(198, 68, 70);
            subjectOneButton.BorderRadius = 20;
            subjectOneButton.BorderSize = 1;
            subjectOneButton.FlatAppearance.BorderSize = 0;
            subjectOneButton.FlatStyle = FlatStyle.Flat;
            subjectOneButton.ForeColor = Color.Black;
            subjectOneButton.Image = Properties.Resources.userplaceholder;
            subjectOneButton.Location = new Point(61, 58);
            subjectOneButton.Name = "subjectOneButton";
            subjectOneButton.Size = new Size(280, 120);
            subjectOneButton.TabIndex = 4;
            subjectOneButton.Text = "Object-Oriented Programming";
            subjectOneButton.TextColor = Color.Black;
            subjectOneButton.TextImageRelation = TextImageRelation.ImageAboveText;
            subjectOneButton.UseVisualStyleBackColor = false;
            subjectOneButton.Click += subjectOneButton_Click;
            // 
            // finalSubjectNoteSearch1
            // 
            finalSubjectNoteSearch1.BackColor = Color.FromArgb(141, 142, 196);
            finalSubjectNoteSearch1.Location = new Point(0, 0);
            finalSubjectNoteSearch1.Margin = new Padding(0);
            finalSubjectNoteSearch1.Name = "finalSubjectNoteSearch1";
            finalSubjectNoteSearch1.Size = new Size(1588, 938);
            finalSubjectNoteSearch1.TabIndex = 5;
            // 
            // FinalSubjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            Controls.Add(subjectOneButton);
            Controls.Add(subjectsLabel);
            Controls.Add(finalSubjectNoteSearch1);
            Name = "FinalSubjects";
            Size = new Size(1270, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subjectsLabel;
        private Custom.FinalCustomButton subjectOneButton;
        private FinalSubjectNoteSearch finalSubjectNoteSearch1;
    }
}
