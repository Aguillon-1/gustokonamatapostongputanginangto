using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class ExtraInformation : UserControl
    {
        public ExtraInformation()
        {
            InitializeComponent();
            AddChoices();
        }

        private void AddChoices()
        {
            // Add choices to ComboBoxes
            Course_select.Items.Add("BS in Computer Science");
            year_level_select.Items.Add("Second");
            section_select.Items.Add("B");

            Course_select.SelectedIndex = 0;
            year_level_select.SelectedIndex = 0;
            section_select.SelectedIndex = 0;
        }

        public void SubmitInformation()
        {
            var studentNo = studentno_textbox.Text;
            var selectedCourse = Course_select.SelectedItem?.ToString();
            var selectedYearLevel = year_level_select.SelectedItem?.ToString();
            var selectedSection = section_select.SelectedItem?.ToString();

            InsertUserInformation(studentNo, selectedCourse, selectedYearLevel, selectedSection);
        }

        private void InsertUserInformation(string studentNo, string selectedCourse, string selectedYearLevel, string selectedSection)
{
    try
    {
        // Get the logged-in user's username
        var session = SessionManager.LoadSession();
        if (session == null)
        {
            Debug.WriteLine("Session is null.");
            return;
        }

        var username = session.Username;
        if (username == null)
        {
            Debug.WriteLine("Username is null.");
            return;
        }

        // Create the SQL connection
        var connection = DatabaseConn.GetConnection();
        if (connection == null)
        {
            Debug.WriteLine("Database connection is null.");
            return;
        }

        using (connection)
        {
            // Insert user information
            var insertQuery = @"
                INSERT INTO [dbo].[user_information] 
                ([student_no], [program_id], [year_level_id], [section_id], [username]) 
                VALUES 
                (@studentNo, 
                (SELECT [program_id] FROM [dbo].[programs] WHERE [program_name] = @selectedCourse), 
                (SELECT [year_level_id] FROM [dbo].[year_levels] WHERE [year_level] = @selectedYearLevel), 
                (SELECT [sections_id] FROM [dbo].[sections] WHERE [section_name] = @selectedSection), 
                @username)";
            using (var insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@studentNo", studentNo);
                insertCommand.Parameters.AddWithValue("@selectedCourse", selectedCourse);
                insertCommand.Parameters.AddWithValue("@selectedYearLevel", selectedYearLevel);
                insertCommand.Parameters.AddWithValue("@selectedSection", selectedSection);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.ExecuteNonQuery();
                Debug.WriteLine("User information inserted successfully.");
            }
        }
    }
    catch (Exception ex)
    {
        Debug.WriteLine($"An error occurred: {ex.Message}");
    }
}

        private void Course_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when a new item is selected in the Course_select ComboBox
        }

        private void year_level_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when a new item is selected in the year_level_select ComboBox
        }

        private void section_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the event when a new item is selected in the section_select ComboBox
        }
    }
}
