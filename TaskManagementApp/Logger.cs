using System;
using System.Data.SqlClient;
using System.Data;

public static class Logger
{
    private static string connectionString = ""; //use your database string here

    public static void WriteLog(string eventType, string details)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Logs (EventType, Details) VALUES (@eventType, @details)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventType", eventType);
                    cmd.Parameters.AddWithValue("@details", details);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing log: " + ex.Message);
            }
        }
    }

    public static DataTable GetLogs()
    {
        DataTable logTable = new DataTable();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "SELECT LogID, EventTime, EventType, Details FROM Logs ORDER BY EventTime DESC";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(logTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching logs: " + ex.Message);
            }
        }
        return logTable;
    }
}
