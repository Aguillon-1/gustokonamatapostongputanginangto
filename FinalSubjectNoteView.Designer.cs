namespace Classroom_Management_System
{
    partial class FinalSubjectNoteView
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
            previewPanel = new Custom.PanelDesign();
            commentsPanel = new Custom.PanelDesign();
            titlePanel = new Custom.PanelDesign();
            descPanel = new Custom.PanelDesign();
            filesPanel = new Custom.PanelDesign();
            exitButton = new Button();
            previewLabel = new Label();
            titleLabel = new Label();
            descLabel = new Label();
            filesLabel = new Label();
            commentsLabel = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            titleName = new Label();
            fullDesc = new Label();
            fileList = new ListBox();
            commentsPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            descPanel.SuspendLayout();
            filesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // previewPanel
            // 
            previewPanel.BackColor = Color.White;
            previewPanel.BackgroundImageLayout = ImageLayout.Center;
            previewPanel.BorderColor = Color.FromArgb(198, 68, 70);
            previewPanel.BorderRadius = 3;
            previewPanel.BorderSize = 2;
            previewPanel.BottomGradient = Color.White;
            previewPanel.ForeColor = Color.White;
            previewPanel.GradientAngle = 0F;
            previewPanel.Location = new Point(20, 37);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new Size(448, 686);
            previewPanel.TabIndex = 0;
            previewPanel.TopGradient = Color.White;
            // 
            // commentsPanel
            // 
            commentsPanel.BackColor = Color.White;
            commentsPanel.BorderColor = Color.FromArgb(93, 49, 156);
            commentsPanel.BorderRadius = 3;
            commentsPanel.BorderSize = 2;
            commentsPanel.BottomGradient = Color.White;
            commentsPanel.Controls.Add(button1);
            commentsPanel.Controls.Add(textBox1);
            commentsPanel.Controls.Add(pictureBox1);
            commentsPanel.ForeColor = Color.White;
            commentsPanel.GradientAngle = 0F;
            commentsPanel.Location = new Point(807, 37);
            commentsPanel.Name = "commentsPanel";
            commentsPanel.Size = new Size(448, 686);
            commentsPanel.TabIndex = 1;
            commentsPanel.TopGradient = Color.White;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.White;
            titlePanel.BorderColor = Color.FromArgb(52, 90, 67);
            titlePanel.BorderRadius = 3;
            titlePanel.BorderSize = 2;
            titlePanel.BottomGradient = Color.White;
            titlePanel.Controls.Add(titleName);
            titlePanel.ForeColor = Color.White;
            titlePanel.GradientAngle = 0F;
            titlePanel.Location = new Point(474, 37);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(327, 103);
            titlePanel.TabIndex = 1;
            titlePanel.TopGradient = Color.White;
            // 
            // descPanel
            // 
            descPanel.BackColor = Color.White;
            descPanel.BorderColor = Color.FromArgb(52, 90, 67);
            descPanel.BorderRadius = 3;
            descPanel.BorderSize = 2;
            descPanel.BottomGradient = Color.White;
            descPanel.Controls.Add(fullDesc);
            descPanel.ForeColor = Color.White;
            descPanel.GradientAngle = 0F;
            descPanel.Location = new Point(474, 177);
            descPanel.Name = "descPanel";
            descPanel.Size = new Size(327, 250);
            descPanel.TabIndex = 2;
            descPanel.TopGradient = Color.White;
            // 
            // filesPanel
            // 
            filesPanel.BackColor = Color.White;
            filesPanel.BorderColor = Color.FromArgb(52, 90, 67);
            filesPanel.BorderRadius = 3;
            filesPanel.BorderSize = 2;
            filesPanel.BottomGradient = Color.White;
            filesPanel.Controls.Add(fileList);
            filesPanel.ForeColor = Color.White;
            filesPanel.GradientAngle = 0F;
            filesPanel.Location = new Point(474, 466);
            filesPanel.Name = "filesPanel";
            filesPanel.Size = new Size(327, 257);
            filesPanel.TabIndex = 3;
            filesPanel.TopGradient = Color.White;
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = Properties.Resources.Cross;
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(1234, 1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(33, 30);
            exitButton.TabIndex = 4;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button1_Click;
            // 
            // previewLabel
            // 
            previewLabel.AutoSize = true;
            previewLabel.Location = new Point(211, 11);
            previewLabel.Name = "previewLabel";
            previewLabel.Size = new Size(69, 20);
            previewLabel.TabIndex = 5;
            previewLabel.Text = "PREVIEW";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(620, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(44, 20);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "TITLE";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(590, 150);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(100, 20);
            descLabel.TabIndex = 7;
            descLabel.Text = "DESCRIPTION";
            // 
            // filesLabel
            // 
            filesLabel.AutoSize = true;
            filesLabel.Location = new Point(618, 438);
            filesLabel.Name = "filesLabel";
            filesLabel.Size = new Size(43, 20);
            filesLabel.TabIndex = 8;
            filesLabel.Text = "FILES";
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Location = new Point(1001, 11);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new Size(90, 20);
            commentsLabel.TabIndex = 9;
            commentsLabel.Text = "COMMENTS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userplaceholder;
            pictureBox1.Location = new Point(12, 604);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(95, 604);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Send a comment...";
            textBox1.Size = new Size(268, 64);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.finalsendIcon;
            button1.Location = new Point(372, 612);
            button1.Name = "button1";
            button1.Size = new Size(59, 47);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            // 
            // titleName
            // 
            titleName.AutoSize = true;
            titleName.ForeColor = Color.Black;
            titleName.Location = new Point(15, 10);
            titleName.Name = "titleName";
            titleName.Size = new Size(35, 20);
            titleName.TabIndex = 0;
            titleName.Text = "title";
            titleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fullDesc
            // 
            fullDesc.AutoSize = true;
            fullDesc.ForeColor = Color.Black;
            fullDesc.Location = new Point(15, 15);
            fullDesc.Name = "fullDesc";
            fullDesc.Size = new Size(39, 20);
            fullDesc.TabIndex = 1;
            fullDesc.Text = "desc";
            fullDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fileList
            // 
            fileList.BorderStyle = BorderStyle.None;
            fileList.FormattingEnabled = true;
            fileList.Location = new Point(12, 8);
            fileList.Name = "fileList";
            fileList.Size = new Size(303, 240);
            fileList.TabIndex = 0;
            // 
            // FinalSubjectNoteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 215, 223);
            Controls.Add(commentsLabel);
            Controls.Add(filesLabel);
            Controls.Add(descLabel);
            Controls.Add(titleLabel);
            Controls.Add(previewLabel);
            Controls.Add(exitButton);
            Controls.Add(filesPanel);
            Controls.Add(descPanel);
            Controls.Add(titlePanel);
            Controls.Add(commentsPanel);
            Controls.Add(previewPanel);
            Name = "FinalSubjectNoteView";
            Size = new Size(1270, 750);
            commentsPanel.ResumeLayout(false);
            commentsPanel.PerformLayout();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            descPanel.ResumeLayout(false);
            descPanel.PerformLayout();
            filesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom.PanelDesign previewPanel;
        private Custom.PanelDesign commentsPanel;
        private Custom.PanelDesign titlePanel;
        private Custom.PanelDesign descPanel;
        private Custom.PanelDesign filesPanel;
        private Button exitButton;
        private Label previewLabel;
        private Label titleLabel;
        private Label descLabel;
        private Label filesLabel;
        private Label commentsLabel;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label titleName;
        private Label fullDesc;
        private ListBox fileList;
    }
}
