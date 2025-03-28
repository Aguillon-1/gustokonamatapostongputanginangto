namespace Classroom_Management_System
{
    partial class classMembers
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
            classMemberName = new Label();
            userPicture = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            SuspendLayout();
            // 
            // classMemberName
            // 
            classMemberName.AutoSize = true;
            classMemberName.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classMemberName.Location = new Point(54, 18);
            classMemberName.Name = "classMemberName";
            classMemberName.Size = new Size(43, 17);
            classMemberName.TabIndex = 0;
            classMemberName.Text = "Name";
            classMemberName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userPicture
            // 
            userPicture.BackColor = Color.Transparent;
            userPicture.BackgroundImage = Properties.Resources.UserCircle;
            userPicture.BackgroundImageLayout = ImageLayout.Center;
            userPicture.Location = new Point(4, 4);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(47, 43);
            userPicture.TabIndex = 2;
            userPicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(93, 49, 156);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 3);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(93, 49, 156);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 3);
            panel2.TabIndex = 4;
            // 
            // classMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(userPicture);
            Controls.Add(classMemberName);
            Controls.Add(panel1);
            Name = "classMembers";
            Size = new Size(277, 53);
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classMemberName;
        private PictureBox userPicture;
        private Panel panel1;
        private Panel panel2;
    }
}
