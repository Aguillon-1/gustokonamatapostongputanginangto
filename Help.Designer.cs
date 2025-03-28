namespace Classroom_Management_System
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            HelpLabel = new Label();
            IrregularPanel = new ClassroomManagementSystem.Custom.GreyTransparentPanel();
            FileName = new ListBox();
            customButton1 = new ClassroomManagementSystem.Custom.CustomButton();
            label8 = new Label();
            dropfilesPanel = new Panel();
            browseButton = new ClassroomManagementSystem.Custom.CustomButton();
            label7 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel4 = new Panel();
            label9 = new Label();
            IrregularPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // HelpLabel
            // 
            HelpLabel.AutoSize = true;
            HelpLabel.BackColor = Color.Transparent;
            HelpLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpLabel.Location = new Point(29, 19);
            HelpLabel.Margin = new Padding(2, 0, 2, 0);
            HelpLabel.Name = "HelpLabel";
            HelpLabel.Size = new Size(93, 36);
            HelpLabel.TabIndex = 6;
            HelpLabel.Text = "HELP";
            // 
            // IrregularPanel
            // 
            IrregularPanel.BackColor = Color.FromArgb(28, 189, 158);
            IrregularPanel.Controls.Add(panel4);
            IrregularPanel.Controls.Add(panel3);
            IrregularPanel.Controls.Add(panel2);
            IrregularPanel.Controls.Add(panel1);
            IrregularPanel.Location = new Point(82, 69);
            IrregularPanel.Name = "IrregularPanel";
            IrregularPanel.Size = new Size(972, 550);
            IrregularPanel.TabIndex = 8;
            // 
            // FileName
            // 
            FileName.FormattingEnabled = true;
            FileName.Location = new Point(198, 149);
            FileName.Name = "FileName";
            FileName.Size = new Size(265, 24);
            FileName.TabIndex = 14;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(30, 38, 51);
            customButton1.FlatAppearance.BorderColor = Color.White;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(660, 240);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(155, 46);
            customButton1.TabIndex = 13;
            customButton1.Text = "SUBMIT";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 149);
            label8.Name = "label8";
            label8.Size = new Size(163, 23);
            label8.TabIndex = 11;
            label8.Text = "Proof of Enrollment:";
            // 
            // dropfilesPanel
            // 
            dropfilesPanel.AllowDrop = true;
            dropfilesPanel.BackColor = Color.White;
            dropfilesPanel.BackgroundImageLayout = ImageLayout.Center;
            dropfilesPanel.Location = new Point(534, 6);
            dropfilesPanel.Name = "dropfilesPanel";
            dropfilesPanel.Size = new Size(382, 216);
            dropfilesPanel.TabIndex = 12;
            dropfilesPanel.DragDrop += panel4_DragDrop;
            dropfilesPanel.DragEnter += dropfilesPanel_DragEnter;
            dropfilesPanel.Paint += dropfilesPanel_Paint;
            // 
            // browseButton
            // 
            browseButton.BackColor = Color.White;
            browseButton.FlatAppearance.BorderColor = Color.White;
            browseButton.FlatAppearance.BorderSize = 2;
            browseButton.FlatAppearance.MouseOverBackColor = Color.White;
            browseButton.FlatStyle = FlatStyle.Flat;
            browseButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browseButton.ForeColor = Color.Black;
            browseButton.Location = new Point(146, 227);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(203, 34);
            browseButton.TabIndex = 0;
            browseButton.Text = "Select a file...";
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Click += customButton2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 3);
            label7.Name = "label7";
            label7.Size = new Size(229, 25);
            label7.TabIndex = 10;
            label7.Text = "Please fill out the following:";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(972, 106);
            panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(345, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 49);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 70);
            label1.Name = "label1";
            label1.Size = new Size(314, 20);
            label1.TabIndex = 9;
            label1.Text = "Congressional Rd Ext, Barangay 171, Caloocan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 18);
            label3.Name = "label3";
            label3.Size = new Size(748, 23);
            label3.TabIndex = 8;
            label3.Text = "You could also visit the MIS on the third floor of University of Caloocan City -- Congress Campus.";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 98);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 99);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(116, 50);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(972, 78);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 13);
            label4.Name = "label4";
            label4.Size = new Size(495, 50);
            label4.TabIndex = 1;
            label4.Text = "   For irregular students, you can send a request to the admin\r\nto unlock access in adding your subjects individually.";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 63);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(381, 14);
            label2.Name = "label2";
            label2.Size = new Size(194, 31);
            label2.TabIndex = 0;
            label2.Text = "IRREGULAR ROLE";
            label2.Click += label2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(browseButton);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(FileName);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(customButton1);
            panel4.Controls.Add(dropfilesPanel);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(textBox2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(972, 303);
            panel4.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 189);
            label9.Name = "label9";
            label9.Size = new Size(336, 20);
            label9.TabIndex = 15;
            label9.Text = "You can choose to either method to upload a file.";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.container;
            Controls.Add(IrregularPanel);
            Controls.Add(HelpLabel);
            MaximumSize = new Size(1107, 645);
            MinimumSize = new Size(1107, 645);
            Name = "Help";
            Size = new Size(1107, 645);
            IrregularPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelpLabel;
        private ClassroomManagementSystem.Custom.GreyTransparentPanel IrregularPanel;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private TextBox textBox2;
        private Label label7;
        private Panel panel3;
        private Label label3;
        private Label label8;
        private Panel dropfilesPanel;
        private OpenFileDialog openFileDialog1;
        private ClassroomManagementSystem.Custom.CustomButton customButton1;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox FileName;
        private ClassroomManagementSystem.Custom.CustomButton browseButton;
        private Panel panel4;
        private Label label9;
    }
}
