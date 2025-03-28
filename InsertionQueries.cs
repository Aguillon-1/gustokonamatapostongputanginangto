using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Classroom_Management_System
{
    class InsertionQueries
    {
        public bool IsUserSignedUp(string email)
        {
            string query = "SELECT COUNT(*) FROM user_information WHERE email = @Email";
            using (var connection = DatabaseConn.GetConnection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void InsertDatafromgoogle(string name, string email)
        {
            Debug.WriteLine("Insert query initiated");

            if (IsUserSignedUp(email))
            {
                Debug.WriteLine("User already signed up, proceeding to credentials form");

                
                return;
            }

            string query = "INSERT INTO user_information(first_name, middle_name, last_name, email, birth_date, address, program, year, section, account_type, regular, date_created, username, password, is_registered)" +
                           "VALUES (@first_name, @middle_name, @last_name, @email, @birth_date, @address, @program, @year, @section, @account_type, @regular, @date_created, @username, @password, @is_registered)";

            using (var connection = DatabaseConn.GetConnection())
            {
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@first_name", name);
                        command.Parameters.AddWithValue("@middle_name", DBNull.Value);
                        command.Parameters.AddWithValue("@last_name", DBNull.Value);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@birth_date", DBNull.Value);
                        command.Parameters.AddWithValue("@address", DBNull.Value);
                        command.Parameters.AddWithValue("@program", DBNull.Value);
                        command.Parameters.AddWithValue("@year", DBNull.Value);
                        command.Parameters.AddWithValue("@section", DBNull.Value);
                        command.Parameters.AddWithValue("@account_type", DBNull.Value);
                        command.Parameters.AddWithValue("@regular", DBNull.Value);
                        command.Parameters.AddWithValue("@date_created", DBNull.Value);
                        command.Parameters.AddWithValue("@username", DBNull.Value);
                        command.Parameters.AddWithValue("@password", DBNull.Value);
                        command.Parameters.AddWithValue("@is_registered", 0);

                        command.ExecuteNonQuery();

                        Debug.WriteLine("Data inserted successfully");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error inserting data: {ex.Message}");
                }
            }
        }
    }

}

