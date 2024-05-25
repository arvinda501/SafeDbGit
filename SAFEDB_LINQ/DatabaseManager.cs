using System;
using System.Data.SqlClient;

public static class DatabaseManager
{
    private static readonly string connectionString = "Data Source=MYPC\\SQLEXPRESS;Initial Catalog=MAS_DATA;Integrated Security=True";
    private static SqlConnection connection;

    public static SqlConnection GetConnection()
    {
        if (connection == null)
        {
            connection = new SqlConnection(connectionString);
        }

        return connection;
    }

    public static void OpenConnection()
    {
        if (connection == null)
        {
            connection = new SqlConnection(connectionString);
        }

        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
    }

    public static void CloseConnection()
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }
}
