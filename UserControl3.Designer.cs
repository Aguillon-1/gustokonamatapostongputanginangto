namespace Classroom_Management_System
{
    partial class UserControl3
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
            dailys = new Label();
            SuspendLayout();
            // 
            // dailys
            // 
            dailys.AutoSize = true;
            dailys.Location = new Point(3, 0);
            dailys.Name = "dailys";
            dailys.Size = new Size(19, 15);
            dailys.TabIndex = 0;
            dailys.Text = "00";
            dailys.Click += label1_Click;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dailys);
            Name = "UserControl3";
            Size = new Size(129, 63);
            Load += UserControl3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dailys;
    }
}
