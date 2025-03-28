namespace Classroom_Management_System
{
    partial class AdminFinalCreateClass
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
            formExpand = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            fileButton = new Custom.FinalCustomButton();
            FileNameLists = new ListBox();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            addSubjectButton = new Custom.FinalCustomButton();
            cancelButton = new ClassroomManagementSystem.Custom.CustomButton();
            createClassButton = new ClassroomManagementSystem.Custom.CustomButton();
            moreSubjectButton = new Custom.FinalCustomButton();
            addSubjectPanel = new Custom.PanelDesign();
            createSubject1 = new CreateSubject();
            label2 = new Label();
            singleFramePanel = new Custom.PanelDesign();
            doubleFramePanel = new Custom.PanelDesign();
            addSubjectPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formExpand
            // 
            formExpand.Tick += formExpand_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Create Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(58, 55);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 80);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 23);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(58, 110);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Icon:";
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
            fileButton.Location = new Point(88, 128);
            fileButton.Margin = new Padding(3, 2, 3, 2);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(178, 28);
            fileButton.TabIndex = 10;
            fileButton.Text = "Choose a file...";
            fileButton.TextColor = Color.Black;
            fileButton.UseVisualStyleBackColor = false;
            fileButton.Click += fileButton_Click;
            // 
            // FileNameLists
            // 
            FileNameLists.FormattingEnabled = true;
            FileNameLists.ItemHeight = 15;
            FileNameLists.Location = new Point(290, 132);
            FileNameLists.Margin = new Padding(3, 2, 3, 2);
            FileNameLists.Name = "FileNameLists";
            FileNameLists.Size = new Size(166, 19);
            FileNameLists.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Location = new Point(88, 172);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 134);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(58, 319);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "Preview:";
            // 
            // panel2
            // 
            panel2.Location = new Point(88, 350);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 43);
            panel2.TabIndex = 16;
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
            addSubjectButton.Location = new Point(158, 411);
            addSubjectButton.Margin = new Padding(3, 2, 3, 2);
            addSubjectButton.Name = "addSubjectButton";
            addSubjectButton.Size = new Size(205, 31);
            addSubjectButton.TabIndex = 17;
            addSubjectButton.Text = "+  Add Subject";
            addSubjectButton.TextColor = Color.Black;
            addSubjectButton.UseVisualStyleBackColor = false;
            addSubjectButton.Click += addSubjectButton_Click;
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
            cancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            cancelButton.Location = new Point(88, 465);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(116, 28);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += customButton1_Click;
            // 
            // createClassButton
            // 
            createClassButton.BackColor = Color.FromArgb(198, 68, 70);
            createClassButton.BorderRadius = 25;
            createClassButton.BorderSize = 0;
            createClassButton.FlatAppearance.BorderColor = Color.White;
            createClassButton.FlatAppearance.BorderSize = 0;
            createClassButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 68, 70);
            createClassButton.FlatStyle = FlatStyle.Flat;
            createClassButton.ForeColor = Color.White;
            createClassButton.ImageAlign = ContentAlignment.MiddleLeft;
            createClassButton.Location = new Point(328, 465);
            createClassButton.Margin = new Padding(3, 2, 3, 2);
            createClassButton.Name = "createClassButton";
            createClassButton.Size = new Size(128, 28);
            createClassButton.TabIndex = 19;
            createClassButton.Text = "CREATE CLASS";
            createClassButton.UseVisualStyleBackColor = false;
            createClassButton.Click += createClassButton_Click;
            // 
            // moreSubjectButton
            // 
            moreSubjectButton.BackColor = Color.Ivory;
            moreSubjectButton.BackgroundColor = Color.Ivory;
            moreSubjectButton.BorderColor = Color.FromArgb(93, 49, 156);
            moreSubjectButton.BorderRadius = 20;
            moreSubjectButton.BorderSize = 2;
            moreSubjectButton.FlatAppearance.BorderSize = 0;
            moreSubjectButton.FlatStyle = FlatStyle.Flat;
            moreSubjectButton.ForeColor = Color.Black;
            moreSubjectButton.ImageAlign = ContentAlignment.MiddleLeft;
            moreSubjectButton.Location = new Point(661, 462);
            moreSubjectButton.Margin = new Padding(3, 2, 3, 2);
            moreSubjectButton.Name = "moreSubjectButton";
            moreSubjectButton.Size = new Size(205, 31);
            moreSubjectButton.TabIndex = 21;
            moreSubjectButton.Text = "+  Add Subject";
            moreSubjectButton.TextColor = Color.Black;
            moreSubjectButton.UseVisualStyleBackColor = false;
            // 
            // addSubjectPanel
            // 
            addSubjectPanel.AutoScroll = true;
            addSubjectPanel.BackColor = Color.White;
            addSubjectPanel.BorderColor = Color.FromArgb(93, 49, 156);
            addSubjectPanel.BorderRadius = 3;
            addSubjectPanel.BorderSize = 3;
            addSubjectPanel.BottomGradient = Color.White;
            addSubjectPanel.Controls.Add(createSubject1);
            addSubjectPanel.ForeColor = Color.Black;
            addSubjectPanel.GradientAngle = 90F;
            addSubjectPanel.Location = new Point(502, 44);
            addSubjectPanel.Margin = new Padding(3, 2, 3, 2);
            addSubjectPanel.Name = "addSubjectPanel";
            addSubjectPanel.Size = new Size(520, 404);
            addSubjectPanel.TabIndex = 0;
            addSubjectPanel.TopGradient = Color.White;
            // 
            // createSubject1
            // 
            createSubject1.BackColor = Color.FromArgb(141, 142, 196);
            createSubject1.Location = new Point(3, 2);
            createSubject1.Margin = new Padding(3, 2, 3, 2);
            createSubject1.Name = "createSubject1";
            createSubject1.Size = new Size(514, 400);
            createSubject1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(715, 15);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 22;
            label2.Text = "Create Subject";
            // 
            // singleFramePanel
            // 
            singleFramePanel.BackColor = Color.White;
            singleFramePanel.BorderColor = Color.MidnightBlue;
            singleFramePanel.BorderRadius = 3;
            singleFramePanel.BorderSize = 3;
            singleFramePanel.BottomGradient = Color.FromArgb(141, 142, 196);
            singleFramePanel.ForeColor = Color.White;
            singleFramePanel.GradientAngle = 90F;
            singleFramePanel.Location = new Point(0, 1);
            singleFramePanel.Margin = new Padding(3, 2, 3, 2);
            singleFramePanel.MaximumSize = new Size(1030, 518);
            singleFramePanel.MinimumSize = new Size(498, 518);
            singleFramePanel.Name = "singleFramePanel";
            singleFramePanel.Size = new Size(498, 518);
            singleFramePanel.TabIndex = 24;
            singleFramePanel.TopGradient = Color.FromArgb(141, 142, 196);
            singleFramePanel.Paint += singleFramePanel_Paint;
            // 
            // doubleFramePanel
            // 
            doubleFramePanel.BackColor = Color.White;
            doubleFramePanel.BorderColor = Color.MidnightBlue;
            doubleFramePanel.BorderRadius = 3;
            doubleFramePanel.BorderSize = 3;
            doubleFramePanel.BottomGradient = Color.FromArgb(141, 142, 196);
            doubleFramePanel.ForeColor = Color.White;
            doubleFramePanel.GradientAngle = 90F;
            doubleFramePanel.Location = new Point(2, 1);
            doubleFramePanel.Margin = new Padding(3, 2, 3, 2);
            doubleFramePanel.MaximumSize = new Size(1030, 518);
            doubleFramePanel.MinimumSize = new Size(498, 518);
            doubleFramePanel.Name = "doubleFramePanel";
            doubleFramePanel.Size = new Size(1030, 518);
            doubleFramePanel.TabIndex = 25;
            doubleFramePanel.TopGradient = Color.FromArgb(141, 142, 196);
            // 
            // AdminFinalCreateClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            ClientSize = new Size(499, 519);
            Controls.Add(label2);
            Controls.Add(addSubjectPanel);
            Controls.Add(moreSubjectButton);
            Controls.Add(createClassButton);
            Controls.Add(cancelButton);
            Controls.Add(addSubjectButton);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(FileNameLists);
            Controls.Add(fileButton);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(singleFramePanel);
            Controls.Add(doubleFramePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1032, 519);
            MinimizeBox = false;
            MinimumSize = new Size(499, 519);
            Name = "AdminFinalCreateClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFinalCreateClass";
            addSubjectPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer formExpand;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Custom.FinalCustomButton fileButton;
        private ListBox FileNameLists;
        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Custom.FinalCustomButton addSubjectButton;
        private ClassroomManagementSystem.Custom.CustomButton cancelButton;
        private ClassroomManagementSystem.Custom.CustomButton createClassButton;
        private Custom.FinalCustomButton moreSubjectButton;
        private Custom.PanelDesign addSubjectPanel;
        private CreateSubject createSubject1;
        private Label label2;
        private Custom.PanelDesign singleFramePanel;
        private Custom.PanelDesign doubleFramePanel;
    }
}