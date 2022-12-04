using Microsoft.Data.SqlClient;
using System;

namespace Unitess_test_app.DAL.DataContext
{
    public class DbContext 
    {
        public const string ConnectionStrings = "ConnectionStrings";

        public static string DefaultConnection { get; set; } = String.Empty;

        public static SqlConnection Connection()
        {
            return new SqlConnection(DefaultConnection);
        }
    }
}
