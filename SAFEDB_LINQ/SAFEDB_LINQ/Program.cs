using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SAFEDB_LINQ
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginform());
        
        }

    }
}

public static class DatabaseManager
{
    private static readonly string connectionString = "Data Source=MYPC\\SQLEXPRESS;Initial Catalog=MAS_DATA;Integrated Security=True";
    public  static SqlConnection connection;

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