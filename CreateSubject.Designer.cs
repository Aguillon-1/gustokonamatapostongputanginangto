namespace Classroom_Management_System
{
    partial class CreateSubject
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
            label3 = new Label();
            subjectNameTextBox = new TextBox();
            label2 = new Label();
            professorNameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            fileButton = new Custom.FinalCustomButton();
            panel1 = new Panel();
            listBox1 = new ListBox();
            label6 = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(66, 14);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Name:";
            // 
            // subjectNameTextBox
            // 
            subjectNameTextBox.Location = new Point(107, 34);
            subjectNameTextBox.Margin = new Padding(3, 2, 3, 2);
            subjectNameTextBox.Name = "subjectNameTextBox";
            subjectNameTextBox.Size = new Size(336, 23);
            subjectNameTextBox.TabIndex = 6;
            subjectNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(71, 117);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // professorNameTextBox
            // 
            professorNameTextBox.Location = new Point(109, 82);
            professorNameTextBox.Margin = new Padding(3, 2, 3, 2);
            professorNameTextBox.Name = "professorNameTextBox";
            professorNameTextBox.Size = new Size(336, 23);
            professorNameTextBox.TabIndex = 18;
            professorNameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(66, 61);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 19;
            label4.Text = "Professor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(66, 110);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 20;
            label5.Text = "Icon:";
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
            fileButton.Location = new Point(80, 129);
            fileButton.Margin = new Padding(3, 2, 3, 2);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(178, 28);
            fileButton.TabIndex = 21;
            fileButton.Text = "Choose a file...";
            fileButton.TextColor = Color.Black;
            fileButton.UseVisualStyleBackColor = false;
            fileButton.Click += fileButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(80, 169);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 134);
            panel1.TabIndex = 22;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(282, 133);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(166, 19);
            listBox1.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(69, 312);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 24;
            label6.Text = "Preview:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(78, 340);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 43);
            panel2.TabIndex = 25;
            // 
            // CreateSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(141, 142, 196);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(fileButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(professorNameTextBox);
            Controls.Add(label2);
            Controls.Add(subjectNameTextBox);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateSubject";
            Size = new Size(516, 396);
            Load += CreateSubject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox subjectNameTextBox;
        private Label label2;
        private TextBox professorNameTextBox;
        private Label label4;
        private Label label5;
        private Custom.FinalCustomButton fileButton;
        private Panel panel1;
        private ListBox listBox1;
        private Label label6;
        private Panel panel2;
    }
}
