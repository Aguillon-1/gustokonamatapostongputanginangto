namespace Classroom_Management_System
{
    partial class FinalNoteUpload
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
            noteUploadLabel = new Label();
            tagInputTextBox = new TextBox();
            searchtextBox = new TextBox();
            tagList = new ListBox();
            cancelButton = new ClassroomManagementSystem.Custom.CustomButton();
            tagInputLabel = new Label();
            subjectLabel = new Label();
            searchPanel = new Panel();
            tagsLabel = new Label();
            uploadButton = new ClassroomManagementSystem.Custom.CustomButton();
            searchButton = new Button();
            SuspendLayout();
            // 
            // noteUploadLabel
            // 
            noteUploadLabel.AutoSize = true;
            noteUploadLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteUploadLabel.Location = new Point(18, 8);
            noteUploadLabel.Name = "noteUploadLabel";
            noteUploadLabel.Size = new Size(87, 19);
            noteUploadLabel.TabIndex = 0;
            noteUploadLabel.Text = "Note Upload";
            // 
            // tagInputTextBox
            // 
            tagInputTextBox.Location = new Point(116, 61);
            tagInputTextBox.Margin = new Padding(3, 2, 3, 2);
            tagInputTextBox.Name = "tagInputTextBox";
            tagInputTextBox.Size = new Size(386, 23);
            tagInputTextBox.TabIndex = 1;
            // 
            // searchtextBox
            // 
            searchtextBox.Location = new Point(116, 116);
            searchtextBox.Margin = new Padding(3, 2, 3, 2);
            searchtextBox.Name = "searchtextBox";
            searchtextBox.Size = new Size(359, 23);
            searchtextBox.TabIndex = 2;
            // 
            // tagList
            // 
            tagList.FormattingEnabled = true;
            tagList.ItemHeight = 15;
            tagList.Location = new Point(116, 183);
            tagList.Margin = new Padding(3, 2, 3, 2);
            tagList.MultiColumn = true;
            tagList.Name = "tagList";
            tagList.Size = new Size(391, 19);
            tagList.TabIndex = 3;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(30, 38, 51);
            cancelButton.BorderRadius = 25;
            cancelButton.BorderSize = 0;
            cancelButton.FlatAppearance.BorderColor = Color.White;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(18, 215);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(102, 30);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += customButton1_Click;
            // 
            // tagInputLabel
            // 
            tagInputLabel.AutoSize = true;
            tagInputLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagInputLabel.ForeColor = SystemColors.ControlLightLight;
            tagInputLabel.Location = new Point(53, 44);
            tagInputLabel.Name = "tagInputLabel";
            tagInputLabel.Size = new Size(179, 15);
            tagInputLabel.TabIndex = 5;
            tagInputLabel.Text = "Enter a tag (maximum of three): ";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subjectLabel.ForeColor = SystemColors.ControlLightLight;
            subjectLabel.Location = new Point(59, 96);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(49, 15);
            subjectLabel.TabIndex = 6;
            subjectLabel.Text = "Subject:";
            // 
            // searchPanel
            // 
            searchPanel.Location = new Point(116, 139);
            searchPanel.Margin = new Padding(3, 2, 3, 2);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(359, 32);
            searchPanel.TabIndex = 7;
            // 
            // tagsLabel
            // 
            tagsLabel.AutoSize = true;
            tagsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tagsLabel.ForeColor = SystemColors.ControlLightLight;
            tagsLabel.Location = new Point(59, 186);
            tagsLabel.Name = "tagsLabel";
            tagsLabel.Size = new Size(33, 15);
            tagsLabel.TabIndex = 8;
            tagsLabel.Text = "Tags:";
            // 
            // uploadButton
            // 
            uploadButton.BackColor = Color.FromArgb(198, 68, 70);
            uploadButton.BorderRadius = 25;
            uploadButton.BorderSize = 0;
            uploadButton.FlatAppearance.BorderColor = Color.White;
            uploadButton.FlatAppearance.BorderSize = 0;
            uploadButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 68, 70);
            uploadButton.FlatStyle = FlatStyle.Flat;
            uploadButton.ForeColor = Color.White;
            uploadButton.Location = new Point(126, 215);
            uploadButton.Margin = new Padding(3, 2, 3, 2);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(102, 30);
            uploadButton.TabIndex = 9;
            uploadButton.Text = "UPLOAD";
            uploadButton.UseVisualStyleBackColor = false;
            uploadButton.Click += uploadButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImageLayout = ImageLayout.Stretch;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = Properties.Resources.blueSendIcon;
            searchButton.Location = new Point(478, 115);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(24, 21);
            searchButton.TabIndex = 11;
            searchButton.UseVisualStyleBackColor = false;
            // 
            // FinalNoteUpload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            Controls.Add(searchButton);
            Controls.Add(uploadButton);
            Controls.Add(tagsLabel);
            Controls.Add(searchPanel);
            Controls.Add(subjectLabel);
            Controls.Add(tagInputLabel);
            Controls.Add(cancelButton);
            Controls.Add(tagList);
            Controls.Add(searchtextBox);
            Controls.Add(tagInputTextBox);
            Controls.Add(noteUploadLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FinalNoteUpload";
            Size = new Size(592, 274);
            Load += FinalNoteUpload_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label noteUploadLabel;
        private TextBox tagInputTextBox;
        private TextBox searchtextBox;
        private ListBox tagList;
        private ClassroomManagementSystem.Custom.CustomButton cancelButton;
        private Label tagInputLabel;
        private Label subjectLabel;
        private Panel searchPanel;
        private Label tagsLabel;
        private ClassroomManagementSystem.Custom.CustomButton uploadButton;
        private Button searchButton;
    }
}
