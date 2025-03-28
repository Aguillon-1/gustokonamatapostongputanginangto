namespace Classroom_Management_System
{
    partial class ExtraInformation
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
            studentno_textbox = new TextBox();
            label3 = new Label();
            Course_select = new ComboBox();
            year_level_select = new ComboBox();
            label4 = new Label();
            section_select = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 24);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "Extra Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 73);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 1;
            label2.Text = "Student Number:";
            // 
            // studentno_textbox
            // 
            studentno_textbox.Location = new Point(37, 97);
            studentno_textbox.Name = "studentno_textbox";
            studentno_textbox.Size = new Size(167, 23);
            studentno_textbox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 73);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 3;
            label3.Text = "Course:";
            // 
            // Course_select
            // 
            Course_select.FormattingEnabled = true;
            Course_select.Location = new Point(243, 97);
            Course_select.Name = "Course_select";
            Course_select.Size = new Size(251, 23);
            Course_select.TabIndex = 4;
            Course_select.SelectedIndexChanged += Course_select_SelectedIndexChanged;
            // 
            // year_level_select
            // 
            year_level_select.FormattingEnabled = true;
            year_level_select.Location = new Point(243, 154);
            year_level_select.Name = "year_level_select";
            year_level_select.Size = new Size(119, 23);
            year_level_select.TabIndex = 6;
            year_level_select.SelectedIndexChanged += year_level_select_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(243, 130);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 5;
            label4.Text = "Year:";
            // 
            // section_select
            // 
            section_select.FormattingEnabled = true;
            section_select.Location = new Point(375, 154);
            section_select.Name = "section_select";
            section_select.Size = new Size(119, 23);
            section_select.TabIndex = 8;
            section_select.SelectedIndexChanged += section_select_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(375, 130);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 7;
            label5.Text = "Section:";
            // 
            // ExtraInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.container;
            Controls.Add(section_select);
            Controls.Add(label5);
            Controls.Add(year_level_select);
            Controls.Add(label4);
            Controls.Add(Course_select);
            Controls.Add(label3);
            Controls.Add(studentno_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExtraInformation";
            Size = new Size(604, 273);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox studentno_textbox;
        private Label label3;
        private ComboBox Course_select;
        private ComboBox year_level_select;
        private Label label4;
        private ComboBox section_select;
        private Label label5;
    }
}
