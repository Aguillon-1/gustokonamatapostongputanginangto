using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Classroom_Management_System
{
    public partial class CalendarAddEvent : Form
    {
        private const string ConnectionString = "Server=tcp:classroom-management-system-server.database.windows.net,1433;Initial Catalog=Classroom-Management-System;Persist Security Info=False;User ID=CMSbscs2badmin;Password=CSMbscs2b2024;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private DateTime selectedDate;

        public CalendarAddEvent(DateTime date)
        {
            InitializeComponent();
            selectedDate = date;
            textBox1.Text = selectedDate.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eventDescription = textBox2.Text;

            if (string.IsNullOrEmpty(eventDescription))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Events (EventDate, EventDescription) VALUES (@EventDate, @EventDescription)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EventDate", selectedDate);
                        command.Parameters.AddWithValue("@EventDescription", eventDescription);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error adding event.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void CalendarAddEvent_Load(object sender, EventArgs e)
        {

        }
    }
}