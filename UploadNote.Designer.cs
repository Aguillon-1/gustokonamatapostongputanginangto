namespace Classroom_Management_System
{
    partial class UploadNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadNote));
            uploadLabel = new Label();
            selectFileButton = new Button();
            submitButton = new ClassroomManagementSystem.Custom.CustomButton();
            dragAndDropDownPanel = new Panel();
            displayButton = new Button();
            FileLists = new ListBox();
            tagLabel = new Label();
            tagsTextBox = new TextBox();
            Tags = new ListBox();
            sendTagButton = new Button();
            cancelButton = new ClassroomManagementSystem.Custom.CustomButton();
            dragAndDropDownPanel.SuspendLayout();
            SuspendLayout();
            // 
            // uploadLabel
            // 
            uploadLabel.AutoSize = true;
            uploadLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uploadLabel.Location = new Point(269, 11);
            uploadLabel.Name = "uploadLabel";
            uploadLabel.Size = new Size(89, 28);
            uploadLabel.TabIndex = 0;
            uploadLabel.Text = "UPLOAD";
            // 
            // selectFileButton
            // 
            selectFileButton.BackColor = Color.FromArgb(44, 56, 75);
            selectFileButton.BackgroundImage = Properties.Resources.container;
            selectFileButton.ForeColor = SystemColors.ActiveCaptionText;
            selectFileButton.Location = new Point(420, 58);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(135, 37);
            selectFileButton.TabIndex = 1;
            selectFileButton.Text = "Select a file";
            selectFileButton.UseVisualStyleBackColor = false;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(30, 38, 51);
            submitButton.FlatAppearance.BorderColor = Color.White;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(472, 406);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(122, 39);
            submitButton.TabIndex = 2;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // dragAndDropDownPanel
            // 
            dragAndDropDownPanel.AllowDrop = true;
            dragAndDropDownPanel.BackColor = Color.Transparent;
            dragAndDropDownPanel.BackgroundImage = Properties.Resources.container;
            dragAndDropDownPanel.BorderStyle = BorderStyle.FixedSingle;
            dragAndDropDownPanel.Controls.Add(displayButton);
            dragAndDropDownPanel.Location = new Point(35, 58);
            dragAndDropDownPanel.Name = "dragAndDropDownPanel";
            dragAndDropDownPanel.Size = new Size(314, 229);
            dragAndDropDownPanel.TabIndex = 3;
            dragAndDropDownPanel.DragDrop += dragAndDropDownPanel_DragDrop;
            dragAndDropDownPanel.DragEnter += dragAndDropDownPanel_DragEnter;
            dragAndDropDownPanel.DragLeave += dragAndDropDownPanel_DragLeave;
            // 
            // displayButton
            // 
            displayButton.BackColor = Color.Transparent;
            displayButton.Enabled = false;
            displayButton.FlatAppearance.BorderSize = 0;
            displayButton.FlatStyle = FlatStyle.Flat;
            displayButton.Image = (Image)resources.GetObject("displayButton.Image");
            displayButton.Location = new Point(57, 56);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(197, 111);
            displayButton.TabIndex = 0;
            displayButton.Text = "Drag and drop the files here.";
            displayButton.TextImageRelation = TextImageRelation.ImageAboveText;
            displayButton.UseVisualStyleBackColor = false;
            // 
            // FileLists
            // 
            FileLists.FormattingEnabled = true;
            FileLists.Location = new Point(372, 101);
            FileLists.Name = "FileLists";
            FileLists.Size = new Size(222, 184);
            FileLists.TabIndex = 4;
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new Point(30, 312);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(198, 20);
            tagLabel.TabIndex = 5;
            tagLabel.Text = "Tag/s (up to three tags only):";
            // 
            // tagsTextBox
            // 
            tagsTextBox.Location = new Point(251, 309);
            tagsTextBox.Name = "tagsTextBox";
            tagsTextBox.Size = new Size(258, 27);
            tagsTextBox.TabIndex = 6;
            tagsTextBox.Text = "#";
            // 
            // Tags
            // 
            Tags.FormattingEnabled = true;
            Tags.Location = new Point(35, 360);
            Tags.MultiColumn = true;
            Tags.Name = "Tags";
            Tags.Size = new Size(559, 24);
            Tags.TabIndex = 7;
            // 
            // sendTagButton
            // 
            sendTagButton.BackgroundImage = Properties.Resources.container;
            sendTagButton.Image = (Image)resources.GetObject("sendTagButton.Image");
            sendTagButton.Location = new Point(524, 305);
            sendTagButton.Name = "sendTagButton";
            sendTagButton.Size = new Size(69, 36);
            sendTagButton.TabIndex = 8;
            sendTagButton.UseVisualStyleBackColor = true;
            sendTagButton.Click += sendTagButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(30, 38, 51);
            cancelButton.FlatAppearance.BorderColor = Color.White;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(338, 406);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(118, 39);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += customButton1_Click;
            // 
            // UploadNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cancelButton);
            Controls.Add(sendTagButton);
            Controls.Add(Tags);
            Controls.Add(tagsTextBox);
            Controls.Add(tagLabel);
            Controls.Add(FileLists);
            Controls.Add(dragAndDropDownPanel);
            Controls.Add(submitButton);
            Controls.Add(selectFileButton);
            Controls.Add(uploadLabel);
            MaximumSize = new Size(612, 460);
            MinimumSize = new Size(612, 460);
            Name = "UploadNote";
            Size = new Size(612, 460);
            dragAndDropDownPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uploadLabel;
        private Button selectFileButton;
        private ClassroomManagementSystem.Custom.CustomButton submitButton;
        private Panel dragAndDropDownPanel;
        private ListBox FileLists;
        private Label tagLabel;
        private TextBox tagsTextBox;
        private ListBox Tags;
        private Button displayButton;
        private Button sendTagButton;
        private ClassroomManagementSystem.Custom.CustomButton cancelButton;
    }
}
