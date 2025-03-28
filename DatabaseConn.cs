using System;
using System.Data.SqlClient;
using System.Diagnostics;

public class DatabaseConn
{
    private const string ConnectionString = "Server=tcp:classroom-management-system-server.database.windows.net,1433;Initial Catalog=Classroom-Management-System;Persist Security Info=False;User ID=CMSbscs2badmin;Password=CSMbscs2b2024;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    

    public static SqlConnection GetConnection()
    {
        var connection = new SqlConnection(ConnectionString);
        try
        {
            connection.Open();
            Debug.WriteLine("Connection established successfully.");
        }
        catch (Exception)
        {
            Debug.WriteLine("Error establishing connection");
        }
        return connection;
    }
}
