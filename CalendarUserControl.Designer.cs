namespace Classroom_Management_System
{
    partial class CalendarControl
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
            daycontainer = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Date1 = new Label();
            SuspendLayout();
            // 
            // daycontainer
            // 
            daycontainer.BackColor = SystemColors.ActiveCaption;
            daycontainer.Location = new Point(21, 67);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(962, 361);
            daycontainer.TabIndex = 0;
            daycontainer.Paint += flowLayoutPanel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(795, 434);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(908, 434);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 9.75F);
            label1.Location = new Point(58, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "SUNDAY";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 9.75F);
            label2.Location = new Point(190, 49);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "MONDAY";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 9.75F);
            label3.Location = new Point(326, 49);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "TUESDAY";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 9.75F);
            label4.Location = new Point(451, 49);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 6;
            label4.Text = "WEDNESDAY";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 9.75F);
            label5.Location = new Point(593, 49);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 7;
            label5.Text = "THURSDAY";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 9.75F);
            label6.Location = new Point(738, 49);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "FRIDAY";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 9.75F);
            label7.Location = new Point(861, 49);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 9;
            label7.Text = "SATURDAY";
            label7.Click += label7_Click;
            // 
            // Date1
            // 
            Date1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date1.Location = new Point(340, 10);
            Date1.Name = "Date1";
            Date1.Size = new Size(355, 39);
            Date1.TabIndex = 10;
            Date1.Text = "MONTH YEAR";
            Date1.TextAlign = ContentAlignment.TopCenter;
            Date1.Click += Date1_Click;
            // 
            // CalendarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Date1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(daycontainer);
            Name = "CalendarControl";
            Size = new Size(1009, 460);
            Load += UserControl2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel daycontainer;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label Date1;
    }
}
