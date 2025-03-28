namespace Classroom_Management_System
{
    partial class CalendarAddEvent
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblSelectedDate;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;

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
            this.lblSelectedDate = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.button1 = new Button();
            this.SuspendLayout();
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Location = new System.Drawing.Point(12, 9);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(89, 13);
            this.lblSelectedDate.TabIndex = 0;
            this.lblSelectedDate.Text = "Selected Date: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 100);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalendarAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSelectedDate);
            this.Name = "CalendarAddEvent";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.CalendarAddEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}