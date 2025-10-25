using System;
using System.Data;
using System.Data.SqlClient;
using TaskManagementApp;

public static class DatabaseHelper
{

    private static readonly string connectionString = DatabaseConfig.ConnectionString;

    public static void ExecuteNonQuery(string query, Action<SqlCommand> parameterizeCommand)
    {
        ExecuteCommand(query, cmd =>
        {
            parameterizeCommand?.Invoke(cmd);
            cmd.ExecuteNonQuery();
        });
    }

    public static object ExecuteScalar(string query, Action<SqlCommand> parameterizeCommand)
    {
        object result = null;
        ExecuteCommand(query, cmd =>
        {
            parameterizeCommand?.Invoke(cmd);
            result = cmd.ExecuteScalar();
        });
        return result;
    }

    public static DataTable ExecuteQuery(string query, Action<SqlCommand> parameterizeCommand = null)
    {
        DataTable dataTable = new DataTable();
        ExecuteCommand(query, cmd =>
        {
            parameterizeCommand?.Invoke(cmd);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }
        });
        return dataTable;
    }

    private static void ExecuteCommand(string query, Action<SqlCommand> execute)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                execute(cmd);
            }
        }
    }
}
