namespace Classroom_Management_System
{
    partial class FinalAnnouncement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            announcementLabel = new Label();
            announcementPanel = new Panel();
            label1 = new Label();
            announcementPanel.SuspendLayout();
            SuspendLayout();
            // 
            // announcementLabel
            // 
            announcementLabel.AutoSize = true;
            announcementLabel.Location = new Point(12, 11);
            announcementLabel.Name = "announcementLabel";
            announcementLabel.Size = new Size(105, 15);
            announcementLabel.TabIndex = 1;
            announcementLabel.Text = "ANNOUNCEMENT";
            // 
            // announcementPanel
            // 
            announcementPanel.Controls.Add(announcementLabel);
            announcementPanel.Controls.Add(label1);
            announcementPanel.Location = new Point(31, 39);
            announcementPanel.Name = "announcementPanel";
            announcementPanel.Size = new Size(839, 233);
            announcementPanel.TabIndex = 3;
            announcementPanel.Paint += announcementPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 39);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // FinalAnnouncement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 215, 223);
            Controls.Add(announcementPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FinalAnnouncement";
            Size = new Size(890, 390);
            Load += FinalAnnouncement_Load;
            announcementPanel.ResumeLayout(false);
            announcementPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label announcementLabel;
        private System.Windows.Forms.Panel announcementPanel;
        private System.Windows.Forms.Label label1;
    }
}