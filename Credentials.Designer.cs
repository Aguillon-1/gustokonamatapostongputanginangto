namespace Classroom_Management_System
{
    partial class Credentials
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
            label1 = new Label();
            label2 = new Label();
            customButton1 = new ClassroomManagementSystem.Custom.CustomButton();
            customButton2 = new ClassroomManagementSystem.Custom.CustomButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 55);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "ACCESS ROLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 107);
            label2.Name = "label2";
            label2.Size = new Size(248, 30);
            label2.TabIndex = 1;
            label2.Text = "Choose your profession.";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(28, 189, 158);
            customButton1.BorderRadius = 25;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderColor = Color.White;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 189, 158);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(88, 182);
            customButton1.Margin = new Padding(3, 2, 3, 2);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(181, 42);
            customButton1.TabIndex = 2;
            customButton1.Text = "STUDENT";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(30, 38, 51);
            customButton2.BorderRadius = 25;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderColor = Color.White;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(346, 182);
            customButton2.Margin = new Padding(3, 2, 3, 2);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(181, 42);
            customButton2.TabIndex = 3;
            customButton2.Text = "PROFESSOR";
            customButton2.UseVisualStyleBackColor = false;
            // 
            // Credentials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.container;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Credentials";
            Size = new Size(604, 273);
            Load += Credentials_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ClassroomManagementSystem.Custom.CustomButton customButton1;
        private ClassroomManagementSystem.Custom.CustomButton customButton2;
    }
}
