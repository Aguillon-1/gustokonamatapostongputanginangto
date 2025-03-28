namespace Classroom_Management_System
{
    partial class FinalUpload
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
            commentsPanel = new Custom.PanelDesign();
            fileLabel = new Label();
            descLabel = new Label();
            titleLabel = new Label();
            saveButton = new Custom.FinalCustomButton();
            announcementCheckedBox = new CheckBox();
            announcementButton = new Button();
            fileLists = new ListBox();
            fileDropPanel = new Panel();
            fileButton = new Custom.FinalCustomButton();
            descTextBox = new TextBox();
            titleTextBox = new TextBox();
            uploadLabel = new Label();
            previewPanel = new Custom.PanelDesign();
            finalNoteUpload1 = new FinalNoteUpload();
            previewLabel = new Label();
            commentsPanel.SuspendLayout();
            previewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // commentsPanel
            // 
            commentsPanel.BackColor = Color.White;
            commentsPanel.BorderColor = Color.FromArgb(93, 49, 156);
            commentsPanel.BorderRadius = 3;
            commentsPanel.BorderSize = 2;
            commentsPanel.BottomGradient = Color.FromArgb(141, 142, 196);
            commentsPanel.Controls.Add(fileLabel);
            commentsPanel.Controls.Add(descLabel);
            commentsPanel.Controls.Add(titleLabel);
            commentsPanel.Controls.Add(saveButton);
            commentsPanel.Controls.Add(announcementCheckedBox);
            commentsPanel.Controls.Add(announcementButton);
            commentsPanel.Controls.Add(fileLists);
            commentsPanel.Controls.Add(fileDropPanel);
            commentsPanel.Controls.Add(fileButton);
            commentsPanel.Controls.Add(descTextBox);
            commentsPanel.Controls.Add(titleTextBox);
            commentsPanel.Controls.Add(uploadLabel);
            commentsPanel.ForeColor = Color.White;
            commentsPanel.GradientAngle = 0F;
            commentsPanel.Location = new Point(3, 2);
            commentsPanel.Margin = new Padding(3, 2, 3, 2);
            commentsPanel.Name = "commentsPanel";
            commentsPanel.Size = new Size(551, 558);
            commentsPanel.TabIndex = 2;
            commentsPanel.TopGradient = Color.FromArgb(141, 142, 196);
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.BackColor = Color.Transparent;
            fileLabel.Location = new Point(263, 260);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(38, 15);
            fileLabel.TabIndex = 12;
            fileLabel.Text = "File/s:";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.BackColor = Color.Transparent;
            descLabel.Location = new Point(244, 87);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(70, 15);
            descLabel.TabIndex = 11;
            descLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Location = new Point(264, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(32, 15);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "Title:";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(198, 68, 70);
            saveButton.BackgroundColor = Color.FromArgb(198, 68, 70);
            saveButton.BorderColor = Color.FromArgb(198, 68, 70);
            saveButton.BorderRadius = 20;
            saveButton.BorderSize = 0;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(236, 524);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(111, 28);
            saveButton.TabIndex = 9;
            saveButton.Text = "SAVE";
            saveButton.TextColor = Color.White;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // announcementCheckedBox
            // 
            announcementCheckedBox.AutoSize = true;
            announcementCheckedBox.BackColor = Color.Transparent;
            announcementCheckedBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            announcementCheckedBox.Location = new Point(191, 500);
            announcementCheckedBox.Margin = new Padding(3, 2, 3, 2);
            announcementCheckedBox.Name = "announcementCheckedBox";
            announcementCheckedBox.Size = new Size(15, 14);
            announcementCheckedBox.TabIndex = 8;
            announcementCheckedBox.TextAlign = ContentAlignment.MiddleCenter;
            announcementCheckedBox.UseVisualStyleBackColor = false;
            announcementCheckedBox.CheckedChanged += announcementCheckedBox_CheckedChanged_1;
            // 
            // announcementButton
            // 
            announcementButton.BackColor = Color.Transparent;
            announcementButton.FlatAppearance.BorderSize = 0;
            announcementButton.FlatStyle = FlatStyle.Flat;
            announcementButton.Location = new Point(186, 495);
            announcementButton.Margin = new Padding(3, 2, 3, 2);
            announcementButton.Name = "announcementButton";
            announcementButton.Size = new Size(215, 21);
            announcementButton.TabIndex = 7;
            announcementButton.Text = "Make it an announcement post";
            announcementButton.TextAlign = ContentAlignment.MiddleRight;
            announcementButton.UseVisualStyleBackColor = false;
            // 
            // fileLists
            // 
            fileLists.FormattingEnabled = true;
            fileLists.ItemHeight = 15;
            fileLists.Location = new Point(318, 315);
            fileLists.Margin = new Padding(3, 2, 3, 2);
            fileLists.Name = "fileLists";
            fileLists.Size = new Size(200, 169);
            fileLists.TabIndex = 5;
            fileLists.SelectedIndexChanged += fileLists_SelectedIndexChanged;
            // 
            // fileDropPanel
            // 
            fileDropPanel.Location = new Point(17, 283);
            fileDropPanel.Margin = new Padding(3, 2, 3, 2);
            fileDropPanel.Name = "fileDropPanel";
            fileDropPanel.Size = new Size(285, 200);
            fileDropPanel.TabIndex = 4;
            fileDropPanel.Paint += fileDropPanel_Paint;
            // 
            // fileButton
            // 
            fileButton.BackColor = Color.White;
            fileButton.BackgroundColor = Color.White;
            fileButton.BorderColor = Color.FromArgb(93, 49, 156);
            fileButton.BorderRadius = 20;
            fileButton.BorderSize = 2;
            fileButton.FlatAppearance.BorderSize = 0;
            fileButton.FlatStyle = FlatStyle.Flat;
            fileButton.ForeColor = Color.Black;
            fileButton.Location = new Point(326, 283);
            fileButton.Margin = new Padding(3, 2, 3, 2);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(178, 28);
            fileButton.TabIndex = 3;
            fileButton.Text = "Choose a file...";
            fileButton.TextColor = Color.Black;
            fileButton.UseVisualStyleBackColor = false;
            fileButton.Click += fileButton_Click;
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(113, 104);
            descTextBox.Margin = new Padding(3, 2, 3, 2);
            descTextBox.Multiline = true;
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(333, 146);
            descTextBox.TabIndex = 2;
            descTextBox.TextChanged += descTextBox_TextChanged;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(113, 53);
            titleTextBox.Margin = new Padding(3, 2, 3, 2);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(333, 23);
            titleTextBox.TabIndex = 1;
            titleTextBox.TextChanged += titleTextBox_TextChanged_1;
            // 
            // uploadLabel
            // 
            uploadLabel.AutoSize = true;
            uploadLabel.BackColor = Color.Transparent;
            uploadLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadLabel.ForeColor = Color.Black;
            uploadLabel.Location = new Point(250, 6);
            uploadLabel.Name = "uploadLabel";
            uploadLabel.Size = new Size(65, 20);
            uploadLabel.TabIndex = 0;
            uploadLabel.Text = "UPLOAD";
            // 
            // previewPanel
            // 
            previewPanel.BackColor = Color.White;
            previewPanel.BorderColor = Color.FromArgb(198, 68, 70);
            previewPanel.BorderRadius = 3;
            previewPanel.BorderSize = 2;
            previewPanel.BottomGradient = Color.White;
            previewPanel.Controls.Add(finalNoteUpload1);
            previewPanel.Controls.Add(previewLabel);
            previewPanel.ForeColor = Color.White;
            previewPanel.GradientAngle = 0F;
            previewPanel.Location = new Point(559, 2);
            previewPanel.Margin = new Padding(3, 2, 3, 2);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new Size(550, 558);
            previewPanel.TabIndex = 3;
            previewPanel.TopGradient = Color.White;
            previewPanel.Paint += previewPanel_Paint;
            // 
            // finalNoteUpload1
            // 
            finalNoteUpload1.BackColor = Color.FromArgb(141, 142, 196);
            finalNoteUpload1.Location = new Point(3, 277);
            finalNoteUpload1.Margin = new Padding(3, 2, 3, 2);
            finalNoteUpload1.Name = "finalNoteUpload1";
            finalNoteUpload1.Size = new Size(541, 279);
            finalNoteUpload1.TabIndex = 13;
            // 
            // previewLabel
            // 
            previewLabel.AutoSize = true;
            previewLabel.BackColor = Color.Transparent;
            previewLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            previewLabel.ForeColor = Color.Black;
            previewLabel.Location = new Point(257, 6);
            previewLabel.Name = "previewLabel";
            previewLabel.Size = new Size(69, 20);
            previewLabel.TabIndex = 1;
            previewLabel.Text = "PREVIEW";
            // 
            // FinalUpload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(previewPanel);
            Controls.Add(commentsPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FinalUpload";
            Size = new Size(1111, 562);
            commentsPanel.ResumeLayout(false);
            commentsPanel.PerformLayout();
            previewPanel.ResumeLayout(false);
            previewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Custom.PanelDesign commentsPanel;
        private TextBox descTextBox;
        private TextBox titleTextBox;
        private Label uploadLabel;
        private Custom.PanelDesign previewPanel;
        private Label previewLabel;
        private Custom.FinalCustomButton fileButton;
        private ListBox fileLists;
        private Panel fileDropPanel;
        private CheckBox announcementCheckedBox;
        private Button announcementButton;
        private Label titleLabel;
        private Custom.FinalCustomButton saveButton;
        private Label descLabel;
        private Label fileLabel;
        private FinalNoteUpload finalNoteUpload1;
    }
}
