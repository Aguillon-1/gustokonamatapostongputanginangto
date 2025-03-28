using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom_Management_System
{
    class Retrievalclass
    {
        public void Retrievaldata(string name, string email)
        {
            /*
            Debug.WriteLine("Insert query initiated");


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
            }*/
        }
    }
}
