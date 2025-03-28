namespace Classroom_Management_System
{
    partial class FinalSubjectNoteSearch
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
            textBox1 = new TextBox();
            searchTopPanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            searchResultFormat1 = new searchResultFormat();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            finalSubjectNoteView1 = new FinalSubjectNoteView();
            exitButton = new Button();
            searchTopPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // subjectsLabel
            // 
            subjectsLabel.AutoSize = true;
            subjectsLabel.Location = new Point(32, 23);
            subjectsLabel.Name = "subjectsLabel";
            subjectsLabel.Size = new Size(117, 20);
            subjectsLabel.TabIndex = 3;
            subjectsLabel.Text = "SUBJECTS/NOTE";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(636, 27);
            textBox1.TabIndex = 4;
            // 
            // searchTopPanel
            // 
            searchTopPanel.BackColor = Color.Transparent;
            searchTopPanel.Controls.Add(button1);
            searchTopPanel.Controls.Add(textBox1);
            searchTopPanel.Location = new Point(320, 78);
            searchTopPanel.Name = "searchTopPanel";
            searchTopPanel.Size = new Size(673, 39);
            searchTopPanel.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = Properties.Resources.Search_Icon;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(639, 2);
            button1.Name = "button1";
            button1.Size = new Size(32, 27);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 136);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "TAGS:";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(217, 217, 217);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(257, 171);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(794, 20);
            listBox1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(searchResultFormat1);
            panel1.Location = new Point(198, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 486);
            panel1.TabIndex = 8;
            // 
            // searchResultFormat1
            // 
            searchResultFormat1.Location = new Point(3, 47);
            searchResultFormat1.Name = "searchResultFormat1";
            searchResultFormat1.Size = new Size(892, 45);
            searchResultFormat1.TabIndex = 0;
            searchResultFormat1.Load += searchResultFormat1_Load;
            searchResultFormat1.Click += searchResultFormat1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(198, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 44);
            panel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(808, 11);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 2;
            label4.Text = "DATE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 11);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 1;
            label3.Text = "DESCRIPTION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 11);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "TITLE";
            // 
            // finalSubjectNoteView1
            // 
            finalSubjectNoteView1.BackColor = Color.FromArgb(223, 215, 223);
            finalSubjectNoteView1.Location = new Point(0, 0);
            finalSubjectNoteView1.Name = "finalSubjectNoteView1";
            finalSubjectNoteView1.Size = new Size(1588, 938);
            finalSubjectNoteView1.TabIndex = 10;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.BackgroundImage = Properties.Resources.Cross;
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(1237, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(33, 30);
            exitButton.TabIndex = 11;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // FinalSubjectNoteSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            Controls.Add(exitButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(searchTopPanel);
            Controls.Add(subjectsLabel);
            Controls.Add(finalSubjectNoteView1);
            Name = "FinalSubjectNoteSearch";
            Size = new Size(1270, 750);
            searchTopPanel.ResumeLayout(false);
            searchTopPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subjectsLabel;
        private TextBox textBox1;
        private Panel searchTopPanel;
        private Button button1;
        private Label label1;
        private ListBox listBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private searchResultFormat searchResultFormat1;
        private FinalSubjectNoteView finalSubjectNoteView1;
        private Button exitButton;
    }
}
