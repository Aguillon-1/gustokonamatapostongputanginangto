namespace Classroom_Management_System
{
    partial class AdminHomeForm
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
            foldMenuBarTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // foldMenuBarTimer
            // 
   
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InsideBackground;
            ClientSize = new Size(1518, 817);
            MaximizeBox = false;
            MaximumSize = new Size(1536, 864);
            MinimizeBox = false;
            MinimumSize = new Size(1536, 864);
            Name = "AdminHomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ClassroomManagementSystem.Custom.GreyTransparentPanel greyTransparentPanel1;
        private ClassroomManagementSystem.Custom.CustomButton homeButton;
        private ClassroomManagementSystem.Custom.CustomButton notifButton;
        private ClassroomManagementSystem.Custom.CustomButton userButton;
        private ClassroomManagementSystem.Custom.CustomButton logOutButton;
        private System.Windows.Forms.Timer foldMenuBarTimer;
        private ClassroomManagementSystem.Custom.CustomButton addSubjectButton;
        private ClassroomManagementSystem.Custom.CustomButton createButton;
    }
}