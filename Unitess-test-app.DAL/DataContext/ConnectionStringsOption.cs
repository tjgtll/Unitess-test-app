using System;

namespace Unitess_test_app.DAL.DataContext
{
    public class ConnectionStringsOption
    {
        public const string ConnectionStrings = "ConnectionStrings";

        public string DefaultConnection { get; set; } = String.Empty;
    }
}
