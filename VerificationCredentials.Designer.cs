namespace Classroom_Management_System
{
    partial class VerificationCredentials
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
            fullnameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.BackColor = Color.Transparent;
            fullnameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullnameLabel.Location = new Point(140, 91);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(128, 25);
            fullnameLabel.TabIndex = 20;
            fullnameLabel.Text = "Email Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 156);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 21;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 217);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 22;
            label2.Text = "Reconfirm Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(292, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 27);
            textBox3.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 15);
            label3.Name = "label3";
            label3.Size = new Size(462, 28);
            label3.TabIndex = 26;
            label3.Text = "For easier signing in, please fill out the following:";
            // 
            // VerificationCredentials
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.container;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fullnameLabel);
            Name = "VerificationCredentials";
            Size = new Size(690, 335);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullnameLabel;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
    }
}
