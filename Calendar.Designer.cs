namespace Classroom_Management_System
{
    partial class Calendar
    {
        private System.ComponentModel.IContainer components = null;
        private CalendarControl calendarControl1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.calendarControl1 = new Classroom_Management_System.CalendarControl();
            this.SuspendLayout();
            // 
            // calendarControl1
            // 
            this.calendarControl1.Location = new System.Drawing.Point(3, 12);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(1009, 460);
            this.calendarControl1.TabIndex = 0;
            this.calendarControl1.Load += new System.EventHandler(this.calendarControl1_Load);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 524);
            this.Controls.Add(this.calendarControl1);
            this.Name = "Calendar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
        }
    }
}